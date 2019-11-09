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
	public class clsOrganizationStructure
	{
		DevExpress.Utils.ImageCollection ImageCol = new DevExpress.Utils.ImageCollection(); // РљРѕР»Р»РµРєС†РёСЏ РёРєРѕРЅРѕРє
		List<ConditionNodeList> ndList = new List<ConditionNodeList>(); // РљРѕР»Р»РµРєС†РёСЏ СЃРѕСЃС‚РѕСЏРЅРёР№ РЅРѕРґРѕРІ
		ConditionNodeList NodeList; // Р—Р°РїРёСЃСЊ РґР»СЏ РґРѕР±Р°РІР»РµРЅРёСЏ РІ РєРѕР»Р»РµРєС†РёСЋ
		
		public int SelectionIdOld; // РРґ РїСЂРµРґС‹РґСѓС‰РµР№ РІС‹Р±СЂР°РЅРЅРѕР№ РІС‹Р±СЂР°РЅРЅРѕР№ Р·Р°РїРёСЃРё
		public int SelectionId = 99999; // РРґ РІС‹Р±СЂР°РЅРЅРѕР№ Р·Р°РїРёСЃРё
		public DevExpress.XtraTreeList.TreeList sender; // Р­Р»РµРјРµРЅС‚ TreeList
		public string TableName = "OrganizationStructure"; // РРјСЏ С‚Р°Р±Р»РёС†С‹ РІ Р”РЎ
		
		// РєРѕР»Р»РµРєС†РёРё СЃРѕСЃС‚СЏРЅРёСЏ РЅРѕРґРѕРІ
		public struct ConditionNodeList
		{
			public int Id; // РРґ РЅРѕРґР°
			public bool Expanded; // РЎРѕСЃС‚РѕСЏРЅРѕРёРµ РЅРѕРґР°
		}
		
		// Р—Р°РїРѕР»РЅСЏРµРј РєРѕР»Р»РµРєС†РёСЋ
		private void Filling_ndList(DevExpress.XtraTreeList.Nodes.TreeListNode node = null, bool IsFirstRun = true)
			{
			if (IsFirstRun)
			{
				ndList.Clear();
			}
			if (IsFirstRun == true) // РџРµСЂРІС‹Р№ Р·Р°РїСѓСЃРє
			{
				foreach (DevExpress.XtraTreeList.Nodes.TreeListNode nd in sender.Nodes)
				{
					NodeList.Id = System.Convert.ToInt32(nd["Id"]);
					NodeList.Expanded = nd.Expanded;
					ndList.Add(NodeList);
					if (nd.HasChildren)
					{
						Filling_ndList(nd, false);
					}
				}
			} // СЂРµРєСѓСЂСЃРёСЏ
			else
			{
				foreach (DevExpress.XtraTreeList.Nodes.TreeListNode nd in node.Nodes)
				{
					NodeList.Id = System.Convert.ToInt32(nd["Id"]);
					NodeList.Expanded = nd.Expanded;
					ndList.Add(NodeList);
					if (nd.HasChildren)
					{
						Filling_ndList(nd, false);
					}
				}
			}
		}
		
		public void GetOrganizationStructure(int ExpandedRoot = 1, int ExpandedFilials = 1, int ExpandedGroups = 0, int ExpandedRoleJob = 0, string OnlyCurentFillial = "NULL")
			{
			
			if (sender.Nodes.Count != 0)
			{
				Filling_ndList();
			}
			mdVariables.EventChangedControl = false;
			ImageCol.Clear();
			ImageCol.AddImage(global::My.Resources.Resources.company_16x16);
			ImageCol.AddImage(global::My.Resources.Resources.organization_16x16);
			ImageCol.AddImage(global::My.Resources.Resources.group_people_16x16);
			ImageCol.AddImage(global::My.Resources.Resources.performer_16x16);
			ImageCol.AddImage(global::My.Resources.Resources.current_16x16);
			
			
			sender.ClearNodes();
			sender.DataSource = mdQuery.iDataSet.Tables[TableName];
			sender.KeyFieldName = "Id";
			sender.ParentFieldName = "ParentId";
			sender.StateImageList = ImageCol;
			sender.PopulateColumns();
			mdHidenAllColumns.HidenAllColumns_TreeList(sender);
			sender.Columns["Name"].Visible = sender.Columns.Count != 0;
		}
		mdVariables.EventChangedControl = true;
		// РІСЃРµРј РЅРѕРґР°Рј РїСЂРёСЃРІР°РёРІР°РµРј РёРєРѕРЅРєСѓ
		foreach (DevExpress.XtraTreeList.Nodes.TreeListNode nd in sender.Nodes)
		{
			FillSelectImageIndex(nd);
		}
		// РёР·РІР»РµС‡РµРЅРёРµ РёР· РєРѕР»Р»РµРєС†РёР№ СЃРѕСЃС‚РѕСЏРЅРёР№ РЅРѕРґРѕРІ
		foreach (var n in ndList)
		{
			if (sender.FindNodeByKeyID(n.Id) != null)
			{
				sender.FindNodeByKeyID(n.Id).Expanded = System.Convert.ToBoolean(n.Expanded);
			}
		}
		sender.FocusedNode = sender.FindNodeByKeyID(SelectionId);
	}
	
	// С†РёРєР» РїРѕ РІСЃРµРј РґРѕС‡РµСЂРЅРёРј СѓР·Р»Р°Рј
	private void FillSelectImageIndex(DevExpress.XtraTreeList.Nodes.TreeListNode ParentNode)
	{
		ParentNode.Expanded = ParentNode["IsExpanded"];
		ParentNode.StateImageIndex = ParentNode.Level;
		foreach (DevExpress.XtraTreeList.Nodes.TreeListNode nd in ParentNode.Nodes)
		{
			FillSelectImageIndex(nd);
		}
	}
	
	// РІС‹РґРµР»РµРЅРёРµ С‚РµРєСѓС‰РµРіРѕ С„РёР»РёР°Р»Р°
	public void NodeCellStyle(object sender, DevExpress.XtraTreeList.GetCustomNodeCellStyleEventArgs e)
	{
		if (mdVariables.EventChangedControl == false)
		{
			return;
		}
		if (e.Column.FieldName != "Name")
		{
			return;
		}
		if (e.Node["IsCurrent"])
		{
			e.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (8.25F), (System.Drawing.FontStyle) (FontStyle.Bold | FontStyle.Underline));
			e.Node.StateImageIndex = 4;
		}
	}
}

}
