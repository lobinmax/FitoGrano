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
		public partial class frAddEditPerformer : DevExpress.XtraEditors.XtraForm
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
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(frAddEditPerformer_FormClosing);
			base.Load += new System.EventHandler(frAddEditPerformer_Load);
			DevExpress.XtraEditors.Controls.EditorButtonImageOptions EditorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frAddEditPerformer));
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SimpleContextButton SimpleContextButton1 = new DevExpress.Utils.SimpleContextButton();
			DevExpress.Utils.SimpleContextButton SimpleContextButton2 = new DevExpress.Utils.SimpleContextButton();
			DevExpress.XtraEditors.Controls.EditorButtonImageOptions EditorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.XtraEditors.Controls.EditorButtonImageOptions EditorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions ButtonImageOptions1 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
			DevExpress.XtraEditors.Controls.EditorButtonImageOptions EditorButtonImageOptions4 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject13 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject14 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject15 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject16 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.XtraEditors.Controls.EditorButtonImageOptions EditorButtonImageOptions5 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject17 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject18 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject19 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject20 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.XtraEditors.Controls.EditorButtonImageOptions EditorButtonImageOptions6 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject21 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject22 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject23 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject24 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.XtraEditors.Controls.EditorButtonImageOptions EditorButtonImageOptions7 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject25 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject26 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject27 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject28 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.XtraEditors.Controls.EditorButtonImageOptions EditorButtonImageOptions8 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject29 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject30 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject31 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject32 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.XtraEditors.Controls.EditorButtonImageOptions EditorButtonImageOptions9 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject33 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject34 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject35 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject36 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.XtraEditors.Controls.EditorButtonImageOptions EditorButtonImageOptions10 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject37 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject38 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject39 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject40 = new DevExpress.Utils.SerializableAppearanceObject();
			this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.txtAddress = new DevExpress.XtraEditors.ButtonEdit();
			this.txtAddress.Properties.Enter += new System.EventHandler(this.txtLogin_Enter);
			this.txtAddress.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtLogin_ButtonClick);
			this.LabelControl7 = new DevExpress.XtraEditors.LabelControl();
			this.lbxContacts = new DevExpress.XtraEditors.ListBoxControl();
			this.lbxContacts.ContextButtonClick += new DevExpress.Utils.ContextItemClickEventHandler(this.lbxContacts_ContextButtonClick);
			this.lbxContacts.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbxContacts_MouseMove);
			this.lbxContacts.MouseLeave += new System.EventHandler(this.lbxContacts_MouseLeave);
			this.ToolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
			this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl8 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl10 = new DevExpress.XtraEditors.LabelControl();
			this.txtDtBirth = new DevExpress.XtraEditors.DateEdit();
			this.txtDtBirth.Properties.Enter += new System.EventHandler(this.txtLogin_Enter);
			this.txtDtBirth.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtLogin_ButtonClick);
			this.txtRoomNumber = new DevExpress.XtraEditors.ButtonEdit();
			this.txtRoomNumber.Properties.Enter += new System.EventHandler(this.txtLogin_Enter);
			this.txtRoomNumber.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtLogin_ButtonClick);
			this.LabelControl11 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl12 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl13 = new DevExpress.XtraEditors.LabelControl();
			this.SeparatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
			this.LabelControl14 = new DevExpress.XtraEditors.LabelControl();
			this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
			this.btnOk = new DevExpress.XtraEditors.SimpleButton();
			this.btnOk.Click += new System.EventHandler(this.btnSave_Click);
			this.gcHistoryRoleJobs = new DevExpress.XtraGrid.GridControl();
			this.gvHistoryRoleJobs = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gcContacts = new DevExpress.XtraEditors.GroupControl();
			this.gcContacts.CustomButtonClick += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.gcContacts_CustomButtonClick);
			this.tmrCheckedFields = new System.Windows.Forms.Timer(this.components);
			this.tmrCheckedFields.Tick += new System.EventHandler(this.tmrCheckedFields_Tick);
			this.btnSave = new DevExpress.XtraEditors.SimpleButton();
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			this.LabelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.txtEmail = new DevExpress.XtraEditors.ButtonEdit();
			this.txtEmail.Properties.Enter += new System.EventHandler(this.txtLogin_Enter);
			this.txtEmail.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtLogin_ButtonClick);
			this.txtLogin = new DevExpress.XtraEditors.ButtonEdit();
			this.txtLogin.Properties.Enter += new System.EventHandler(this.txtLogin_Enter);
			this.txtLogin.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtLogin_ButtonClick);
			this.txtSurname = new DevExpress.XtraEditors.ButtonEdit();
			this.txtSurname.Properties.Enter += new System.EventHandler(this.txtLogin_Enter);
			this.txtSurname.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtLogin_ButtonClick);
			this.txtPatronymic = new DevExpress.XtraEditors.ButtonEdit();
			this.txtPatronymic.Properties.Enter += new System.EventHandler(this.txtLogin_Enter);
			this.txtPatronymic.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtLogin_ButtonClick);
			this.txtName = new DevExpress.XtraEditors.ButtonEdit();
			this.txtName.Properties.Enter += new System.EventHandler(this.txtLogin_Enter);
			this.txtName.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtLogin_ButtonClick);
			this.txtPassword1 = new DevExpress.XtraEditors.ButtonEdit();
			this.txtPassword1.Properties.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword2_Properties_Validating);
			this.txtPassword1.TextChanged += new System.EventHandler(this.txtPassword2_TextChanged);
			this.txtPassword1.Properties.Enter += new System.EventHandler(this.txtLogin_Enter);
			this.txtPassword1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtLogin_ButtonClick);
			this.txtPassword2 = new DevExpress.XtraEditors.ButtonEdit();
			this.txtPassword2.Properties.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword2_Properties_Validating);
			this.txtPassword2.TextChanged += new System.EventHandler(this.txtPassword2_TextChanged);
			this.txtPassword2.Properties.Enter += new System.EventHandler(this.txtLogin_Enter);
			this.txtPassword2.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtLogin_ButtonClick);
			this.btnAddRoleJobs = new DevExpress.XtraEditors.SimpleButton();
			this.btnAddRoleJobs.Click += new System.EventHandler(this.btnAddRoleJobs_Click);
			this.btnEditRoleJobs = new DevExpress.XtraEditors.SimpleButton();
			this.btnEditRoleJobs.Click += new System.EventHandler(this.btnEditRoleJobs_Click);
			this.btnDeleteRoleJobs = new DevExpress.XtraEditors.SimpleButton();
			this.btnDeleteRoleJobs.Click += new System.EventHandler(this.btnDeleteRoleJobs_Click);
			this.cmdSex = new DevExpress.XtraEditors.ImageComboBoxEdit();
			this.lbxPerfGroups = new DevExpress.XtraEditors.CheckedListBoxControl();
			this.GroupControl1 = new DevExpress.XtraEditors.GroupControl();
			((System.ComponentModel.ISupportInitialize) this.txtAddress.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.lbxContacts).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.txtDtBirth.Properties.CalendarTimeProperties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.txtDtBirth.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.txtRoomNumber.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.SeparatorControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.gcHistoryRoleJobs).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.gvHistoryRoleJobs).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.gcContacts).BeginInit();
			this.gcContacts.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.txtEmail.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.txtLogin.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.txtSurname.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.txtPatronymic.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.txtName.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.txtPassword1.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.txtPassword2.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.cmdSex.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.lbxPerfGroups).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GroupControl1).BeginInit();
			this.GroupControl1.SuspendLayout();
			this.SuspendLayout();
			//
			//LabelControl3
			//
			this.LabelControl3.AllowHtmlString = true;
			this.LabelControl3.Location = new System.Drawing.Point(169, 95);
			this.LabelControl3.Name = "LabelControl3";
			this.LabelControl3.Size = new System.Drawing.Size(62, 13);
			this.LabelControl3.TabIndex = 0;
			this.LabelControl3.Tag = "0";
			this.LabelControl3.Text = "<color=red>*</color><u> Отчество:</u>";
			//
			//LabelControl2
			//
			this.LabelControl2.AllowHtmlString = true;
			this.LabelControl2.Location = new System.Drawing.Point(169, 54);
			this.LabelControl2.Name = "LabelControl2";
			this.LabelControl2.Size = new System.Drawing.Size(32, 13);
			this.LabelControl2.TabIndex = 0;
			this.LabelControl2.Tag = "0";
			this.LabelControl2.Text = "<color=red>*</color><u> Имя:</u>";
			//
			//LabelControl1
			//
			this.LabelControl1.AllowHtmlString = true;
			this.LabelControl1.Location = new System.Drawing.Point(169, 13);
			this.LabelControl1.Name = "LabelControl1";
			this.LabelControl1.Size = new System.Drawing.Size(57, 13);
			this.LabelControl1.TabIndex = 0;
			this.LabelControl1.Tag = "0";
			this.LabelControl1.Text = "<color=red>*</color><u> Фамилия:</u>";
			//
			//txtAddress
			//
			this.txtAddress.EnterMoveNextControl = true;
			this.txtAddress.Location = new System.Drawing.Point(13, 173);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Properties.AutoHeight = false;
			EditorButtonImageOptions1.Image = (System.Drawing.Image) (resources.GetObject("EditorButtonImageOptions1.Image"));
			this.txtAddress.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "txtAddress", -1, true, true, false, EditorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "Очистить поле", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
			this.txtAddress.Properties.ContextImageOptions.Image = (System.Drawing.Image) (resources.GetObject("txtAddress.Properties.ContextImageOptions.Image"));
			this.txtAddress.Properties.MaxLength = 70;
			this.txtAddress.Size = new System.Drawing.Size(531, 20);
			this.txtAddress.TabIndex = 7;
			this.txtAddress.Tag = "6";
			//
			//LabelControl7
			//
			this.LabelControl7.AllowHtmlString = true;
			this.LabelControl7.Location = new System.Drawing.Point(296, 256);
			this.LabelControl7.Name = "LabelControl7";
			this.LabelControl7.Size = new System.Drawing.Size(86, 13);
			this.LabelControl7.TabIndex = 0;
			this.LabelControl7.Tag = "0";
			this.LabelControl7.Text = "<u>Пол сотрудника:</u>";
			//
			//lbxContacts
			//
			this.lbxContacts.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
			this.lbxContacts.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
			this.lbxContacts.ContextButtonOptions.AllowHtmlText = true;
			SimpleContextButton1.AnimationType = DevExpress.Utils.ContextAnimationType.OutAnimation;
			SimpleContextButton1.Id = new System.Guid("0ba77821-8c51-40ce-bbae-312af7df6c00");
			SimpleContextButton1.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("resource.Image"));
			SimpleContextButton1.Name = "btnEditPerfPhone";
			SimpleContextButton1.ToolTip = "Изменить контакт";
			SimpleContextButton2.AnimationType = DevExpress.Utils.ContextAnimationType.OutAnimation;
			SimpleContextButton2.Id = new System.Guid("58424967-6e95-4d42-83e8-efd19c355642");
			SimpleContextButton2.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("resource.Image1"));
			SimpleContextButton2.Name = "btnDelPerfPhone";
			SimpleContextButton2.Tag = "";
			SimpleContextButton2.ToolTip = "Удалить контакт";
			this.lbxContacts.ContextButtons.Add(SimpleContextButton1);
			this.lbxContacts.ContextButtons.Add(SimpleContextButton2);
			this.lbxContacts.Cursor = System.Windows.Forms.Cursors.Default;
			this.lbxContacts.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbxContacts.HotTrackItems = true;
			this.lbxContacts.ItemAutoHeight = true;
			this.lbxContacts.ItemHeight = 16;
			this.lbxContacts.Location = new System.Drawing.Point(2, 29);
			this.lbxContacts.Name = "lbxContacts";
			this.lbxContacts.ShowToolTipForTrimmedText = DevExpress.Utils.DefaultBoolean.True;
			this.lbxContacts.Size = new System.Drawing.Size(262, 66);
			this.lbxContacts.SortOrder = System.Windows.Forms.SortOrder.Ascending;
			this.lbxContacts.TabIndex = 12;
			this.lbxContacts.Tag = "0";
			this.lbxContacts.ToolTipController = this.ToolTipController1;
			//
			//ToolTipController1
			//
			this.ToolTipController1.AllowHtmlText = true;
			this.ToolTipController1.AutoPopDelay = 1000;
			//
			//LabelControl4
			//
			this.LabelControl4.AllowHtmlString = true;
			this.LabelControl4.Location = new System.Drawing.Point(333, 230);
			this.LabelControl4.Name = "LabelControl4";
			this.LabelControl4.Size = new System.Drawing.Size(47, 13);
			this.LabelControl4.TabIndex = 0;
			this.LabelControl4.Tag = "0";
			this.LabelControl4.Text = "<u>Кабинет:</u>";
			//
			//LabelControl8
			//
			this.LabelControl8.AllowHtmlString = true;
			this.LabelControl8.Location = new System.Drawing.Point(296, 204);
			this.LabelControl8.Name = "LabelControl8";
			this.LabelControl8.Size = new System.Drawing.Size(84, 13);
			this.LabelControl8.TabIndex = 0;
			this.LabelControl8.Tag = "0";
			this.LabelControl8.Text = "<u>Дата рождения:</u>";
			//
			//LabelControl10
			//
			this.LabelControl10.AllowHtmlString = true;
			this.LabelControl10.Location = new System.Drawing.Point(13, 159);
			this.LabelControl10.Name = "LabelControl10";
			this.LabelControl10.Size = new System.Drawing.Size(89, 13);
			this.LabelControl10.TabIndex = 0;
			this.LabelControl10.Tag = "0";
			this.LabelControl10.Text = "<u>Домашний адрес:</u>";
			//
			//txtDtBirth
			//
			this.txtDtBirth.EditValue = null;
			this.txtDtBirth.EnterMoveNextControl = true;
			this.txtDtBirth.Location = new System.Drawing.Point(386, 203);
			this.txtDtBirth.Name = "txtDtBirth";
			this.txtDtBirth.Properties.AutoHeight = false;
			EditorButtonImageOptions2.Image = (System.Drawing.Image) (resources.GetObject("EditorButtonImageOptions2.Image"));
			this.txtDtBirth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, EditorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
			this.txtDtBirth.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtDtBirth.Size = new System.Drawing.Size(158, 20);
			this.txtDtBirth.TabIndex = 8;
			this.txtDtBirth.Tag = "7";
			//
			//txtRoomNumber
			//
			this.txtRoomNumber.EditValue = "";
			this.txtRoomNumber.EnterMoveNextControl = true;
			this.txtRoomNumber.Location = new System.Drawing.Point(386, 229);
			this.txtRoomNumber.Name = "txtRoomNumber";
			this.txtRoomNumber.Properties.AutoHeight = false;
			EditorButtonImageOptions3.Image = (System.Drawing.Image) (resources.GetObject("EditorButtonImageOptions3.Image"));
			this.txtRoomNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "txtRoomNumber", -1, true, true, false, EditorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject9, SerializableAppearanceObject10, SerializableAppearanceObject11, SerializableAppearanceObject12, "Очистить поле", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
			this.txtRoomNumber.Properties.ContextImageOptions.Image = (System.Drawing.Image) (resources.GetObject("txtRoomNumber.Properties.ContextImageOptions.Image"));
			this.txtRoomNumber.Properties.MaxLength = 4;
			this.txtRoomNumber.Size = new System.Drawing.Size(158, 20);
			this.txtRoomNumber.TabIndex = 9;
			this.txtRoomNumber.Tag = "8";
			//
			//LabelControl11
			//
			this.LabelControl11.AllowHtmlString = true;
			this.LabelControl11.Location = new System.Drawing.Point(13, 54);
			this.LabelControl11.Name = "LabelControl11";
			this.LabelControl11.Size = new System.Drawing.Size(50, 13);
			this.LabelControl11.TabIndex = 0;
			this.LabelControl11.Tag = "0";
			this.LabelControl11.Text = "<color=red>*</color><u> Пароль:</u>";
			//
			//LabelControl12
			//
			this.LabelControl12.AllowHtmlString = true;
			this.LabelControl12.Location = new System.Drawing.Point(13, 95);
			this.LabelControl12.Name = "LabelControl12";
			this.LabelControl12.Size = new System.Drawing.Size(135, 13);
			this.LabelControl12.TabIndex = 0;
			this.LabelControl12.Tag = "0";
			this.LabelControl12.Text = "<color=red>*</color><u> Подтверждение пароля:</u>";
			//
			//LabelControl13
			//
			this.LabelControl13.AllowHtmlString = true;
			this.LabelControl13.Location = new System.Drawing.Point(13, 13);
			this.LabelControl13.Name = "LabelControl13";
			this.LabelControl13.Size = new System.Drawing.Size(43, 13);
			this.LabelControl13.TabIndex = 0;
			this.LabelControl13.Tag = "0";
			this.LabelControl13.Text = "<color=red>*</color><u> Логин:</u>";
			//
			//SeparatorControl1
			//
			this.SeparatorControl1.LineAlignment = DevExpress.XtraEditors.Alignment.Center;
			this.SeparatorControl1.Location = new System.Drawing.Point(13, 299);
			this.SeparatorControl1.Name = "SeparatorControl1";
			this.SeparatorControl1.Size = new System.Drawing.Size(531, 29);
			this.SeparatorControl1.TabIndex = 40;
			this.SeparatorControl1.Tag = "0";
			//
			//LabelControl14
			//
			this.LabelControl14.AllowHtmlString = true;
			this.LabelControl14.Appearance.Options.UseTextOptions = true;
			this.LabelControl14.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.LabelControl14.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.LabelControl14.LineVisible = true;
			this.LabelControl14.Location = new System.Drawing.Point(13, 143);
			this.LabelControl14.Name = "LabelControl14";
			this.LabelControl14.Size = new System.Drawing.Size(531, 13);
			this.LabelControl14.TabIndex = 0;
			this.LabelControl14.Tag = "0";
			this.LabelControl14.Text = " <image=#Contact_16x16> Контактные данные";
			//
			//btnCancel
			//
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnCancel.ImageOptions.Image"));
			this.btnCancel.Location = new System.Drawing.Point(467, 494);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
			this.btnCancel.Size = new System.Drawing.Size(77, 26);
			this.btnCancel.TabIndex = 15;
			this.btnCancel.Tag = "0";
			this.btnCancel.Text = "Отмена";
			//
			//btnOk
			//
			this.btnOk.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnOk.ImageOptions.Image"));
			this.btnOk.ImageOptions.ImageIndex = 0;
			this.btnOk.Location = new System.Drawing.Point(384, 494);
			this.btnOk.Name = "btnOk";
			this.btnOk.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
			this.btnOk.Size = new System.Drawing.Size(77, 26);
			this.btnOk.TabIndex = 14;
			this.btnOk.Tag = "11";
			this.btnOk.Text = "OK";
			//
			//gcHistoryRoleJobs
			//
			this.gcHistoryRoleJobs.Location = new System.Drawing.Point(13, 332);
			this.gcHistoryRoleJobs.MainView = this.gvHistoryRoleJobs;
			this.gcHistoryRoleJobs.Name = "gcHistoryRoleJobs";
			this.gcHistoryRoleJobs.Size = new System.Drawing.Size(531, 147);
			this.gcHistoryRoleJobs.TabIndex = 41;
			this.gcHistoryRoleJobs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.gvHistoryRoleJobs});
			//
			//gvHistoryRoleJobs
			//
			this.gvHistoryRoleJobs.Appearance.HeaderPanel.Options.UseTextOptions = true;
			this.gvHistoryRoleJobs.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gvHistoryRoleJobs.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", (float) (10.0F));
			this.gvHistoryRoleJobs.Appearance.ViewCaption.Options.UseFont = true;
			this.gvHistoryRoleJobs.Appearance.ViewCaption.Options.UseTextOptions = true;
			this.gvHistoryRoleJobs.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
			this.gvHistoryRoleJobs.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
			this.gvHistoryRoleJobs.GridControl = this.gcHistoryRoleJobs;
			this.gvHistoryRoleJobs.Name = "gvHistoryRoleJobs";
			this.gvHistoryRoleJobs.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
			this.gvHistoryRoleJobs.OptionsBehavior.Editable = false;
			this.gvHistoryRoleJobs.OptionsClipboard.AllowCopy = DevExpress.Utils.DefaultBoolean.False;
			this.gvHistoryRoleJobs.OptionsCustomization.AllowColumnMoving = false;
			this.gvHistoryRoleJobs.OptionsCustomization.AllowFilter = false;
			this.gvHistoryRoleJobs.OptionsCustomization.AllowGroup = false;
			this.gvHistoryRoleJobs.OptionsCustomization.AllowMergedGrouping = DevExpress.Utils.DefaultBoolean.False;
			this.gvHistoryRoleJobs.OptionsCustomization.AllowQuickHideColumns = false;
			this.gvHistoryRoleJobs.OptionsCustomization.AllowSort = false;
			this.gvHistoryRoleJobs.OptionsDetail.EnableMasterViewMode = false;
			this.gvHistoryRoleJobs.OptionsFilter.AllowFilterEditor = false;
			this.gvHistoryRoleJobs.OptionsFind.AllowFindPanel = false;
			this.gvHistoryRoleJobs.OptionsFind.ClearFindOnClose = false;
			this.gvHistoryRoleJobs.OptionsImageLoad.AnimationType = DevExpress.Utils.ImageContentAnimationType.Slide;
			this.gvHistoryRoleJobs.OptionsMenu.EnableColumnMenu = false;
			this.gvHistoryRoleJobs.OptionsMenu.EnableFooterMenu = false;
			this.gvHistoryRoleJobs.OptionsMenu.EnableGroupPanelMenu = false;
			this.gvHistoryRoleJobs.OptionsNavigation.AutoFocusNewRow = true;
			this.gvHistoryRoleJobs.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gvHistoryRoleJobs.OptionsView.ShowGroupPanel = false;
			this.gvHistoryRoleJobs.OptionsView.ShowIndicator = false;
			this.gvHistoryRoleJobs.OptionsView.ShowViewCaption = true;
			this.gvHistoryRoleJobs.ViewCaption = "<size=13> </size><color=red>*</color><u> <u><b>История должностных обязанностей с" +
				"отрудника</b></u>";
			//
			//gcContacts
			//
			this.gcContacts.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.gcContacts.CaptionImageOptions.Image = (System.Drawing.Image) (resources.GetObject("gcContacts.CaptionImageOptions.Image"));
			this.gcContacts.Controls.Add(this.lbxContacts);
			ButtonImageOptions1.Image = (System.Drawing.Image) (resources.GetObject("ButtonImageOptions1.Image"));
			this.gcContacts.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("btnAddContact", false, ButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Добавить контакт", -1, true, null, true, false, true, null, 1)});
			this.gcContacts.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
			this.gcContacts.Location = new System.Drawing.Point(13, 204);
			this.gcContacts.Name = "gcContacts";
			this.gcContacts.Size = new System.Drawing.Size(266, 97);
			this.gcContacts.TabIndex = 42;
			this.gcContacts.Text = " Контакты пользователя";
			//
			//tmrCheckedFields
			//
			this.tmrCheckedFields.Enabled = true;
			this.tmrCheckedFields.Interval = 10;
			//
			//btnSave
			//
			this.btnSave.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnSave.ImageOptions.Image"));
			this.btnSave.ImageOptions.ImageIndex = 0;
			this.btnSave.Location = new System.Drawing.Point(349, 494);
			this.btnSave.Name = "btnSave";
			this.btnSave.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
			this.btnSave.Size = new System.Drawing.Size(26, 26);
			this.btnSave.TabIndex = 43;
			this.btnSave.Tag = "11";
			this.btnSave.ToolTip = "Добавить сотрудника в базу данных";
			//
			//LabelControl5
			//
			this.LabelControl5.AllowHtmlString = true;
			this.LabelControl5.Location = new System.Drawing.Point(296, 282);
			this.LabelControl5.Name = "LabelControl5";
			this.LabelControl5.Size = new System.Drawing.Size(35, 13);
			this.LabelControl5.TabIndex = 44;
			this.LabelControl5.Tag = "0";
			this.LabelControl5.Text = "<u> E-mail:</u>";
			//
			//txtEmail
			//
			this.txtEmail.EnterMoveNextControl = true;
			this.txtEmail.Location = new System.Drawing.Point(337, 281);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Properties.AutoHeight = false;
			EditorButtonImageOptions4.Image = (System.Drawing.Image) (resources.GetObject("EditorButtonImageOptions4.Image"));
			this.txtEmail.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "txtEmail", -1, true, true, false, EditorButtonImageOptions4, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject13, SerializableAppearanceObject14, SerializableAppearanceObject15, SerializableAppearanceObject16, "Очистить поле", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
			this.txtEmail.Properties.ContextImageOptions.Image = (System.Drawing.Image) (resources.GetObject("txtEmail.Properties.ContextImageOptions.Image"));
			this.txtEmail.Properties.HideSelection = false;
			this.txtEmail.Properties.MaxLength = 70;
			this.txtEmail.Size = new System.Drawing.Size(207, 20);
			this.txtEmail.TabIndex = 12;
			this.txtEmail.Tag = "5";
			//
			//txtLogin
			//
			this.txtLogin.EnterMoveNextControl = true;
			this.txtLogin.Location = new System.Drawing.Point(13, 28);
			this.txtLogin.Name = "txtLogin";
			this.txtLogin.Properties.AutoHeight = false;
			EditorButtonImageOptions5.Image = (System.Drawing.Image) (resources.GetObject("EditorButtonImageOptions5.Image"));
			this.txtLogin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "txtLogin", -1, true, true, false, EditorButtonImageOptions5, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject17, SerializableAppearanceObject18, SerializableAppearanceObject19, SerializableAppearanceObject20, "Очистить поле", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
			this.txtLogin.Properties.MaxLength = 20;
			this.txtLogin.Size = new System.Drawing.Size(146, 20);
			this.txtLogin.TabIndex = 1;
			this.txtLogin.Tag = "0";
			//
			//txtSurname
			//
			this.txtSurname.EnterMoveNextControl = true;
			this.txtSurname.Location = new System.Drawing.Point(169, 28);
			this.txtSurname.Name = "txtSurname";
			this.txtSurname.Properties.AutoHeight = false;
			EditorButtonImageOptions6.Image = (System.Drawing.Image) (resources.GetObject("EditorButtonImageOptions6.Image"));
			this.txtSurname.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "txtSurname", -1, true, true, false, EditorButtonImageOptions6, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject21, SerializableAppearanceObject22, SerializableAppearanceObject23, SerializableAppearanceObject24, "Очистить поле", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
			this.txtSurname.Properties.MaxLength = 30;
			this.txtSurname.Size = new System.Drawing.Size(177, 20);
			this.txtSurname.TabIndex = 4;
			this.txtSurname.Tag = "3";
			//
			//txtPatronymic
			//
			this.txtPatronymic.EnterMoveNextControl = true;
			this.txtPatronymic.Location = new System.Drawing.Point(169, 110);
			this.txtPatronymic.Name = "txtPatronymic";
			this.txtPatronymic.Properties.AutoHeight = false;
			EditorButtonImageOptions7.Image = (System.Drawing.Image) (resources.GetObject("EditorButtonImageOptions7.Image"));
			this.txtPatronymic.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "txtPatronymic", -1, true, true, false, EditorButtonImageOptions7, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject25, SerializableAppearanceObject26, SerializableAppearanceObject27, SerializableAppearanceObject28, "Очистить поле", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
			this.txtPatronymic.Properties.MaxLength = 30;
			this.txtPatronymic.Size = new System.Drawing.Size(177, 20);
			this.txtPatronymic.TabIndex = 6;
			this.txtPatronymic.Tag = "5";
			//
			//txtName
			//
			this.txtName.EnterMoveNextControl = true;
			this.txtName.Location = new System.Drawing.Point(169, 69);
			this.txtName.Name = "txtName";
			this.txtName.Properties.AutoHeight = false;
			EditorButtonImageOptions8.Image = (System.Drawing.Image) (resources.GetObject("EditorButtonImageOptions8.Image"));
			this.txtName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "txtName", -1, true, true, false, EditorButtonImageOptions8, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject29, SerializableAppearanceObject30, SerializableAppearanceObject31, SerializableAppearanceObject32, "Очистить поле", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
			this.txtName.Properties.MaxLength = 30;
			this.txtName.Size = new System.Drawing.Size(177, 20);
			this.txtName.TabIndex = 5;
			this.txtName.Tag = "4";
			//
			//txtPassword1
			//
			this.txtPassword1.EnterMoveNextControl = true;
			this.txtPassword1.Location = new System.Drawing.Point(13, 69);
			this.txtPassword1.Name = "txtPassword1";
			this.txtPassword1.Properties.AutoHeight = false;
			EditorButtonImageOptions9.Image = (System.Drawing.Image) (resources.GetObject("EditorButtonImageOptions9.Image"));
			this.txtPassword1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "txtPassword1", -1, true, true, false, EditorButtonImageOptions9, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject33, SerializableAppearanceObject34, SerializableAppearanceObject35, SerializableAppearanceObject36, "Очистить поле", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
			this.txtPassword1.Properties.MaxLength = 20;
			this.txtPassword1.Properties.PasswordChar = global::Microsoft.VisualBasic.Strings.ChrW(8226);
			this.txtPassword1.Size = new System.Drawing.Size(146, 20);
			this.txtPassword1.TabIndex = 2;
			this.txtPassword1.Tag = "1";
			//
			//txtPassword2
			//
			this.txtPassword2.EnterMoveNextControl = true;
			this.txtPassword2.Location = new System.Drawing.Point(13, 110);
			this.txtPassword2.Name = "txtPassword2";
			this.txtPassword2.Properties.AutoHeight = false;
			EditorButtonImageOptions10.Image = (System.Drawing.Image) (resources.GetObject("EditorButtonImageOptions10.Image"));
			this.txtPassword2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "txtPassword2", -1, true, true, false, EditorButtonImageOptions10, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject37, SerializableAppearanceObject38, SerializableAppearanceObject39, SerializableAppearanceObject40, "Очистить поле", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
			this.txtPassword2.Properties.MaxLength = 20;
			this.txtPassword2.Properties.PasswordChar = global::Microsoft.VisualBasic.Strings.ChrW(8226);
			this.txtPassword2.Size = new System.Drawing.Size(146, 20);
			this.txtPassword2.TabIndex = 3;
			this.txtPassword2.Tag = "2";
			//
			//btnAddRoleJobs
			//
			this.btnAddRoleJobs.AllowFocus = false;
			this.btnAddRoleJobs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnAddRoleJobs.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnAddRoleJobs.ImageOptions.Image"));
			this.btnAddRoleJobs.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
			this.btnAddRoleJobs.ImageOptions.ImageToTextIndent = 0;
			this.btnAddRoleJobs.Location = new System.Drawing.Point(15, 334);
			this.btnAddRoleJobs.Name = "btnAddRoleJobs";
			this.btnAddRoleJobs.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
			this.btnAddRoleJobs.Size = new System.Drawing.Size(27, 27);
			this.btnAddRoleJobs.TabIndex = 45;
			//
			//btnEditRoleJobs
			//
			this.btnEditRoleJobs.AllowFocus = false;
			this.btnEditRoleJobs.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnEditRoleJobs.ImageOptions.Image"));
			this.btnEditRoleJobs.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
			this.btnEditRoleJobs.ImageOptions.ImageToTextIndent = 0;
			this.btnEditRoleJobs.Location = new System.Drawing.Point(45, 334);
			this.btnEditRoleJobs.Name = "btnEditRoleJobs";
			this.btnEditRoleJobs.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
			this.btnEditRoleJobs.Size = new System.Drawing.Size(27, 27);
			this.btnEditRoleJobs.TabIndex = 46;
			//
			//btnDeleteRoleJobs
			//
			this.btnDeleteRoleJobs.AllowFocus = false;
			this.btnDeleteRoleJobs.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnDeleteRoleJobs.ImageOptions.Image"));
			this.btnDeleteRoleJobs.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
			this.btnDeleteRoleJobs.ImageOptions.ImageToTextIndent = 0;
			this.btnDeleteRoleJobs.Location = new System.Drawing.Point(75, 334);
			this.btnDeleteRoleJobs.Name = "btnDeleteRoleJobs";
			this.btnDeleteRoleJobs.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
			this.btnDeleteRoleJobs.Size = new System.Drawing.Size(27, 27);
			this.btnDeleteRoleJobs.TabIndex = 47;
			//
			//cmdSex
			//
			this.cmdSex.EnterMoveNextControl = true;
			this.cmdSex.Location = new System.Drawing.Point(386, 255);
			this.cmdSex.Name = "cmdSex";
			this.cmdSex.Properties.AllowFocused = false;
			this.cmdSex.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
			this.cmdSex.Properties.Appearance.Options.UseTextOptions = true;
			this.cmdSex.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
			this.cmdSex.Properties.AppearanceDropDown.Options.UseImage = true;
			this.cmdSex.Properties.AppearanceDropDown.Options.UseTextOptions = true;
			this.cmdSex.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cmdSex.Properties.ImmediatePopup = true;
			this.cmdSex.Properties.PopupFormMinSize = new System.Drawing.Size(10, 0);
			this.cmdSex.Properties.PopupFormSize = new System.Drawing.Size(155, 0);
			this.cmdSex.Size = new System.Drawing.Size(158, 20);
			this.cmdSex.TabIndex = 11;
			this.cmdSex.Tag = "10";
			//
			//lbxPerfGroups
			//
			this.lbxPerfGroups.CheckOnClick = true;
			this.lbxPerfGroups.Cursor = System.Windows.Forms.Cursors.Default;
			this.lbxPerfGroups.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbxPerfGroups.HotTrackSelectMode = DevExpress.XtraEditors.HotTrackSelectMode.SelectItemOnClick;
			this.lbxPerfGroups.Location = new System.Drawing.Point(2, 23);
			this.lbxPerfGroups.Name = "lbxPerfGroups";
			this.lbxPerfGroups.SelectionMode = System.Windows.Forms.SelectionMode.None;
			this.lbxPerfGroups.ShowFocusRect = false;
			this.lbxPerfGroups.Size = new System.Drawing.Size(188, 92);
			this.lbxPerfGroups.SortOrder = System.Windows.Forms.SortOrder.Ascending;
			this.lbxPerfGroups.TabIndex = 48;
			//
			//GroupControl1
			//
			this.GroupControl1.AllowHtmlText = true;
			this.GroupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.GroupControl1.CaptionImageOptions.Image = (System.Drawing.Image) (resources.GetObject("GroupControl1.CaptionImageOptions.Image"));
			this.GroupControl1.Controls.Add(this.lbxPerfGroups);
			this.GroupControl1.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
			this.GroupControl1.Location = new System.Drawing.Point(352, 13);
			this.GroupControl1.Name = "GroupControl1";
			this.GroupControl1.Size = new System.Drawing.Size(192, 117);
			this.GroupControl1.TabIndex = 49;
			this.GroupControl1.Text = "<color=red> *</color><u> Группы пользователя:</u>";
			//
			//frAddEditPerformer
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(559, 536);
			this.Controls.Add(this.GroupControl1);
			this.Controls.Add(this.btnAddRoleJobs);
			this.Controls.Add(this.btnDeleteRoleJobs);
			this.Controls.Add(this.btnEditRoleJobs);
			this.Controls.Add(this.LabelControl5);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.gcContacts);
			this.Controls.Add(this.gcHistoryRoleJobs);
			this.Controls.Add(this.LabelControl14);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.LabelControl13);
			this.Controls.Add(this.LabelControl12);
			this.Controls.Add(this.LabelControl11);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.LabelControl7);
			this.Controls.Add(this.LabelControl4);
			this.Controls.Add(this.LabelControl8);
			this.Controls.Add(this.LabelControl10);
			this.Controls.Add(this.txtDtBirth);
			this.Controls.Add(this.txtRoomNumber);
			this.Controls.Add(this.LabelControl3);
			this.Controls.Add(this.LabelControl2);
			this.Controls.Add(this.LabelControl1);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtLogin);
			this.Controls.Add(this.txtSurname);
			this.Controls.Add(this.txtPatronymic);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.txtPassword1);
			this.Controls.Add(this.txtPassword2);
			this.Controls.Add(this.SeparatorControl1);
			this.Controls.Add(this.cmdSex);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frAddEditPerformer";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Добавить исполнителя базы данных";
			((System.ComponentModel.ISupportInitialize) this.txtAddress.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.lbxContacts).EndInit();
			((System.ComponentModel.ISupportInitialize) this.txtDtBirth.Properties.CalendarTimeProperties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.txtDtBirth.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.txtRoomNumber.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.SeparatorControl1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.gcHistoryRoleJobs).EndInit();
			((System.ComponentModel.ISupportInitialize) this.gvHistoryRoleJobs).EndInit();
			((System.ComponentModel.ISupportInitialize) this.gcContacts).EndInit();
			this.gcContacts.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.txtEmail.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.txtLogin.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.txtSurname.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.txtPatronymic.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.txtName.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.txtPassword1.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.txtPassword2.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.cmdSex.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.lbxPerfGroups).EndInit();
			((System.ComponentModel.ISupportInitialize) this.GroupControl1).EndInit();
			this.GroupControl1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		internal DevExpress.XtraEditors.LabelControl LabelControl3;
		internal DevExpress.XtraEditors.LabelControl LabelControl2;
		internal DevExpress.XtraEditors.LabelControl LabelControl1;
		internal DevExpress.XtraEditors.ButtonEdit txtAddress;
		internal DevExpress.XtraEditors.LabelControl LabelControl7;
		internal DevExpress.XtraEditors.ListBoxControl lbxContacts;
		internal DevExpress.XtraEditors.LabelControl LabelControl4;
		internal DevExpress.XtraEditors.LabelControl LabelControl8;
		internal DevExpress.XtraEditors.LabelControl LabelControl10;
		internal DevExpress.XtraEditors.DateEdit txtDtBirth;
		internal DevExpress.XtraEditors.ButtonEdit txtRoomNumber;
		internal DevExpress.XtraEditors.LabelControl LabelControl11;
		internal DevExpress.XtraEditors.LabelControl LabelControl12;
		internal DevExpress.XtraEditors.LabelControl LabelControl13;
		internal DevExpress.XtraEditors.SimpleButton btnOk;
		internal DevExpress.XtraEditors.SimpleButton btnCancel;
		internal DevExpress.XtraEditors.SeparatorControl SeparatorControl1;
		internal DevExpress.XtraEditors.LabelControl LabelControl14;
		internal DevExpress.XtraGrid.GridControl gcHistoryRoleJobs;
		internal DevExpress.XtraGrid.Views.Grid.GridView gvHistoryRoleJobs;
		internal DevExpress.XtraEditors.GroupControl gcContacts;
		internal Timer tmrCheckedFields;
		internal DevExpress.XtraEditors.SimpleButton btnSave;
		internal DevExpress.XtraEditors.LabelControl LabelControl5;
		internal DevExpress.XtraEditors.ButtonEdit txtEmail;
		internal DevExpress.XtraEditors.ButtonEdit txtLogin;
		internal DevExpress.XtraEditors.ButtonEdit txtSurname;
		internal DevExpress.XtraEditors.ButtonEdit txtPatronymic;
		internal DevExpress.XtraEditors.ButtonEdit txtName;
		internal DevExpress.XtraEditors.ButtonEdit txtPassword1;
		internal DevExpress.XtraEditors.ButtonEdit txtPassword2;
		internal DevExpress.XtraEditors.SimpleButton btnAddRoleJobs;
		internal DevExpress.XtraEditors.SimpleButton btnEditRoleJobs;
		internal DevExpress.XtraEditors.SimpleButton btnDeleteRoleJobs;
		internal DevExpress.Utils.ToolTipController ToolTipController1;
		internal DevExpress.XtraEditors.ImageComboBoxEdit cmdSex;
		internal DevExpress.XtraEditors.CheckedListBoxControl lbxPerfGroups;
		internal DevExpress.XtraEditors.GroupControl GroupControl1;
	}
	
}
