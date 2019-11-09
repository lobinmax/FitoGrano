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
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraTab;
using DevExpress.XtraTreeList.Nodes;
using FitoGrano;

namespace FitoGrano
{
	
	public partial class frBooks_CountryAgreements
	{
		public frBooks_CountryAgreements()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frBooks_CountryAgreements defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frBooks_CountryAgreements Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frBooks_CountryAgreements();
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
		internal string NewId_Countries; // Ид новой страны
		internal string NewId_Agreement; // Ид нового соглашения
		
		// закрытие формы
		public void frBooks_FormClosing(object sender, FormClosingEventArgs e)
		{
			clsMyUserFunction.RemoveTableDataSet(this);
			clsMyUserFunction.SaveViewForm(this);
			mdRegistrySetting.RegistryWrite(PreferenceForms, "SplitterPosition", System.Convert.ToString(this.SplitContainerControl1.SplitterPosition));
			mdRegistrySetting.RegistryWrite(PreferenceForms, "gvCountries.ShowFilterRow", this.gvCountries.OptionsView.ShowAutoFilterRow.ToString());
			mdRegistrySetting.RegistryWrite(PreferenceForms, "gvCountries.ShowFindPanel", this.gvCountries.OptionsFind.AlwaysVisible.ToString());
			mdRegistrySetting.RegistryWrite(PreferenceForms, "gvAgreements.ShowFilterRow", this.gvAgreement.OptionsView.ShowAutoFilterRow.ToString());
			mdRegistrySetting.RegistryWrite(PreferenceForms, "gvAgreements.ShowFindPanel", this.gvAgreement.OptionsFind.AlwaysVisible.ToString());
		}
		// загрузка формы
		public void frBooks_ResearchObjects_Load(object sender, EventArgs e)
		{
			// настройка элементов
			PreferenceForms = mdVariables.pref_UserSettings + this.Name + "\\";
			clsMyUserFunction.LoadViewForm(this);
			this.SplitContainerControl1.SplitterPosition = System.Convert.ToInt32(mdRegistrySetting.RegistryRead(PreferenceForms, "SplitterPosition", System.Convert.ToString(252)));
			this.gcnCountries.CustomHeaderButtons[4].Properties.Checked = System.Convert.ToBoolean(mdRegistrySetting.RegistryRead(PreferenceForms, "gvCountries.ShowFindPanel", System.Convert.ToString(false)));
			this.gcnCountries.CustomHeaderButtons[5].Properties.Checked = System.Convert.ToBoolean(mdRegistrySetting.RegistryRead(PreferenceForms, "gvCountries.ShowFilterRow", System.Convert.ToString(false)));
			this.gcnAgreements.CustomHeaderButtons[4].Properties.Checked = System.Convert.ToBoolean(mdRegistrySetting.RegistryRead(PreferenceForms, "gvAgreements.ShowFindPanel", System.Convert.ToString(false)));
			this.gcnAgreements.CustomHeaderButtons[5].Properties.Checked = System.Convert.ToBoolean(mdRegistrySetting.RegistryRead(PreferenceForms, "gvAgreements.ShowFilterRow", System.Convert.ToString(false)));
			this.lbProductIdIsNull.Parent = this.tlObjectsQurantine.tlQurantineObjects;
			this.tlObjectsQurantine.tlQurantineObjects.OptionsView.ShowPreview = true;
			this.tlObjectsQurantine.tlQurantineObjects.PreviewFieldName = "PreviewString";
			this.tlObjectsQurantine.tlQurantineObjects.OptionsView.AutoCalcPreviewLineCount = true;
			this.tlObjectsQurantine.tlQurantineObjects.OptionsView.ShowHorzLines = true;
			this.tlObjectsQurantine.tlQurantineObjects.OptionsView.ShowVertLines = true;
			
			// измерение содержания
			mdQuery.SelectQueryData("Units." + this.Name, "SELECT bu.Id, bu.Name FROM Books_Units bu", "GetUnits");
			this.cmbUnits.Properties.DataSource = mdQuery.iDataSet.Tables["Units." + this.Name];
			this.cmbUnits.Properties.ValueMember = "Id";
			this.cmbUnits.Properties.DisplayMember = "Name";
			this.cmbUnits.Properties.KeyMember = "Name";
			
			this.cmbUnits.Properties.PopulateColumns();
			this.cmbUnits.Properties.Columns["Id"].Visible = false;
			
			
			string SelectedTabPage = System.Convert.ToString(mdRegistrySetting.RegistryRead(PreferenceForms, "SelectedTabPage", ""));
			foreach (XtraTabPage tb in this.XtraTabControl.TabPages)
			{
				if (tb.Name == SelectedTabPage)
				{
					this.XtraTabControl.SelectedTabPage = tb;
				}
			}
			this.lbDB_name.Caption = mdVariables.pref_DataBaseName;
			this.lbServerName.Caption = mdVariables.pref_ServerIP;
			Designer_Countries();
			
			// активируем событие на первой строке в странах
			gvCountries_FocusedRowChanged(gvCountries, new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs(0, 0));
			
			// добавляем обработку событий на дереве продукции
			this.tlClassificationProducts.tlClassification.AfterFocusNode += tlClassification_AfterFocusNode;
			this.tlObjectsQurantine.tlQurantineObjects.AfterFocusNode += tlQurantineObjects_AfterFocusNode;
		}
		
#region Страны
		// настройка списка стран
		private void Designer_Countries()
		{
			mdVariables.EventChangedControl = false;
			mdQuery.SelectQueryData(
				"Books_Contries." + this.Name,
				"EXEC Books_CountriesFunction @Parameter = 1, @Function = 1",
				"GetCountries"
				);
			if (ReferenceEquals(this.gcCountries.DataSource, null))
			{
				this.gcCountries.DataSource = mdQuery.iDataSet.Tables["Books_Contries." + this.Name];
				mdHidenAllColumns.HidenAllColumns_Grid(this.gvCountries, mdQuery.iDataSet.Tables["Books_Contries." + this.Name]);
				this.gvCountries.Columns["Name_a1"].Visible = true;
				this.gvCountries.Columns["Name_a1"].Caption = "Наименование";
			}
			mdVariables.EventChangedControl = true;
			this.gvCountries.FocusedRowHandle = this.gvCountries.LocateByValue("Id", System.Convert.ToInt32(NewId_Countries));
		}
		// группа кнопок стран
		public void gcnObjects_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
		{
			bool btnAddEdit = false;
			GroupBoxButton btn = e.Button;
			switch (btn.VisibleIndex)
			{
				case 0:
					frAddEditCountry.Default.AddEdit = 2;
					btnAddEdit = true;
					break;
				case 1:
					if (this.gvCountries.RowCount != 0)
					{
						frAddEditCountry.Default.AddEdit = 3;
						btnAddEdit = true;
					}
					break;
				case 2:
					if (this.gvCountries.RowCount != 0)
					{
						DeleteCountry();
					}
					break;
				case 6:
					this.gvCountries.ClearSorting();
					break;
			}
			// если добавление или редактирование
			if (btnAddEdit)
			{
				if (frAddEditCountry.Default.ShowDialog() == DialogResult.OK)
				{
					Designer_Countries();
				}
			}
		}
		// группа чеков стран
		public void gcnCountries_CustomButtonChecked(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
		{
			GroupBoxButton btn = e.Button;
			switch (btn.VisibleIndex)
			{
				case 4:
					this.gvCountries.OptionsFind.AlwaysVisible = btn.Checked;
					// при отключении очищаем фильтрацию
					if (btn.Checked == false)
					{
						this.gvCountries.FindFilterText = null;
					}
					break;
				case 5:
					this.gvCountries.OptionsView.ShowAutoFilterRow = btn.Checked;
					// при отключении очищаем фильтрацию
					if (btn.Checked == false)
					{
						this.gvCountries.ClearColumnsFilter();
					}
					break;
			}
		}
		// удалить или редактировать объект клавиатурой
		public void gvCountries_KeyDown(dynamic sender, KeyEventArgs e)
		{
			if (sender.FocusedRowHandle < 0)
			{
				return;
			}
			if (e.KeyCode == Keys.Delete) // удаление
			{
				btnDelCountry_ItemClick(e, null);
			}
			if (e.KeyCode == Keys.Enter) // редиктирование
			{
				btnEditCountry_ItemClick(e, null);
			}
		}
		// удаление страны
		private void DeleteCountry()
		{
			int RowNumber = this.gvCountries.FocusedRowHandle;
			string vl = ""; // что вернет сервер
			if (XtraMessageBox.Show("Страна с именем <b>" + this.gvCountries.GetFocusedRowCellDisplayText("NameShort") + "</b> будет удалена!" + "\n" +
					"Имейте ввиду что так же будут удалены все сущности принадлежащие данной стране! " + "\n" +
					"Вы согласны?", Application.ProductName, MessageBoxButtons.YesNo,
					MessageBoxIcon.Question, DevExpress.Utils.DefaultBoolean.True) == DialogResult.Yes)
					{
					vl = System.Convert.ToString(mdQuery.ExecuteScalar(
						"EXEC Books_CountriesFunction " +
						"@CountryId = " + this.gvCountries.GetFocusedRowCellDisplayText("Id") + ", " +
						"@Parameter = 1," +
						"@Function = 4",
						"Books_CountriesFunction.Function = 4, Parameter = 1"
						));
				if (vl != "err")
				{
					this.gvCountries.FocusedRowHandle = RowNumber - 1;
				}
				Designer_Countries();
			}
		}
		// вызов контекстного меню на объектах
		public void gvCountries_MouseDown(object sender, MouseEventArgs e)
		{
			GridView view = (GridView) sender;
			Point pt = view.GridControl.PointToClient(Control.MousePosition);
			GridHitInfo info = view.CalcHitInfo(pt);
			if (e.Button == MouseButtons.Right)
			{
				this.btnEditCountry.Enabled = info.InRow;
				this.btnDeleteCountry.Enabled = info.InRow;
				this.pmMenuCountries.ShowPopup(MousePosition);
			}
			// двойной клик для редактирования
			if (info.InRow & e.Button == MouseButtons.Left & e.Clicks == 2)
			{
				btnEditCountry_ItemClick(e, null);
			}
		}
		
#region Контекстное меню на странах
		// добавить страну
		public void btnAddCountry_ItemClick(object sender, ItemClickEventArgs e)
		{
			gcnObjects_CustomButtonClick(this.gcnCountries, new DevExpress.XtraBars.Docking2010.BaseButtonEventArgs(this.gcnCountries.CustomHeaderButtons[0]));
		}
		// редактировать страну
		public void btnEditCountry_ItemClick(object sender, ItemClickEventArgs e)
		{
			gcnObjects_CustomButtonClick(this.gcnCountries, new DevExpress.XtraBars.Docking2010.BaseButtonEventArgs(this.gcnCountries.CustomHeaderButtons[1]));
		}
		// удалить страну
		public void btnDelCountry_ItemClick(object sender, ItemClickEventArgs e)
		{
			gcnObjects_CustomButtonClick(this.gcnCountries, new DevExpress.XtraBars.Docking2010.BaseButtonEventArgs(this.gcnCountries.CustomHeaderButtons[2]));
		}
#endregion
		// фокус на стране
		public void gvCountries_FocusedRowChanged(dynamic sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			if (e.FocusedRowHandle < 0)
			{
				return;
			}
			DataRow iRow = sender.GetFocusedDataRow;
			if (mdVariables.EventChangedControl)
			{
				NewId_Countries = iRow["Id"].ToString();
				// настройка Карантинов
				Designer_Quarantine();
				this.tlClassificationProducts.SetCaptionTreeList("Классификация продукции: " + "\n" +
					this.gvCountries.GetFocusedRowCellDisplayText("NameShort"));
				// настройка Соглашений
				Designer_Agreements();
			}
		}
#endregion
		
		
#region Карантинные объекты
		private void Designer_Quarantine()
		{
			tlClassificationProducts.LoadTreeList(CountryId: this.gvCountries.GetFocusedRowCellDisplayText("Id"), FilterParametr: "=");
		}
		
		private void tlClassification_AfterFocusNode(System.Object sender, DevExpress.XtraTreeList.NodeEventArgs e)
		{
			string CountryId = this.gvCountries.GetFocusedRowCellDisplayText("Id");
			string ProductId = this.tlClassificationProducts.GetFocusedProductId();
			
			if (ProductId == "NULL")
			{
				this.tlObjectsQurantine.ClearDataSet();
				this.lbProductIdIsNull.Visible = true;
			}
			else
			{
				this.lbProductIdIsNull.Visible = false;
				this.tlObjectsQurantine.LoadTreeList(TableName: null, CountryId: CountryId, ProductId: ProductId);
			}
		}
		
		private void tlQurantineObjects_AfterFocusNode(System.Object sender, DevExpress.XtraTreeList.NodeEventArgs e)
		{
			TreeListNode nd = this.tlObjectsQurantine.tlQurantineObjects.FocusedNode;
			
			if ((int) nd["Level"] == 0)
			{
				this.gcObjectIformation.Visible = false;
				this.tlObjectsQurantine.Size = new System.Drawing.Size(this.tlObjectsQurantine.Size.Width, this.tlClassificationProducts.Size.Height);
			}
			else
			{
				this.gcObjectIformation.Visible = true;
				this.txtNorma.EditValue = nd["NormValue"];
				this.cmbUnits.EditValue = nd["UnitId"];
			}
		}
#endregion
		
#region Соглашения
		// настройка списка соглашений
		private void Designer_Agreements()
		{
			mdVariables.EventChangedControl = false;
			SelectQueryData(
				"Books_Agreementss." + this.Name,
				EXEC Books_CountriesFunction
				@CountryId == " & Me.gvCountries.GetFocusedRowCellDisplayText(" Id ") & ",
				@Parameter == 2,
				@Function == 1,
				"GetAgreements"
				);
			if (ReferenceEquals(this.gcAgreement.DataSource, null))
			{
				this.gcAgreement.DataSource = mdQuery.iDataSet.Tables["Books_Agreementss." + this.Name];
				mdHidenAllColumns.HidenAllColumns_Grid(this.gvAgreement, mdQuery.iDataSet.Tables["Books_Agreementss." + this.Name]);
				this.gvAgreement.Columns["AgreementText"].Visible = true;
				this.gvAgreement.Columns["AgreementText"].Caption = "Текст соглашения";
				// для многострочного отображения подключаем репозиторий
				this.gvAgreement.Columns["AgreementText"].ColumnEdit = new RepositoryItemMemoEdit();
			}
			mdVariables.EventChangedControl = true;
			this.gvAgreement.FocusedRowHandle = this.gvAgreement.LocateByValue("Id", System.Convert.ToInt32(NewId_Agreement));
		}
		// группа кнопок соглашений
		public void gcnAgreements_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
		{
			bool btnAddEdit = false;
			GroupBoxButton btn = e.Button;
			switch (btn.VisibleIndex)
			{
				case 0:
					frAddEditCountryAgreement.Default.AddEdit = 2;
					btnAddEdit = true;
					break;
				case 1:
					if (this.gvAgreement.RowCount != 0)
					{
						frAddEditCountryAgreement.Default.AddEdit = 3;
						btnAddEdit = true;
					}
					break;
				case 2:
					if (this.gvAgreement.RowCount != 0)
					{
						DeleteAgreement();
					}
					break;
				case 6:
					this.gvAgreement.ClearSorting();
					break;
			}
			// если добавление или редактирование
			if (btnAddEdit)
			{
				if (frAddEditCountryAgreement.Default.ShowDialog() == DialogResult.OK)
				{
					Designer_Agreements();
				}
			}
		}
		// группа чеков соглашений
		public void gcnAgreements_CustomButtonChecked(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
		{
			GroupBoxButton btn = e.Button;
			switch (btn.VisibleIndex)
			{
				case 4:
					this.gvAgreement.OptionsFind.AlwaysVisible = btn.Checked;
					// при отключении очищаем фильтрацию
					if (btn.Checked == false)
					{
						this.gvAgreement.FindFilterText = null;
					}
					break;
				case 5:
					this.gvAgreement.OptionsView.ShowAutoFilterRow = btn.Checked;
					// при отключении очищаем фильтрацию
					if (btn.Checked == false)
					{
						this.gvAgreement.ClearColumnsFilter();
					}
					break;
			}
		}
		// удаление соглашения
		private void DeleteAgreement()
		{
			int RowNumber = this.gvAgreement.FocusedRowHandle;
			string vl = ""; // что вернет сервер
			if (XtraMessageBox.Show("Соглашение по стране <b>" + this.gvCountries.GetFocusedRowCellDisplayText("Name_a1") + "</b> будет удалено!" + "\n" +
					"Вы согласны?", Application.ProductName, MessageBoxButtons.YesNo,
					MessageBoxIcon.Question, DevExpress.Utils.DefaultBoolean.True) == DialogResult.Yes)
					{
					vl = System.Convert.ToString(mdQuery.ExecuteScalar(
						"EXEC Books_CountriesFunction " +
						"@AgreementId = " + this.gvAgreement.GetFocusedRowCellDisplayText("AgreementId") + ", " +
						"@Parameter = 2," +
						"@Function = 4",
						"Books_CountriesFunction.Function = 4, Parameter = 2"
						));
				if (vl != "err")
				{
					this.gvAgreement.FocusedRowHandle = RowNumber - 1;
					Designer_Agreements();
				}
			}
		}
		// вызов контекстного меню на объектах
		public void gvAgreement_MouseDown(object sender, MouseEventArgs e)
		{
			GridView view = (GridView) sender;
			Point pt = view.GridControl.PointToClient(Control.MousePosition);
			GridHitInfo info = view.CalcHitInfo(pt);
			if (e.Button == MouseButtons.Right)
			{
				this.btnEditAgreement.Enabled = info.InRow;
				this.btnDeleteAgreement.Enabled = info.InRow;
				this.pmMenuAgreements.ShowPopup(MousePosition);
			}
			// двойной клик для редактирования
			if (info.InRow & e.Button == MouseButtons.Left & e.Clicks == 2)
			{
				btnEditAgreement_ItemClick(e, null);
			}
		}
		
#region Контекстное меню на соглашениях
		// добавить соглашение
		public void btnAddAgreement_ItemClick(object sender, ItemClickEventArgs e)
		{
			gcnAgreements_CustomButtonClick(this.gcnAgreements, new DevExpress.XtraBars.Docking2010.BaseButtonEventArgs(this.gcnAgreements.CustomHeaderButtons[0]));
		}
		// редактировать соглашение
		public void btnEditAgreement_ItemClick(object sender, ItemClickEventArgs e)
		{
			gcnAgreements_CustomButtonClick(this.gcnAgreements, new DevExpress.XtraBars.Docking2010.BaseButtonEventArgs(this.gcnAgreements.CustomHeaderButtons[1]));
		}
		// удалить Соглашение
		public void btnDeleteAgreement_ItemClick(object sender, ItemClickEventArgs e)
		{
			gcnAgreements_CustomButtonClick(this.gcnAgreements, new DevExpress.XtraBars.Docking2010.BaseButtonEventArgs(this.gcnAgreements.CustomHeaderButtons[2]));
		}
#endregion
		// фокус на соглашении
		public void gvAgreement_FocusedRowChanged(dynamic sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			if (e.FocusedRowHandle < 0)
			{
				return;
			}
			DataRow iRow = sender.GetFocusedDataRow;
			if (mdVariables.EventChangedControl)
			{
				NewId_Agreement = iRow["AgreementId"].ToString();
			}
		}
#endregion
		
		
		
		
		
		
		public void XtraTabControl_SelectedPageChanged(object sender, TabPageChangedEventArgs e)
		{
			if (this.XtraTabControl.SelectedTabPage != null)
			{
				mdRegistrySetting.RegistryWrite(PreferenceForms, "SelectedTabPage", this.XtraTabControl.SelectedTabPage.Name.ToString());
			}
		}
		
		// проверка полей по таймеру
		public void tmChecked_Tick(object sender, EventArgs e)
		{
			int CountryCount = this.gvCountries.RowCount;
			int AgreementCount = this.gvAgreement.RowCount;
			
			// страны
			this.gcnCountries.CustomHeaderButtons[1].Properties.Enabled = CountryCount != 0;
			this.btnEditCountry.Enabled = CountryCount != 0;
			this.gcnCountries.CustomHeaderButtons[2].Properties.Enabled = CountryCount != 0;
			this.btnDeleteCountry.Enabled = CountryCount != 0;
			
			// соглашения
			this.gcnAgreements.CustomHeaderButtons[0].Properties.Enabled = CountryCount != 0;
			this.btnAddAgreement.Enabled = CountryCount != 0;
			this.gcnAgreements.CustomHeaderButtons[1].Properties.Enabled = AgreementCount != 0;
			this.btnEditAgreement.Enabled = AgreementCount != 0;
			this.gcnAgreements.CustomHeaderButtons[2].Properties.Enabled = AgreementCount != 0;
			this.btnDeleteAgreement.Enabled = AgreementCount != 0;
			
			// подсчет столбцов с примененной сортировкой
			// Страны
			int ColCount = 0;
			foreach (GridColumn c in this.gvCountries.SortedColumns)
			{
				ColCount++;
			}
			this.gcnCountries.CustomHeaderButtons[6].Properties.Enabled = ColCount != 0;
			
			// Соглашения
			foreach (GridColumn c in this.gvAgreement.SortedColumns)
			{
				ColCount++;
			}
			this.gcnAgreements.CustomHeaderButtons[6].Properties.Enabled = ColCount != 0;
		}
		
		public void btnUpdate_ItemClick(object sender, ItemClickEventArgs e)
		{
			MessageBox.Show("Не реализовано ...");
		}
		
		public void lbProductIdIsNull_Click(object sender, EventArgs e)
		{
			
		}
	}
}
