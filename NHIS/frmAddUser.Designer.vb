<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddUser
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
        Me.pnlOuter = New System.Windows.Forms.Panel()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblProfileSmall = New System.Windows.Forms.Label()
        Me.lblProfileLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblStrength = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblRepeatPassword = New System.Windows.Forms.Label()
        Me.cboRole = New System.Windows.Forms.ComboBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtRepeatPassword = New System.Windows.Forms.TextBox()
        Me.pnlStrength = New System.Windows.Forms.Panel()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.pbAvatar = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlOuter.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.pbAvatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlOuter
        '
        Me.pnlOuter.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlOuter.BackColor = System.Drawing.Color.White
        Me.pnlOuter.Controls.Add(Me.Cancel)
        Me.pnlOuter.Controls.Add(Me.btnClear)
        Me.pnlOuter.Controls.Add(Me.btnSave)
        Me.pnlOuter.Controls.Add(Me.lblProfileSmall)
        Me.pnlOuter.Controls.Add(Me.lblProfileLabel)
        Me.pnlOuter.Controls.Add(Me.TableLayoutPanel1)
        Me.pnlOuter.Controls.Add(Me.btnUpload)
        Me.pnlOuter.Controls.Add(Me.pbAvatar)
        Me.pnlOuter.Controls.Add(Me.Label1)
        Me.pnlOuter.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlOuter.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlOuter.Location = New System.Drawing.Point(141, 31)
        Me.pnlOuter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pnlOuter.Name = "pnlOuter"
        Me.pnlOuter.Padding = New System.Windows.Forms.Padding(42, 43, 42, 43)
        Me.pnlOuter.Size = New System.Drawing.Size(926, 694)
        Me.pnlOuter.TabIndex = 0
        '
        'Cancel
        '
        Me.Cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(630, 611)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(112, 49)
        Me.Cancel.TabIndex = 8
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(490, 611)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(112, 49)
        Me.btnClear.TabIndex = 8
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
        Me.btnSave.Location = New System.Drawing.Point(351, 611)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(112, 49)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Save User"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lblProfileSmall
        '
        Me.lblProfileSmall.AutoSize = True
        Me.lblProfileSmall.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProfileSmall.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.lblProfileSmall.Location = New System.Drawing.Point(51, 366)
        Me.lblProfileSmall.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProfileSmall.Name = "lblProfileSmall"
        Me.lblProfileSmall.Size = New System.Drawing.Size(163, 21)
        Me.lblProfileSmall.TabIndex = 6
        Me.lblProfileSmall.Text = "JPG or PNG, max 2MB"
        '
        'lblProfileLabel
        '
        Me.lblProfileLabel.AutoSize = True
        Me.lblProfileLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProfileLabel.Location = New System.Drawing.Point(78, 343)
        Me.lblProfileLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProfileLabel.Name = "lblProfileLabel"
        Me.lblProfileLabel.Size = New System.Drawing.Size(124, 25)
        Me.lblProfileLabel.TabIndex = 5
        Me.lblProfileLabel.Text = "Profile Photo"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.15089!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.84911!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblStrength, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.txtEmail, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblPassword, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblName, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtName, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblRole, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblEmail, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblPhone, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblRepeatPassword, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.cboRole, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPhone, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtRepeatPassword, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.pnlStrength, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPassword, 0, 5)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(294, 105)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 10
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 163.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(586, 468)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'lblStrength
        '
        Me.lblStrength.AutoSize = True
        Me.lblStrength.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStrength.Location = New System.Drawing.Point(4, 327)
        Me.lblStrength.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStrength.Name = "lblStrength"
        Me.lblStrength.Size = New System.Drawing.Size(0, 23)
        Me.lblStrength.TabIndex = 8
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(3, 148)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(248, 31)
        Me.txtEmail.TabIndex = 8
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(3, 233)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(87, 25)
        Me.lblPassword.TabIndex = 4
        Me.lblPassword.Text = "Password"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblName.Location = New System.Drawing.Point(3, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(59, 25)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(3, 31)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(248, 31)
        Me.txtName.TabIndex = 7
        '
        'lblRole
        '
        Me.lblRole.AutoSize = True
        Me.lblRole.Location = New System.Drawing.Point(302, 0)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(46, 25)
        Me.lblRole.TabIndex = 9
        Me.lblRole.Text = "Role"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(3, 116)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(54, 25)
        Me.lblEmail.TabIndex = 1
        Me.lblEmail.Text = "Email"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(302, 116)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(62, 25)
        Me.lblPhone.TabIndex = 0
        Me.lblPhone.Text = "Phone"
        '
        'lblRepeatPassword
        '
        Me.lblRepeatPassword.AutoSize = True
        Me.lblRepeatPassword.Location = New System.Drawing.Point(3, 370)
        Me.lblRepeatPassword.Name = "lblRepeatPassword"
        Me.lblRepeatPassword.Size = New System.Drawing.Size(87, 25)
        Me.lblRepeatPassword.TabIndex = 10
        Me.lblRepeatPassword.Text = "Password"
        '
        'cboRole
        '
        Me.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRole.FormattingEnabled = True
        Me.cboRole.Items.AddRange(New Object() {"Administrator", "Claims Officer", "Provider"})
        Me.cboRole.Location = New System.Drawing.Point(302, 31)
        Me.cboRole.Name = "cboRole"
        Me.cboRole.Size = New System.Drawing.Size(199, 33)
        Me.cboRole.TabIndex = 10
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(302, 148)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(199, 31)
        Me.txtPhone.TabIndex = 7
        '
        'txtRepeatPassword
        '
        Me.txtRepeatPassword.Location = New System.Drawing.Point(3, 401)
        Me.txtRepeatPassword.Name = "txtRepeatPassword"
        Me.txtRepeatPassword.Size = New System.Drawing.Size(248, 31)
        Me.txtRepeatPassword.TabIndex = 11
        Me.txtRepeatPassword.UseSystemPasswordChar = True
        '
        'pnlStrength
        '
        Me.pnlStrength.Location = New System.Drawing.Point(4, 301)
        Me.pnlStrength.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pnlStrength.Name = "pnlStrength"
        Me.pnlStrength.Size = New System.Drawing.Size(212, 6)
        Me.pnlStrength.TabIndex = 8
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(3, 268)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(248, 31)
        Me.txtPassword.TabIndex = 7
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'btnUpload
        '
        Me.btnUpload.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpload.Location = New System.Drawing.Point(75, 402)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(123, 38)
        Me.btnUpload.TabIndex = 3
        Me.btnUpload.Text = "Upload Picture"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'pbAvatar
        '
        Me.pbAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbAvatar.Location = New System.Drawing.Point(56, 142)
        Me.pbAvatar.Name = "pbAvatar"
        Me.pbAvatar.Size = New System.Drawing.Size(164, 168)
        Me.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbAvatar.TabIndex = 2
        Me.pbAvatar.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(388, 72)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ACCOUNT SETTINGS"
        '
        'frmAddUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1208, 777)
        Me.Controls.Add(Me.pnlOuter)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmAddUser"
        Me.Text = "frmAddUser"
        Me.pnlOuter.ResumeLayout(False)
        Me.pnlOuter.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.pbAvatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlOuter As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnUpload As Button
    Friend WithEvents pbAvatar As PictureBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblRole As Label
    Friend WithEvents cboRole As ComboBox
    Friend WithEvents lblProfileSmall As Label
    Friend WithEvents lblProfileLabel As Label
    Friend WithEvents lblRepeatPassword As Label
    Friend WithEvents pnlStrength As Panel
    Friend WithEvents txtRepeatPassword As TextBox
    Friend WithEvents lblStrength As Label
    Friend WithEvents Cancel As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSave As Button
End Class
