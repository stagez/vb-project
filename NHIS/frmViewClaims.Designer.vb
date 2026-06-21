<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewClaims
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
        Me.lblReviewClaims = New System.Windows.Forms.Label()
        Me.dgvReviewClaims = New System.Windows.Forms.DataGridView()
        Me.pnlReviewClaims = New System.Windows.Forms.Panel()
        Me.colClaimNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colProvider = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMember = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colServiceDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvReviewClaims, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlReviewClaims.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblReviewClaims
        '
        Me.lblReviewClaims.AutoSize = True
        Me.lblReviewClaims.Location = New System.Drawing.Point(313, 27)
        Me.lblReviewClaims.Name = "lblReviewClaims"
        Me.lblReviewClaims.Size = New System.Drawing.Size(111, 20)
        Me.lblReviewClaims.TabIndex = 0
        Me.lblReviewClaims.Text = "Claims Review"
        '
        'dgvReviewClaims
        '
        Me.dgvReviewClaims.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReviewClaims.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colClaimNumber, Me.colProvider, Me.colMember, Me.colServiceDate, Me.colAmount, Me.colStatus})
        Me.dgvReviewClaims.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvReviewClaims.Location = New System.Drawing.Point(0, 0)
        Me.dgvReviewClaims.Name = "dgvReviewClaims"
        Me.dgvReviewClaims.RowTemplate.Height = 28
        Me.dgvReviewClaims.Size = New System.Drawing.Size(800, 283)
        Me.dgvReviewClaims.TabIndex = 1
        '
        'pnlReviewClaims
        '
        Me.pnlReviewClaims.Controls.Add(Me.dgvReviewClaims)
        Me.pnlReviewClaims.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlReviewClaims.Location = New System.Drawing.Point(0, 167)
        Me.pnlReviewClaims.Name = "pnlReviewClaims"
        Me.pnlReviewClaims.Size = New System.Drawing.Size(800, 283)
        Me.pnlReviewClaims.TabIndex = 2
        '
        'colClaimNumber
        '
        Me.colClaimNumber.HeaderText = "Claim Number"
        Me.colClaimNumber.Name = "colClaimNumber"
        '
        'colProvider
        '
        Me.colProvider.HeaderText = "Provider"
        Me.colProvider.Name = "colProvider"
        '
        'colMember
        '
        Me.colMember.HeaderText = "Member"
        Me.colMember.Name = "colMember"
        '
        'colServiceDate
        '
        Me.colServiceDate.HeaderText = "Service Date"
        Me.colServiceDate.Name = "colServiceDate"
        '
        'colAmount
        '
        Me.colAmount.HeaderText = "Amount"
        Me.colAmount.Name = "colAmount"
        '
        'colStatus
        '
        Me.colStatus.HeaderText = "Status"
        Me.colStatus.Name = "colStatus"
        '
        'frmViewClaims
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pnlReviewClaims)
        Me.Controls.Add(Me.lblReviewClaims)
        Me.Name = "frmViewClaims"
        Me.Text = "frmViewClaims"
        CType(Me.dgvReviewClaims, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlReviewClaims.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblReviewClaims As Label
    Friend WithEvents dgvReviewClaims As DataGridView
    Friend WithEvents pnlReviewClaims As Panel
    Friend WithEvents colClaimNumber As DataGridViewTextBoxColumn
    Friend WithEvents colProvider As DataGridViewTextBoxColumn
    Friend WithEvents colMember As DataGridViewTextBoxColumn
    Friend WithEvents colServiceDate As DataGridViewTextBoxColumn
    Friend WithEvents colAmount As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
End Class
