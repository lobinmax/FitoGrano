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
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
		public partial class frBooks_ClassificationProducts : DevExpress.XtraEditors.XtraForm
		{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]
			protected override void Dispose(bool disposing)
			{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}
		
		//Required by the Windows Form Designer
		private System.ComponentModel.Container components = null;
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
			private void InitializeComponent()
			{
			this.components = new System.ComponentModel.Container();
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(frBooks_FormClosing);
			this.Load += new System.EventHandler(frBooks_ClassificationProducts_Load);
			DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions ButtonImageOptions1 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
			DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions ButtonImageOptions2 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
			DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions ButtonImageOptions3 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
			DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions ButtonImageOptions4 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
			DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions ButtonImageOptions5 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
			DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions ButtonImageOptions6 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
			DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions ButtonImageOptions7 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frBooks_ClassificationProducts));
			DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions ButtonImageOptions8 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
			DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions ButtonImageOptions9 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
			DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions ButtonImageOptions10 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
			DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions ButtonImageOptions11 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
			DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions ButtonImageOptions12 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
			DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions ButtonImageOptions13 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
			DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions ButtonImageOptions14 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
			this.SplitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
			this.gcnClassification = new DevExpress.XtraEditors.GroupControl();
			this.gcnClassification.CustomButtonClick += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.gcnClassification_CustomButtonClick);
			this.gcnClassification.CustomButtonChecked += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.gcnClassification_CustomButtonChecked);
			this.gcnClassification.CustomButtonUnchecked += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.gcnClassification_CustomButtonChecked);
			this.gcClassification = new DevExpress.XtraGrid.GridControl();
			this.gvClassification = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gvClassification.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvClassification_FocusedRowChanged);
			this.gvClassification.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gvPerformers_MouseDown);
			this.gvClassification.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvClassification_KeyDown);
			this.BarManager1 = new DevExpress.XtraBars.BarManager(this.components);
			this.Bar1 = new DevExpress.XtraBars.Bar();
			this.Bar3 = new DevExpress.XtraBars.Bar();
			this.lbServerName = new DevExpress.XtraBars.BarStaticItem();
			this.lbDB_name = new DevExpress.XtraBars.BarStaticItem();
			this.btnUpdate = new DevExpress.XtraBars.BarButtonItem();
			this.btnUpdate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUpdate_ItemClick);
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.btnAddClassifications = new DevExpress.XtraBars.BarButtonItem();
			this.btnAddClassifications.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddClassifications_ItemClick);
			this.btnEditClassifications = new DevExpress.XtraBars.BarButtonItem();
			this.btnEditClassifications.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditClassifications_ItemClick);
			this.btnDeleteClassifications = new DevExpress.XtraBars.BarButtonItem();
			this.btnDeleteClassifications.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDeleteClassifications_ItemClick);
			this.btnAddProducts = new DevExpress.XtraBars.BarButtonItem();
			this.btnAddProducts.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddProducts_ItemClick);
			this.btnEditProducts = new DevExpress.XtraBars.BarButtonItem();
			this.btnEditProducts.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditProducts_ItemClick);
			this.btnDeleteProducts = new DevExpress.XtraBars.BarButtonItem();
			this.btnDeleteProducts.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDeleteProducts_ItemClick);
			this.BarStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
			this.BarStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
			this.gcnProducts = new DevExpress.XtraEditors.GroupControl();
			this.gcnProducts.CustomButtonClick += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.gcnProducts_CustomButtonClick);
			this.gcnProducts.CustomButtonChecked += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.gcnProducts_CustomButtonChecked);
			this.gcnProducts.CustomButtonUnchecked += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.gcnProducts_CustomButtonChecked);
			this.gcProducts = new DevExpress.XtraGrid.GridControl();
			this.gvProducts = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gvProducts.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvProducts_FocusedRowChanged);
			this.gvProducts.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gvProducts_MouseDown);
			this.gvProducts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvProducts_KeyDown);
			this.tmChecked = new System.Windows.Forms.Timer(this.components);
			this.tmChecked.Tick += new System.EventHandler(this.tmChecked_Tick);
			this.pmMenuClassifications = new DevExpress.XtraBars.PopupMenu(this.components);
			this.pmMenuProducts = new DevExpress.XtraBars.PopupMenu(this.components);
			((System.ComponentModel.ISupportInitialize) this.SplitContainerControl1).BeginInit();
			this.SplitContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.gcnClassification).BeginInit();
			this.gcnClassification.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.gcClassification).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.gvClassification).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.BarManager1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.gcnProducts).BeginInit();
			this.gcnProducts.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.gcProducts).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.gvProducts).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.pmMenuClassifications).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.pmMenuProducts).BeginInit();
			this.SuspendLayout();
			//
			//SplitContainerControl1
			//
			this.SplitContainerControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.SplitContainerControl1.CaptionLocation = DevExpress.Utils.Locations.Top;
			this.SplitContainerControl1.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
			this.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SplitContainerControl1.Location = new System.Drawing.Point(0, 29);
			this.SplitContainerControl1.Name = "SplitContainerControl1";
			this.SplitContainerControl1.Panel1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", (float) (8.25F), (System.Drawing.FontStyle) ((int) (System.Drawing.FontStyle.Bold) | (int) System.Drawing.FontStyle.Underline));
			this.SplitContainerControl1.Panel1.AppearanceCaption.Options.UseFont = true;
			this.SplitContainerControl1.Panel1.AppearanceCaption.Options.UseTextOptions = true;
			this.SplitContainerControl1.Panel1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.SplitContainerControl1.Panel1.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
			this.SplitContainerControl1.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.SplitContainerControl1.Panel1.Controls.Add(this.gcnClassification);
			this.SplitContainerControl1.Panel1.MinSize = 30;
			this.SplitContainerControl1.Panel2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", (float) (8.25F), (System.Drawing.FontStyle) ((int) (System.Drawing.FontStyle.Bold) | (int) System.Drawing.FontStyle.Underline));
			this.SplitContainerControl1.Panel2.AppearanceCaption.Options.UseFont = true;
			this.SplitContainerControl1.Panel2.AppearanceCaption.Options.UseTextOptions = true;
			this.SplitContainerControl1.Panel2.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.SplitContainerControl1.Panel2.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
			this.SplitContainerControl1.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.SplitContainerControl1.Panel2.CaptionLocation = DevExpress.Utils.Locations.Top;
			this.SplitContainerControl1.Panel2.Controls.Add(this.gcnProducts);
			this.SplitContainerControl1.Size = new System.Drawing.Size(914, 475);
			this.SplitContainerControl1.SplitterPosition = 319;
			this.SplitContainerControl1.TabIndex = 0;
			//
			//gcnClassification
			//
			this.gcnClassification.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (8.0F));
			this.gcnClassification.Appearance.Options.UseFont = true;
			this.gcnClassification.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", (float) (9.0F), (System.Drawing.FontStyle) ((int) (System.Drawing.FontStyle.Bold) | (int) System.Drawing.FontStyle.Underline));
			this.gcnClassification.AppearanceCaption.Options.UseFont = true;
			this.gcnClassification.AppearanceCaption.Options.UseTextOptions = true;
			this.gcnClassification.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
			this.gcnClassification.Controls.Add(this.gcClassification);
			ButtonImageOptions1.Image = (System.Drawing.Image) (resources.GetObject("ButtonImageOptions1.Image"));
			ButtonImageOptions2.Image = (System.Drawing.Image) (resources.GetObject("ButtonImageOptions2.Image"));
			ButtonImageOptions3.Image = (System.Drawing.Image) (resources.GetObject("ButtonImageOptions3.Image"));
			ButtonImageOptions5.Image = (System.Drawing.Image) (resources.GetObject("ButtonImageOptions5.Image"));
			ButtonImageOptions6.Image = (System.Drawing.Image) (resources.GetObject("ButtonImageOptions6.Image"));
			ButtonImageOptions7.Image = (System.Drawing.Image) (resources.GetObject("ButtonImageOptions7.Image"));
			this.gcnClassification.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("btnAddClassification", false, ButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Добавить", -1, true, null, true, false, true, null, 1), new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("btnEditClassfication", false, ButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Изменить", -1, true, null, true, false, true, null, 1), new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("btnDeleteClassfication", false, ButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Удалить", -1, true, null, true, false, true, null, 1), new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("|", true, ButtonImageOptions4, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, false, null, true, false, true, null, -1), new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("btnSearch_Classifications", false, ButtonImageOptions5, DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, "Показать панель поиска", -1, true, null, true, false, true, null, 3), new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("btnAutoFilter_Classifications", false, ButtonImageOptions6, DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, "Показать строку автофильтра", -1, true, null, true, false, true, null, 4), new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("btnClearSort_Classfication", false, ButtonImageOptions7, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Очистить сортировку", -1, true, null, true, false, true, null, -1)});
			this.gcnClassification.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
			this.gcnClassification.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gcnClassification.Location = new System.Drawing.Point(0, 0);
			this.gcnClassification.Name = "gcnClassification";
			this.gcnClassification.Size = new System.Drawing.Size(315, 467);
			this.gcnClassification.TabIndex = 0;
			this.gcnClassification.Text = "Классификация";
			//
			//gcClassification
			//
			this.gcClassification.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gcClassification.Location = new System.Drawing.Point(2, 29);
			this.gcClassification.MainView = this.gvClassification;
			this.gcClassification.MenuManager = this.BarManager1;
			this.gcClassification.Name = "gcClassification";
			this.gcClassification.Size = new System.Drawing.Size(311, 436);
			this.gcClassification.TabIndex = 0;
			this.gcClassification.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.gvClassification});
			//
			//gvClassification
			//
			this.gvClassification.Appearance.HeaderPanel.Options.UseTextOptions = true;
			this.gvClassification.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gvClassification.Appearance.HeaderPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
			this.gvClassification.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
			this.gvClassification.GridControl = this.gcClassification;
			this.gvClassification.Name = "gvClassification";
			this.gvClassification.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvClassification.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvClassification.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
			this.gvClassification.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
			this.gvClassification.OptionsBehavior.Editable = false;
			this.gvClassification.OptionsCustomization.AllowColumnMoving = false;
			this.gvClassification.OptionsCustomization.AllowGroup = false;
			this.gvClassification.OptionsDetail.EnableMasterViewMode = false;
			this.gvClassification.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
			this.gvClassification.OptionsFind.SearchInPreview = true;
			this.gvClassification.OptionsFind.ShowClearButton = false;
			this.gvClassification.OptionsMenu.EnableColumnMenu = false;
			this.gvClassification.OptionsMenu.EnableFooterMenu = false;
			this.gvClassification.OptionsMenu.EnableGroupPanelMenu = false;
			this.gvClassification.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gvClassification.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
			this.gvClassification.OptionsView.ShowGroupPanel = false;
			this.gvClassification.OptionsView.ShowIndicator = false;
			//
			//BarManager1
			//
			this.BarManager1.AllowShowToolbarsPopup = false;
			this.BarManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.Bar1, this.Bar3});
			this.BarManager1.DockControls.Add(this.barDockControlTop);
			this.BarManager1.DockControls.Add(this.barDockControlBottom);
			this.BarManager1.DockControls.Add(this.barDockControlLeft);
			this.BarManager1.DockControls.Add(this.barDockControlRight);
			this.BarManager1.Form = this;
			this.BarManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {this.lbServerName, this.lbDB_name, this.btnUpdate, this.btnAddClassifications, this.btnEditClassifications, this.btnDeleteClassifications, this.btnAddProducts, this.btnEditProducts, this.btnDeleteProducts, this.BarStaticItem1, this.BarStaticItem2});
			this.BarManager1.MaxItemId = 11;
			this.BarManager1.StatusBar = this.Bar3;
			//
			//Bar1
			//
			this.Bar1.BarName = "Сервис";
			this.Bar1.DockCol = 0;
			this.Bar1.DockRow = 0;
			this.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.Bar1.Text = "Сервис";
			this.Bar1.Visible = false;
			//
			//Bar3
			//
			this.Bar3.BarName = "Строка состояния";
			this.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
			this.Bar3.DockCol = 0;
			this.Bar3.DockRow = 0;
			this.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
			this.Bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {new DevExpress.XtraBars.LinkPersistInfo(this.lbServerName), new DevExpress.XtraBars.LinkPersistInfo(this.lbDB_name), new DevExpress.XtraBars.LinkPersistInfo(this.btnUpdate)});
			this.Bar3.OptionsBar.AllowQuickCustomization = false;
			this.Bar3.OptionsBar.DrawDragBorder = false;
			this.Bar3.OptionsBar.UseWholeRow = true;
			this.Bar3.Text = "Строка состояния";
			//
			//lbServerName
			//
			this.lbServerName.Caption = "Сервер";
			this.lbServerName.Id = 0;
			this.lbServerName.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("lbServerName.ImageOptions.Image"));
			this.lbServerName.Name = "lbServerName";
			this.lbServerName.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			//
			//lbDB_name
			//
			this.lbDB_name.Caption = "База данных";
			this.lbDB_name.Id = 1;
			this.lbDB_name.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("lbDB_name.ImageOptions.Image"));
			this.lbDB_name.ImageOptions.LargeImage = (System.Drawing.Image) (resources.GetObject("lbDB_name.ImageOptions.LargeImage"));
			this.lbDB_name.Name = "lbDB_name";
			this.lbDB_name.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			//
			//btnUpdate
			//
			this.btnUpdate.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
			this.btnUpdate.Caption = "Обновить данные";
			this.btnUpdate.Id = 2;
			this.btnUpdate.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnUpdate.ImageOptions.Image"));
			this.btnUpdate.ImageOptions.LargeImage = (System.Drawing.Image) (resources.GetObject("btnUpdate.ImageOptions.LargeImage"));
			this.btnUpdate.Name = "btnUpdate";
			//
			//barDockControlTop
			//
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
			this.barDockControlTop.Manager = this.BarManager1;
			this.barDockControlTop.Size = new System.Drawing.Size(914, 29);
			//
			//barDockControlBottom
			//
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 504);
			this.barDockControlBottom.Manager = this.BarManager1;
			this.barDockControlBottom.Size = new System.Drawing.Size(914, 27);
			//
			//barDockControlLeft
			//
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 29);
			this.barDockControlLeft.Manager = this.BarManager1;
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 475);
			//
			//barDockControlRight
			//
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(914, 29);
			this.barDockControlRight.Manager = this.BarManager1;
			this.barDockControlRight.Size = new System.Drawing.Size(0, 475);
			//
			//btnAddClassifications
			//
			this.btnAddClassifications.Caption = "Добавить";
			this.btnAddClassifications.Id = 3;
			this.btnAddClassifications.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnAddClassifications.ImageOptions.Image"));
			this.btnAddClassifications.Name = "btnAddClassifications";
			//
			//btnEditClassifications
			//
			this.btnEditClassifications.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
			this.btnEditClassifications.Caption = "Изменить          <i>Enter</i>";
			this.btnEditClassifications.Id = 4;
			this.btnEditClassifications.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnEditClassifications.ImageOptions.Image"));
			this.btnEditClassifications.Name = "btnEditClassifications";
			//
			//btnDeleteClassifications
			//
			this.btnDeleteClassifications.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
			this.btnDeleteClassifications.Caption = "Удалить             <i>Delete</i>";
			this.btnDeleteClassifications.Id = 5;
			this.btnDeleteClassifications.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnDeleteClassifications.ImageOptions.Image"));
			this.btnDeleteClassifications.Name = "btnDeleteClassifications";
			//
			//btnAddProducts
			//
			this.btnAddProducts.Caption = "Добавить";
			this.btnAddProducts.Id = 6;
			this.btnAddProducts.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnAddProducts.ImageOptions.Image"));
			this.btnAddProducts.Name = "btnAddProducts";
			//
			//btnEditProducts
			//
			this.btnEditProducts.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
			this.btnEditProducts.Caption = "Изменить          <i>Enter</i>";
			this.btnEditProducts.Id = 7;
			this.btnEditProducts.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnEditProducts.ImageOptions.Image"));
			this.btnEditProducts.Name = "btnEditProducts";
			//
			//btnDeleteProducts
			//
			this.btnDeleteProducts.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
			this.btnDeleteProducts.Caption = "Удалить             <i>Delete</i>";
			this.btnDeleteProducts.Id = 8;
			this.btnDeleteProducts.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnDeleteProducts.ImageOptions.Image"));
			this.btnDeleteProducts.Name = "btnDeleteProducts";
			//
			//BarStaticItem1
			//
			this.BarStaticItem1.Caption = "   Классификация   ";
			this.BarStaticItem1.Id = 9;
			this.BarStaticItem1.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", (float) (8.25F), (System.Drawing.FontStyle) ((int) (System.Drawing.FontStyle.Bold) | (int) System.Drawing.FontStyle.Underline));
			this.BarStaticItem1.ItemAppearance.Normal.Options.UseFont = true;
			this.BarStaticItem1.Name = "BarStaticItem1";
			//
			//BarStaticItem2
			//
			this.BarStaticItem2.Caption = "   Продукция   ";
			this.BarStaticItem2.Id = 10;
			this.BarStaticItem2.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", (float) (8.25F), (System.Drawing.FontStyle) ((int) (System.Drawing.FontStyle.Bold) | (int) System.Drawing.FontStyle.Underline));
			this.BarStaticItem2.ItemAppearance.Normal.Options.UseFont = true;
			this.BarStaticItem2.Name = "BarStaticItem2";
			//
			//gcnProducts
			//
			this.gcnProducts.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (8.0F));
			this.gcnProducts.Appearance.Options.UseFont = true;
			this.gcnProducts.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", (float) (9.0F), (System.Drawing.FontStyle) ((int) (System.Drawing.FontStyle.Bold) | (int) System.Drawing.FontStyle.Underline));
			this.gcnProducts.AppearanceCaption.Options.UseFont = true;
			this.gcnProducts.AppearanceCaption.Options.UseTextOptions = true;
			this.gcnProducts.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
			this.gcnProducts.Controls.Add(this.gcProducts);
			ButtonImageOptions8.Image = (System.Drawing.Image) (resources.GetObject("ButtonImageOptions8.Image"));
			ButtonImageOptions9.Image = (System.Drawing.Image) (resources.GetObject("ButtonImageOptions9.Image"));
			ButtonImageOptions10.Image = (System.Drawing.Image) (resources.GetObject("ButtonImageOptions10.Image"));
			ButtonImageOptions12.Image = (System.Drawing.Image) (resources.GetObject("ButtonImageOptions12.Image"));
			ButtonImageOptions13.Image = (System.Drawing.Image) (resources.GetObject("ButtonImageOptions13.Image"));
			ButtonImageOptions14.Image = (System.Drawing.Image) (resources.GetObject("ButtonImageOptions14.Image"));
			this.gcnProducts.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("btnAddProducts", false, ButtonImageOptions8, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Добавить", -1, true, null, true, false, true, null, 2), new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("btnEditProducts", false, ButtonImageOptions9, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Изменить", -1, true, null, true, false, true, null, 2), new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("btnDeleteProducts", false, ButtonImageOptions10, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Удалаить", -1, true, null, true, false, true, null, 2), new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("|", true, ButtonImageOptions11, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, false, null, true, false, true, null, -1), new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("btnSearch_Products", false, ButtonImageOptions12, DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, "Показать панель поиска", -1, true, null, true, false, true, null, 5), new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("btnAutoFilter_Products", false, ButtonImageOptions13, DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, "Показать строку автофильтра", -1, true, null, true, false, true, null, 6), new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("btnClearSort_Products", false, ButtonImageOptions14, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Очистить сортировку", -1, true, null, true, false, true, null, -1)});
			this.gcnProducts.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
			this.gcnProducts.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gcnProducts.Location = new System.Drawing.Point(0, 0);
			this.gcnProducts.Name = "gcnProducts";
			this.gcnProducts.Size = new System.Drawing.Size(582, 467);
			this.gcnProducts.TabIndex = 0;
			this.gcnProducts.Text = "Продукция";
			//
			//gcProducts
			//
			this.gcProducts.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gcProducts.Location = new System.Drawing.Point(2, 29);
			this.gcProducts.MainView = this.gvProducts;
			this.gcProducts.MenuManager = this.BarManager1;
			this.gcProducts.Name = "gcProducts";
			this.gcProducts.Size = new System.Drawing.Size(578, 436);
			this.gcProducts.TabIndex = 0;
			this.gcProducts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.gvProducts});
			//
			//gvProducts
			//
			this.gvProducts.Appearance.HeaderPanel.Options.UseTextOptions = true;
			this.gvProducts.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gvProducts.Appearance.HeaderPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
			this.gvProducts.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
			this.gvProducts.GridControl = this.gcProducts;
			this.gvProducts.Name = "gvProducts";
			this.gvProducts.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvProducts.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvProducts.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
			this.gvProducts.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
			this.gvProducts.OptionsBehavior.Editable = false;
			this.gvProducts.OptionsCustomization.AllowColumnMoving = false;
			this.gvProducts.OptionsCustomization.AllowGroup = false;
			this.gvProducts.OptionsDetail.EnableMasterViewMode = false;
			this.gvProducts.OptionsMenu.EnableColumnMenu = false;
			this.gvProducts.OptionsMenu.EnableFooterMenu = false;
			this.gvProducts.OptionsMenu.EnableGroupPanelMenu = false;
			this.gvProducts.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gvProducts.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
			this.gvProducts.OptionsView.ShowGroupPanel = false;
			//
			//tmChecked
			//
			this.tmChecked.Enabled = true;
			//
			//pmMenuClassifications
			//
			this.pmMenuClassifications.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {new DevExpress.XtraBars.LinkPersistInfo(this.BarStaticItem1), new DevExpress.XtraBars.LinkPersistInfo(this.btnAddClassifications, true), new DevExpress.XtraBars.LinkPersistInfo(this.btnEditClassifications), new DevExpress.XtraBars.LinkPersistInfo(this.btnDeleteClassifications)});
			this.pmMenuClassifications.Manager = this.BarManager1;
			this.pmMenuClassifications.Name = "pmMenuClassifications";
			//
			//pmMenuProducts
			//
			this.pmMenuProducts.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {new DevExpress.XtraBars.LinkPersistInfo(this.BarStaticItem2), new DevExpress.XtraBars.LinkPersistInfo(this.btnAddProducts, true), new DevExpress.XtraBars.LinkPersistInfo(this.btnEditProducts), new DevExpress.XtraBars.LinkPersistInfo(this.btnDeleteProducts)});
			this.pmMenuProducts.Manager = this.BarManager1;
			this.pmMenuProducts.Name = "pmMenuProducts";
			//
			//frBooks_ClassificationProducts
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(914, 531);
			this.Controls.Add(this.SplitContainerControl1);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MinimumSize = new System.Drawing.Size(563, 353);
			this.Name = "frBooks_ClassificationProducts";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Классификация продукции";
			((System.ComponentModel.ISupportInitialize) this.SplitContainerControl1).EndInit();
			this.SplitContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.gcnClassification).EndInit();
			this.gcnClassification.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.gcClassification).EndInit();
			((System.ComponentModel.ISupportInitialize) this.gvClassification).EndInit();
			((System.ComponentModel.ISupportInitialize) this.BarManager1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.gcnProducts).EndInit();
			this.gcnProducts.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.gcProducts).EndInit();
			((System.ComponentModel.ISupportInitialize) this.gvProducts).EndInit();
			((System.ComponentModel.ISupportInitialize) this.pmMenuClassifications).EndInit();
			((System.ComponentModel.ISupportInitialize) this.pmMenuProducts).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		
		internal DevExpress.XtraEditors.SplitContainerControl SplitContainerControl1;
		internal DevExpress.XtraBars.BarManager BarManager1;
		internal DevExpress.XtraBars.Bar Bar1;
		internal DevExpress.XtraBars.Bar Bar3;
		internal DevExpress.XtraBars.BarDockControl barDockControlTop;
		internal DevExpress.XtraBars.BarDockControl barDockControlBottom;
		internal DevExpress.XtraBars.BarDockControl barDockControlLeft;
		internal DevExpress.XtraBars.BarDockControl barDockControlRight;
		internal DevExpress.XtraBars.BarStaticItem lbServerName;
		internal DevExpress.XtraBars.BarStaticItem lbDB_name;
		internal DevExpress.XtraEditors.GroupControl gcnClassification;
		internal DevExpress.XtraEditors.GroupControl gcnProducts;
		internal DevExpress.XtraGrid.GridControl gcClassification;
		internal DevExpress.XtraGrid.Views.Grid.GridView gvClassification;
		internal DevExpress.XtraGrid.GridControl gcProducts;
		internal DevExpress.XtraGrid.Views.Grid.GridView gvProducts;
		internal DevExpress.XtraBars.BarButtonItem btnUpdate;
		internal Timer tmChecked;
		internal DevExpress.XtraBars.BarButtonItem btnAddClassifications;
		internal DevExpress.XtraBars.BarButtonItem btnEditClassifications;
		internal DevExpress.XtraBars.BarButtonItem btnDeleteClassifications;
		internal DevExpress.XtraBars.PopupMenu pmMenuClassifications;
		internal DevExpress.XtraBars.BarButtonItem btnAddProducts;
		internal DevExpress.XtraBars.BarButtonItem btnEditProducts;
		internal DevExpress.XtraBars.BarButtonItem btnDeleteProducts;
		internal DevExpress.XtraBars.PopupMenu pmMenuProducts;
		internal DevExpress.XtraBars.BarStaticItem BarStaticItem1;
		internal DevExpress.XtraBars.BarStaticItem BarStaticItem2;
	}
	
}
