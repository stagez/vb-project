<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewClaim
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
        Me.tcClaimSubmission = New System.Windows.Forms.TabControl()
        Me.tpPatientProvider = New System.Windows.Forms.TabPage()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.cboProviderID = New System.Windows.Forms.ComboBox()
        Me.txtProviderType = New System.Windows.Forms.TextBox()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblProviderType = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.txtRegion2 = New System.Windows.Forms.TextBox()
        Me.txtProviderName = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNHISNumber = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPatientFullName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tpServiceDetails = New System.Windows.Forms.TabPage()
        Me.pnlClaimDetails = New System.Windows.Forms.Panel()
        Me.cboProcedureType = New System.Windows.Forms.ComboBox()
        Me.dtpDateSubmitted = New System.Windows.Forms.DateTimePicker()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblProcedureServiceType = New System.Windows.Forms.Label()
        Me.lblDiagnosisCode = New System.Windows.Forms.Label()
        Me.txtWardDepartment = New System.Windows.Forms.TextBox()
        Me.txtDiagnosisDescription = New System.Windows.Forms.TextBox()
        Me.txtDiagnosisCode = New System.Windows.Forms.TextBox()
        Me.lblWardDepartment = New System.Windows.Forms.Label()
        Me.lblDateSubmitted = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tpFinancial = New System.Windows.Forms.TabPage()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.lblAdditionalNotes = New System.Windows.Forms.Label()
        Me.txtAdditionalNotes = New System.Windows.Forms.TextBox()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.lblRemarks = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtPatientName = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.pnlMainContainer = New System.Windows.Forms.Panel()
        Me.tcClaimSubmission.SuspendLayout()
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
        Me.pnlMainContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcClaimSubmission
        '
        Me.tcClaimSubmission.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tcClaimSubmission.Controls.Add(Me.tpPatientProvider)
        Me.tcClaimSubmission.Controls.Add(Me.tpServiceDetails)
        Me.tcClaimSubmission.Controls.Add(Me.tpFinancial)
        Me.tcClaimSubmission.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcClaimSubmission.Location = New System.Drawing.Point(7, 75)
        Me.tcClaimSubmission.Name = "tcClaimSubmission"
        Me.tcClaimSubmission.SelectedIndex = 0
        Me.tcClaimSubmission.Size = New System.Drawing.Size(941, 527)
        Me.tcClaimSubmission.TabIndex = 3
        '
        'tpPatientProvider
        '
        Me.tpPatientProvider.Controls.Add(Me.Panel10)
        Me.tpPatientProvider.Controls.Add(Me.Panel5)
        Me.tpPatientProvider.Location = New System.Drawing.Point(4, 24)
        Me.tpPatientProvider.Name = "tpPatientProvider"
        Me.tpPatientProvider.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPatientProvider.Size = New System.Drawing.Size(933, 499)
        Me.tpPatientProvider.TabIndex = 1
        Me.tpPatientProvider.Text = "Patient & Provider"
        Me.tpPatientProvider.UseVisualStyleBackColor = True
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.White
        Me.Panel10.Controls.Add(Me.cboProviderID)
        Me.Panel10.Controls.Add(Me.txtProviderType)
        Me.Panel10.Controls.Add(Me.Panel11)
        Me.Panel10.Controls.Add(Me.Label14)
        Me.Panel10.Controls.Add(Me.lblProviderType)
        Me.Panel10.Controls.Add(Me.TextBox6)
        Me.Panel10.Controls.Add(Me.TextBox5)
        Me.Panel10.Controls.Add(Me.txtRegion2)
        Me.Panel10.Controls.Add(Me.txtProviderName)
        Me.Panel10.Controls.Add(Me.Label15)
        Me.Panel10.Controls.Add(Me.Label17)
        Me.Panel10.Controls.Add(Me.Label18)
        Me.Panel10.Controls.Add(Me.Label21)
        Me.Panel10.Controls.Add(Me.Label22)
        Me.Panel10.Location = New System.Drawing.Point(12, 216)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Padding = New System.Windows.Forms.Padding(16)
        Me.Panel10.Size = New System.Drawing.Size(915, 266)
        Me.Panel10.TabIndex = 3
        '
        'cboProviderID
        '
        Me.cboProviderID.FormattingEnabled = True
        Me.cboProviderID.Location = New System.Drawing.Point(27, 74)
        Me.cboProviderID.Name = "cboProviderID"
        Me.cboProviderID.Size = New System.Drawing.Size(218, 23)
        Me.cboProviderID.TabIndex = 9
        '
        'txtProviderType
        '
        Me.txtProviderType.Location = New System.Drawing.Point(29, 138)
        Me.txtProviderType.Name = "txtProviderType"
        Me.txtProviderType.Size = New System.Drawing.Size(219, 23)
        Me.txtProviderType.TabIndex = 8
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel11.Controls.Add(Me.Panel12)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Location = New System.Drawing.Point(16, 37)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(883, 1)
        Me.Panel11.TabIndex = 7
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel12.Location = New System.Drawing.Point(0, 0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(883, 1)
        Me.Panel12.TabIndex = 8
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(16, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(132, 21)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Provider Details"
        '
        'lblProviderType
        '
        Me.lblProviderType.AutoSize = True
        Me.lblProviderType.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProviderType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lblProviderType.Location = New System.Drawing.Point(26, 114)
        Me.lblProviderType.Name = "lblProviderType"
        Me.lblProviderType.Size = New System.Drawing.Size(115, 21)
        Me.lblProviderType.TabIndex = 4
        Me.lblProviderType.Text = "Provider Type"
        '
        'TextBox6
        '
        Me.TextBox6.Enabled = False
        Me.TextBox6.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(29, 203)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(216, 28)
        Me.TextBox6.TabIndex = 4
        '
        'TextBox5
        '
        Me.TextBox5.Enabled = False
        Me.TextBox5.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(562, 203)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(230, 28)
        Me.TextBox5.TabIndex = 5
        '
        'txtRegion2
        '
        Me.txtRegion2.Enabled = False
        Me.txtRegion2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegion2.Location = New System.Drawing.Point(563, 118)
        Me.txtRegion2.Name = "txtRegion2"
        Me.txtRegion2.Size = New System.Drawing.Size(230, 28)
        Me.txtRegion2.TabIndex = 3
        '
        'txtProviderName
        '
        Me.txtProviderName.Enabled = False
        Me.txtProviderName.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProviderName.Location = New System.Drawing.Point(563, 54)
        Me.txtProviderName.Name = "txtProviderName"
        Me.txtProviderName.Size = New System.Drawing.Size(230, 28)
        Me.txtProviderName.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(26, 181)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 21)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "District"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(559, 181)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(59, 21)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Phone"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(560, 96)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(64, 21)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "Region"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(560, 32)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(125, 21)
        Me.Label21.TabIndex = 1
        Me.Label21.Text = "Provider Name"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(26, 50)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(96, 21)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Provider ID"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.dtpDOB)
        Me.Panel5.Controls.Add(Me.cboGender)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.txtNHISNumber)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.txtPatientFullName)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Location = New System.Drawing.Point(9, 6)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(16)
        Me.Panel5.Size = New System.Drawing.Size(934, 192)
        Me.Panel5.TabIndex = 1
        '
        'dtpDOB
        '
        Me.dtpDOB.Enabled = False
        Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDOB.Location = New System.Drawing.Point(21, 152)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(227, 23)
        Me.dtpDOB.TabIndex = 2
        '
        'cboGender
        '
        Me.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGender.Enabled = False
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboGender.Location = New System.Drawing.Point(566, 156)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(166, 23)
        Me.cboGender.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(18, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 21)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Date of Birth"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(19, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 20)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Patient Name"
        '
        'txtNHISNumber
        '
        Me.txtNHISNumber.Enabled = False
        Me.txtNHISNumber.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNHISNumber.Location = New System.Drawing.Point(565, 78)
        Me.txtNHISNumber.Name = "txtNHISNumber"
        Me.txtNHISNumber.Size = New System.Drawing.Size(230, 28)
        Me.txtNHISNumber.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(564, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 21)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Gender"
        '
        'txtPatientFullName
        '
        Me.txtPatientFullName.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientFullName.Location = New System.Drawing.Point(22, 75)
        Me.txtPatientFullName.Name = "txtPatientFullName"
        Me.txtPatientFullName.Size = New System.Drawing.Size(229, 28)
        Me.txtPatientFullName.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(562, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 21)
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
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(16, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 21)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Patient Details"
        '
        'tpServiceDetails
        '
        Me.tpServiceDetails.Controls.Add(Me.pnlClaimDetails)
        Me.tpServiceDetails.Location = New System.Drawing.Point(4, 24)
        Me.tpServiceDetails.Name = "tpServiceDetails"
        Me.tpServiceDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.tpServiceDetails.Size = New System.Drawing.Size(933, 499)
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
        Me.pnlClaimDetails.Size = New System.Drawing.Size(928, 618)
        Me.pnlClaimDetails.TabIndex = 0
        '
        'cboProcedureType
        '
        Me.cboProcedureType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProcedureType.FormattingEnabled = True
        Me.cboProcedureType.Items.AddRange(New Object() {"Inpatient Care", "Outpatient Consultation", "Surgery", "Laboratory", "Pharmacy", "Dental", "Optical"})
        Me.cboProcedureType.Location = New System.Drawing.Point(19, 325)
        Me.cboProcedureType.Name = "cboProcedureType"
        Me.cboProcedureType.Size = New System.Drawing.Size(214, 23)
        Me.cboProcedureType.TabIndex = 23
        '
        'dtpDateSubmitted
        '
        Me.dtpDateSubmitted.Enabled = False
        Me.dtpDateSubmitted.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateSubmitted.Location = New System.Drawing.Point(18, 100)
        Me.dtpDateSubmitted.Name = "dtpDateSubmitted"
        Me.dtpDateSubmitted.Size = New System.Drawing.Size(211, 23)
        Me.dtpDateSubmitted.TabIndex = 22
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(571, 169)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(161, 20)
        Me.Label20.TabIndex = 21
        Me.Label20.Text = "Diagnosis Description"
        '
        'lblProcedureServiceType
        '
        Me.lblProcedureServiceType.AutoSize = True
        Me.lblProcedureServiceType.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcedureServiceType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lblProcedureServiceType.Location = New System.Drawing.Point(21, 294)
        Me.lblProcedureServiceType.Name = "lblProcedureServiceType"
        Me.lblProcedureServiceType.Size = New System.Drawing.Size(191, 21)
        Me.lblProcedureServiceType.TabIndex = 21
        Me.lblProcedureServiceType.Text = "Procedure/Service Type"
        '
        'lblDiagnosisCode
        '
        Me.lblDiagnosisCode.AutoSize = True
        Me.lblDiagnosisCode.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiagnosisCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lblDiagnosisCode.Location = New System.Drawing.Point(16, 173)
        Me.lblDiagnosisCode.Name = "lblDiagnosisCode"
        Me.lblDiagnosisCode.Size = New System.Drawing.Size(116, 20)
        Me.lblDiagnosisCode.TabIndex = 21
        Me.lblDiagnosisCode.Text = "Diagnosis Code"
        '
        'txtWardDepartment
        '
        Me.txtWardDepartment.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWardDepartment.Location = New System.Drawing.Point(573, 110)
        Me.txtWardDepartment.Name = "txtWardDepartment"
        Me.txtWardDepartment.Size = New System.Drawing.Size(222, 29)
        Me.txtWardDepartment.TabIndex = 17
        '
        'txtDiagnosisDescription
        '
        Me.txtDiagnosisDescription.Enabled = False
        Me.txtDiagnosisDescription.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiagnosisDescription.Location = New System.Drawing.Point(573, 195)
        Me.txtDiagnosisDescription.Name = "txtDiagnosisDescription"
        Me.txtDiagnosisDescription.Size = New System.Drawing.Size(222, 29)
        Me.txtDiagnosisDescription.TabIndex = 19
        '
        'txtDiagnosisCode
        '
        Me.txtDiagnosisCode.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiagnosisCode.Location = New System.Drawing.Point(18, 195)
        Me.txtDiagnosisCode.Name = "txtDiagnosisCode"
        Me.txtDiagnosisCode.Size = New System.Drawing.Size(211, 29)
        Me.txtDiagnosisCode.TabIndex = 19
        '
        'lblWardDepartment
        '
        Me.lblWardDepartment.AutoSize = True
        Me.lblWardDepartment.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWardDepartment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lblWardDepartment.Location = New System.Drawing.Point(571, 84)
        Me.lblWardDepartment.Name = "lblWardDepartment"
        Me.lblWardDepartment.Size = New System.Drawing.Size(138, 20)
        Me.lblWardDepartment.TabIndex = 13
        Me.lblWardDepartment.Text = "Ward/Department"
        '
        'lblDateSubmitted
        '
        Me.lblDateSubmitted.AutoSize = True
        Me.lblDateSubmitted.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateSubmitted.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lblDateSubmitted.Location = New System.Drawing.Point(15, 74)
        Me.lblDateSubmitted.Name = "lblDateSubmitted"
        Me.lblDateSubmitted.Size = New System.Drawing.Size(96, 20)
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
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(16, 16)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(123, 21)
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
        Me.tpFinancial.Size = New System.Drawing.Size(933, 499)
        Me.tpFinancial.TabIndex = 3
        Me.tpFinancial.Text = "Financial"
        Me.tpFinancial.UseVisualStyleBackColor = True
        '
        'Panel18
        '
        Me.Panel18.BackColor = System.Drawing.Color.White
        Me.Panel18.Controls.Add(Me.lblAdditionalNotes)
        Me.Panel18.Controls.Add(Me.txtAdditionalNotes)
        Me.Panel18.Controls.Add(Me.Panel19)
        Me.Panel18.Controls.Add(Me.lblRemarks)
        Me.Panel18.Location = New System.Drawing.Point(3, 205)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Padding = New System.Windows.Forms.Padding(16)
        Me.Panel18.Size = New System.Drawing.Size(924, 251)
        Me.Panel18.TabIndex = 22
        '
        'lblAdditionalNotes
        '
        Me.lblAdditionalNotes.AutoSize = True
        Me.lblAdditionalNotes.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdditionalNotes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lblAdditionalNotes.Location = New System.Drawing.Point(19, 51)
        Me.lblAdditionalNotes.Name = "lblAdditionalNotes"
        Me.lblAdditionalNotes.Size = New System.Drawing.Size(140, 21)
        Me.lblAdditionalNotes.TabIndex = 21
        Me.lblAdditionalNotes.Text = "Additional Notes"
        '
        'txtAdditionalNotes
        '
        Me.txtAdditionalNotes.AcceptsTab = True
        Me.txtAdditionalNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAdditionalNotes.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdditionalNotes.Location = New System.Drawing.Point(22, 76)
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
        'lblRemarks
        '
        Me.lblRemarks.AutoSize = True
        Me.lblRemarks.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRemarks.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemarks.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.lblRemarks.Location = New System.Drawing.Point(16, 16)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(51, 13)
        Me.lblRemarks.TabIndex = 3
        Me.lblRemarks.Text = "Remarks"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.txtPatientName)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.lblAmount)
        Me.Panel3.Location = New System.Drawing.Point(7, 6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(16)
        Me.Panel3.Size = New System.Drawing.Size(920, 193)
        Me.Panel3.TabIndex = 1
        '
        'txtPatientName
        '
        Me.txtPatientName.Enabled = False
        Me.txtPatientName.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientName.Location = New System.Drawing.Point(18, 39)
        Me.txtPatientName.Name = "txtPatientName"
        Me.txtPatientName.Size = New System.Drawing.Size(295, 29)
        Me.txtPatientName.TabIndex = 19
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
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblAmount.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.lblAmount.Location = New System.Drawing.Point(16, 16)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(116, 21)
        Me.lblAmount.TabIndex = 3
        Me.lblAmount.Text = "Amount(GHS)"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(365, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(347, 37)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "NEW CLAIM SUBMISSION"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(863, 618)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(82, 32)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(756, 617)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(82, 32)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(630, 617)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(99, 32)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Submit Claim"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'pnlMainContainer
        '
        Me.pnlMainContainer.Controls.Add(Me.tcClaimSubmission)
        Me.pnlMainContainer.Controls.Add(Me.btnCancel)
        Me.pnlMainContainer.Controls.Add(Me.Label1)
        Me.pnlMainContainer.Controls.Add(Me.btnClear)
        Me.pnlMainContainer.Controls.Add(Me.btnSave)
        Me.pnlMainContainer.Location = New System.Drawing.Point(12, 12)
        Me.pnlMainContainer.Name = "pnlMainContainer"
        Me.pnlMainContainer.Size = New System.Drawing.Size(972, 675)
        Me.pnlMainContainer.TabIndex = 16
        '
        'frmNewClaim
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(987, 696)
        Me.Controls.Add(Me.pnlMainContainer)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "frmNewClaim"
        Me.Text = "Submit Claim"
        Me.tcClaimSubmission.ResumeLayout(False)
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
        Me.pnlMainContainer.ResumeLayout(False)
        Me.pnlMainContainer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tcClaimSubmission As TabControl
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
    Friend WithEvents txtPatientName As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents lblAmount As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents dtpDOB As DateTimePicker
    Friend WithEvents cboGender As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNHISNumber As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPatientFullName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents lblProviderType As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents txtRegion2 As TextBox
    Friend WithEvents txtProviderName As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Panel18 As Panel
    Friend WithEvents lblAdditionalNotes As Label
    Friend WithEvents txtAdditionalNotes As TextBox
    Friend WithEvents Panel19 As Panel
    Friend WithEvents Panel20 As Panel
    Friend WithEvents lblRemarks As Label
    Friend WithEvents cboProcedureType As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents lblProcedureServiceType As Label
    Friend WithEvents txtDiagnosisDescription As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents pnlMainContainer As Panel
    Friend WithEvents cboProviderID As ComboBox
    Friend WithEvents txtProviderType As TextBox
End Class
