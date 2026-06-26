Module HelperMethods
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
