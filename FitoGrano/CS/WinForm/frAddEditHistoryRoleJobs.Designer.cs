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
	partial class frAddEditHistoryRoleJobs : DevExpress.XtraEditors.XtraForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frAddEditHistoryRoleJobs));
			DevExpress.XtraEditors.Controls.EditorButtonImageOptions EditorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject SerializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
			this.PanelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.PanelControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_MouseDown);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(frAddEditHistoryRoleJobs_FormClosing);
			this.Load += new System.EventHandler(frAddEditHistoryRoleJobs_Load);
			this.lbNameForm = new DevExpress.XtraEditors.LabelControl();
			this.lbNameForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_MouseDown);
			this.btnClose = new DevExpress.XtraEditors.SimpleButton();
			this.btnClose.Click += new System.EventHandler(this.frAddEditHistoryRoleJobs_FormClosing);
			this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			this.btnOk = new DevExpress.XtraEditors.SimpleButton();
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.cmbRoleJobsFilial = new DevExpress.XtraEditors.TreeListLookUpEdit();
			this.cmbRoleJobsFilial.QueryCloseUp += new System.ComponentModel.CancelEventHandler(this.cmbRoleJobsFilial_QueryCloseUp);
			this.cmbRoleJobsFilial.EditValueChanged += new System.EventHandler(this.cmbRoleJobsFvilial_EditValueChanged);
			this.tlRoleJobsFilial = new DevExpress.XtraTreeList.TreeList();
			this.LabelControl8 = new DevExpress.XtraEditors.LabelControl();
			this.txtDtBegin = new DevExpress.XtraEditors.DateEdit();
			this.txtDtBegin.Properties.Validating += new System.ComponentModel.CancelEventHandler(this.txtDtBegin_Properties_Validating);
			this.txtDtBegin.EditValueChanged += new System.EventHandler(this.txtDtBegin_EditValueChanged);
			((System.ComponentModel.ISupportInitialize) this.PanelControl1).BeginInit();
			this.PanelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.cmbRoleJobsFilial.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.tlRoleJobsFilial).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.txtDtBegin.Properties.CalendarTimeProperties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.txtDtBegin.Properties).BeginInit();
			this.SuspendLayout();
			//
			//PanelControl1
			//
			this.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.PanelControl1.Controls.Add(this.lbNameForm);
			this.PanelControl1.Controls.Add(this.btnClose);
			this.PanelControl1.Controls.Add(this.btnCancel);
			this.PanelControl1.Controls.Add(this.btnOk);
			this.PanelControl1.Controls.Add(this.LabelControl1);
			this.PanelControl1.Controls.Add(this.cmbRoleJobsFilial);
			this.PanelControl1.Controls.Add(this.LabelControl8);
			this.PanelControl1.Controls.Add(this.txtDtBegin);
			this.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PanelControl1.Location = new System.Drawing.Point(0, 0);
			this.PanelControl1.Name = "PanelControl1";
			this.PanelControl1.Size = new System.Drawing.Size(489, 203);
			this.PanelControl1.TabIndex = 0;
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
			this.lbNameForm.Location = new System.Drawing.Point(12, 9);
			this.lbNameForm.Name = "lbNameForm";
			this.lbNameForm.Size = new System.Drawing.Size(241, 20);
			this.lbNameForm.TabIndex = 16;
			this.lbNameForm.Text = "Присвоить должность сотруднику";
			//
			//btnClose
			//
			this.btnClose.AllowFocus = false;
			this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			this.btnClose.AutoSize = true;
			this.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.ImageOptions.ImageUri.Uri = "Delete;Size16x16;Office2013";
			this.btnClose.Location = new System.Drawing.Point(460, 5);
			this.btnClose.Name = "btnClose";
			this.btnClose.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
			this.btnClose.Size = new System.Drawing.Size(24, 22);
			this.btnClose.TabIndex = 15;
			//
			//btnCancel
			//
			this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnCancel.ImageOptions.Image"));
			this.btnCancel.Location = new System.Drawing.Point(382, 157);
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
			this.btnOk.Location = new System.Drawing.Point(299, 157);
			this.btnOk.Name = "btnOk";
			this.btnOk.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
			this.btnOk.Size = new System.Drawing.Size(77, 26);
			this.btnOk.TabIndex = 3;
			this.btnOk.Tag = "11";
			this.btnOk.Text = "OK";
			//
			//LabelControl1
			//
			this.LabelControl1.AllowHtmlString = true;
			this.LabelControl1.Location = new System.Drawing.Point(24, 97);
			this.LabelControl1.Name = "LabelControl1";
			this.LabelControl1.Size = new System.Drawing.Size(136, 13);
			this.LabelControl1.TabIndex = 0;
			this.LabelControl1.Tag = "0";
			this.LabelControl1.Text = "<u>Наименование должности:</u>";
			//
			//cmbRoleJobsFilial
			//
			this.cmbRoleJobsFilial.EnterMoveNextControl = true;
			this.cmbRoleJobsFilial.Location = new System.Drawing.Point(24, 116);
			this.cmbRoleJobsFilial.Name = "cmbRoleJobsFilial";
			this.cmbRoleJobsFilial.Properties.AllowFocused = false;
			this.cmbRoleJobsFilial.Properties.Appearance.Options.UseTextOptions = true;
			this.cmbRoleJobsFilial.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
			this.cmbRoleJobsFilial.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.cmbRoleJobsFilial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cmbRoleJobsFilial.Properties.ContextImageOptions.Image = (System.Drawing.Image) (resources.GetObject("cmbRoleJobsFilial.Properties.ContextImageOptions.Image"));
			this.cmbRoleJobsFilial.Properties.NullText = "[Должность не выбрана]";
			this.cmbRoleJobsFilial.Properties.TreeList = this.tlRoleJobsFilial;
			this.cmbRoleJobsFilial.Size = new System.Drawing.Size(435, 20);
			this.cmbRoleJobsFilial.TabIndex = 2;
			//
			//tlRoleJobsFilial
			//
			this.tlRoleJobsFilial.Location = new System.Drawing.Point(0, 0);
			this.tlRoleJobsFilial.Name = "tlRoleJobsFilial";
			this.tlRoleJobsFilial.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
			this.tlRoleJobsFilial.OptionsBehavior.Editable = false;
			this.tlRoleJobsFilial.OptionsMenu.EnableColumnMenu = false;
			this.tlRoleJobsFilial.OptionsMenu.EnableFooterMenu = false;
			this.tlRoleJobsFilial.OptionsMenu.ShowAutoFilterRowItem = false;
			this.tlRoleJobsFilial.OptionsNavigation.AutoMoveRowFocus = true;
			this.tlRoleJobsFilial.OptionsSelection.SelectNodesOnRightClick = true;
			this.tlRoleJobsFilial.OptionsView.ShowColumns = false;
			this.tlRoleJobsFilial.OptionsView.ShowHorzLines = false;
			this.tlRoleJobsFilial.OptionsView.ShowIndentAsRowStyle = true;
			this.tlRoleJobsFilial.OptionsView.ShowIndicator = false;
			this.tlRoleJobsFilial.OptionsView.ShowVertLines = false;
			this.tlRoleJobsFilial.Size = new System.Drawing.Size(400, 200);
			this.tlRoleJobsFilial.TabIndex = 0;
			//
			//LabelControl8
			//
			this.LabelControl8.AllowHtmlString = true;
			this.LabelControl8.Location = new System.Drawing.Point(24, 58);
			this.LabelControl8.Name = "LabelControl8";
			this.LabelControl8.Size = new System.Drawing.Size(160, 13);
			this.LabelControl8.TabIndex = 0;
			this.LabelControl8.Tag = "0";
			this.LabelControl8.Text = "<u>Дата вступления в должность:</u>";
			//
			//txtDtBegin
			//
			this.txtDtBegin.EditValue = null;
			this.txtDtBegin.EnterMoveNextControl = true;
			this.txtDtBegin.Location = new System.Drawing.Point(190, 57);
			this.txtDtBegin.Name = "txtDtBegin";
			this.txtDtBegin.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
			this.txtDtBegin.Properties.AutoHeight = false;
			EditorButtonImageOptions1.Image = (System.Drawing.Image) (resources.GetObject("EditorButtonImageOptions1.Image"));
			this.txtDtBegin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, EditorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
			this.txtDtBegin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtDtBegin.Size = new System.Drawing.Size(158, 20);
			this.txtDtBegin.TabIndex = 1;
			this.txtDtBegin.Tag = "7";
			//
			//frAddEditHistoryRoleJobs
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(489, 203);
			this.Controls.Add(this.PanelControl1);
			this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frAddEditHistoryRoleJobs";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "frAddEditHistoryRoleJobs";
			((System.ComponentModel.ISupportInitialize) this.PanelControl1).EndInit();
			this.PanelControl1.ResumeLayout(false);
			this.PanelControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.cmbRoleJobsFilial.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.tlRoleJobsFilial).EndInit();
			((System.ComponentModel.ISupportInitialize) this.txtDtBegin.Properties.CalendarTimeProperties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.txtDtBegin.Properties).EndInit();
			this.ResumeLayout(false);
			
		}
		
		internal DevExpress.XtraEditors.PanelControl PanelControl1;
		internal DevExpress.XtraEditors.DateEdit txtDtBegin;
		internal DevExpress.XtraEditors.LabelControl LabelControl8;
		internal DevExpress.XtraEditors.LabelControl LabelControl1;
		internal DevExpress.XtraEditors.TreeListLookUpEdit cmbRoleJobsFilial;
		internal DevExpress.XtraTreeList.TreeList tlRoleJobsFilial;
		internal DevExpress.XtraEditors.SimpleButton btnClose;
		internal DevExpress.XtraEditors.SimpleButton btnCancel;
		internal DevExpress.XtraEditors.SimpleButton btnOk;
		internal DevExpress.XtraEditors.LabelControl lbNameForm;
	}
	
}
