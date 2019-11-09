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

using System.ComponentModel;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraTreeList.Nodes;
using FitoGrano;

namespace FitoGrano
{
	
	public partial class frAddEditOrganizations
	{
		public frAddEditOrganizations()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frAddEditOrganizations defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frAddEditOrganizations Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frAddEditOrganizations();
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
		string Id = "NULL"; // Ид текущей записи
		internal int AddOrEdit = 2;
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
		public void FrAddEditOrganizations_Closing(object sender, CancelEventArgs e)
		{
			this.Dispose();
		}
		// Загрузка формы
		public void FrAddEditOrganizations_Load(object sender, EventArgs e)
		{
			TreeListNode curNode = frBooks_OrganizationStructure.Default.tlStructure.FocusedNode;
			if (AddOrEdit == 3)
			{
				Id = System.Convert.ToString(curNode["Id"]);
				this.txtNameOrganization.Text = System.Convert.ToString(curNode["Name"]);
				this.txtAddressOrganization.Text = System.Convert.ToString(curNode["Address"]);
				this.txtManagerOrganization.Text = System.Convert.ToString(curNode["Manager"]);
				this.txtEmailOrganization.Text = System.Convert.ToString(curNode["Email"]);
				this.txtPhoneOrganization.Text = System.Convert.ToString(curNode["Phones"]);
				this.txtNote.Text = System.Convert.ToString(curNode["Notes"]);
			}
			this.txtNameOrganization.Select();
		}
		// Добавление или изменение
		public void btnOk_Click(object sender, EventArgs e)
		{
			string NewId = "Nothing";
			if (CheckeFeilds() == false)
			{
				return;
			}
			NewId = System.Convert.ToString(mdQuery.ExecuteScalar(
				"EXEC OrganizationStructureFunction " +
				"@Id = " + Id + ", " +
				"@Name = " + clsForSQL.InDataBase(this.txtNameOrganization.Text) + ", " +
				"@Address = " + clsForSQL.InDataBase(this.txtAddressOrganization.Text) + ", " +
				"@Manager = " + clsForSQL.InDataBase(this.txtManagerOrganization.Text) + ", " +
				"@Email = " + clsForSQL.InDataBase(this.txtEmailOrganization.Text) + ", " +
				"@Phone = " + clsForSQL.InDataBase(this.txtPhoneOrganization.Text) + ", " +
				"@Notes = " + clsForSQL.InDataBase(this.txtNote.Text) + ", " +
				"@Level = 1, " +
				"@Function = " + System.Convert.ToString(AddOrEdit),
				"EXEC OrganizationStructureFunction. @Function = 2"
				));
			if (NewId != null && AddOrEdit == 2 && NewId != "err")
			{
				mdVariables.glNewId = NewId;
				this.DialogResult = DialogResult.OK;
			}
			if (ReferenceEquals(NewId, null) && AddOrEdit == 3)
			{
				this.DialogResult = DialogResult.OK;
			}
			
			if (NewId == "err")
			{
				return;
			}
		}
#region Очистка полей
		public void txtNameOrganization_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
		{
			EditorButton btn = e.Button;
			string btnCapt = btn.Caption;
			this.PanelControl1.Controls[btnCapt].Text = null;
		}
		public void btnClearNotes_Click(object sender, EventArgs e)
		{
			this.txtNote.Text = null;
		}
#endregion
		// Проверка заполнения полей
		private bool CheckeFeilds()
		{
			if (clsForSQL.InDataBase(this.txtNameOrganization.Text) == "NULL" ||
					clsForSQL.InDataBase(this.txtAddressOrganization.Text) == "NULL" ||
					clsForSQL.InDataBase(this.txtManagerOrganization.Text) == "NULL" ||
					clsForSQL.InDataBase(this.txtEmailOrganization.Text) == "NULL")
					{
					XtraMessageBox.Show("Не все обязательные поля заполнены!",
						Application.ProductName,
						MessageBoxButtons.OK,
						MessageBoxIcon.Error,
						DevExpress.Utils.DefaultBoolean.True);
				return false;
			}
			return true;
		}
	}
}
