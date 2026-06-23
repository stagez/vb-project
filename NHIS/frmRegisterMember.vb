Public Class frmRegisterMember
    Private Sub frmRegisterMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtPatientID_Leave(sender As Object, e As EventArgs) 
        If Not isRequired(txtPatientID.Text) Then
            ShakeControl(txtPatientID)
            txtPatientID.Focus()
        End If
    End Sub

    Private Sub txtContactName_Leave(sender As Object, e As EventArgs) 
        If Not isValidName(txtContactName.Text) Then
            ShakeControl(txtContactName)
            txtContactName.Focus()
        End If
    End Sub

    Private Sub txtDistrict_Leave(sender As Object, e As EventArgs) 
        If Not isRequired(txtDistrict.Text) Then
            ShakeControl(txtDistrict)
            txtDistrict.Focus()
        End If
    End Sub

    Private Sub txtEPhoneNumber_Leave(sender As Object, e As EventArgs) 
        If Not isValidPhone(txtEPhoneNumber.Text) Then
            ShakeControl(txtEPhoneNumber)
            txtEPhoneNumber.Focus()
        End If
    End Sub

    Private Sub txtRegion_Leave(sender As Object, e As EventArgs) 
        If Not isRequired(txtRegion.Text) Then
            ShakeControl(txtRegion)
            txtRegion.Focus()
        End If
    End Sub

    Private Sub txtRelationship_Leave(sender As Object, e As EventArgs) 
        If Not isRequired(cboRelationship.Text) Then
            ShakeControl(txtRelationship)
            txtRelationship.Focus()
        End If
    End Sub

    Private Sub dtpDOB_Leave(sender As Object, e As EventArgs) 
        If Not isValidDOB(dtpDOB.Value) Then
            ShakeControl(dtpDOB)
            dtpDOB.Focus()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) 
        ClearForm(Me)
    End Sub
End Class