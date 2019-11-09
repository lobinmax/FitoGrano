Imports System.Data
Imports DevExpress.Data
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Columns
Module mdHidenAllColumns
    ' скрытие всех столбцов в гриде
    Friend Sub HidenAllColumns_Grid(ByVal _grid As GridView, ByVal dt As DataTable)
        _grid.PopulateColumns(dt)
        For Each col As GridColumn In _grid.Columns
            col.Visible = False
        Next
    End Sub
    ' скрытие всех столбцов в TreeList
    Friend Sub HidenAllColumns_TreeList(ByVal _TreeList As TreeList)
        For Each col As TreeListColumn In _TreeList.Columns
            col.Visible = False
        Next
    End Sub
End Module
