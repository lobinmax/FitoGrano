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
	partial class frMain : DevExpress.XtraEditors.XtraForm
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
			base.Load += new System.EventHandler(frMain_Load);
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frMain));
			this.BarManager = new DevExpress.XtraBars.BarManager(this.components);
			this.Bar2 = new DevExpress.XtraBars.Bar();
			this.BarLinkContainerItem1 = new DevExpress.XtraBars.BarLinkContainerItem();
			this.btnClassificationProducts = new DevExpress.XtraBars.BarButtonItem();
			this.btnClassificationProducts.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClassificationProducts_ItemClick);
			this.btnResearchDirection = new DevExpress.XtraBars.BarButtonItem();
			this.btnResearchDirection.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnResearchDirection_ItemClick);
			this.btnResearchObjects = new DevExpress.XtraBars.BarButtonItem();
			this.btnResearchObjects.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnResearchObjects_ItemClick);
			this.btnOrganizationStructure = new DevExpress.XtraBars.BarButtonItem();
			this.btnOrganizationStructure.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnOrganizationStructure_ItemClick);
			this.btnCountryAgreements = new DevExpress.XtraBars.BarButtonItem();
			this.btnCountryAgreements.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCountryAgreements_ItemClick);
			this.btnServises = new DevExpress.XtraBars.BarLinkContainerItem();
			this.btnSecurityUsers = new DevExpress.XtraBars.BarButtonItem();
			this.btnSecurityUsers.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSecurityUsers_ItemClick);
			this.btnChangeSkin = new DevExpress.XtraBars.SkinBarSubItem();
			this.barStatusBar = new DevExpress.XtraBars.Bar();
			this.lbDivisionName = new DevExpress.XtraBars.BarStaticItem();
			this.lbServerName = new DevExpress.XtraBars.BarStaticItem();
			this.lbDataBaseName = new DevExpress.XtraBars.BarStaticItem();
			this.lbUserName = new DevExpress.XtraBars.BarStaticItem();
			this.lbDateTime = new DevExpress.XtraBars.BarStaticItem();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.ImageCollection = new DevExpress.Utils.ImageCollection(this.components);
			this.BarStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
			this.BarButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
			this.BarButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
			this.BarButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItem2_ItemClick);
			this.SkinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
			this.BarToolbarsListItem1 = new DevExpress.XtraBars.BarToolbarsListItem();
			this.SkinBarSubItem2 = new DevExpress.XtraBars.SkinBarSubItem();
			this.BarEditItem1 = new DevExpress.XtraBars.BarEditItem();
			this.RepositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
			this.ptbFone = new DevExpress.XtraEditors.PictureEdit();
			this.ptbGerb = new DevExpress.XtraEditors.PictureEdit();
			this.tmrDateTime = new System.Windows.Forms.Timer(this.components);
			this.tmrDateTime.Tick += new System.EventHandler(this.tmrDateTime_Tick);
			((System.ComponentModel.ISupportInitialize) this.BarManager).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.ImageCollection).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.RepositoryItemTextEdit1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.ptbFone.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.ptbGerb.Properties).BeginInit();
			this.SuspendLayout();
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
			this.BarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {this.btnServises, this.btnSecurityUsers, this.BarLinkContainerItem1, this.lbDivisionName, this.lbDataBaseName, this.lbServerName, this.lbUserName, this.lbDateTime, this.BarStaticItem2, this.btnOrganizationStructure, this.BarButtonItem1, this.BarButtonItem2, this.SkinBarSubItem1, this.BarToolbarsListItem1, this.SkinBarSubItem2, this.BarEditItem1, this.btnChangeSkin, this.btnClassificationProducts, this.btnResearchDirection, this.btnResearchObjects, this.btnCountryAgreements});
			this.BarManager.MainMenu = this.Bar2;
			this.BarManager.MaxItemId = 21;
			this.BarManager.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {this.RepositoryItemTextEdit1});
			this.BarManager.StatusBar = this.barStatusBar;
			//
			//Bar2
			//
			this.Bar2.BarName = "Главное меню";
			this.Bar2.DockCol = 0;
			this.Bar2.DockRow = 0;
			this.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.Bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {new DevExpress.XtraBars.LinkPersistInfo(this.BarLinkContainerItem1), new DevExpress.XtraBars.LinkPersistInfo(this.btnServises)});
			this.Bar2.OptionsBar.AllowQuickCustomization = false;
			this.Bar2.OptionsBar.DrawBorder = false;
			this.Bar2.OptionsBar.DrawDragBorder = false;
			this.Bar2.OptionsBar.MultiLine = true;
			this.Bar2.OptionsBar.UseWholeRow = true;
			this.Bar2.Text = "Главное меню";
			//
			//BarLinkContainerItem1
			//
			this.BarLinkContainerItem1.Caption = "Справочники";
			this.BarLinkContainerItem1.Id = 2;
			this.BarLinkContainerItem1.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("BarLinkContainerItem1.ImageOptions.Image"));
			this.BarLinkContainerItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {new DevExpress.XtraBars.LinkPersistInfo(this.btnClassificationProducts), new DevExpress.XtraBars.LinkPersistInfo(this.btnResearchDirection), new DevExpress.XtraBars.LinkPersistInfo(this.btnResearchObjects), new DevExpress.XtraBars.LinkPersistInfo(this.btnCountryAgreements), new DevExpress.XtraBars.LinkPersistInfo(this.btnOrganizationStructure)});
			this.BarLinkContainerItem1.Name = "BarLinkContainerItem1";
			this.BarLinkContainerItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			//
			//btnClassificationProducts
			//
			this.btnClassificationProducts.Caption = "Классификация продукции";
			this.btnClassificationProducts.Id = 17;
			this.btnClassificationProducts.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnClassificationProducts.ImageOptions.Image"));
			this.btnClassificationProducts.Name = "btnClassificationProducts";
			//
			//btnResearchDirection
			//
			this.btnResearchDirection.Caption = "Направление исследований";
			this.btnResearchDirection.Id = 18;
			this.btnResearchDirection.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnResearchDirection.ImageOptions.Image"));
			this.btnResearchDirection.Name = "btnResearchDirection";
			//
			//btnResearchObjects
			//
			this.btnResearchObjects.Caption = "Объекты исследований";
			this.btnResearchObjects.Id = 19;
			this.btnResearchObjects.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnResearchObjects.ImageOptions.Image"));
			this.btnResearchObjects.Name = "btnResearchObjects";
			//
			//btnOrganizationStructure
			//
			this.btnOrganizationStructure.Caption = "Структура учреждения";
			this.btnOrganizationStructure.Id = 9;
			this.btnOrganizationStructure.ImageOptions.ImageIndex = 7;
			this.btnOrganizationStructure.Name = "btnOrganizationStructure";
			//
			//btnCountryAgreements
			//
			this.btnCountryAgreements.Caption = "Страны и соглашения";
			this.btnCountryAgreements.Id = 20;
			this.btnCountryAgreements.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnCountryAgreements.ImageOptions.Image"));
			this.btnCountryAgreements.Name = "btnCountryAgreements";
			//
			//btnServises
			//
			this.btnServises.Caption = "Сервис";
			this.btnServises.Id = 0;
			this.btnServises.ImageOptions.ImageIndex = 6;
			this.btnServises.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {new DevExpress.XtraBars.LinkPersistInfo(this.btnSecurityUsers), new DevExpress.XtraBars.LinkPersistInfo(this.btnChangeSkin)});
			this.btnServises.Name = "btnServises";
			this.btnServises.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			//
			//btnSecurityUsers
			//
			this.btnSecurityUsers.Caption = "Исполнители и безопасность";
			this.btnSecurityUsers.Id = 1;
			this.btnSecurityUsers.ImageOptions.ImageIndex = 5;
			this.btnSecurityUsers.Name = "btnSecurityUsers";
			//
			//btnChangeSkin
			//
			this.btnChangeSkin.Caption = "Сменить оформление";
			this.btnChangeSkin.Id = 16;
			this.btnChangeSkin.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnChangeSkin.ImageOptions.Image"));
			this.btnChangeSkin.Name = "btnChangeSkin";
			//
			//barStatusBar
			//
			this.barStatusBar.BarName = "Строка состояния";
			this.barStatusBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
			this.barStatusBar.DockCol = 0;
			this.barStatusBar.DockRow = 0;
			this.barStatusBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
			this.barStatusBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {new DevExpress.XtraBars.LinkPersistInfo(this.lbDivisionName), new DevExpress.XtraBars.LinkPersistInfo(this.lbServerName), new DevExpress.XtraBars.LinkPersistInfo(this.lbDataBaseName), new DevExpress.XtraBars.LinkPersistInfo(this.lbUserName), new DevExpress.XtraBars.LinkPersistInfo(this.lbDateTime)});
			this.barStatusBar.OptionsBar.AllowQuickCustomization = false;
			this.barStatusBar.OptionsBar.DrawBorder = false;
			this.barStatusBar.OptionsBar.DrawDragBorder = false;
			this.barStatusBar.OptionsBar.UseWholeRow = true;
			this.barStatusBar.Text = "Строка состояния";
			//
			//lbDivisionName
			//
			this.lbDivisionName.Caption = "Новороссийский филиал";
			this.lbDivisionName.Id = 3;
			this.lbDivisionName.ImageOptions.ImageIndex = 0;
			this.lbDivisionName.Name = "lbDivisionName";
			this.lbDivisionName.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			//
			//lbServerName
			//
			this.lbServerName.Caption = "LOBIN_MAX";
			this.lbServerName.Id = 5;
			this.lbServerName.ImageOptions.ImageIndex = 2;
			this.lbServerName.Name = "lbServerName";
			this.lbServerName.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			//
			//lbDataBaseName
			//
			this.lbDataBaseName.Caption = "fgNovorossiysk";
			this.lbDataBaseName.Id = 4;
			this.lbDataBaseName.ImageOptions.ImageIndex = 1;
			this.lbDataBaseName.Name = "lbDataBaseName";
			this.lbDataBaseName.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			//
			//lbUserName
			//
			this.lbUserName.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring;
			this.lbUserName.Caption = "Лобин М.А.";
			this.lbUserName.Id = 6;
			this.lbUserName.ImageOptions.ImageIndex = 3;
			this.lbUserName.Name = "lbUserName";
			this.lbUserName.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			//
			//lbDateTime
			//
			this.lbDateTime.Caption = "01.01.2019 15:15:00";
			this.lbDateTime.Id = 7;
			this.lbDateTime.ImageOptions.ImageIndex = 4;
			this.lbDateTime.Name = "lbDateTime";
			this.lbDateTime.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			//
			//barDockControlTop
			//
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
			this.barDockControlTop.Manager = this.BarManager;
			this.barDockControlTop.Size = new System.Drawing.Size(742, 24);
			//
			//barDockControlBottom
			//
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 478);
			this.barDockControlBottom.Manager = this.BarManager;
			this.barDockControlBottom.Size = new System.Drawing.Size(742, 27);
			//
			//barDockControlLeft
			//
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
			this.barDockControlLeft.Manager = this.BarManager;
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 454);
			//
			//barDockControlRight
			//
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(742, 24);
			this.barDockControlRight.Manager = this.BarManager;
			this.barDockControlRight.Size = new System.Drawing.Size(0, 454);
			//
			//ImageCollection
			//
			this.ImageCollection.ImageStream = (DevExpress.Utils.ImageCollectionStreamer) (resources.GetObject("ImageCollection.ImageStream"));
			this.ImageCollection.Images.SetKeyName(0, "capofgrane.png");
			this.ImageCollection.InsertGalleryImage("database_16x16.png", "images/data/database_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/data/database_16x16.png"), 1);
			this.ImageCollection.Images.SetKeyName(1, "database_16x16.png");
			this.ImageCollection.Images.SetKeyName(2, "IP_16x16.png");
			this.ImageCollection.InsertGalleryImage("user_16x16.png", "images/people/user_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/people/user_16x16.png"), 3);
			this.ImageCollection.Images.SetKeyName(3, "user_16x16.png");
			this.ImageCollection.InsertGalleryImage("showworktimeonly_16x16.png", "office2013/scheduling/showworktimeonly_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/scheduling/showworktimeonly_16x16.png"), 4);
			this.ImageCollection.Images.SetKeyName(4, "showworktimeonly_16x16.png");
			this.ImageCollection.InsertGalleryImage("editrangepermission_16x16.png", "images/richedit/editrangepermission_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/richedit/editrangepermission_16x16.png"), 5);
			this.ImageCollection.Images.SetKeyName(5, "editrangepermission_16x16.png");
			this.ImageCollection.InsertGalleryImage("viewsetting_16x16.png", "devav/actions/viewsetting_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("devav/actions/viewsetting_16x16.png"), 6);
			this.ImageCollection.Images.SetKeyName(6, "viewsetting_16x16.png");
			this.ImageCollection.Images.SetKeyName(7, "company.png");
			//
			//BarStaticItem2
			//
			this.BarStaticItem2.Caption = "BarStaticItem2";
			this.BarStaticItem2.Id = 8;
			this.BarStaticItem2.Name = "BarStaticItem2";
			//
			//BarButtonItem1
			//
			this.BarButtonItem1.Caption = "BarButtonItem1";
			this.BarButtonItem1.Id = 10;
			this.BarButtonItem1.Name = "BarButtonItem1";
			//
			//BarButtonItem2
			//
			this.BarButtonItem2.Caption = "BarButtonItem2";
			this.BarButtonItem2.Id = 11;
			this.BarButtonItem2.Name = "BarButtonItem2";
			//
			//SkinBarSubItem1
			//
			this.SkinBarSubItem1.Caption = "SkinBarSubItem1";
			this.SkinBarSubItem1.Id = 12;
			this.SkinBarSubItem1.Name = "SkinBarSubItem1";
			//
			//BarToolbarsListItem1
			//
			this.BarToolbarsListItem1.Caption = "BarToolbarsListItem1";
			this.BarToolbarsListItem1.Id = 13;
			this.BarToolbarsListItem1.Name = "BarToolbarsListItem1";
			//
			//SkinBarSubItem2
			//
			this.SkinBarSubItem2.Caption = "SkinBarSubItem2";
			this.SkinBarSubItem2.Id = 14;
			this.SkinBarSubItem2.Name = "SkinBarSubItem2";
			//
			//BarEditItem1
			//
			this.BarEditItem1.Caption = "BarEditItem1";
			this.BarEditItem1.Edit = this.RepositoryItemTextEdit1;
			this.BarEditItem1.Id = 15;
			this.BarEditItem1.Name = "BarEditItem1";
			//
			//RepositoryItemTextEdit1
			//
			this.RepositoryItemTextEdit1.AutoHeight = false;
			this.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1";
			//
			//ptbFone
			//
			this.ptbFone.Cursor = System.Windows.Forms.Cursors.Default;
			this.ptbFone.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ptbFone.EditValue = resources.GetObject("ptbFone.EditValue");
			this.ptbFone.Location = new System.Drawing.Point(0, 24);
			this.ptbFone.MenuManager = this.BarManager;
			this.ptbFone.Name = "ptbFone";
			this.ptbFone.Properties.AllowFocused = false;
			this.ptbFone.Properties.ReadOnly = true;
			this.ptbFone.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
			this.ptbFone.Properties.ShowMenu = false;
			this.ptbFone.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
			this.ptbFone.Size = new System.Drawing.Size(742, 454);
			this.ptbFone.TabIndex = 4;
			//
			//ptbGerb
			//
			this.ptbGerb.Cursor = System.Windows.Forms.Cursors.Default;
			this.ptbGerb.EditValue = resources.GetObject("ptbGerb.EditValue");
			this.ptbGerb.Location = new System.Drawing.Point(600, 12);
			this.ptbGerb.MenuManager = this.BarManager;
			this.ptbGerb.Name = "ptbGerb";
			this.ptbGerb.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.ptbGerb.Properties.Appearance.Options.UseBackColor = true;
			this.ptbGerb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.ptbGerb.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
			this.ptbGerb.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
			this.ptbGerb.Size = new System.Drawing.Size(130, 130);
			this.ptbGerb.TabIndex = 9;
			//
			//tmrDateTime
			//
			this.tmrDateTime.Enabled = true;
			//
			//frMain
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(742, 505);
			this.Controls.Add(this.ptbGerb);
			this.Controls.Add(this.ptbFone);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frMain";
			((System.ComponentModel.ISupportInitialize) this.BarManager).EndInit();
			((System.ComponentModel.ISupportInitialize) this.ImageCollection).EndInit();
			((System.ComponentModel.ISupportInitialize) this.RepositoryItemTextEdit1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.ptbFone.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.ptbGerb.Properties).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		internal DevExpress.XtraBars.BarManager BarManager;
		internal DevExpress.XtraBars.Bar Bar2;
		internal DevExpress.XtraBars.Bar barStatusBar;
		internal DevExpress.XtraBars.BarDockControl barDockControlTop;
		internal DevExpress.XtraBars.BarDockControl barDockControlBottom;
		internal DevExpress.XtraBars.BarDockControl barDockControlLeft;
		internal DevExpress.XtraBars.BarDockControl barDockControlRight;
		internal DevExpress.XtraEditors.PictureEdit ptbFone;
		internal DevExpress.XtraBars.BarLinkContainerItem btnServises;
		internal DevExpress.XtraBars.BarButtonItem btnSecurityUsers;
		internal DevExpress.XtraBars.BarLinkContainerItem BarLinkContainerItem1;
		internal DevExpress.XtraEditors.PictureEdit ptbGerb;
		internal DevExpress.XtraBars.BarStaticItem lbDivisionName;
		internal DevExpress.Utils.ImageCollection ImageCollection;
		internal DevExpress.XtraBars.BarStaticItem lbDataBaseName;
		internal DevExpress.XtraBars.BarStaticItem lbServerName;
		internal DevExpress.XtraBars.BarStaticItem lbUserName;
		internal DevExpress.XtraBars.BarStaticItem lbDateTime;
		internal DevExpress.XtraBars.BarStaticItem BarStaticItem2;
		internal System.Windows.Forms.Timer tmrDateTime;
		internal DevExpress.XtraBars.BarButtonItem btnOrganizationStructure;
		internal DevExpress.XtraBars.BarButtonItem BarButtonItem1;
		internal DevExpress.XtraBars.BarButtonItem BarButtonItem2;
		internal DevExpress.XtraBars.SkinBarSubItem SkinBarSubItem1;
		internal DevExpress.XtraBars.SkinBarSubItem btnChangeSkin;
		internal DevExpress.XtraBars.BarToolbarsListItem BarToolbarsListItem1;
		internal DevExpress.XtraBars.SkinBarSubItem SkinBarSubItem2;
		internal DevExpress.XtraBars.BarEditItem BarEditItem1;
		internal DevExpress.XtraEditors.Repository.RepositoryItemTextEdit RepositoryItemTextEdit1;
		internal DevExpress.XtraBars.BarButtonItem btnClassificationProducts;
		internal DevExpress.XtraBars.BarButtonItem btnResearchDirection;
		internal DevExpress.XtraBars.BarButtonItem btnResearchObjects;
		internal DevExpress.XtraBars.BarButtonItem btnCountryAgreements;
	}
	
}
