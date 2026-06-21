Public Class frmViewProviders
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvViewProviders.CellContentClick

    End Sub

    Private Sub frmViewProviders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvViewProviders.Rows.Add("P001", "Korle Bu Hospital")
        dgvViewProviders.Rows.Add("P002", "Reach Hospital")
        dgvViewProviders.Rows.Add("P003", "Temale Teaching Hospital")
        dgvViewProviders.Rows.Add("P004", "UEW Student Hospital")
    End Sub
End Class