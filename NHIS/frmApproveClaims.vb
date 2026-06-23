Public Class frmApproveClaims
    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        MessageBox.Show(
            "Claim Approved!",
            "Approve",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )
    End Sub

    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click
        Dim result = MessageBox.Show(
            "Do you want to reject claim?",
            "Reject Claim",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )
        If result = DialogResult.Yes Then
            MessageBox.Show(
                "Claim rejected!",
                "Reject Claim",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )
        End If
    End Sub
End Class