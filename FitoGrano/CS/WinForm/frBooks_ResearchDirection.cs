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
	
	public partial class frBooks_ResearchDirection
	{
		public frBooks_ResearchDirection()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frBooks_ResearchDirection defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frBooks_ResearchDirection Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frBooks_ResearchDirection();
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
		string NewId_Direction; // Новая запись в классификациях
		bool EventChangedControl_Direction = false; // вкл обработки событий классификаций
		bool EventChangedControl_Method = false; // вкл обработка событий продукций
		internal string NewId_Method; // Новая запись в продукциях
		
		// закрытие формы
		public void frBooks_FormClosing(object sender, FormClosingEventArgs e)
		{
			clsMyUserFunction.RemoveTableDataSet(this);
			clsMyUserFunction.SaveViewForm(this);
			mdRegistrySetting.RegistryWrite(PreferenceForms, "SplitterPosition", System.Convert.ToString(this.SplitContainerControl1.SplitterPosition));
			mdRegistrySetting.RegistryWrite(PreferenceForms, "gvDirection.ShowFilterRow", this.gvDirection.OptionsView.ShowAutoFilterRow.ToString());
			mdRegistrySetting.RegistryWrite(PreferenceForms, "gvDirection.ShowFindPanel", this.gvDirection.OptionsFind.AlwaysVisible.ToString());
			mdRegistrySetting.RegistryWrite(PreferenceForms, "gvMethod.ShowFilterRow", this.gvMethod.OptionsView.ShowAutoFilterRow.ToString());
			mdRegistrySetting.RegistryWrite(PreferenceForms, "gvMethod.ShowFindPanel", this.gvMethod.OptionsFind.AlwaysVisible.ToString());
		}
		// загрузка формы
		public void frBooks_ResearchDirection_Load(object sender, EventArgs e)
		{
			// настройка элементов
			PreferenceForms = mdVariables.pref_UserSettings + this.Name + "\\";
			clsMyUserFunction.LoadViewForm(this);
			this.SplitContainerControl1.SplitterPosition = System.Convert.ToInt32(mdRegistrySetting.RegistryRead(PreferenceForms, "SplitterPosition", System.Convert.ToString(301)));
			this.gcnDirection.CustomHeaderButtons[4].Properties.Checked = System.Convert.ToBoolean(mdRegistrySetting.RegistryRead(PreferenceForms, "gvDirection.ShowFindPanel", System.Convert.ToString(false)));
			this.gcnDirection.CustomHeaderButtons[5].Properties.Checked = System.Convert.ToBoolean(mdRegistrySetting.RegistryRead(PreferenceForms, "gvDirection.ShowFilterRow", System.Convert.ToString(false)));
			this.gcnMethods.CustomHeaderButtons[4].Properties.Checked = System.Convert.ToBoolean(mdRegistrySetting.RegistryRead(PreferenceForms, "gvMethod.ShowFindPanel", System.Convert.ToString(false)));
			this.gcnMethods.CustomHeaderButtons[5].Properties.Checked = System.Convert.ToBoolean(mdRegistrySetting.RegistryRead(PreferenceForms, "gvMethod.ShowFilterRow", System.Convert.ToString(false)));
			this.lbServerName.Caption = mdVariables.pref_ServerIP;
			this.lbDB_name.Caption = mdVariables.pref_DataBaseName;
			Designer_Direction(); // загрузка направлений
		}
		
#region Направления
		// настройка таблицы классификаций
		private void Designer_Direction()
		{
			EventChangedControl_Direction = false;
			mdQuery.SelectQueryData(
				"Books_Direction." + this.Name,
				"EXEC Books_ResearchDirectionMethod @Parameter = 1, @Function = 1",
				"GetBooks_ResearchDirection"
				);
			if (ReferenceEquals(this.gcDirection.DataSource, null))
			{
				this.gcDirection.DataSource = mdQuery.iDataSet.Tables["Books_Direction." + this.Name];
				mdHidenAllColumns.HidenAllColumns_Grid(this.gvDirection, mdQuery.iDataSet.Tables["Books_Direction." + this.Name]);
				this.gvDirection.Columns["Name"].Visible = true;
				this.gvDirection.Columns["Name"].Caption = "Направление";
			}
			EventChangedControl_Direction = true;
			// активная строка из памяти
			this.gvDirection.FocusedRowHandle = this.gvDirection.LocateByValue("Id", System.Convert.ToInt32(NewId_Direction));
		}
		// группа кнопок направлений
		public void gcnDirection_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
		{
			GroupBoxButton btn = e.Button;
			switch (btn.Caption)
			{
				case "btnAddDirection":
					btnAddDirections(2);
					break;
				case "btnEditDirection":
					if (this.gvDirection.RowCount != 0)
					{
						btnAddDirections(3);
					}
					break;
				case "btnDeleteDirection":
					if (this.gvDirection.RowCount != 0)
					{
						btnDeleteDirections();
					}
					break;
				case "btnClearSort_Direction":
					this.gvDirection.ClearSorting();
					break;
			}
		}
		// группа чеков направлений
		public void gcnDirection_CustomButtonChecked(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
		{
			GroupBoxButton btn = e.Button;
			switch (btn.Caption)
			{
				case "btnSearch_Direction":
					this.gvDirection.OptionsFind.AlwaysVisible = btn.Checked;
					// при отключении очищаем фильтрацию
					if (btn.Checked == false)
					{
						this.gvDirection.FindFilterText = null;
					}
					break;
				case "btnAutoFilter_Direction":
					this.gvDirection.OptionsView.ShowAutoFilterRow = btn.Checked;
					// при отключении очищаем фильтрацию
					if (btn.Checked == false)
					{
						this.gvDirection.ClearColumnsFilter();
					}
					break;
			}
		}
		// фокус на направление
		public void gvDirection_FocusedRowChanged(dynamic sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			if (e.FocusedRowHandle < 0)
			{
				return;
			}
			DataRow iRow = sender.GetFocusedDataRow;
			string ParentId = System.Convert.ToString(iRow["Id"]);
			Designer_Method(ParentId); // получаем список методов по направлению
			if (EventChangedControl_Direction)
			{
				NewId_Direction = iRow["Id"].ToString();
			}
		}
		// добавить/редактировать направление
		private void btnAddDirections(int AddEdit)
		{
			XtraInputBoxArgs ib = new XtraInputBoxArgs(null, null, null, null, null, null); // окно ввода значения
			string result = "";
			string NewId = "";
			string IdClassifications = "NULL"; // запролняется при изменении записи
			TextEdit editor = new TextEdit(); // тип редактора в диалоге
			editor.Properties.MaxLength = 200; // макс кол-во знаков редакторе
			editor.Properties.NullValuePromptShowForEmptyValue = true;
			editor.Properties.ShowNullValuePromptWhenFocused = true;
			editor.Properties.NullValuePrompt = "Введите наименование направления (до " + System.Convert.ToString(editor.Properties.MaxLength) + " символов)";
			ib.Editor = editor;
			ib.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
			ib.Prompt = "<b><u>Наименование направления</b></u>";
			ib.DefaultButtonIndex = 0;
			ib.Caption = System.Convert.ToString(AddEdit == 2 ? "Добавить направление" : "Редактировать направление");
			// при редактировании записи
			if (AddEdit == 3)
			{
				IdClassifications = this.gvDirection.GetFocusedRowCellDisplayText("Id");
				ib.DefaultResponse = this.gvDirection.GetFocusedRowCellDisplayText("Name"); // значение в поле ввода по умолчанию
			}
			
			result = clsForSQL.InDataBase(XtraInputBox.Show(ib));
			if (result != "NULL")
			{
				NewId = System.Convert.ToString(mdQuery.ExecuteScalar(
					"EXEC Books_ResearchDirectionMethod " +
					"@IdDirection = " + IdClassifications + ", " +
					"@NameDirection = " + result + ", " +
					"@Parameter = 1, " +
					"@Function = " + System.Convert.ToString(AddEdit),
					"Books_ResearchDirectionMethod.Function = " + System.Convert.ToString(AddEdit)
					));
				if (NewId != null && AddEdit == 2 && NewId != "err")
				{
					NewId_Direction = NewId;
				}
			}
			Designer_Direction();
		}
		// удалить направление
		private void btnDeleteDirections()
		{
			int RowNumber = this.gvDirection.FocusedRowHandle;
			if (XtraMessageBox.Show("Исследование по направлению <b>" + this.gvDirection.GetFocusedRowCellDisplayText("Name") + "</b> " + "\n" +
					"и принадлежащие ему методы будут удалены из справочника!" + "\n" +
					"Вы согласны?", Application.ProductName, MessageBoxButtons.YesNo,
					MessageBoxIcon.Question, DevExpress.Utils.DefaultBoolean.True) == DialogResult.Yes)
					{
					mdQuery.ExecuteScalar(
						"EXEC Books_ResearchDirectionMethod " +
						"@IdDirection = " + this.gvDirection.GetFocusedRowCellDisplayText("Id") + ", " +
						"@NameDirection = " + this.gvDirection.GetFocusedRowCellDisplayText("Name") + ", " +
						"@Parameter = 1, " +
						"@Function = 4",
						"Books_ResearchDirectionMethod.Function = 4"
						);
				Designer_Direction();
				if (mdQuery.iDataSet.Tables["Books_Direction." + this.Name].Rows.Count == 0)
				{
					mdQuery.iDataSet.Tables["Books_Method." + this.Name].Rows.Clear();
				}
				this.gvDirection.FocusedRowHandle = RowNumber - 1;
			}
		}
		// вызов контекстного меню на направлении
		public void gvDirection_MouseDown(object sender, MouseEventArgs e)
		{
			GridView view = (GridView) sender;
			Point pt = view.GridControl.PointToClient(Control.MousePosition);
			GridHitInfo info = view.CalcHitInfo(pt);
			if (e.Button == MouseButtons.Right)
			{
				this.btnEditDirection.Enabled = info.InRow;
				this.btnDeleteDirection.Enabled = info.InRow;
				this.pmMenuDirection.ShowPopup(MousePosition);
			}
			if (info.InRow & e.Button == MouseButtons.Left & e.Clicks == 2)
			{
				btnEditDirection_ItemClick(e, null);
			}
		}
#region Контекстное меню
		// добавить направление
		public void btnAddDirection_ItemClick(object sender, ItemClickEventArgs e)
		{
			gcnDirection_CustomButtonClick(this.gcnDirection, new DevExpress.XtraBars.Docking2010.BaseButtonEventArgs(this.gcnDirection.CustomHeaderButtons[0]));
		}
		// редактировать направление
		public void btnEditDirection_ItemClick(object sender, ItemClickEventArgs e)
		{
			gcnDirection_CustomButtonClick(this.gcnDirection, new DevExpress.XtraBars.Docking2010.BaseButtonEventArgs(this.gcnDirection.CustomHeaderButtons[1]));
		}
		// удалить направление
		public void btnDeleteDirection_ItemClick(object sender, ItemClickEventArgs e)
		{
			gcnDirection_CustomButtonClick(this.gcnDirection, new DevExpress.XtraBars.Docking2010.BaseButtonEventArgs(this.gcnDirection.CustomHeaderButtons[2]));
		}
#endregion
		// удалить или редактировать направление клавишей
		public void gvDirection_KeyDown(dynamic sender, KeyEventArgs e)
		{
			if (sender.FocusedRowHandle < 0)
			{
				return;
			}
			if (e.KeyCode == Keys.Delete)
			{
				btnDeleteDirection_ItemClick(e, null);
			}
			if (e.KeyCode == Keys.Enter)
			{
				btnEditDirection_ItemClick(e, null);
			}
		}
#endregion
		
#region Методы
		// настройка таблицы с методами
		private void Designer_Method(string ParentId)
		{
			EventChangedControl_Method = false;
			mdQuery.SelectQueryData(
				"Books_Method." + this.Name,
				"EXEC Books_ResearchDirectionMethod @IdDirection = " + ParentId + ", @Parameter = 2, @Function = 1",
				"GetMethods"
				);
			if (ReferenceEquals(this.gcMethod.DataSource, null))
			{
				this.gcMethod.DataSource = mdQuery.iDataSet.Tables["Books_Method." + this.Name];
				mdHidenAllColumns.HidenAllColumns_Grid(this.gvMethod, mdQuery.iDataSet.Tables["Books_Method." + this.Name]);
				this.gvMethod.Columns["LongDay"].Visible = true;
				this.gvMethod.Columns["LongDay"].Caption = "Продолжительность, дней";
				this.gvMethod.Columns["IsPriority"].Visible = true;
				this.gvMethod.Columns["IsPriority"].Caption = "Метод приоритетный";
				this.gvMethod.Columns["Name"].Visible = true;
				this.gvMethod.Columns["Name"].Caption = "Наименование метода";
				this.gvMethod.BestFitColumns();
			}
			EventChangedControl_Method = true;
			// активная строка из памяти
			this.gvMethod.FocusedRowHandle = this.gvMethod.LocateByValue("Id", System.Convert.ToInt32(NewId_Method));
		}
		// группа кнопок методов
		public void gcnProducts_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
		{
			bool btnAddEdit = false;
			GroupBoxButton btn = e.Button;
			switch (btn.Caption)
			{
				case "btnAddMethod":
					frAddEditResearchMethod.Default.AddEdit = 2;
					btnAddEdit = true;
					break;
				case "btnEditMethod":
					if (this.gvMethod.RowCount != 0)
					{
						frAddEditResearchMethod.Default.AddEdit = 3;
						btnAddEdit = true;
					}
					break;
				case "btnDeleteMethod":
					if (this.gvMethod.RowCount != 0)
					{
						btnDeleteMethods();
					}
					break;
				case "btnClearSort_Method":
					this.gvMethod.ClearSorting();
					break;
			}
			// если добавление или редактирование
			if (btnAddEdit)
			{
				NewId_Method = this.gvMethod.GetFocusedRowCellDisplayText("Id");
				if (frAddEditResearchMethod.Default.ShowDialog() == DialogResult.OK)
				{
					Designer_Method(this.gvDirection.GetFocusedRowCellDisplayText("Id"));
				}
			}
		}
		// группа чеков методов
		public void gcnMethods_CustomButtonChecked(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
		{
			GroupBoxButton btn = e.Button;
			switch (btn.Caption)
			{
				case "btnSearch_Method":
					this.gvMethod.OptionsFind.AlwaysVisible = btn.Checked;
					// при отключении очищаем фильтрацию
					if (btn.Checked == false)
					{
						this.gvMethod.FindFilterText = null;
					}
					break;
				case "btnAutoFilter_Method":
					this.gvMethod.OptionsView.ShowAutoFilterRow = btn.Checked;
					// при отключении очищаем фильтрацию
					if (btn.Checked == false)
					{
						this.gvMethod.ClearColumnsFilter();
					}
					break;
			}
		}
		// фокус на методах
		public void gvMethod_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			gvMethod_RowChanged(e.FocusedRowHandle);
		}
		// Клмк на методах
		public void gvMethod_FocusedRowChanged(object sender, RowCellClickEventArgs e)
		{
			gvMethod_RowChanged(e.RowHandle);
		}
		// событие строк
		private void gvMethod_RowChanged(int RowHandle)
		{
			if (RowHandle < 0)
			{
				return;
			}
			DataRow iRow = this.gvMethod.GetFocusedDataRow();
			if (RowHandle < 0)
			{
				return;
			}
			if (EventChangedControl_Method)
			{
				NewId_Method = iRow["Id"].ToString();
			}
		}
		// удалить метод
		private void btnDeleteMethods()
		{
			int RowNumber = this.gvMethod.FocusedRowHandle;
			if (XtraMessageBox.Show("Метод исследования <b>" + this.gvMethod.GetFocusedRowCellDisplayText("Name") + "</b> будет удален!" + "\n" +
					"Вы согласны?", Application.ProductName, MessageBoxButtons.YesNo,
					MessageBoxIcon.Question, DevExpress.Utils.DefaultBoolean.True) == DialogResult.Yes)
					{
					mdQuery.ExecuteScalar(
						"EXEC Books_ResearchDirectionMethod " +
						"@IdMethod = " + this.gvMethod.GetFocusedRowCellDisplayText("Id") + ", " +
						"@NameMethod = " + clsForSQL.InDataBase(this.gvMethod.GetFocusedRowCellDisplayText("Name")) + ", " +
						"@Parameter = 2, " +
						"@Function = 4",
						"Books_ResearchDirectionMethod.Function = 4"
						);
				Designer_Method(this.gvDirection.GetFocusedRowCellDisplayText("Id"));
				this.gvMethod.FocusedRowHandle = RowNumber - 1;
			}
		}
		// вызов контекстного меню на методах
		public void gvMethod_MouseDown(object sender, MouseEventArgs e)
		{
			GridView view = (GridView) sender;
			Point pt = view.GridControl.PointToClient(Control.MousePosition);
			GridHitInfo info = view.CalcHitInfo(pt);
			if (e.Button == MouseButtons.Right)
			{
				this.btnEditMethod.Enabled = info.InRow;
				this.btnDeleteMethod.Enabled = info.InRow;
				this.pmMenuMethods.ShowPopup(MousePosition);
			}
			if (info.InRow & e.Button == MouseButtons.Left & e.Clicks == 2)
			{
				btnEditMethod_ItemClick(e, null);
			}
		}
#region Контекстное меню
		// добавить метод
		public void btnAddMethod_ItemClick(object sender, ItemClickEventArgs e)
		{
			gcnProducts_CustomButtonClick(this.gcnDirection, new DevExpress.XtraBars.Docking2010.BaseButtonEventArgs(this.gcnMethods.CustomHeaderButtons[0]));
		}
		// редактировать метод
		public void btnEditMethod_ItemClick(object sender, ItemClickEventArgs e)
		{
			gcnProducts_CustomButtonClick(this.gcnDirection, new DevExpress.XtraBars.Docking2010.BaseButtonEventArgs(this.gcnMethods.CustomHeaderButtons[1]));
		}
		// удалить метод
		public void btnDeleteMethod_ItemClick(object sender, ItemClickEventArgs e)
		{
			gcnProducts_CustomButtonClick(this.gcnDirection, new DevExpress.XtraBars.Docking2010.BaseButtonEventArgs(this.gcnMethods.CustomHeaderButtons[2]));
		}
#endregion
		// удалить или редактировать метод клавишей
		public void gvMethod_KeyDown(dynamic sender, KeyEventArgs e)
		{
			if (sender.FocusedRowHandle < 0)
			{
				return;
			}
			if (e.KeyCode == Keys.Delete & sender.FocusedRowHandle >= 0)
			{
				btnDeleteMethod_ItemClick(e, null);
			}
			if (e.KeyCode == Keys.Enter & sender.FocusedRowHandle >= 0)
			{
				btnEditMethod_ItemClick(e, null);
			}
		}
#endregion
		
		// проверка полей по таймеру
		public void tmChecked_Tick(object sender, EventArgs e)
		{
			int gvDirectionRowCount = this.gvDirection.RowCount; // кол-во направлений
			int gvMethodRowCount = this.gvMethod.RowCount; // кол-во методов
			// направления
			this.gcnDirection.CustomHeaderButtons[1].Properties.Enabled = gvDirectionRowCount != 0; // редактировать
			this.gcnDirection.CustomHeaderButtons[2].Properties.Enabled = gvDirectionRowCount != 0; // удалить
			// методы
			this.btnAddMethod.Enabled = gvDirectionRowCount != 0; // добавить в меню
			this.gcnMethods.CustomHeaderButtons[0].Properties.Enabled = gvDirectionRowCount != 0; // добавить
			this.gcnMethods.CustomHeaderButtons[1].Properties.Enabled = gvMethodRowCount != 0; // редактировать
			this.gcnMethods.CustomHeaderButtons[2].Properties.Enabled = gvMethodRowCount != 0; // удалить
			// подсчет столбцов с примененной сортировкой
			int ColCount = 0;
			foreach (GridColumn c in this.gvDirection.SortedColumns)
			{
				ColCount++;
			}
			this.gcnDirection.CustomHeaderButtons[6].Properties.Enabled = ColCount != 0;
			// подсчет столбцов с примененной сортировкой
			ColCount = 0;
			foreach (GridColumn c in this.gvMethod.SortedColumns)
			{
				ColCount++;
			}
			this.gcnMethods.CustomHeaderButtons[6].Properties.Enabled = ColCount != 0;
		}
		// обновление формы
		public void btnUpdate_ItemClick(object sender, ItemClickEventArgs e)
		{
			Designer_Direction();
		}
	}
}
