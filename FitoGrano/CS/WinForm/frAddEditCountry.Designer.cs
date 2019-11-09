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
	partial class frAddEditCountry : DevExpress.XtraEditors.XtraForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frAddEditCountry));
			DevExpress.XtraEditors.Controls.EditorButtonImageOptions EditorButtonImageOptions5 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject17 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject18 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject19 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject20 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.XtraEditors.Controls.EditorButtonImageOptions EditorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
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
			this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(Control_MouseDown);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(frAddEditContact_FormClosing);
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(frAddEditCountry_MouseMove);
			this.Load += new System.EventHandler(frAddEditContact_Load);
			this.btnOk = new DevExpress.XtraEditors.SimpleButton();
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			this.LabelControl13 = new DevExpress.XtraEditors.LabelControl();
			this.txtCountryNameShort = new DevExpress.XtraEditors.ButtonEdit();
			this.txtCountryNameShort.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtProductsName_ButtonClick);
			this.lbNameForm = new DevExpress.XtraEditors.LabelControl();
			this.lbNameForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_MouseDown);
			this.lbNameForm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbNameForm_MouseUp);
			this.btnClose = new DevExpress.XtraEditors.SimpleButton();
			this.btnClose.Click += new System.EventHandler(this.btnCancel_Click);
			this.GroupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.GroupControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_MouseDown);
			this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.txtCountryNameLong = new DevExpress.XtraEditors.ButtonEdit();
			this.txtCountryNameLong.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtProductsName_ButtonClick);
			this.txtCountryNameLong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCountryNameLong_KeyDown);
			this.GroupControl2 = new DevExpress.XtraEditors.GroupControl();
			this.GroupControl2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_MouseDown);
			this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.txtCountryAlpha2 = new DevExpress.XtraEditors.ButtonEdit();
			this.txtCountryAlpha2.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtProductsName_ButtonClick);
			this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.txtCountryAlpha1 = new DevExpress.XtraEditors.ButtonEdit();
			this.txtCountryAlpha1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtProductsName_ButtonClick);
			this.lbGrip = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize) this.txtCountryNameShort.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GroupControl1).BeginInit();
			this.GroupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.txtCountryNameLong.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GroupControl2).BeginInit();
			this.GroupControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.txtCountryAlpha2.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.txtCountryAlpha1.Properties).BeginInit();
			this.SuspendLayout();
			//
			//btnCancel
			//
			this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnCancel.ImageOptions.Image"));
			this.btnCancel.Location = new System.Drawing.Point(394, 296);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
			this.btnCancel.Size = new System.Drawing.Size(77, 26);
			this.btnCancel.TabIndex = 0;
			this.btnCancel.Tag = "0";
			this.btnCancel.Text = "Отмена";
			//
			//btnOk
			//
			this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			this.btnOk.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnOk.ImageOptions.Image"));
			this.btnOk.ImageOptions.ImageIndex = 0;
			this.btnOk.Location = new System.Drawing.Point(311, 296);
			this.btnOk.Name = "btnOk";
			this.btnOk.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
			this.btnOk.Size = new System.Drawing.Size(77, 26);
			this.btnOk.TabIndex = 6;
			this.btnOk.Tag = "11";
			this.btnOk.Text = "OK";
			//
			//LabelControl13
			//
			this.LabelControl13.AllowHtmlString = true;
			this.LabelControl13.Location = new System.Drawing.Point(5, 31);
			this.LabelControl13.Name = "LabelControl13";
			this.LabelControl13.Size = new System.Drawing.Size(56, 13);
			this.LabelControl13.TabIndex = 0;
			this.LabelControl13.Tag = "0";
			this.LabelControl13.Text = "<color=red>*</color><u> Краткое:</u>";
			//
			//txtCountryNameShort
			//
			this.txtCountryNameShort.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left 
				| System.Windows.Forms.AnchorStyles.Right;
			this.txtCountryNameShort.EnterMoveNextControl = true;
			this.txtCountryNameShort.Location = new System.Drawing.Point(5, 46);
			this.txtCountryNameShort.Name = "txtCountryNameShort";
			EditorButtonImageOptions5.Image = (System.Drawing.Image) (resources.GetObject("EditorButtonImageOptions5.Image"));
			this.txtCountryNameShort.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, EditorButtonImageOptions5, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject17, SerializableAppearanceObject18, SerializableAppearanceObject19, SerializableAppearanceObject20, "Очистить поле", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
			this.txtCountryNameShort.Properties.Mask.EditMask = "(\\d?\\d?\\d?) \\d\\d\\d-\\d\\d\\d\\d";
			this.txtCountryNameShort.Properties.MaxLength = 80;
			this.txtCountryNameShort.Size = new System.Drawing.Size(449, 22);
			this.txtCountryNameShort.TabIndex = 1;
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
			this.lbNameForm.Location = new System.Drawing.Point(12, 12);
			this.lbNameForm.Name = "lbNameForm";
			this.lbNameForm.Size = new System.Drawing.Size(129, 20);
			this.lbNameForm.TabIndex = 0;
			this.lbNameForm.Text = "Добавить страну";
			//
			//btnClose
			//
			this.btnClose.AllowFocus = false;
			this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			this.btnClose.AutoSize = true;
			this.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
			this.btnClose.ImageOptions.ImageUri.Uri = "Delete;Size16x16;Office2013";
			this.btnClose.Location = new System.Drawing.Point(447, 12);
			this.btnClose.Name = "btnClose";
			this.btnClose.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
			this.btnClose.Size = new System.Drawing.Size(24, 22);
			this.btnClose.TabIndex = 0;
			//
			//GroupControl1
			//
			this.GroupControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left 
				| System.Windows.Forms.AnchorStyles.Right;
			this.GroupControl1.Controls.Add(this.LabelControl1);
			this.GroupControl1.Controls.Add(this.txtCountryNameLong);
			this.GroupControl1.Controls.Add(this.txtCountryNameShort);
			this.GroupControl1.Controls.Add(this.LabelControl13);
			this.GroupControl1.Location = new System.Drawing.Point(12, 50);
			this.GroupControl1.Name = "GroupControl1";
			this.GroupControl1.Size = new System.Drawing.Size(459, 140);
			this.GroupControl1.TabIndex = 0;
			this.GroupControl1.Text = "Наименование страны";
			//
			//LabelControl1
			//
			this.LabelControl1.AllowHtmlString = true;
			this.LabelControl1.Location = new System.Drawing.Point(11, 84);
			this.LabelControl1.Name = "LabelControl1";
			this.LabelControl1.Size = new System.Drawing.Size(44, 13);
			this.LabelControl1.TabIndex = 0;
			this.LabelControl1.Tag = "0";
			this.LabelControl1.Text = "<u> Полное:</u>";
			//
			//txtCountryNameLong
			//
			this.txtCountryNameLong.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left 
				| System.Windows.Forms.AnchorStyles.Right;
			this.txtCountryNameLong.EnterMoveNextControl = true;
			this.txtCountryNameLong.Location = new System.Drawing.Point(5, 99);
			this.txtCountryNameLong.Name = "txtCountryNameLong";
			EditorButtonImageOptions1.Image = (System.Drawing.Image) (resources.GetObject("EditorButtonImageOptions1.Image"));
			this.txtCountryNameLong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, EditorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "Очистить поле", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
			this.txtCountryNameLong.Properties.Mask.EditMask = "(\\d?\\d?\\d?) \\d\\d\\d-\\d\\d\\d\\d";
			this.txtCountryNameLong.Properties.MaxLength = 150;
			this.txtCountryNameLong.Size = new System.Drawing.Size(449, 22);
			this.txtCountryNameLong.TabIndex = 2;
			//
			//GroupControl2
			//
			this.GroupControl2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left 
				| System.Windows.Forms.AnchorStyles.Right;
			this.GroupControl2.Controls.Add(this.LabelControl3);
			this.GroupControl2.Controls.Add(this.txtCountryAlpha2);
			this.GroupControl2.Controls.Add(this.LabelControl2);
			this.GroupControl2.Controls.Add(this.txtCountryAlpha1);
			this.GroupControl2.Location = new System.Drawing.Point(12, 196);
			this.GroupControl2.Name = "GroupControl2";
			this.GroupControl2.Size = new System.Drawing.Size(459, 75);
			this.GroupControl2.TabIndex = 3;
			this.GroupControl2.Text = "Буквенный код";
			//
			//LabelControl3
			//
			this.LabelControl3.AllowHtmlString = true;
			this.LabelControl3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			this.LabelControl3.Location = new System.Drawing.Point(236, 35);
			this.LabelControl3.Name = "LabelControl3";
			this.LabelControl3.Size = new System.Drawing.Size(56, 13);
			this.LabelControl3.TabIndex = 0;
			this.LabelControl3.Tag = "0";
			this.LabelControl3.Text = "<color=red>*</color><u> Альфа-2:</u>";
			//
			//txtCountryAlpha2
			//
			this.txtCountryAlpha2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			this.txtCountryAlpha2.EditValue = "";
			this.txtCountryAlpha2.EnterMoveNextControl = true;
			this.txtCountryAlpha2.Location = new System.Drawing.Point(298, 33);
			this.txtCountryAlpha2.Name = "txtCountryAlpha2";
			EditorButtonImageOptions2.Image = (System.Drawing.Image) (resources.GetObject("EditorButtonImageOptions2.Image"));
			this.txtCountryAlpha2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, EditorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "Очистить поле", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
			this.txtCountryAlpha2.Properties.Mask.EditMask = "(\\d?\\d?\\d?) \\d\\d\\d-\\d\\d\\d\\d";
			this.txtCountryAlpha2.Properties.MaxLength = 10;
			this.txtCountryAlpha2.Size = new System.Drawing.Size(156, 22);
			this.txtCountryAlpha2.TabIndex = 5;
			//
			//LabelControl2
			//
			this.LabelControl2.AllowHtmlString = true;
			this.LabelControl2.Location = new System.Drawing.Point(6, 35);
			this.LabelControl2.Name = "LabelControl2";
			this.LabelControl2.Size = new System.Drawing.Size(56, 13);
			this.LabelControl2.TabIndex = 0;
			this.LabelControl2.Tag = "0";
			this.LabelControl2.Text = "<color=red>*</color><u> Альфа-1:</u>";
			//
			//txtCountryAlpha1
			//
			this.txtCountryAlpha1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left 
				| System.Windows.Forms.AnchorStyles.Right;
			this.txtCountryAlpha1.EnterMoveNextControl = true;
			this.txtCountryAlpha1.Location = new System.Drawing.Point(68, 33);
			this.txtCountryAlpha1.Name = "txtCountryAlpha1";
			EditorButtonImageOptions3.Image = (System.Drawing.Image) (resources.GetObject("EditorButtonImageOptions3.Image"));
			this.txtCountryAlpha1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, EditorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject9, SerializableAppearanceObject10, SerializableAppearanceObject11, SerializableAppearanceObject12, "Очистить поле", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
			this.txtCountryAlpha1.Properties.Mask.EditMask = "(\\d?\\d?\\d?) \\d\\d\\d-\\d\\d\\d\\d";
			this.txtCountryAlpha1.Properties.MaxLength = 10;
			this.txtCountryAlpha1.Size = new System.Drawing.Size(156, 22);
			this.txtCountryAlpha1.TabIndex = 4;
			//
			//lbGrip
			//
			this.lbGrip.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			this.lbGrip.Appearance.Image = (System.Drawing.Image) (resources.GetObject("lbGrip.Appearance.Image"));
			this.lbGrip.Appearance.Options.UseImage = true;
			this.lbGrip.Enabled = false;
			this.lbGrip.Location = new System.Drawing.Point(466, 318);
			this.lbGrip.Name = "lbGrip";
			this.lbGrip.Size = new System.Drawing.Size(16, 15);
			this.lbGrip.TabIndex = 7;
			//
			//frAddEditCountry
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(483, 334);
			this.Controls.Add(this.GroupControl2);
			this.Controls.Add(this.GroupControl1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.lbNameForm);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.lbGrip);
			this.DoubleBuffered = true;
			this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MinimumSize = new System.Drawing.Size(483, 334);
			this.Name = "frAddEditCountry";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "frAddEditCountry";
			((System.ComponentModel.ISupportInitialize) this.txtCountryNameShort.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.GroupControl1).EndInit();
			this.GroupControl1.ResumeLayout(false);
			this.GroupControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.txtCountryNameLong.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.GroupControl2).EndInit();
			this.GroupControl2.ResumeLayout(false);
			this.GroupControl2.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.txtCountryAlpha2.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.txtCountryAlpha1.Properties).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		
		internal DevExpress.XtraEditors.SimpleButton btnCancel;
		internal DevExpress.XtraEditors.SimpleButton btnOk;
		internal DevExpress.XtraEditors.LabelControl LabelControl13;
		internal DevExpress.XtraEditors.ButtonEdit txtCountryNameShort;
		internal DevExpress.XtraEditors.LabelControl lbNameForm;
		internal DevExpress.XtraEditors.SimpleButton btnClose;
		internal DevExpress.XtraEditors.GroupControl GroupControl1;
		internal DevExpress.XtraEditors.LabelControl LabelControl1;
		internal DevExpress.XtraEditors.ButtonEdit txtCountryNameLong;
		internal DevExpress.XtraEditors.GroupControl GroupControl2;
		internal DevExpress.XtraEditors.LabelControl LabelControl3;
		internal DevExpress.XtraEditors.ButtonEdit txtCountryAlpha2;
		internal DevExpress.XtraEditors.LabelControl LabelControl2;
		internal DevExpress.XtraEditors.ButtonEdit txtCountryAlpha1;
		internal DevExpress.XtraEditors.LabelControl lbGrip;
	}
	
}
