Imports MySql.Data.MySqlClient

Public Class ClaimsReport
    Private _startDate As Date?
    Private _endDate As Date?
    Private _statusFilter As String

    Public Sub New(Optional startDate As Date? = Nothing, Optional endDate As Date? = Nothing, Optional statusFilter As String = Nothing)
        InitializeComponent()
        _startDate = startDate
        _endDate = endDate
        _statusFilter = statusFilter
    End Sub

    Private Sub ClaimsReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connString As String = My.Settings.dbConStrRemote
        Dim dt As New DataTable()
        Dim query As String = "SELECT id AS ClaimID, patient_name AS PatientName, service_date AS ServiceDate, amount AS Amount, status AS Status FROM claim2 WHERE 1=1"

        If _startDate.HasValue Then query &= " AND service_date >= @startDate"
        If _endDate.HasValue Then query &= " AND service_date <= @endDate"
        If Not String.IsNullOrEmpty(_statusFilter) Then query &= " AND status = @status"

        Using conn As New MySqlConnection(connString)
            Dim cmd As New MySqlCommand(query, conn)
            If _startDate.HasValue Then cmd.Parameters.AddWithValue("@startDate", _startDate.Value.Date)
            If _endDate.HasValue Then cmd.Parameters.AddWithValue("@endDate", _endDate.Value.Date.AddDays(1).AddSeconds(-1))
            If Not String.IsNullOrEmpty(_statusFilter) Then cmd.Parameters.AddWithValue("@status", _statusFilter)

            Dim da As New MySqlDataAdapter(cmd)
            da.Fill(dt)
        End Using

        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt))
        ReportViewer1.RefreshReport()
    End Sub
End Class