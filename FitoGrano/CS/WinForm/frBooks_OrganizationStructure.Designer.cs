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
		public partial class frBooks_OrganizationStructure : DevExpress.XtraEditors.XtraForm
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
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(frOrganizationStructure_FormClosing);
			base.Load += new System.EventHandler(frOrganizationStructure_Load);
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frBooks_OrganizationStructure));
			this.PanelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.PictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
			this.tlStructure = new DevExpress.XtraTreeList.TreeList();
			this.tlStructure.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tlStructure_MouseClick);
			this.tlStructure.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.tlStructure_FocusedNodeChanged);
			this.tlStructure.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tlStructure_KeyUp);
			this.tlStructure.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tlStructure_KeyDown);
			this.tlStructure.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tlStructure_MouseDoubleClick);
			this.PanelControl2 = new DevExpress.XtraEditors.PanelControl();
			this.lbAddressOrganization = new DevExpress.XtraEditors.LabelControl();
			this.lbPhoneOrganization = new DevExpress.XtraEditors.LabelControl();
			this.lbEmailOrganization = new DevExpress.XtraEditors.LabelControl();
			this.lbManagerOrganization = new DevExpress.XtraEditors.LabelControl();
			this.SeparatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
			this.PopupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
			this.btnAddMenu = new DevExpress.XtraBars.BarSubItem();
			this.btnAddFilial = new DevExpress.XtraBars.BarButtonItem();
			this.btnAddFilial.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddFilial_ItemClick);
			this.btnAddGroup = new DevExpress.XtraBars.BarButtonItem();
			this.btnAddGroup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddGroup_ItemClick);
			this.btnAddRoleJob = new DevExpress.XtraBars.BarButtonItem();
			this.btnAddRoleJob.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddRoleJob_ItemClick);
			this.btnEditRecord = new DevExpress.XtraBars.BarButtonItem();
			this.btnEditRecord.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditRecord_ItemClick);
			this.btnDeleteRecord = new DevExpress.XtraBars.BarButtonItem();
			this.btnDeleteRecord.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDeleteRecord_ItemClick);
			this.btnCollapsedAll = new DevExpress.XtraBars.BarButtonItem();
			this.btnCollapsedAll.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCollapsedAll_ItemClick);
			this.btnExpandedAll = new DevExpress.XtraBars.BarButtonItem();
			this.btnExpandedAll.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExpandedAll_ItemClick);
			this.btnUpdate = new DevExpress.XtraBars.BarButtonItem();
			this.btnUpdate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUpdate_ItemClick);
			this.btnSetCurrentFilial = new DevExpress.XtraBars.BarButtonItem();
			this.btnSetCurrentFilial.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSetCurrentFilial_ItemClick);
			this.BarManager = new DevExpress.XtraBars.BarManager(this.components);
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			this.btnOk = new DevExpress.XtraEditors.SimpleButton();
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			this.tmUpdateForm = new System.Windows.Forms.Timer(this.components);
			this.tmUpdateForm.Tick += new System.EventHandler(this.tmUpdateForm_Tick);
			((System.ComponentModel.ISupportInitialize) this.PanelControl1).BeginInit();
			this.PanelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.PictureEdit1.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.tlStructure).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.PanelControl2).BeginInit();
			this.PanelControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.SeparatorControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.PopupMenu).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.BarManager).BeginInit();
			this.SuspendLayout();
			//
			//PanelControl1
			//
			this.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.PanelControl1.Controls.Add(this.LabelControl1);
			this.PanelControl1.Controls.Add(this.PictureEdit1);
			this.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.PanelControl1.Location = new System.Drawing.Point(0, 0);
			this.PanelControl1.Name = "PanelControl1";
			this.PanelControl1.Size = new System.Drawing.Size(663, 100);
			this.PanelControl1.TabIndex = 0;
			//
			//LabelControl1
			//
			this.LabelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (14.0F));
			this.LabelControl1.Appearance.Options.UseFont = true;
			this.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.LabelControl1.Location = new System.Drawing.Point(95, 17);
			this.LabelControl1.Name = "LabelControl1";
			this.LabelControl1.Size = new System.Drawing.Size(560, 59);
			this.LabelControl1.TabIndex = 1;
			this.LabelControl1.Text = "Структура предприятия ФГБУ" + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(13)) + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(10)) + "«Федеральный центр оценки безопасности и качества зер" +
				"на»";
			//
			//PictureEdit1
			//
			this.PictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
			this.PictureEdit1.Dock = System.Windows.Forms.DockStyle.Left;
			this.PictureEdit1.EditValue = resources.GetObject("PictureEdit1.EditValue");
			this.PictureEdit1.Location = new System.Drawing.Point(2, 2);
			this.PictureEdit1.Name = "PictureEdit1";
			this.PictureEdit1.Properties.AllowFocused = false;
			this.PictureEdit1.Properties.AllowZoomOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
			this.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.PictureEdit1.Properties.Appearance.Options.UseBackColor = true;
			this.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.PictureEdit1.Properties.ReadOnly = true;
			this.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
			this.PictureEdit1.Properties.ShowMenu = false;
			this.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
			this.PictureEdit1.Size = new System.Drawing.Size(100, 96);
			this.PictureEdit1.TabIndex = 0;
			//
			//tlStructure
			//
			this.tlStructure.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.tlStructure.Dock = System.Windows.Forms.DockStyle.Top;
			this.tlStructure.Location = new System.Drawing.Point(0, 100);
			this.tlStructure.Name = "tlStructure";
			this.tlStructure.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
			this.tlStructure.OptionsBehavior.Editable = false;
			this.tlStructure.OptionsBehavior.ResizeNodes = false;
			this.tlStructure.OptionsClipboard.AllowHtmlFormat = DevExpress.Utils.DefaultBoolean.True;
			this.tlStructure.OptionsCustomization.AllowBandMoving = false;
			this.tlStructure.OptionsCustomization.AllowBandResizing = false;
			this.tlStructure.OptionsCustomization.AllowColumnMoving = false;
			this.tlStructure.OptionsCustomization.AllowColumnResizing = false;
			this.tlStructure.OptionsCustomization.AllowFilter = false;
			this.tlStructure.OptionsCustomization.AllowSort = false;
			this.tlStructure.OptionsFilter.AllowFilterEditor = false;
			this.tlStructure.OptionsMenu.EnableColumnMenu = false;
			this.tlStructure.OptionsMenu.EnableFooterMenu = false;
			this.tlStructure.OptionsNavigation.AutoFocusNewNode = true;
			this.tlStructure.OptionsNavigation.MoveOnEdit = false;
			this.tlStructure.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.tlStructure.OptionsSelection.SelectNodesOnRightClick = true;
			this.tlStructure.OptionsView.ShowColumns = false;
			this.tlStructure.OptionsView.ShowIndicator = false;
			this.tlStructure.Size = new System.Drawing.Size(663, 343);
			this.tlStructure.TabIndex = 1;
			//
			//PanelControl2
			//
			this.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.PanelControl2.Controls.Add(this.lbAddressOrganization);
			this.PanelControl2.Controls.Add(this.lbPhoneOrganization);
			this.PanelControl2.Controls.Add(this.lbEmailOrganization);
			this.PanelControl2.Controls.Add(this.lbManagerOrganization);
			this.PanelControl2.Controls.Add(this.SeparatorControl1);
			this.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top;
			this.PanelControl2.Location = new System.Drawing.Point(0, 443);
			this.PanelControl2.Name = "PanelControl2";
			this.PanelControl2.Size = new System.Drawing.Size(663, 87);
			this.PanelControl2.TabIndex = 2;
			//
			//lbAddressOrganization
			//
			this.lbAddressOrganization.AllowHtmlString = true;
			this.lbAddressOrganization.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.lbAddressOrganization.Location = new System.Drawing.Point(12, 61);
			this.lbAddressOrganization.Name = "lbAddressOrganization";
			this.lbAddressOrganization.Size = new System.Drawing.Size(651, 13);
			this.lbAddressOrganization.TabIndex = 3;
			this.lbAddressOrganization.Text = "Юридический адрес:";
			//
			//lbPhoneOrganization
			//
			this.lbPhoneOrganization.AllowHtmlString = true;
			this.lbPhoneOrganization.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.lbPhoneOrganization.Location = new System.Drawing.Point(314, 42);
			this.lbPhoneOrganization.Name = "lbPhoneOrganization";
			this.lbPhoneOrganization.Size = new System.Drawing.Size(349, 13);
			this.lbPhoneOrganization.TabIndex = 2;
			this.lbPhoneOrganization.Text = "Контакты:";
			//
			//lbEmailOrganization
			//
			this.lbEmailOrganization.AllowHtmlString = true;
			this.lbEmailOrganization.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.lbEmailOrganization.Location = new System.Drawing.Point(12, 42);
			this.lbEmailOrganization.Name = "lbEmailOrganization";
			this.lbEmailOrganization.Size = new System.Drawing.Size(296, 13);
			this.lbEmailOrganization.TabIndex = 1;
			this.lbEmailOrganization.Text = "Email:";
			//
			//lbManagerOrganization
			//
			this.lbManagerOrganization.AllowHtmlString = true;
			this.lbManagerOrganization.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.lbManagerOrganization.Location = new System.Drawing.Point(12, 12);
			this.lbManagerOrganization.Name = "lbManagerOrganization";
			this.lbManagerOrganization.Size = new System.Drawing.Size(651, 13);
			this.lbManagerOrganization.TabIndex = 0;
			this.lbManagerOrganization.Text = "ФИО руководителя:";
			//
			//SeparatorControl1
			//
			this.SeparatorControl1.Location = new System.Drawing.Point(12, 21);
			this.SeparatorControl1.Name = "SeparatorControl1";
			this.SeparatorControl1.Size = new System.Drawing.Size(646, 23);
			this.SeparatorControl1.TabIndex = 51;
			//
			//PopupMenu
			//
			this.PopupMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {new DevExpress.XtraBars.LinkPersistInfo(this.btnAddMenu), new DevExpress.XtraBars.LinkPersistInfo(this.btnEditRecord), new DevExpress.XtraBars.LinkPersistInfo(this.btnDeleteRecord), new DevExpress.XtraBars.LinkPersistInfo(this.btnCollapsedAll, true), new DevExpress.XtraBars.LinkPersistInfo(this.btnExpandedAll), new DevExpress.XtraBars.LinkPersistInfo(this.btnUpdate), new DevExpress.XtraBars.LinkPersistInfo(this.btnSetCurrentFilial, true)});
			this.PopupMenu.Manager = this.BarManager;
			this.PopupMenu.Name = "PopupMenu";
			//
			//btnAddMenu
			//
			this.btnAddMenu.Caption = "Добавить ...";
			this.btnAddMenu.Id = 2;
			this.btnAddMenu.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnAddMenu.ImageOptions.Image"));
			this.btnAddMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {new DevExpress.XtraBars.LinkPersistInfo(this.btnAddFilial), new DevExpress.XtraBars.LinkPersistInfo(this.btnAddGroup), new DevExpress.XtraBars.LinkPersistInfo(this.btnAddRoleJob)});
			this.btnAddMenu.Name = "btnAddMenu";
			//
			//btnAddFilial
			//
			this.btnAddFilial.Caption = "Добавить филиал";
			this.btnAddFilial.Id = 3;
			this.btnAddFilial.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnAddFilial.ImageOptions.Image"));
			this.btnAddFilial.Name = "btnAddFilial";
			//
			//btnAddGroup
			//
			this.btnAddGroup.Caption = "Добавить группу";
			this.btnAddGroup.Id = 4;
			this.btnAddGroup.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnAddGroup.ImageOptions.Image"));
			this.btnAddGroup.ImageOptions.LargeImage = (System.Drawing.Image) (resources.GetObject("btnAddGroup.ImageOptions.LargeImage"));
			this.btnAddGroup.Name = "btnAddGroup";
			//
			//btnAddRoleJob
			//
			this.btnAddRoleJob.Caption = "Добавить должность";
			this.btnAddRoleJob.Id = 5;
			this.btnAddRoleJob.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnAddRoleJob.ImageOptions.Image"));
			this.btnAddRoleJob.Name = "btnAddRoleJob";
			//
			//btnEditRecord
			//
			this.btnEditRecord.Caption = "Изменить";
			this.btnEditRecord.Id = 0;
			this.btnEditRecord.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnEditRecord.ImageOptions.Image"));
			this.btnEditRecord.Name = "btnEditRecord";
			//
			//btnDeleteRecord
			//
			this.btnDeleteRecord.Caption = "Удалить";
			this.btnDeleteRecord.Id = 6;
			this.btnDeleteRecord.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnDeleteRecord.ImageOptions.Image"));
			this.btnDeleteRecord.Name = "btnDeleteRecord";
			//
			//btnCollapsedAll
			//
			this.btnCollapsedAll.Caption = "Свернуть все";
			this.btnCollapsedAll.Id = 8;
			this.btnCollapsedAll.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnCollapsedAll.ImageOptions.Image"));
			this.btnCollapsedAll.Name = "btnCollapsedAll";
			//
			//btnExpandedAll
			//
			this.btnExpandedAll.Caption = "Развернуть все";
			this.btnExpandedAll.Id = 9;
			this.btnExpandedAll.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnExpandedAll.ImageOptions.Image"));
			this.btnExpandedAll.Name = "btnExpandedAll";
			//
			//btnUpdate
			//
			this.btnUpdate.Caption = "Обновить";
			this.btnUpdate.Id = 11;
			this.btnUpdate.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnUpdate.ImageOptions.Image"));
			this.btnUpdate.Name = "btnUpdate";
			//
			//btnSetCurrentFilial
			//
			this.btnSetCurrentFilial.Caption = "Назначить филиал текущим";
			this.btnSetCurrentFilial.Id = 10;
			this.btnSetCurrentFilial.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnSetCurrentFilial.ImageOptions.Image"));
			this.btnSetCurrentFilial.Name = "btnSetCurrentFilial";
			//
			//BarManager
			//
			this.BarManager.DockControls.Add(this.barDockControlTop);
			this.BarManager.DockControls.Add(this.barDockControlBottom);
			this.BarManager.DockControls.Add(this.barDockControlLeft);
			this.BarManager.DockControls.Add(this.barDockControlRight);
			this.BarManager.Form = this;
			this.BarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {this.btnEditRecord, this.btnAddMenu, this.btnAddFilial, this.btnAddGroup, this.btnAddRoleJob, this.btnDeleteRecord, this.btnCollapsedAll, this.btnExpandedAll, this.btnSetCurrentFilial, this.btnUpdate});
			this.BarManager.MaxItemId = 12;
			//
			//barDockControlTop
			//
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
			this.barDockControlTop.Manager = this.BarManager;
			this.barDockControlTop.Size = new System.Drawing.Size(663, 0);
			//
			//barDockControlBottom
			//
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 589);
			this.barDockControlBottom.Manager = this.BarManager;
			this.barDockControlBottom.Size = new System.Drawing.Size(663, 0);
			//
			//barDockControlLeft
			//
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
			this.barDockControlLeft.Manager = this.BarManager;
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 589);
			//
			//barDockControlRight
			//
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(663, 0);
			this.barDockControlRight.Manager = this.BarManager;
			this.barDockControlRight.Size = new System.Drawing.Size(0, 589);
			//
			//btnCancel
			//
			this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			this.btnCancel.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnCancel.ImageOptions.Image"));
			this.btnCancel.Location = new System.Drawing.Point(572, 551);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
			this.btnCancel.Size = new System.Drawing.Size(77, 26);
			this.btnCancel.TabIndex = 46;
			this.btnCancel.Tag = "0";
			this.btnCancel.Text = "Отмена";
			//
			//btnOk
			//
			this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			this.btnOk.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnOk.ImageOptions.Image"));
			this.btnOk.ImageOptions.ImageIndex = 0;
			this.btnOk.Location = new System.Drawing.Point(489, 551);
			this.btnOk.Name = "btnOk";
			this.btnOk.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
			this.btnOk.Size = new System.Drawing.Size(77, 26);
			this.btnOk.TabIndex = 45;
			this.btnOk.Tag = "11";
			this.btnOk.Text = "OK";
			//
			//tmUpdateForm
			//
			this.tmUpdateForm.Enabled = true;
			this.tmUpdateForm.Interval = 60000;
			//
			//frOrganizationStructure
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(663, 589);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.PanelControl2);
			this.Controls.Add(this.tlStructure);
			this.Controls.Add(this.PanelControl1);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximizeBox = false;
			this.Name = "frOrganizationStructure";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Структура предприятия";
			((System.ComponentModel.ISupportInitialize) this.PanelControl1).EndInit();
			this.PanelControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.PictureEdit1.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.tlStructure).EndInit();
			((System.ComponentModel.ISupportInitialize) this.PanelControl2).EndInit();
			this.PanelControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.SeparatorControl1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.PopupMenu).EndInit();
			((System.ComponentModel.ISupportInitialize) this.BarManager).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		internal DevExpress.XtraEditors.PanelControl PanelControl1;
		internal DevExpress.XtraEditors.PictureEdit PictureEdit1;
		internal DevExpress.XtraEditors.LabelControl LabelControl1;
		internal DevExpress.XtraTreeList.TreeList tlStructure;
		internal DevExpress.XtraEditors.PanelControl PanelControl2;
		internal DevExpress.XtraEditors.LabelControl lbAddressOrganization;
		internal DevExpress.XtraEditors.LabelControl lbPhoneOrganization;
		internal DevExpress.XtraEditors.LabelControl lbEmailOrganization;
		internal DevExpress.XtraEditors.LabelControl lbManagerOrganization;
		internal DevExpress.XtraBars.PopupMenu PopupMenu;
		internal DevExpress.XtraBars.BarManager BarManager;
		internal DevExpress.XtraBars.BarDockControl barDockControlTop;
		internal DevExpress.XtraBars.BarDockControl barDockControlBottom;
		internal DevExpress.XtraBars.BarDockControl barDockControlLeft;
		internal DevExpress.XtraBars.BarDockControl barDockControlRight;
		internal DevExpress.XtraBars.BarButtonItem btnEditRecord;
		internal DevExpress.XtraBars.BarSubItem btnAddMenu;
		internal DevExpress.XtraBars.BarButtonItem btnAddFilial;
		internal DevExpress.XtraBars.BarButtonItem btnAddGroup;
		internal DevExpress.XtraBars.BarButtonItem btnAddRoleJob;
		internal DevExpress.XtraBars.BarButtonItem btnDeleteRecord;
		internal DevExpress.XtraEditors.SimpleButton btnCancel;
		internal DevExpress.XtraEditors.SimpleButton btnOk;
		internal DevExpress.XtraBars.BarButtonItem btnCollapsedAll;
		internal DevExpress.XtraBars.BarButtonItem btnExpandedAll;
		internal DevExpress.XtraBars.BarButtonItem btnSetCurrentFilial;
		internal DevExpress.XtraBars.BarButtonItem btnUpdate;
		internal DevExpress.XtraEditors.SeparatorControl SeparatorControl1;
		internal Timer tmUpdateForm;
	}
	
}
