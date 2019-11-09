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

using System.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using FitoGrano;

namespace FitoGrano
{
	
	public partial class frSecurityUsers
	{
		public frSecurityUsers()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frSecurityUsers defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frSecurityUsers Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frSecurityUsers();
					defaultInstance.FormClosed += new System.Windows.Forms.FormClosedEventHandler(defaultInstance_FormClosed);
				}
				
				return defaultInstance;
			}
			set
			{
				defaultInstance = value;
			}
		}
		
		static void defaultInstance_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
		{
			defaultInstance = null;
		}
		
#endregion
		internal string NewRecord_PerformeId;
		
		// закрытие формы
		public void frSecurityUsers_FormClosing(object sender, FormClosingEventArgs e)
		{
			clsMyUserFunction.RemoveTableDataSet(this);
		}
		// загрузка формы
		public void frSecurityUsers_Load(System.Object sender, System.EventArgs e)
		{
			this.lbServerName.Caption = mdVariables.pref_ServerIP;
			this.lbDB_name.Caption = mdVariables.pref_DataBaseName;
			DesignerPerformers();
			//gvPerformers_RowCellClick(Me.gvPerformers, Nothing)
		}
		
#region Дизайнеры
		// дизайнер исполнителей
		private void DesignerPerformers()
		{
			mdVariables.EventChangedControl = false;
			mdQuery.SelectQueryData("Performers." + this.Name, "EXEC PerformersFunctions @Function = 1");
			if (ReferenceEquals(this.gcPerformers.DataSource, null))
			{
				this.gcPerformers.DataSource = mdQuery.iDataSet.Tables["Performers." + this.Name];
				mdHidenAllColumns.HidenAllColumns_Grid(this.gvPerformers, mdQuery.iDataSet.Tables["Performers." + this.Name]);
				this.gvPerformers.Columns["RolesJobShort"].Visible = true;
				this.gvPerformers.Columns["RolesJobShort"].Caption = "Должность";
				this.gvPerformers.Columns["SNP"].Visible = true;
				this.gvPerformers.Columns["SNP"].Caption = "ФИО";
			}
			mdVariables.EventChangedControl = true;
			this.gvPerformers.BestFitColumns();
			this.gvPerformers.FocusedRowHandle = this.gvPerformers.LocateByValue("PerformerId", System.Convert.ToInt32(NewRecord_PerformeId));
		}
		// дизайнер контактов пользователя
		private void DesignerPerformerContacts(ref string PerformerId)
		{
			PerformerId = clsForSQL.InDataBase(PerformerId);
			mdQuery.SelectQueryData(
				"PerformersContacts." + this.Name,
				"EXEC PerformersContactsFunction @PerformerId = " + PerformerId + ", @Function = 1",
				"GetPerformersContacts"
				);
			this.lbxContacts.DataSource = mdQuery.iDataSet.Tables["PerformersContacts." + this.Name];
			this.lbxContacts.DisplayMember = "NumberString";
		}
		// Дизайнер групп пользователей
		private void DesignerPerfGroups(ref string PerformerId)
		{
			PerformerId = clsForSQL.InDataBase(PerformerId);
			mdQuery.SelectQueryData(
				"PerformersRightGroups." + this.Name, System.Convert.ToString(
				SELECT * FROM vPerformersGroups pg
				WHERE pg.PerformerId == & PerformerId,
				"GetPerformersRightGroups")
				);
			this.lbxPerfGroups.DataSource = mdQuery.iDataSet.Tables["PerformersRightGroups." + this.Name];
			this.lbxPerfGroups.DisplayMember = "Name";
			this.lbxPerfGroups.ValueMember = "Id";
		}
#endregion
		
#region События gvPerformers
		// изменение фокуса в таблиуе исполнителей
		public void gvPerformers_FocusedRowChanged(dynamic sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			DataRow iRow = sender.GetFocusedDataRow;
			if (mdVariables.EventChangedControl)
			{
				NewRecord_PerformeId = iRow["PerformerId"].ToString();
			}
			this.txtAddress.Text = iRow["Address"].ToString();
			this.gcPerformerInformation.Text = " Информация о сотруднике <u>" + iRow["SNP"].ToString() + "</u>";
			this.txtDtBirth.Text = System.Convert.ToString((!string.IsNullOrEmpty(iRow["DtBirth"].ToString())) ? (System.Convert.ToDateTime(iRow["DtBirth"].ToString()).ToShortDateString()) : "");
			this.txtRoleJob.Text = iRow["RolesJobShort"].ToString();
			this.txtRoomNumber.Text = iRow["RoomNumber"].ToString();
			this.txtSex.Text = iRow["Sex"].ToString();
			this.txtSex.Properties.ContextImageOptions.Image = (iRow["SexId"].ToString() == 0) ? global::My.Resources.Resources.SexWomen_16x16 : global::My.Resources.Resources.SexMen_16x16;
			this.txtEmail.Text = iRow["Email"].ToString();
			string temp_PerformerId = iRow["PerformerId"].ToString();
			DesignerPerformerContacts(ref temp_PerformerId);
			string temp_PerformerId2 = iRow["PerformerId"].ToString();
			DesignerPerfGroups(ref temp_PerformerId2);
		}
		// двойной клик по исполнителю
		public void gvPerformers_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
		{
			if (e.Clicks == 2 & e.Button == System.Windows.Forms.MouseButtons.Left && btnEditPerformer.Enabled)
			{
				btnEditPerformer_ItemClick(btnEditPerformer, null);
			}
			if (e.Clicks == 1)
			{
				gvPerformers_FocusedRowChanged(gvPerformers, null);
			}
		}
		// Перехват кнопки DELETE на исполнителях
		public void gvPerformers_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Delete)
			{
				btnDelPerformer_ItemClick(btnDelPerformer, null);
			}
		}
		// вызов контекстного меню на исполнителях
		public void gvPerformers_MouseDown(object sender, MouseEventArgs e)
		{
			GridView view = (GridView) sender;
			Point pt = view.GridControl.PointToClient(Control.MousePosition);
			GridHitInfo info = view.CalcHitInfo(pt);
			if (e.Button == MouseButtons.Right & e.Clicks == 1)
			{
				this.btnEditPerformer_pm.Enabled = info.InRow;
				this.btnDelPerformer_pm.Enabled = info.InRow;
				this.pmMenuPerformers.ShowPopup(MousePosition);
			}
		}
#endregion
		
#region Управление исполнителями
		// добавить исполнителя
		public void btnAddPerformer_ItemClick(System.Object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frAddEditPerformer.Default.AddOrEdit = 2;
			if (frAddEditPerformer.Default.ShowDialog() == DialogResult.OK)
			{
				DesignerPerformers();
			}
		}
		// редиктировать исполнителя
		public void btnEditPerformer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frAddEditPerformer.Default.AddOrEdit = 3;
			if (frAddEditPerformer.Default.ShowDialog() == DialogResult.OK)
			{
				DesignerPerformers();
			}
		}
		// удалить исполнителя
		public void btnDelPerformer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (XtraMessageBox.Show("Пользователь <b><u>" + this.gvPerformers.GetFocusedRowCellDisplayText("SNP") + "</u></b> будет удален." + "\n" +
					"Вы согласны?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, DefaultBoolean.True) == DialogResult.Yes)
					{
					if (ExecuteScalar(
							EXEC PerformersFunctions
							@Login == " & Me.gvPerformers.GetFocusedRowCellDisplayText(" Login ") & ",
							@Function == 4,
							"DeleteUser"
							) != "err")
							{
							DesignerPerformers();
				}
			}
		}
#endregion
		
		// контектные кнопки информации о сотруднике
		public void gcPerformerInformation_CustomButtonClick(System.Object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
		{
			int _min = 30;
			int _max = 193;
			switch (e.Button.Properties.GroupIndex)
			{
				case 0: // Статистика подключений
					break;
					
				case 2: // Свернуть / Развернуть
					if ((int) e.Button.Properties.Tag == 0) // свернуть
					{
						e.Button.Properties.Tag = 1;
						e.Button.Properties.ImageOptions.Image = global::My.Resources.Resources.down_20x20;
						this.gcPerformerInformation.Size = new Size(this.gcPerformerInformation.Size.Width, 30);
						this.tlRightsPerformer.Location = new Point(this.tlRightsPerformer.Location.X, this.tlRightsPerformer.Location.Y - (_max - _min));
						this.tlRightsPerformer.Size = new Point(this.tlRightsPerformer.Size.Width, this.tlRightsPerformer.Size.Height + (_max - _min));
					} // развернуть
					else if ((int) e.Button.Properties.Tag == 1)
					{
						e.Button.Properties.Tag = 0;
						e.Button.Properties.ImageOptions.Image = global::My.Resources.Resources.up_20x20;
						this.gcPerformerInformation.Size = new Size(this.gcPerformerInformation.Size.Width, 193);
						this.tlRightsPerformer.Location = new Point(this.tlRightsPerformer.Location.X, this.tlRightsPerformer.Location.Y + (_max - _min));
						this.tlRightsPerformer.Size = new Point(this.tlRightsPerformer.Size.Width, this.tlRightsPerformer.Size.Width - (_max - _min));
					}
					break;
			}
		}
		// таймер для активности кнопок
		public void tmChecked_Tick(object sender, EventArgs e)
		{
			int gvPerformersRowCount = this.gvPerformers.RowCount;
			
			SplitContainerControl1.Panel2.Enabled = gvPerformersRowCount != 0;
			this.btnEditPerformer.Enabled = gvPerformersRowCount != 0;
			this.btnDelPerformer.Enabled = gvPerformersRowCount != 0;
		}
		// обновить форму
		public void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			DesignerPerformers();
		}
	}
}
