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
using DevExpress.Data;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using FitoGrano;

namespace FitoGrano
{
	sealed class mdHidenAllColumns
	{
		// скрытие всех столбцов в гриде
		internal static void HidenAllColumns_Grid(GridView _grid, DataTable dt)
		{
			_grid.PopulateColumns(dt);
			foreach (GridColumn col in _grid.Columns)
			{
				col.Visible = false;
			}
		}
		// скрытие всех столбцов в TreeList
		internal static void HidenAllColumns_TreeList(TreeList _TreeList)
		{
			foreach (TreeListColumn col in _TreeList.Columns)
			{
				col.Visible = false;
			}
		}
	}
	
}
