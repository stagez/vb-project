<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboard
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlTotal = New System.Windows.Forms.Panel()
        Me.lblTotalCount = New System.Windows.Forms.Label()
        Me.lblTotalClaimsTitle = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlCards = New System.Windows.Forms.Panel()
        Me.lblPendingCount = New System.Windows.Forms.Label()
        Me.lblPendingTitle = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblApprovedCount = New System.Windows.Forms.Label()
        Me.lblApprovedTitle = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblRejectedCount = New System.Windows.Forms.Label()
        Me.lblRejectedTitle = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lblRecentTitle = New System.Windows.Forms.Label()
        Me.dgvClaims = New System.Windows.Forms.DataGridView()
        Me.colClaimID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colProvider = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.pnlTotal.SuspendLayout()
        Me.pnlCards.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgvClaims, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.pnlTotal, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pnlCards, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 3, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(40, 24)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(853, 130)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'pnlTotal
        '
        Me.pnlTotal.BackColor = System.Drawing.Color.White
        Me.pnlTotal.Controls.Add(Me.lblTotalCount)
        Me.pnlTotal.Controls.Add(Me.lblTotalClaimsTitle)
        Me.pnlTotal.Controls.Add(Me.Panel1)
        Me.pnlTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTotal.Location = New System.Drawing.Point(0, 0)
        Me.pnlTotal.Margin = New System.Windows.Forms.Padding(0, 0, 12, 0)
        Me.pnlTotal.Name = "pnlTotal"
        Me.pnlTotal.Padding = New System.Windows.Forms.Padding(16)
        Me.pnlTotal.Size = New System.Drawing.Size(201, 130)
        Me.pnlTotal.TabIndex = 0
        '
        'lblTotalCount
        '
        Me.lblTotalCount.AutoSize = True
        Me.lblTotalCount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTotalCount.Font = New System.Drawing.Font("Segoe UI", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblTotalCount.Location = New System.Drawing.Point(22, 44)
        Me.lblTotalCount.Name = "lblTotalCount"
        Me.lblTotalCount.Size = New System.Drawing.Size(42, 59)
        Me.lblTotalCount.TabIndex = 2
        Me.lblTotalCount.Text = "-"
        Me.lblTotalCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalClaimsTitle
        '
        Me.lblTotalClaimsTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTotalClaimsTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.lblTotalClaimsTitle.Location = New System.Drawing.Point(22, 16)
        Me.lblTotalClaimsTitle.Name = "lblTotalClaimsTitle"
        Me.lblTotalClaimsTitle.Size = New System.Drawing.Size(163, 28)
        Me.lblTotalClaimsTitle.TabIndex = 1
        Me.lblTotalClaimsTitle.Text = "Total Claims"
        Me.lblTotalClaimsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(16, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(6, 98)
        Me.Panel1.TabIndex = 0
        '
        'pnlCards
        '
        Me.pnlCards.BackColor = System.Drawing.Color.White
        Me.pnlCards.Controls.Add(Me.lblPendingCount)
        Me.pnlCards.Controls.Add(Me.lblPendingTitle)
        Me.pnlCards.Controls.Add(Me.Panel5)
        Me.pnlCards.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCards.Location = New System.Drawing.Point(213, 0)
        Me.pnlCards.Margin = New System.Windows.Forms.Padding(0, 0, 12, 0)
        Me.pnlCards.Name = "pnlCards"
        Me.pnlCards.Padding = New System.Windows.Forms.Padding(16)
        Me.pnlCards.Size = New System.Drawing.Size(201, 130)
        Me.pnlCards.TabIndex = 1
        '
        'lblPendingCount
        '
        Me.lblPendingCount.AutoSize = True
        Me.lblPendingCount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPendingCount.Font = New System.Drawing.Font("Segoe UI", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPendingCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblPendingCount.Location = New System.Drawing.Point(22, 44)
        Me.lblPendingCount.Name = "lblPendingCount"
        Me.lblPendingCount.Size = New System.Drawing.Size(42, 59)
        Me.lblPendingCount.TabIndex = 2
        Me.lblPendingCount.Text = "-"
        Me.lblPendingCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPendingTitle
        '
        Me.lblPendingTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPendingTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.lblPendingTitle.Location = New System.Drawing.Point(22, 16)
        Me.lblPendingTitle.Name = "lblPendingTitle"
        Me.lblPendingTitle.Size = New System.Drawing.Size(163, 28)
        Me.lblPendingTitle.TabIndex = 1
        Me.lblPendingTitle.Text = "Pending"
        Me.lblPendingTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(16, 16)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(6, 98)
        Me.Panel5.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.lblApprovedCount)
        Me.Panel3.Controls.Add(Me.lblApprovedTitle)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(426, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0, 0, 12, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(16)
        Me.Panel3.Size = New System.Drawing.Size(201, 130)
        Me.Panel3.TabIndex = 2
        '
        'lblApprovedCount
        '
        Me.lblApprovedCount.AutoSize = True
        Me.lblApprovedCount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblApprovedCount.Font = New System.Drawing.Font("Segoe UI", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApprovedCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblApprovedCount.Location = New System.Drawing.Point(22, 44)
        Me.lblApprovedCount.Name = "lblApprovedCount"
        Me.lblApprovedCount.Size = New System.Drawing.Size(42, 59)
        Me.lblApprovedCount.TabIndex = 2
        Me.lblApprovedCount.Text = "-"
        Me.lblApprovedCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblApprovedTitle
        '
        Me.lblApprovedTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblApprovedTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.lblApprovedTitle.Location = New System.Drawing.Point(22, 16)
        Me.lblApprovedTitle.Name = "lblApprovedTitle"
        Me.lblApprovedTitle.Size = New System.Drawing.Size(163, 28)
        Me.lblApprovedTitle.TabIndex = 1
        Me.lblApprovedTitle.Text = "Approved"
        Me.lblApprovedTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(16, 16)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(6, 98)
        Me.Panel6.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.lblRejectedCount)
        Me.Panel4.Controls.Add(Me.lblRejectedTitle)
        Me.Panel4.Controls.Add(Me.Panel7)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(639, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(0, 0, 12, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(16)
        Me.Panel4.Size = New System.Drawing.Size(202, 130)
        Me.Panel4.TabIndex = 3
        '
        'lblRejectedCount
        '
        Me.lblRejectedCount.AutoSize = True
        Me.lblRejectedCount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRejectedCount.Font = New System.Drawing.Font("Segoe UI", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRejectedCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblRejectedCount.Location = New System.Drawing.Point(22, 44)
        Me.lblRejectedCount.Name = "lblRejectedCount"
        Me.lblRejectedCount.Size = New System.Drawing.Size(42, 59)
        Me.lblRejectedCount.TabIndex = 2
        Me.lblRejectedCount.Text = "-"
        Me.lblRejectedCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRejectedTitle
        '
        Me.lblRejectedTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRejectedTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.lblRejectedTitle.Location = New System.Drawing.Point(22, 16)
        Me.lblRejectedTitle.Name = "lblRejectedTitle"
        Me.lblRejectedTitle.Size = New System.Drawing.Size(164, 28)
        Me.lblRejectedTitle.TabIndex = 1
        Me.lblRejectedTitle.Text = "Rejected"
        Me.lblRejectedTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(16, 16)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(6, 98)
        Me.Panel7.TabIndex = 0
        '
        'lblRecentTitle
        '
        Me.lblRecentTitle.AutoSize = True
        Me.lblRecentTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRecentTitle.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecentTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.lblRecentTitle.Location = New System.Drawing.Point(40, 154)
        Me.lblRecentTitle.Name = "lblRecentTitle"
        Me.lblRecentTitle.Size = New System.Drawing.Size(107, 20)
        Me.lblRecentTitle.TabIndex = 1
        Me.lblRecentTitle.Text = "Recent Claims"
        Me.lblRecentTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'dgvClaims
        '
        Me.dgvClaims.AllowUserToAddRows = False
        Me.dgvClaims.AllowUserToDeleteRows = False
        Me.dgvClaims.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvClaims.BackgroundColor = System.Drawing.Color.White
        Me.dgvClaims.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(89, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvClaims.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvClaims.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClaims.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colClaimID, Me.colProvider, Me.colDate, Me.colAmount, Me.colStatus})
        Me.dgvClaims.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvClaims.EnableHeadersVisualStyles = False
        Me.dgvClaims.Location = New System.Drawing.Point(40, 174)
        Me.dgvClaims.Name = "dgvClaims"
        Me.dgvClaims.ReadOnly = True
        Me.dgvClaims.RowHeadersVisible = False
        Me.dgvClaims.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClaims.Size = New System.Drawing.Size(853, 321)
        Me.dgvClaims.TabIndex = 2
        '
        'colClaimID
        '
        Me.colClaimID.HeaderText = "Claim ID"
        Me.colClaimID.Name = "colClaimID"
        Me.colClaimID.ReadOnly = True
        '
        'colProvider
        '
        Me.colProvider.HeaderText = "Provider"
        Me.colProvider.Name = "colProvider"
        Me.colProvider.ReadOnly = True
        '
        'colDate
        '
        Me.colDate.HeaderText = "Date"
        Me.colDate.Name = "colDate"
        Me.colDate.ReadOnly = True
        '
        'colAmount
        '
        Me.colAmount.HeaderText = "Amount(GHS)"
        Me.colAmount.Name = "colAmount"
        Me.colAmount.ReadOnly = True
        '
        'colStatus
        '
        Me.colStatus.HeaderText = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.ReadOnly = True
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(933, 519)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgvClaims)
        Me.Controls.Add(Me.lblRecentTitle)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDashboard"
        Me.Padding = New System.Windows.Forms.Padding(40, 24, 40, 24)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.pnlTotal.ResumeLayout(False)
        Me.pnlTotal.PerformLayout()
        Me.pnlCards.ResumeLayout(False)
        Me.pnlCards.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.dgvClaims, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents pnlTotal As Panel
    Friend WithEvents pnlCards As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents lblTotalCount As Label
    Friend WithEvents lblTotalClaimsTitle As Label
    Friend WithEvents lblPendingCount As Label
    Friend WithEvents lblPendingTitle As Label
    Friend WithEvents lblApprovedCount As Label
    Friend WithEvents lblApprovedTitle As Label
    Friend WithEvents lblRejectedCount As Label
    Friend WithEvents lblRejectedTitle As Label
    Friend WithEvents lblRecentTitle As Label
    Friend WithEvents dgvClaims As DataGridView
    Friend WithEvents colClaimID As DataGridViewTextBoxColumn
    Friend WithEvents colProvider As DataGridViewTextBoxColumn
    Friend WithEvents colDate As DataGridViewTextBoxColumn
    Friend WithEvents colAmount As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
End Class
