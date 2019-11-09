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

using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using FitoGrano;

namespace FitoGrano
{
	
	public partial class frBooks_OrganizationStructure
	{
		public frBooks_OrganizationStructure()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frBooks_OrganizationStructure defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frBooks_OrganizationStructure Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frBooks_OrganizationStructure();
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
		clsOrganizationStructure OrganizationStructure = new clsOrganizationStructure();
		// закрытие формы
		public void frOrganizationStructure_FormClosing(object sender, FormClosingEventArgs e)
		{
			clsMyUserFunction.RemoveTableDataSet(this);
		}
		// Загрузка формы
		public void frOrganizationStructure_Load(System.Object sender, System.EventArgs e)
		{
			OrganizationStructure.sender = this.tlStructure;
			OrganizationStructure.TableName = "OrganizationStructure." + this.Name;
			tlStructure.NodeCellStyle += OrganizationStructure.NodeCellStyle;
			OrganizationStructure.GetOrganizationStructure(ExpandedRoot: 1, ExpandedFilials: 0);
			this.tlStructure.Nodes[0].Expand();
			UpdateInfoRecord(this.tlStructure.FocusedNode);
		}
		// Правой кнопкой мыши вызываем контекстное меню
		public void tlStructure_MouseClick(System.Object sender, System.Windows.Forms.MouseEventArgs e)
		{
			TreeList tl = sender;
			TreeListHitInfo hitinfo = tl.CalcHitInfo(e.Location);
			if (this.tlStructure.Nodes.Count == 0)
			{
				return;
			}
			if (e.Button == System.Windows.Forms.MouseButtons.Right)
			{
				// если меню вызвано вне строк, можно только добавить филиал
				if (hitinfo.InRowCell == false || Information.IsDBNull(this.tlStructure.FocusedNode["ParentId"]))
				{
					this.btnEditRecord.Enabled = false;
					this.btnDeleteRecord.Enabled = false;
					this.btnAddGroup.Enabled = false;
					this.btnAddRoleJob.Enabled = false;
					this.btnSetCurrentFilial.Enabled = false;
					this.btnAddFilial.Enabled = true;
					this.PopupMenu.ShowPopup(MousePosition);
				}
				else
				{
					this.btnEditRecord.Enabled = true;
					this.btnDeleteRecord.Enabled = true;
					this.btnAddFilial.Enabled = this.tlStructure.FocusedNode.Level == 0;
					this.btnAddGroup.Enabled = this.tlStructure.FocusedNode.Level == 1;
					this.btnAddRoleJob.Enabled = this.tlStructure.FocusedNode.Level == 2;
					this.btnAddMenu.Enabled = this.tlStructure.FocusedNode.Level < 3;
					this.btnSetCurrentFilial.Enabled = this.tlStructure.FocusedNode.Level == 1;
					this.PopupMenu.ShowPopup(MousePosition);
				}
			}
		}
		// событие изменения фокуса
		public void tlStructure_FocusedNodeChanged(dynamic sender, FocusedNodeChangedEventArgs e)
		{
			if (mdVariables.EventChangedControl == false)
			{
				return;
			}
			// если Root запись, отменяем фокус
			if (Information.IsDBNull(e.Node["ParentId"]))
			{
				sender.FocusedNode = e.OldNode;
				return;
			}
			UpdateInfoRecord(e.Node, e.OldNode); // обновление полей
		}
		// Для запрета перемещения на Root с помощью стрелок
		public void tlStructure_KeyUp(dynamic sender, KeyEventArgs e)
		{
			if (Information.IsDBNull(sender.FocusedNode("ParentId")))
			{
				e.Handled = true;
				sender.FocusedNode = this.tlStructure.FindNodeByKeyID(OrganizationStructure.SelectionId);
			}
		}
		// обработка горячих клавиш
		public void tlStructure_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				btnDeleteRecord_ItemClick(sender, null);
			}
			if (e.KeyCode == Keys.Enter)
			{
				btnEditRecord_ItemClick(sender, null);
			}
			if (e.KeyCode == Keys.Apps)
			{
				tlStructure_MouseClick(sender, null);
			}
		}
		// двойной клик по ветке дерева
		public void tlStructure_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			TreeList tl = sender;
			TreeListHitInfo hitinfo = tl.CalcHitInfo(e.Location);
			if (ReferenceEquals(hitinfo.Node, null))
			{
				return;
			}
			// если у ветки нет подветки и это не Root, вызываем диалог редактирования
			if (hitinfo.Node.HasChildren == false && Information.IsDBNull(hitinfo.Node["ParentId"]) == false)
			{
				btnEditRecord_ItemClick(sender, null);
			}
		}
		// добавить филиал
		public void btnAddFilial_ItemClick(System.Object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frAddEditOrganizations.Default.AddOrEdit = 2;
			if (frAddEditOrganizations.Default.ShowDialog() == DialogResult.OK)
			{
				OrganizationStructure.SelectionId = System.Convert.ToInt32(mdVariables.glNewId);
				OrganizationStructure.GetOrganizationStructure();
			}
		}
		// добавить группу
		public void btnAddGroup_ItemClick(object sender, ItemClickEventArgs e)
		{
			frAddEditOrganizationsGroup.Default.AddOrEdit = 2;
			if (frAddEditOrganizationsGroup.Default.ShowDialog() == DialogResult.OK)
			{
				OrganizationStructure.SelectionId = System.Convert.ToInt32(mdVariables.glNewId);
				OrganizationStructure.GetOrganizationStructure();
			}
		}
		// добавить должность
		public void btnAddRoleJob_ItemClick(object sender, ItemClickEventArgs e)
		{
			frAddEditOrganizationsRoleJob.Default.AddOrEdit = 2;
			if (frAddEditOrganizationsRoleJob.Default.ShowDialog() == DialogResult.OK)
			{
				OrganizationStructure.SelectionId = System.Convert.ToInt32(mdVariables.glNewId);
				OrganizationStructure.GetOrganizationStructure();
			}
		}
		// кнопка изменить
		public void btnEditRecord_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (this.tlStructure.FocusedNode != null)
			{
				switch (this.tlStructure.FocusedNode.Level)
				{
					case 1: // филиал
						frAddEditOrganizations.Default.AddOrEdit = 3;
						if (frAddEditOrganizations.Default.ShowDialog() == DialogResult.OK)
						{
							OrganizationStructure.GetOrganizationStructure();
						}
						break;
					case 2: // группа
						frAddEditOrganizationsGroup.Default.AddOrEdit = 3;
						if (frAddEditOrganizationsGroup.Default.ShowDialog() == DialogResult.OK)
						{
							OrganizationStructure.GetOrganizationStructure();
						}
						break;
					case 3: // Должность
						frAddEditOrganizationsRoleJob.Default.AddOrEdit = 3;
						if (frAddEditOrganizationsRoleJob.Default.ShowDialog() == DialogResult.OK)
						{
							OrganizationStructure.GetOrganizationStructure();
						}
						break;
					default:
						break;
				}
			}
		}
		// кнопка удаленния записи
		public void btnDeleteRecord_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (XtraMessageBox.Show("Запись с именем <b>" + System.Convert.ToString(this.tlStructure.FocusedNode["Name"]) + "</b> будет удалена!" + "\n" +
					"Вы согласны?",
					Application.ProductName, MessageBoxButtons.YesNo,
					MessageBoxIcon.Question, DevExpress.Utils.DefaultBoolean.True) == DialogResult.Yes)
					{
					ExecuteQuery(
						EXEC OrganizationStructureFunction
						@Id == " & Me.tlStructure.FocusedNode(" Id ") & ",
						@Level == " & Me.tlStructure.FocusedNode.Level & ",
						@Function == 4
						);
				OrganizationStructure.SelectionId = OrganizationStructure.SelectionIdOld;
				OrganizationStructure.GetOrganizationStructure();
			}
		}
		// обновление полей с информацией о записи
		private void UpdateInfoRecord(TreeListNode e, TreeListNode eOld = null)
		{
			this.lbManagerOrganization.Text = "ФИО руководителя: <b>" + System.Convert.ToString(e["Manager"]) + "</b>";
			this.lbEmailOrganization.Text = "Email: <b>" + System.Convert.ToString(e["Email"]) + "</b>";
			this.lbPhoneOrganization.Text = "Контакты: <b>" + System.Convert.ToString(e["Phones"]) + "</b>";
			this.lbAddressOrganization.Text = "Юридический адрес: <b>" + System.Convert.ToString(e["Address"]) + "</b>";
			OrganizationStructure.SelectionId = e["Id"];
			if (eOld != null)
			{
				OrganizationStructure.SelectionIdOld = eOld["Id"];
			}
		}
		// свернуть все
		public void btnCollapsedAll_ItemClick(object sender, ItemClickEventArgs e)
		{
			foreach (TreeListNode n in this.tlStructure.Nodes)
			{
				foreach (TreeListNode n1 in n.Nodes)
				{
					n1.Collapse();
				}
			}
		}
		// развернуть все
		public void btnExpandedAll_ItemClick(object sender, ItemClickEventArgs e)
		{
			this.tlStructure.ExpandAll();
		}
		// назначить филиал текущим
		public void btnSetCurrentFilial_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (this.tlStructure.FocusedNode != null)
			{
				mdQuery.ExecuteScalar("EXEC OrganizationStructureFunction @Function = 5, @Id = " + clsForSQL.InDataBase(this.tlStructure.FocusedNode["Id"]));
				OrganizationStructure.GetOrganizationStructure();
			}
		}
		// кнопка обновления формы
		public void btnUpdate_ItemClick(object sender, ItemClickEventArgs e)
		{
			OrganizationStructure.GetOrganizationStructure();
			UpdateInfoRecord(this.tlStructure.FocusedNode);
		}
		// обновление формы по таймеру
		public void tmUpdateForm_Tick(object sender, EventArgs e)
		{
			UpdateInfoRecord(this.tlStructure.FocusedNode);
		}
		// ок
		public void btnOk_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}
		// отмена
		public void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}
	}
}
