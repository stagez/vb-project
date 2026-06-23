Public Class frmRegisterProvider
    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        If Not isRequired(TextBox1.Text) Then
            ShakeControl(TextBox1)
            TextBox1.Focus()
        End If
    End Sub

    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles TextBox2.Leave
        If Not isValidName(TextBox2.Text) Then
            ShakeControl(TextBox2)
            TextBox2.Focus()
        End If
    End Sub

    Private Sub ComboBox1_Leave(sender As Object, e As EventArgs) Handles ComboBox1.Leave
        If Not isRequired(ComboBox1.Text) Then
            ShakeControl(ComboBox1)
            ComboBox1.Focus()
        End If
    End Sub

    Private Sub TextBox6_Leave(sender As Object, e As EventArgs) Handles TextBox6.Leave
        If Not isRequired(TextBox6.Text) Then
            ShakeControl(TextBox6)
            TextBox6.Focus()
        End If
    End Sub

    Private Sub TextBox14_Leave(sender As Object, e As EventArgs) Handles TextBox14.Leave
        If Not isRequired(TextBox14.Text) Then
            ShakeControl(TextBox14)
            TextBox14.Focus()
        End If
    End Sub

    Private Sub ComboBox2_Leave(sender As Object, e As EventArgs) Handles ComboBox2.Leave
        If Not isRequired(ComboBox2.Text) Then
            ShakeControl(ComboBox2)
            ComboBox2.Focus()
        End If
    End Sub

    Private Sub TextBox4_Leave(sender As Object, e As EventArgs) Handles TextBox4.Leave
        If Not isRequired(TextBox4.Text) Then
            ShakeControl(TextBox4)
            TextBox4.Focus()
        End If
    End Sub

    Private Sub TextBox3_Leave(sender As Object, e As EventArgs) Handles TextBox3.Leave
        If Not isRequired(TextBox3.Text) Then
            ShakeControl(TextBox3)
            TextBox3.Focus()
        End If
    End Sub

    Private Sub TextBox5_Leave(sender As Object, e As EventArgs) Handles TextBox5.Leave
        If Not isRequired(TextBox5.Text) Then
            ShakeControl(TextBox5)
            TextBox5.Focus()
        End If
    End Sub

    Private Sub TextBox7_Leave(sender As Object, e As EventArgs) Handles TextBox7.Leave
        If Not isValidPhone(TextBox7.Text) Then
            ShakeControl(TextBox7)
            TextBox7.Focus()
        End If
    End Sub

    Private Sub TextBox8_Leave(sender As Object, e As EventArgs) Handles TextBox8.Leave
        If Not isValidEmail(TextBox8.Text) Then
            ShakeControl(TextBox8)
            TextBox8.Focus()
        End If
    End Sub

    Private Sub TextBox10_Leave(sender As Object, e As EventArgs) Handles TextBox10.Leave
        If Not isRequired(TextBox10.Text) Then
            ShakeControl(TextBox10)
            TextBox10.Focus()
        End If
    End Sub

    Private Sub TextBox11_Leave(sender As Object, e As EventArgs) Handles TextBox11.Leave
        If Not isRequired(TextBox11.Text) Then
            ShakeControl(TextBox11)
            TextBox11.Focus()
        End If
    End Sub

    Private Sub TextBox12_Leave(sender As Object, e As EventArgs) Handles TextBox12.Leave
        If Not isRequired(TextBox12.Text) Then
            ShakeControl(TextBox12)
            TextBox12.Focus()
        End If
    End Sub

    Private Sub TextBox13_Leave(sender As Object, e As EventArgs) Handles TextBox13.Leave
        If Not isRequired(TextBox13.Text) Then
            ShakeControl(TextBox13)
            TextBox13.Focus()
        End If
    End Sub

    Private Sub ComboBox4_Leave(sender As Object, e As EventArgs) Handles ComboBox4.Leave
        If Not isRequired(ComboBox4.Text) Then
            ShakeControl(ComboBox4)
            ComboBox4.Focus()
        End If
    End Sub
End Class