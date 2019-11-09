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
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using FitoGrano;

namespace FitoGrano
{
	
	public partial class frAddEditProducts
	{
		public frAddEditProducts()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frAddEditProducts defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frAddEditProducts Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frAddEditProducts();
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
				this.txtProductsName.Select();
				return;
			}
			this.lbNameForm.Text = "Редактировать продукцию";
			// текущая строка в таблице
			iRowCurrent = mdQuery.iDataSet.Tables["Books_Products." + frBooks_ClassificationProducts.Default.Name].Rows[frBooks_ClassificationProducts.Default.gvProducts.FocusedRowHandle];
			this.txtProductsName.EditValue = iRowCurrent["Name"];
			this.txtWeightSample.EditValue = iRowCurrent["WeightSample"];
			mdVariables.EventChangedControl = true;
			
			this.txtProductsName.Select();
		}
		// Кнопка Ok
		public void btnOk_Click(object sender, EventArgs e)
		{
			if ((int) this.txtWeightSample.EditValue == 0 ||
					clsForSQL.InDataBase(this.txtProductsName.Text) == "NULL")
					{
					XtraMessageBox.Show("Не все обязательные поля заполнены!",
						Application.ProductName,
						MessageBoxButtons.OK,
						MessageBoxIcon.Error);
				return;
			}
			
			string ParentId = frBooks_ClassificationProducts.Default.gvClassification.GetFocusedRowCellDisplayText("Id");
			string Id = "NULL";
			string NewId = "";
			if (AddEdit == 3)
			{
				Id = System.Convert.ToString(iRowCurrent["Id"]);
			}
			NewId = System.Convert.ToString(ExecuteScalar(
				EXEC Books_ClassificationsProducts
				@IdClassifications == " & ParentId & ",
				@IdProducts == " & Id & ",
				@NameProducts == " & clsForSQL.InDataBase(Me.txtProductsName.EditValue) & ",
				@WeightSample == " & clsForSQL.InDataBase(Me.txtWeightSample.EditValue) & ",
				@Parameter == 2,
				@Function == & AddEdit,
				"Books_ClassificationsProducts.Function = " + AddEdit
				));
			
			if (NewId != "err")
			{
				if (AddEdit == 2)
				{
					frBooks_ClassificationProducts.Default.NewId_Products = NewId;
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
