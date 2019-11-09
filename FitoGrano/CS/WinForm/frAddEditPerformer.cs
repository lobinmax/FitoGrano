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

using System.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using FitoGrano;

namespace FitoGrano
{
	
	public partial class frAddEditPerformer
	{
		public frAddEditPerformer()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frAddEditPerformer defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frAddEditPerformer Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frAddEditPerformer();
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
		internal int AddOrEdit = 2;
		internal string PerformerId = "NULL";
		internal DateTime NewRecord_HistoryRoleJobs; // Дата добавленной записи в историю должностей
		internal string NewRecord_Contact; // ид добавленнго контакта
		DataRow iCurrentRow;
		// закрытие формы
		public void frAddEditPerformer_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this.gvHistoryRoleJobs.RowCount == 0 && PerformerId != "NULL")
			{
				XtraMessageBox.Show("Форма не может быть закрыта, т.к. сотруднику не назначена должность!",
					Application.ProductName,
					MessageBoxButtons.OK,
					MessageBoxIcon.Stop);
				e.Cancel = true;
				return;
			}
			clsMyUserFunction.RemoveTableDataSet(this);
		}
		// загрузка формы
		public void frAddEditPerformer_Load(System.Object sender, System.EventArgs e)
		{
			switch (AddOrEdit)
			{
				case 2:
					this.Text = "Добавить исполнителя базы данных";
					break;
				case 3:
					this.Text = "Редактировать исполнителя базы данных";
					iCurrentRow = frSecurityUsers.Default.gvPerformers.GetFocusedDataRow();
					PerformerId = System.Convert.ToString(clsForSQL.OutDataBase(iCurrentRow["PerformerId"]));
					break;
			}
			
			ImageCollection ret = new ImageCollection();
			ret.ImageSize = new Size(16, 16);
			ret.AddImage(global::My.Resources.Resources.SexWomen_16x16);
			ret.AddImage(global::My.Resources.Resources.SexMen_16x16);
			this.cmdSex.Properties.SmallImages = ret;
			this.cmdSex.Properties.Items.AddEnum<mdVariables.SexType>();
			
			this.txtLogin.EditValue = iCurrentRow != null ? (iCurrentRow["Login"]) : "";
			this.txtPassword1.EditValue = iCurrentRow != null ? (iCurrentRow["Password"]) : "";
			this.txtPassword2.EditValue = iCurrentRow != null ? (iCurrentRow["Password"]) : "";
			this.txtSurname.EditValue = iCurrentRow != null ? (iCurrentRow["Surname"]) : "";
			this.txtName.EditValue = iCurrentRow != null ? (iCurrentRow["Name"]) : "";
			this.txtPatronymic.EditValue = iCurrentRow != null ? (iCurrentRow["Patronymic"]) : "";
			this.txtAddress.EditValue = iCurrentRow != null ? (iCurrentRow["Address"]) : "";
			this.txtDtBirth.EditValue = iCurrentRow != null ? (iCurrentRow["DtBirth"]) : "";
			this.txtRoomNumber.EditValue = iCurrentRow != null ? (iCurrentRow["RoomNumber"]) : "";
			this.cmdSex.SelectedIndex = System.Convert.ToInt32(iCurrentRow != null ? (iCurrentRow["SexId"]) : 1);
			this.txtEmail.EditValue = iCurrentRow != null ? (iCurrentRow["Email"]) : "";
			
			DesignerPerformerContacts(); // контакты пользователя
			DesignerHistoryRoleJobs(); // история должностных обязанностей
			
			// Группы пользователей
			//FALSE' ELSE 'TRUE' END  AS BIT) AS Checked
			dbo.vPerformersRightGroupsprg, GetPerformersRightGroups;
			);
			this.lbxPerfGroups.DataSource = mdQuery.iDataSet.Tables["PerformersRightGroups." + this.Name];
			this.lbxPerfGroups.DisplayMember = "Name";
			this.lbxPerfGroups.ValueMember = "Id";
			this.lbxPerfGroups.CheckMember = "Checked";
			this.txtLogin.Select();
		}
		
#region Дизайнеры
		// дизайнер истории должностей
		private void DesignerHistoryRoleJobs()
		{
			mdQuery.SelectQueryData(
				"HistoryRoleJobs." + this.Name,
				"EXEC PerformersHistoryRJFuction @PerformerId = " + PerformerId + ", @Function = 1",
				"GetHistoryRoleJobs"
				);
			if (ReferenceEquals(this.gcHistoryRoleJobs.DataSource, null))
			{
				this.gcHistoryRoleJobs.DataSource = mdQuery.iDataSet.Tables["HistoryRoleJobs." + this.Name];
				this.gvHistoryRoleJobs.PopulateColumns(mdQuery.iDataSet.Tables["HistoryRoleJobs." + this.Name]);
				this.gvHistoryRoleJobs.Columns["DtChange"].Caption = "Дата";
				this.gvHistoryRoleJobs.Columns["RoleJobsId"].Visible = false;
				this.gvHistoryRoleJobs.Columns["RoleJobs"].Caption = "Наименование должности";
				this.gvHistoryRoleJobs.Columns["DtUpdate"].Caption = "Изменено";
				this.gvHistoryRoleJobs.Columns["Updater"].Caption = "Автор";
				this.gvHistoryRoleJobs.BestFitColumns();
			}
			// сортировка таблицы через датасет
			clsMyUserFunction.SortDataTable(mdQuery.iDataSet.Tables["HistoryRoleJobs." + this.Name], "DtChange");
			// фокус на строку по Дате
			this.gvHistoryRoleJobs.FocusedRowHandle = this.gvHistoryRoleJobs.LocateByValue("DtChange", NewRecord_HistoryRoleJobs);
		}
		// дизайнер контактов пользователя
		private void DesignerPerformerContacts()
		{
			mdQuery.SelectQueryData(
				"PerformersContacts." + this.Name,
				"EXEC PerformersContactsFunction @PerformerId = " + PerformerId + ", @Function = 1",
				"GetPerformersContacts"
				);
			if (ReferenceEquals(this.lbxContacts.DataSource, null))
			{
				this.lbxContacts.DataSource = mdQuery.iDataSet.Tables["PerformersContacts." + this.Name];
				this.lbxContacts.DisplayMember = "NumberString";
			}
		}
#endregion
		
#region Контакты пользователя
		// добавить контакт пользователя
		public void gcContacts_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
		{
			if (e.Button.Properties.Caption == "btnAddContact")
			{
				if (frAddEditContact.Default.ShowDialog() == DialogResult.OK)
				{
					DesignerPerformerContacts();
				}
			}
		}
		// редактировать и удалить контакт пользователя
		public void lbxContacts_ContextButtonClick(object sender, DevExpress.Utils.ContextItemClickEventArgs e)
		{
			ContextButton btn = (ContextButton) e.Item;
			switch (btn.Name)
			{
				case "btnEditPerfPhone": // Редактировать
					frAddEditContact.Default.AddEdit = 3;
					if (frAddEditContact.Default.ShowDialog() == DialogResult.OK)
					{
						DesignerPerformerContacts();
					}
					break;
				case "btnDelPerfPhone": // Удалить
					DataRowView iRow = (DataRowView) lbxContacts.SelectedItem;
					if (XtraMessageBox.Show("Выбранный контакт пользователя <b><u>" + System.Convert.ToString(iRow["ContactType"]) + " - " + System.Convert.ToString(iRow["Number"]) + "</u></b> будет удален!" + "\n" +
							"Вы согласны?",
							Application.ProductName,
							MessageBoxButtons.YesNo,
							MessageBoxIcon.Question,
							DefaultBoolean.True) == DialogResult.Yes)
							{
							if (mdQuery.ExecuteScalar("EXEC PerformersContactsFunction " +
									"@ContactId = " + System.Convert.ToString(iRow["ContactId"]) + ", " +
									"@Function = 4"))
									{
									DesignerPerformerContacts();
						}
					}
					break;
			}
		}
		// движение по контактам пользователя для отображения типа контакта
		public void lbxContacts_MouseMove(object sender, MouseEventArgs e)
		{
			ListBoxControl listBoxControl = sender as ListBoxControl;
			int index = listBoxControl.IndexFromPoint(new Point(e.X, e.Y));
			if (index != -1)
			{
				string item = System.Convert.ToString(mdQuery.iDataSet.Tables["PerformersContacts." + this.Name].Rows[index]["ContactType"]); //TryCast(listBoxControl.GetItem(index), String)
				ToolTipController1.SetAllowHtmlText(listBoxControl, DefaultBoolean.True);
				ToolTipController1.ShowHint(item, listBoxControl.PointToScreen(new Point(e.X, e.Y)));
			}
			else
			{
				ToolTipController1.HideHint();
			}
		}
		// уход курсора от контактов пользователя
		public void lbxContacts_MouseLeave(object sender, EventArgs e)
		{
			ToolTipController1.HideHint();
		}
#endregion
		
#region История должностных обязанностей
		// добавить должность
		public void btnAddRoleJobs_Click(object sender, EventArgs e)
		{
			if (frAddEditHistoryRoleJobs.Default.ShowDialog() == DialogResult.OK)
			{
				DesignerHistoryRoleJobs();
			}
		}
		// редактировать должность
		public void btnEditRoleJobs_Click(object sender, EventArgs e)
		{
			frAddEditHistoryRoleJobs.Default.AddEdit = 3;
			if (frAddEditHistoryRoleJobs.Default.ShowDialog() == DialogResult.OK)
			{
				DesignerHistoryRoleJobs();
			}
		}
		// удалить должность
		public void btnDeleteRoleJobs_Click(object sender, EventArgs e)
		{
			if (XtraMessageBox.Show("Выбранная запись будет удалена!" + "\n" +
					"Вы согласны?",
					Application.ProductName,
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question) == DialogResult.Yes)
					{
					if (ExecuteScalar(
							EXEC PerformersHistoryRJFuction
							@PerformerId == " & PerformerId & ",
							@DtChange == " & clsForSQL.InDataBase(Me.gvHistoryRoleJobs.GetFocusedRowCellDisplayText(" DtChange ")) & ",
							@Function == 4,
							"DeleteRoleJob"
							) == 1)
							{
							DesignerHistoryRoleJobs();
				}
			}
		}
#endregion
		
		// таймер проверки полей
		public void tmrCheckedFields_Tick(object sender, EventArgs e)
		{
			// если обязательные поля не заполнены
			if (clsForSQL.InDataBase(this.txtLogin.Text) == "NULL" ||
					clsForSQL.InDataBase(this.txtPassword1.Text) == "NULL" ||
					clsForSQL.InDataBase(this.txtPassword2.Text) == "NULL" ||
					clsForSQL.InDataBase(this.txtSurname.Text) == "NULL" ||
					clsForSQL.InDataBase(this.txtName.Text) == "NULL" ||
					clsForSQL.InDataBase(this.txtPatronymic.Text) == "NULL" ||
					this.lbxPerfGroups.CheckedItemsCount == 0 ||
					this.txtPassword1.ErrorText != "" ||
					this.txtPassword2.ErrorText != "")
					{
					this.btnSave.Enabled = false; // нельзя сохранить
					this.btnOk.Enabled = false;
			}
			else
			{
				this.btnSave.Enabled = true; // можно сохранить
				this.btnOk.Enabled = PerformerId != "NULL" && this.gvHistoryRoleJobs.RowCount != 0;
			}
			// редактировать и удалить дожность если только есть записи
			this.btnEditRoleJobs.Enabled = this.gvHistoryRoleJobs.RowCount != 0;
			this.btnDeleteRoleJobs.Enabled = this.gvHistoryRoleJobs.RowCount != 0;
			// активность кнопок если пользователь еже создан
			this.gcContacts.Enabled = PerformerId != "NULL";
			this.gcHistoryRoleJobs.Enabled = PerformerId != "NULL";
			this.btnAddRoleJobs.Enabled = PerformerId != "NULL";
		}
		// получение ид выбранных групп работников
		private string GetSelectedGroups()
		{
			string text = string.Empty;
			foreach (object item in this.lbxPerfGroups.CheckedItems)
			{
				DataRowView row = item as DataRowView;
				text += string.Format("{0},", row["Id"]);
			}
			return text.TrimEnd(",".ToCharArray());
		}
		// проверка совпадения паролей при выходе из поля
		public void txtPassword2_Properties_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			CheckedPassword();
		}
		// проверка совпадения паролей
		private void CheckedPassword()
		{
			if (System.Convert.ToDouble(this.txtPassword1.EditValue) != System.Convert.ToDouble(this.txtPassword2.EditValue))
			{
				this.txtPassword1.ErrorText = "Пароль не совпадают ...";
				this.txtPassword2.ErrorText = "Пароль не совпадают ...";
				this.btnSave.Enabled = false;
			}
			else
			{
				this.txtPassword1.ErrorText = null;
				this.txtPassword2.ErrorText = null;
			}
		}
		// проверка совпадения паролей при вводе значений
		public void txtPassword2_TextChanged(object sender, EventArgs e)
		{
			CheckedPassword();
		}
		// кнопка сохранить и Ок
		public void btnSave_Click(dynamic sender, EventArgs e)
		{
			string perf = "";
			perf = System.Convert.ToString(mdQuery.ExecuteScalar(
				"EXEC PerformersFunctions " +
				"@PerformerId = " + PerformerId + ", " +
				"@Login = " + clsForSQL.InDataBase(this.txtLogin.Text) + ", " +
				"@Password = " + clsForSQL.InDataBase(this.txtPassword1.Text) + ", " +
				"@Surname = " + clsForSQL.InDataBase(this.txtSurname.Text) + ", " +
				"@Name = " + clsForSQL.InDataBase(this.txtName.Text) + ", " +
				"@Patronymic = " + clsForSQL.InDataBase(this.txtPatronymic.Text) + ", " +
				"@Address = " + clsForSQL.InDataBase(this.txtAddress.Text) + ", " +
				"@DtBirth = " + clsForSQL.InDataBase(this.txtDtBirth.Text) + ", " +
				"@RoomNumber = " + clsForSQL.InDataBase(this.txtRoomNumber.Text) + ", " +
				"@PerformersGroups = " + clsForSQL.InDataBase(GetSelectedGroups()) + ", " +
				"@SexId = " + clsForSQL.InDataBase(this.cmdSex.SelectedIndex) + ", " +
				"@Email = " + clsForSQL.InDataBase(this.txtEmail.Text) + ", " +
				"@Function = " + System.Convert.ToString(AddOrEdit),
				"CreateUser"
				));
			if (perf != "err" && perf != null)
			{
				PerformerId = perf;
				frSecurityUsers.Default.NewRecord_PerformeId = perf;
				if (AddOrEdit == 2)
				{
					XtraMessageBox.Show("Логин <b>" + this.txtLogin.Text + "</b> успешно добавлен в базу данных <b>" + mdVariables.pref_DataBaseName + "</b>!" + "\n" +
						"Теперь необходимо присвоить сотруднику должность ...",
						Application.ProductName,
						MessageBoxButtons.OK,
						MessageBoxIcon.Information,
						DefaultBoolean.True);
					AddOrEdit = 3;
				}
				// закрытие формы только по кнопке Ок
				if (sender.Name == "btnOk")
				{
					this.DialogResult = DialogResult.OK;
				}
			}
		}
		// выделение текста в полях при входе
		public void txtLogin_Enter(dynamic sender, EventArgs e)
		{
			sender.SelectAll();
		}
		// очищение текста в полях
		public void txtLogin_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
		{
			EditorButton btn = e.Button;
			if (btn.Caption != "")
			{
				this.Controls[btn.Caption].Text = null;
			}
		}
	}
}
