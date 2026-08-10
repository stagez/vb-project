Imports MySql.Data.MySqlClient
Public Class ClaimsReport
    Private Sub ClaimsReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connString As String = My.Settings.dbConStr
        Dim dt As New DataTable()
        Using conn As New MySqlConnection(connString)
            Dim query As String = "SELECT claim_id AS ClaimID, patient_name AS PatientName, service_date AS ServiceDate, amount AS Amount, status AS Status FROM claims"
            Dim cmd As New MySqlCommand(query, conn)
            Dim da As New MySqlDataAdapter(cmd)
            da.Fill(dt)
        End Using
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt))
        ReportViewer1.RefreshReport()
    End Sub
End Class