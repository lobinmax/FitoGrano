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
	
	public partial class frAddEditObjects
	{
		public frAddEditObjects()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frAddEditObjects defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frAddEditObjects Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frAddEditObjects();
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
		bool CanResize = false; // возможно изменение размера формы
		bool IsResize = false; // происходит изменения размера
		// Таскание формы за любой участок
		public void Control_MouseDown(dynamic sender, System.Windows.Forms.MouseEventArgs e)
		{
			CanResize = true;
			if (e.Button == System.Windows.Forms.MouseButtons.Left && IsResize == false)
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
			clsMyUserFunction.SaveViewForm(this);
		}
		//Отмена
		public void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}
		// изменение размера формы
		public void frAddEditCountry_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.X > this.Width - 10 & e.Y > this.Height - 10)
			{
				this.Cursor = Cursors.SizeNWSE;
				IsResize = true;
			}
			else
			{
				Cursor = Cursors.Default;
				IsResize = false;
			}
			if (e.Button == System.Windows.Forms.MouseButtons.Left && CanResize)
			{
				this.Size = new Size(e.X, e.Y);
				Application.DoEvents();
			}
		}
		// Невозможно изменение размера формы
		public void lbNameForm_MouseUp(object sender, MouseEventArgs e)
		{
			CanResize = false;
		}
		// загрузка формы
		public void frAddEditObjects_Load(object sender, EventArgs e)
		{
			clsMyUserFunction.LoadViewForm(this);
			this.tlResearchMetods.LoadMethodList(IsExpDirection: false);
			mdVariables.EventChangedControl = false;
			if (AddEdit == 2)
			{
				mdVariables.EventChangedControl = true;
				this.txtObjectNameRU.Select();
				return;
			}
			this.lbNameForm.Text = "Редактировать объект исследования";
			// текущая строка в таблице
			iRowCurrent = mdQuery.iDataSet.Tables["Books_Objects." + frBooks_ResearchObjects.Default.Name].Rows[frBooks_ResearchObjects.Default.gvObjects.FocusedRowHandle];
			this.txtObjectNameRU.EditValue = iRowCurrent["Name"];
			this.txtObjectNameLAT.EditValue = iRowCurrent["NameLatin"];
			this.tlResearchMetods.SetMultiCheckedObjectId(System.Convert.ToString(iRowCurrent["Id"]));
			mdVariables.EventChangedControl = true;
			this.txtObjectNameRU.Select();
		}
		// кнопка ОК
		public void btnOk_Click(object sender, EventArgs e)
		{
			if (this.tlResearchMetods.GetMultiStringMethodId() == "NULL")
			{
				XtraMessageBox.Show("Не указаны методы для объекта исследования!",
					Application.ProductName,
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				return;
			}
			if (clsForSQL.InDataBase(this.txtObjectNameRU.Text) == "NULL" ||
					clsForSQL.InDataBase(this.txtObjectNameLAT.Text) == "NULL")
					{
					XtraMessageBox.Show("Не все обязательные поля заполнены!",
						Application.ProductName,
						MessageBoxButtons.OK,
						MessageBoxIcon.Error);
				return;
			}
			
			string ObjectTypeId = System.Convert.ToString(frBooks_ResearchObjects.Default.Accord.SelectedElement.Tag);
			string Id = "NULL";
			string NewId = "";
			if (AddEdit == 3)
			{
				Id = System.Convert.ToString(iRowCurrent["Id"]);
			}
			NewId = System.Convert.ToString(ExecuteScalar(
				EXEC Books_ObjectsFunc
				@ObjectId == " & Id & ",
				@ObjectTypeId == " & ObjectTypeId & ",
				@ObjectName == " & clsForSQL.InDataBase(Me.txtObjectNameRU.EditValue) & ",
				@ObjectNameLatin == " & clsForSQL.InDataBase(Me.txtObjectNameLAT.EditValue) & ",
				@MethodsMultiString == " & Me.tlResearchMetods.GetMultiStringMethodId & ",
				@Function == & AddEdit,
				"Books_ObjectsFunc.Function = " + AddEdit
				));
			
			if (NewId != "err")
			{
				if (AddEdit == 2)
				{
					frBooks_ResearchObjects.Default.NewId_Object = NewId;
				}
				this.DialogResult = DialogResult.OK;
			}
		}
		// очистить поле
		public void txtProductsName_ButtonClick(dynamic sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
		{
			EditorButton btn = e.Button;
			if (btn.Index == 0)
			{
				sender.Text = "";
			}
		}
	}
}
