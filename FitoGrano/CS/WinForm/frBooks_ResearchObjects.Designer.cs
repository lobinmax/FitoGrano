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
		public partial class frBooks_ResearchObjects : DevExpress.XtraEditors.XtraForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frBooks_ResearchObjects));
			DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions ButtonImageOptions1 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
			DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions ButtonImageOptions2 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
			DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions ButtonImageOptions3 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
			DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions ButtonImageOptions4 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
			DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions ButtonImageOptions5 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
			DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions ButtonImageOptions6 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
			DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions ButtonImageOptions7 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
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
			this.BarStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
			this.BarStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
			this.btnAddObject = new DevExpress.XtraBars.BarButtonItem();
			this.btnAddObject.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddObject_ItemClick);
			this.btnEditObject = new DevExpress.XtraBars.BarButtonItem();
			this.btnEditObject.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditObject_ItemClick);
			this.btnDelObject = new DevExpress.XtraBars.BarButtonItem();
			this.btnDelObject.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelObject_ItemClick);
			this.tmChecked = new System.Windows.Forms.Timer(this.components);
			this.tmChecked.Tick += new System.EventHandler(this.tmChecked_Tick);
			this.gcnObjects = new DevExpress.XtraEditors.GroupControl();
			this.gcnObjects.CustomButtonClick += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.gcnObjects_CustomButtonClick);
			this.gcnObjects.CustomButtonChecked += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.gcnMethods_CustomButtonChecked);
			this.gcnObjects.CustomButtonUnchecked += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.gcnMethods_CustomButtonChecked);
			this.gcObjects = new DevExpress.XtraGrid.GridControl();
			this.gvObjects = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gvObjects.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvObjects_KeyDown);
			this.gvObjects.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gvObjects_MouseDown);
			this.gvObjects.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvObjects_FocusedRowChanged);
			this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.Accord = new DevExpress.XtraBars.Navigation.AccordionControl();
			this.Accord.SelectedElementChanged += new DevExpress.XtraBars.Navigation.SelectedElementChangedEventHandler(this.Accord_SelectedElementChanged);
			this.acRoot = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.SplitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
			this.pmObjects = new DevExpress.XtraBars.PopupMenu(this.components);
			((System.ComponentModel.ISupportInitialize) this.BarManager1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.gcnObjects).BeginInit();
			this.gcnObjects.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.gcObjects).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.gvObjects).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.Accord).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.SplitContainerControl1).BeginInit();
			this.SplitContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.pmObjects).BeginInit();
			this.SuspendLayout();
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
			this.BarManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {this.lbServerName, this.lbDB_name, this.btnUpdate, this.BarStaticItem1, this.BarStaticItem2, this.btnAddObject, this.btnEditObject, this.btnDelObject});
			this.BarManager1.MaxItemId = 22;
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
			this.barDockControlTop.Size = new System.Drawing.Size(825, 29);
			//
			//barDockControlBottom
			//
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 413);
			this.barDockControlBottom.Manager = this.BarManager1;
			this.barDockControlBottom.Size = new System.Drawing.Size(825, 27);
			//
			//barDockControlLeft
			//
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 29);
			this.barDockControlLeft.Manager = this.BarManager1;
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 384);
			//
			//barDockControlRight
			//
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(825, 29);
			this.barDockControlRight.Manager = this.BarManager1;
			this.barDockControlRight.Size = new System.Drawing.Size(0, 384);
			//
			//BarStaticItem1
			//
			this.BarStaticItem1.Id = 17;
			this.BarStaticItem1.Name = "BarStaticItem1";
			//
			//BarStaticItem2
			//
			this.BarStaticItem2.Id = 18;
			this.BarStaticItem2.Name = "BarStaticItem2";
			//
			//btnAddObject
			//
			this.btnAddObject.Caption = "Добавить";
			this.btnAddObject.Id = 19;
			this.btnAddObject.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnAddObject.ImageOptions.Image"));
			this.btnAddObject.Name = "btnAddObject";
			//
			//btnEditObject
			//
			this.btnEditObject.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
			this.btnEditObject.Caption = "Изменить          <i>Enter</i>";
			this.btnEditObject.Id = 20;
			this.btnEditObject.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnEditObject.ImageOptions.Image"));
			this.btnEditObject.Name = "btnEditObject";
			//
			//btnDelObject
			//
			this.btnDelObject.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
			this.btnDelObject.Caption = "Удалить             <i>Delete</i>";
			this.btnDelObject.Id = 21;
			this.btnDelObject.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnDelObject.ImageOptions.Image"));
			this.btnDelObject.Name = "btnDelObject";
			//
			//tmChecked
			//
			this.tmChecked.Enabled = true;
			//
			//gcnObjects
			//
			this.gcnObjects.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (8.0F));
			this.gcnObjects.Appearance.Options.UseFont = true;
			this.gcnObjects.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", (float) (9.0F), (System.Drawing.FontStyle) ((int) (System.Drawing.FontStyle.Bold) | (int) System.Drawing.FontStyle.Underline));
			this.gcnObjects.AppearanceCaption.Options.UseFont = true;
			this.gcnObjects.AppearanceCaption.Options.UseTextOptions = true;
			this.gcnObjects.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
			this.gcnObjects.Controls.Add(this.gcObjects);
			ButtonImageOptions1.Image = (System.Drawing.Image) (resources.GetObject("ButtonImageOptions1.Image"));
			ButtonImageOptions2.Image = (System.Drawing.Image) (resources.GetObject("ButtonImageOptions2.Image"));
			ButtonImageOptions3.Image = (System.Drawing.Image) (resources.GetObject("ButtonImageOptions3.Image"));
			ButtonImageOptions5.Image = (System.Drawing.Image) (resources.GetObject("ButtonImageOptions5.Image"));
			ButtonImageOptions6.Image = (System.Drawing.Image) (resources.GetObject("ButtonImageOptions6.Image"));
			ButtonImageOptions7.Image = (System.Drawing.Image) (resources.GetObject("ButtonImageOptions7.Image"));
			this.gcnObjects.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("btnAddObject", false, ButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Добавить", -1, true, null, true, false, true, null, 2), new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("btnEditObject", false, ButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Изменить", -1, true, null, true, false, true, null, 2), new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("btnDeleteObject", false, ButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Удалаить", -1, true, null, true, false, true, null, 2), new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("|", true, ButtonImageOptions4, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, false, null, true, false, true, null, -1), new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("btnSearch_Object", false, ButtonImageOptions5, DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, "Показать панель поиска", -1, true, null, true, false, true, null, 5), new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("btnAutoFilter_Object", false, ButtonImageOptions6, DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, "Показать строку автофильтра", -1, true, null, true, false, true, null, 6), new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("btnClearSort_Object", false, ButtonImageOptions7, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Очистить сортировку", -1, true, null, true, false, true, null, -1)});
			this.gcnObjects.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
			this.gcnObjects.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gcnObjects.Location = new System.Drawing.Point(0, 0);
			this.gcnObjects.Name = "gcnObjects";
			this.gcnObjects.Size = new System.Drawing.Size(632, 376);
			this.gcnObjects.TabIndex = 0;
			this.gcnObjects.Text = "Список объектов";
			//
			//gcObjects
			//
			this.gcObjects.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gcObjects.Location = new System.Drawing.Point(2, 29);
			this.gcObjects.MainView = this.gvObjects;
			this.gcObjects.Name = "gcObjects";
			this.gcObjects.Size = new System.Drawing.Size(628, 345);
			this.gcObjects.TabIndex = 0;
			this.gcObjects.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.gvObjects, this.GridView1});
			//
			//gvObjects
			//
			this.gvObjects.Appearance.HeaderPanel.Options.UseTextOptions = true;
			this.gvObjects.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gvObjects.Appearance.HeaderPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
			this.gvObjects.Appearance.Preview.Font = new System.Drawing.Font("Tahoma", (float) (8.25F), System.Drawing.FontStyle.Italic);
			this.gvObjects.Appearance.Preview.Options.UseFont = true;
			this.gvObjects.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.gvObjects.GridControl = this.gcObjects;
			this.gvObjects.Name = "gvObjects";
			this.gvObjects.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvObjects.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvObjects.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
			this.gvObjects.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
			this.gvObjects.OptionsBehavior.Editable = false;
			this.gvObjects.OptionsCustomization.AllowColumnMoving = false;
			this.gvObjects.OptionsCustomization.AllowGroup = false;
			this.gvObjects.OptionsDetail.EnableMasterViewMode = false;
			this.gvObjects.OptionsMenu.EnableColumnMenu = false;
			this.gvObjects.OptionsMenu.EnableFooterMenu = false;
			this.gvObjects.OptionsMenu.EnableGroupPanelMenu = false;
			this.gvObjects.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gvObjects.OptionsView.AllowHtmlDrawHeaders = true;
			this.gvObjects.OptionsView.AutoCalcPreviewLineCount = true;
			this.gvObjects.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
			this.gvObjects.OptionsView.ShowGroupPanel = false;
			this.gvObjects.OptionsView.ShowPreview = true;
			this.gvObjects.PreviewIndent = 3;
			//
			//GridView1
			//
			this.GridView1.GridControl = this.gcObjects;
			this.GridView1.Name = "GridView1";
			//
			//Accord
			//
			this.Accord.AllowItemSelection = true;
			this.Accord.AllowSmoothScrolling = false;
			this.Accord.AnimationType = DevExpress.XtraBars.Navigation.AnimationType.Spline;
			this.Accord.Appearance.Item.Pressed.Font = new System.Drawing.Font("Tahoma", (float) (8.25F), System.Drawing.FontStyle.Bold);
			this.Accord.Appearance.Item.Pressed.Options.UseFont = true;
			this.Accord.Cursor = System.Windows.Forms.Cursors.Default;
			this.Accord.DistanceBetweenRootGroups = 10;
			this.Accord.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Accord.ElementPositionOnExpanding = DevExpress.XtraBars.Navigation.ElementPositionOnExpanding.Fixed;
			this.Accord.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {this.acRoot});
			this.Accord.Location = new System.Drawing.Point(0, 0);
			this.Accord.Name = "Accord";
			this.Accord.ScaleImages = DevExpress.Utils.DefaultBoolean.False;
			this.Accord.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
			this.Accord.Size = new System.Drawing.Size(176, 358);
			this.Accord.TabIndex = 0;
			//
			//acRoot
			//
			this.acRoot.Expanded = true;
			this.acRoot.Height = -1;
			this.acRoot.Name = "acRoot";
			this.acRoot.Text = "Root";
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
			this.SplitContainerControl1.Panel1.Controls.Add(this.Accord);
			this.SplitContainerControl1.Panel1.MinSize = 30;
			this.SplitContainerControl1.Panel1.ShowCaption = true;
			this.SplitContainerControl1.Panel1.Text = "Виды объектов";
			this.SplitContainerControl1.Panel2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", (float) (8.25F), (System.Drawing.FontStyle) ((int) (System.Drawing.FontStyle.Bold) | (int) System.Drawing.FontStyle.Underline));
			this.SplitContainerControl1.Panel2.AppearanceCaption.Options.UseFont = true;
			this.SplitContainerControl1.Panel2.AppearanceCaption.Options.UseTextOptions = true;
			this.SplitContainerControl1.Panel2.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.SplitContainerControl1.Panel2.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
			this.SplitContainerControl1.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.SplitContainerControl1.Panel2.CaptionLocation = DevExpress.Utils.Locations.Top;
			this.SplitContainerControl1.Panel2.Controls.Add(this.gcnObjects);
			this.SplitContainerControl1.Panel2.Text = "Наименование";
			this.SplitContainerControl1.Size = new System.Drawing.Size(825, 384);
			this.SplitContainerControl1.SplitterPosition = 180;
			this.SplitContainerControl1.TabIndex = 4;
			//
			//pmObjects
			//
			this.pmObjects.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {new DevExpress.XtraBars.LinkPersistInfo(this.btnAddObject), new DevExpress.XtraBars.LinkPersistInfo(this.btnEditObject), new DevExpress.XtraBars.LinkPersistInfo(this.btnDelObject)});
			this.pmObjects.Manager = this.BarManager1;
			this.pmObjects.Name = "pmObjects";
			//
			//frBooks_ResearchObjects
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(825, 440);
			this.Controls.Add(this.SplitContainerControl1);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.Name = "frBooks_ResearchObjects";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Объекты исследований";
			((System.ComponentModel.ISupportInitialize) this.BarManager1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.gcnObjects).EndInit();
			this.gcnObjects.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.gcObjects).EndInit();
			((System.ComponentModel.ISupportInitialize) this.gvObjects).EndInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.Accord).EndInit();
			((System.ComponentModel.ISupportInitialize) this.SplitContainerControl1).EndInit();
			this.SplitContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.pmObjects).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		
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
		internal DevExpress.XtraBars.BarStaticItem BarStaticItem1;
		internal DevExpress.XtraBars.BarStaticItem BarStaticItem2;
		internal Timer tmChecked;
		internal DevExpress.XtraEditors.SplitContainerControl SplitContainerControl1;
		internal DevExpress.XtraBars.Navigation.AccordionControl Accord;
		internal DevExpress.XtraBars.Navigation.AccordionControlElement acRoot;
		internal DevExpress.XtraEditors.GroupControl gcnObjects;
		internal DevExpress.XtraGrid.GridControl gcObjects;
		internal DevExpress.XtraGrid.Views.Grid.GridView gvObjects;
		internal DevExpress.XtraGrid.Views.Grid.GridView GridView1;
		internal DevExpress.XtraBars.BarButtonItem btnAddObject;
		internal DevExpress.XtraBars.PopupMenu pmObjects;
		internal DevExpress.XtraBars.BarButtonItem btnEditObject;
		internal DevExpress.XtraBars.BarButtonItem btnDelObject;
	}
	
}
