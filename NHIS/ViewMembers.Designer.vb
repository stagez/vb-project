<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewMembers
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblViewMembers = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvMembers = New System.Windows.Forms.DataGridView()
        Me.colClaimID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colProvider = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPhone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRegio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvMembers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblViewMembers
        '
        Me.lblViewMembers.AutoSize = True
        Me.lblViewMembers.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblViewMembers.Location = New System.Drawing.Point(11, 1)
        Me.lblViewMembers.Name = "lblViewMembers"
        Me.lblViewMembers.Size = New System.Drawing.Size(212, 38)
        Me.lblViewMembers.TabIndex = 3
        Me.lblViewMembers.Text = "View Members"
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(391, 5)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(83, 25)
        Me.btnRefresh.TabIndex = 2
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(480, 7)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(151, 29)
        Me.txtSearch.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnRefresh)
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.lblViewMembers)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(27, 16)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(668, 62)
        Me.Panel1.TabIndex = 5
        '
        'dgvMembers
        '
        Me.dgvMembers.AllowUserToAddRows = False
        Me.dgvMembers.AllowUserToDeleteRows = False
        Me.dgvMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMembers.BackgroundColor = System.Drawing.Color.White
        Me.dgvMembers.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(89, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMembers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMembers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colClaimID, Me.colProvider, Me.colDate, Me.colAmount, Me.colStatus, Me.colPhone, Me.colRegio})
        Me.dgvMembers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMembers.EnableHeadersVisualStyles = False
        Me.dgvMembers.Location = New System.Drawing.Point(27, 78)
        Me.dgvMembers.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvMembers.Name = "dgvMembers"
        Me.dgvMembers.ReadOnly = True
        Me.dgvMembers.RowHeadersVisible = False
        Me.dgvMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMembers.Size = New System.Drawing.Size(668, 343)
        Me.dgvMembers.TabIndex = 6
        '
        'colClaimID
        '
        Me.colClaimID.HeaderText = "Member ID"
        Me.colClaimID.Name = "colClaimID"
        Me.colClaimID.ReadOnly = True
        '
        'colProvider
        '
        Me.colProvider.HeaderText = "Full Name"
        Me.colProvider.Name = "colProvider"
        Me.colProvider.ReadOnly = True
        '
        'colDate
        '
        Me.colDate.HeaderText = "NHIS Number"
        Me.colDate.Name = "colDate"
        Me.colDate.ReadOnly = True
        '
        'colAmount
        '
        Me.colAmount.HeaderText = "Membership Type"
        Me.colAmount.Name = "colAmount"
        Me.colAmount.ReadOnly = True
        '
        'colStatus
        '
        Me.colStatus.HeaderText = "Gender"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.ReadOnly = True
        '
        'colPhone
        '
        Me.colPhone.HeaderText = "Phone Number"
        Me.colPhone.Name = "colPhone"
        Me.colPhone.ReadOnly = True
        '
        'colRegio
        '
        Me.colRegio.HeaderText = "Region"
        Me.colRegio.Name = "colRegio"
        Me.colRegio.ReadOnly = True
        '
        'ViewMembers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 437)
        Me.Controls.Add(Me.dgvMembers)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "ViewMembers"
        Me.Padding = New System.Windows.Forms.Padding(27, 16, 27, 16)
        Me.Text = "frmViewMembers"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvMembers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblViewMembers As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvMembers As DataGridView
    Friend WithEvents colClaimID As DataGridViewTextBoxColumn
    Friend WithEvents colProvider As DataGridViewTextBoxColumn
    Friend WithEvents colDate As DataGridViewTextBoxColumn
    Friend WithEvents colAmount As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents colPhone As DataGridViewTextBoxColumn
    Friend WithEvents colRegio As DataGridViewTextBoxColumn
End Class
