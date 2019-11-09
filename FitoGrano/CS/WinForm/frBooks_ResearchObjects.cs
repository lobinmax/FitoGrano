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
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ButtonsPanelControl;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using FitoGrano;

namespace FitoGrano
{
	
	public partial class frBooks_ResearchObjects
	{
		public frBooks_ResearchObjects()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frBooks_ResearchObjects defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frBooks_ResearchObjects Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frBooks_ResearchObjects();
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
		string SelectedObjectType; // активный тип объекта
		internal string NewId_Object; // Ид нового объекта
		// закрытие формы
		public void frBooks_FormClosing(object sender, FormClosingEventArgs e)
		{
			clsMyUserFunction.RemoveTableDataSet(this);
			clsMyUserFunction.SaveViewForm(this);
			mdRegistrySetting.RegistryWrite(PreferenceForms, "SplitterPosition", System.Convert.ToString(this.SplitContainerControl1.SplitterPosition));
			mdRegistrySetting.RegistryWrite(PreferenceForms, "gvObjects.ShowFilterRow", this.gvObjects.OptionsView.ShowAutoFilterRow.ToString());
			mdRegistrySetting.RegistryWrite(PreferenceForms, "gvObjects.ShowFindPanel", this.gvObjects.OptionsFind.AlwaysVisible.ToString());
			mdRegistrySetting.RegistryWrite(PreferenceForms, "SelectedObject", this.Accord.SelectedElement.Name);
		}
		// загрузка формы
		public void frBooks_ResearchObjects_Load(object sender, EventArgs e)
		{
			this.acRoot.HeaderVisible = false;
			// загрузка объектов
			Designer_ObjectsTypes();
			// настройка элементов
			PreferenceForms = mdVariables.pref_UserSettings + this.Name + "\\";
			clsMyUserFunction.LoadViewForm(this);
			this.SplitContainerControl1.SplitterPosition = System.Convert.ToInt32(mdRegistrySetting.RegistryRead(PreferenceForms, "SplitterPosition", System.Convert.ToString(180)));
			this.gcnObjects.CustomHeaderButtons[4].Properties.Checked = System.Convert.ToBoolean(mdRegistrySetting.RegistryRead(PreferenceForms, "gvObjects.ShowFindPanel", System.Convert.ToString(false)));
			this.gcnObjects.CustomHeaderButtons[5].Properties.Checked = System.Convert.ToBoolean(mdRegistrySetting.RegistryRead(PreferenceForms, "gvObjects.ShowFilterRow", System.Convert.ToString(false)));
			this.Accord.SelectedElement = this.acRoot.Elements[System.Convert.ToString(mdRegistrySetting.RegistryRead(PreferenceForms, "SelectedObject", this.acRoot.Elements[0].Name))];
			this.lbDB_name.Caption = mdVariables.pref_DataBaseName;
			this.lbServerName.Caption = mdVariables.pref_ServerIP;
		}
		// выбор типа объекта
		public void Accord_SelectedElementChanged(object sender, SelectedElementChangedEventArgs e)
		{
			SelectedObjectType = e.Element.Name;
			Designer_Objects();
		}
		// группа кнопок объектов
		public void gcnObjects_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
		{
			bool btnAddEdit = false;
			GroupBoxButton btn = e.Button;
			switch (btn.Caption)
			{
				case "btnAddObject":
					frAddEditObjects.Default.AddEdit = 2;
					btnAddEdit = true;
					break;
				case "btnEditObject":
					if (this.gvObjects.RowCount != 0)
					{
						frAddEditObjects.Default.AddEdit = 3;
						btnAddEdit = true;
					}
					break;
				case "btnDeleteObject":
					if (this.gvObjects.RowCount != 0)
					{
						btnDeleteObject();
					}
					break;
				case "btnClearSort_Object":
					this.gvObjects.ClearSorting();
					break;
			}
			// если добавление или редактирование
			if (btnAddEdit)
			{
				if (frAddEditObjects.Default.ShowDialog() == DialogResult.OK)
				{
					Designer_Objects();
					Designer_ObjectsTypes();
				}
			}
		}
		// группа чеков объектов
		public void gcnMethods_CustomButtonChecked(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
		{
			GroupBoxButton btn = e.Button;
			switch (btn.Caption)
			{
				case "btnSearch_Object":
					this.gvObjects.OptionsFind.AlwaysVisible = btn.Checked;
					// при отключении очищаем фильтрацию
					if (btn.Checked == false)
					{
						this.gvObjects.FindFilterText = null;
					}
					break;
				case "btnAutoFilter_Object":
					this.gvObjects.OptionsView.ShowAutoFilterRow = btn.Checked;
					// при отключении очищаем фильтрацию
					if (btn.Checked == false)
					{
						this.gvObjects.ClearColumnsFilter();
					}
					break;
			}
		}
		// настройки сетки типов объектов
		private void Designer_ObjectsTypes()
		{
			// загрузка объектов
			mdQuery.SelectQueryData("Books_ObjectsTypes." + this.Name, "SELECT * FROM vBooks_ObjectsTypes", "GetObjectsTypes");
			this.acRoot.Elements.Clear();
			foreach (DataRow r in mdQuery.iDataSet.Tables["Books_ObjectsTypes." + this.Name].Rows)
			{
				AccordionControlElement el = new AccordionControlElement();
				el.Name = "btn" + System.Convert.ToString(r["Name"]);
				el.Text = "<image=#" + System.Convert.ToString(r["Icon"]) + ">   " + System.Convert.ToString(r["NameCountHtml"]);
				el.Tag = r["Id"];
				el.Style = ElementStyle.Item;
				el.Height = 40;
				this.acRoot.Elements.Add(el);
			}
			this.Accord.SelectedElement = this.acRoot.Elements[SelectedObjectType];
		}
		// настройки сетки объектов
		private void Designer_Objects()
		{
			mdVariables.EventChangedControl = false;
			mdQuery.SelectQueryData("Books_Objects." + this.Name,
				"EXEC Books_ObjectsFunc @ObjectTypeId = " + System.Convert.ToString(this.Accord.SelectedElement.Tag) +, System.Convert.ToString(
				@Function == 1));
			if (ReferenceEquals(this.gcObjects.DataSource, null))
			{
				this.gcObjects.DataSource = mdQuery.iDataSet.Tables["Books_Objects." + this.Name];
				mdHidenAllColumns.HidenAllColumns_Grid(this.gvObjects, mdQuery.iDataSet.Tables["Books_Objects." + this.Name]);
				this.gvObjects.Columns["NameLatin"].Visible = true;
				this.gvObjects.Columns["NameLatin"].Caption = "Наименование(латин)";
				this.gvObjects.Columns["Name"].Visible = true;
				this.gvObjects.Columns["Name"].Caption = "Наименование (русс)";
				this.gvObjects.PreviewFieldName = "MethodsString";
				this.gvObjects.BestFitColumns();
			}
			mdVariables.EventChangedControl = true;
			// активная строка из памяти
			this.gvObjects.FocusedRowHandle = this.gvObjects.LocateByValue("Id", System.Convert.ToInt32(NewId_Object));
		}
		// удалить или редактировать объект клавиотурой
		public void gvObjects_KeyDown(dynamic sender, KeyEventArgs e)
		{
			if (sender.FocusedRowHandle < 0)
			{
				return;
			}
			if (e.KeyCode == Keys.Delete)
			{
				btnDelObject_ItemClick(e, null);
			}
			if (e.KeyCode == Keys.Enter)
			{
				btnEditObject_ItemClick(e, null);
			}
		}
		// удаление объекта
		private void btnDeleteObject()
		{
			int RowNumber = this.gvObjects.FocusedRowHandle;
			if (XtraMessageBox.Show("Объект исследования с именем <b>" + this.gvObjects.GetFocusedRowCellDisplayText("Name") + "</b> будет удален!" + "\n" +
					"Вы согласны?", Application.ProductName, MessageBoxButtons.YesNo,
					MessageBoxIcon.Question, DevExpress.Utils.DefaultBoolean.True) == DialogResult.Yes)
					{
					mdQuery.ExecuteScalar(
						"EXEC Books_ObjectsFunc " +
						"@ObjectId = " + this.gvObjects.GetFocusedRowCellDisplayText("Id") + ", " +
						"@Function = 4",
						"Books_ClassificationsProducts.Function = 4"
						);
				Designer_Objects();
				Designer_ObjectsTypes();
				this.gvObjects.FocusedRowHandle = RowNumber - 1;
			}
		}
		// вызов контекстного меню на объектах
		public void gvObjects_MouseDown(object sender, MouseEventArgs e)
		{
			GridView view = (GridView) sender;
			Point pt = view.GridControl.PointToClient(Control.MousePosition);
			GridHitInfo info = view.CalcHitInfo(pt);
			if (e.Button == MouseButtons.Right)
			{
				this.btnEditObject.Enabled = info.InRow;
				this.btnDelObject.Enabled = info.InRow;
				this.pmObjects.ShowPopup(MousePosition);
			}
			if (info.InRow & e.Button == MouseButtons.Left & e.Clicks == 2)
			{
				btnEditObject_ItemClick(e, null);
			}
		}
		// фокус на объектах
		public void gvObjects_FocusedRowChanged(dynamic sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			if (e.FocusedRowHandle < 0)
			{
				return;
			}
			DataRow iRow = sender.GetFocusedDataRow;
			if (mdVariables.EventChangedControl)
			{
				NewId_Object = iRow["Id"].ToString();
			}
		}
		
#region Контекстное меню на объектах
		// добавить объект
		public void btnAddObject_ItemClick(object sender, ItemClickEventArgs e)
		{
			gcnObjects_CustomButtonClick(this.gcnObjects, new DevExpress.XtraBars.Docking2010.BaseButtonEventArgs(this.gcnObjects.CustomHeaderButtons[0]));
		}
		// редактировать объект
		public void btnEditObject_ItemClick(object sender, ItemClickEventArgs e)
		{
			gcnObjects_CustomButtonClick(this.gcnObjects, new DevExpress.XtraBars.Docking2010.BaseButtonEventArgs(this.gcnObjects.CustomHeaderButtons[1]));
		}
		// удалить объект
		public void btnDelObject_ItemClick(object sender, ItemClickEventArgs e)
		{
			gcnObjects_CustomButtonClick(this.gcnObjects, new DevExpress.XtraBars.Docking2010.BaseButtonEventArgs(this.gcnObjects.CustomHeaderButtons[2]));
		}
#endregion
		
		// кнопка Обновить
		public void btnUpdate_ItemClick(object sender, ItemClickEventArgs e)
		{
			Designer_Objects();
		}
		// проверка полей по таймеру
		public void tmChecked_Tick(object sender, EventArgs e)
		{
			int ObjectsCount = this.gvObjects.RowCount;
			this.gcnObjects.CustomHeaderButtons[0].Properties.Enabled = this.acRoot.Elements.Count != 0;
			this.btnAddObject.Enabled = this.acRoot.Elements.Count != 0;
			this.gcnObjects.CustomHeaderButtons[1].Properties.Enabled = ObjectsCount != 0;
			this.btnEditObject.Enabled = ObjectsCount != 0;
			this.gcnObjects.CustomHeaderButtons[2].Properties.Enabled = ObjectsCount != 0;
			this.btnDelObject.Enabled = ObjectsCount != 0;
			// подсчет столбцов с примененной сортировкой
			int ColCount = 0;
			foreach (GridColumn c in this.gvObjects.SortedColumns)
			{
				ColCount++;
			}
			this.gcnObjects.CustomHeaderButtons[6].Properties.Enabled = ColCount != 0;
		}
	}
}
