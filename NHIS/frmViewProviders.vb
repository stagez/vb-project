Public Class frmViewProviders
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub frmViewProviders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvViewProviders.RowTemplate.Height = 45


        dgvViewProviders.GridColor = Color.FromArgb(230, 235, 230)
        dgvViewProviders.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal

        dgvViewProviders.DefaultCellStyle.Padding = New Padding(8, 0, 0, 0)
        dgvViewProviders.ColumnHeadersDefaultCellStyle.Padding = New Padding(8, 0, 0, 0)


        dgvViewProviders.Rows.Add("P001", "Korle Bu Teaching Hospital", "Teaching Hospital", "030 276 1100", "Accra, Greater Accra")
        dgvViewProviders.Rows.Add("P002", "Reach Hospital", "Private Hospital", "030 277 5500", "Accra, Greater Accra")
        dgvViewProviders.Rows.Add("P003", "Tamale Teaching Hospital", "Teaching Hospital", "037 202 2566", "Tamale, Northern")
        dgvViewProviders.Rows.Add("P004", "UEW Student Hospital", "Clinic", "033 209 3000", "Winneba, Central")
        dgvViewProviders.Rows.Add("P005", "Trust Hospital", "Private Hospital", "030 278 1000", "Accra, Greater Accra")
        dgvViewProviders.Rows.Add("P006", "Nyaho Medical Centre", "Private Hospital", "030 277 7777", "Accra, Greater Accra")
    End Sub
End Class