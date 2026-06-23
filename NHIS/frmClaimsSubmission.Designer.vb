<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClaimsSubmission
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpPatientProvider = New System.Windows.Forms.TabPage()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.cboProviderType = New System.Windows.Forms.ComboBox()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblProviderType = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.txtRegion2 = New System.Windows.Forms.TextBox()
        Me.txtProviderName = New System.Windows.Forms.TextBox()
        Me.txtProviderID = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNHISNumber = New System.Windows.Forms.TextBox()
        Me.dtpDateOfBirth = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPatientFullName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tpServiceDetails = New System.Windows.Forms.TabPage()
        Me.pnlClaimDetails = New System.Windows.Forms.Panel()
        Me.dtpDateSubmitted = New System.Windows.Forms.DateTimePicker()
        Me.lblDiagnosisCode = New System.Windows.Forms.Label()
        Me.txtWardDepartment = New System.Windows.Forms.TextBox()
        Me.txtDiagnosisCode = New System.Windows.Forms.TextBox()
        Me.lblWardDepartment = New System.Windows.Forms.Label()
        Me.lblDateSubmitted = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tpFinancial = New System.Windows.Forms.TabPage()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtAdditionalNotes = New System.Windows.Forms.TextBox()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtAmountClaimed = New System.Windows.Forms.Label()
        Me.txtApprovedAmount = New System.Windows.Forms.TextBox()
        Me.txtPatientName = New System.Windows.Forms.TextBox()
        Me.lblNHISNumber = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblClaimIDBadge = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblDateSubmittedBadge = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lblStatusBadge = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.txtDiagnosisDescription = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cboProcedureType = New System.Windows.Forms.ComboBox()
        Me.lblProcedureServiceType = New System.Windows.Forms.Label()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.tpPatientProvider.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.tpServiceDetails.SuspendLayout()
        Me.pnlClaimDetails.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.tpFinancial.SuspendLayout()
        Me.Panel18.SuspendLayout()
        Me.Panel19.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel17.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpPatientProvider)
        Me.TabControl1.Controls.Add(Me.tpServiceDetails)
        Me.TabControl1.Controls.Add(Me.tpFinancial)
        Me.TabControl1.Enabled = False
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(81, 167)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(607, 458)
        Me.TabControl1.TabIndex = 3
        '
        'tpPatientProvider
        '
        Me.tpPatientProvider.Controls.Add(Me.Panel10)
        Me.tpPatientProvider.Controls.Add(Me.Panel5)
        Me.tpPatientProvider.Location = New System.Drawing.Point(4, 24)
        Me.tpPatientProvider.Name = "tpPatientProvider"
        Me.tpPatientProvider.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPatientProvider.Size = New System.Drawing.Size(599, 430)
        Me.tpPatientProvider.TabIndex = 1
        Me.tpPatientProvider.Text = "Patient & Provider"
        Me.tpPatientProvider.UseVisualStyleBackColor = True
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.White
        Me.Panel10.Controls.Add(Me.cboProviderType)
        Me.Panel10.Controls.Add(Me.Panel11)
        Me.Panel10.Controls.Add(Me.Label14)
        Me.Panel10.Controls.Add(Me.lblProviderType)
        Me.Panel10.Controls.Add(Me.TextBox6)
        Me.Panel10.Controls.Add(Me.TextBox5)
        Me.Panel10.Controls.Add(Me.txtRegion2)
        Me.Panel10.Controls.Add(Me.txtProviderName)
        Me.Panel10.Controls.Add(Me.txtProviderID)
        Me.Panel10.Controls.Add(Me.Label15)
        Me.Panel10.Controls.Add(Me.Label17)
        Me.Panel10.Controls.Add(Me.Label18)
        Me.Panel10.Controls.Add(Me.Label21)
        Me.Panel10.Controls.Add(Me.Label22)
        Me.Panel10.Location = New System.Drawing.Point(9, 247)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Padding = New System.Windows.Forms.Padding(16)
        Me.Panel10.Size = New System.Drawing.Size(584, 177)
        Me.Panel10.TabIndex = 3
        '
        'cboProviderType
        '
        Me.cboProviderType.FormattingEnabled = True
        Me.cboProviderType.Items.AddRange(New Object() {"Hospital", "Clinic", "Pharmacy"})
        Me.cboProviderType.Location = New System.Drawing.Point(29, 131)
        Me.cboProviderType.Name = "cboProviderType"
        Me.cboProviderType.Size = New System.Drawing.Size(145, 23)
        Me.cboProviderType.TabIndex = 8
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel11.Controls.Add(Me.Panel12)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Location = New System.Drawing.Point(16, 29)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(552, 1)
        Me.Panel11.TabIndex = 7
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel12.Location = New System.Drawing.Point(0, 0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(552, 1)
        Me.Panel12.TabIndex = 8
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(16, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(89, 13)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Provider Details"
        '
        'lblProviderType
        '
        Me.lblProviderType.AutoSize = True
        Me.lblProviderType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lblProviderType.Location = New System.Drawing.Point(26, 114)
        Me.lblProviderType.Name = "lblProviderType"
        Me.lblProviderType.Size = New System.Drawing.Size(78, 15)
        Me.lblProviderType.TabIndex = 4
        Me.lblProviderType.Text = "Provider Type"
        '
        'TextBox6
        '
        Me.TextBox6.Enabled = False
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(29, 199)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(145, 22)
        Me.TextBox6.TabIndex = 3
        '
        'TextBox5
        '
        Me.TextBox5.Enabled = False
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(268, 199)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(165, 22)
        Me.TextBox5.TabIndex = 3
        '
        'txtRegion2
        '
        Me.txtRegion2.Enabled = False
        Me.txtRegion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegion2.Location = New System.Drawing.Point(268, 132)
        Me.txtRegion2.Name = "txtRegion2"
        Me.txtRegion2.Size = New System.Drawing.Size(165, 22)
        Me.txtRegion2.TabIndex = 3
        '
        'txtProviderName
        '
        Me.txtProviderName.Enabled = False
        Me.txtProviderName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProviderName.Location = New System.Drawing.Point(268, 68)
        Me.txtProviderName.Name = "txtProviderName"
        Me.txtProviderName.Size = New System.Drawing.Size(165, 22)
        Me.txtProviderName.TabIndex = 3
        '
        'txtProviderID
        '
        Me.txtProviderID.Enabled = False
        Me.txtProviderID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProviderID.Location = New System.Drawing.Point(29, 68)
        Me.txtProviderID.Name = "txtProviderID"
        Me.txtProviderID.Size = New System.Drawing.Size(145, 22)
        Me.txtProviderID.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(26, 181)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(44, 15)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "District"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(265, 181)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(41, 15)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Phone"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(265, 114)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(44, 15)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "Region"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(265, 50)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(86, 15)
        Me.Label21.TabIndex = 1
        Me.Label21.Text = "Provider Name"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(26, 50)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(65, 15)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Provider ID"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.dtpDOB)
        Me.Panel5.Controls.Add(Me.cboGender)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.txtNHISNumber)
        Me.Panel5.Controls.Add(Me.dtpDateOfBirth)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.txtPatientFullName)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Location = New System.Drawing.Point(9, 6)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(16)
        Me.Panel5.Size = New System.Drawing.Size(587, 235)
        Me.Panel5.TabIndex = 2
        '
        'dtpDOB
        '
        Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDOB.Location = New System.Drawing.Point(24, 195)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(105, 23)
        Me.dtpDOB.TabIndex = 23
        '
        'cboGender
        '
        Me.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboGender.Location = New System.Drawing.Point(261, 135)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(100, 23)
        Me.cboGender.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(21, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 15)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Date of Birth"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(20, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 15)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Date of Birth"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(19, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 15)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Patient Name"
        '
        'txtNHISNumber
        '
        Me.txtNHISNumber.Enabled = False
        Me.txtNHISNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNHISNumber.Location = New System.Drawing.Point(261, 69)
        Me.txtNHISNumber.Name = "txtNHISNumber"
        Me.txtNHISNumber.Size = New System.Drawing.Size(100, 22)
        Me.txtNHISNumber.TabIndex = 17
        '
        'dtpDateOfBirth
        '
        Me.dtpDateOfBirth.Enabled = False
        Me.dtpDateOfBirth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateOfBirth.Location = New System.Drawing.Point(22, 136)
        Me.dtpDateOfBirth.Name = "dtpDateOfBirth"
        Me.dtpDateOfBirth.Size = New System.Drawing.Size(107, 22)
        Me.dtpDateOfBirth.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(259, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 15)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Gender"
        '
        'txtPatientFullName
        '
        Me.txtPatientFullName.Enabled = False
        Me.txtPatientFullName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientFullName.Location = New System.Drawing.Point(22, 69)
        Me.txtPatientFullName.Name = "txtPatientFullName"
        Me.txtPatientFullName.Size = New System.Drawing.Size(107, 22)
        Me.txtPatientFullName.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(258, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 15)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "NHIS Number"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Location = New System.Drawing.Point(21, 32)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(660, 1)
        Me.Panel7.TabIndex = 9
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(660, 1)
        Me.Panel8.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(16, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Patient Details"
        '
        'tpServiceDetails
        '
        Me.tpServiceDetails.Controls.Add(Me.pnlClaimDetails)
        Me.tpServiceDetails.Location = New System.Drawing.Point(4, 24)
        Me.tpServiceDetails.Name = "tpServiceDetails"
        Me.tpServiceDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.tpServiceDetails.Size = New System.Drawing.Size(599, 430)
        Me.tpServiceDetails.TabIndex = 2
        Me.tpServiceDetails.Text = "Service Details"
        Me.tpServiceDetails.UseVisualStyleBackColor = True
        '
        'pnlClaimDetails
        '
        Me.pnlClaimDetails.BackColor = System.Drawing.Color.White
        Me.pnlClaimDetails.Controls.Add(Me.cboProcedureType)
        Me.pnlClaimDetails.Controls.Add(Me.dtpDateSubmitted)
        Me.pnlClaimDetails.Controls.Add(Me.Label20)
        Me.pnlClaimDetails.Controls.Add(Me.lblProcedureServiceType)
        Me.pnlClaimDetails.Controls.Add(Me.lblDiagnosisCode)
        Me.pnlClaimDetails.Controls.Add(Me.txtWardDepartment)
        Me.pnlClaimDetails.Controls.Add(Me.txtDiagnosisDescription)
        Me.pnlClaimDetails.Controls.Add(Me.txtDiagnosisCode)
        Me.pnlClaimDetails.Controls.Add(Me.lblWardDepartment)
        Me.pnlClaimDetails.Controls.Add(Me.lblDateSubmitted)
        Me.pnlClaimDetails.Controls.Add(Me.Panel13)
        Me.pnlClaimDetails.Controls.Add(Me.Label19)
        Me.pnlClaimDetails.Location = New System.Drawing.Point(6, 5)
        Me.pnlClaimDetails.Name = "pnlClaimDetails"
        Me.pnlClaimDetails.Padding = New System.Windows.Forms.Padding(16)
        Me.pnlClaimDetails.Size = New System.Drawing.Size(587, 278)
        Me.pnlClaimDetails.TabIndex = 0
        '
        'dtpDateSubmitted
        '
        Me.dtpDateSubmitted.Enabled = False
        Me.dtpDateSubmitted.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateSubmitted.Location = New System.Drawing.Point(25, 71)
        Me.dtpDateSubmitted.Name = "dtpDateSubmitted"
        Me.dtpDateSubmitted.Size = New System.Drawing.Size(211, 23)
        Me.dtpDateSubmitted.TabIndex = 22
        '
        'lblDiagnosisCode
        '
        Me.lblDiagnosisCode.AutoSize = True
        Me.lblDiagnosisCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lblDiagnosisCode.Location = New System.Drawing.Point(20, 118)
        Me.lblDiagnosisCode.Name = "lblDiagnosisCode"
        Me.lblDiagnosisCode.Size = New System.Drawing.Size(89, 15)
        Me.lblDiagnosisCode.TabIndex = 21
        Me.lblDiagnosisCode.Text = "Diagnosis Code"
        '
        'txtWardDepartment
        '
        Me.txtWardDepartment.Enabled = False
        Me.txtWardDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWardDepartment.Location = New System.Drawing.Point(312, 71)
        Me.txtWardDepartment.Name = "txtWardDepartment"
        Me.txtWardDepartment.Size = New System.Drawing.Size(222, 22)
        Me.txtWardDepartment.TabIndex = 17
        '
        'txtDiagnosisCode
        '
        Me.txtDiagnosisCode.Enabled = False
        Me.txtDiagnosisCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiagnosisCode.Location = New System.Drawing.Point(22, 136)
        Me.txtDiagnosisCode.Name = "txtDiagnosisCode"
        Me.txtDiagnosisCode.Size = New System.Drawing.Size(211, 22)
        Me.txtDiagnosisCode.TabIndex = 19
        Me.txtDiagnosisCode.Text = "P1004 "
        '
        'lblWardDepartment
        '
        Me.lblWardDepartment.AutoSize = True
        Me.lblWardDepartment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lblWardDepartment.Location = New System.Drawing.Point(310, 53)
        Me.lblWardDepartment.Name = "lblWardDepartment"
        Me.lblWardDepartment.Size = New System.Drawing.Size(103, 15)
        Me.lblWardDepartment.TabIndex = 13
        Me.lblWardDepartment.Text = "Ward/Department"
        '
        'lblDateSubmitted
        '
        Me.lblDateSubmitted.AutoSize = True
        Me.lblDateSubmitted.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lblDateSubmitted.Location = New System.Drawing.Point(22, 53)
        Me.lblDateSubmitted.Name = "lblDateSubmitted"
        Me.lblDateSubmitted.Size = New System.Drawing.Size(71, 15)
        Me.lblDateSubmitted.TabIndex = 13
        Me.lblDateSubmitted.Text = "Service Date"
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel13.Controls.Add(Me.Panel14)
        Me.Panel13.Location = New System.Drawing.Point(21, 32)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(660, 1)
        Me.Panel13.TabIndex = 9
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel14.Location = New System.Drawing.Point(0, 0)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(660, 1)
        Me.Panel14.TabIndex = 8
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(16, 16)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(81, 13)
        Me.Label19.TabIndex = 3
        Me.Label19.Text = "Service Details"
        '
        'tpFinancial
        '
        Me.tpFinancial.Controls.Add(Me.Panel18)
        Me.tpFinancial.Controls.Add(Me.Panel3)
        Me.tpFinancial.Location = New System.Drawing.Point(4, 24)
        Me.tpFinancial.Name = "tpFinancial"
        Me.tpFinancial.Padding = New System.Windows.Forms.Padding(3)
        Me.tpFinancial.Size = New System.Drawing.Size(599, 430)
        Me.tpFinancial.TabIndex = 3
        Me.tpFinancial.Text = "Financial"
        Me.tpFinancial.UseVisualStyleBackColor = True
        '
        'Panel18
        '
        Me.Panel18.BackColor = System.Drawing.Color.White
        Me.Panel18.Controls.Add(Me.Label23)
        Me.Panel18.Controls.Add(Me.txtAdditionalNotes)
        Me.Panel18.Controls.Add(Me.Panel19)
        Me.Panel18.Controls.Add(Me.Label25)
        Me.Panel18.Location = New System.Drawing.Point(6, 155)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Padding = New System.Windows.Forms.Padding(16)
        Me.Panel18.Size = New System.Drawing.Size(587, 190)
        Me.Panel18.TabIndex = 22
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label23.Location = New System.Drawing.Point(19, 51)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(96, 15)
        Me.Label23.TabIndex = 21
        Me.Label23.Text = "Additional Notes"
        '
        'txtAdditionalNotes
        '
        Me.txtAdditionalNotes.AcceptsTab = True
        Me.txtAdditionalNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAdditionalNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdditionalNotes.Location = New System.Drawing.Point(22, 69)
        Me.txtAdditionalNotes.Multiline = True
        Me.txtAdditionalNotes.Name = "txtAdditionalNotes"
        Me.txtAdditionalNotes.Size = New System.Drawing.Size(526, 102)
        Me.txtAdditionalNotes.TabIndex = 19
        '
        'Panel19
        '
        Me.Panel19.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel19.Controls.Add(Me.Panel20)
        Me.Panel19.Location = New System.Drawing.Point(21, 32)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(660, 1)
        Me.Panel19.TabIndex = 9
        '
        'Panel20
        '
        Me.Panel20.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel20.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel20.Location = New System.Drawing.Point(0, 0)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(660, 1)
        Me.Panel20.TabIndex = 8
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.Label25.Location = New System.Drawing.Point(16, 16)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(51, 13)
        Me.Label25.TabIndex = 3
        Me.Label25.Text = "Remarks"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.txtAmountClaimed)
        Me.Panel3.Controls.Add(Me.txtApprovedAmount)
        Me.Panel3.Controls.Add(Me.txtPatientName)
        Me.Panel3.Controls.Add(Me.lblNHISNumber)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Location = New System.Drawing.Point(7, 6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(16)
        Me.Panel3.Size = New System.Drawing.Size(587, 143)
        Me.Panel3.TabIndex = 1
        '
        'txtAmountClaimed
        '
        Me.txtAmountClaimed.AutoSize = True
        Me.txtAmountClaimed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.txtAmountClaimed.Location = New System.Drawing.Point(19, 51)
        Me.txtAmountClaimed.Name = "txtAmountClaimed"
        Me.txtAmountClaimed.Size = New System.Drawing.Size(132, 15)
        Me.txtAmountClaimed.TabIndex = 21
        Me.txtAmountClaimed.Text = "Amount Claimed (GHS)"
        '
        'txtApprovedAmount
        '
        Me.txtApprovedAmount.Enabled = False
        Me.txtApprovedAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApprovedAmount.Location = New System.Drawing.Point(331, 69)
        Me.txtApprovedAmount.Name = "txtApprovedAmount"
        Me.txtApprovedAmount.Size = New System.Drawing.Size(216, 22)
        Me.txtApprovedAmount.TabIndex = 17
        '
        'txtPatientName
        '
        Me.txtPatientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientName.Location = New System.Drawing.Point(22, 69)
        Me.txtPatientName.Name = "txtPatientName"
        Me.txtPatientName.Size = New System.Drawing.Size(210, 22)
        Me.txtPatientName.TabIndex = 19
        '
        'lblNHISNumber
        '
        Me.lblNHISNumber.AutoSize = True
        Me.lblNHISNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lblNHISNumber.Location = New System.Drawing.Point(328, 51)
        Me.lblNHISNumber.Name = "lblNHISNumber"
        Me.lblNHISNumber.Size = New System.Drawing.Size(140, 15)
        Me.lblNHISNumber.TabIndex = 13
        Me.lblNHISNumber.Text = "Approved Amount (GHS)"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Panel9)
        Me.Panel4.Location = New System.Drawing.Point(21, 32)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(660, 1)
        Me.Panel4.TabIndex = 9
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(660, 1)
        Me.Panel9.TabIndex = 8
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(16, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 13)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Amount"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel2)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel6)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(81, 60)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(603, 86)
        Me.FlowLayoutPanel1.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lblClaimIDBadge)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel1.Size = New System.Drawing.Size(200, 83)
        Me.Panel1.TabIndex = 6
        '
        'lblClaimIDBadge
        '
        Me.lblClaimIDBadge.AutoSize = True
        Me.lblClaimIDBadge.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClaimIDBadge.Location = New System.Drawing.Point(31, 34)
        Me.lblClaimIDBadge.Name = "lblClaimIDBadge"
        Me.lblClaimIDBadge.Size = New System.Drawing.Size(13, 17)
        Me.lblClaimIDBadge.TabIndex = 0
        Me.lblClaimIDBadge.Text = "-"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(29, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Claim ID"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.lblDateSubmittedBadge)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Location = New System.Drawing.Point(209, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel2.Size = New System.Drawing.Size(182, 83)
        Me.Panel2.TabIndex = 7
        '
        'lblDateSubmittedBadge
        '
        Me.lblDateSubmittedBadge.AutoSize = True
        Me.lblDateSubmittedBadge.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateSubmittedBadge.Location = New System.Drawing.Point(27, 34)
        Me.lblDateSubmittedBadge.Name = "lblDateSubmittedBadge"
        Me.lblDateSubmittedBadge.Size = New System.Drawing.Size(13, 17)
        Me.lblDateSubmittedBadge.TabIndex = 0
        Me.lblDateSubmittedBadge.Text = "-"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(28, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Date Submitted"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Controls.Add(Me.lblStatusBadge)
        Me.Panel6.Controls.Add(Me.Label10)
        Me.Panel6.Location = New System.Drawing.Point(397, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel6.Size = New System.Drawing.Size(200, 83)
        Me.Panel6.TabIndex = 7
        '
        'lblStatusBadge
        '
        Me.lblStatusBadge.AutoSize = True
        Me.lblStatusBadge.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatusBadge.Location = New System.Drawing.Point(39, 34)
        Me.lblStatusBadge.Name = "lblStatusBadge"
        Me.lblStatusBadge.Size = New System.Drawing.Size(13, 17)
        Me.lblStatusBadge.TabIndex = 0
        Me.lblStatusBadge.Text = "-"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(38, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Status"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "NEW CLAIM SUBMISSION"
        '
        'Panel17
        '
        Me.Panel17.AutoScroll = True
        Me.Panel17.Controls.Add(Me.Cancel)
        Me.Panel17.Controls.Add(Me.btnClear)
        Me.Panel17.Controls.Add(Me.Label1)
        Me.Panel17.Controls.Add(Me.TabControl1)
        Me.Panel17.Controls.Add(Me.btnSave)
        Me.Panel17.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel17.Location = New System.Drawing.Point(0, 0)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(755, 720)
        Me.Panel17.TabIndex = 6
        '
        'txtDiagnosisDescription
        '
        Me.txtDiagnosisDescription.Enabled = False
        Me.txtDiagnosisDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiagnosisDescription.Location = New System.Drawing.Point(312, 136)
        Me.txtDiagnosisDescription.Name = "txtDiagnosisDescription"
        Me.txtDiagnosisDescription.Size = New System.Drawing.Size(222, 22)
        Me.txtDiagnosisDescription.TabIndex = 19
        Me.txtDiagnosisDescription.Text = "P1004 "
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(310, 118)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(121, 15)
        Me.Label20.TabIndex = 21
        Me.Label20.Text = "Diagnosis Description"
        '
        'cboProcedureType
        '
        Me.cboProcedureType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProcedureType.FormattingEnabled = True
        Me.cboProcedureType.Items.AddRange(New Object() {"Inpatient Care", "Outpatient Consultation", "Surgery", "Laboratory", "Pharmacy", "Dental", "Optical"})
        Me.cboProcedureType.Location = New System.Drawing.Point(19, 217)
        Me.cboProcedureType.Name = "cboProcedureType"
        Me.cboProcedureType.Size = New System.Drawing.Size(214, 23)
        Me.cboProcedureType.TabIndex = 23
        '
        'lblProcedureServiceType
        '
        Me.lblProcedureServiceType.AutoSize = True
        Me.lblProcedureServiceType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lblProcedureServiceType.Location = New System.Drawing.Point(19, 199)
        Me.lblProcedureServiceType.Name = "lblProcedureServiceType"
        Me.lblProcedureServiceType.Size = New System.Drawing.Size(130, 15)
        Me.lblProcedureServiceType.TabIndex = 21
        Me.lblProcedureServiceType.Text = "Procedure/Service Type"
        '
        'Cancel
        '
        Me.Cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(613, 646)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(75, 32)
        Me.Cancel.TabIndex = 9
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(520, 646)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 32)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(410, 646)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(92, 32)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Submit Claim"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'frmClaimsSubmission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 720)
        Me.Controls.Add(Me.Panel17)
        Me.Name = "frmClaimsSubmission"
        Me.Text = "frmClaimsSubmition"
        Me.TabControl1.ResumeLayout(False)
        Me.tpPatientProvider.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.tpServiceDetails.ResumeLayout(False)
        Me.pnlClaimDetails.ResumeLayout(False)
        Me.pnlClaimDetails.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        Me.tpFinancial.ResumeLayout(False)
        Me.Panel18.ResumeLayout(False)
        Me.Panel18.PerformLayout()
        Me.Panel19.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel17.ResumeLayout(False)
        Me.Panel17.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpPatientProvider As TabPage
    Friend WithEvents tpServiceDetails As TabPage
    Friend WithEvents pnlClaimDetails As Panel
    Friend WithEvents dtpDateSubmitted As DateTimePicker
    Friend WithEvents lblDiagnosisCode As Label
    Friend WithEvents txtWardDepartment As TextBox
    Friend WithEvents txtDiagnosisCode As TextBox
    Friend WithEvents lblWardDepartment As Label
    Friend WithEvents lblDateSubmitted As Label
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Label19 As Label
    Friend WithEvents tpFinancial As TabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtAmountClaimed As Label
    Friend WithEvents txtApprovedAmount As TextBox
    Friend WithEvents txtPatientName As TextBox
    Friend WithEvents lblNHISNumber As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblClaimIDBadge As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblDateSubmittedBadge As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblStatusBadge As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents dtpDOB As DateTimePicker
    Friend WithEvents cboGender As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNHISNumber As TextBox
    Friend WithEvents dtpDateOfBirth As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPatientFullName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents cboProviderType As ComboBox
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents lblProviderType As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents txtRegion2 As TextBox
    Friend WithEvents txtProviderName As TextBox
    Friend WithEvents txtProviderID As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Panel17 As Panel
    Friend WithEvents Panel18 As Panel
    Friend WithEvents Label23 As Label
    Friend WithEvents txtAdditionalNotes As TextBox
    Friend WithEvents Panel19 As Panel
    Friend WithEvents Panel20 As Panel
    Friend WithEvents Label25 As Label
    Friend WithEvents cboProcedureType As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents lblProcedureServiceType As Label
    Friend WithEvents txtDiagnosisDescription As TextBox
    Friend WithEvents Cancel As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSave As Button
End Class
