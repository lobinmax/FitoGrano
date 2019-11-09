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

using FitoGrano;

namespace FitoGrano
{
	public partial class frAddEditQuarantineProducts
	{
		public frAddEditQuarantineProducts()
		{
			// VBConversions Note: Non-static class variable initialization is below.  Class variables cannot be initially assigned non-static values in C#.
			CurrentCountryId = frBooks_CountryAgreements.Default.gvCountries.GetFocusedRowCellDisplayText("Id");
			
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frAddEditQuarantineProducts defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frAddEditQuarantineProducts Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frAddEditQuarantineProducts();
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
		// Ид выбранной страны
		string CurrentCountryId; // VBConversions Note: Initial value cannot be assigned here since it is non-static.  Assignment has been moved to the class constructors.
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
			this.Location = Cursor.Position;
			clsMyUserFunction.LoadViewForm(this);
			tlAddEditQuarantineProducts.LoadTreeList(ShowCountProducts: 1, IsExpClassification: 0);
			tlAddEditQuarantineProducts.SetMultiCheckedProductId(CurrentCountryId);
			this.tlAddEditQuarantineProducts.SetCaptionTreeList("Классификация продукции: " + "\n" +
				frBooks_CountryAgreements.Default.gvCountries.GetFocusedRowCellDisplayText("NameShort"));
		}
		// Кнопка Ok
		public void btnOk_Click(object sender, EventArgs e)
		{
			string NewId = "";
			NewId = System.Convert.ToString(ExecuteScalar(
				Books_CountriesFunction
				@CountryId == " & CurrentCountryId & ",
				@ProductsMultyString == " & Me.tlAddEditQuarantineProducts.GetMultiStringProductId & ",
				@Parameter == 3,
				"Books_CountriesFunction.SetProducts"
				));
			if (NewId != "err")
			{
				this.DialogResult = DialogResult.OK;
			}
		}
	}
}
