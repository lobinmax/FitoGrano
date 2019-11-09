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
		public partial class frAddEditObjects : DevExpress.XtraEditors.XtraForm
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
			DevExpress.XtraEditors.Controls.EditorButtonImageOptions EditorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frAddEditObjects));
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.XtraEditors.Controls.EditorButtonImageOptions EditorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
			FitoGrano.ucTreeListResearchMetods.UserControlProp UserControlProp1 = new FitoGrano.ucTreeListResearchMetods.UserControlProp();
			this.LabelControl13 = new DevExpress.XtraEditors.LabelControl();
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(Control_MouseDown);
			this.LabelControl13.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_MouseDown);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(frAddEditContact_FormClosing);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(frAddEditCountry_MouseMove);
			base.Load += new System.EventHandler(frAddEditObjects_Load);
			this.txtObjectNameRU = new DevExpress.XtraEditors.ButtonEdit();
			this.txtObjectNameRU.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtProductsName_ButtonClick);
			this.lbNameForm = new DevExpress.XtraEditors.LabelControl();
			this.lbNameForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_MouseDown);
			this.lbNameForm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbNameForm_MouseUp);
			this.btnClose = new DevExpress.XtraEditors.SimpleButton();
			this.btnClose.Click += new System.EventHandler(this.btnCancel_Click);
			this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_MouseDown);
			this.txtObjectNameLAT = new DevExpress.XtraEditors.ButtonEdit();
			this.txtObjectNameLAT.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtProductsName_ButtonClick);
			this.lbGrip = new DevExpress.XtraEditors.LabelControl();
			this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			this.btnOk = new DevExpress.XtraEditors.SimpleButton();
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			this.tlResearchMetods = new FitoGrano.ucTreeListResearchMetods();
			((System.ComponentModel.ISupportInitialize) this.txtObjectNameRU.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.txtObjectNameLAT.Properties).BeginInit();
			this.SuspendLayout();
			//
			//LabelControl13
			//
			this.LabelControl13.AllowHtmlString = true;
			this.LabelControl13.Location = new System.Drawing.Point(12, 54);
			this.LabelControl13.Name = "LabelControl13";
			this.LabelControl13.Size = new System.Drawing.Size(163, 13);
			this.LabelControl13.TabIndex = 0;
			this.LabelControl13.Tag = "0";
			this.LabelControl13.Text = "<color=red>*</color><u> Наименование объкта (русс.):</u>";
			//
			//txtObjectNameRU
			//
			this.txtObjectNameRU.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left 
				| System.Windows.Forms.AnchorStyles.Right;
			this.txtObjectNameRU.EnterMoveNextControl = true;
			this.txtObjectNameRU.Location = new System.Drawing.Point(12, 69);
			this.txtObjectNameRU.Name = "txtObjectNameRU";
			EditorButtonImageOptions1.Image = (System.Drawing.Image) (resources.GetObject("EditorButtonImageOptions1.Image"));
			this.txtObjectNameRU.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, EditorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "Очистить поле", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
			this.txtObjectNameRU.Properties.Mask.EditMask = "(\\d?\\d?\\d?) \\d\\d\\d-\\d\\d\\d\\d";
			this.txtObjectNameRU.Properties.MaxLength = 300;
			this.txtObjectNameRU.Size = new System.Drawing.Size(409, 22);
			this.txtObjectNameRU.TabIndex = 1;
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
			this.lbNameForm.Size = new System.Drawing.Size(223, 20);
			this.lbNameForm.TabIndex = 0;
			this.lbNameForm.Text = "Добавить объект исследования";
			//
			//btnClose
			//
			this.btnClose.AllowFocus = false;
			this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			this.btnClose.AutoSize = true;
			this.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.ImageOptions.ImageUri.Uri = "Delete;Size16x16;Office2013";
			this.btnClose.Location = new System.Drawing.Point(397, 12);
			this.btnClose.Name = "btnClose";
			this.btnClose.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
			this.btnClose.Size = new System.Drawing.Size(24, 22);
			this.btnClose.TabIndex = 0;
			//
			//LabelControl1
			//
			this.LabelControl1.AllowHtmlString = true;
			this.LabelControl1.Location = new System.Drawing.Point(12, 98);
			this.LabelControl1.Name = "LabelControl1";
			this.LabelControl1.Size = new System.Drawing.Size(171, 13);
			this.LabelControl1.TabIndex = 0;
			this.LabelControl1.Tag = "0";
			this.LabelControl1.Text = "<color=red>*</color><u> Наименование объкта (латин.):</u>";
			//
			//txtObjectNameLAT
			//
			this.txtObjectNameLAT.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left 
				| System.Windows.Forms.AnchorStyles.Right;
			this.txtObjectNameLAT.EnterMoveNextControl = true;
			this.txtObjectNameLAT.Location = new System.Drawing.Point(12, 113);
			this.txtObjectNameLAT.Name = "txtObjectNameLAT";
			EditorButtonImageOptions2.Image = (System.Drawing.Image) (resources.GetObject("EditorButtonImageOptions2.Image"));
			this.txtObjectNameLAT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, EditorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "Очистить поле", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
			this.txtObjectNameLAT.Properties.Mask.EditMask = "(\\d?\\d?\\d?) \\d\\d\\d-\\d\\d\\d\\d";
			this.txtObjectNameLAT.Properties.MaxLength = 300;
			this.txtObjectNameLAT.Size = new System.Drawing.Size(409, 22);
			this.txtObjectNameLAT.TabIndex = 2;
			//
			//lbGrip
			//
			this.lbGrip.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			this.lbGrip.Appearance.Image = (System.Drawing.Image) (resources.GetObject("lbGrip.Appearance.Image"));
			this.lbGrip.Appearance.Options.UseImage = true;
			this.lbGrip.Enabled = false;
			this.lbGrip.Location = new System.Drawing.Point(419, 439);
			this.lbGrip.Name = "lbGrip";
			this.lbGrip.Size = new System.Drawing.Size(16, 15);
			this.lbGrip.TabIndex = 5;
			//
			//btnCancel
			//
			this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnCancel.ImageOptions.Image"));
			this.btnCancel.Location = new System.Drawing.Point(344, 419);
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
			this.btnOk.Location = new System.Drawing.Point(261, 419);
			this.btnOk.Name = "btnOk";
			this.btnOk.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
			this.btnOk.Size = new System.Drawing.Size(77, 26);
			this.btnOk.TabIndex = 3;
			this.btnOk.Tag = "11";
			this.btnOk.Text = "OK";
			//
			//tlResearchMetods
			//
			this.tlResearchMetods.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom 
				| System.Windows.Forms.AnchorStyles.Left 
				| System.Windows.Forms.AnchorStyles.Right;
			this.tlResearchMetods.Location = new System.Drawing.Point(12, 152);
			this.tlResearchMetods.Name = "tlResearchMetods";
			this.tlResearchMetods.Size = new System.Drawing.Size(409, 242);
			this.tlResearchMetods.TabIndex = 6;
			UserControlProp1.btnMultiCheckingIsVisible = false;
			this.tlResearchMetods.UserControlProperty = UserControlProp1;
			//
			//frAddEditObjects
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(438, 457);
			this.Controls.Add(this.tlResearchMetods);
			this.Controls.Add(this.LabelControl1);
			this.Controls.Add(this.txtObjectNameLAT);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.LabelControl13);
			this.Controls.Add(this.txtObjectNameRU);
			this.Controls.Add(this.lbNameForm);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.lbGrip);
			this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MinimumSize = new System.Drawing.Size(438, 457);
			this.Name = "frAddEditObjects";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "frAddEditObjects";
			((System.ComponentModel.ISupportInitialize) this.txtObjectNameRU.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.txtObjectNameLAT.Properties).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		
		internal DevExpress.XtraEditors.SimpleButton btnCancel;
		internal DevExpress.XtraEditors.SimpleButton btnOk;
		internal DevExpress.XtraEditors.LabelControl LabelControl13;
		internal DevExpress.XtraEditors.ButtonEdit txtObjectNameRU;
		internal DevExpress.XtraEditors.LabelControl lbNameForm;
		internal DevExpress.XtraEditors.SimpleButton btnClose;
		internal DevExpress.XtraEditors.LabelControl LabelControl1;
		internal DevExpress.XtraEditors.ButtonEdit txtObjectNameLAT;
		internal DevExpress.XtraEditors.LabelControl lbGrip;
		internal ucTreeListResearchMetods tlResearchMetods;
	}
	
}
