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
	
	public partial class frAddEditCountry
	{
		public frAddEditCountry()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frAddEditCountry defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frAddEditCountry Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frAddEditCountry();
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
		//Загрузка формы
		public void frAddEditContact_Load(object sender, EventArgs e)
		{
			clsMyUserFunction.LoadViewForm(this);
			mdVariables.EventChangedControl = false;
			if (AddEdit == 2)
			{
				mdVariables.EventChangedControl = true;
				this.txtCountryNameShort.Select();
				return;
			}
			this.lbNameForm.Text = "Редактировать страну";
			// текущая строка в таблице
			iRowCurrent = mdQuery.iDataSet.Tables["Books_Contries." + frBooks_CountryAgreements.Default.Name].Rows[frBooks_CountryAgreements.Default.gvCountries.FocusedRowHandle];
			this.txtCountryNameShort.EditValue = iRowCurrent["NameShort"];
			this.txtCountryNameLong.EditValue = iRowCurrent["NameLong"];
			this.txtCountryAlpha1.EditValue = iRowCurrent["Alpha1"];
			this.txtCountryAlpha2.EditValue = iRowCurrent["Alpha2"];
			mdVariables.EventChangedControl = true;
			this.txtCountryNameShort.Select();
		}
		// Кнопка Ok
		public void btnOk_Click(object sender, EventArgs e)
		{
			if (clsForSQL.InDataBase(this.txtCountryNameShort.Text) == "NULL" ||
					clsForSQL.InDataBase(this.txtCountryAlpha1.Text) == "NULL" ||
					clsForSQL.InDataBase(this.txtCountryAlpha2.Text) == "NULL")
					{
					XtraMessageBox.Show("Не все обязательные поля заполнены!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			
			string Id = "NULL";
			string NewId = "";
			if (AddEdit == 3)
			{
				Id = System.Convert.ToString(iRowCurrent["Id"]);
			}
			NewId = System.Convert.ToString(ExecuteScalar(
				EXEC Books_CountriesFunction
				@CountryId == " & Id & ",
				@CountryNameShort == " & clsForSQL.InDataBase(Me.txtCountryNameShort.EditValue) & ",
				@CountryNameLong == " & clsForSQL.InDataBase(Me.txtCountryNameLong.EditValue) & ",
				@CountryAlpha1 == " & clsForSQL.InDataBase(Me.txtCountryAlpha1.EditValue) & ",
				@CountryAlpha2 == " & clsForSQL.InDataBase(Me.txtCountryAlpha2.EditValue) & ",
				@Parameter == 1,
				@Function == & AddEdit,
				"Books_CountriesFunction.Parameter = 1, Function = " + AddEdit
				));
			if (NewId != "err")
			{
				if (AddEdit == 2)
				{
					frBooks_CountryAgreements.Default.NewId_Countries = NewId;
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
		// перевод курсора по ентору
		public void txtCountryNameLong_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Enter)
			{
				this.GroupControl2.Select();
			}
		}
	}
}
