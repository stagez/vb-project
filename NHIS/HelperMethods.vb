Module HelperMethods
    Public Async Sub ShakeControl(ctrl As Control)
        Dim originalLeft = ctrl.Left
        Dim originalBack = ctrl.BackColor

        ctrl.BackColor = Color.FromArgb(255, 220, 220) ' light red tint

        Dim moves = {-6, 6, -5, 5, -3, 3, -1, 1}
        For Each offset In moves
            ctrl.Left = originalLeft + offset
            Await Task.Delay(30)
        Next

        ctrl.Left = originalLeft
        Await Task.Delay(300)
        ctrl.BackColor = originalBack
    End Sub

    Public Function isValidName(name As String) As Boolean
        If String.IsNullOrWhiteSpace(name) Then Return False
        Return System.Text.RegularExpressions.Regex.IsMatch(name.Trim(), "^[a-zA-Z\s\-']+$")
    End Function

    Public Function isWholeNumber(value As String) As Boolean
        Dim result As Integer
        Return Integer.TryParse(value.Trim(), result)
    End Function

    Public Function isValidEmail(email As String) As Boolean
        If String.IsNullOrWhiteSpace(email) Then Return False
        Return System.Text.RegularExpressions.Regex.IsMatch(email.Trim(), "^[^@\s]+@[^@\s]+\.[^@\s]+$")
    End Function

    Public Function GetAge(dob As String) As Integer
        Dim result As Date
        If Not Date.TryParse(dob, result) Then Return -1
        Dim age As Integer = Date.Today.Year - result.Year
        If result > Date.Today.AddYears(-age) Then age -= 1
        Return age
    End Function

    Public Function isValidDOB(dob As String, Optional minAge As Integer = 0, Optional maxAge As Integer = 120) As Integer
        Dim result As Date
        If Not Date.TryParse(dob, result) Then Return -1
        Dim age As Integer = Date.Today.Year - result.Year
        If result > Date.Today.AddYears(-age) Then age -= 1
        Return age
    End Function

    Public Function isValidPhone(phone As String) As Boolean
        If String.IsNullOrWhiteSpace(phone) Then Return False
        Dim cleaned = System.Text.RegularExpressions.Regex.Replace(phone.Trim(), "[\s\-\(\)]", "")
        Return System.Text.RegularExpressions.Regex.IsMatch(cleaned, "^\+?\d{7,15}$")
    End Function

    Public Function isRequired(value As String) As Boolean
        Return Not String.IsNullOrWhiteSpace(value)
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
