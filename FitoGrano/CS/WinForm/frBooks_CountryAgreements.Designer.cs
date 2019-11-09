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
		public partial class frBooks_CountryAgreements : DevExpress.XtraEditors.XtraForm
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
			base.Load += new System.EventHandler(frBooks_ResearchObjects_Load);
			DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions ButtonImageOptions15 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frBooks_CountryAgreements));
			DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions ButtonImageOptions16 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
			DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions ButtonImageOptions17 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
			DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions ButtonImageOptions18 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
			DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions ButtonImageOptions19 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
			DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions ButtonImageOptions20 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
			DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions ButtonImageOptions21 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
			FitoGrano.ucTreeListClassificationProducts.UserControlProp UserControlProp3 = new FitoGrano.ucTreeListClassificationProducts.UserControlProp();
			FitoGrano.ucTreeListObjectsQurantine.UserControlProp UserControlProp4 = new FitoGrano.ucTreeListObjectsQurantine.UserControlProp();
			DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions ButtonImageOptions1 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
			DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions ButtonImageOptions2 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
			DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions ButtonImageOptions3 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
			DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions ButtonImageOptions4 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
			DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions ButtonImageOptions5 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
			DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions ButtonImageOptions6 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
			DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions ButtonImageOptions7 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
			this.BarManager = new DevExpress.XtraBars.BarManager(this.components);
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
			this.btnAddCountry = new DevExpress.XtraBars.BarButtonItem();
			this.btnAddCountry.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddCountry_ItemClick);
			this.btnEditCountry = new DevExpress.XtraBars.BarButtonItem();
			this.btnEditCountry.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditCountry_ItemClick);
			this.btnDeleteCountry = new DevExpress.XtraBars.BarButtonItem();
			this.btnDeleteCountry.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelCountry_ItemClick);
			this.btnAddAgreement = new DevExpress.XtraBars.BarButtonItem();
			this.btnAddAgreement.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddAgreement_ItemClick);
			this.btnEditAgreement = new DevExpress.XtraBars.BarButtonItem();
			this.btnEditAgreement.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditAgreement_ItemClick);
			this.btnDeleteAgreement = new DevExpress.XtraBars.BarButtonItem();
			this.btnDeleteAgreement.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDeleteAgreement_ItemClick);
			this.BarStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
			this.BarStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
			this.BarStaticItem3 = new DevExpress.XtraBars.BarStaticItem();
			this.btnAddObject = new DevExpress.XtraBars.BarButtonItem();
			this.btnEditObject = new DevExpress.XtraBars.BarButtonItem();
			this.btnDeleteObject = new DevExpress.XtraBars.BarButtonItem();
			this.tmChecked = new System.Windows.Forms.Timer(this.components);
			this.tmChecked.Tick += new System.EventHandler(this.tmChecked_Tick);
			this.pmMenuAgreements = new DevExpress.XtraBars.PopupMenu(this.components);
			this.SplitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
			this.gcnCountries = new DevExpress.XtraEditors.GroupControl();
			this.gcnCountries.CustomButtonClick += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.gcnObjects_CustomButtonClick);
			this.gcnCountries.CustomButtonChecked += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.gcnCountries_CustomButtonChecked);
			this.gcnCountries.CustomButtonUnchecked += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.gcnCountries_CustomButtonChecked);
			this.gcCountries = new DevExpress.XtraGrid.GridControl();
			this.gvCountries = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gvCountries.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvCountries_KeyDown);
			this.gvCountries.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gvCountries_MouseDown);
			this.gvCountries.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvCountries_FocusedRowChanged);
			this.XtraTabControl = new DevExpress.XtraTab.XtraTabControl();
			this.XtraTabControl.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.XtraTabControl_SelectedPageChanged);
			this.xtcObjects = new DevExpress.XtraTab.XtraTabPage();
			this.SplitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
			this.tlClassificationProducts = new FitoGrano.ucTreeListClassificationProducts();
			this.gcObjectIformation = new DevExpress.XtraEditors.GroupControl();
			this.SimpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			this.btnSaveObjectIformation = new DevExpress.XtraEditors.SimpleButton();
			this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.cmbUnits = new DevExpress.XtraEditors.LookUpEdit();
			this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.txtNorma = new DevExpress.XtraEditors.SpinEdit();
			this.tlObjectsQurantine = new FitoGrano.ucTreeListObjectsQurantine();
			this.lbProductIdIsNull = new DevExpress.XtraEditors.LabelControl();
			this.lbProductIdIsNull.Click += new System.EventHandler(this.lbProductIdIsNull_Click);
			this.xtcAgreements = new DevExpress.XtraTab.XtraTabPage();
			this.gcnAgreements = new DevExpress.XtraEditors.GroupControl();
			this.gcnAgreements.CustomButtonClick += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.gcnAgreements_CustomButtonClick);
			this.gcnAgreements.CustomButtonChecked += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.gcnAgreements_CustomButtonChecked);
			this.gcnAgreements.CustomButtonUnchecked += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.gcnAgreements_CustomButtonChecked);
			this.gcAgreement = new DevExpress.XtraGrid.GridControl();
			this.gvAgreement = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gvAgreement.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gvAgreement_MouseDown);
			this.gvAgreement.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvAgreement_FocusedRowChanged);
			this.pmMenuCountries = new DevExpress.XtraBars.PopupMenu(this.components);
			((System.ComponentModel.ISupportInitialize) this.BarManager).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.pmMenuAgreements).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.SplitContainerControl1).BeginInit();
			this.SplitContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.gcnCountries).BeginInit();
			this.gcnCountries.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.gcCountries).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.gvCountries).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.XtraTabControl).BeginInit();
			this.XtraTabControl.SuspendLayout();
			this.xtcObjects.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.SplitContainerControl2).BeginInit();
			this.SplitContainerControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.gcObjectIformation).BeginInit();
			this.gcObjectIformation.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.cmbUnits.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.txtNorma.Properties).BeginInit();
			this.xtcAgreements.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.gcnAgreements).BeginInit();
			this.gcnAgreements.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.gcAgreement).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.gvAgreement).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.pmMenuCountries).BeginInit();
			this.SuspendLayout();
			//
			//BarManager
			//
			this.BarManager.AllowShowToolbarsPopup = false;
			this.BarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.Bar1, this.Bar3});
			this.BarManager.DockControls.Add(this.barDockControlTop);
			this.BarManager.DockControls.Add(this.barDockControlBottom);
			this.BarManager.DockControls.Add(this.barDockControlLeft);
			this.BarManager.DockControls.Add(this.barDockControlRight);
			this.BarManager.Form = this;
			this.BarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {this.lbServerName, this.lbDB_name, this.btnUpdate, this.btnAddCountry, this.btnEditCountry, this.btnDeleteCountry, this.btnAddAgreement, this.btnEditAgreement, this.btnDeleteAgreement, this.BarStaticItem1, this.BarStaticItem2, this.BarStaticItem3, this.btnAddObject, this.btnEditObject, this.btnDeleteObject});
			this.BarManager.MaxItemId = 15;
			this.BarManager.StatusBar = this.Bar3;
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
			this.barDockControlTop.Manager = this.BarManager;
			this.barDockControlTop.Size = new System.Drawing.Size(1150, 29);
			//
			//barDockControlBottom
			//
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 588);
			this.barDockControlBottom.Manager = this.BarManager;
			this.barDockControlBottom.Size = new System.Drawing.Size(1150, 27);
			//
			//barDockControlLeft
			//
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 29);
			this.barDockControlLeft.Manager = this.BarManager;
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 559);
			//
			//barDockControlRight
			//
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(1150, 29);
			this.barDockControlRight.Manager = this.BarManager;
			this.barDockControlRight.Size = new System.Drawing.Size(0, 559);
			//
			//btnAddCountry
			//
			this.btnAddCountry.Caption = "Добавить";
			this.btnAddCountry.Id = 3;
			this.btnAddCountry.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnAddCountry.ImageOptions.Image"));
			this.btnAddCountry.Name = "btnAddCountry";
			//
			//btnEditCountry
			//
			this.btnEditCountry.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
			this.btnEditCountry.Caption = "Изменить          <i>Enter</i>";
			this.btnEditCountry.Id = 4;
			this.btnEditCountry.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnEditCountry.ImageOptions.Image"));
			this.btnEditCountry.Name = "btnEditCountry";
			//
			//btnDeleteCountry
			//
			this.btnDeleteCountry.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
			this.btnDeleteCountry.Caption = "Удалить             <i>Delete</i>";
			this.btnDeleteCountry.Id = 5;
			this.btnDeleteCountry.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnDeleteCountry.ImageOptions.Image"));
			this.btnDeleteCountry.Name = "btnDeleteCountry";
			//
			//btnAddAgreement
			//
			this.btnAddAgreement.Caption = "Добавить";
			this.btnAddAgreement.Id = 6;
			this.btnAddAgreement.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnAddAgreement.ImageOptions.Image"));
			this.btnAddAgreement.Name = "btnAddAgreement";
			//
			//btnEditAgreement
			//
			this.btnEditAgreement.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
			this.btnEditAgreement.Caption = "Изменить          <i>Enter</i>";
			this.btnEditAgreement.Id = 7;
			this.btnEditAgreement.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnEditAgreement.ImageOptions.Image"));
			this.btnEditAgreement.Name = "btnEditAgreement";
			//
			//btnDeleteAgreement
			//
			this.btnDeleteAgreement.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
			this.btnDeleteAgreement.Caption = "Удалить             <i>Delete</i>";
			this.btnDeleteAgreement.Id = 8;
			this.btnDeleteAgreement.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnDeleteAgreement.ImageOptions.Image"));
			this.btnDeleteAgreement.Name = "btnDeleteAgreement";
			//
			//BarStaticItem1
			//
			this.BarStaticItem1.Caption = "   Страны   ";
			this.BarStaticItem1.Id = 9;
			this.BarStaticItem1.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", (float) (8.25F), (System.Drawing.FontStyle) ((int) (System.Drawing.FontStyle.Bold) | (int) System.Drawing.FontStyle.Underline));
			this.BarStaticItem1.ItemAppearance.Normal.Options.UseFont = true;
			this.BarStaticItem1.Name = "BarStaticItem1";
			//
			//BarStaticItem2
			//
			this.BarStaticItem2.Caption = "   Соглашения   ";
			this.BarStaticItem2.Id = 10;
			this.BarStaticItem2.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", (float) (8.25F), (System.Drawing.FontStyle) ((int) (System.Drawing.FontStyle.Bold) | (int) System.Drawing.FontStyle.Underline));
			this.BarStaticItem2.ItemAppearance.Normal.Options.UseFont = true;
			this.BarStaticItem2.Name = "BarStaticItem2";
			//
			//BarStaticItem3
			//
			this.BarStaticItem3.Caption = "   Соглашения   ";
			this.BarStaticItem3.Id = 11;
			this.BarStaticItem3.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", (float) (8.25F), (System.Drawing.FontStyle) ((int) (System.Drawing.FontStyle.Bold) | (int) System.Drawing.FontStyle.Underline));
			this.BarStaticItem3.ItemAppearance.Normal.Options.UseFont = true;
			this.BarStaticItem3.Name = "BarStaticItem3";
			//
			//btnAddObject
			//
			this.btnAddObject.Caption = "Добавить";
			this.btnAddObject.Id = 12;
			this.btnAddObject.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnAddObject.ImageOptions.Image"));
			this.btnAddObject.Name = "btnAddObject";
			//
			//btnEditObject
			//
			this.btnEditObject.Caption = "Изменить";
			this.btnEditObject.Id = 13;
			this.btnEditObject.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnEditObject.ImageOptions.Image"));
			this.btnEditObject.Name = "btnEditObject";
			//
			//btnDeleteObject
			//
			this.btnDeleteObject.Caption = "Удалить";
			this.btnDeleteObject.Id = 14;
			this.btnDeleteObject.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnDeleteObject.ImageOptions.Image"));
			this.btnDeleteObject.Name = "btnDeleteObject";
			//
			//tmChecked
			//
			this.tmChecked.Enabled = true;
			//
			//pmMenuAgreements
			//
			this.pmMenuAgreements.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {new DevExpress.XtraBars.LinkPersistInfo(this.BarStaticItem2), new DevExpress.XtraBars.LinkPersistInfo(this.btnAddAgreement, true), new DevExpress.XtraBars.LinkPersistInfo(this.btnEditAgreement), new DevExpress.XtraBars.LinkPersistInfo(this.btnDeleteAgreement)});
			this.pmMenuAgreements.Manager = this.BarManager;
			this.pmMenuAgreements.Name = "pmMenuAgreements";
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
			this.SplitContainerControl1.Panel1.Controls.Add(this.gcnCountries);
			this.SplitContainerControl1.Panel1.MinSize = 30;
			this.SplitContainerControl1.Panel2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", (float) (8.25F), (System.Drawing.FontStyle) ((int) (System.Drawing.FontStyle.Bold) | (int) System.Drawing.FontStyle.Underline));
			this.SplitContainerControl1.Panel2.AppearanceCaption.Options.UseFont = true;
			this.SplitContainerControl1.Panel2.AppearanceCaption.Options.UseTextOptions = true;
			this.SplitContainerControl1.Panel2.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.SplitContainerControl1.Panel2.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
			this.SplitContainerControl1.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.SplitContainerControl1.Panel2.CaptionLocation = DevExpress.Utils.Locations.Top;
			this.SplitContainerControl1.Panel2.Controls.Add(this.XtraTabControl);
			this.SplitContainerControl1.Size = new System.Drawing.Size(1150, 559);
			this.SplitContainerControl1.SplitterPosition = 264;
			this.SplitContainerControl1.TabIndex = 4;
			//
			//gcnCountries
			//
			this.gcnCountries.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (8.0F));
			this.gcnCountries.Appearance.Options.UseFont = true;
			this.gcnCountries.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", (float) (9.0F), (System.Drawing.FontStyle) ((int) (System.Drawing.FontStyle.Bold) | (int) System.Drawing.FontStyle.Underline));
			this.gcnCountries.AppearanceCaption.Options.UseFont = true;
			this.gcnCountries.AppearanceCaption.Options.UseTextOptions = true;
			this.gcnCountries.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
			this.gcnCountries.Controls.Add(this.gcCountries);
			ButtonImageOptions15.Image = (System.Drawing.Image) (resources.GetObject("ButtonImageOptions15.Image"));
			ButtonImageOptions16.Image = (System.Drawing.Image) (resources.GetObject("ButtonImageOptions16.Image"));
			ButtonImageOptions17.Image = (System.Drawing.Image) (resources.GetObject("ButtonImageOptions17.Image"));
			ButtonImageOptions19.Image = (System.Drawing.Image) (resources.GetObject("ButtonImageOptions19.Image"));
			ButtonImageOptions20.Image = (System.Drawing.Image) (resources.GetObject("ButtonImageOptions20.Image"));
			ButtonImageOptions21.Image = (System.Drawing.Image) (resources.GetObject("ButtonImageOptions21.Image"));
			this.gcnCountries.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("", false, ButtonImageOptions15, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Добавить", 0, true, null, true, false, true, null, 1), new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("", false, ButtonImageOptions16, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Изменить", 1, true, null, true, false, true, null, 1), new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("", false, ButtonImageOptions17, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Удалить", 2, true, null, true, false, true, null, 1), new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("|", true, ButtonImageOptions18, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", 3, false, null, true, false, true, null, -1), new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("", false, ButtonImageOptions19, DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, "Показать панель поиска", 4, true, null, true, false, true, null, 3), new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("", false, ButtonImageOptions20, DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, "Показать строку автофильтра", 5, true, null, true, false, true, null, 4), new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("", false, ButtonImageOptions21, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Очистить сортировку", 6, true, null, true, false, true, null, -1)});
			this.gcnCountries.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
			this.gcnCountries.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gcnCountries.Location = new System.Drawing.Point(0, 0);
			this.gcnCountries.Name = "gcnCountries";
			this.gcnCountries.Size = new System.Drawing.Size(260, 551);
			this.gcnCountries.TabIndex = 0;
			this.gcnCountries.Text = "Страны";
			//
			//gcCountries
			//
			this.gcCountries.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gcCountries.Location = new System.Drawing.Point(2, 29);
			this.gcCountries.MainView = this.gvCountries;
			this.gcCountries.MenuManager = this.BarManager;
			this.gcCountries.Name = "gcCountries";
			this.gcCountries.Size = new System.Drawing.Size(256, 520);
			this.gcCountries.TabIndex = 0;
			this.gcCountries.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.gvCountries});
			//
			//gvCountries
			//
			this.gvCountries.Appearance.HeaderPanel.Options.UseTextOptions = true;
			this.gvCountries.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gvCountries.Appearance.HeaderPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
			this.gvCountries.GridControl = this.gcCountries;
			this.gvCountries.Name = "gvCountries";
			this.gvCountries.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvCountries.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvCountries.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
			this.gvCountries.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
			this.gvCountries.OptionsBehavior.Editable = false;
			this.gvCountries.OptionsCustomization.AllowColumnMoving = false;
			this.gvCountries.OptionsCustomization.AllowGroup = false;
			this.gvCountries.OptionsDetail.EnableMasterViewMode = false;
			this.gvCountries.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
			this.gvCountries.OptionsFind.SearchInPreview = true;
			this.gvCountries.OptionsFind.ShowClearButton = false;
			this.gvCountries.OptionsMenu.EnableColumnMenu = false;
			this.gvCountries.OptionsMenu.EnableFooterMenu = false;
			this.gvCountries.OptionsMenu.EnableGroupPanelMenu = false;
			this.gvCountries.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gvCountries.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
			this.gvCountries.OptionsView.ShowGroupPanel = false;
			this.gvCountries.OptionsView.ShowIndicator = false;
			//
			//XtraTabControl
			//
			this.XtraTabControl.AllowHtmlDraw = true;
			this.XtraTabControl.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (9.0F));
			this.XtraTabControl.Appearance.Options.UseFont = true;
			this.XtraTabControl.AppearancePage.Header.Font = new System.Drawing.Font("Tahoma", (float) (10.0F));
			this.XtraTabControl.AppearancePage.Header.Options.UseFont = true;
			this.XtraTabControl.AppearancePage.Header.Options.UseTextOptions = true;
			this.XtraTabControl.AppearancePage.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.XtraTabControl.AppearancePage.Header.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
			this.XtraTabControl.AppearancePage.Header.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.XtraTabControl.AppearancePage.HeaderActive.Font = new System.Drawing.Font("Tahoma", (float) (10.0F), System.Drawing.FontStyle.Bold);
			this.XtraTabControl.AppearancePage.HeaderActive.Options.UseFont = true;
			this.XtraTabControl.AppearancePage.HeaderActive.Options.UseTextOptions = true;
			this.XtraTabControl.AppearancePage.HeaderActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.XtraTabControl.AppearancePage.HeaderActive.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
			this.XtraTabControl.AppearancePage.HeaderActive.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.XtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.XtraTabControl.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.True;
			this.XtraTabControl.Location = new System.Drawing.Point(0, 0);
			this.XtraTabControl.Name = "XtraTabControl";
			this.XtraTabControl.SelectedTabPage = this.xtcObjects;
			this.XtraTabControl.ShowHeaderFocus = DevExpress.Utils.DefaultBoolean.False;
			this.XtraTabControl.Size = new System.Drawing.Size(873, 551);
			this.XtraTabControl.TabIndex = 1;
			this.XtraTabControl.TabMiddleClickFiringMode = DevExpress.XtraTab.TabMiddleClickFiringMode.None;
			this.XtraTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {this.xtcObjects, this.xtcAgreements});
			//
			//xtcObjects
			//
			this.xtcObjects.Appearance.Header.Options.UseTextOptions = true;
			this.xtcObjects.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.xtcObjects.Appearance.Header.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.xtcObjects.Appearance.HeaderActive.Options.UseTextOptions = true;
			this.xtcObjects.Appearance.HeaderActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.xtcObjects.Appearance.HeaderActive.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.xtcObjects.Controls.Add(this.SplitContainerControl2);
			this.xtcObjects.Name = "xtcObjects";
			this.xtcObjects.Size = new System.Drawing.Size(867, 520);
			this.xtcObjects.Text = "<image=#karantin_24x24>    <u>Карантинные объекты";
			//
			//SplitContainerControl2
			//
			this.SplitContainerControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.SplitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SplitContainerControl2.Location = new System.Drawing.Point(0, 0);
			this.SplitContainerControl2.Name = "SplitContainerControl2";
			this.SplitContainerControl2.Panel1.Controls.Add(this.tlClassificationProducts);
			this.SplitContainerControl2.Panel1.MinSize = 265;
			this.SplitContainerControl2.Panel1.Text = "Panel1";
			this.SplitContainerControl2.Panel2.Controls.Add(this.gcObjectIformation);
			this.SplitContainerControl2.Panel2.Controls.Add(this.tlObjectsQurantine);
			this.SplitContainerControl2.Panel2.Controls.Add(this.lbProductIdIsNull);
			this.SplitContainerControl2.Panel2.Text = "Panel2";
			this.SplitContainerControl2.Size = new System.Drawing.Size(867, 520);
			this.SplitContainerControl2.SplitterPosition = 323;
			this.SplitContainerControl2.TabIndex = 2;
			this.SplitContainerControl2.Text = "SplitContainerControl2";
			//
			//tlClassificationProducts
			//
			this.tlClassificationProducts.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlClassificationProducts.Location = new System.Drawing.Point(0, 0);
			this.tlClassificationProducts.Name = "tlClassificationProducts";
			this.tlClassificationProducts.Size = new System.Drawing.Size(323, 516);
			this.tlClassificationProducts.TabIndex = 0;
			UserControlProp3.btnMultiCheckingIsVisible = false;
			UserControlProp3.IsCheckBoxes = false;
			this.tlClassificationProducts.UserControlProperty = UserControlProp3;
			//
			//gcObjectIformation
			//
			this.gcObjectIformation.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left 
				| System.Windows.Forms.AnchorStyles.Right;
			this.gcObjectIformation.CaptionImageOptions.Image = (System.Drawing.Image) (resources.GetObject("gcObjectIformation.CaptionImageOptions.Image"));
			this.gcObjectIformation.Controls.Add(this.SimpleButton1);
			this.gcObjectIformation.Controls.Add(this.btnSaveObjectIformation);
			this.gcObjectIformation.Controls.Add(this.LabelControl2);
			this.gcObjectIformation.Controls.Add(this.cmbUnits);
			this.gcObjectIformation.Controls.Add(this.LabelControl1);
			this.gcObjectIformation.Controls.Add(this.txtNorma);
			this.gcObjectIformation.Location = new System.Drawing.Point(0, 342);
			this.gcObjectIformation.Name = "gcObjectIformation";
			this.gcObjectIformation.Size = new System.Drawing.Size(535, 172);
			this.gcObjectIformation.TabIndex = 2;
			this.gcObjectIformation.Text = "  Информация об объекте исследования:";
			//
			//SimpleButton1
			//
			this.SimpleButton1.AllowFocus = false;
			this.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
			this.SimpleButton1.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("SimpleButton1.ImageOptions.Image"));
			this.SimpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
			this.SimpleButton1.Location = new System.Drawing.Point(385, 46);
			this.SimpleButton1.Name = "SimpleButton1";
			this.SimpleButton1.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
			this.SimpleButton1.Size = new System.Drawing.Size(20, 20);
			this.SimpleButton1.TabIndex = 6;
			this.SimpleButton1.ToolTip = "Убрать норму " + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(13)) + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(10)) + "содержания";
			//
			//btnSaveObjectIformation
			//
			this.btnSaveObjectIformation.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			this.btnSaveObjectIformation.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnSaveObjectIformation.ImageOptions.Image"));
			this.btnSaveObjectIformation.Location = new System.Drawing.Point(424, 44);
			this.btnSaveObjectIformation.Name = "btnSaveObjectIformation";
			this.btnSaveObjectIformation.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
			this.btnSaveObjectIformation.Size = new System.Drawing.Size(106, 23);
			this.btnSaveObjectIformation.TabIndex = 5;
			this.btnSaveObjectIformation.Text = "Сохранить";
			//
			//LabelControl2
			//
			this.LabelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (8.25F), System.Drawing.FontStyle.Underline);
			this.LabelControl2.Appearance.Options.UseFont = true;
			this.LabelControl2.Location = new System.Drawing.Point(10, 72);
			this.LabelControl2.Name = "LabelControl2";
			this.LabelControl2.Size = new System.Drawing.Size(91, 13);
			this.LabelControl2.TabIndex = 4;
			this.LabelControl2.Text = "Правовая основа:";
			//
			//cmbUnits
			//
			this.cmbUnits.Location = new System.Drawing.Point(116, 46);
			this.cmbUnits.MenuManager = this.BarManager;
			this.cmbUnits.Name = "cmbUnits";
			this.cmbUnits.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
			this.cmbUnits.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cmbUnits.Properties.NullText = "Ед.изм. не выбрана";
			this.cmbUnits.Properties.ShowFooter = false;
			this.cmbUnits.Properties.ShowHeader = false;
			this.cmbUnits.Size = new System.Drawing.Size(266, 20);
			this.cmbUnits.TabIndex = 3;
			//
			//LabelControl1
			//
			this.LabelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (8.25F), System.Drawing.FontStyle.Underline);
			this.LabelControl1.Appearance.Options.UseFont = true;
			this.LabelControl1.Location = new System.Drawing.Point(10, 31);
			this.LabelControl1.Name = "LabelControl1";
			this.LabelControl1.Size = new System.Drawing.Size(161, 13);
			this.LabelControl1.TabIndex = 2;
			this.LabelControl1.Text = "Норма содержания в продукци:";
			//
			//txtNorma
			//
			this.txtNorma.EditValue = new decimal(new int[] {0, 0, 0, 0});
			this.txtNorma.Location = new System.Drawing.Point(10, 46);
			this.txtNorma.MenuManager = this.BarManager;
			this.txtNorma.Name = "txtNorma";
			this.txtNorma.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtNorma.Properties.MaxValue = new decimal(new int[] {1215752192, 23, 0, 0});
			this.txtNorma.Size = new System.Drawing.Size(100, 20);
			this.txtNorma.TabIndex = 0;
			//
			//tlObjectsQurantine
			//
			this.tlObjectsQurantine.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom 
				| System.Windows.Forms.AnchorStyles.Left 
				| System.Windows.Forms.AnchorStyles.Right;
			this.tlObjectsQurantine.Location = new System.Drawing.Point(0, 0);
			this.tlObjectsQurantine.Name = "tlObjectsQurantine";
			this.tlObjectsQurantine.Size = new System.Drawing.Size(535, 341);
			this.tlObjectsQurantine.TabIndex = 0;
			UserControlProp4.btnMultiCheckingIsVisible = false;
			UserControlProp4.IsCheckBoxes = false;
			this.tlObjectsQurantine.UserControlProperty = UserControlProp4;
			//
			//lbProductIdIsNull
			//
			this.lbProductIdIsNull.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.lbProductIdIsNull.Appearance.Image = (System.Drawing.Image) (resources.GetObject("lbProductIdIsNull.Appearance.Image"));
			this.lbProductIdIsNull.Appearance.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.lbProductIdIsNull.Appearance.Options.UseBackColor = true;
			this.lbProductIdIsNull.Appearance.Options.UseImage = true;
			this.lbProductIdIsNull.Appearance.Options.UseImageAlign = true;
			this.lbProductIdIsNull.Appearance.Options.UseTextOptions = true;
			this.lbProductIdIsNull.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.lbProductIdIsNull.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.lbProductIdIsNull.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbProductIdIsNull.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
			this.lbProductIdIsNull.Location = new System.Drawing.Point(0, 0);
			this.lbProductIdIsNull.Name = "lbProductIdIsNull";
			this.lbProductIdIsNull.Size = new System.Drawing.Size(535, 516);
			this.lbProductIdIsNull.TabIndex = 1;
			this.lbProductIdIsNull.Text = "  Для отображения объектов исследования" + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(13)) + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(10)) + "  выберите наименование продукции";
			this.lbProductIdIsNull.Visible = false;
			//
			//xtcAgreements
			//
			this.xtcAgreements.Controls.Add(this.gcnAgreements);
			this.xtcAgreements.Name = "xtcAgreements";
			this.xtcAgreements.Size = new System.Drawing.Size(867, 520);
			this.xtcAgreements.Text = "<image=#agreements_24x24>    <u>Соглашения";
			//
			//gcnAgreements
			//
			this.gcnAgreements.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (8.0F));
			this.gcnAgreements.Appearance.Options.UseFont = true;
			this.gcnAgreements.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", (float) (9.0F), (System.Drawing.FontStyle) ((int) (System.Drawing.FontStyle.Bold) | (int) System.Drawing.FontStyle.Underline));
			this.gcnAgreements.AppearanceCaption.Options.UseFont = true;
			this.gcnAgreements.AppearanceCaption.Options.UseTextOptions = true;
			this.gcnAgreements.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
			this.gcnAgreements.Controls.Add(this.gcAgreement);
			ButtonImageOptions1.Image = (System.Drawing.Image) (resources.GetObject("ButtonImageOptions1.Image"));
			ButtonImageOptions2.Image = (System.Drawing.Image) (resources.GetObject("ButtonImageOptions2.Image"));
			ButtonImageOptions3.Image = (System.Drawing.Image) (resources.GetObject("ButtonImageOptions3.Image"));
			ButtonImageOptions5.Image = (System.Drawing.Image) (resources.GetObject("ButtonImageOptions5.Image"));
			ButtonImageOptions6.Image = (System.Drawing.Image) (resources.GetObject("ButtonImageOptions6.Image"));
			ButtonImageOptions7.Image = (System.Drawing.Image) (resources.GetObject("ButtonImageOptions7.Image"));
			this.gcnAgreements.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("btnAddAgreement", false, ButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Добавить", 0, true, null, true, false, true, null, 2), new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("btnEditAgreement", false, ButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Изменить", 1, true, null, true, false, true, null, 2), new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("btnDeleteAgreement", false, ButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Удалаить", 2, true, null, true, false, true, null, 2), new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("|", true, ButtonImageOptions4, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", 3, false, null, true, false, true, null, -1), new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("btnSearch_Agreement", false, ButtonImageOptions5, DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, "Показать панель поиска", 4, true, null, true, false, true, null, 5), new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("btnAutoFilter_Agreement", false, ButtonImageOptions6, DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, "Показать строку автофильтра", 5, true, null, true, false, true, null, 6), new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("btnClearSort_Agreement", false, ButtonImageOptions7, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Очистить сортировку", 6, true, null, true, false, true, null, -1)});
			this.gcnAgreements.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
			this.gcnAgreements.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gcnAgreements.Location = new System.Drawing.Point(0, 0);
			this.gcnAgreements.Name = "gcnAgreements";
			this.gcnAgreements.Size = new System.Drawing.Size(867, 520);
			this.gcnAgreements.TabIndex = 0;
			//
			//gcAgreement
			//
			this.gcAgreement.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gcAgreement.Location = new System.Drawing.Point(2, 29);
			this.gcAgreement.MainView = this.gvAgreement;
			this.gcAgreement.MenuManager = this.BarManager;
			this.gcAgreement.Name = "gcAgreement";
			this.gcAgreement.Size = new System.Drawing.Size(863, 489);
			this.gcAgreement.TabIndex = 0;
			this.gcAgreement.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.gvAgreement});
			//
			//gvAgreement
			//
			this.gvAgreement.Appearance.HeaderPanel.Options.UseTextOptions = true;
			this.gvAgreement.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gvAgreement.Appearance.HeaderPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
			this.gvAgreement.Appearance.Row.Options.UseTextOptions = true;
			this.gvAgreement.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
			this.gvAgreement.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
			this.gvAgreement.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
			this.gvAgreement.GridControl = this.gcAgreement;
			this.gvAgreement.Name = "gvAgreement";
			this.gvAgreement.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvAgreement.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvAgreement.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
			this.gvAgreement.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
			this.gvAgreement.OptionsBehavior.Editable = false;
			this.gvAgreement.OptionsCustomization.AllowColumnMoving = false;
			this.gvAgreement.OptionsCustomization.AllowGroup = false;
			this.gvAgreement.OptionsDetail.EnableMasterViewMode = false;
			this.gvAgreement.OptionsMenu.EnableColumnMenu = false;
			this.gvAgreement.OptionsMenu.EnableFooterMenu = false;
			this.gvAgreement.OptionsMenu.EnableGroupPanelMenu = false;
			this.gvAgreement.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gvAgreement.OptionsView.AutoCalcPreviewLineCount = true;
			this.gvAgreement.OptionsView.RowAutoHeight = true;
			this.gvAgreement.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
			this.gvAgreement.OptionsView.ShowGroupPanel = false;
			//
			//pmMenuCountries
			//
			this.pmMenuCountries.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {new DevExpress.XtraBars.LinkPersistInfo(this.BarStaticItem1), new DevExpress.XtraBars.LinkPersistInfo(this.btnAddCountry, true), new DevExpress.XtraBars.LinkPersistInfo(this.btnEditCountry), new DevExpress.XtraBars.LinkPersistInfo(this.btnDeleteCountry)});
			this.pmMenuCountries.Manager = this.BarManager;
			this.pmMenuCountries.Name = "pmMenuCountries";
			//
			//frBooks_CountryAgreements
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1150, 615);
			this.Controls.Add(this.SplitContainerControl1);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MinimumSize = new System.Drawing.Size(969, 573);
			this.Name = "frBooks_CountryAgreements";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Страны и соглашения";
			((System.ComponentModel.ISupportInitialize) this.BarManager).EndInit();
			((System.ComponentModel.ISupportInitialize) this.pmMenuAgreements).EndInit();
			((System.ComponentModel.ISupportInitialize) this.SplitContainerControl1).EndInit();
			this.SplitContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.gcnCountries).EndInit();
			this.gcnCountries.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.gcCountries).EndInit();
			((System.ComponentModel.ISupportInitialize) this.gvCountries).EndInit();
			((System.ComponentModel.ISupportInitialize) this.XtraTabControl).EndInit();
			this.XtraTabControl.ResumeLayout(false);
			this.xtcObjects.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.SplitContainerControl2).EndInit();
			this.SplitContainerControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.gcObjectIformation).EndInit();
			this.gcObjectIformation.ResumeLayout(false);
			this.gcObjectIformation.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.cmbUnits.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.txtNorma.Properties).EndInit();
			this.xtcAgreements.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.gcnAgreements).EndInit();
			this.gcnAgreements.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.gcAgreement).EndInit();
			((System.ComponentModel.ISupportInitialize) this.gvAgreement).EndInit();
			((System.ComponentModel.ISupportInitialize) this.pmMenuCountries).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		
		internal DevExpress.XtraBars.BarManager BarManager;
		internal DevExpress.XtraBars.Bar Bar1;
		internal DevExpress.XtraBars.Bar Bar3;
		internal DevExpress.XtraBars.BarStaticItem lbServerName;
		internal DevExpress.XtraBars.BarStaticItem lbDB_name;
		internal DevExpress.XtraBars.BarButtonItem btnUpdate;
		internal DevExpress.XtraBars.BarDockControl barDockControlTop;
		internal DevExpress.XtraBars.BarDockControl barDockControlBottom;
		internal DevExpress.XtraBars.BarDockControl barDockControlLeft;
		internal DevExpress.XtraBars.BarDockControl barDockControlRight;
		internal DevExpress.XtraBars.BarButtonItem btnAddCountry;
		internal DevExpress.XtraBars.BarButtonItem btnEditCountry;
		internal DevExpress.XtraBars.BarButtonItem btnDeleteCountry;
		internal DevExpress.XtraBars.BarButtonItem btnAddAgreement;
		internal DevExpress.XtraBars.BarButtonItem btnEditAgreement;
		internal DevExpress.XtraBars.BarButtonItem btnDeleteAgreement;
		internal DevExpress.XtraBars.BarStaticItem BarStaticItem1;
		internal DevExpress.XtraBars.BarStaticItem BarStaticItem2;
		internal Timer tmChecked;
		internal DevExpress.XtraBars.PopupMenu pmMenuAgreements;
		internal DevExpress.XtraEditors.SplitContainerControl SplitContainerControl1;
		internal DevExpress.XtraEditors.GroupControl gcnCountries;
		internal DevExpress.XtraGrid.GridControl gcCountries;
		internal DevExpress.XtraGrid.Views.Grid.GridView gvCountries;
		internal DevExpress.XtraEditors.GroupControl gcnAgreements;
		internal DevExpress.XtraGrid.GridControl gcAgreement;
		internal DevExpress.XtraGrid.Views.Grid.GridView gvAgreement;
		internal DevExpress.XtraTab.XtraTabControl XtraTabControl;
		internal DevExpress.XtraTab.XtraTabPage xtcObjects;
		internal DevExpress.XtraTab.XtraTabPage xtcAgreements;
		internal DevExpress.XtraBars.PopupMenu pmMenuCountries;
		internal DevExpress.XtraBars.BarStaticItem BarStaticItem3;
		internal DevExpress.XtraBars.BarButtonItem btnAddObject;
		internal DevExpress.XtraBars.BarButtonItem btnEditObject;
		internal DevExpress.XtraBars.BarButtonItem btnDeleteObject;
		internal DevExpress.XtraEditors.SplitContainerControl SplitContainerControl2;
		internal ucTreeListClassificationProducts tlClassificationProducts;
		internal ucTreeListObjectsQurantine tlObjectsQurantine;
		internal DevExpress.XtraEditors.LabelControl lbProductIdIsNull;
		internal DevExpress.XtraEditors.GroupControl gcObjectIformation;
		internal DevExpress.XtraEditors.LabelControl LabelControl1;
		internal DevExpress.XtraEditors.SpinEdit txtNorma;
		internal DevExpress.XtraEditors.LabelControl LabelControl2;
		internal DevExpress.XtraEditors.LookUpEdit cmbUnits;
		internal DevExpress.XtraEditors.SimpleButton btnSaveObjectIformation;
		internal DevExpress.XtraEditors.SimpleButton SimpleButton1;
	}
	
}
