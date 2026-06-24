<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewProviders
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvViewProviders = New System.Windows.Forms.DataGridView()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.lblProvidersTitle = New System.Windows.Forms.Label()
        Me.colProviderID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colProviderName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colProviderType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPhonneNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colProviderLocation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlMain.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvViewProviders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.Panel2)
        Me.pnlMain.Controls.Add(Me.txtSearch)
        Me.pnlMain.Controls.Add(Me.lblSearch)
        Me.pnlMain.Controls.Add(Me.lblProvidersTitle)
        Me.pnlMain.Location = New System.Drawing.Point(18, 18)
        Me.pnlMain.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1164, 655)
        Me.pnlMain.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgvViewProviders)
        Me.Panel2.Location = New System.Drawing.Point(54, 143)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1065, 480)
        Me.Panel2.TabIndex = 3
        '
        'dgvViewProviders
        '
        Me.dgvViewProviders.AllowUserToDeleteRows = False
        Me.dgvViewProviders.AllowUserToResizeColumns = False
        Me.dgvViewProviders.AllowUserToResizeRows = False
        Me.dgvViewProviders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvViewProviders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colProviderID, Me.colProviderName, Me.colProviderType, Me.colPhonneNumber, Me.colProviderLocation})
        Me.dgvViewProviders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvViewProviders.Location = New System.Drawing.Point(0, 0)
        Me.dgvViewProviders.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvViewProviders.Name = "dgvViewProviders"
        Me.dgvViewProviders.Size = New System.Drawing.Size(1065, 480)
        Me.dgvViewProviders.TabIndex = 0
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(969, 25)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(148, 26)
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
        Me.lblProvidersTitle.Location = New System.Drawing.Point(70, 35)
        Me.lblProvidersTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProvidersTitle.Name = "lblProvidersTitle"
        Me.lblProvidersTitle.Size = New System.Drawing.Size(148, 40)
        Me.lblProvidersTitle.TabIndex = 0
        Me.lblProvidersTitle.Text = "Providers"
        '
        'colProviderID
        '
        Me.colProviderID.HeaderText = "Provider ID"
        Me.colProviderID.Name = "colProviderID"
        '
        'colProviderName
        '
        Me.colProviderName.HeaderText = "Provider Name"
        Me.colProviderName.Name = "colProviderName"
        '
        'colProviderType
        '
        Me.colProviderType.HeaderText = "Provider Type"
        Me.colProviderType.Name = "colProviderType"
        '
        'colPhonneNumber
        '
        Me.colPhonneNumber.HeaderText = "Phone Number"
        Me.colPhonneNumber.Name = "colPhonneNumber"
        '
        'colProviderLocation
        '
        Me.colProviderLocation.HeaderText = "Provider Location"
        Me.colProviderLocation.Name = "colProviderLocation"
        '
        'frmViewProviders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.pnlMain)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmViewProviders"
        Me.Text = "frmViewProviders"
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvViewProviders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents lblSearch As Label
    Friend WithEvents lblProvidersTitle As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dgvViewProviders As DataGridView
    Friend WithEvents colProviderID As DataGridViewTextBoxColumn
    Friend WithEvents colProviderName As DataGridViewTextBoxColumn
    Friend WithEvents colProviderType As DataGridViewTextBoxColumn
    Friend WithEvents colPhonneNumber As DataGridViewTextBoxColumn
    Friend WithEvents colProviderLocation As DataGridViewTextBoxColumn
End Class
