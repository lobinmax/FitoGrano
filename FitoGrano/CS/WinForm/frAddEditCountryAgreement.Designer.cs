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
	partial class frAddEditCountryAgreement : DevExpress.XtraEditors.XtraForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frAddEditCountryAgreement));
			DevExpress.XtraEditors.Controls.EditorButtonImageOptions EditorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
			this.lbNameForm = new DevExpress.XtraEditors.LabelControl();
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(Control_MouseDown);
			this.lbNameForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_MouseDown);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(frAddEditContact_FormClosing);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(frAddEditCountry_MouseMove);
			this.lbNameForm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbNameForm_MouseUp);
			this.Load += new System.EventHandler(frAddEditContact_Load);
			this.btnClose = new DevExpress.XtraEditors.SimpleButton();
			this.btnClose.Click += new System.EventHandler(this.btnCancel_Click);
			this.lbCountryName = new DevExpress.XtraEditors.LabelControl();
			this.lbCountryName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_MouseDown);
			this.lbCountryName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_MouseDown);
			this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			this.btnOk = new DevExpress.XtraEditors.SimpleButton();
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			this.txtAgreementText = new DevExpress.XtraEditors.MemoEdit();
			this.lbGrip = new DevExpress.XtraEditors.LabelControl();
			this.txtAgreementDtBegin = new DevExpress.XtraEditors.DateEdit();
			this.txtAgreementDtEnd = new DevExpress.XtraEditors.DateEdit();
			this.txtAgreementDtEnd.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtAgreementDtEnd_ButtonClick);
			this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize) this.txtAgreementText.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.txtAgreementDtBegin.Properties.CalendarTimeProperties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.txtAgreementDtBegin.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.txtAgreementDtEnd.Properties.CalendarTimeProperties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.txtAgreementDtEnd.Properties).BeginInit();
			this.SuspendLayout();
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
			this.lbNameForm.Size = new System.Drawing.Size(161, 20);
			this.lbNameForm.TabIndex = 0;
			this.lbNameForm.Text = "Добавить соглашение";
			//
			//btnClose
			//
			this.btnClose.AllowFocus = false;
			this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			this.btnClose.AutoSize = true;
			this.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
			this.btnClose.ImageOptions.ImageUri.Uri = "Delete;Size16x16;Office2013";
			this.btnClose.Location = new System.Drawing.Point(455, 12);
			this.btnClose.Name = "btnClose";
			this.btnClose.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
			this.btnClose.Size = new System.Drawing.Size(24, 22);
			this.btnClose.TabIndex = 0;
			//
			//lbCountryName
			//
			this.lbCountryName.AllowHtmlString = true;
			this.lbCountryName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left 
				| System.Windows.Forms.AnchorStyles.Right;
			this.lbCountryName.Appearance.Options.UseTextOptions = true;
			this.lbCountryName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.lbCountryName.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
			this.lbCountryName.AutoEllipsis = true;
			this.lbCountryName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.lbCountryName.LineVisible = true;
			this.lbCountryName.Location = new System.Drawing.Point(12, 55);
			this.lbCountryName.Name = "lbCountryName";
			this.lbCountryName.Size = new System.Drawing.Size(467, 13);
			this.lbCountryName.TabIndex = 0;
			this.lbCountryName.Tag = "0";
			this.lbCountryName.Text = " <image=#earth_16x16> Наименование страны";
			//
			//btnCancel
			//
			this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnCancel.ImageOptions.Image"));
			this.btnCancel.Location = new System.Drawing.Point(402, 265);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
			this.btnCancel.Size = new System.Drawing.Size(77, 26);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Tag = "0";
			this.btnCancel.Text = "Отмена";
			//
			//btnOk
			//
			this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			this.btnOk.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnOk.ImageOptions.Image"));
			this.btnOk.ImageOptions.ImageIndex = 0;
			this.btnOk.Location = new System.Drawing.Point(319, 265);
			this.btnOk.Name = "btnOk";
			this.btnOk.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
			this.btnOk.Size = new System.Drawing.Size(77, 26);
			this.btnOk.TabIndex = 4;
			this.btnOk.Tag = "11";
			this.btnOk.Text = "OK";
			//
			//txtAgreementText
			//
			this.txtAgreementText.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom 
				| System.Windows.Forms.AnchorStyles.Left 
				| System.Windows.Forms.AnchorStyles.Right;
			this.txtAgreementText.Location = new System.Drawing.Point(12, 83);
			this.txtAgreementText.Name = "txtAgreementText";
			this.txtAgreementText.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
			this.txtAgreementText.Properties.MaxLength = 500;
			this.txtAgreementText.Properties.NullText = "Введите текст соглашения ...";
			this.txtAgreementText.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtAgreementText.Size = new System.Drawing.Size(467, 102);
			this.txtAgreementText.TabIndex = 1;
			//
			//lbGrip
			//
			this.lbGrip.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			this.lbGrip.Appearance.Image = (System.Drawing.Image) (resources.GetObject("lbGrip.Appearance.Image"));
			this.lbGrip.Appearance.Options.UseImage = true;
			this.lbGrip.Enabled = false;
			this.lbGrip.Location = new System.Drawing.Point(474, 287);
			this.lbGrip.Name = "lbGrip";
			this.lbGrip.Size = new System.Drawing.Size(16, 15);
			this.lbGrip.TabIndex = 4;
			//
			//txtAgreementDtBegin
			//
			this.txtAgreementDtBegin.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			this.txtAgreementDtBegin.EditValue = null;
			this.txtAgreementDtBegin.EnterMoveNextControl = true;
			this.txtAgreementDtBegin.Location = new System.Drawing.Point(154, 201);
			this.txtAgreementDtBegin.Name = "txtAgreementDtBegin";
			this.txtAgreementDtBegin.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
			this.txtAgreementDtBegin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtAgreementDtBegin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtAgreementDtBegin.Properties.TodayDate = new DateTime(2018, 11, 26, 22, 56, 49, 0);
			this.txtAgreementDtBegin.Size = new System.Drawing.Size(123, 20);
			this.txtAgreementDtBegin.TabIndex = 2;
			//
			//txtAgreementDtEnd
			//
			this.txtAgreementDtEnd.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			this.txtAgreementDtEnd.EditValue = null;
			this.txtAgreementDtEnd.EnterMoveNextControl = true;
			this.txtAgreementDtEnd.Location = new System.Drawing.Point(154, 230);
			this.txtAgreementDtEnd.Name = "txtAgreementDtEnd";
			this.txtAgreementDtEnd.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
			EditorButtonImageOptions1.Image = (System.Drawing.Image) (resources.GetObject("EditorButtonImageOptions1.Image"));
			this.txtAgreementDtEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "btnClearAgreementDtEnd", -1, true, true, true, EditorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "Удалить дату", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
			this.txtAgreementDtEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtAgreementDtEnd.Properties.TodayDate = new DateTime(2018, 11, 26, 22, 56, 49, 0);
			this.txtAgreementDtEnd.Size = new System.Drawing.Size(123, 20);
			this.txtAgreementDtEnd.TabIndex = 3;
			//
			//LabelControl2
			//
			this.LabelControl2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			this.LabelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (8.25F), System.Drawing.FontStyle.Underline);
			this.LabelControl2.Appearance.Options.UseFont = true;
			this.LabelControl2.Location = new System.Drawing.Point(21, 233);
			this.LabelControl2.Name = "LabelControl2";
			this.LabelControl2.Size = new System.Drawing.Size(102, 13);
			this.LabelControl2.TabIndex = 0;
			this.LabelControl2.Text = "Дата прекращения:";
			//
			//LabelControl1
			//
			this.LabelControl1.AllowHtmlString = true;
			this.LabelControl1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			this.LabelControl1.Location = new System.Drawing.Point(12, 202);
			this.LabelControl1.Name = "LabelControl1";
			this.LabelControl1.Size = new System.Drawing.Size(136, 13);
			this.LabelControl1.TabIndex = 0;
			this.LabelControl1.Text = "<color=red>*</color><u> Дата вступления в силу:";
			//
			//frAddEditCountryAgreement
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(491, 303);
			this.Controls.Add(this.txtAgreementDtEnd);
			this.Controls.Add(this.LabelControl2);
			this.Controls.Add(this.txtAgreementDtBegin);
			this.Controls.Add(this.LabelControl1);
			this.Controls.Add(this.txtAgreementText);
			this.Controls.Add(this.lbCountryName);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.lbNameForm);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.lbGrip);
			this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximumSize = new System.Drawing.Size(724, 484);
			this.MinimumSize = new System.Drawing.Size(425, 264);
			this.Name = "frAddEditCountryAgreement";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "frAddEditCountryAgreement";
			((System.ComponentModel.ISupportInitialize) this.txtAgreementText.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.txtAgreementDtBegin.Properties.CalendarTimeProperties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.txtAgreementDtBegin.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.txtAgreementDtEnd.Properties.CalendarTimeProperties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.txtAgreementDtEnd.Properties).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		
		internal DevExpress.XtraEditors.SimpleButton btnCancel;
		internal DevExpress.XtraEditors.SimpleButton btnOk;
		internal DevExpress.XtraEditors.LabelControl lbNameForm;
		internal DevExpress.XtraEditors.SimpleButton btnClose;
		internal DevExpress.XtraEditors.LabelControl lbCountryName;
		internal DevExpress.XtraEditors.MemoEdit txtAgreementText;
		internal DevExpress.XtraEditors.LabelControl lbGrip;
		internal DevExpress.XtraEditors.DateEdit txtAgreementDtBegin;
		internal DevExpress.XtraEditors.DateEdit txtAgreementDtEnd;
		internal DevExpress.XtraEditors.LabelControl LabelControl2;
		internal DevExpress.XtraEditors.LabelControl LabelControl1;
	}
	
}
