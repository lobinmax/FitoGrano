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
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using FitoGrano;

namespace FitoGrano
{
	
	public partial class frAddEditContact //W = 235; H = 142
	{
		public frAddEditContact()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frAddEditContact defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frAddEditContact Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frAddEditContact();
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
		internal int AddEdit = 2;
		DataRowView iRowCurrent;
		string ContactId = "NULL";
		// Таскание формы за любой участок
		public void Control_MouseDown(dynamic sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == System.Windows.Forms.MouseButtons.Left)
			{
				this.Cursor = Cursors.NoMove2D;
				sender.Capture = false;
				Windows.Forms.Message temp_msg = Message.Create(this.Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
				this.WndProc(ref temp_msg);
				this.Cursor = Cursors.Default;
			}
		}
		// Закрытие формы
		public void frAddEditContact_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Dispose();
		}
		//Загрузка формы
		public void frAddEditContact_Load(object sender, EventArgs e)
		{
			if (Information.IsNumeric(frAddEditPerformer.Default.PerformerId) == false)
			{
				XtraMessageBox.Show("Не удалось определить пользователя, для добавления контакта ...",
					Application.ProductName,
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				this.Close();
			}
			if (AddEdit == 3)
			{
				this.lbNameForm.Text = "Редактировать контакт";
				iRowCurrent = (DataRowView) frAddEditPerformer.Default.lbxContacts.SelectedItem;
				ContactId = System.Convert.ToString(clsForSQL.OutDataBase(iRowCurrent["ContactId"]));
			}
			this.Location = MousePosition;
			rgContactsTypes_SelectedIndexChanged(this.rgContactsTypes, e);
			this.txtPhoneNumber.Text = System.Convert.ToString(iRowCurrent != null ? (clsForSQL.OutDataBase(iRowCurrent["Number"])) : "");
			this.rgContactsTypes.SelectedIndex = System.Convert.ToInt32(iRowCurrent != null ? (clsForSQL.OutDataBase(iRowCurrent["ContactTypeId"])) : 0);
			this.txtPhoneNumber.Select();
		}
		// Добавление новой записи
		public void btnOk_Click(object sender, EventArgs e)
		{
			string _ContactId = "";
			if (clsForSQL.InDataBase(this.txtPhoneNumber.Text) == "NULL")
			{
				return;
			}
			_ContactId = System.Convert.ToString(mdQuery.ExecuteScalar(
				"EXEC PerformersContactsFunction " +
				"@ContactId = " + ContactId + ", " +
				"@PerformerId = " + frAddEditPerformer.Default.PerformerId + ", " +
				"@ContactTypeId = " + System.Convert.ToString(this.rgContactsTypes.SelectedIndex) + ", " +
				"@Number = " + clsForSQL.InDataBase(this.txtPhoneNumber.Text) + ", " +
				"@Function = " + System.Convert.ToString(AddEdit), System.Convert.ToString((AddEdit == 2 ? "Add" : "Edit") + "PerformerContact")
				));
			switch (AddEdit)
			{
				case 2:
					if (_ContactId != "err" && _ContactId != null)
					{
						frAddEditPerformer.Default.NewRecord_Contact = _ContactId;
						this.DialogResult = DialogResult.OK;
					}
					break;
				case 3:
					if (_ContactId != "err" && _ContactId != null)
					{
						if (System.Convert.ToBoolean(_ContactId))
						{
							this.DialogResult = DialogResult.OK;
						}
					}
					break;
			}
		}
		//Отмена
		public void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}
		// Очистить поле
		public void txtPhoneNumber_Properties_ButtonClick(dynamic sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
		{
			EditorButton btn = e.Button;
			if (btn.Index == 0)
			{
				sender.Text = "";
			}
		}
		// смена типа контакта
		public void rgContactsTypes_SelectedIndexChanged(dynamic sender, EventArgs e)
		{
			// получаем иконку из ресурсов по имени
			System.Drawing.Image img = global::My.Resources.Resources.ResourceManager.GetObject(System.Convert.ToString(this.rgContactsTypes.Properties.Items[this.rgContactsTypes.SelectedIndex].Value.ToString()));
			string maskedit = System.Convert.ToString(sender.Properties.Items.Item(this.rgContactsTypes.SelectedIndex).Tag.ToString()); // текст маски
			this.txtPhoneNumber.Properties.ContextImageOptions.Image = img; // меняем иконку на поле
			if (string.IsNullOrEmpty(maskedit))
			{
				this.txtPhoneNumber.Properties.Mask.EditMask = "";
				this.txtPhoneNumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
			}
			else
			{
				this.txtPhoneNumber.Properties.Mask.EditMask = maskedit;
				this.txtPhoneNumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
			}
		}
	}
}
