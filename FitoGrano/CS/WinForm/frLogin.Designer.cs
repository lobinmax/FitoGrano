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
	public partial class frLogin : DevExpress.XtraEditors.XtraForm
	{
		
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}
		
#region Windows Form Designer generated code
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frLogin));
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
			DevExpress.Utils.SuperToolTip SuperToolTip1 = new DevExpress.Utils.SuperToolTip();
			DevExpress.Utils.ToolTipItem ToolTipItem1 = new DevExpress.Utils.ToolTipItem();
			DevExpress.Utils.ToolTipTitleItem ToolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
			this.ChB_ShowPass = new DevExpress.XtraEditors.CheckEdit();
			base.Load += new System.EventHandler(frLogin_Load);
			this.ChB_ShowPass.CheckedChanged += new System.EventHandler(this.ChB_ShowPass_CheckedChanged);
			this.FormIsShort = new DevExpress.XtraEditors.SimpleButton();
			this.FormIsShort.Click += new System.EventHandler(this.FormIsShort_Click);
			this.Cancel = new DevExpress.XtraEditors.SimpleButton();
			this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
			this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.ok = new DevExpress.XtraEditors.SimpleButton();
			this.ok.Click += new System.EventHandler(this.ok_Click);
			this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.Pass = new DevExpress.XtraEditors.TextEdit();
			this.User = new DevExpress.XtraEditors.MRUEdit();
			this.User.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ClearHistory_User);
			this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.BD = new DevExpress.XtraEditors.MRUEdit();
			this.BD.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ClearHistory_BD);
			this.Server = new DevExpress.XtraEditors.MRUEdit();
			this.Server.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ClearHistory_Server);
			this.PictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
			((System.ComponentModel.ISupportInitialize) this.ChB_ShowPass.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.Pass.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.User.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.BD.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.Server.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.PictureEdit1.Properties).BeginInit();
			this.SuspendLayout();
			//
			//ChB_ShowPass
			//
			this.ChB_ShowPass.Location = new System.Drawing.Point(255, 110);
			this.ChB_ShowPass.Name = "ChB_ShowPass";
			this.ChB_ShowPass.Properties.Caption = "Показать пароль";
			this.ChB_ShowPass.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
			this.ChB_ShowPass.Size = new System.Drawing.Size(226, 19);
			this.ChB_ShowPass.TabIndex = 25;
			//
			//FormIsShort
			//
			this.FormIsShort.Appearance.ForeColor = System.Drawing.Color.Transparent;
			this.FormIsShort.Appearance.Options.UseForeColor = true;
			this.FormIsShort.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.FormIsShort.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("FormIsShort.ImageOptions.Image"));
			this.FormIsShort.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
			this.FormIsShort.Location = new System.Drawing.Point(462, 175);
			this.FormIsShort.Name = "FormIsShort";
			this.FormIsShort.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
			this.FormIsShort.Size = new System.Drawing.Size(20, 20);
			this.FormIsShort.TabIndex = 32;
			this.FormIsShort.ToolTip = "Параметры подключения";
			//
			//Cancel
			//
			this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Cancel.Location = new System.Drawing.Point(373, 135);
			this.Cancel.Name = "Cancel";
			this.Cancel.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
			this.Cancel.Size = new System.Drawing.Size(109, 23);
			this.Cancel.TabIndex = 31;
			this.Cancel.Text = "Отмена";
			//
			//LabelControl1
			//
			this.LabelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (8.25F), System.Drawing.FontStyle.Underline);
			this.LabelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.LabelControl1.Appearance.Options.UseFont = true;
			this.LabelControl1.Appearance.Options.UseImageAlign = true;
			this.LabelControl1.Location = new System.Drawing.Point(256, 21);
			this.LabelControl1.Name = "LabelControl1";
			this.LabelControl1.Size = new System.Drawing.Size(93, 13);
			this.LabelControl1.TabIndex = 29;
			this.LabelControl1.Text = "Имя пользователя";
			//
			//ok
			//
			this.ok.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.ok.Location = new System.Drawing.Point(256, 135);
			this.ok.Name = "ok";
			this.ok.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
			this.ok.Size = new System.Drawing.Size(109, 23);
			this.ok.TabIndex = 28;
			this.ok.Text = "Войти";
			//
			//LabelControl2
			//
			this.LabelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (8.25F), System.Drawing.FontStyle.Underline);
			this.LabelControl2.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.LabelControl2.Appearance.Options.UseFont = true;
			this.LabelControl2.Appearance.Options.UseImageAlign = true;
			this.LabelControl2.Location = new System.Drawing.Point(256, 69);
			this.LabelControl2.Name = "LabelControl2";
			this.LabelControl2.Size = new System.Drawing.Size(37, 13);
			this.LabelControl2.TabIndex = 30;
			this.LabelControl2.Text = "Пароль";
			//
			//Pass
			//
			this.Pass.EditValue = "123123";
			this.Pass.Location = new System.Drawing.Point(256, 84);
			this.Pass.Name = "Pass";
			this.Pass.Properties.ContextImageOptions.Image = (System.Drawing.Image) (resources.GetObject("Pass.Properties.ContextImageOptions.Image"));
			this.Pass.Properties.PasswordChar = global::Microsoft.VisualBasic.Strings.ChrW(8226);
			this.Pass.Size = new System.Drawing.Size(226, 20);
			this.Pass.TabIndex = 27;
			//
			//User
			//
			this.User.EnterMoveNextControl = true;
			this.User.Location = new System.Drawing.Point(256, 36);
			this.User.Name = "User";
			EditorButtonImageOptions1.Image = (System.Drawing.Image) (resources.GetObject("EditorButtonImageOptions1.Image"));
			this.User.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, EditorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "Очистить историю логинов", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
			this.User.Properties.ContextImageOptions.Image = (System.Drawing.Image) (resources.GetObject("User.Properties.ContextImageOptions.Image"));
			this.User.Properties.DropDownRows = 4;
			this.User.Properties.ImmediatePopup = false;
			this.User.Properties.PopupSizeable = true;
			this.User.Properties.ValidateOnEnterKey = false;
			this.User.Size = new System.Drawing.Size(226, 22);
			this.User.TabIndex = 26;
			this.User.Tag = "";
			//
			//LabelControl3
			//
			this.LabelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (8.25F), (System.Drawing.FontStyle) ((int) (System.Drawing.FontStyle.Bold) | (int) System.Drawing.FontStyle.Italic));
			this.LabelControl3.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.LabelControl3.Appearance.Options.UseFont = true;
			this.LabelControl3.Appearance.Options.UseImageAlign = true;
			this.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.LabelControl3.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
			this.LabelControl3.LineVisible = true;
			this.LabelControl3.Location = new System.Drawing.Point(12, 174);
			this.LabelControl3.Name = "LabelControl3";
			this.LabelControl3.Size = new System.Drawing.Size(444, 22);
			this.LabelControl3.TabIndex = 33;
			this.LabelControl3.Text = "Параметры подключения к серверу";
			//
			//LabelControl4
			//
			this.LabelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (8.25F), System.Drawing.FontStyle.Underline);
			this.LabelControl4.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.LabelControl4.Appearance.Options.UseFont = true;
			this.LabelControl4.Appearance.Options.UseImageAlign = true;
			this.LabelControl4.Location = new System.Drawing.Point(256, 204);
			this.LabelControl4.Name = "LabelControl4";
			this.LabelControl4.Size = new System.Drawing.Size(69, 13);
			this.LabelControl4.TabIndex = 37;
			this.LabelControl4.Text = "База данных:";
			//
			//LabelControl5
			//
			this.LabelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (8.25F), System.Drawing.FontStyle.Underline);
			this.LabelControl5.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.LabelControl5.Appearance.Options.UseFont = true;
			this.LabelControl5.Appearance.Options.UseImageAlign = true;
			this.LabelControl5.Location = new System.Drawing.Point(15, 205);
			this.LabelControl5.Name = "LabelControl5";
			this.LabelControl5.Size = new System.Drawing.Size(70, 13);
			this.LabelControl5.TabIndex = 35;
			this.LabelControl5.Text = "SQL - Сервер:";
			//
			//BD
			//
			this.BD.Location = new System.Drawing.Point(256, 219);
			this.BD.Name = "BD";
			EditorButtonImageOptions2.Image = (System.Drawing.Image) (resources.GetObject("EditorButtonImageOptions2.Image"));
			this.BD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, EditorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "Очистить историю баз данных", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
			this.BD.Properties.ContextImageOptions.Image = (System.Drawing.Image) (resources.GetObject("BD.Properties.ContextImageOptions.Image"));
			this.BD.Properties.ImmediatePopup = false;
			this.BD.Properties.PopupFormMinSize = new System.Drawing.Size(210, 0);
			this.BD.Properties.PopupSizeable = true;
			this.BD.Properties.ValidateOnEnterKey = false;
			this.BD.Size = new System.Drawing.Size(226, 22);
			this.BD.TabIndex = 36;
			//
			//Server
			//
			this.Server.Location = new System.Drawing.Point(12, 219);
			this.Server.Name = "Server";
			EditorButtonImageOptions3.Image = (System.Drawing.Image) (resources.GetObject("EditorButtonImageOptions3.Image"));
			this.Server.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, EditorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject9, SerializableAppearanceObject10, SerializableAppearanceObject11, SerializableAppearanceObject12, "Очистить историю имен серверов", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
			this.Server.Properties.ContextImageOptions.Image = (System.Drawing.Image) (resources.GetObject("Server.Properties.ContextImageOptions.Image"));
			this.Server.Properties.ImmediatePopup = false;
			this.Server.Properties.PopupFormMinSize = new System.Drawing.Size(210, 0);
			this.Server.Properties.PopupSizeable = true;
			this.Server.Properties.ValidateOnEnterKey = false;
			this.Server.Size = new System.Drawing.Size(222, 22);
			SuperToolTip1.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
			ToolTipItem1.Text = "IP адрес сервера в формате" + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(13)) + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(10)) + "<u><b>ХХХ.ХХХ.ХХХ.ХХХ</b></u>" + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(13)) + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(10)) + "Например: 10.60.161.10" +
				"5";
			ToolTipTitleItem1.Appearance.Image = (System.Drawing.Image) (resources.GetObject("resource.Image"));
			ToolTipTitleItem1.Appearance.Options.UseImage = true;
			ToolTipTitleItem1.ImageOptions.Image = (System.Drawing.Image) (resources.GetObject("resource.Image1"));
			ToolTipTitleItem1.Text = "Подсказка";
			SuperToolTip1.Items.Add(ToolTipItem1);
			SuperToolTip1.Items.Add(ToolTipTitleItem1);
			this.Server.SuperTip = SuperToolTip1;
			this.Server.TabIndex = 34;
			//
			//PictureEdit1
			//
			this.PictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
			this.PictureEdit1.EditValue = resources.GetObject("PictureEdit1.EditValue");
			this.PictureEdit1.Location = new System.Drawing.Point(12, 12);
			this.PictureEdit1.Name = "PictureEdit1";
			this.PictureEdit1.Properties.AllowFocused = false;
			this.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.PictureEdit1.Properties.Appearance.Options.UseBackColor = true;
			this.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.PictureEdit1.Properties.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Bicubic;
			this.PictureEdit1.Properties.ShowMenu = false;
			this.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
			this.PictureEdit1.Size = new System.Drawing.Size(224, 153);
			this.PictureEdit1.TabIndex = 24;
			//
			//frLogin
			//
			this.AcceptButton = this.ok;
			this.CancelButton = this.Cancel;
			this.ClientSize = new System.Drawing.Size(493, 253);
			this.Controls.Add(this.BD);
			this.Controls.Add(this.Server);
			this.Controls.Add(this.ChB_ShowPass);
			this.Controls.Add(this.FormIsShort);
			this.Controls.Add(this.Cancel);
			this.Controls.Add(this.ok);
			this.Controls.Add(this.Pass);
			this.Controls.Add(this.User);
			this.Controls.Add(this.PictureEdit1);
			this.Controls.Add(this.LabelControl2);
			this.Controls.Add(this.LabelControl1);
			this.Controls.Add(this.LabelControl4);
			this.Controls.Add(this.LabelControl5);
			this.Controls.Add(this.LabelControl3);
			this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Добро пожаловать в FitoGrano";
			((System.ComponentModel.ISupportInitialize) this.ChB_ShowPass.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.Pass.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.User.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.BD.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.Server.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.PictureEdit1.Properties).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		internal DevExpress.XtraEditors.PictureEdit PictureEdit1;
		internal DevExpress.XtraEditors.CheckEdit ChB_ShowPass;
		internal DevExpress.XtraEditors.SimpleButton FormIsShort;
		internal DevExpress.XtraEditors.SimpleButton Cancel;
		internal DevExpress.XtraEditors.LabelControl LabelControl1;
		internal DevExpress.XtraEditors.SimpleButton ok;
		internal DevExpress.XtraEditors.LabelControl LabelControl2;
		internal DevExpress.XtraEditors.TextEdit Pass;
		internal DevExpress.XtraEditors.MRUEdit User;
		internal DevExpress.XtraEditors.LabelControl LabelControl3;
		internal DevExpress.XtraEditors.LabelControl LabelControl4;
		internal DevExpress.XtraEditors.LabelControl LabelControl5;
		internal DevExpress.XtraEditors.MRUEdit BD;
		internal DevExpress.XtraEditors.MRUEdit Server;
		
#endregion
		
	}
	
}
