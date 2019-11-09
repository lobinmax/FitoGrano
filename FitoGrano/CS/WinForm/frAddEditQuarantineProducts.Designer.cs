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
	partial class frAddEditQuarantineProducts : DevExpress.XtraEditors.XtraForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frAddEditQuarantineProducts));
			FitoGrano.ucTreeListClassificationProducts.UserControlProp UserControlProp1 = new FitoGrano.ucTreeListClassificationProducts.UserControlProp();
			this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(Control_MouseDown);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(frAddEditContact_FormClosing);
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(frAddEditCountry_MouseMove);
			this.Load += new System.EventHandler(frAddEditContact_Load);
			this.btnOk = new DevExpress.XtraEditors.SimpleButton();
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			this.lbNameForm = new DevExpress.XtraEditors.LabelControl();
			this.lbNameForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_MouseDown);
			this.lbNameForm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbNameForm_MouseUp);
			this.btnClose = new DevExpress.XtraEditors.SimpleButton();
			this.btnClose.Click += new System.EventHandler(this.btnCancel_Click);
			this.lbGrip = new DevExpress.XtraEditors.LabelControl();
			this.tlAddEditQuarantineProducts = new FitoGrano.ucTreeListClassificationProducts();
			this.SuspendLayout();
			//
			//btnCancel
			//
			this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnCancel.ImageOptions.Image"));
			this.btnCancel.Location = new System.Drawing.Point(344, 528);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
			this.btnCancel.Size = new System.Drawing.Size(77, 26);
			this.btnCancel.TabIndex = 8;
			this.btnCancel.Tag = "0";
			this.btnCancel.Text = "Отмена";
			//
			//btnOk
			//
			this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			this.btnOk.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnOk.ImageOptions.Image"));
			this.btnOk.ImageOptions.ImageIndex = 0;
			this.btnOk.Location = new System.Drawing.Point(261, 528);
			this.btnOk.Name = "btnOk";
			this.btnOk.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
			this.btnOk.Size = new System.Drawing.Size(77, 26);
			this.btnOk.TabIndex = 11;
			this.btnOk.Tag = "11";
			this.btnOk.Text = "OK";
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
			this.lbNameForm.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisWord;
			this.lbNameForm.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
			this.lbNameForm.Location = new System.Drawing.Point(12, 12);
			this.lbNameForm.Name = "lbNameForm";
			this.lbNameForm.Size = new System.Drawing.Size(234, 20);
			this.lbNameForm.TabIndex = 9;
			this.lbNameForm.Text = "Редактировать набор продукции";
			//
			//btnClose
			//
			this.btnClose.AllowFocus = false;
			this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			this.btnClose.AutoSize = true;
			this.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
			this.btnClose.ImageOptions.ImageUri.Uri = "Delete;Size16x16;Office2013";
			this.btnClose.Location = new System.Drawing.Point(397, 12);
			this.btnClose.Name = "btnClose";
			this.btnClose.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
			this.btnClose.Size = new System.Drawing.Size(24, 22);
			this.btnClose.TabIndex = 10;
			//
			//lbGrip
			//
			this.lbGrip.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			this.lbGrip.Appearance.Image = (System.Drawing.Image) (resources.GetObject("lbGrip.Appearance.Image"));
			this.lbGrip.Appearance.Options.UseImage = true;
			this.lbGrip.Enabled = false;
			this.lbGrip.Location = new System.Drawing.Point(416, 550);
			this.lbGrip.Name = "lbGrip";
			this.lbGrip.Size = new System.Drawing.Size(16, 15);
			this.lbGrip.TabIndex = 12;
			//
			//tlAddEditQuarantineProducts
			//
			this.tlAddEditQuarantineProducts.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom 
				| System.Windows.Forms.AnchorStyles.Left 
				| System.Windows.Forms.AnchorStyles.Right;
			this.tlAddEditQuarantineProducts.Location = new System.Drawing.Point(12, 38);
			this.tlAddEditQuarantineProducts.Name = "tlAddEditQuarantineProducts";
			this.tlAddEditQuarantineProducts.Size = new System.Drawing.Size(409, 484);
			this.tlAddEditQuarantineProducts.TabIndex = 13;
			UserControlProp1.btnMultiCheckingIsVisible = false;
			this.tlAddEditQuarantineProducts.UserControlProperty = UserControlProp1;
			//
			//frAddEditQuarantineProducts
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(433, 566);
			this.Controls.Add(this.tlAddEditQuarantineProducts);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.lbNameForm);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.lbGrip);
			this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximumSize = new System.Drawing.Size(644, 780);
			this.MinimumSize = new System.Drawing.Size(305, 386);
			this.Name = "frAddEditQuarantineProducts";
			this.ShowInTaskbar = false;
			this.Text = "frAddEditQuarantineObjects";
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		
		internal DevExpress.XtraEditors.SimpleButton btnCancel;
		internal DevExpress.XtraEditors.SimpleButton btnOk;
		internal DevExpress.XtraEditors.LabelControl lbNameForm;
		internal DevExpress.XtraEditors.SimpleButton btnClose;
		internal DevExpress.XtraEditors.LabelControl lbGrip;
		internal ucTreeListClassificationProducts tlAddEditQuarantineProducts;
	}
	
}
