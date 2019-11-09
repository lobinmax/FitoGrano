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
	partial class frAddEditResearchMethod : DevExpress.XtraEditors.XtraForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frAddEditResearchMethod));
			DevExpress.XtraEditors.Controls.EditorButtonImageOptions EditorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
			this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(Control_MouseDown);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(frAddEditContact_FormClosing);
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			this.Load += new System.EventHandler(frAddEditContact_Load);
			this.btnOk = new DevExpress.XtraEditors.SimpleButton();
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			this.LabelControl13 = new DevExpress.XtraEditors.LabelControl();
			this.txtMethodName = new DevExpress.XtraEditors.ButtonEdit();
			this.txtMethodName.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtMethodName_ButtonClick);
			this.lbNameForm = new DevExpress.XtraEditors.LabelControl();
			this.lbNameForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_MouseDown);
			this.btnClose = new DevExpress.XtraEditors.SimpleButton();
			this.btnClose.Click += new System.EventHandler(this.btnCancel_Click);
			this.cheIsPriority = new DevExpress.XtraEditors.CheckEdit();
			this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.txtLongDay = new DevExpress.XtraEditors.SpinEdit();
			((System.ComponentModel.ISupportInitialize) this.txtMethodName.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.cheIsPriority.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.txtLongDay.Properties).BeginInit();
			this.SuspendLayout();
			//
			//btnCancel
			//
			this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnCancel.ImageOptions.Image"));
			this.btnCancel.Location = new System.Drawing.Point(264, 183);
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
			this.btnOk.Location = new System.Drawing.Point(181, 183);
			this.btnOk.Name = "btnOk";
			this.btnOk.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
			this.btnOk.Size = new System.Drawing.Size(77, 26);
			this.btnOk.TabIndex = 4;
			this.btnOk.Tag = "11";
			this.btnOk.Text = "OK";
			//
			//LabelControl13
			//
			this.LabelControl13.AllowHtmlString = true;
			this.LabelControl13.Location = new System.Drawing.Point(12, 54);
			this.LabelControl13.Name = "LabelControl13";
			this.LabelControl13.Size = new System.Drawing.Size(200, 13);
			this.LabelControl13.TabIndex = 0;
			this.LabelControl13.Tag = "0";
			this.LabelControl13.Text = "<color=red>*</color><u> Наименование метода исследования:</u>";
			//
			//txtMethodName
			//
			this.txtMethodName.EnterMoveNextControl = true;
			this.txtMethodName.Location = new System.Drawing.Point(12, 69);
			this.txtMethodName.Name = "txtMethodName";
			EditorButtonImageOptions2.Image = (System.Drawing.Image) (resources.GetObject("EditorButtonImageOptions2.Image"));
			this.txtMethodName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, EditorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "Очистить поле", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
			this.txtMethodName.Properties.Mask.EditMask = "(\\d?\\d?\\d?) \\d\\d\\d-\\d\\d\\d\\d";
			this.txtMethodName.Properties.MaxLength = 200;
			this.txtMethodName.Size = new System.Drawing.Size(329, 22);
			this.txtMethodName.TabIndex = 1;
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
			this.lbNameForm.Size = new System.Drawing.Size(217, 20);
			this.lbNameForm.TabIndex = 0;
			this.lbNameForm.Text = "Добавить метод исследования";
			//
			//btnClose
			//
			this.btnClose.AllowFocus = false;
			this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			this.btnClose.AutoSize = true;
			this.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
			this.btnClose.ImageOptions.ImageUri.Uri = "Delete;Size16x16;Office2013";
			this.btnClose.Location = new System.Drawing.Point(317, 12);
			this.btnClose.Name = "btnClose";
			this.btnClose.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
			this.btnClose.Size = new System.Drawing.Size(24, 22);
			this.btnClose.TabIndex = 0;
			//
			//cheIsPriority
			//
			this.cheIsPriority.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
			this.cheIsPriority.EnterMoveNextControl = true;
			this.cheIsPriority.Location = new System.Drawing.Point(12, 106);
			this.cheIsPriority.Name = "cheIsPriority";
			this.cheIsPriority.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
			this.cheIsPriority.Properties.AutoWidth = true;
			this.cheIsPriority.Properties.Caption = "<color=red>*</color><u> Метод является приоритетным";
			this.cheIsPriority.Size = new System.Drawing.Size(191, 19);
			this.cheIsPriority.TabIndex = 2;
			this.cheIsPriority.ToolTip = "Выберите если пробу нужно добавить в начало";
			//
			//LabelControl1
			//
			this.LabelControl1.AllowHtmlString = true;
			this.LabelControl1.Location = new System.Drawing.Point(12, 144);
			this.LabelControl1.Name = "LabelControl1";
			this.LabelControl1.Size = new System.Drawing.Size(224, 13);
			this.LabelControl1.TabIndex = 4;
			this.LabelControl1.Tag = "0";
			this.LabelControl1.Text = "<color=red>*</color><u> Продолжительность исследования, дней:</u>";
			//
			//txtLongDay
			//
			this.txtLongDay.EditValue = new decimal(new int[] {1, 0, 0, 0});
			this.txtLongDay.EnterMoveNextControl = true;
			this.txtLongDay.Location = new System.Drawing.Point(242, 141);
			this.txtLongDay.Name = "txtLongDay";
			this.txtLongDay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtLongDay.Properties.IsFloatValue = false;
			this.txtLongDay.Properties.Mask.EditMask = "N00";
			this.txtLongDay.Properties.MaxValue = new decimal(new int[] {1000000, 0, 0, 0});
			this.txtLongDay.Properties.MinValue = new decimal(new int[] {1, 0, 0, 0});
			this.txtLongDay.Size = new System.Drawing.Size(99, 20);
			this.txtLongDay.TabIndex = 3;
			//
			//frAddEditResearchMethod
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(353, 221);
			this.Controls.Add(this.txtLongDay);
			this.Controls.Add(this.LabelControl1);
			this.Controls.Add(this.cheIsPriority);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.LabelControl13);
			this.Controls.Add(this.txtMethodName);
			this.Controls.Add(this.lbNameForm);
			this.Controls.Add(this.btnClose);
			this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frAddEditResearchMethod";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "frAddEditResearchMethod";
			((System.ComponentModel.ISupportInitialize) this.txtMethodName.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.cheIsPriority.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.txtLongDay.Properties).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		
		internal DevExpress.XtraEditors.SimpleButton btnCancel;
		internal DevExpress.XtraEditors.SimpleButton btnOk;
		internal DevExpress.XtraEditors.LabelControl LabelControl13;
		internal DevExpress.XtraEditors.ButtonEdit txtMethodName;
		internal DevExpress.XtraEditors.LabelControl lbNameForm;
		internal DevExpress.XtraEditors.SimpleButton btnClose;
		internal DevExpress.XtraEditors.CheckEdit cheIsPriority;
		internal DevExpress.XtraEditors.LabelControl LabelControl1;
		internal DevExpress.XtraEditors.SpinEdit txtLongDay;
	}
	
}
