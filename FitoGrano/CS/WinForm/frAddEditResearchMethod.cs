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
	
	public partial class frAddEditResearchMethod
	{
		public frAddEditResearchMethod()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frAddEditResearchMethod defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frAddEditResearchMethod Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frAddEditResearchMethod();
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
		DataRow iRowCurrent;
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
		//Отмена
		public void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}
		//Загрузка формы
		public void frAddEditContact_Load(object sender, EventArgs e)
		{
			mdVariables.EventChangedControl = false;
			if (AddEdit == 2)
			{
				mdVariables.EventChangedControl = true;
				this.txtMethodName.Select();
				return;
			}
			this.lbNameForm.Text = "Редактировать метод";
			// текущая строка в таблице
			iRowCurrent = mdQuery.iDataSet.Tables["Books_Method." + frBooks_ResearchDirection.Default.Name].Rows[frBooks_ResearchDirection.Default.gvMethod.FocusedRowHandle];
			this.txtMethodName.EditValue = iRowCurrent["Name"];
			this.cheIsPriority.Checked = Convert.ToBoolean(iRowCurrent["IsPriority"]);
			this.txtLongDay.EditValue = iRowCurrent["LongDay"];
			mdVariables.EventChangedControl = true;
			
			this.txtMethodName.Select();
		}
		// Кнопка Ok
		public void btnOk_Click(object sender, EventArgs e)
		{
			if (clsForSQL.InDataBase(this.txtMethodName.Text) == "NULL")
			{
				XtraMessageBox.Show("Не указано наименование метода исследования!",
					Application.ProductName,
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				return;
			}
			
			string ParentId = frBooks_ResearchDirection.Default.gvDirection.GetFocusedRowCellDisplayText("Id");
			string Id = "NULL";
			string NewId = "";
			if (AddEdit == 3)
			{
				Id = System.Convert.ToString(iRowCurrent["Id"]);
			}
			NewId = System.Convert.ToString(ExecuteScalar(
				EXEC Books_ResearchDirectionMethod
				@IdDirection == " & ParentId & ",
				@IdMethod == " & Id & ",
				@NameMethod == " & clsForSQL.InDataBase(Me.txtMethodName.EditValue) & ",
				@IsPriority == " & clsForSQL.InDataBase(Convert.ToInt64(Me.cheIsPriority.Checked)) & ",
				@LongDay == " & clsForSQL.InDataBase(Convert.ToInt64(Me.txtLongDay.Text)) & ",
				@Parameter == 2,
				@Function == & AddEdit,
				"Books_ResearchDirectionMethod.Function = " + AddEdit
				));
			
			if (NewId != "err")
			{
				if (AddEdit == 2)
				{
					frBooks_ResearchDirection.Default.NewId_Method = NewId;
				}
				this.DialogResult = DialogResult.OK;
			}
			else
			{
				this.txtMethodName.Select();
			}
		}
		// очистить поле
		public void txtMethodName_ButtonClick(dynamic sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
		{
			EditorButton btn = e.Button;
			if (btn.Index == 0)
			{
				sender.Text = "";
			}
		}
	}
}
