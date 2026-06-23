Public Class frmRegisterMember
    Private Sub frmRegisterMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtPatientID_Leave(sender As Object, e As EventArgs) Handles txtPatientID.Leave
        If Not isRequired(txtPatientID.Text) Then
            ShakeControl(txtPatientID)
            txtPatientID.Focus()
        End If
    End Sub

    Private Sub txtContactName_Leave(sender As Object, e As EventArgs) Handles txtContactName.Leave
        If Not isValidName(txtContactName.Text) Then
            ShakeControl(txtContactName)
            txtContactName.Focus()
        End If
    End Sub

    Private Sub txtDistrict_Leave(sender As Object, e As EventArgs) Handles txtDistrict.Leave
        If Not isRequired(txtDistrict.Text) Then
            ShakeControl(txtDistrict)
            txtDistrict.Focus()
        End If
    End Sub

    Private Sub txtEPhoneNumber_Leave(sender As Object, e As EventArgs) Handles txtEPhoneNumber.Leave
        If Not isValidPhone(txtEPhoneNumber.Text) Then
            ShakeControl(txtEPhoneNumber)
            txtEPhoneNumber.Focus()
        End If
    End Sub

    Private Sub txtRegion_Leave(sender As Object, e As EventArgs) Handles txtRegion.Leave
        If Not isRequired(txtRegion.Text) Then
            ShakeControl(txtRegion)
            txtRegion.Focus()
        End If
    End Sub

    Private Sub txtRelationship_Leave(sender As Object, e As EventArgs) Handles txtRelationship.Leave
        If Not isRequired(cboRelationship.Text) Then
            ShakeControl(txtRelationship)
            txtRelationship.Focus()
        End If
    End Sub

    Private Sub dtpDOB_Leave(sender As Object, e As EventArgs) Handles dtpDOB.Leave, DateTimePicker2.Leave
        If Not isValidDOB(dtpDOB.Value) Then
            ShakeControl(dtpDOB)
            dtpDOB.Focus()
        End If
    End Sub
End Class