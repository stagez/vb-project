<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewProviders
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
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.lblProvidersTitle = New System.Windows.Forms.Label()
        Me.dgvViewProviders = New System.Windows.Forms.DataGridView()
        Me.colClaimID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colProvider = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPhone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRegio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlMain.SuspendLayout()
        CType(Me.dgvViewProviders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.txtSearch)
        Me.pnlMain.Controls.Add(Me.lblSearch)
        Me.pnlMain.Controls.Add(Me.lblProvidersTitle)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlMain.Location = New System.Drawing.Point(40, 24)
        Me.pnlMain.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1120, 125)
        Me.pnlMain.TabIndex = 0
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(925, 25)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(195, 26)
        Me.txtSearch.TabIndex = 2
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(852, 29)
        Me.lblSearch.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(60, 20)
        Me.lblSearch.TabIndex = 1
        Me.lblSearch.Text = "Search"
        '
        'lblProvidersTitle
        '
        Me.lblProvidersTitle.AutoSize = True
        Me.lblProvidersTitle.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProvidersTitle.Location = New System.Drawing.Point(23, 29)
        Me.lblProvidersTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProvidersTitle.Name = "lblProvidersTitle"
        Me.lblProvidersTitle.Size = New System.Drawing.Size(148, 40)
        Me.lblProvidersTitle.TabIndex = 0
        Me.lblProvidersTitle.Text = "Providers"
        '
        'dgvViewProviders
        '
        Me.dgvViewProviders.AllowUserToAddRows = False
        Me.dgvViewProviders.AllowUserToDeleteRows = False
        Me.dgvViewProviders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvViewProviders.BackgroundColor = System.Drawing.Color.White
        Me.dgvViewProviders.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(89, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvViewProviders.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvViewProviders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvViewProviders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colClaimID, Me.colProvider, Me.colDate, Me.colPhone, Me.colRegio})
        Me.dgvViewProviders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvViewProviders.EnableHeadersVisualStyles = False
        Me.dgvViewProviders.Location = New System.Drawing.Point(40, 149)
        Me.dgvViewProviders.Name = "dgvViewProviders"
        Me.dgvViewProviders.ReadOnly = True
        Me.dgvViewProviders.RowHeadersVisible = False
        Me.dgvViewProviders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvViewProviders.Size = New System.Drawing.Size(1120, 519)
        Me.dgvViewProviders.TabIndex = 7
        '
        'colClaimID
        '
        Me.colClaimID.HeaderText = "Provider ID"
        Me.colClaimID.Name = "colClaimID"
        Me.colClaimID.ReadOnly = True
        '
        'colProvider
        '
        Me.colProvider.HeaderText = "Provider Name"
        Me.colProvider.Name = "colProvider"
        Me.colProvider.ReadOnly = True
        '
        'colDate
        '
        Me.colDate.HeaderText = "Provider Type"
        Me.colDate.Name = "colDate"
        Me.colDate.ReadOnly = True
        '
        'colPhone
        '
        Me.colPhone.HeaderText = "Phone Number"
        Me.colPhone.Name = "colPhone"
        Me.colPhone.ReadOnly = True
        '
        'colRegio
        '
        Me.colRegio.HeaderText = "Provider Location"
        Me.colRegio.Name = "colRegio"
        Me.colRegio.ReadOnly = True
        '
        'frmViewProviders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.dgvViewProviders)
        Me.Controls.Add(Me.pnlMain)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmViewProviders"
        Me.Padding = New System.Windows.Forms.Padding(40, 24, 40, 24)
        Me.Text = "frmViewProviders"
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        CType(Me.dgvViewProviders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents lblSearch As Label
    Friend WithEvents lblProvidersTitle As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dgvViewProviders As DataGridView
    Friend WithEvents colClaimID As DataGridViewTextBoxColumn
    Friend WithEvents colProvider As DataGridViewTextBoxColumn
    Friend WithEvents colDate As DataGridViewTextBoxColumn
    Friend WithEvents colPhone As DataGridViewTextBoxColumn
    Friend WithEvents colRegio As DataGridViewTextBoxColumn
End Class
