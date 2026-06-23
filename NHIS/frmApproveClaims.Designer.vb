<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmApproveClaims
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtRegion = New System.Windows.Forms.ComboBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblProviderType = New System.Windows.Forms.Label()
        Me.txtDistrict = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.txtProviderName = New System.Windows.Forms.TextBox()
        Me.txtProviderType = New System.Windows.Forms.TextBox()
        Me.txtProviderID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.pnlAmount = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.pnlClaimDetails = New System.Windows.Forms.Panel()
        Me.dtpDateSubmitted = New System.Windows.Forms.DateTimePicker()
        Me.lblDiagnosisCode = New System.Windows.Forms.Label()
        Me.lblClaimID = New System.Windows.Forms.Label()
        Me.txtProcedure = New System.Windows.Forms.TextBox()
        Me.txtDiagnosisCode = New System.Windows.Forms.TextBox()
        Me.lblProcedure = New System.Windows.Forms.Label()
        Me.txtClaimID = New System.Windows.Forms.TextBox()
        Me.lblDateSubmitted = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.txtContactNumber = New System.Windows.Forms.Label()
        Me.lblDateOfBirth = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtNHISNumber = New System.Windows.Forms.TextBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.dtpDateOfBirth = New System.Windows.Forms.TextBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.txtPatientName = New System.Windows.Forms.TextBox()
        Me.lblNHISNumber = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnReject = New System.Windows.Forms.Button()
        Me.btnApprove = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.pnlAmount.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.pnlClaimDetails.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(208, 271)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Enabled = False
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(72, 65)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(910, 705)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Panel5)
        Me.TabPage2.Location = New System.Drawing.Point(4, 34)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage2.Size = New System.Drawing.Size(902, 667)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Provider Information"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.txtRegion)
        Me.Panel5.Controls.Add(Me.Panel8)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.lblProviderType)
        Me.Panel5.Controls.Add(Me.txtDistrict)
        Me.Panel5.Controls.Add(Me.TextBox5)
        Me.Panel5.Controls.Add(Me.txtProviderName)
        Me.Panel5.Controls.Add(Me.txtProviderType)
        Me.Panel5.Controls.Add(Me.txtProviderID)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Location = New System.Drawing.Point(9, 9)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(24, 25, 24, 25)
        Me.Panel5.Size = New System.Drawing.Size(810, 420)
        Me.Panel5.TabIndex = 0
        '
        'txtRegion
        '
        Me.txtRegion.FormattingEnabled = True
        Me.txtRegion.Items.AddRange(New Object() {"Ahafo Region", "Ashanti Region", "Bono East Region"})
        Me.txtRegion.Location = New System.Drawing.Point(486, 203)
        Me.txtRegion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtRegion.Name = "txtRegion"
        Me.txtRegion.Size = New System.Drawing.Size(270, 33)
        Me.txtRegion.TabIndex = 8
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel8.Controls.Add(Me.Panel12)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(24, 48)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(762, 2)
        Me.Panel8.TabIndex = 7
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel12.Location = New System.Drawing.Point(0, 0)
        Me.Panel12.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(762, 2)
        Me.Panel12.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(24, 25)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 23)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Identification"
        '
        'lblProviderType
        '
        Me.lblProviderType.AutoSize = True
        Me.lblProviderType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lblProviderType.Location = New System.Drawing.Point(39, 175)
        Me.lblProviderType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProviderType.Name = "lblProviderType"
        Me.lblProviderType.Size = New System.Drawing.Size(120, 25)
        Me.lblProviderType.TabIndex = 4
        Me.lblProviderType.Text = "Provider Type"
        '
        'txtDistrict
        '
        Me.txtDistrict.Enabled = False
        Me.txtDistrict.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDistrict.Location = New System.Drawing.Point(44, 306)
        Me.txtDistrict.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDistrict.Name = "txtDistrict"
        Me.txtDistrict.Size = New System.Drawing.Size(270, 29)
        Me.txtDistrict.TabIndex = 3
        '
        'TextBox5
        '
        Me.TextBox5.Enabled = False
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(486, 306)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(270, 29)
        Me.TextBox5.TabIndex = 3
        '
        'txtProviderName
        '
        Me.txtProviderName.Enabled = False
        Me.txtProviderName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProviderName.Location = New System.Drawing.Point(486, 105)
        Me.txtProviderName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtProviderName.Name = "txtProviderName"
        Me.txtProviderName.Size = New System.Drawing.Size(270, 29)
        Me.txtProviderName.TabIndex = 3
        '
        'txtProviderType
        '
        Me.txtProviderType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProviderType.Location = New System.Drawing.Point(44, 203)
        Me.txtProviderType.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtProviderType.Name = "txtProviderType"
        Me.txtProviderType.Size = New System.Drawing.Size(270, 29)
        Me.txtProviderType.TabIndex = 3
        '
        'txtProviderID
        '
        Me.txtProviderID.Enabled = False
        Me.txtProviderID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProviderID.Location = New System.Drawing.Point(44, 105)
        Me.txtProviderID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtProviderID.Name = "txtProviderID"
        Me.txtProviderID.Size = New System.Drawing.Size(270, 29)
        Me.txtProviderID.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(39, 278)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 25)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "District"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(482, 278)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 25)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Phone"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(482, 175)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 25)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Region"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(482, 77)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Provider Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(39, 77)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Provider ID"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.pnlAmount)
        Me.TabPage3.Controls.Add(Me.pnlClaimDetails)
        Me.TabPage3.Location = New System.Drawing.Point(4, 34)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage3.Size = New System.Drawing.Size(902, 667)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Claim Information"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'pnlAmount
        '
        Me.pnlAmount.BackColor = System.Drawing.Color.White
        Me.pnlAmount.Controls.Add(Me.Panel15)
        Me.pnlAmount.Controls.Add(Me.Label20)
        Me.pnlAmount.Controls.Add(Me.lblAmount)
        Me.pnlAmount.Location = New System.Drawing.Point(9, 334)
        Me.pnlAmount.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pnlAmount.Name = "pnlAmount"
        Me.pnlAmount.Padding = New System.Windows.Forms.Padding(24, 25, 24, 25)
        Me.pnlAmount.Size = New System.Drawing.Size(896, 205)
        Me.pnlAmount.TabIndex = 0
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel15.Controls.Add(Me.Panel16)
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel15.Location = New System.Drawing.Point(24, 46)
        Me.Panel15.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(848, 2)
        Me.Panel15.TabIndex = 9
        '
        'Panel16
        '
        Me.Panel16.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel16.Location = New System.Drawing.Point(0, 0)
        Me.Panel16.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(848, 2)
        Me.Panel16.TabIndex = 8
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(24, 25)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 21)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "Amount"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lblAmount.Location = New System.Drawing.Point(28, 91)
        Me.lblAmount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(108, 32)
        Me.lblAmount.TabIndex = 0
        Me.lblAmount.Text = "Amount"
        '
        'pnlClaimDetails
        '
        Me.pnlClaimDetails.BackColor = System.Drawing.Color.White
        Me.pnlClaimDetails.Controls.Add(Me.dtpDateSubmitted)
        Me.pnlClaimDetails.Controls.Add(Me.lblDiagnosisCode)
        Me.pnlClaimDetails.Controls.Add(Me.lblClaimID)
        Me.pnlClaimDetails.Controls.Add(Me.txtProcedure)
        Me.pnlClaimDetails.Controls.Add(Me.txtDiagnosisCode)
        Me.pnlClaimDetails.Controls.Add(Me.lblProcedure)
        Me.pnlClaimDetails.Controls.Add(Me.txtClaimID)
        Me.pnlClaimDetails.Controls.Add(Me.lblDateSubmitted)
        Me.pnlClaimDetails.Controls.Add(Me.Panel13)
        Me.pnlClaimDetails.Controls.Add(Me.Label19)
        Me.pnlClaimDetails.Location = New System.Drawing.Point(9, 8)
        Me.pnlClaimDetails.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pnlClaimDetails.Name = "pnlClaimDetails"
        Me.pnlClaimDetails.Padding = New System.Windows.Forms.Padding(24, 25, 24, 25)
        Me.pnlClaimDetails.Size = New System.Drawing.Size(885, 317)
        Me.pnlClaimDetails.TabIndex = 0
        '
        'dtpDateSubmitted
        '
        Me.dtpDateSubmitted.Enabled = False
        Me.dtpDateSubmitted.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateSubmitted.Location = New System.Drawing.Point(392, 106)
        Me.dtpDateSubmitted.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpDateSubmitted.Name = "dtpDateSubmitted"
        Me.dtpDateSubmitted.Size = New System.Drawing.Size(148, 31)
        Me.dtpDateSubmitted.TabIndex = 22
        '
        'lblDiagnosisCode
        '
        Me.lblDiagnosisCode.AutoSize = True
        Me.lblDiagnosisCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lblDiagnosisCode.Location = New System.Drawing.Point(30, 182)
        Me.lblDiagnosisCode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDiagnosisCode.Name = "lblDiagnosisCode"
        Me.lblDiagnosisCode.Size = New System.Drawing.Size(137, 25)
        Me.lblDiagnosisCode.TabIndex = 21
        Me.lblDiagnosisCode.Text = "Diagnosis Code"
        '
        'lblClaimID
        '
        Me.lblClaimID.AutoSize = True
        Me.lblClaimID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lblClaimID.Location = New System.Drawing.Point(28, 78)
        Me.lblClaimID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblClaimID.Name = "lblClaimID"
        Me.lblClaimID.Size = New System.Drawing.Size(79, 25)
        Me.lblClaimID.TabIndex = 21
        Me.lblClaimID.Text = "Claim ID"
        '
        'txtProcedure
        '
        Me.txtProcedure.Enabled = False
        Me.txtProcedure.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProcedure.Location = New System.Drawing.Point(392, 209)
        Me.txtProcedure.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtProcedure.Name = "txtProcedure"
        Me.txtProcedure.Size = New System.Drawing.Size(148, 29)
        Me.txtProcedure.TabIndex = 17
        '
        'txtDiagnosisCode
        '
        Me.txtDiagnosisCode.Enabled = False
        Me.txtDiagnosisCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiagnosisCode.Location = New System.Drawing.Point(33, 209)
        Me.txtDiagnosisCode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDiagnosisCode.Name = "txtDiagnosisCode"
        Me.txtDiagnosisCode.Size = New System.Drawing.Size(148, 29)
        Me.txtDiagnosisCode.TabIndex = 19
        Me.txtDiagnosisCode.Text = "P1004 "
        '
        'lblProcedure
        '
        Me.lblProcedure.AutoSize = True
        Me.lblProcedure.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lblProcedure.Location = New System.Drawing.Point(388, 182)
        Me.lblProcedure.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProcedure.Name = "lblProcedure"
        Me.lblProcedure.Size = New System.Drawing.Size(164, 25)
        Me.lblProcedure.TabIndex = 13
        Me.lblProcedure.Text = "Procedure / Service"
        '
        'txtClaimID
        '
        Me.txtClaimID.Enabled = False
        Me.txtClaimID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClaimID.Location = New System.Drawing.Point(33, 106)
        Me.txtClaimID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtClaimID.Name = "txtClaimID"
        Me.txtClaimID.Size = New System.Drawing.Size(148, 29)
        Me.txtClaimID.TabIndex = 19
        Me.txtClaimID.Text = "CL005"
        '
        'lblDateSubmitted
        '
        Me.lblDateSubmitted.AutoSize = True
        Me.lblDateSubmitted.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lblDateSubmitted.Location = New System.Drawing.Point(387, 78)
        Me.lblDateSubmitted.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDateSubmitted.Name = "lblDateSubmitted"
        Me.lblDateSubmitted.Size = New System.Drawing.Size(137, 25)
        Me.lblDateSubmitted.TabIndex = 13
        Me.lblDateSubmitted.Text = "Date Submitted"
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel13.Controls.Add(Me.Panel14)
        Me.Panel13.Location = New System.Drawing.Point(32, 49)
        Me.Panel13.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(990, 2)
        Me.Panel13.TabIndex = 9
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel14.Location = New System.Drawing.Point(0, 0)
        Me.Panel14.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(990, 2)
        Me.Panel14.TabIndex = 8
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(24, 25)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(111, 21)
        Me.Label19.TabIndex = 3
        Me.Label19.Text = "Claim Details"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage1.Size = New System.Drawing.Size(902, 667)
        Me.TabPage1.TabIndex = 3
        Me.TabPage1.Text = "Member Information"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.cboGender)
        Me.Panel3.Controls.Add(Me.txtContactNumber)
        Me.Panel3.Controls.Add(Me.lblDateOfBirth)
        Me.Panel3.Controls.Add(Me.lblName)
        Me.Panel3.Controls.Add(Me.txtNHISNumber)
        Me.Panel3.Controls.Add(Me.TextBox15)
        Me.Panel3.Controls.Add(Me.dtpDateOfBirth)
        Me.Panel3.Controls.Add(Me.lblGender)
        Me.Panel3.Controls.Add(Me.txtPatientName)
        Me.Panel3.Controls.Add(Me.lblNHISNumber)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Location = New System.Drawing.Point(10, 9)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(24, 25, 24, 25)
        Me.Panel3.Size = New System.Drawing.Size(880, 362)
        Me.Panel3.TabIndex = 1
        '
        'cboGender
        '
        Me.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboGender.Location = New System.Drawing.Point(392, 208)
        Me.cboGender.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(148, 33)
        Me.cboGender.TabIndex = 22
        '
        'txtContactNumber
        '
        Me.txtContactNumber.AutoSize = True
        Me.txtContactNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.txtContactNumber.Location = New System.Drawing.Point(32, 271)
        Me.txtContactNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(112, 25)
        Me.txtContactNumber.TabIndex = 21
        Me.txtContactNumber.Text = "Date of Birth"
        '
        'lblDateOfBirth
        '
        Me.lblDateOfBirth.AutoSize = True
        Me.lblDateOfBirth.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lblDateOfBirth.Location = New System.Drawing.Point(30, 182)
        Me.lblDateOfBirth.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDateOfBirth.Name = "lblDateOfBirth"
        Me.lblDateOfBirth.Size = New System.Drawing.Size(112, 25)
        Me.lblDateOfBirth.TabIndex = 21
        Me.lblDateOfBirth.Text = "Date of Birth"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lblName.Location = New System.Drawing.Point(28, 78)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(117, 25)
        Me.lblName.TabIndex = 21
        Me.lblName.Text = "Patient Name"
        '
        'txtNHISNumber
        '
        Me.txtNHISNumber.Enabled = False
        Me.txtNHISNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNHISNumber.Location = New System.Drawing.Point(392, 106)
        Me.txtNHISNumber.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNHISNumber.Name = "txtNHISNumber"
        Me.txtNHISNumber.Size = New System.Drawing.Size(148, 29)
        Me.txtNHISNumber.TabIndex = 17
        '
        'TextBox15
        '
        Me.TextBox15.Enabled = False
        Me.TextBox15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox15.Location = New System.Drawing.Point(34, 298)
        Me.TextBox15.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(148, 29)
        Me.TextBox15.TabIndex = 19
        '
        'dtpDateOfBirth
        '
        Me.dtpDateOfBirth.Enabled = False
        Me.dtpDateOfBirth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateOfBirth.Location = New System.Drawing.Point(33, 209)
        Me.dtpDateOfBirth.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpDateOfBirth.Name = "dtpDateOfBirth"
        Me.dtpDateOfBirth.Size = New System.Drawing.Size(148, 29)
        Me.dtpDateOfBirth.TabIndex = 19
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lblGender.Location = New System.Drawing.Point(388, 182)
        Me.lblGender.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(69, 25)
        Me.lblGender.TabIndex = 13
        Me.lblGender.Text = "Gender"
        '
        'txtPatientName
        '
        Me.txtPatientName.Enabled = False
        Me.txtPatientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientName.Location = New System.Drawing.Point(33, 106)
        Me.txtPatientName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPatientName.Name = "txtPatientName"
        Me.txtPatientName.Size = New System.Drawing.Size(148, 29)
        Me.txtPatientName.TabIndex = 19
        '
        'lblNHISNumber
        '
        Me.lblNHISNumber.AutoSize = True
        Me.lblNHISNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lblNHISNumber.Location = New System.Drawing.Point(387, 78)
        Me.lblNHISNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNHISNumber.Name = "lblNHISNumber"
        Me.lblNHISNumber.Size = New System.Drawing.Size(123, 25)
        Me.lblNHISNumber.TabIndex = 13
        Me.lblNHISNumber.Text = "NHIS Number"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Panel9)
        Me.Panel4.Location = New System.Drawing.Point(32, 49)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(990, 2)
        Me.Panel4.TabIndex = 9
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(990, 2)
        Me.Panel9.TabIndex = 8
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(24, 25)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(122, 21)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Patient Details"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Enabled = False
        Me.Panel1.Location = New System.Drawing.Point(16, 17)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1054, 891)
        Me.Panel1.TabIndex = 0
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.MediumPurple
        Me.Label21.Location = New System.Drawing.Point(274, 35)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(122, 20)
        Me.Label21.TabIndex = 14
        Me.Label21.Text = "Pending Review"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Controls.Add(Me.btnReject)
        Me.Panel2.Controls.Add(Me.btnApprove)
        Me.Panel2.Location = New System.Drawing.Point(76, 766)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(902, 105)
        Me.Panel2.TabIndex = 3
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.White
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(363, 35)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(112, 49)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnReject
        '
        Me.btnReject.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnReject.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReject.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReject.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnReject.Location = New System.Drawing.Point(696, 35)
        Me.btnReject.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnReject.Name = "btnReject"
        Me.btnReject.Size = New System.Drawing.Size(112, 49)
        Me.btnReject.TabIndex = 0
        Me.btnReject.Text = "Reject"
        Me.btnReject.UseVisualStyleBackColor = False
        '
        'btnApprove
        '
        Me.btnApprove.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btnApprove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnApprove.FlatAppearance.BorderSize = 0
        Me.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApprove.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApprove.ForeColor = System.Drawing.Color.White
        Me.btnApprove.Location = New System.Drawing.Point(538, 35)
        Me.btnApprove.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.Size = New System.Drawing.Size(112, 49)
        Me.btnApprove.TabIndex = 0
        Me.btnApprove.Text = "Approve"
        Me.btnApprove.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(82, 28)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(112, 29)
        Me.Label18.TabIndex = 14
        Me.Label18.Text = "Claim ID"
        '
        'frmApproveClaims
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1096, 928)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmApproveClaims"
        Me.Text = "frmApproveClaims"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.pnlAmount.ResumeLayout(False)
        Me.pnlAmount.PerformLayout()
        Me.Panel15.ResumeLayout(False)
        Me.pnlClaimDetails.ResumeLayout(False)
        Me.pnlClaimDetails.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents lblProviderType As Label
    Friend WithEvents txtProviderName As TextBox
    Friend WithEvents txtProviderID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents pnlAmount As Panel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Label20 As Label
    Friend WithEvents lblAmount As Label
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnReject As Button
    Friend WithEvents btnApprove As Button
    Friend WithEvents txtDistrict As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents txtProviderType As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents pnlClaimDetails As Panel
    Friend WithEvents lblDiagnosisCode As Label
    Friend WithEvents lblClaimID As Label
    Friend WithEvents txtProcedure As TextBox
    Friend WithEvents txtDiagnosisCode As TextBox
    Friend WithEvents lblProcedure As Label
    Friend WithEvents txtClaimID As TextBox
    Friend WithEvents lblDateSubmitted As Label
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Label19 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtContactNumber As Label
    Friend WithEvents lblDateOfBirth As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtNHISNumber As TextBox
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents dtpDateOfBirth As TextBox
    Friend WithEvents lblGender As Label
    Friend WithEvents txtPatientName As TextBox
    Friend WithEvents lblNHISNumber As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents dtpDateSubmitted As DateTimePicker
    Friend WithEvents cboGender As ComboBox
    Friend WithEvents txtRegion As ComboBox
End Class
