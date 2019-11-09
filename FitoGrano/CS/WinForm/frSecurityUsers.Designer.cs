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
		public partial class frSecurityUsers : DevExpress.XtraEditors.XtraForm
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
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(frSecurityUsers_FormClosing);
			base.Load += new System.EventHandler(frSecurityUsers_Load);
			DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions ButtonImageOptions1 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
			DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions ButtonImageOptions2 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
			DevExpress.Utils.SuperToolTip SuperToolTip1 = new DevExpress.Utils.SuperToolTip();
			DevExpress.Utils.ToolTipItem ToolTipItem1 = new DevExpress.Utils.ToolTipItem();
			DevExpress.Utils.ToolTipSeparatorItem ToolTipSeparatorItem1 = new DevExpress.Utils.ToolTipSeparatorItem();
			DevExpress.Utils.ToolTipTitleItem ToolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frSecurityUsers));
			this.SplitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
			this.gcPerformers = new DevExpress.XtraGrid.GridControl();
			this.gvPerformers = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gvPerformers.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvPerformers_FocusedRowChanged);
			this.gvPerformers.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvPerformers_RowCellClick);
			this.gvPerformers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvPerformers_KeyDown);
			this.gvPerformers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gvPerformers_MouseDown);
			this.BarManager = new DevExpress.XtraBars.BarManager(this.components);
			this.Bar2 = new DevExpress.XtraBars.Bar();
			this.btnAddPerformer = new DevExpress.XtraBars.BarButtonItem();
			this.btnAddPerformer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddPerformer_ItemClick);
			this.btnEditPerformer = new DevExpress.XtraBars.BarButtonItem();
			this.btnEditPerformer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditPerformer_ItemClick);
			this.btnDelPerformer = new DevExpress.XtraBars.BarButtonItem();
			this.btnDelPerformer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelPerformer_ItemClick);
			this.btnUpdate = new DevExpress.XtraBars.BarButtonItem();
			this.btnUpdate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUpdate_ItemClick);
			this.barStatusBar = new DevExpress.XtraBars.Bar();
			this.lbServerName = new DevExpress.XtraBars.BarStaticItem();
			this.lbDB_name = new DevExpress.XtraBars.BarStaticItem();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.ImageCollection = new DevExpress.Utils.ImageCollection(this.components);
			this.btnSecurityUsers = new DevExpress.XtraBars.BarButtonItem();
			this.BarStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
			this.BarEditItem1 = new DevExpress.XtraBars.BarEditItem();
			this.RepositoryItemSearchControl1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchControl();
			this.btnAddPerformer_pm = new DevExpress.XtraBars.BarButtonItem();
			this.btnAddPerformer_pm.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddPerformer_ItemClick);
			this.btnEditPerformer_pm = new DevExpress.XtraBars.BarButtonItem();
			this.btnEditPerformer_pm.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditPerformer_ItemClick);
			this.btnDelPerformer_pm = new DevExpress.XtraBars.BarButtonItem();
			this.btnDelPerformer_pm.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelPerformer_ItemClick);
			this.tlRightsPerformer = new DevExpress.XtraTreeList.TreeList();
			this.gcPerformerInformation = new DevExpress.XtraEditors.GroupControl();
			this.gcPerformerInformation.CustomButtonClick += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.gcPerformerInformation_CustomButtonClick);
			this.GroupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.lbxPerfGroups = new DevExpress.XtraEditors.ListBoxControl();
			this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.txtRoleJob = new DevExpress.XtraEditors.ButtonEdit();
			this.LabelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.txtEmail = new DevExpress.XtraEditors.ButtonEdit();
			this.gcContacts = new DevExpress.XtraEditors.GroupControl();
			this.lbxContacts = new DevExpress.XtraEditors.ListBoxControl();
			this.txtAddress = new DevExpress.XtraEditors.ButtonEdit();
			this.LabelControl7 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.txtRoomNumber = new DevExpress.XtraEditors.ButtonEdit();
			this.txtSex = new DevExpress.XtraEditors.ButtonEdit();
			this.txtDtBirth = new DevExpress.XtraEditors.ButtonEdit();
			this.tmChecked = new System.Windows.Forms.Timer(this.components);
			this.tmChecked.Tick += new System.EventHandler(this.tmChecked_Tick);
			this.pmMenuPerformers = new DevExpress.XtraBars.PopupMenu(this.components);
			((System.ComponentModel.ISupportInitialize) this.SplitContainerControl1).BeginInit();
			this.SplitContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.gcPerformers).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.gvPerformers).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.BarManager).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.ImageCollection).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.RepositoryItemSearchControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.tlRightsPerformer).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.gcPerformerInformation).BeginInit();
			this.gcPerformerInformation.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.GroupControl1).BeginInit();
			this.GroupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.lbxPerfGroups).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.txtRoleJob.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.txtEmail.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.gcContacts).BeginInit();
			this.gcContacts.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.lbxContacts).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.txtAddress.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.txtRoomNumber.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.txtSex.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.txtDtBirth.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.pmMenuPerformers).BeginInit();
			this.SuspendLayout();
			//
			//SplitContainerControl1
			//
			this.SplitContainerControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SplitContainerControl1.FireScrollEventOnMouseWheel = true;
			this.SplitContainerControl1.Location = new System.Drawing.Point(0, 24);
			this.SplitContainerControl1.Name = "SplitContainerControl1";
			this.SplitContainerControl1.Panel1.AppearanceCaption.Options.UseTextOptions = true;
			this.SplitContainerControl1.Panel1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.SplitContainerControl1.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.SplitContainerControl1.Panel1.CaptionLocation = DevExpress.Utils.Locations.Top;
			this.SplitContainerControl1.Panel1.Controls.Add(this.gcPerformers);
			this.SplitContainerControl1.Panel1.ShowCaption = true;
			this.SplitContainerControl1.Panel1.Text = "Исполнители базы данных";
			this.SplitContainerControl1.Panel2.AppearanceCaption.Options.UseTextOptions = true;
			this.SplitContainerControl1.Panel2.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.SplitContainerControl1.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.SplitContainerControl1.Panel2.Controls.Add(this.tlRightsPerformer);
			this.SplitContainerControl1.Panel2.Controls.Add(this.gcPerformerInformation);
			this.SplitContainerControl1.Panel2.ShowCaption = true;
			this.SplitContainerControl1.Panel2.Text = "Определение разрешений";
			this.SplitContainerControl1.Size = new System.Drawing.Size(1251, 515);
			this.SplitContainerControl1.SplitterPosition = 442;
			this.SplitContainerControl1.TabIndex = 4;
			this.SplitContainerControl1.Text = "SplitContainerControl1";
			//
			//gcPerformers
			//
			this.gcPerformers.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gcPerformers.Location = new System.Drawing.Point(0, 0);
			this.gcPerformers.MainView = this.gvPerformers;
			this.gcPerformers.MenuManager = this.BarManager;
			this.gcPerformers.Name = "gcPerformers";
			this.gcPerformers.Size = new System.Drawing.Size(438, 489);
			this.gcPerformers.TabIndex = 0;
			this.gcPerformers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.gvPerformers});
			//
			//gvPerformers
			//
			this.gvPerformers.Appearance.HeaderPanel.Options.UseTextOptions = true;
			this.gvPerformers.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gvPerformers.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
			this.gvPerformers.GridControl = this.gcPerformers;
			this.gvPerformers.Name = "gvPerformers";
			this.gvPerformers.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvPerformers.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvPerformers.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
			this.gvPerformers.OptionsBehavior.Editable = false;
			this.gvPerformers.OptionsCustomization.AllowColumnMoving = false;
			this.gvPerformers.OptionsCustomization.AllowGroup = false;
			this.gvPerformers.OptionsDetail.EnableMasterViewMode = false;
			this.gvPerformers.OptionsFilter.AllowFilterEditor = false;
			this.gvPerformers.OptionsMenu.EnableColumnMenu = false;
			this.gvPerformers.OptionsMenu.EnableFooterMenu = false;
			this.gvPerformers.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gvPerformers.OptionsView.ShowGroupPanel = false;
			this.gvPerformers.OptionsView.ShowIndicator = false;
			//
			//BarManager
			//
			this.BarManager.AllowCustomization = false;
			this.BarManager.AllowMoveBarOnToolbar = false;
			this.BarManager.AllowQuickCustomization = false;
			this.BarManager.AllowShowToolbarsPopup = false;
			this.BarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.Bar2, this.barStatusBar});
			this.BarManager.DockControls.Add(this.barDockControlTop);
			this.BarManager.DockControls.Add(this.barDockControlBottom);
			this.BarManager.DockControls.Add(this.barDockControlLeft);
			this.BarManager.DockControls.Add(this.barDockControlRight);
			this.BarManager.Form = this;
			this.BarManager.Images = this.ImageCollection;
			this.BarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {this.btnSecurityUsers, this.BarStaticItem2, this.btnAddPerformer, this.btnEditPerformer, this.btnDelPerformer, this.btnUpdate, this.lbServerName, this.lbDB_name, this.BarEditItem1, this.btnAddPerformer_pm, this.btnEditPerformer_pm, this.btnDelPerformer_pm});
			this.BarManager.MainMenu = this.Bar2;
			this.BarManager.MaxItemId = 19;
			this.BarManager.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {this.RepositoryItemSearchControl1});
			this.BarManager.StatusBar = this.barStatusBar;
			//
			//Bar2
			//
			this.Bar2.BarName = "Главное меню";
			this.Bar2.DockCol = 0;
			this.Bar2.DockRow = 0;
			this.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.Bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {new DevExpress.XtraBars.LinkPersistInfo(this.btnAddPerformer), new DevExpress.XtraBars.LinkPersistInfo(this.btnEditPerformer), new DevExpress.XtraBars.LinkPersistInfo(this.btnDelPerformer), new DevExpress.XtraBars.LinkPersistInfo(this.btnUpdate, true)});
			this.Bar2.OptionsBar.AllowQuickCustomization = false;
			this.Bar2.OptionsBar.DrawBorder = false;
			this.Bar2.OptionsBar.DrawDragBorder = false;
			this.Bar2.OptionsBar.MultiLine = true;
			this.Bar2.OptionsBar.UseWholeRow = true;
			this.Bar2.Text = "Главное меню";
			//
			//btnAddPerformer
			//
			this.btnAddPerformer.Caption = "Добавить исполнителя";
			this.btnAddPerformer.Id = 9;
			this.btnAddPerformer.ImageOptions.ImageIndex = 1;
			this.btnAddPerformer.Name = "btnAddPerformer";
			//
			//btnEditPerformer
			//
			this.btnEditPerformer.Caption = "Редактировать исполнителя";
			this.btnEditPerformer.Id = 10;
			this.btnEditPerformer.ImageOptions.ImageIndex = 2;
			this.btnEditPerformer.Name = "btnEditPerformer";
			//
			//btnDelPerformer
			//
			this.btnDelPerformer.Caption = "Удалить исполнителя";
			this.btnDelPerformer.Id = 11;
			this.btnDelPerformer.ImageOptions.ImageIndex = 0;
			this.btnDelPerformer.Name = "btnDelPerformer";
			//
			//btnUpdate
			//
			this.btnUpdate.Caption = "Обновить форму";
			this.btnUpdate.Id = 12;
			this.btnUpdate.ImageOptions.ImageIndex = 3;
			this.btnUpdate.Name = "btnUpdate";
			//
			//barStatusBar
			//
			this.barStatusBar.BarName = "Строка состояния";
			this.barStatusBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
			this.barStatusBar.DockCol = 0;
			this.barStatusBar.DockRow = 0;
			this.barStatusBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
			this.barStatusBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {new DevExpress.XtraBars.LinkPersistInfo(this.lbServerName), new DevExpress.XtraBars.LinkPersistInfo(this.lbDB_name)});
			this.barStatusBar.OptionsBar.AllowQuickCustomization = false;
			this.barStatusBar.OptionsBar.DrawBorder = false;
			this.barStatusBar.OptionsBar.DrawDragBorder = false;
			this.barStatusBar.OptionsBar.DrawSizeGrip = true;
			this.barStatusBar.OptionsBar.UseWholeRow = true;
			this.barStatusBar.Text = "Строка состояния";
			//
			//lbServerName
			//
			this.lbServerName.Caption = "Сервер";
			this.lbServerName.Id = 13;
			this.lbServerName.ImageOptions.ImageIndex = 4;
			this.lbServerName.Name = "lbServerName";
			this.lbServerName.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			//
			//lbDB_name
			//
			this.lbDB_name.Caption = "База данных";
			this.lbDB_name.Id = 14;
			this.lbDB_name.ImageOptions.ImageIndex = 5;
			this.lbDB_name.Name = "lbDB_name";
			this.lbDB_name.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			//
			//barDockControlTop
			//
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
			this.barDockControlTop.Manager = this.BarManager;
			this.barDockControlTop.Size = new System.Drawing.Size(1251, 24);
			//
			//barDockControlBottom
			//
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 539);
			this.barDockControlBottom.Manager = this.BarManager;
			this.barDockControlBottom.Size = new System.Drawing.Size(1251, 27);
			//
			//barDockControlLeft
			//
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
			this.barDockControlLeft.Manager = this.BarManager;
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 515);
			//
			//barDockControlRight
			//
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(1251, 24);
			this.barDockControlRight.Manager = this.BarManager;
			this.barDockControlRight.Size = new System.Drawing.Size(0, 515);
			//
			//ImageCollection
			//
			this.ImageCollection.ImageStream = (DevExpress.Utils.ImageCollectionStreamer) (resources.GetObject("ImageCollection.ImageStream"));
			this.ImageCollection.Images.SetKeyName(0, "DelUser_16x16.png");
			this.ImageCollection.Images.SetKeyName(1, "AddUser_16x16.png");
			this.ImageCollection.Images.SetKeyName(2, "EditUser_16x16.png");
			this.ImageCollection.InsertGalleryImage("recurrence_16x16.png", "office2013/scheduling/recurrence_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/scheduling/recurrence_16x16.png"), 3);
			this.ImageCollection.Images.SetKeyName(3, "recurrence_16x16.png");
			this.ImageCollection.Images.SetKeyName(4, "IP_16x16.png");
			this.ImageCollection.InsertGalleryImage("database_16x16.png", "images/data/database_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/data/database_16x16.png"), 5);
			this.ImageCollection.Images.SetKeyName(5, "database_16x16.png");
			//
			//btnSecurityUsers
			//
			this.btnSecurityUsers.Caption = "Исполнители и безопасность";
			this.btnSecurityUsers.Id = 1;
			this.btnSecurityUsers.ImageOptions.ImageIndex = 5;
			this.btnSecurityUsers.Name = "btnSecurityUsers";
			//
			//BarStaticItem2
			//
			this.BarStaticItem2.Caption = "BarStaticItem2";
			this.BarStaticItem2.Id = 8;
			this.BarStaticItem2.Name = "BarStaticItem2";
			//
			//BarEditItem1
			//
			this.BarEditItem1.Caption = "BarEditItem1";
			this.BarEditItem1.Edit = this.RepositoryItemSearchControl1;
			this.BarEditItem1.Id = 15;
			this.BarEditItem1.Name = "BarEditItem1";
			//
			//RepositoryItemSearchControl1
			//
			this.RepositoryItemSearchControl1.AutoHeight = false;
			this.RepositoryItemSearchControl1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Repository.ClearButton(), new DevExpress.XtraEditors.Repository.SearchButton()});
			this.RepositoryItemSearchControl1.Name = "RepositoryItemSearchControl1";
			//
			//btnAddPerformer_pm
			//
			this.btnAddPerformer_pm.Caption = "Добавить";
			this.btnAddPerformer_pm.Id = 16;
			this.btnAddPerformer_pm.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnAddPerformer_pm.ImageOptions.Image"));
			this.btnAddPerformer_pm.Name = "btnAddPerformer_pm";
			//
			//btnEditPerformer_pm
			//
			this.btnEditPerformer_pm.Caption = "Изменить";
			this.btnEditPerformer_pm.Id = 17;
			this.btnEditPerformer_pm.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnEditPerformer_pm.ImageOptions.Image"));
			this.btnEditPerformer_pm.Name = "btnEditPerformer_pm";
			//
			//btnDelPerformer_pm
			//
			this.btnDelPerformer_pm.Caption = "Удалить";
			this.btnDelPerformer_pm.Id = 18;
			this.btnDelPerformer_pm.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnDelPerformer_pm.ImageOptions.Image"));
			this.btnDelPerformer_pm.Name = "btnDelPerformer_pm";
			//
			//tlRightsPerformer
			//
			this.tlRightsPerformer.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.tlRightsPerformer.Caption = "Права сотрудника";
			this.tlRightsPerformer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlRightsPerformer.Location = new System.Drawing.Point(0, 193);
			this.tlRightsPerformer.Name = "tlRightsPerformer";
			this.tlRightsPerformer.OptionsView.ShowCaption = true;
			this.tlRightsPerformer.Size = new System.Drawing.Size(796, 296);
			this.tlRightsPerformer.TabIndex = 1;
			//
			//gcPerformerInformation
			//
			this.gcPerformerInformation.AllowHtmlText = true;
			this.gcPerformerInformation.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.gcPerformerInformation.CaptionImageOptions.Image = (System.Drawing.Image) (resources.GetObject("gcPerformerInformation.CaptionImageOptions.Image"));
			this.gcPerformerInformation.Controls.Add(this.GroupControl1);
			this.gcPerformerInformation.Controls.Add(this.LabelControl2);
			this.gcPerformerInformation.Controls.Add(this.txtRoleJob);
			this.gcPerformerInformation.Controls.Add(this.LabelControl5);
			this.gcPerformerInformation.Controls.Add(this.txtEmail);
			this.gcPerformerInformation.Controls.Add(this.gcContacts);
			this.gcPerformerInformation.Controls.Add(this.txtAddress);
			this.gcPerformerInformation.Controls.Add(this.LabelControl7);
			this.gcPerformerInformation.Controls.Add(this.LabelControl4);
			this.gcPerformerInformation.Controls.Add(this.LabelControl3);
			this.gcPerformerInformation.Controls.Add(this.LabelControl1);
			this.gcPerformerInformation.Controls.Add(this.txtRoomNumber);
			this.gcPerformerInformation.Controls.Add(this.txtSex);
			this.gcPerformerInformation.Controls.Add(this.txtDtBirth);
			ButtonImageOptions1.Image = (System.Drawing.Image) (resources.GetObject("ButtonImageOptions1.Image"));
			ButtonImageOptions2.Image = (System.Drawing.Image) (resources.GetObject("ButtonImageOptions2.Image"));
			ToolTipItem1.Appearance.Image = (System.Drawing.Image) (resources.GetObject("resource.Image"));
			ToolTipItem1.Appearance.Options.UseImage = true;
			ToolTipItem1.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("resource.Image1"));
			ToolTipItem1.Text = "Свернуть / Развернуть";
			ToolTipTitleItem1.Text = "Подсказка ...";
			SuperToolTip1.Items.Add(ToolTipItem1);
			SuperToolTip1.Items.Add(ToolTipSeparatorItem1);
			SuperToolTip1.Items.Add(ToolTipTitleItem1);
			this.gcPerformerInformation.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("", false, ButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Статистика подключений к базе данных", -1, true, null, true, false, true, null, 0), new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("", false, ButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, SuperToolTip1, true, false, true, "0", 2)});
			this.gcPerformerInformation.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
			this.gcPerformerInformation.Dock = System.Windows.Forms.DockStyle.Top;
			this.gcPerformerInformation.Location = new System.Drawing.Point(0, 0);
			this.gcPerformerInformation.Name = "gcPerformerInformation";
			this.gcPerformerInformation.Size = new System.Drawing.Size(796, 193);
			this.gcPerformerInformation.TabIndex = 0;
			this.gcPerformerInformation.Text = " Информация о сотруднике";
			//
			//GroupControl1
			//
			this.GroupControl1.AllowHtmlText = true;
			this.GroupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.GroupControl1.CaptionImageOptions.Image = (System.Drawing.Image) (resources.GetObject("GroupControl1.CaptionImageOptions.Image"));
			this.GroupControl1.Controls.Add(this.lbxPerfGroups);
			this.GroupControl1.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
			this.GroupControl1.Location = new System.Drawing.Point(585, 39);
			this.GroupControl1.Name = "GroupControl1";
			this.GroupControl1.Size = new System.Drawing.Size(209, 143);
			this.GroupControl1.TabIndex = 50;
			this.GroupControl1.Text = "Группы пользователя:</u>";
			//
			//lbxPerfGroups
			//
			this.lbxPerfGroups.Cursor = System.Windows.Forms.Cursors.Default;
			this.lbxPerfGroups.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbxPerfGroups.HotTrackItems = true;
			this.lbxPerfGroups.ItemAutoHeight = true;
			this.lbxPerfGroups.ItemHeight = 16;
			this.lbxPerfGroups.Location = new System.Drawing.Point(2, 23);
			this.lbxPerfGroups.Name = "lbxPerfGroups";
			this.lbxPerfGroups.ShowFocusRect = false;
			this.lbxPerfGroups.Size = new System.Drawing.Size(205, 118);
			this.lbxPerfGroups.SortOrder = System.Windows.Forms.SortOrder.Ascending;
			this.lbxPerfGroups.TabIndex = 0;
			//
			//LabelControl2
			//
			this.LabelControl2.AllowHtmlString = true;
			this.LabelControl2.Location = new System.Drawing.Point(233, 137);
			this.LabelControl2.Name = "LabelControl2";
			this.LabelControl2.Size = new System.Drawing.Size(28, 13);
			this.LabelControl2.TabIndex = 44;
			this.LabelControl2.Text = "<u>Email:</u>";
			//
			//txtRoleJob
			//
			this.txtRoleJob.Location = new System.Drawing.Point(72, 162);
			this.txtRoleJob.MenuManager = this.BarManager;
			this.txtRoleJob.Name = "txtRoleJob";
			this.txtRoleJob.Properties.AllowFocused = false;
			this.txtRoleJob.Properties.ContextImageOptions.Image = (System.Drawing.Image) (resources.GetObject("txtRoleJob.Properties.ContextImageOptions.Image"));
			this.txtRoleJob.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			this.txtRoleJob.Size = new System.Drawing.Size(507, 20);
			this.txtRoleJob.TabIndex = 9;
			//
			//LabelControl5
			//
			this.LabelControl5.AllowHtmlString = true;
			this.LabelControl5.Location = new System.Drawing.Point(5, 163);
			this.LabelControl5.Name = "LabelControl5";
			this.LabelControl5.Size = new System.Drawing.Size(61, 13);
			this.LabelControl5.TabIndex = 8;
			this.LabelControl5.Text = "<u>Должность:</u>";
			//
			//txtEmail
			//
			this.txtEmail.Location = new System.Drawing.Point(325, 136);
			this.txtEmail.MenuManager = this.BarManager;
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Properties.AllowFocused = false;
			this.txtEmail.Properties.ContextImageOptions.Image = (System.Drawing.Image) (resources.GetObject("txtEmail.Properties.ContextImageOptions.Image"));
			this.txtEmail.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			this.txtEmail.Size = new System.Drawing.Size(254, 20);
			this.txtEmail.TabIndex = 45;
			//
			//gcContacts
			//
			this.gcContacts.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.gcContacts.CaptionImageOptions.Image = (System.Drawing.Image) (resources.GetObject("gcContacts.CaptionImageOptions.Image"));
			this.gcContacts.Controls.Add(this.lbxContacts);
			this.gcContacts.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
			this.gcContacts.Location = new System.Drawing.Point(5, 39);
			this.gcContacts.Name = "gcContacts";
			this.gcContacts.Size = new System.Drawing.Size(222, 117);
			this.gcContacts.TabIndex = 43;
			this.gcContacts.Text = " Контакты пользователя";
			//
			//lbxContacts
			//
			this.lbxContacts.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
			this.lbxContacts.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
			this.lbxContacts.ContextButtonOptions.AllowHtmlText = true;
			this.lbxContacts.Cursor = System.Windows.Forms.Cursors.Default;
			this.lbxContacts.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbxContacts.HotTrackItems = true;
			this.lbxContacts.ItemAutoHeight = true;
			this.lbxContacts.ItemHeight = 16;
			this.lbxContacts.Location = new System.Drawing.Point(2, 23);
			this.lbxContacts.Name = "lbxContacts";
			this.lbxContacts.ShowFocusRect = false;
			this.lbxContacts.ShowToolTipForTrimmedText = DevExpress.Utils.DefaultBoolean.True;
			this.lbxContacts.Size = new System.Drawing.Size(218, 92);
			this.lbxContacts.SortOrder = System.Windows.Forms.SortOrder.Ascending;
			this.lbxContacts.TabIndex = 12;
			this.lbxContacts.Tag = "0";
			//
			//txtAddress
			//
			this.txtAddress.Location = new System.Drawing.Point(233, 54);
			this.txtAddress.MenuManager = this.BarManager;
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Properties.AllowFocused = false;
			this.txtAddress.Properties.AutoHeight = false;
			this.txtAddress.Properties.ContextImageOptions.Image = (System.Drawing.Image) (resources.GetObject("txtAddress.Properties.ContextImageOptions.Image"));
			this.txtAddress.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			this.txtAddress.Size = new System.Drawing.Size(346, 20);
			this.txtAddress.TabIndex = 0;
			//
			//LabelControl7
			//
			this.LabelControl7.AllowHtmlString = true;
			this.LabelControl7.Location = new System.Drawing.Point(233, 111);
			this.LabelControl7.Name = "LabelControl7";
			this.LabelControl7.Size = new System.Drawing.Size(86, 13);
			this.LabelControl7.TabIndex = 13;
			this.LabelControl7.Text = "<u>Пол сотрудника:</u>";
			//
			//LabelControl4
			//
			this.LabelControl4.AllowHtmlString = true;
			this.LabelControl4.Location = new System.Drawing.Point(426, 85);
			this.LabelControl4.Name = "LabelControl4";
			this.LabelControl4.Size = new System.Drawing.Size(47, 13);
			this.LabelControl4.TabIndex = 6;
			this.LabelControl4.Text = "<u>Кабинет:</u>";
			//
			//LabelControl3
			//
			this.LabelControl3.AllowHtmlString = true;
			this.LabelControl3.Location = new System.Drawing.Point(233, 85);
			this.LabelControl3.Name = "LabelControl3";
			this.LabelControl3.Size = new System.Drawing.Size(84, 13);
			this.LabelControl3.TabIndex = 4;
			this.LabelControl3.Text = "<u>Дата рождения:</u>";
			//
			//LabelControl1
			//
			this.LabelControl1.AllowHtmlString = true;
			this.LabelControl1.Location = new System.Drawing.Point(233, 39);
			this.LabelControl1.Name = "LabelControl1";
			this.LabelControl1.Size = new System.Drawing.Size(89, 13);
			this.LabelControl1.TabIndex = 1;
			this.LabelControl1.Text = "<u>Домашний адрес:</u>";
			//
			//txtRoomNumber
			//
			this.txtRoomNumber.EditValue = "";
			this.txtRoomNumber.Location = new System.Drawing.Point(479, 84);
			this.txtRoomNumber.Name = "txtRoomNumber";
			this.txtRoomNumber.Properties.AllowFocused = false;
			this.txtRoomNumber.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
			this.txtRoomNumber.Properties.AutoHeight = false;
			this.txtRoomNumber.Properties.ContextImageOptions.Image = (System.Drawing.Image) (resources.GetObject("txtRoomNumber.Properties.ContextImageOptions.Image"));
			this.txtRoomNumber.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			this.txtRoomNumber.Size = new System.Drawing.Size(100, 20);
			this.txtRoomNumber.TabIndex = 7;
			//
			//txtSex
			//
			this.txtSex.EditValue = "";
			this.txtSex.Location = new System.Drawing.Point(325, 110);
			this.txtSex.MenuManager = this.BarManager;
			this.txtSex.Name = "txtSex";
			this.txtSex.Properties.AllowFocused = false;
			this.txtSex.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
			this.txtSex.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			this.txtSex.Size = new System.Drawing.Size(132, 20);
			this.txtSex.TabIndex = 14;
			//
			//txtDtBirth
			//
			this.txtDtBirth.Location = new System.Drawing.Point(325, 84);
			this.txtDtBirth.Name = "txtDtBirth";
			this.txtDtBirth.Properties.AllowFocused = false;
			this.txtDtBirth.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.txtDtBirth.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.txtDtBirth.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			this.txtDtBirth.Size = new System.Drawing.Size(92, 20);
			this.txtDtBirth.TabIndex = 5;
			//
			//tmChecked
			//
			this.tmChecked.Enabled = true;
			//
			//pmMenuPerformers
			//
			this.pmMenuPerformers.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {new DevExpress.XtraBars.LinkPersistInfo(this.btnAddPerformer_pm), new DevExpress.XtraBars.LinkPersistInfo(this.btnEditPerformer_pm), new DevExpress.XtraBars.LinkPersistInfo(this.btnDelPerformer_pm)});
			this.pmMenuPerformers.Manager = this.BarManager;
			this.pmMenuPerformers.Name = "pmMenuPerformers";
			//
			//frSecurityUsers
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1251, 566);
			this.Controls.Add(this.SplitContainerControl1);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MinimumSize = new System.Drawing.Size(1267, 604);
			this.Name = "frSecurityUsers";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Испонители и безопасность";
			((System.ComponentModel.ISupportInitialize) this.SplitContainerControl1).EndInit();
			this.SplitContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.gcPerformers).EndInit();
			((System.ComponentModel.ISupportInitialize) this.gvPerformers).EndInit();
			((System.ComponentModel.ISupportInitialize) this.BarManager).EndInit();
			((System.ComponentModel.ISupportInitialize) this.ImageCollection).EndInit();
			((System.ComponentModel.ISupportInitialize) this.RepositoryItemSearchControl1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.tlRightsPerformer).EndInit();
			((System.ComponentModel.ISupportInitialize) this.gcPerformerInformation).EndInit();
			this.gcPerformerInformation.ResumeLayout(false);
			this.gcPerformerInformation.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.GroupControl1).EndInit();
			this.GroupControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.lbxPerfGroups).EndInit();
			((System.ComponentModel.ISupportInitialize) this.txtRoleJob.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.txtEmail.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.gcContacts).EndInit();
			this.gcContacts.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.lbxContacts).EndInit();
			((System.ComponentModel.ISupportInitialize) this.txtAddress.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.txtRoomNumber.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.txtSex.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.txtDtBirth.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.pmMenuPerformers).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		internal DevExpress.XtraEditors.SplitContainerControl SplitContainerControl1;
		internal DevExpress.XtraBars.BarManager BarManager;
		internal DevExpress.XtraBars.Bar Bar2;
		internal DevExpress.XtraBars.Bar barStatusBar;
		internal DevExpress.XtraBars.BarDockControl barDockControlTop;
		internal DevExpress.XtraBars.BarDockControl barDockControlBottom;
		internal DevExpress.XtraBars.BarDockControl barDockControlLeft;
		internal DevExpress.XtraBars.BarDockControl barDockControlRight;
		internal DevExpress.XtraBars.BarButtonItem btnSecurityUsers;
		internal DevExpress.XtraBars.BarStaticItem BarStaticItem2;
		internal DevExpress.XtraBars.BarButtonItem btnAddPerformer;
		internal DevExpress.Utils.ImageCollection ImageCollection;
		internal DevExpress.XtraBars.BarButtonItem btnEditPerformer;
		internal DevExpress.XtraBars.BarButtonItem btnDelPerformer;
		internal DevExpress.XtraBars.BarButtonItem btnUpdate;
		internal DevExpress.XtraGrid.GridControl gcPerformers;
		internal DevExpress.XtraGrid.Views.Grid.GridView gvPerformers;
		internal DevExpress.XtraTreeList.TreeList tlRightsPerformer;
		internal DevExpress.XtraEditors.GroupControl gcPerformerInformation;
		internal DevExpress.XtraBars.BarStaticItem lbServerName;
		internal DevExpress.XtraBars.BarStaticItem lbDB_name;
		internal DevExpress.XtraBars.BarEditItem BarEditItem1;
		internal DevExpress.XtraEditors.Repository.RepositoryItemSearchControl RepositoryItemSearchControl1;
		internal DevExpress.XtraEditors.LabelControl LabelControl1;
		internal DevExpress.XtraEditors.LabelControl LabelControl4;
		internal DevExpress.XtraEditors.LabelControl LabelControl3;
		internal DevExpress.XtraEditors.LabelControl LabelControl5;
		internal DevExpress.XtraEditors.LabelControl LabelControl7;
		internal DevExpress.XtraEditors.ButtonEdit txtAddress;
		internal DevExpress.XtraEditors.ButtonEdit txtRoomNumber;
		internal DevExpress.XtraEditors.GroupControl gcContacts;
		internal DevExpress.XtraEditors.ListBoxControl lbxContacts;
		internal DevExpress.XtraEditors.ButtonEdit txtSex;
		internal DevExpress.XtraEditors.ButtonEdit txtRoleJob;
		internal DevExpress.XtraEditors.ButtonEdit txtDtBirth;
		internal Timer tmChecked;
		internal DevExpress.XtraEditors.LabelControl LabelControl2;
		internal DevExpress.XtraEditors.ButtonEdit txtEmail;
		internal DevExpress.XtraEditors.GroupControl GroupControl1;
		internal DevExpress.XtraEditors.ListBoxControl lbxPerfGroups;
		internal DevExpress.XtraBars.BarButtonItem btnAddPerformer_pm;
		internal DevExpress.XtraBars.BarButtonItem btnEditPerformer_pm;
		internal DevExpress.XtraBars.BarButtonItem btnDelPerformer_pm;
		internal DevExpress.XtraBars.PopupMenu pmMenuPerformers;
	}
	
}
