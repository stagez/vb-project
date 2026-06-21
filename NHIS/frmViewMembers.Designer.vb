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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dvgViewMembers = New System.Windows.Forms.DataGridView()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.lblViewMembers = New System.Windows.Forms.Label()
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
        Me.pnlMain.Location = New System.Drawing.Point(34, 12)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(715, 426)
        Me.pnlMain.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dvgViewMembers)
        Me.Panel1.Location = New System.Drawing.Point(26, 125)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(665, 230)
        Me.Panel1.TabIndex = 0
        '
        'dvgViewMembers
        '
        Me.dvgViewMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgViewMembers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dvgViewMembers.Location = New System.Drawing.Point(0, 0)
        Me.dvgViewMembers.Name = "dvgViewMembers"
        Me.dvgViewMembers.Size = New System.Drawing.Size(665, 230)
        Me.dvgViewMembers.TabIndex = 0
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(540, 17)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(151, 20)
        Me.txtSearch.TabIndex = 1
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(451, 14)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(83, 25)
        Me.btnRefresh.TabIndex = 2
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'lblViewMembers
        '
        Me.lblViewMembers.AutoSize = True
        Me.lblViewMembers.Location = New System.Drawing.Point(23, 14)
        Me.lblViewMembers.Name = "lblViewMembers"
        Me.lblViewMembers.Size = New System.Drawing.Size(71, 13)
        Me.lblViewMembers.TabIndex = 3
        Me.lblViewMembers.Text = "View Member"
        '
        'frmViewMembers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pnlMain)
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
End Class
