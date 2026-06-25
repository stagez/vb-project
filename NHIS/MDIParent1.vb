Imports System.Windows.Forms

Public Class frmMain
    Private Async Sub ShakeControl(ctrl As Control)
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

    Private Sub LoadForm(frm As Form)
        pnlContent.Controls.Clear()
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        pnlContent.Controls.Add(frm)
        CentreForm(frm, pnlContent)
        frm.Show()
    End Sub

    Private Sub CentreForm(frm As Form, container As Panel)
        frm.Left = (container.Width - frm.Width) \ 2
        frm.Top = (container.Height - frm.Height) \ 2
    End Sub

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub MDIMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim frm As New frmDashboard
        'frm.Dock = DockStyle.Fill
        'frm.MdiParent = Me
        'frm.Show()
        LoadForm(New frmDashboard())

    End Sub

    Private Sub RegisterProviderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisterProviderToolStripMenuItem.Click
        For Each f As Form In Me.MdiChildren
            f.Close()
        Next

        LoadForm(New frmRegisterProvider())
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim result = MessageBox.Show(
            "Are you sure you want to logout?",
            "Confirm Logout",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If result = DialogResult.Yes Then
            frmLogin.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub ViewProvidersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewProvidersToolStripMenuItem.Click
        'Dim frm As New frmViewProviders
        'frm.MdiParent = Me
        'frm.Show()
        LoadForm(New frmViewProviders)
    End Sub

    Private Sub DashboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DashboardToolStripMenuItem.Click
        LoadForm(New frmDashboard())
    End Sub

    Private Sub tsHome_Click(sender As Object, e As EventArgs) Handles tsHome.Click
        LoadForm(New frmDashboard())
    End Sub

    Private Sub tsNewClaim_Click(sender As Object, e As EventArgs) Handles tsNewClaim.Click
        LoadForm(New frmClaimsSubmission)
    End Sub

    Private Sub tsViewClaims_Click(sender As Object, e As EventArgs) Handles tsViewClaims.Click
        LoadForm(New frmViewClaims())
    End Sub

    Private Sub tsProviders_Click(sender As Object, e As EventArgs) Handles tsProviders.Click
        LoadForm(New frmViewProviders())
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim result = MessageBox.Show(
            "Are you sure you want to exit?",
            "Confirm Exit", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            )
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Don't ask again if Application.Exit() was already called
        If e.CloseReason = CloseReason.ApplicationExitCall Then Return

        Dim result = MessageBox.Show(
            "Are you sure you want to exit?",
            "Confirm Exit",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If result = DialogResult.No Then
            e.Cancel = True  ' stops the form from closing
        Else
            Application.Exit()
        End If
    End Sub

    Private Sub AddUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddUserToolStripMenuItem.Click
        LoadForm(New frmAddUser())
    End Sub

    Private Sub AboutSystemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutSystemToolStripMenuItem.Click
        Dim f As New frmAbout()
        f.ShowDialog()
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        'pnlContent.Visible = False
        'Dim frm As New frmRegisterMember
        'frm.MdiParent = Me
        'frm.Show()
        LoadForm(New frmRegisterMember)
    End Sub

    Private Sub ClaimsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClaimsToolStripMenuItem1.Click
        LoadForm(New frmClaimsSubmission)
    End Sub

    Private Sub SubmitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubmitToolStripMenuItem.Click
        LoadForm(New frmViewClaims)
    End Sub
End Class
