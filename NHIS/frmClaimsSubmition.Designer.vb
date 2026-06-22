<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClaimsSubmition
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
        Me.frmClaimsPanel = New System.Windows.Forms.Panel()
        Me.nudClaimAmount = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.rtbTreatment = New System.Windows.Forms.RichTextBox()
        Me.txtPatientName = New System.Windows.Forms.TextBox()
        Me.rtpDiagnosis = New System.Windows.Forms.RichTextBox()
        Me.dtpServiceDate = New System.Windows.Forms.DateTimePicker()
        Me.cboProvider = New System.Windows.Forms.ComboBox()
        Me.txtNHISNumber = New System.Windows.Forms.TextBox()
        Me.txtClaimNumber = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSubmitClaim = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblClaimsSubmission = New System.Windows.Forms.Label()
        Me.frmClaimsPanel.SuspendLayout()
        CType(Me.nudClaimAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'frmClaimsPanel
        '
        Me.frmClaimsPanel.Controls.Add(Me.nudClaimAmount)
        Me.frmClaimsPanel.Controls.Add(Me.Label8)
        Me.frmClaimsPanel.Controls.Add(Me.rtbTreatment)
        Me.frmClaimsPanel.Controls.Add(Me.txtPatientName)
        Me.frmClaimsPanel.Controls.Add(Me.rtpDiagnosis)
        Me.frmClaimsPanel.Controls.Add(Me.dtpServiceDate)
        Me.frmClaimsPanel.Controls.Add(Me.cboProvider)
        Me.frmClaimsPanel.Controls.Add(Me.txtNHISNumber)
        Me.frmClaimsPanel.Controls.Add(Me.txtClaimNumber)
        Me.frmClaimsPanel.Controls.Add(Me.btnClear)
        Me.frmClaimsPanel.Controls.Add(Me.btnSubmitClaim)
        Me.frmClaimsPanel.Controls.Add(Me.Label7)
        Me.frmClaimsPanel.Controls.Add(Me.Label6)
        Me.frmClaimsPanel.Controls.Add(Me.Label5)
        Me.frmClaimsPanel.Controls.Add(Me.Label4)
        Me.frmClaimsPanel.Controls.Add(Me.Label3)
        Me.frmClaimsPanel.Controls.Add(Me.Label2)
        Me.frmClaimsPanel.Controls.Add(Me.Label1)
        Me.frmClaimsPanel.Location = New System.Drawing.Point(28, 142)
        Me.frmClaimsPanel.Name = "frmClaimsPanel"
        Me.frmClaimsPanel.Size = New System.Drawing.Size(648, 330)
        Me.frmClaimsPanel.TabIndex = 0
        '
        'nudClaimAmount
        '
        Me.nudClaimAmount.Location = New System.Drawing.Point(390, 187)
        Me.nudClaimAmount.Name = "nudClaimAmount"
        Me.nudClaimAmount.Size = New System.Drawing.Size(176, 20)
        Me.nudClaimAmount.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(313, 187)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Claim Amount"
        '
        'rtbTreatment
        '
        Me.rtbTreatment.Location = New System.Drawing.Point(109, 172)
        Me.rtbTreatment.Name = "rtbTreatment"
        Me.rtbTreatment.Size = New System.Drawing.Size(111, 33)
        Me.rtbTreatment.TabIndex = 16
        Me.rtbTreatment.Text = ""
        '
        'txtPatientName
        '
        Me.txtPatientName.Location = New System.Drawing.Point(390, 25)
        Me.txtPatientName.Name = "txtPatientName"
        Me.txtPatientName.Size = New System.Drawing.Size(192, 20)
        Me.txtPatientName.TabIndex = 15
        '
        'rtpDiagnosis
        '
        Me.rtpDiagnosis.Location = New System.Drawing.Point(390, 113)
        Me.rtpDiagnosis.Name = "rtpDiagnosis"
        Me.rtpDiagnosis.Size = New System.Drawing.Size(108, 33)
        Me.rtpDiagnosis.TabIndex = 14
        Me.rtpDiagnosis.Text = ""
        '
        'dtpServiceDate
        '
        Me.dtpServiceDate.Location = New System.Drawing.Point(390, 72)
        Me.dtpServiceDate.Name = "dtpServiceDate"
        Me.dtpServiceDate.Size = New System.Drawing.Size(197, 20)
        Me.dtpServiceDate.TabIndex = 13
        '
        'cboProvider
        '
        Me.cboProvider.FormattingEnabled = True
        Me.cboProvider.Location = New System.Drawing.Point(109, 69)
        Me.cboProvider.Name = "cboProvider"
        Me.cboProvider.Size = New System.Drawing.Size(171, 21)
        Me.cboProvider.TabIndex = 12
        '
        'txtNHISNumber
        '
        Me.txtNHISNumber.Location = New System.Drawing.Point(109, 126)
        Me.txtNHISNumber.Name = "txtNHISNumber"
        Me.txtNHISNumber.Size = New System.Drawing.Size(171, 20)
        Me.txtNHISNumber.TabIndex = 11
        '
        'txtClaimNumber
        '
        Me.txtClaimNumber.Location = New System.Drawing.Point(109, 25)
        Me.txtClaimNumber.Name = "txtClaimNumber"
        Me.txtClaimNumber.Size = New System.Drawing.Size(171, 20)
        Me.txtClaimNumber.TabIndex = 9
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(390, 236)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 45)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSubmitClaim
        '
        Me.btnSubmitClaim.Location = New System.Drawing.Point(145, 236)
        Me.btnSubmitClaim.Name = "btnSubmitClaim"
        Me.btnSubmitClaim.Size = New System.Drawing.Size(75, 45)
        Me.btnSubmitClaim.TabIndex = 7
        Me.btnSubmitClaim.Text = "Submit Claim"
        Me.btnSubmitClaim.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Treatment"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(313, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Diagnosis"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(313, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Service Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(313, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Patient Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "NHIS Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Provider"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Claim Number"
        '
        'lblClaimsSubmission
        '
        Me.lblClaimsSubmission.AutoSize = True
        Me.lblClaimsSubmission.Location = New System.Drawing.Point(248, 31)
        Me.lblClaimsSubmission.Name = "lblClaimsSubmission"
        Me.lblClaimsSubmission.Size = New System.Drawing.Size(93, 13)
        Me.lblClaimsSubmission.TabIndex = 1
        Me.lblClaimsSubmission.Text = "Claims Submission"
        '
        'frmClaimsSubmition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 595)
        Me.Controls.Add(Me.lblClaimsSubmission)
        Me.Controls.Add(Me.frmClaimsPanel)
        Me.Name = "frmClaimsSubmition"
        Me.Text = "frmClaimsSubmition"
        Me.frmClaimsPanel.ResumeLayout(False)
        Me.frmClaimsPanel.PerformLayout()
        CType(Me.nudClaimAmount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents frmClaimsPanel As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents rtbTreatment As RichTextBox
    Friend WithEvents txtPatientName As TextBox
    Friend WithEvents rtpDiagnosis As RichTextBox
    Friend WithEvents dtpServiceDate As DateTimePicker
    Friend WithEvents cboProvider As ComboBox
    Friend WithEvents txtNHISNumber As TextBox
    Friend WithEvents txtClaimNumber As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSubmitClaim As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblClaimsSubmission As Label
    Friend WithEvents nudClaimAmount As NumericUpDown
End Class
