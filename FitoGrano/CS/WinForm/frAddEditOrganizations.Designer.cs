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
		public partial class frAddEditOrganizations : DevExpress.XtraEditors.XtraForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frAddEditOrganizations));
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
			this.PanelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.PanelControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_MouseDown);
			this.Closing += new System.ComponentModel.CancelEventHandler(FrAddEditOrganizations_Closing);
			this.Load += new System.EventHandler(FrAddEditOrganizations_Load);
			this.PictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
			this.txtNote = new DevExpress.XtraEditors.MemoEdit();
			this.txtPhoneOrganization = new DevExpress.XtraEditors.ButtonEdit();
			this.txtPhoneOrganization.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtNameOrganization_Properties_ButtonClick);
			this.LabelControl14 = new DevExpress.XtraEditors.LabelControl();
			this.txtEmailOrganization = new DevExpress.XtraEditors.ButtonEdit();
			this.txtEmailOrganization.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtNameOrganization_Properties_ButtonClick);
			this.txtManagerOrganization = new DevExpress.XtraEditors.ButtonEdit();
			this.txtManagerOrganization.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtNameOrganization_Properties_ButtonClick);
			this.txtNameOrganization = new DevExpress.XtraEditors.ButtonEdit();
			this.txtNameOrganization.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtNameOrganization_Properties_ButtonClick);
			this.txtAddressOrganization = new DevExpress.XtraEditors.ButtonEdit();
			this.txtAddressOrganization.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtNameOrganization_Properties_ButtonClick);
			this.LabelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
			this.btnOk = new DevExpress.XtraEditors.SimpleButton();
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			this.btnClearNotes = new DevExpress.XtraEditors.SimpleButton();
			this.btnClearNotes.Click += new System.EventHandler(this.btnClearNotes_Click);
			((System.ComponentModel.ISupportInitialize) this.PanelControl1).BeginInit();
			this.PanelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.PictureEdit1.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.txtNote.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.txtPhoneOrganization.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.txtEmailOrganization.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.txtManagerOrganization.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.txtNameOrganization.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.txtAddressOrganization.Properties).BeginInit();
			this.SuspendLayout();
			//
			//PanelControl1
			//
			this.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.PanelControl1.Controls.Add(this.PictureEdit1);
			this.PanelControl1.Controls.Add(this.txtNote);
			this.PanelControl1.Controls.Add(this.txtPhoneOrganization);
			this.PanelControl1.Controls.Add(this.LabelControl14);
			this.PanelControl1.Controls.Add(this.txtEmailOrganization);
			this.PanelControl1.Controls.Add(this.txtManagerOrganization);
			this.PanelControl1.Controls.Add(this.txtNameOrganization);
			this.PanelControl1.Controls.Add(this.txtAddressOrganization);
			this.PanelControl1.Controls.Add(this.LabelControl6);
			this.PanelControl1.Controls.Add(this.LabelControl5);
			this.PanelControl1.Controls.Add(this.LabelControl4);
			this.PanelControl1.Controls.Add(this.LabelControl3);
			this.PanelControl1.Controls.Add(this.LabelControl2);
			this.PanelControl1.Controls.Add(this.LabelControl1);
			this.PanelControl1.Controls.Add(this.btnCancel);
			this.PanelControl1.Controls.Add(this.btnOk);
			this.PanelControl1.Controls.Add(this.btnClearNotes);
			this.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PanelControl1.Location = new System.Drawing.Point(0, 0);
			this.PanelControl1.Name = "PanelControl1";
			this.PanelControl1.Size = new System.Drawing.Size(606, 290);
			this.PanelControl1.TabIndex = 49;
			//
			//PictureEdit1
			//
			this.PictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
			this.PictureEdit1.EditValue = resources.GetObject("PictureEdit1.EditValue");
			this.PictureEdit1.Location = new System.Drawing.Point(28, 223);
			this.PictureEdit1.Name = "PictureEdit1";
			this.PictureEdit1.Properties.AllowFocused = false;
			this.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.PictureEdit1.Properties.Appearance.Options.UseBackColor = true;
			this.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.PictureEdit1.Properties.ShowMenu = false;
			this.PictureEdit1.Properties.ShowZoomSubMenu = DevExpress.Utils.DefaultBoolean.False;
			this.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
			this.PictureEdit1.Size = new System.Drawing.Size(43, 43);
			this.PictureEdit1.TabIndex = 8;
			//
			//txtNote
			//
			this.txtNote.EditValue = "";
			this.txtNote.EnterMoveNextControl = true;
			this.txtNote.Location = new System.Drawing.Point(28, 181);
			this.txtNote.Name = "txtNote";
			this.txtNote.Properties.MaxLength = 500;
			this.txtNote.Size = new System.Drawing.Size(554, 36);
			this.txtNote.TabIndex = 6;
			this.txtNote.Tag = "";
			//
			//txtPhoneOrganization
			//
			this.txtPhoneOrganization.EnterMoveNextControl = true;
			this.txtPhoneOrganization.Location = new System.Drawing.Point(321, 136);
			this.txtPhoneOrganization.Name = "txtPhoneOrganization";
			this.txtPhoneOrganization.Properties.AutoHeight = false;
			EditorButtonImageOptions1.Image = (System.Drawing.Image) (resources.GetObject("EditorButtonImageOptions1.Image"));
			this.txtPhoneOrganization.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "txtPhoneOrganization", -1, true, true, false, EditorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "Очистить поле", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
			this.txtPhoneOrganization.Properties.ContextImageOptions.Image = (System.Drawing.Image) (resources.GetObject("txtPhoneOrganization.Properties.ContextImageOptions.Image"));
			this.txtPhoneOrganization.Size = new System.Drawing.Size(261, 20);
			this.txtPhoneOrganization.TabIndex = 5;
			//
			//LabelControl14
			//
			this.LabelControl14.Appearance.Options.UseTextOptions = true;
			this.LabelControl14.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.LabelControl14.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.LabelControl14.Cursor = System.Windows.Forms.Cursors.Default;
			this.LabelControl14.LineVisible = true;
			this.LabelControl14.Location = new System.Drawing.Point(28, 111);
			this.LabelControl14.Name = "LabelControl14";
			this.LabelControl14.Size = new System.Drawing.Size(554, 13);
			this.LabelControl14.TabIndex = 0;
			this.LabelControl14.Tag = "0";
			this.LabelControl14.Text = " Контактные данные";
			//
			//txtEmailOrganization
			//
			this.txtEmailOrganization.EnterMoveNextControl = true;
			this.txtEmailOrganization.Location = new System.Drawing.Point(71, 136);
			this.txtEmailOrganization.Name = "txtEmailOrganization";
			this.txtEmailOrganization.Properties.AutoHeight = false;
			EditorButtonImageOptions2.Image = (System.Drawing.Image) (resources.GetObject("EditorButtonImageOptions2.Image"));
			this.txtEmailOrganization.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "txtEmailOrganization", -1, true, true, false, EditorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "Очистить поле", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
			this.txtEmailOrganization.Properties.ContextImageOptions.Image = (System.Drawing.Image) (resources.GetObject("txtEmailOrganization.Properties.ContextImageOptions.Image"));
			this.txtEmailOrganization.Size = new System.Drawing.Size(180, 20);
			this.txtEmailOrganization.TabIndex = 4;
			//
			//txtManagerOrganization
			//
			this.txtManagerOrganization.EnterMoveNextControl = true;
			this.txtManagerOrganization.Location = new System.Drawing.Point(150, 75);
			this.txtManagerOrganization.Name = "txtManagerOrganization";
			this.txtManagerOrganization.Properties.AutoHeight = false;
			EditorButtonImageOptions3.Image = (System.Drawing.Image) (resources.GetObject("EditorButtonImageOptions3.Image"));
			this.txtManagerOrganization.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "txtManagerOrganization", -1, true, true, false, EditorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject9, SerializableAppearanceObject10, SerializableAppearanceObject11, SerializableAppearanceObject12, "Очистить поле", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
			this.txtManagerOrganization.Properties.ContextImageOptions.Image = (System.Drawing.Image) (resources.GetObject("txtManagerOrganization.Properties.ContextImageOptions.Image"));
			this.txtManagerOrganization.Size = new System.Drawing.Size(432, 20);
			this.txtManagerOrganization.TabIndex = 3;
			//
			//txtNameOrganization
			//
			this.txtNameOrganization.EnterMoveNextControl = true;
			this.txtNameOrganization.Location = new System.Drawing.Point(150, 23);
			this.txtNameOrganization.Name = "txtNameOrganization";
			this.txtNameOrganization.Properties.AutoHeight = false;
			EditorButtonImageOptions4.Image = (System.Drawing.Image) (resources.GetObject("EditorButtonImageOptions4.Image"));
			this.txtNameOrganization.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "txtNameOrganization", -1, true, true, false, EditorButtonImageOptions4, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject13, SerializableAppearanceObject14, SerializableAppearanceObject15, SerializableAppearanceObject16, "Очистить поле", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
			this.txtNameOrganization.Properties.ContextImageOptions.Image = (System.Drawing.Image) (resources.GetObject("txtNameOrganization.Properties.ContextImageOptions.Image"));
			this.txtNameOrganization.Properties.MaxLength = 150;
			this.txtNameOrganization.Size = new System.Drawing.Size(432, 20);
			this.txtNameOrganization.TabIndex = 1;
			//
			//txtAddressOrganization
			//
			this.txtAddressOrganization.EnterMoveNextControl = true;
			this.txtAddressOrganization.Location = new System.Drawing.Point(150, 49);
			this.txtAddressOrganization.Name = "txtAddressOrganization";
			this.txtAddressOrganization.Properties.AutoHeight = false;
			EditorButtonImageOptions5.Image = (System.Drawing.Image) (resources.GetObject("EditorButtonImageOptions5.Image"));
			this.txtAddressOrganization.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "txtAddressOrganization", -1, true, true, false, EditorButtonImageOptions5, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject17, SerializableAppearanceObject18, SerializableAppearanceObject19, SerializableAppearanceObject20, "Очистить поле", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
			this.txtAddressOrganization.Properties.ContextImageOptions.Image = (System.Drawing.Image) (resources.GetObject("txtAddressOrganization.Properties.ContextImageOptions.Image"));
			this.txtAddressOrganization.Properties.MaxLength = 200;
			this.txtAddressOrganization.Size = new System.Drawing.Size(432, 20);
			this.txtAddressOrganization.TabIndex = 2;
			//
			//LabelControl6
			//
			this.LabelControl6.AllowHtmlString = true;
			this.LabelControl6.Location = new System.Drawing.Point(28, 166);
			this.LabelControl6.Name = "LabelControl6";
			this.LabelControl6.Size = new System.Drawing.Size(74, 13);
			this.LabelControl6.TabIndex = 0;
			this.LabelControl6.Text = "<u> Комментарий:</u>";
			//
			//LabelControl5
			//
			this.LabelControl5.AllowHtmlString = true;
			this.LabelControl5.Location = new System.Drawing.Point(259, 137);
			this.LabelControl5.Name = "LabelControl5";
			this.LabelControl5.Size = new System.Drawing.Size(56, 13);
			this.LabelControl5.TabIndex = 0;
			this.LabelControl5.Text = "<u>Телефоны:</u>";
			//
			//LabelControl4
			//
			this.LabelControl4.AllowHtmlString = true;
			this.LabelControl4.Location = new System.Drawing.Point(28, 137);
			this.LabelControl4.Name = "LabelControl4";
			this.LabelControl4.Size = new System.Drawing.Size(37, 13);
			this.LabelControl4.TabIndex = 0;
			this.LabelControl4.Text = "<color=red>*</color><u> Email:</u>";
			//
			//LabelControl3
			//
			this.LabelControl3.AllowHtmlString = true;
			this.LabelControl3.Location = new System.Drawing.Point(28, 78);
			this.LabelControl3.Name = "LabelControl3";
			this.LabelControl3.Size = new System.Drawing.Size(112, 13);
			this.LabelControl3.TabIndex = 0;
			this.LabelControl3.Text = "<color=red>*</color><u> ФИО руководителя:</u>";
			//
			//LabelControl2
			//
			this.LabelControl2.AllowHtmlString = true;
			this.LabelControl2.Location = new System.Drawing.Point(28, 52);
			this.LabelControl2.Name = "LabelControl2";
			this.LabelControl2.Size = new System.Drawing.Size(116, 13);
			this.LabelControl2.TabIndex = 0;
			this.LabelControl2.Text = "<color=red>*</color><u> Юридический адрес:</u>";
			//
			//LabelControl1
			//
			this.LabelControl1.AllowHtmlString = true;
			this.LabelControl1.Location = new System.Drawing.Point(28, 26);
			this.LabelControl1.Name = "LabelControl1";
			this.LabelControl1.Size = new System.Drawing.Size(86, 13);
			this.LabelControl1.TabIndex = 0;
			this.LabelControl1.Text = "<color=red>*</color><u> Наименование:</u>";
			//
			//btnCancel
			//
			this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnCancel.ImageOptions.Image"));
			this.btnCancel.Location = new System.Drawing.Point(505, 240);
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
			this.btnOk.Location = new System.Drawing.Point(422, 240);
			this.btnOk.Name = "btnOk";
			this.btnOk.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
			this.btnOk.Size = new System.Drawing.Size(77, 26);
			this.btnOk.TabIndex = 7;
			this.btnOk.Tag = "11";
			this.btnOk.Text = "OK";
			//
			//btnClearNotes
			//
			this.btnClearNotes.AllowFocus = false;
			this.btnClearNotes.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
			this.btnClearNotes.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("btnClearNotes.ImageOptions.Image"));
			this.btnClearNotes.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
			this.btnClearNotes.Location = new System.Drawing.Point(102, 161);
			this.btnClearNotes.Name = "btnClearNotes";
			this.btnClearNotes.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
			this.btnClearNotes.Size = new System.Drawing.Size(22, 22);
			this.btnClearNotes.TabIndex = 0;
			this.btnClearNotes.ToolTip = "Очистить поле";
			//
			//frAddEditOrganizations
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(606, 290);
			this.Controls.Add(this.PanelControl1);
			this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frAddEditOrganizations";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "frAddEditSubOrganizations";
			((System.ComponentModel.ISupportInitialize) this.PanelControl1).EndInit();
			this.PanelControl1.ResumeLayout(false);
			this.PanelControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.PictureEdit1.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.txtNote.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.txtPhoneOrganization.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.txtEmailOrganization.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.txtManagerOrganization.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.txtNameOrganization.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.txtAddressOrganization.Properties).EndInit();
			this.ResumeLayout(false);
			
		}
		internal DevExpress.XtraEditors.SimpleButton btnCancel;
		internal DevExpress.XtraEditors.SimpleButton btnOk;
		internal DevExpress.XtraEditors.PanelControl PanelControl1;
		internal DevExpress.XtraEditors.LabelControl LabelControl1;
		internal DevExpress.XtraEditors.LabelControl LabelControl5;
		internal DevExpress.XtraEditors.LabelControl LabelControl4;
		internal DevExpress.XtraEditors.LabelControl LabelControl3;
		internal DevExpress.XtraEditors.LabelControl LabelControl2;
		internal DevExpress.XtraEditors.LabelControl LabelControl6;
		internal DevExpress.XtraEditors.ButtonEdit txtAddressOrganization;
		internal DevExpress.XtraEditors.ButtonEdit txtManagerOrganization;
		internal DevExpress.XtraEditors.ButtonEdit txtNameOrganization;
		internal DevExpress.XtraEditors.ButtonEdit txtEmailOrganization;
		internal DevExpress.XtraEditors.LabelControl LabelControl14;
		internal DevExpress.XtraEditors.ButtonEdit txtPhoneOrganization;
		internal DevExpress.XtraEditors.MemoEdit txtNote;
		internal DevExpress.XtraEditors.SimpleButton btnClearNotes;
		internal DevExpress.XtraEditors.PictureEdit PictureEdit1;
	}
	
}
