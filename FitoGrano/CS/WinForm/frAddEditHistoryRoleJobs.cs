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

using System.ComponentModel;
using System.Data;
using FitoGrano;

namespace FitoGrano
{
	
	public partial class frAddEditHistoryRoleJobs
	{
		public frAddEditHistoryRoleJobs()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frAddEditHistoryRoleJobs defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frAddEditHistoryRoleJobs Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frAddEditHistoryRoleJobs();
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
		internal int AddEdit = 2;
		DataRow iRowCurrent;
		// Таскание формы за любой участок
		public void Control_MouseDown(dynamic sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == System.Windows.Forms.MouseButtons.Left)
			{
				this.Cursor = Cursors.NoMove2D;
				sender.Capture = false;
				Windows.Forms.Message temp_msg = Message.Create(this.Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
				this.WndProc(ref temp_msg);
				this.Cursor = Cursors.Default;
			}
		}
		// Закрытие формы
		public void frAddEditHistoryRoleJobs_FormClosing(object sender, FormClosingEventArgs e)
		{
			clsMyUserFunction.RemoveTableDataSet(this);
		}
		// загрузка формы
		public void frAddEditHistoryRoleJobs_Load(object sender, EventArgs e)
		{
			mdVariables.EventChangedControl = false;
			if (AddEdit == 3)
			{
				this.lbNameForm.Text = "Редактировать должности сотрудника";
			}
			this.Location = MousePosition;
			this.txtDtBegin.EditValue = DateTime.Now;
			this.txtDtBegin.Select();
			// дерево должностей
			clsOrganizationStructure RoleJobsFilial = new clsOrganizationStructure() {
					sender = this.cmbRoleJobsFilial.Properties.TreeList,
					TableName = "tlRoleJobsFilial." + this.Name
				};
			this.cmbRoleJobsFilial.Properties.DisplayMember = "RoleJobsString";
			this.cmbRoleJobsFilial.Properties.ValueMember = "Id";
			RoleJobsFilial.GetOrganizationStructure(ExpandedRoot: 1, OnlyCurentFillial: "1");
			tlRoleJobsFilial.NodeCellStyle += RoleJobsFilial.NodeCellStyle;
			// если новая запись выходим из процедуры
			if (AddEdit == 2)
			{
				mdVariables.EventChangedControl = true;
				return;
			}
			// текущая строка в таблице
			iRowCurrent = mdQuery.iDataSet.Tables["HistoryRoleJobs." + frAddEditPerformer.Default.Name].Rows[frAddEditPerformer.Default.gvHistoryRoleJobs.FocusedRowHandle];
			this.cmbRoleJobsFilial.EditValue = iRowCurrent["RoleJobsId"];
			this.txtDtBegin.EditValue = iRowCurrent["DtChange"];
			this.tlRoleJobsFilial.FocusedNode = this.tlRoleJobsFilial.FindNodeByKeyID(iRowCurrent["RoleJobsId"]);
			mdVariables.EventChangedControl = true;
		}
		// отмена закрытия выпадающего дерева
		public void cmbRoleJobsFilial_QueryCloseUp(dynamic sender, CancelEventArgs e)
		{
			if (ReferenceEquals(sender.Properties.TreeList.FocusedNode, null))
			{
				return;
			}
			// выбираем только должность
			e.Cancel = sender.Properties.TreeList.FocusedNode("Level") != 3;
		}
		// событие проверки корректности даты
		public void txtDtBegin_Properties_Validating(dynamic sender, CancelEventArgs e)
		{
			if (CheckingDtBegin())
			{
				sender.ErrorText = null;
				this.btnOk.Enabled = true;
			}
			else
			{
				this.txtDtBegin.Focus();
				this.txtDtBegin.SelectAll();
				this.txtDtBegin.ErrorText = "Указанная дата уже присутствует в истории ...";
				this.btnOk.Enabled = false;
			}
		}
		// событие изменения даты
		public void txtDtBegin_EditValueChanged(object sender, EventArgs e)
		{
			if (mdVariables.EventChangedControl == false)
			{
				return;
			}
			txtDtBegin_Properties_Validating(sender, new CancelEventArgs());
		}
		// Проверка уникальности даты
		private bool CheckingDtBegin()
		{
			DataTable dt = mdQuery.iDataSet.Tables["HistoryRoleJobs." + frAddEditPerformer.Default.Name];
			DateTime dt_NewValue = System.Convert.ToDateTime(this.txtDtBegin.EditValue); // введенная дата
			DateTime dt_dsValue; // дата из таблицы для сравнения
			DateTime dt_dsCurValue; // выбранная дата в таблице
			// если редактирование
			if (AddEdit == 3)
			{
				// сравниваем новую и редактируемую дату
				dt_dsCurValue = System.Convert.ToDateTime(iRowCurrent["DtChange"]);
				if (dt_dsCurValue.ToShortDateString() == dt_NewValue.ToShortDateString())
				{
					return true;
				}
			}
			// проходим по таблице в поисках совпадения
			foreach (DataRow r in dt.Rows)
			{
				if (Information.IsDBNull(r["DtChange"]))
				{
					continue;
				}
				dt_dsValue = System.Convert.ToDateTime(r["DtChange"]);
				// если совпадение найдено
				if (dt_dsValue.ToShortDateString() == dt_NewValue.ToShortDateString())
				{
					return false;
				}
			}
			return true;
		}
		// проверка назначения должности
		private bool CheckingRoleJobs()
		{
			if (clsForSQL.InDataBase(this.cmbRoleJobsFilial.EditValue) == "NULL")
			{
				this.cmbRoleJobsFilial.ErrorText = "Должность не назначена ...";
				this.btnOk.Enabled = false;
				return false;
			}
			else
			{
				this.cmbRoleJobsFilial.ErrorText = null;
				this.btnOk.Enabled = true;
				return true;
			}
		}
		// Ок
		public void btnOk_Click(object sender, EventArgs e)
		{
			if (CheckingRoleJobs() == false)
			{
				return; // проверка назначения должности
			}
			if (ExecuteScalar(
					EXEC PerformersHistoryRJFuction
					@PerformerId == " & frAddEditPerformer.PerformerId & ",
					@DtChange == " & clsForSQL.InDataBase(Me.txtDtBegin.Text) & ",
					@DtChangeOld == " & If(AddEdit = 2, " NULL ", clsForSQL.InDataBase(iRowCurrent(" DtChange "), " DateTime ")) & ",
					@RoleJobsId == " & Me.cmbRoleJobsFilial.EditValue & ",
					@Function == & AddEdit,
					"SetRoleJob"
					) == 1)
					{
					// передача даты новой записи
					frAddEditPerformer.Default.NewRecord_HistoryRoleJobs = DateTime.Parse(this.txtDtBegin.Text);
				this.DialogResult = DialogResult.OK;
			}
		}
		// отмена
		public void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}
		// событие изменения должности
		public void cmbRoleJobsFvilial_EditValueChanged(object sender, EventArgs e)
		{
			CheckingRoleJobs();
		}
	}
}
