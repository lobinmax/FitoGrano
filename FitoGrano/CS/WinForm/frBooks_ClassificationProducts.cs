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
using DevExpress.XtraEditors.ButtonsPanelControl;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using FitoGrano;

namespace FitoGrano
{
	
	public partial class frBooks_ClassificationProducts
	{
		public frBooks_ClassificationProducts()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frBooks_ClassificationProducts defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frBooks_ClassificationProducts Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frBooks_ClassificationProducts();
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
		string NewId_Classification; // Новая запись в классификациях
		bool EventChangedControl_Classification = false; // вкл обработки событий классификаций
		bool EventChangedControl_Products = false; // вкл обработка событий продукций
		internal string NewId_Products; // Новая запись в продукциях
		
		// закрытие формы
		public void frBooks_FormClosing(object sender, FormClosingEventArgs e)
		{
			clsMyUserFunction.RemoveTableDataSet(this);
			clsMyUserFunction.SaveViewForm(this);
			mdRegistrySetting.RegistryWrite(PreferenceForms, "SplitterPosition", System.Convert.ToString(this.SplitContainerControl1.SplitterPosition));
			mdRegistrySetting.RegistryWrite(PreferenceForms, "gvClassification.ShowFilterRow", this.gvClassification.OptionsView.ShowAutoFilterRow.ToString());
			mdRegistrySetting.RegistryWrite(PreferenceForms, "gvClassification.ShowFindPanel", this.gvClassification.OptionsFind.AlwaysVisible.ToString());
			mdRegistrySetting.RegistryWrite(PreferenceForms, "gvProducts.ShowFilterRow", this.gvProducts.OptionsView.ShowAutoFilterRow.ToString());
			mdRegistrySetting.RegistryWrite(PreferenceForms, "gvProducts.ShowFindPanel", this.gvProducts.OptionsFind.AlwaysVisible.ToString());
		}
		// загрузка формы
		public void frBooks_ClassificationProducts_Load(object sender, EventArgs e)
		{
			// настройка элементов
			PreferenceForms = mdVariables.pref_UserSettings + this.Name + "\\";
			clsMyUserFunction.LoadViewForm(this);
			this.SplitContainerControl1.SplitterPosition = System.Convert.ToInt32(mdRegistrySetting.RegistryRead(PreferenceForms, "SplitterPosition", System.Convert.ToString(301)));
			this.gcnClassification.CustomHeaderButtons[4].Properties.Checked = System.Convert.ToBoolean(mdRegistrySetting.RegistryRead(PreferenceForms, "gvClassification.ShowFindPanel", System.Convert.ToString(false)));
			this.gcnClassification.CustomHeaderButtons[5].Properties.Checked = System.Convert.ToBoolean(mdRegistrySetting.RegistryRead(PreferenceForms, "gvClassification.ShowFilterRow", System.Convert.ToString(false)));
			this.gcnProducts.CustomHeaderButtons[4].Properties.Checked = System.Convert.ToBoolean(mdRegistrySetting.RegistryRead(PreferenceForms, "gvProducts.ShowFindPanel", System.Convert.ToString(false)));
			this.gcnProducts.CustomHeaderButtons[5].Properties.Checked = System.Convert.ToBoolean(mdRegistrySetting.RegistryRead(PreferenceForms, "gvProducts.ShowFilterRow", System.Convert.ToString(false)));
			this.lbServerName.Caption = mdVariables.pref_ServerIP;
			this.lbDB_name.Caption = mdVariables.pref_DataBaseName;
			Designer_Classification(); // загрузка классификаций
		}
		
#region Классификации
		// настройка таблицы классификаций
		private void Designer_Classification()
		{
			EventChangedControl_Classification = false;
			mdQuery.SelectQueryData(
				"Books_Classification." + this.Name,
				"EXEC Books_ClassificationsProducts @Parameter = 1, @Function = 1",
				"GetClassifications"
				);
			if (ReferenceEquals(this.gcClassification.DataSource, null))
			{
				this.gcClassification.DataSource = mdQuery.iDataSet.Tables["Books_Classification." + this.Name];
				mdHidenAllColumns.HidenAllColumns_Grid(this.gvClassification, mdQuery.iDataSet.Tables["Books_Classification." + this.Name]);
				this.gvClassification.Columns["Name"].Visible = true;
				this.gvClassification.Columns["Name"].Caption = "Наименование";
			}
			EventChangedControl_Classification = true;
			// активная строка из памяти
			this.gvClassification.FocusedRowHandle = this.gvClassification.LocateByValue("Id", System.Convert.ToInt32(NewId_Classification));
		}
		// группа кнопок классификаций
		public void gcnClassification_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
		{
			GroupBoxButton btn = e.Button;
			// Console.WriteLine(e.Button.Properties.Caption)
			switch (btn.Caption)
			{
				case "btnAddClassification":
					btnAddClassification(2);
					break;
				case "btnEditClassfication":
					if (this.gvClassification.RowCount != 0)
					{
						btnAddClassification(3);
					}
					break;
				case "btnDeleteClassfication":
					if (this.gvClassification.RowCount != 0)
					{
						btnDeleteClassfication();
					}
					break;
				case "btnClearSort_Classfication":
					this.gvClassification.ClearSorting();
					break;
			}
		}
		// группа чеков классификаций
		public void gcnClassification_CustomButtonChecked(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
		{
			GroupBoxButton btn = e.Button;
			switch (btn.Caption)
			{
				case "btnSearch_Classifications":
					this.gvClassification.OptionsFind.AlwaysVisible = btn.Checked;
					// при отключении очищаем фильтрацию
					if (btn.Checked == false)
					{
						this.gvClassification.FindFilterText = null;
					}
					break;
				case "btnAutoFilter_Classifications":
					this.gvClassification.OptionsView.ShowAutoFilterRow = btn.Checked;
					// при отключении очищаем фильтрацию
					if (btn.Checked == false)
					{
						this.gvClassification.ClearColumnsFilter();
					}
					break;
			}
		}
		// фокус на классификацию
		public void gvClassification_FocusedRowChanged(dynamic sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			if (e.FocusedRowHandle < 0)
			{
				return;
			}
			DataRow iRow = sender.GetFocusedDataRow;
			string ParentId = System.Convert.ToString(iRow["Id"]);
			Designer_Products(ParentId); // получаем список продукций по классификации
			if (EventChangedControl_Classification)
			{
				NewId_Classification = iRow["Id"].ToString();
			}
		}
		// добавить/редактировать классификацию
		private void btnAddClassification(int AddEdit)
		{
			XtraInputBoxArgs ib = new XtraInputBoxArgs(null, null, null, null, null, null); // окно ввода значения
			string result = "";
			string NewId = "";
			string IdClassifications = "NULL"; // запролняется при изменении записи
			TextEdit editor = new TextEdit(); // тип редактора в диалоге
			editor.Properties.MaxLength = 200; // макс кол-во знаков редакторе
			editor.Properties.NullValuePromptShowForEmptyValue = true;
			editor.Properties.ShowNullValuePromptWhenFocused = true;
			editor.Properties.NullValuePrompt = "Введите наименование классификации (до " + System.Convert.ToString(editor.Properties.MaxLength) + " символов)";
			ib.Editor = editor;
			ib.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
			ib.Prompt = "<b><u>Наименование классификации</b></u>";
			ib.DefaultButtonIndex = 0;
			ib.Caption = System.Convert.ToString(AddEdit == 2 ? "Добавить классификацию" : "Редактировать классификацию");
			// при редактировании записи
			if (AddEdit == 3)
			{
				IdClassifications = this.gvClassification.GetFocusedRowCellDisplayText("Id");
				ib.DefaultResponse = this.gvClassification.GetFocusedRowCellDisplayText("Name"); // значение в поле ввода по умолчанию
			}
			
			result = clsForSQL.InDataBase(XtraInputBox.Show(ib));
			if (result != "NULL")
			{
				NewId = System.Convert.ToString(mdQuery.ExecuteScalar(
					"EXEC Books_ClassificationsProducts " +
					"@IdClassifications = " + IdClassifications + ", " +
					"@NameClassifications = " + result + ", " +
					"@Parameter = 1, " +
					"@Function = " + System.Convert.ToString(AddEdit),
					"Books_ClassificationsProducts.Function = " + System.Convert.ToString(AddEdit)
					));
				if (NewId != null && AddEdit == 2 && NewId != "err")
				{
					NewId_Classification = NewId;
				}
				Designer_Classification();
			}
		}
		// удалить классификацию
		private void btnDeleteClassfication()
		{
			int RowNumber = this.gvClassification.FocusedRowHandle;
			if (XtraMessageBox.Show("Классификация <b>" + this.gvClassification.GetFocusedRowCellDisplayText("Name") + "</b> " + "\n" +
					"и принадлежащая ей продукция будет удалена из справочника!" + "\n" +
					"Вы согласны?", Application.ProductName, MessageBoxButtons.YesNo,
					MessageBoxIcon.Question, DevExpress.Utils.DefaultBoolean.True) == DialogResult.Yes)
					{
					mdQuery.ExecuteScalar(
						"EXEC Books_ClassificationsProducts " +
						"@IdClassifications = " + this.gvClassification.GetFocusedRowCellDisplayText("Id") + ", " +
						"@Parameter = 1, " +
						"@Function = 4",
						"Books_ClassificationsProducts.Function = 4"
						);
				Designer_Classification();
				if (mdQuery.iDataSet.Tables["Books_Classification." + this.Name].Rows.Count == 0)
				{
					mdQuery.iDataSet.Tables["Books_Products." + this.Name].Rows.Clear();
				}
				this.gvClassification.FocusedRowHandle = RowNumber - 1;
			}
		}
		// вызов контекстного меню на классификациях
		public void gvPerformers_MouseDown(object sender, MouseEventArgs e)
		{
			GridView view = (GridView) sender;
			Point pt = view.GridControl.PointToClient(Control.MousePosition);
			GridHitInfo info = view.CalcHitInfo(pt);
			if (e.Button == MouseButtons.Right)
			{
				this.btnEditClassifications.Enabled = info.InRow;
				this.btnDeleteClassifications.Enabled = info.InRow;
				this.pmMenuClassifications.ShowPopup(MousePosition);
			}
			if (info.InRow & e.Button == MouseButtons.Left & e.Clicks == 2)
			{
				btnEditClassifications_ItemClick(e, null);
			}
		}
#region Контекстное меню
		// добавить классификацию
		public void btnAddClassifications_ItemClick(object sender, ItemClickEventArgs e)
		{
			gcnClassification_CustomButtonClick(this.gcnClassification, new DevExpress.XtraBars.Docking2010.BaseButtonEventArgs(this.gcnClassification.CustomHeaderButtons[0]));
		}
		// редактировать классификацию
		public void btnEditClassifications_ItemClick(object sender, ItemClickEventArgs e)
		{
			gcnClassification_CustomButtonClick(this.gcnClassification, new DevExpress.XtraBars.Docking2010.BaseButtonEventArgs(this.gcnClassification.CustomHeaderButtons[1]));
		}
		// удалить классификацию
		public void btnDeleteClassifications_ItemClick(object sender, ItemClickEventArgs e)
		{
			gcnClassification_CustomButtonClick(this.gcnClassification, new DevExpress.XtraBars.Docking2010.BaseButtonEventArgs(this.gcnClassification.CustomHeaderButtons[2]));
		}
#endregion
		// удалить или редактировать классификацию клавишей
		public void gvClassification_KeyDown(dynamic sender, KeyEventArgs e)
		{
			if (sender.FocusedRowHandle < 0)
			{
				return;
			}
			if (e.KeyCode == Keys.Delete)
			{
				btnDeleteClassifications_ItemClick(e, null);
			}
			if (e.KeyCode == Keys.Enter)
			{
				btnEditClassifications_ItemClick(e, null);
			}
		}
		
#endregion
		
#region Придукция
		// настройка таблицы с продукцией
		private void Designer_Products(string ParentId)
		{
			EventChangedControl_Products = false;
			mdQuery.SelectQueryData(
				"Books_Products." + this.Name,
				"EXEC Books_ClassificationsProducts @IdClassifications = " + ParentId + ", @Parameter = 2, @Function = 1",
				"GetProducts"
				);
			if (ReferenceEquals(this.gcProducts.DataSource, null))
			{
				this.gcProducts.DataSource = mdQuery.iDataSet.Tables["Books_Products." + this.Name];
				mdHidenAllColumns.HidenAllColumns_Grid(this.gvProducts, mdQuery.iDataSet.Tables["Books_Products." + this.Name]);
				this.gvProducts.Columns["WeightSample"].Visible = true;
				this.gvProducts.Columns["WeightSample"].Caption = "Средний вес пробы, г.";
				this.gvProducts.Columns["Name"].Visible = true;
				this.gvProducts.Columns["Name"].Caption = "Наименование продукции";
				this.gvProducts.Columns["WeightSample"].BestFit();
			}
			EventChangedControl_Products = true;
			// активная строка из памяти
			this.gvProducts.FocusedRowHandle = this.gvProducts.LocateByValue("Id", System.Convert.ToInt32(NewId_Products));
		}
		// группа кнопок продукций
		public void gcnProducts_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
		{
			bool btnAddEdit = false;
			GroupBoxButton btn = e.Button;
			switch (btn.Caption)
			{
				case "btnAddProducts":
					frAddEditProducts.Default.AddEdit = 2;
					btnAddEdit = true;
					break;
				case "btnEditProducts":
					if (this.gvProducts.RowCount != 0)
					{
						frAddEditProducts.Default.AddEdit = 3;
						btnAddEdit = true;
					}
					break;
				case "btnDeleteProducts":
					if (this.gvProducts.RowCount != 0)
					{
						btnDeleteProduct();
					}
					break;
				case "btnClearSort_Products":
					this.gvProducts.ClearSorting();
					break;
			}
			// если добавление или редактирование
			if (btnAddEdit)
			{
				if (frAddEditProducts.Default.ShowDialog() == DialogResult.OK)
				{
					Designer_Products(this.gvClassification.GetFocusedRowCellDisplayText("Id"));
				}
			}
		}
		// группа чеков продукций
		public void gcnProducts_CustomButtonChecked(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
		{
			GroupBoxButton btn = e.Button;
			switch (btn.Caption)
			{
				case "btnSearch_Products":
					this.gvProducts.OptionsFind.AlwaysVisible = btn.Checked;
					// при отключении очищаем фильтрацию
					if (btn.Checked == false)
					{
						this.gvProducts.FindFilterText = null;
					}
					break;
				case "btnAutoFilter_Products":
					this.gvProducts.OptionsView.ShowAutoFilterRow = btn.Checked;
					// при отключении очищаем фильтрацию
					if (btn.Checked == false)
					{
						this.gvProducts.ClearColumnsFilter();
					}
					break;
			}
		}
		// фокус на продукцию
		public void gvProducts_FocusedRowChanged(dynamic sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			if (sender.FocusedRowHandle < 0)
			{
				return;
			}
			DataRow iRow = sender.GetFocusedDataRow;
			if (e.FocusedRowHandle < 0)
			{
				return;
			}
			if (EventChangedControl_Products)
			{
				NewId_Products = iRow["Id"].ToString();
			}
		}
		// удалить продукцию
		private void btnDeleteProduct()
		{
			int RowNumber = this.gvProducts.FocusedRowHandle;
			if (XtraMessageBox.Show("Продукция с наименованием <b>" + this.gvProducts.GetFocusedRowCellDisplayText("Name") + "</b> будет удалена!" + "\n" +
					"Вы согласны?", Application.ProductName, MessageBoxButtons.YesNo,
					MessageBoxIcon.Question, DevExpress.Utils.DefaultBoolean.True) == DialogResult.Yes)
					{
					mdQuery.ExecuteScalar(
						"EXEC Books_ClassificationsProducts " +
						"@IdProducts = " + this.gvProducts.GetFocusedRowCellDisplayText("Id") + ", " +
						"@Parameter = 2, " +
						"@Function = 4",
						"Books_ClassificationsProducts.Function = 4"
						);
				Designer_Products(this.gvClassification.GetFocusedRowCellDisplayText("Id"));
				this.gvProducts.FocusedRowHandle = RowNumber - 1;
			}
		}
		// вызов контекстного меню на продукции
		public void gvProducts_MouseDown(object sender, MouseEventArgs e)
		{
			GridView view = (GridView) sender;
			Point pt = view.GridControl.PointToClient(Control.MousePosition);
			GridHitInfo info = view.CalcHitInfo(pt);
			if (e.Button == MouseButtons.Right)
			{
				this.btnEditProducts.Enabled = info.InRow;
				this.btnDeleteProducts.Enabled = info.InRow;
				this.pmMenuProducts.ShowPopup(MousePosition);
			}
			if (info.InRow & e.Button == MouseButtons.Left & e.Clicks == 2)
			{
				btnEditProducts_ItemClick(e, null);
			}
		}
#region Контекстное меню
		// добавить продукцию
		public void btnAddProducts_ItemClick(object sender, ItemClickEventArgs e)
		{
			gcnProducts_CustomButtonClick(this.gcnClassification, new DevExpress.XtraBars.Docking2010.BaseButtonEventArgs(this.gcnProducts.CustomHeaderButtons[0]));
		}
		// редактировать продукцию
		public void btnEditProducts_ItemClick(object sender, ItemClickEventArgs e)
		{
			gcnProducts_CustomButtonClick(this.gcnClassification, new DevExpress.XtraBars.Docking2010.BaseButtonEventArgs(this.gcnProducts.CustomHeaderButtons[1]));
		}
		// удалить продукцию
		public void btnDeleteProducts_ItemClick(object sender, ItemClickEventArgs e)
		{
			gcnProducts_CustomButtonClick(this.gcnClassification, new DevExpress.XtraBars.Docking2010.BaseButtonEventArgs(this.gcnProducts.CustomHeaderButtons[2]));
		}
#endregion
		// удалить или редактировать продукцию клавишей
		public void gvProducts_KeyDown(dynamic sender, KeyEventArgs e)
		{
			if (sender.FocusedRowHandle < 0)
			{
				return;
			}
			if (e.KeyCode == Keys.Delete & sender.FocusedRowHandle >= 0)
			{
				btnDeleteProducts_ItemClick(e, null);
			}
			if (e.KeyCode == Keys.Enter & sender.FocusedRowHandle >= 0)
			{
				btnEditProducts_ItemClick(e, null);
			}
		}
#endregion
		
		// проверка полей по таймеру
		public void tmChecked_Tick(object sender, EventArgs e)
		{
			int gvClassificationRowCount = this.gvClassification.RowCount; // кол-во классификаций
			int gvProductsRowCount = this.gvProducts.RowCount; // кол-во продукций
			// классификации
			this.gcnClassification.CustomHeaderButtons[1].Properties.Enabled = gvClassificationRowCount != 0; // редактировать
			this.gcnClassification.CustomHeaderButtons[2].Properties.Enabled = gvClassificationRowCount != 0; // удалить
			// продукция
			this.btnAddProducts.Enabled = gvClassificationRowCount != 0; // добавить в меню
			this.gcnProducts.CustomHeaderButtons[0].Properties.Enabled = gvClassificationRowCount != 0; // добавить
			this.gcnProducts.CustomHeaderButtons[1].Properties.Enabled = gvProductsRowCount != 0; // редактировать
			this.gcnProducts.CustomHeaderButtons[2].Properties.Enabled = gvProductsRowCount != 0; // удалить
			// подсчет столбцов с примененной сортировкой
			int ColCount = 0;
			foreach (GridColumn c in this.gvClassification.SortedColumns)
			{
				ColCount++;
			}
			this.gcnClassification.CustomHeaderButtons[6].Properties.Enabled = ColCount != 0;
			// подсчет столбцов с примененной сортировкой
			ColCount = 0;
			foreach (GridColumn c in this.gvProducts.SortedColumns)
			{
				ColCount++;
			}
			this.gcnProducts.CustomHeaderButtons[6].Properties.Enabled = ColCount != 0;
		}
		
		// обновление формы
		public void btnUpdate_ItemClick(object sender, ItemClickEventArgs e)
		{
			Designer_Classification();
		}
	}
}
