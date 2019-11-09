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
	partial class frAddEditContact : DevExpress.XtraEditors.XtraForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frAddEditContact));
			DevExpress.XtraEditors.Controls.EditorButtonImageOptions EditorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
			this.PanelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.PanelControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_MouseDown);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(frAddEditContact_FormClosing);
			this.Load += new System.EventHandler(frAddEditContact_Load);
			this.LabelControl13 = new DevExpress.XtraEditors.LabelControl();
			this.lbNameForm = new DevExpress.XtraEditors.LabelControl();
			this.lbNameForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_MouseDown);
			this.btnClose = new DevExpress.XtraEditors.SimpleButton();
			this.btnClose.Click += new System.EventHandler(this.btnCancel_Click);
			this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			this.btnOk = new DevExpress.XtraEditors.SimpleButton();
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			this.txtPhoneNumber = new DevExpress.XtraEditors.ButtonEdit();
			this.txtPhoneNumber.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtPhoneNumber_Properties_ButtonClick);
			this.rgContactsTypes = new DevExpress.XtraEditors.RadioGroup();
			this.rgContactsTypes.SelectedIndexChanged += new System.EventHandler(this.rgContactsTypes_SelectedIndexChanged);
			((System.ComponentModel.ISupportInitialize) this.PanelControl1).BeginInit();
			this.PanelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.txtPhoneNumber.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.rgContactsTypes.Properties).BeginInit();
			this.SuspendLayout();
			//
			//PanelControl1
			//
			this.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.PanelControl1.Controls.Add(this.LabelControl13);
			this.PanelControl1.Controls.Add(this.lbNameForm);
			this.PanelControl1.Controls.Add(this.btnClose);
			this.PanelControl1.Controls.Add(this.btnCancel);
			this.PanelControl1.Controls.Add(this.btnOk);
			this.PanelControl1.Controls.Add(this.txtPhoneNumber);
			this.PanelControl1.Controls.Add(this.rgContactsTypes);
			this.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PanelControl1.Location = new System.Drawing.Point(0, 0);
			this.PanelControl1.Name = "PanelControl1";
			this.PanelControl1.Size = new System.Drawing.Size(247, 194);
			this.PanelControl1.TabIndex = 0;
			//
			//LabelControl13
			//
			this.LabelControl13.AllowHtmlString = true;
			this.LabelControl13.Location = new System.Drawing.Point(17, 36);
			this.LabelControl13.Name = "LabelControl13";
			this.LabelControl13.Size = new System.Drawing.Size(95, 13);
			this.LabelControl13.TabIndex = 18;
			this.LabelControl13.Tag = "0";
			this.LabelControl13.Text = "<color=red>*</color><u> Номер контакта:</u>";
			//
			//lbNameForm
			//
			this.lbNameForm.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (9.0F), System.Drawing.FontStyle.Bold);
			this.lbNameForm.Appearance.Image = (System.Drawing.Image) (resources.GetObject("lbNameForm.Appearance.Image"));
			this.lbNameForm.Appearance.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.lbNameForm.Appearance.Options.UseFont = true;
			this.lbNameForm.Appearance.Options.UseImage = true;
			this.lbNameForm.Appearance.Options.UseImageAlign = true;
			this.lbNameForm.Appearance.Options.UseTextOptions = true;
			this.lbNameForm.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.lbNameForm.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
			this.lbNameForm.Location = new System.Drawing.Point(5, 5);
			this.lbNameForm.Name = "lbNameForm";
			this.lbNameForm.Size = new System.Drawing.Size(137, 20);
			this.lbNameForm.TabIndex = 17;
			this.lbNameForm.Text = "Добавить контакт";
			//
			//btnClose
			//
			this.btnClose.AllowFocus = false;
			this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			this.btnClose.AutoSize = true;
			this.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
			this.btnClose.ImageOptions.ImageUri.Uri = "Delete;Size16x16;Office2013";
			this.btnClose.Location = new System.Drawing.Point(218, 5);
			this.btnClose.Name = "btnClose";
			this.btnClose.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
			this.btnClose.Size = new System.Drawing.Size(24, 22);
			this.btnClose.TabIndex = 16;
			//
			//btnCancel
			//
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnCancel.ImageOptions.Image"));
			this.btnCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
			this.btnCancel.Location = new System.Drawing.Point(188, 153);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
			this.btnCancel.Size = new System.Drawing.Size(38, 26);
			this.btnCancel.TabIndex = 0;
			this.btnCancel.Tag = "0";
			//
			//btnOk
			//
			this.btnOk.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnOk.ImageOptions.Image"));
			this.btnOk.ImageOptions.ImageIndex = 0;
			this.btnOk.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
			this.btnOk.Location = new System.Drawing.Point(144, 153);
			this.btnOk.Name = "btnOk";
			this.btnOk.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
			this.btnOk.Size = new System.Drawing.Size(38, 26);
			this.btnOk.TabIndex = 2;
			this.btnOk.Tag = "11";
			//
			//txtPhoneNumber
			//
			this.txtPhoneNumber.EnterMoveNextControl = true;
			this.txtPhoneNumber.Location = new System.Drawing.Point(17, 51);
			this.txtPhoneNumber.Name = "txtPhoneNumber";
			EditorButtonImageOptions1.Image = (System.Drawing.Image) (resources.GetObject("EditorButtonImageOptions1.Image"));
			this.txtPhoneNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, EditorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "Очистить поле", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
			this.txtPhoneNumber.Properties.Mask.EditMask = "(\\d?\\d?\\d?) \\d\\d\\d-\\d\\d\\d\\d";
			this.txtPhoneNumber.Properties.MaxLength = 50;
			this.txtPhoneNumber.Size = new System.Drawing.Size(209, 22);
			this.txtPhoneNumber.TabIndex = 1;
			//
			//rgContactsTypes
			//
			this.rgContactsTypes.EditValue = "PhoneMobile_12x12";
			this.rgContactsTypes.EnterMoveNextControl = true;
			this.rgContactsTypes.Location = new System.Drawing.Point(17, 77);
			this.rgContactsTypes.Name = "rgContactsTypes";
			this.rgContactsTypes.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {new DevExpress.XtraEditors.Controls.RadioGroupItem("PhoneMobile_12x12", "Сотовый", true, "\\+7(\\d?\\d?\\d?) \\d\\d\\d-\\d\\d-\\d\\d"), new DevExpress.XtraEditors.Controls.RadioGroupItem("PhoneHome_12x12", "Домашний", true, "\\+7(\\d?\\d?\\d?) \\d\\d\\d-\\d\\d-\\d\\d"), new DevExpress.XtraEditors.Controls.RadioGroupItem("PhoneWork_12x12", "Рабочий", true, ""), new DevExpress.XtraEditors.Controls.RadioGroupItem("PhoneOther_12x12", "Другой", true, "")});
			this.rgContactsTypes.Size = new System.Drawing.Size(209, 60);
			this.rgContactsTypes.TabIndex = 0;
			//
			//frAddEditContact
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(247, 194);
			this.Controls.Add(this.PanelControl1);
			this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frAddEditContact";
			this.ShowInTaskbar = false;
			((System.ComponentModel.ISupportInitialize) this.PanelControl1).EndInit();
			this.PanelControl1.ResumeLayout(false);
			this.PanelControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.txtPhoneNumber.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.rgContactsTypes.Properties).EndInit();
			this.ResumeLayout(false);
			
		}
		
		internal DevExpress.XtraEditors.PanelControl PanelControl1;
		internal DevExpress.XtraEditors.ButtonEdit txtPhoneNumber;
		internal DevExpress.XtraEditors.RadioGroup rgContactsTypes;
		internal DevExpress.XtraEditors.SimpleButton btnCancel;
		internal DevExpress.XtraEditors.SimpleButton btnOk;
		internal DevExpress.XtraEditors.SimpleButton btnClose;
		internal DevExpress.XtraEditors.LabelControl lbNameForm;
		internal DevExpress.XtraEditors.LabelControl LabelControl13;
	}
	
}
