Public Class frmClaimsSubmition
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub txtClaimNumber_Leave(sender As Object, e As EventArgs) Handles txtClaimNumber.Leave
        If Not isRequired(txtClaimNumber.Text) Then
            ShakeControl(txtClaimNumber)
            txtClaimNumber.Focus()
        End If
    End Sub

    Private Sub txtNHISNumber_Leave(sender As Object, e As EventArgs) Handles txtNHISNumber.Leave
        If Not isRequired(txtNHISNumber.Text) Then
            ShakeControl(txtNHISNumber)
            txtNHISNumber.Focus()
        End If
    End Sub

    Private Sub txtPatientName_Leave(sender As Object, e As EventArgs) Handles txtPatientName.Leave
        If Not isValidName(txtPatientName.Text) Then
            ShakeControl(txtPatientName)
            txtPatientName.Focus()
        End If
    End Sub

    Private Sub cboProvider_Leave(sender As Object, e As EventArgs) Handles cboProvider.Leave
        If Not isRequired(cboProvider.Text) Then
            ShakeControl(cboProvider)
            cboProvider.Focus()
        End If
    End Sub

    Private Sub dtpServiceDate_Leave(sender As Object, e As EventArgs) Handles dtpServiceDate.Leave
        If Not isValidDOB(dtpServiceDate.Value) Then
            ShakeControl(dtpServiceDate)
            dtpServiceDate.Focus()
        End If
    End Sub
End Class