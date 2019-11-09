// VBConversions Note: VB project level imports
using System.Collections.Generic;
using System;
using System.Linq;
using System.Drawing;
using System.Diagnostics;
using Microsoft.VisualBasic;
using System.Xml.Linq;
using System.Windows.Forms;
// End of VB project level imports

using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using System.Globalization;
using System.IO;
using FitoGrano;

namespace FitoGrano
{
	
	public partial class frLogin
	{
		
#region Default Instance
		
		private static frLogin defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frLogin Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frLogin();
					defaultInstance.FormClosed += new System.Windows.Forms.FormClosedEventHandler(defaultInstance_FormClosed);
				}
				
				return defaultInstance;
			}
			set
			{
				defaultInstance = value;
			}
		}
		
		static void defaultInstance_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
		{
			defaultInstance = null;
		}
		
#endregion
		string PreferenceForms; // Ветка в реестре для хранения настроек формы
		string[] iRecords;
		string iRecord;
		static frLogin()
		{
			DevExpress.UserSkins.BonusSkins.Register();
			DevExpress.Skins.SkinManager.EnableFormSkins();
			mdVariables.iLookAndFeel.EnableBonusSkins = true; // Включаем бонусные скины
			DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = System.Convert.ToString(mdRegistrySetting.RegistryRead(mdVariables.pref_ComplexSettings, "SkinName", "Dark Side"));
		}
		public frLogin()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		// если есть обновленный стартер, удаляем старый, переименовываем новый
		private void UpgradeStarter()
		{
			try
			{
				if (File.Exists(Application.StartupPath + "\\FitoGranoStarter_New.exe"))
				{
					(new Microsoft.VisualBasic.Devices.ServerComputer()).FileSystem.DeleteFile(Application.StartupPath + "\\FitoGranoStarter.exe");
					(new Microsoft.VisualBasic.Devices.ServerComputer()).FileSystem.RenameFile(Application.StartupPath + "\\FitoGranoStarter_New.exe", "FitoGranoStarter.exe");
				}
			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message);
			}
		}
		// загрузка формы
		public void frLogin_Load(System.Object sender, System.EventArgs e)
		{
			System.Threading.Thread Th = new System.Threading.Thread(new System.Threading.ThreadStart(UpgradeStarter)); // Создание дилигата процесса обновления старта
			Th.Start(); // Запуск "обновления" Стартера в фоновом режиме
			// Параметры отображения формы
			PreferenceForms = mdVariables.pref_RegistryPath + this.Name + "\\"; // Путь к настройкам в реестре
			if ((int) mdRegistrySetting.RegistryRead(PreferenceForms, "IsShort", "0") == 1)
			{
				this.ClientSize = new Size(493, 260);
				this.FormIsShort.Image = global::My.Resources.Resources.up_20x20;
			}
			else
			{
				this.ClientSize = new Size(493, 203);
				this.FormIsShort.Image = global::My.Resources.Resources.down_20x20;
			}
			// Отображение пароля
			this.ChB_ShowPass.Checked = Convert.ToBoolean(Convert.ToInt32(mdRegistrySetting.RegistryRead(PreferenceForms, "ShowPass", "0")));
			
			// Заполнение основных полей
			iRecord = System.Convert.ToString(mdRegistrySetting.RegistryRead(PreferenceForms, "HistoryLogin", ""));
			if (!string.IsNullOrEmpty(iRecord))
			{
				iRecords = null;
				iRecords = iRecord.Split(",".ToCharArray());
				this.User.Properties.Items.AddRange(iRecords.Distinct().ToArray());
				this.User.SelectedIndex = 0;
			}
			
			iRecord = System.Convert.ToString(mdRegistrySetting.RegistryRead(PreferenceForms, "HistoryServer", ""));
			if (!string.IsNullOrEmpty(iRecord))
			{
				iRecords = null;
				iRecords = iRecord.Split(",".ToCharArray());
				this.Server.Properties.Items.AddRange(iRecords.Distinct().ToArray());
				this.Server.SelectedIndex = 0;
			}
			
			iRecord = System.Convert.ToString(mdRegistrySetting.RegistryRead(PreferenceForms, "HistoryBase", ""));
			if (!string.IsNullOrEmpty(iRecord))
			{
				iRecords = null;
				iRecords = iRecord.Split(",".ToCharArray());
				this.BD.Properties.Items.AddRange(iRecords.Distinct().ToArray());
				this.BD.SelectedIndex = 0;
			}
			
			this.Select();
			this.Focus();
			this.Pass.Select();
			this.Pass.Text = null; // Фокус на пароль
		}
		
		public void Cancel_Click(System.Object sender, System.EventArgs e)
		{
			Application.Exit();
		}
		
		public void ChB_ShowPass_CheckedChanged(dynamic sender, System.EventArgs e)
		{
			// Показывать или не показывать пароль
			if (sender.Checked == true)
			{
				this.Pass.Properties.PasswordChar = ' ';
			}
			if (sender.Checked == false)
			{
				this.Pass.Properties.PasswordChar = '\a';
			}
			mdRegistrySetting.RegistryWrite(PreferenceForms, "ShowPass", System.Convert.ToString(Convert.ToInt32(sender.Checked)));
		}
		
		public void ClearHistory_User(dynamic sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
		{
			EditorButton btn = e.Button;
			if (btn.Index == 1)
			{
				if (this.User.Properties.Items.Count != 0)
				{
					if (XtraMessageBox.Show("Вы действительно хотите очистить историю имен пользователей?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2
							) == System.Windows.Forms.DialogResult.Yes)
							{
							mdRegistrySetting.RegistryWrite(PreferenceForms, "HistoryLogin", "");
						sender.Properties.Items.Clear();
						sender.Text = "";
					}
				}
			}
		}
		public void ClearHistory_BD(dynamic sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
		{
			EditorButton btn = e.Button;
			if (btn.Index == 1)
			{
				if (sender.Properties.Items.Count != 0)
				{
					if (XtraMessageBox.Show("Вы действительно хотите очистить историю баз данных?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2
							) == System.Windows.Forms.DialogResult.Yes)
							{
							mdRegistrySetting.RegistryWrite(PreferenceForms, "HistoryBase", "");
						sender.Properties.Items.Clear();
						sender.Text = "";
					}
				}
			}
		}
		public void ClearHistory_Server(dynamic sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
		{
			EditorButton btn = e.Button;
			if (btn.Index == 1)
			{
				if (sender.Properties.Items.Count != 0)
				{
					if (XtraMessageBox.Show("Вы действительно хотите очистить историю имен срверов?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2
							) == System.Windows.Forms.DialogResult.Yes)
							{
							mdRegistrySetting.RegistryWrite(PreferenceForms, "HistoryServer", "");
						sender.Properties.Items.Clear();
						sender.Text = "";
					}
				}
			}
		}
		
		public void FormIsShort_Click(System.Object sender, System.EventArgs e)
		{
			if ((int) mdRegistrySetting.RegistryRead(PreferenceForms, "IsShort", "0") == 0)
			{
				mdRegistrySetting.RegistryWrite(PreferenceForms, "IsShort", "1");
				this.ClientSize = new Size(493, 260);
				this.FormIsShort.Image = global::My.Resources.Resources.up_20x20;
			}
			else
			{
				mdRegistrySetting.RegistryWrite(PreferenceForms, "IsShort", "0");
				this.ClientSize = new Size(493, 203);
				this.FormIsShort.Image = global::My.Resources.Resources.down_20x20;
			}
		}
		
		public void ok_Click(System.Object sender, System.EventArgs e)
		{
			string iRecord = ""; // Переменная для записи истории подключений к базе
			// Разделитель целой и дробной цасти
			mdVariables.DecSeporator = (new Microsoft.VisualBasic.Devices.Computer()).Info.InstalledUICulture.NumberFormat.NumberDecimalSeparator;
			// Меняем системный разделитель целой и дробной части
			CultureInfo inf = new CultureInfo(System.Threading.Thread.CurrentThread.CurrentCulture.Name);
			System.Threading.Thread.CurrentThread.CurrentCulture = inf;
			inf.NumberFormat.NumberDecimalSeparator = ".";
			
			//=================================
			// Если поля не заполнены выходим из процедуры
			if (this.Server.Text == "" ||
					this.User.Text == "" ||
					this.Pass.Text == "" ||
					this.BD.Text == "")
					{
					XtraMessageBox.Show("Для входа в базу данных <b><u>" + this.BD.Text + "</b></u> необходимо заполнить все поля!", "Заполнены не все поля...", MessageBoxButtons.OK, MessageBoxIcon.Error, DevExpress.Utils.DefaultBoolean.True);
				return; // Выход процедуры
			}
			// Попытка подключится к клиентской базе данных
			// Запись переменных настроек
			mdVariables.pref_ServerIP = this.Server.Text; // IP сервера
			mdVariables.pref_DataBaseName = this.BD.Text; // Имя БД
			mdVariables.pref_PerformerLogin = this.User.Text; // Логин пользователя
			
			try // Вызов процедуры подключения к базе данных
			{
				mdQuery.ConnectionToBase(mdVariables.pref_ServerIP,
					mdVariables.pref_PerformerLogin,
					this.Pass.Text,
					mdVariables.pref_DataBaseName);
				
				mdVariables.pref_PerformerId = System.Convert.ToString(clsForSQL.OutDataBase(mdQuery.ExecuteScalar("SELECT dbo.fnsGetPerformerId()")));
				mdVariables.pref_PerformerNameShort = System.Convert.ToString(clsForSQL.OutDataBase(mdQuery.ExecuteScalar("SELECT dbo.fnsGetShortSNP(" + mdVariables.pref_PerformerId + ", 0)")));
				mdVariables.pref_PerformerName = System.Convert.ToString(clsForSQL.OutDataBase(mdQuery.ExecuteScalar("SELECT SNP FROM vPerformers WHERE login = SYSTEM_USER")));
				mdVariables.pref_OrganizationFilial = System.Convert.ToString(clsForSQL.OutDataBase(mdQuery.ExecuteScalar("SELECT os.NameFilials FROM vOrganizationStructure os WHERE os.IsCurrent = 1 GROUP BY os.NameFilials")));
				
				if (ReferenceEquals(mdVariables.pref_PerformerId, null))
				{
					XtraMessageBox.Show("Соединение с базой данных <b>" + this.BD.Text + "</b> прошло успешно!" + "\n" +
						"Но пользователь <b>" + this.User.Text + "</b> не зарегистрирован в программном комплексе <b>" + Application.ProductName + "</b>!" + "\n" +
						"Обратитесь к администратору базы данных",
						Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error, DevExpress.Utils.DefaultBoolean.True);
					return;
				}
				// Запись истории логинов в реестр
				// Пользователь
				iRecord = "";
				if (this.User.Properties.Items.Count == 0)
				{
					iRecord = this.User.Text;
				}
				else
				{
					for (var i = 0; i <= this.User.Properties.Items.Count - 1; i++)
					{
						iRecord = iRecord + "," + this.User.Properties.Items[i].ToString();
					}
					iRecord = this.User.Text + iRecord;
				}
				mdRegistrySetting.RegistryWrite(PreferenceForms, "HistoryLogin", iRecord);
				
				// База данных
				iRecord = "";
				if (this.BD.Properties.Items.Count == 0)
				{
					iRecord = this.BD.Text;
				}
				else
				{
					for (var i = 0; i <= this.BD.Properties.Items.Count - 1; i++)
					{
						iRecord = iRecord + "," + this.BD.Properties.Items[i].ToString();
					}
					iRecord = this.BD.Text + iRecord;
				}
				mdRegistrySetting.RegistryWrite(PreferenceForms, "HistoryBase", iRecord);
				
				// Сервер
				iRecord = "";
				if (this.Server.Properties.Items.Count == 0)
				{
					iRecord = this.Server.Text;
				}
				else
				{
					for (var i = 0; i <= this.Server.Properties.Items.Count - 1; i++)
					{
						iRecord = iRecord + "," + this.Server.Properties.Items[i].ToString();
					}
					iRecord = this.Server.Text + iRecord;
				}
				mdRegistrySetting.RegistryWrite(PreferenceForms, "HistoryServer", iRecord);
				
				// Ветка в реестре для персональных настроек пользователя
				mdVariables.pref_UserSettings = mdVariables.pref_RegistryPath + "UserSettings\\" + mdVariables.pref_PerformerLogin + "\\";
				frMain.Default.Show(); // Запуск гравной формы программы
				frMain.Default.Text = "(" + this.User.Text + ") - " + " " + Application.ProductName +". Центр оценки качества зерна - Новороссийский филиал";
				// Информация в СтатусБар из настроек
				frMain.Default.lbDataBaseName.Caption = this.BD.Text;
				frMain.Default.lbServerName.Caption = this.Server.Text;
				frMain.Default.lbUserName.Caption = mdVariables.pref_PerformerNameShort;
				frMain.Default.lbDivisionName.Caption = mdVariables.pref_OrganizationFilial;
				this.Close(); // Закрытие формы входа
				
			}
			catch (Exception ex) // При неудачной попытки
			{
				this.Pass.Text = "";
				this.Pass.Select();
				// Сообщение при неудачном подключении к базе данных
				XtraMessageBox.Show(ex.Message + "\n" + "Обратитесь к системному администратору...", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
	
}
