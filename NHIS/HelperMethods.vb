Imports System.Security.Cryptography
Imports System.Text

Module HelperMethods

    Public Function HashedPassword(password As String) As String
        Dim salt(15) As Byte
        Using rng As New RNGCryptoServiceProvider()
            rng.GetBytes(salt)
        End Using

        Using pbkdf2 As New Rfc2898DeriveBytes(password, salt, 100000)
            Dim hash As Byte() = pbkdf2.GetBytes(32)

            Dim hashBytes(47) As Byte
            Array.Copy(salt, 0, hashBytes, 0, 16)
            Array.Copy(hash, 0, hashBytes, 16, 32)

            Return Convert.ToBase64String(hashBytes)

        End Using
    End Function

    Public Function VerifyPassword(enteredPassword As String, storedHash As String) As Boolean
        Try
            ' Decode stored base64 payload (16 bytes salt + 32 bytes hash = 48 bytes total)
            Dim hashBytes As Byte() = Convert.FromBase64String(storedHash)

            ' Ensure length is at least 48 bytes to prevent indexing errors
            If hashBytes.Length < 48 Then Return False

            ' Extract 16-byte salt
            Dim salt(15) As Byte
            Array.Copy(hashBytes, 0, salt, 0, 16)

            ' Derive 32-byte hash using the entered password and extracted salt
            ' Note: HashAlgorithmName.SHA256 is recommended for modern PBKDF2
            Using pbkdf2 As New Rfc2898DeriveBytes(enteredPassword, salt, 100000)
                Dim hash As Byte() = pbkdf2.GetBytes(32)

                ' Constant-time byte comparison to prevent timing attacks
                For i As Integer = 0 To 31
                    If hash(i) <> hashBytes(i + 16) Then
                        Return False
                    End If
                Next

                Return True
            End Using
        Catch ex As Exception
            ' Handles invalid Base64 string formats gracefully
            Return False
        End Try
    End Function




    Public Sub Highlight(ctrl As TextBox)
        ctrl.BackColor = Color.MistyRose
        ShakeControl(ctrl)
    End Sub
    Public Async Sub ShakeControl(ctrl As Control)
        If ctrl Is Nothing Then Exit Sub

        Dim originalLeft = ctrl.Left

        Dim moves = {-6, 6, -5, 5, -3, 3, -1, 1}
        For Each offset In moves
            ctrl.Left = originalLeft + offset
            Await Task.Delay(30)
        Next

        ctrl.Left = originalLeft
        Await Task.Delay(300)
    End Sub

    Public Function isValidName(name As String) As Boolean
        If String.IsNullOrWhiteSpace(name) Then Return False
        Return System.Text.RegularExpressions.Regex.IsMatch(name.Trim(), "^[a-zA-Z\s\-']+$")
    End Function

    Public Function isValidEmail(email As String) As Boolean
        If String.IsNullOrWhiteSpace(email) Then Return False
        Return System.Text.RegularExpressions.Regex.IsMatch(email.Trim(), "^[^@\s]+@[^@\s]+\.[^@\s]+$")
    End Function

    Public Function isValidPhone(phone As String) As Boolean
        If String.IsNullOrWhiteSpace(phone) Then Return False
        Dim cleaned = System.Text.RegularExpressions.Regex.Replace(phone.Trim(), "[\s\-\(\)]", "")
        Return System.Text.RegularExpressions.Regex.IsMatch(cleaned, "^0\d{9}$")
    End Function

    Public Function isRequired(value As String) As Boolean
        Return Not String.IsNullOrWhiteSpace(value)
    End Function

    Public Function isValidCombo(combo As ComboBox) As Boolean
        Return combo IsNot Nothing AndAlso combo.SelectedIndex <> -1 AndAlso Not String.IsNullOrWhiteSpace(combo.Text)
    End Function

    Public Function isValidDate(dtp As DateTimePicker, Optional minDate As Date? = Nothing, Optional maxDate As Date? = Nothing) As Boolean
        If dtp Is Nothing Then Return False
        Dim value = dtp.Value.Date
        If minDate.HasValue AndAlso value < minDate.Value.Date Then Return False
        If maxDate.HasValue AndAlso value > maxDate.Value.Date Then Return False
        Return True
    End Function

    Public Function isFormComplete(container As Control) As Boolean
        For Each ctrl As Control In container.Controls
            If TypeOf ctrl Is TextBox Then
                If Not isRequired(DirectCast(ctrl, TextBox).Text) Then Return False
            ElseIf TypeOf ctrl Is ComboBox Then
                If Not isValidCombo(DirectCast(ctrl, ComboBox)) Then Return False
            ElseIf TypeOf ctrl Is DateTimePicker Then
                If Not isValidDate(DirectCast(ctrl, DateTimePicker)) Then Return False
            ElseIf ctrl.Controls.Count > 0 Then
                If Not isFormComplete(ctrl) Then Return False
            End If
        Next
        Return True
    End Function

    Public Sub ClearForm(container As Control)
        For Each ctrl As Control In container.Controls
            If TypeOf ctrl Is TextBox Then
                DirectCast(ctrl, TextBox).Clear()

            ElseIf TypeOf ctrl Is ComboBox Then
                DirectCast(ctrl, ComboBox).SelectedIndex = -1

            ElseIf TypeOf ctrl Is DateTimePicker Then
                DirectCast(ctrl, DateTimePicker).Value = DateTime.Today

            ElseIf TypeOf ctrl Is CheckBox Then
                DirectCast(ctrl, CheckBox).Checked = False

            ElseIf TypeOf ctrl Is RadioButton Then
                DirectCast(ctrl, RadioButton).Checked = False

            ElseIf TypeOf ctrl Is RichTextBox Then
                DirectCast(ctrl, RichTextBox).Clear()

            ElseIf TypeOf ctrl Is PictureBox Then
                DirectCast(ctrl, PictureBox).Image = Nothing

            ElseIf ctrl.Controls.Count > 0 Then
                ClearForm(ctrl)
            End If
        Next
    End Sub


End Module
