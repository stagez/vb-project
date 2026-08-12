<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewClaims
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvViewClaims = New System.Windows.Forms.DataGridView()
        Me.colClaimID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPhone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblViewMembers = New System.Windows.Forms.Label()
        CType(Me.dgvViewClaims, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvViewClaims
        '
        Me.dgvViewClaims.AllowUserToAddRows = False
        Me.dgvViewClaims.AllowUserToDeleteRows = False
        Me.dgvViewClaims.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvViewClaims.BackgroundColor = System.Drawing.Color.White
        Me.dgvViewClaims.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(89, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvViewClaims.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvViewClaims.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvViewClaims.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colClaimID, Me.DataGridViewTextBoxColumn1, Me.colDate, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.colPhone})
        Me.dgvViewClaims.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvViewClaims.EnableHeadersVisualStyles = False
        Me.dgvViewClaims.Location = New System.Drawing.Point(40, 120)
        Me.dgvViewClaims.Name = "dgvViewClaims"
        Me.dgvViewClaims.ReadOnly = True
        Me.dgvViewClaims.RowHeadersVisible = False
        Me.dgvViewClaims.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvViewClaims.Size = New System.Drawing.Size(1176, 551)
        Me.dgvViewClaims.TabIndex = 8
        '
        'colClaimID
        '
        Me.colClaimID.HeaderText = "Claim ID"
        Me.colClaimID.Name = "colClaimID"
        Me.colClaimID.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Provider"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'colDate
        '
        Me.colDate.HeaderText = "Membership TYpe"
        Me.colDate.Name = "colDate"
        Me.colDate.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Service Date"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Amount(GHS)"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'colPhone
        '
        Me.colPhone.HeaderText = "Status"
        Me.colPhone.Name = "colPhone"
        Me.colPhone.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnGenerate)
        Me.Panel1.Controls.Add(Me.btnRefresh)
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.lblViewMembers)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(40, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1176, 96)
        Me.Panel1.TabIndex = 7
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(444, 20)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(150, 40)
        Me.btnGenerate.TabIndex = 4
        Me.btnGenerate.Text = "Generate Report"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(780, 5)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(124, 38)
        Me.btnRefresh.TabIndex = 2
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(952, 0)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(224, 26)
        Me.txtSearch.TabIndex = 1
        '
        'lblViewMembers
        '
        Me.lblViewMembers.AutoSize = True
        Me.lblViewMembers.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblViewMembers.Location = New System.Drawing.Point(17, 2)
        Me.lblViewMembers.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblViewMembers.Name = "lblViewMembers"
        Me.lblViewMembers.Size = New System.Drawing.Size(175, 38)
        Me.lblViewMembers.TabIndex = 3
        Me.lblViewMembers.Text = "View Claims"
        '
        'ViewClaims
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1256, 695)
        Me.Controls.Add(Me.dgvViewClaims)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ViewClaims"
        Me.Padding = New System.Windows.Forms.Padding(40, 24, 40, 24)
        Me.Text = "frmViewClaims"
        CType(Me.dgvViewClaims, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvViewClaims As DataGridView
    Friend WithEvents colClaimID As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents colDate As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents colPhone As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnRefresh As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblViewMembers As Label
    Friend WithEvents btnGenerate As Button
End Class
