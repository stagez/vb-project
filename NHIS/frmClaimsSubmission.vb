Public Class frmClaimsSubmission
    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

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

    Private Sub cboProcedureType_Leave(sender As Object, e As EventArgs) Handles cboProcedureType.Leave
        If Not isRequired(cboProcedureType.Text) Then
            ShakeControl(cboProcedureType)
            cboProcedureType.Focus()
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