<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewMembers
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.lblViewMembers = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dvgViewMembers = New System.Windows.Forms.DataGridView()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.colMemberID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFullname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNHISNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMembershipType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPhoneNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRegion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlMain.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dvgViewMembers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.lblViewMembers)
        Me.pnlMain.Controls.Add(Me.btnRefresh)
        Me.pnlMain.Controls.Add(Me.Panel1)
        Me.pnlMain.Controls.Add(Me.txtSearch)
        Me.pnlMain.Location = New System.Drawing.Point(51, 18)
        Me.pnlMain.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1072, 655)
        Me.pnlMain.TabIndex = 0
        '
        'lblViewMembers
        '
        Me.lblViewMembers.AutoSize = True
        Me.lblViewMembers.Location = New System.Drawing.Point(34, 22)
        Me.lblViewMembers.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblViewMembers.Name = "lblViewMembers"
        Me.lblViewMembers.Size = New System.Drawing.Size(105, 20)
        Me.lblViewMembers.TabIndex = 3
        Me.lblViewMembers.Text = "View Member"
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(676, 22)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(124, 38)
        Me.btnRefresh.TabIndex = 2
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dvgViewMembers)
        Me.Panel1.Location = New System.Drawing.Point(39, 192)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(998, 354)
        Me.Panel1.TabIndex = 0
        '
        'dvgViewMembers
        '
        Me.dvgViewMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgViewMembers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colMemberID, Me.colFullname, Me.colNHISNumber, Me.colMembershipType, Me.colGender, Me.colPhoneNumber, Me.colRegion})
        Me.dvgViewMembers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dvgViewMembers.Location = New System.Drawing.Point(0, 0)
        Me.dvgViewMembers.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dvgViewMembers.Name = "dvgViewMembers"
        Me.dvgViewMembers.Size = New System.Drawing.Size(998, 354)
        Me.dvgViewMembers.TabIndex = 0
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(810, 26)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(224, 26)
        Me.txtSearch.TabIndex = 1
        '
        'colMemberID
        '
        Me.colMemberID.HeaderText = "MemberID"
        Me.colMemberID.Name = "colMemberID"
        '
        'colFullname
        '
        Me.colFullname.HeaderText = "Full Name"
        Me.colFullname.Name = "colFullname"
        '
        'colNHISNumber
        '
        Me.colNHISNumber.HeaderText = "NHIS Number"
        Me.colNHISNumber.Name = "colNHISNumber"
        '
        'colMembershipType
        '
        Me.colMembershipType.HeaderText = "Membership Type"
        Me.colMembershipType.Name = "colMembershipType"
        '
        'colGender
        '
        Me.colGender.HeaderText = "Gender"
        Me.colGender.Name = "colGender"
        '
        'colPhoneNumber
        '
        Me.colPhoneNumber.HeaderText = "Phone Number"
        Me.colPhoneNumber.Name = "colPhoneNumber"
        '
        'colRegion
        '
        Me.colRegion.HeaderText = "Region"
        Me.colRegion.Name = "colRegion"
        '
        'frmViewMembers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.pnlMain)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmViewMembers"
        Me.Text = "frmViewMembers"
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dvgViewMembers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dvgViewMembers As DataGridView
    Friend WithEvents lblViewMembers As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents colMemberID As DataGridViewTextBoxColumn
    Friend WithEvents colFullname As DataGridViewTextBoxColumn
    Friend WithEvents colNHISNumber As DataGridViewTextBoxColumn
    Friend WithEvents colMembershipType As DataGridViewTextBoxColumn
    Friend WithEvents colGender As DataGridViewTextBoxColumn
    Friend WithEvents colPhoneNumber As DataGridViewTextBoxColumn
    Friend WithEvents colRegion As DataGridViewTextBoxColumn
End Class
