Public Class frmClaimsSubmission
    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtClaimNumber_Leave(sender As Object, e As EventArgs)
        If Not isRequired(txtClaimNumber.Text) Then
            ShakeControl(txtClaimNumber)
            txtClaimNumber.Focus()
        End If
    End Sub

    Private Sub txtNHISNumber_Leave(sender As Object, e As EventArgs)
        If Not isRequired(txtApprovedAmount.Text) Then
            ShakeControl(txtApprovedAmount)
            txtApprovedAmount.Focus()
        End If
    End Sub

    Private Sub txtPatientName_Leave(sender As Object, e As EventArgs)
        If Not isValidName(txtPatientName.Text) Then
            ShakeControl(txtPatientName)
            txtPatientName.Focus()
        End If
    End Sub

    Private Sub cboProvider_Leave(sender As Object, e As EventArgs)
        If Not isRequired(cboProvider.Text) Then
            ShakeControl(cboProvider)
            cboProvider.Focus()
        End If
    End Sub

    Private Sub dtpServiceDate_Leave(sender As Object, e As EventArgs)
        If Not isValidDOB(dtpServiceDate.Value) Then
            ShakeControl(dtpServiceDate)
            dtpServiceDate.Focus()
        End If
    End Sub

    Private Sub frmClaimsSubmission_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtRegion2.TextChanged

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm(Me)
    End Sub
End Class