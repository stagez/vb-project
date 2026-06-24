<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ssStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DashboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProviderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisterProviderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewProvidersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClaimsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClaimsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubmitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchClaimsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApproveClaimsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RejectedClaimsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DailyReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonthlyReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApprovedClaimsReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RejectedClaimsReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutSystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsHome = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsNewClaim = New System.Windows.Forms.ToolStripButton()
        Me.tsViewClaims = New System.Windows.Forms.ToolStripButton()
        Me.tsProviders = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsApprove = New System.Windows.Forms.ToolStripButton()
        Me.tsReject = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsReports = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsPrint = New System.Windows.Forms.ToolStripButton()
        Me.tsLogOut = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ssStatus})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 913)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(2, 0, 21, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(1539, 30)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ssStatus
        '
        Me.ssStatus.Name = "ssStatus"
        Me.ssStatus.Size = New System.Drawing.Size(162, 25)
        Me.ssStatus.Text = "Admin - Logged in"
        '
        'pnlContent
        '
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(0, 66)
        Me.pnlContent.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Padding = New System.Windows.Forms.Padding(60, 37, 60, 37)
        Me.pnlContent.Size = New System.Drawing.Size(1539, 847)
        Me.pnlContent.TabIndex = 12
        Me.ToolTip.SetToolTip(Me.pnlContent, "Reports")
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ProviderToolStripMenuItem, Me.ClaimsToolStripMenuItem, Me.ViewToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.UserManagementToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(1539, 35)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DashboardToolStripMenuItem, Me.AddToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(50, 29)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'DashboardToolStripMenuItem
        '
        Me.DashboardToolStripMenuItem.Image = Global.NHIS.My.Resources.Resources.icons8_dashboard_48
        Me.DashboardToolStripMenuItem.Name = "DashboardToolStripMenuItem"
        Me.DashboardToolStripMenuItem.Size = New System.Drawing.Size(184, 30)
        Me.DashboardToolStripMenuItem.Text = "Dashboard"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem})
        Me.AddToolStripMenuItem.Image = Global.NHIS.My.Resources.Resources.icons8_add_48
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(184, 30)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(203, 30)
        Me.NewToolStripMenuItem.Text = "New Member"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Image = Global.NHIS.My.Resources.Resources.icons8_logout_48
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(184, 30)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.NHIS.My.Resources.Resources.icons8_exit_48
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(184, 30)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ProviderToolStripMenuItem
        '
        Me.ProviderToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegisterProviderToolStripMenuItem, Me.ViewProvidersToolStripMenuItem})
        Me.ProviderToolStripMenuItem.Name = "ProviderToolStripMenuItem"
        Me.ProviderToolStripMenuItem.Size = New System.Drawing.Size(90, 29)
        Me.ProviderToolStripMenuItem.Text = "Provider"
        '
        'RegisterProviderToolStripMenuItem
        '
        Me.RegisterProviderToolStripMenuItem.Name = "RegisterProviderToolStripMenuItem"
        Me.RegisterProviderToolStripMenuItem.Size = New System.Drawing.Size(230, 30)
        Me.RegisterProviderToolStripMenuItem.Text = "Register Provider"
        '
        'ViewProvidersToolStripMenuItem
        '
        Me.ViewProvidersToolStripMenuItem.Name = "ViewProvidersToolStripMenuItem"
        Me.ViewProvidersToolStripMenuItem.Size = New System.Drawing.Size(230, 30)
        Me.ViewProvidersToolStripMenuItem.Text = "View Providers"
        '
        'ClaimsToolStripMenuItem
        '
        Me.ClaimsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClaimsToolStripMenuItem1, Me.SubmitToolStripMenuItem, Me.SearchClaimsToolStripMenuItem})
        Me.ClaimsToolStripMenuItem.Name = "ClaimsToolStripMenuItem"
        Me.ClaimsToolStripMenuItem.Size = New System.Drawing.Size(178, 29)
        Me.ClaimsToolStripMenuItem.Text = "Claim Management"
        '
        'ClaimsToolStripMenuItem1
        '
        Me.ClaimsToolStripMenuItem1.Image = Global.NHIS.My.Resources.Resources.icons8_submit_48
        Me.ClaimsToolStripMenuItem1.Name = "ClaimsToolStripMenuItem1"
        Me.ClaimsToolStripMenuItem1.Size = New System.Drawing.Size(205, 30)
        Me.ClaimsToolStripMenuItem1.Text = "Submit Claim"
        '
        'SubmitToolStripMenuItem
        '
        Me.SubmitToolStripMenuItem.Name = "SubmitToolStripMenuItem"
        Me.SubmitToolStripMenuItem.Size = New System.Drawing.Size(205, 30)
        Me.SubmitToolStripMenuItem.Text = "View Claims"
        '
        'SearchClaimsToolStripMenuItem
        '
        Me.SearchClaimsToolStripMenuItem.Name = "SearchClaimsToolStripMenuItem"
        Me.SearchClaimsToolStripMenuItem.Size = New System.Drawing.Size(205, 30)
        Me.SearchClaimsToolStripMenuItem.Text = "Search Claims"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ApproveClaimsToolStripMenuItem, Me.RejectedClaimsToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(97, 29)
        Me.ViewToolStripMenuItem.Text = "Approval"
        '
        'ApproveClaimsToolStripMenuItem
        '
        Me.ApproveClaimsToolStripMenuItem.Image = Global.NHIS.My.Resources.Resources.icons8_check_mark_48
        Me.ApproveClaimsToolStripMenuItem.Name = "ApproveClaimsToolStripMenuItem"
        Me.ApproveClaimsToolStripMenuItem.Size = New System.Drawing.Size(222, 30)
        Me.ApproveClaimsToolStripMenuItem.Text = "Approve Claims"
        '
        'RejectedClaimsToolStripMenuItem
        '
        Me.RejectedClaimsToolStripMenuItem.Image = Global.NHIS.My.Resources.Resources.icons8_reject_48__1_
        Me.RejectedClaimsToolStripMenuItem.Name = "RejectedClaimsToolStripMenuItem"
        Me.RejectedClaimsToolStripMenuItem.Size = New System.Drawing.Size(222, 30)
        Me.RejectedClaimsToolStripMenuItem.Text = "Rejected Claims"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DailyReportToolStripMenuItem, Me.MonthlyReportToolStripMenuItem, Me.ApprovedClaimsReportToolStripMenuItem, Me.RejectedClaimsReportToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(85, 29)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'DailyReportToolStripMenuItem
        '
        Me.DailyReportToolStripMenuItem.Name = "DailyReportToolStripMenuItem"
        Me.DailyReportToolStripMenuItem.Size = New System.Drawing.Size(291, 30)
        Me.DailyReportToolStripMenuItem.Text = "Daily Report"
        '
        'MonthlyReportToolStripMenuItem
        '
        Me.MonthlyReportToolStripMenuItem.Name = "MonthlyReportToolStripMenuItem"
        Me.MonthlyReportToolStripMenuItem.Size = New System.Drawing.Size(291, 30)
        Me.MonthlyReportToolStripMenuItem.Text = "Monthly Report"
        '
        'ApprovedClaimsReportToolStripMenuItem
        '
        Me.ApprovedClaimsReportToolStripMenuItem.Name = "ApprovedClaimsReportToolStripMenuItem"
        Me.ApprovedClaimsReportToolStripMenuItem.Size = New System.Drawing.Size(291, 30)
        Me.ApprovedClaimsReportToolStripMenuItem.Text = "Approved Claims Report"
        '
        'RejectedClaimsReportToolStripMenuItem
        '
        Me.RejectedClaimsReportToolStripMenuItem.Name = "RejectedClaimsReportToolStripMenuItem"
        Me.RejectedClaimsReportToolStripMenuItem.Size = New System.Drawing.Size(291, 30)
        Me.RejectedClaimsReportToolStripMenuItem.Text = "Rejected Claims Report"
        '
        'UserManagementToolStripMenuItem
        '
        Me.UserManagementToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddUserToolStripMenuItem, Me.ManageUsersToolStripMenuItem})
        Me.UserManagementToolStripMenuItem.Name = "UserManagementToolStripMenuItem"
        Me.UserManagementToolStripMenuItem.Size = New System.Drawing.Size(169, 29)
        Me.UserManagementToolStripMenuItem.Text = "User Management"
        '
        'AddUserToolStripMenuItem
        '
        Me.AddUserToolStripMenuItem.Image = Global.NHIS.My.Resources.Resources.icons8_add_user_48
        Me.AddUserToolStripMenuItem.Name = "AddUserToolStripMenuItem"
        Me.AddUserToolStripMenuItem.Size = New System.Drawing.Size(208, 30)
        Me.AddUserToolStripMenuItem.Text = "Add User"
        '
        'ManageUsersToolStripMenuItem
        '
        Me.ManageUsersToolStripMenuItem.Image = Global.NHIS.My.Resources.Resources.icons8_manage_48
        Me.ManageUsersToolStripMenuItem.Name = "ManageUsersToolStripMenuItem"
        Me.ManageUsersToolStripMenuItem.Size = New System.Drawing.Size(208, 30)
        Me.ManageUsersToolStripMenuItem.Text = "Manage Users"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutSystemToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(61, 29)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutSystemToolStripMenuItem
        '
        Me.AboutSystemToolStripMenuItem.Image = Global.NHIS.My.Resources.Resources.icons8_about_48
        Me.AboutSystemToolStripMenuItem.Name = "AboutSystemToolStripMenuItem"
        Me.AboutSystemToolStripMenuItem.Size = New System.Drawing.Size(208, 30)
        Me.AboutSystemToolStripMenuItem.Text = "About System"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsHome, Me.ToolStripSeparator1, Me.tsNewClaim, Me.tsViewClaims, Me.tsProviders, Me.ToolStripSeparator2, Me.tsApprove, Me.tsReject, Me.ToolStripSeparator3, Me.tsSave, Me.ToolStripSeparator4, Me.tsReports, Me.ToolStripSeparator5, Me.tsPrint, Me.tsLogOut})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 35)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(1539, 31)
        Me.ToolStrip1.TabIndex = 10
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsHome
        '
        Me.tsHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsHome.Image = Global.NHIS.My.Resources.Resources.icons8_dashboard_48
        Me.tsHome.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsHome.Name = "tsHome"
        Me.tsHome.Size = New System.Drawing.Size(28, 28)
        Me.tsHome.Text = "Dashboard"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'tsNewClaim
        '
        Me.tsNewClaim.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsNewClaim.Image = Global.NHIS.My.Resources.Resources.icons8_add_48__1_
        Me.tsNewClaim.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsNewClaim.Name = "tsNewClaim"
        Me.tsNewClaim.Size = New System.Drawing.Size(28, 28)
        Me.tsNewClaim.Text = "Add New Claim"
        '
        'tsViewClaims
        '
        Me.tsViewClaims.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsViewClaims.Image = Global.NHIS.My.Resources.Resources.icons8_view_48__1_
        Me.tsViewClaims.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsViewClaims.Name = "tsViewClaims"
        Me.tsViewClaims.Size = New System.Drawing.Size(28, 28)
        Me.tsViewClaims.Text = "View Claims"
        '
        'tsProviders
        '
        Me.tsProviders.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsProviders.Image = Global.NHIS.My.Resources.Resources.icons8_list_48
        Me.tsProviders.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsProviders.Name = "tsProviders"
        Me.tsProviders.Size = New System.Drawing.Size(28, 28)
        Me.tsProviders.Text = "Providers"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'tsApprove
        '
        Me.tsApprove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsApprove.Image = Global.NHIS.My.Resources.Resources.icons8_check_mark_48
        Me.tsApprove.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsApprove.Name = "tsApprove"
        Me.tsApprove.Size = New System.Drawing.Size(28, 28)
        Me.tsApprove.Text = "Approve"
        '
        'tsReject
        '
        Me.tsReject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsReject.Image = Global.NHIS.My.Resources.Resources.icons8_reject_48__1_
        Me.tsReject.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsReject.Name = "tsReject"
        Me.tsReject.Size = New System.Drawing.Size(28, 28)
        Me.tsReject.Text = "Reject"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 31)
        '
        'tsSave
        '
        Me.tsSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsSave.Image = Global.NHIS.My.Resources.Resources.icons8_save_48__1_
        Me.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSave.Name = "tsSave"
        Me.tsSave.Size = New System.Drawing.Size(28, 28)
        Me.tsSave.Text = "Save"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 31)
        '
        'tsReports
        '
        Me.tsReports.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsReports.Image = Global.NHIS.My.Resources.Resources.icons8_pie_chart_48
        Me.tsReports.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsReports.Name = "tsReports"
        Me.tsReports.Size = New System.Drawing.Size(28, 28)
        Me.tsReports.Text = "Reports"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 31)
        '
        'tsPrint
        '
        Me.tsPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsPrint.Image = Global.NHIS.My.Resources.Resources.icons8_print_48__1_
        Me.tsPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsPrint.Name = "tsPrint"
        Me.tsPrint.Size = New System.Drawing.Size(28, 28)
        Me.tsPrint.Text = "Save"
        '
        'tsLogOut
        '
        Me.tsLogOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsLogOut.Image = Global.NHIS.My.Resources.Resources.icons8_logout_48
        Me.tsLogOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsLogOut.Name = "tsLogOut"
        Me.tsLogOut.Size = New System.Drawing.Size(28, 28)
        Me.tsLogOut.Text = "Log out"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1539, 943)
        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NHIS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ssStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProviderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClaimsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DashboardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegisterProviderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewProvidersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClaimsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SubmitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchClaimsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ApproveClaimsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RejectedClaimsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DailyReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MonthlyReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ApprovedClaimsReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RejectedClaimsReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageUsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutSystemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsHome As ToolStripButton
    Friend WithEvents tsNewClaim As ToolStripButton
    Friend WithEvents tsViewClaims As ToolStripButton
    Friend WithEvents tsProviders As ToolStripButton
    Friend WithEvents tsApprove As ToolStripButton
    Friend WithEvents tsReject As ToolStripButton
    Friend WithEvents tsReports As ToolStripButton
    Friend WithEvents tsPrint As ToolStripButton
    Friend WithEvents tsSave As ToolStripButton
    Friend WithEvents tsLogOut As ToolStripButton
    Friend WithEvents pnlContent As Panel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
End Class
