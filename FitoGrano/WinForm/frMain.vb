Public Class frMain 
    ' Локация герба {600; 12}
    Private Sub frMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.ptbGerb.Parent = Me.ptbFone
        AddHandler DevExpress.LookAndFeel.UserLookAndFeel.Default.StyleChanged, AddressOf Default_StyleChanged
    End Sub

    Private Sub tmrDateTime_Tick(sender As System.Object, e As System.EventArgs) Handles tmrDateTime.Tick
        Me.lbDateTime.Caption = Now.ToLocalTime
    End Sub

    Private Sub btnSecurityUsers_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSecurityUsers.ItemClick
        frSecurityUsers.ShowDialog()
    End Sub

    Private Sub btnOrganizationStructure_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOrganizationStructure.ItemClick
        frBooks_OrganizationStructure.ShowDialog()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        frAddEditOrganizationsRoleJob.ShowDialog()
    End Sub

    ' Событие изменения темы оформления
    Private Sub Default_StyleChanged(ByVal sender As Object, ByVal e As EventArgs)
        RegistryWrite(pref_ComplexSettings, "SkinName", DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName)
    End Sub

    Private Sub btnClassificationProducts_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClassificationProducts.ItemClick
        frBooks_ClassificationProducts.ShowDialog()
    End Sub

    Private Sub btnResearchDirection_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnResearchDirection.ItemClick
        frBooks_ResearchDirection.ShowDialog()
    End Sub

    Private Sub btnResearchObjects_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnResearchObjects.ItemClick
        frBooks_ResearchObjects.ShowDialog()
    End Sub

    Private Sub btnCountryAgreements_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCountryAgreements.ItemClick
        frBooks_CountryAgreements.ShowDialog()
    End Sub
End Class