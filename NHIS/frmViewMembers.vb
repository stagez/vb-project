Public Class frmViewMembers
    Private Sub dgvViewMembers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMembers.CellContentClick

    End Sub

    Private Sub frmViewMembers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvMembers.RowTemplate.Height = 45

        dgvMembers.GridColor = Color.FromArgb(230, 235, 230)
        dgvMembers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal

        dgvMembers.DefaultCellStyle.Padding = New Padding(8, 0, 0, 0)
        dgvMembers.ColumnHeadersDefaultCellStyle.Padding = New Padding(8, 0, 0, 0)

        dgvMembers.Rows.Add("PAT-001", "Kofi Asante", "NHIS-2024-00123", "SSNIT Contributor", "Male", "024 567 8901", "Greater Accra")
        dgvMembers.Rows.Add("PAT-002", "Abena Owusu", "NHIS-2024-00456", "Indigent", "Female", "054 321 7890", "Central")
        dgvMembers.Rows.Add("PAT-003", "Kwame Mensah", "NHIS-2024-00789", "Under 18", "Male", "020 111 2233", "Ashanti")
        dgvMembers.Rows.Add("PAT-004", "Akosua Adjei", "NHIS-2024-01012", "Pregnant Woman", "Female", "026 445 6677", "Western")
        dgvMembers.Rows.Add("PAT-005", "Yaw Darko", "NHIS-2024-01345", "SSNIT Pensioner", "Male", "050 998 8776", "Northern")
        dgvMembers.Rows.Add("PAT-006", "Ama Boateng", "NHIS-2024-01678", "SSNIT Contributor", "Female", "027 334 5566", "Eastern")
        dgvMembers.Rows.Add("PAT-007", "Kojo Frimpong", "NHIS-2024-01901", "Under 18", "Male", "023 667 4433", "Central")
    End Sub
End Class