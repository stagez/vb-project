Public Class frmClaim

    Private Sub TextBox3_Leave(sender As Object, e As EventArgs) Handles TextBox3.Leave
        If Not isRequired(TextBox3.Text) Then
            ShakeControl(TextBox3)
            TextBox3.Focus()
        End If
    End Sub

    Private Sub TextBox4_Leave(sender As Object, e As EventArgs) Handles TextBox4.Leave
        If Not isRequired(TextBox4.Text) Then
            ShakeControl(TextBox4)
            TextBox4.Focus()
        End If
    End Sub

    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles TextBox2.Leave
        If Not isValidName(TextBox2.Text) Then
            ShakeControl(TextBox2)
            TextBox2.Focus()
        End If
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        If Not isRequired(TextBox1.Text) Then
            ShakeControl(TextBox1)
            TextBox1.Focus()
        End If
    End Sub

    Private Sub TextBox5_Leave(sender As Object, e As EventArgs) Handles TextBox5.Leave
        If Not isRequired(TextBox5.Text) Then
            ShakeControl(TextBox5)
            TextBox5.Focus()
        End If
    End Sub

    Private Sub TextBox6_Leave(sender As Object, e As EventArgs) Handles TextBox6.Leave
        If Not isRequired(TextBox6.Text) Then
            ShakeControl(TextBox6)
            TextBox6.Focus()
        End If
    End Sub

    Private Sub ComboBox1_Leave(sender As Object, e As EventArgs) Handles ComboBox1.Leave
        If Not isRequired(ComboBox1.Text) Then
            ShakeControl(ComboBox1)
            ComboBox1.Focus()
        End If
    End Sub

    Private Sub DateTimePicker1_Leave(sender As Object, e As EventArgs) Handles DateTimePicker1.Leave
        If Not isValidDOB(DateTimePicker1.Value) Then
            ShakeControl(DateTimePicker1)
            DateTimePicker1.Focus()
        End If
    End Sub

    Private Sub DateTimePicker2_Leave(sender As Object, e As EventArgs) Handles DateTimePicker2.Leave
        If Not isValidDOB(DateTimePicker2.Value) Then
            ShakeControl(DateTimePicker2)
            DateTimePicker2.Focus()
        End If
    End Sub

End Class