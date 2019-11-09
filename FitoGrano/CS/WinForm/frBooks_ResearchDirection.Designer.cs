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
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public 
	partial class frBooks_ResearchDirection : DevExpress.XtraEditors.XtraForm
	{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
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
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(frBooks_FormClosing);
			this.Load += new System.EventHandler(frBooks_ResearchDirection_Load);
			DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions ButtonImageOptions1 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frBooks_ResearchDirection));
			DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions ButtonImageOptions2 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
			DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions ButtonImageOptions3 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
			DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions ButtonImageOptions4 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
			DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions ButtonImageOptions5 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
			DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions ButtonImageOptions6 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
			DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions ButtonImageOptions7 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
			DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions ButtonImageOptions8 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
			DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions ButtonImageOptions9 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
			DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions ButtonImageOptions10 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
			DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions ButtonImageOptions11 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
			DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions ButtonImageOptions12 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
			DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions ButtonImageOptions13 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
			DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions ButtonImageOptions14 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
			this.SplitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
			this.gcnDirection = new DevExpress.XtraEditors.GroupControl();
			this.gcnDirection.CustomButtonClick += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.gcnDirection_CustomButtonClick);
			this.gcnDirection.CustomButtonChecked += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.gcnDirection_CustomButtonChecked);
			this.gcnDirection.CustomButtonUnchecked += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.gcnDirection_CustomButtonChecked);
			this.gcDirection = new DevExpress.XtraGrid.GridControl();
			this.gvDirection = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gvDirection.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvDirection_FocusedRowChanged);
			this.gvDirection.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gvDirection_MouseDown);
			this.gvDirection.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvDirection_KeyDown);
			this.gcnMethods = new DevExpress.XtraEditors.GroupControl();
			this.gcnMethods.CustomButtonClick += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.gcnProducts_CustomButtonClick);
			this.gcnMethods.CustomButtonChecked += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.gcnMethods_CustomButtonChecked);
			this.gcnMethods.CustomButtonUnchecked += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.gcnMethods_CustomButtonChecked);
			this.gcMethod = new DevExpress.XtraGrid.GridControl();
			this.gvMethod = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gvMethod.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvMethod_FocusedRowChanged);
			this.gvMethod.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvMethod_FocusedRowChanged);
			this.gvMethod.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gvMethod_MouseDown);
			this.gvMethod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvMethod_KeyDown);
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
			this.btnAddDirection = new DevExpress.XtraBars.BarButtonItem();
			this.btnAddDirection.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddDirection_ItemClick);
			this.btnEditDirection = new DevExpress.XtraBars.BarButtonItem();
			this.btnEditDirection.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditDirection_ItemClick);
			this.btnDeleteDirection = new DevExpress.XtraBars.BarButtonItem();
			this.btnDeleteDirection.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDeleteDirection_ItemClick);
			this.btnAddMethod = new DevExpress.XtraBars.BarButtonItem();
			this.btnAddMethod.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddMethod_ItemClick);
			this.btnEditMethod = new DevExpress.XtraBars.BarButtonItem();
			this.btnEditMethod.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditMethod_ItemClick);
			this.btnDeleteMethod = new DevExpress.XtraBars.BarButtonItem();
			this.btnDeleteMethod.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDeleteMethod_ItemClick);
			this.BarStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
			this.BarStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
			this.tmChecked = new System.Windows.Forms.Timer(this.components);
			this.tmChecked.Tick += new System.EventHandler(this.tmChecked_Tick);
			this.pmMenuDirection = new DevExpress.XtraBars.PopupMenu(this.components);
			this.pmMenuMethods = new DevExpress.XtraBars.PopupMenu(this.components);
			((System.ComponentModel.ISupportInitialize) this.SplitContainerControl1).BeginInit();
			this.SplitContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.gcnDirection).BeginInit();
			this.gcnDirection.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.gcDirection).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.gvDirection).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.gcnMethods).BeginInit();
			this.gcnMethods.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.gcMethod).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.gvMethod).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.BarManager1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.pmMenuDirection).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.pmMenuMethods).BeginInit();
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
			this.SplitContainerControl1.Panel1.Controls.Add(this.gcnDirection);
			this.SplitContainerControl1.Panel1.MinSize = 30;
			this.SplitContainerControl1.Panel2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", (float) (8.25F), (System.Drawing.FontStyle) ((int) (System.Drawing.FontStyle.Bold) | (int) System.Drawing.FontStyle.Underline));
			this.SplitContainerControl1.Panel2.AppearanceCaption.Options.UseFont = true;
			this.SplitContainerControl1.Panel2.AppearanceCaption.Options.UseTextOptions = true;
			this.SplitContainerControl1.Panel2.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.SplitContainerControl1.Panel2.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
			this.SplitContainerControl1.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.SplitContainerControl1.Panel2.CaptionLocation = DevExpress.Utils.Locations.Top;
			this.SplitContainerControl1.Panel2.Controls.Add(this.gcnMethods);
			this.SplitContainerControl1.Size = new System.Drawing.Size(929, 495);
			this.SplitContainerControl1.SplitterPosition = 299;
			this.SplitContainerControl1.TabIndex = 1;
			//
			//gcnDirection
			//
			this.gcnDirection.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (8.0F));
			this.gcnDirection.Appearance.Options.UseFont = true;
			this.gcnDirection.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", (float) (9.0F), (System.Drawing.FontStyle) ((int) (System.Drawing.FontStyle.Bold) | (int) System.Drawing.FontStyle.Underline));
			this.gcnDirection.AppearanceCaption.Options.UseFont = true;
			this.gcnDirection.AppearanceCaption.Options.UseTextOptions = true;
			this.gcnDirection.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
			this.gcnDirection.Controls.Add(this.gcDirection);
			ButtonImageOptions1.Image = (System.Drawing.Image) (resources.GetObject("ButtonImageOptions1.Image"));
			ButtonImageOptions2.Image = (System.Drawing.Image) (resources.GetObject("ButtonImageOptions2.Image"));
			ButtonImageOptions3.Image = (System.Drawing.Image) (resources.GetObject("ButtonImageOptions3.Image"));
			ButtonImageOptions5.Image = (System.Drawing.Image) (resources.GetObject("ButtonImageOptions5.Image"));
			ButtonImageOptions6.Image = (System.Drawing.Image) (resources.GetObject("ButtonImageOptions6.Image"));
			ButtonImageOptions7.Image = (System.Drawing.Image) (resources.GetObject("ButtonImageOptions7.Image"));
			this.gcnDirection.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("btnAddDirection", false, ButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Добавить", -1, true, null, true, false, true, null, 1), new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("btnEditDirection", false, ButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Изменить", -1, true, null, true, false, true, null, 1), new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("btnDeleteDirection", false, ButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Удалить", -1, true, null, true, false, true, null, 1), new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("|", true, ButtonImageOptions4, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, false, null, true, false, true, null, -1), new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("btnSearch_Direction", false, ButtonImageOptions5, DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, "Показать панель поиска", -1, true, null, true, false, true, null, 3), new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("btnAutoFilter_Direction", false, ButtonImageOptions6, DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, "Показать строку автофильтра", -1, true, null, true, false, true, null, 4), new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("btnClearSort_Direction", false, ButtonImageOptions7, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Очистить сортировку", -1, true, null, true, false, true, null, -1)});
			this.gcnDirection.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
			this.gcnDirection.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gcnDirection.Location = new System.Drawing.Point(0, 0);
			this.gcnDirection.Name = "gcnDirection";
			this.gcnDirection.Size = new System.Drawing.Size(295, 487);
			this.gcnDirection.TabIndex = 0;
			this.gcnDirection.Text = "Направления";
			//
			//gcDirection
			//
			this.gcDirection.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gcDirection.Location = new System.Drawing.Point(2, 29);
			this.gcDirection.MainView = this.gvDirection;
			this.gcDirection.Name = "gcDirection";
			this.gcDirection.Size = new System.Drawing.Size(291, 456);
			this.gcDirection.TabIndex = 0;
			this.gcDirection.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.gvDirection});
			//
			//gvDirection
			//
			this.gvDirection.Appearance.HeaderPanel.Options.UseTextOptions = true;
			this.gvDirection.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gvDirection.Appearance.HeaderPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
			this.gvDirection.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
			this.gvDirection.GridControl = this.gcDirection;
			this.gvDirection.Name = "gvDirection";
			this.gvDirection.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvDirection.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvDirection.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
			this.gvDirection.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
			this.gvDirection.OptionsBehavior.Editable = false;
			this.gvDirection.OptionsCustomization.AllowColumnMoving = false;
			this.gvDirection.OptionsCustomization.AllowGroup = false;
			this.gvDirection.OptionsDetail.EnableMasterViewMode = false;
			this.gvDirection.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
			this.gvDirection.OptionsFind.SearchInPreview = true;
			this.gvDirection.OptionsFind.ShowClearButton = false;
			this.gvDirection.OptionsMenu.EnableColumnMenu = false;
			this.gvDirection.OptionsMenu.EnableFooterMenu = false;
			this.gvDirection.OptionsMenu.EnableGroupPanelMenu = false;
			this.gvDirection.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gvDirection.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
			this.gvDirection.OptionsView.ShowGroupPanel = false;
			this.gvDirection.OptionsView.ShowIndicator = false;
			//
			//gcnMethods
			//
			this.gcnMethods.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (8.0F));
			this.gcnMethods.Appearance.Options.UseFont = true;
			this.gcnMethods.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", (float) (9.0F), (System.Drawing.FontStyle) ((int) (System.Drawing.FontStyle.Bold) | (int) System.Drawing.FontStyle.Underline));
			this.gcnMethods.AppearanceCaption.Options.UseFont = true;
			this.gcnMethods.AppearanceCaption.Options.UseTextOptions = true;
			this.gcnMethods.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
			this.gcnMethods.Controls.Add(this.gcMethod);
			ButtonImageOptions8.Image = (System.Drawing.Image) (resources.GetObject("ButtonImageOptions8.Image"));
			ButtonImageOptions9.Image = (System.Drawing.Image) (resources.GetObject("ButtonImageOptions9.Image"));
			ButtonImageOptions10.Image = (System.Drawing.Image) (resources.GetObject("ButtonImageOptions10.Image"));
			ButtonImageOptions12.Image = (System.Drawing.Image) (resources.GetObject("ButtonImageOptions12.Image"));
			ButtonImageOptions13.Image = (System.Drawing.Image) (resources.GetObject("ButtonImageOptions13.Image"));
			ButtonImageOptions14.Image = (System.Drawing.Image) (resources.GetObject("ButtonImageOptions14.Image"));
			this.gcnMethods.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("btnAddMethod", false, ButtonImageOptions8, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Добавить", -1, true, null, true, false, true, null, 2), new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("btnEditMethod", false, ButtonImageOptions9, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Изменить", -1, true, null, true, false, true, null, 2), new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("btnDeleteMethod", false, ButtonImageOptions10, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Удалаить", -1, true, null, true, false, true, null, 2), new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("|", true, ButtonImageOptions11, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, false, null, true, false, true, null, -1), new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("btnSearch_Method", false, ButtonImageOptions12, DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, "Показать панель поиска", -1, true, null, true, false, true, null, 5), new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("btnAutoFilter_Method", false, ButtonImageOptions13, DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, "Показать строку автофильтра", -1, true, null, true, false, true, null, 6), new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("btnClearSort_Method", false, ButtonImageOptions14, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Очистить сортировку", -1, true, null, true, false, true, null, -1)});
			this.gcnMethods.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
			this.gcnMethods.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gcnMethods.Location = new System.Drawing.Point(0, 0);
			this.gcnMethods.Name = "gcnMethods";
			this.gcnMethods.Size = new System.Drawing.Size(617, 487);
			this.gcnMethods.TabIndex = 0;
			this.gcnMethods.Text = "Методы исследования";
			//
			//gcMethod
			//
			this.gcMethod.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gcMethod.Location = new System.Drawing.Point(2, 29);
			this.gcMethod.MainView = this.gvMethod;
			this.gcMethod.Name = "gcMethod";
			this.gcMethod.Size = new System.Drawing.Size(613, 456);
			this.gcMethod.TabIndex = 0;
			this.gcMethod.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.gvMethod});
			//
			//gvMethod
			//
			this.gvMethod.Appearance.HeaderPanel.Options.UseTextOptions = true;
			this.gvMethod.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gvMethod.Appearance.HeaderPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
			this.gvMethod.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
			this.gvMethod.GridControl = this.gcMethod;
			this.gvMethod.Name = "gvMethod";
			this.gvMethod.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvMethod.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvMethod.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
			this.gvMethod.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
			this.gvMethod.OptionsBehavior.Editable = false;
			this.gvMethod.OptionsCustomization.AllowColumnMoving = false;
			this.gvMethod.OptionsCustomization.AllowGroup = false;
			this.gvMethod.OptionsDetail.EnableMasterViewMode = false;
			this.gvMethod.OptionsMenu.EnableColumnMenu = false;
			this.gvMethod.OptionsMenu.EnableFooterMenu = false;
			this.gvMethod.OptionsMenu.EnableGroupPanelMenu = false;
			this.gvMethod.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gvMethod.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
			this.gvMethod.OptionsView.ShowGroupPanel = false;
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
			this.BarManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {this.lbServerName, this.lbDB_name, this.btnUpdate, this.btnAddDirection, this.btnEditDirection, this.btnDeleteDirection, this.btnAddMethod, this.btnEditMethod, this.btnDeleteMethod, this.BarStaticItem1, this.BarStaticItem2});
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
			this.barDockControlTop.Size = new System.Drawing.Size(929, 29);
			//
			//barDockControlBottom
			//
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 524);
			this.barDockControlBottom.Manager = this.BarManager1;
			this.barDockControlBottom.Size = new System.Drawing.Size(929, 27);
			//
			//barDockControlLeft
			//
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 29);
			this.barDockControlLeft.Manager = this.BarManager1;
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 495);
			//
			//barDockControlRight
			//
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(929, 29);
			this.barDockControlRight.Manager = this.BarManager1;
			this.barDockControlRight.Size = new System.Drawing.Size(0, 495);
			//
			//btnAddDirection
			//
			this.btnAddDirection.Caption = "Добавить";
			this.btnAddDirection.Id = 3;
			this.btnAddDirection.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnAddDirection.ImageOptions.Image"));
			this.btnAddDirection.Name = "btnAddDirection";
			//
			//btnEditDirection
			//
			this.btnEditDirection.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
			this.btnEditDirection.Caption = "Изменить          <i>Enter</i>";
			this.btnEditDirection.Id = 4;
			this.btnEditDirection.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnEditDirection.ImageOptions.Image"));
			this.btnEditDirection.Name = "btnEditDirection";
			//
			//btnDeleteDirection
			//
			this.btnDeleteDirection.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
			this.btnDeleteDirection.Caption = "Удалить             <i>Delete</i>";
			this.btnDeleteDirection.Id = 5;
			this.btnDeleteDirection.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnDeleteDirection.ImageOptions.Image"));
			this.btnDeleteDirection.Name = "btnDeleteDirection";
			//
			//btnAddMethod
			//
			this.btnAddMethod.Caption = "Добавить";
			this.btnAddMethod.Id = 6;
			this.btnAddMethod.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnAddMethod.ImageOptions.Image"));
			this.btnAddMethod.Name = "btnAddMethod";
			//
			//btnEditMethod
			//
			this.btnEditMethod.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
			this.btnEditMethod.Caption = "Изменить          <i>Enter</i>";
			this.btnEditMethod.Id = 7;
			this.btnEditMethod.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnEditMethod.ImageOptions.Image"));
			this.btnEditMethod.Name = "btnEditMethod";
			//
			//btnDeleteMethod
			//
			this.btnDeleteMethod.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
			this.btnDeleteMethod.Caption = "Удалить             <i>Delete</i>";
			this.btnDeleteMethod.Id = 8;
			this.btnDeleteMethod.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnDeleteMethod.ImageOptions.Image"));
			this.btnDeleteMethod.Name = "btnDeleteMethod";
			//
			//BarStaticItem1
			//
			this.BarStaticItem1.Caption = "   Направление   ";
			this.BarStaticItem1.Id = 9;
			this.BarStaticItem1.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", (float) (8.25F), (System.Drawing.FontStyle) ((int) (System.Drawing.FontStyle.Bold) | (int) System.Drawing.FontStyle.Underline));
			this.BarStaticItem1.ItemAppearance.Normal.Options.UseFont = true;
			this.BarStaticItem1.Name = "BarStaticItem1";
			//
			//BarStaticItem2
			//
			this.BarStaticItem2.Caption = "   Метод   ";
			this.BarStaticItem2.Id = 10;
			this.BarStaticItem2.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", (float) (8.25F), (System.Drawing.FontStyle) ((int) (System.Drawing.FontStyle.Bold) | (int) System.Drawing.FontStyle.Underline));
			this.BarStaticItem2.ItemAppearance.Normal.Options.UseFont = true;
			this.BarStaticItem2.Name = "BarStaticItem2";
			//
			//tmChecked
			//
			this.tmChecked.Enabled = true;
			//
			//pmMenuDirection
			//
			this.pmMenuDirection.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {new DevExpress.XtraBars.LinkPersistInfo(this.BarStaticItem1), new DevExpress.XtraBars.LinkPersistInfo(this.btnAddDirection, true), new DevExpress.XtraBars.LinkPersistInfo(this.btnEditDirection), new DevExpress.XtraBars.LinkPersistInfo(this.btnDeleteDirection)});
			this.pmMenuDirection.Manager = this.BarManager1;
			this.pmMenuDirection.Name = "pmMenuDirection";
			//
			//pmMenuMethods
			//
			this.pmMenuMethods.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {new DevExpress.XtraBars.LinkPersistInfo(this.BarStaticItem2), new DevExpress.XtraBars.LinkPersistInfo(this.btnAddMethod, true), new DevExpress.XtraBars.LinkPersistInfo(this.btnEditMethod), new DevExpress.XtraBars.LinkPersistInfo(this.btnDeleteMethod)});
			this.pmMenuMethods.Manager = this.BarManager1;
			this.pmMenuMethods.Name = "pmMenuMethods";
			//
			//frBooks_ResearchDirection
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(929, 551);
			this.Controls.Add(this.SplitContainerControl1);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.Name = "frBooks_ResearchDirection";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Направления исследований";
			((System.ComponentModel.ISupportInitialize) this.SplitContainerControl1).EndInit();
			this.SplitContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.gcnDirection).EndInit();
			this.gcnDirection.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.gcDirection).EndInit();
			((System.ComponentModel.ISupportInitialize) this.gvDirection).EndInit();
			((System.ComponentModel.ISupportInitialize) this.gcnMethods).EndInit();
			this.gcnMethods.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.gcMethod).EndInit();
			((System.ComponentModel.ISupportInitialize) this.gvMethod).EndInit();
			((System.ComponentModel.ISupportInitialize) this.BarManager1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.pmMenuDirection).EndInit();
			((System.ComponentModel.ISupportInitialize) this.pmMenuMethods).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		
		internal DevExpress.XtraEditors.SplitContainerControl SplitContainerControl1;
		internal DevExpress.XtraEditors.GroupControl gcnDirection;
		internal DevExpress.XtraGrid.GridControl gcDirection;
		internal DevExpress.XtraGrid.Views.Grid.GridView gvDirection;
		internal DevExpress.XtraEditors.GroupControl gcnMethods;
		internal DevExpress.XtraGrid.GridControl gcMethod;
		internal DevExpress.XtraGrid.Views.Grid.GridView gvMethod;
		internal DevExpress.XtraBars.BarManager BarManager1;
		internal DevExpress.XtraBars.Bar Bar1;
		internal DevExpress.XtraBars.Bar Bar3;
		internal DevExpress.XtraBars.BarStaticItem lbServerName;
		internal DevExpress.XtraBars.BarStaticItem lbDB_name;
		internal DevExpress.XtraBars.BarButtonItem btnUpdate;
		internal DevExpress.XtraBars.BarDockControl barDockControlTop;
		internal DevExpress.XtraBars.BarDockControl barDockControlBottom;
		internal DevExpress.XtraBars.BarDockControl barDockControlLeft;
		internal DevExpress.XtraBars.BarDockControl barDockControlRight;
		internal DevExpress.XtraBars.BarButtonItem btnAddDirection;
		internal DevExpress.XtraBars.BarButtonItem btnEditDirection;
		internal DevExpress.XtraBars.BarButtonItem btnDeleteDirection;
		internal DevExpress.XtraBars.BarButtonItem btnAddMethod;
		internal DevExpress.XtraBars.BarButtonItem btnEditMethod;
		internal DevExpress.XtraBars.BarButtonItem btnDeleteMethod;
		internal DevExpress.XtraBars.BarStaticItem BarStaticItem1;
		internal DevExpress.XtraBars.BarStaticItem BarStaticItem2;
		internal Timer tmChecked;
		internal DevExpress.XtraBars.PopupMenu pmMenuDirection;
		internal DevExpress.XtraBars.PopupMenu pmMenuMethods;
	}
	
}
