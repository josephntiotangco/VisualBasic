<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmin
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BACKTOHOMEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.chkAcct = New System.Windows.Forms.CheckBox()
        Me.chkProject = New System.Windows.Forms.CheckBox()
        Me.chkBank = New System.Windows.Forms.CheckBox()
        Me.lblBankcbo = New System.Windows.Forms.Label()
        Me.cboBank = New System.Windows.Forms.ComboBox()
        Me.txtAcct = New System.Windows.Forms.TextBox()
        Me.btnAddprofile = New System.Windows.Forms.Button()
        Me.txtProjectname = New System.Windows.Forms.TextBox()
        Me.txtBankname = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.cboSite = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.chkShow = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboLevel = New System.Windows.Forms.ComboBox()
        Me.txtRetry = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnResetCollections = New System.Windows.Forms.Button()
        Me.btnDeleteProf = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(511, 31)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FILEToolStripMenuItem
        '
        Me.FILEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BACKTOHOMEToolStripMenuItem})
        Me.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(53, 27)
        Me.FILEToolStripMenuItem.Text = "FILE"
        '
        'BACKTOHOMEToolStripMenuItem
        '
        Me.BACKTOHOMEToolStripMenuItem.Name = "BACKTOHOMEToolStripMenuItem"
        Me.BACKTOHOMEToolStripMenuItem.Size = New System.Drawing.Size(209, 28)
        Me.BACKTOHOMEToolStripMenuItem.Text = "BACK TO HOME"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 34)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(511, 433)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Info
        Me.TabPage1.Controls.Add(Me.btnDeleteProf)
        Me.TabPage1.Controls.Add(Me.chkAcct)
        Me.TabPage1.Controls.Add(Me.chkProject)
        Me.TabPage1.Controls.Add(Me.chkBank)
        Me.TabPage1.Controls.Add(Me.lblBankcbo)
        Me.TabPage1.Controls.Add(Me.cboBank)
        Me.TabPage1.Controls.Add(Me.txtAcct)
        Me.TabPage1.Controls.Add(Me.btnAddprofile)
        Me.TabPage1.Controls.Add(Me.txtProjectname)
        Me.TabPage1.Controls.Add(Me.txtBankname)
        Me.TabPage1.Location = New System.Drawing.Point(4, 30)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(503, 399)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ADD PROFILES"
        '
        'chkAcct
        '
        Me.chkAcct.AutoSize = True
        Me.chkAcct.Location = New System.Drawing.Point(23, 148)
        Me.chkAcct.Name = "chkAcct"
        Me.chkAcct.Size = New System.Drawing.Size(120, 25)
        Me.chkAcct.TabIndex = 18
        Me.chkAcct.Text = "BANK ACCT#"
        Me.chkAcct.UseVisualStyleBackColor = True
        '
        'chkProject
        '
        Me.chkProject.AutoSize = True
        Me.chkProject.Location = New System.Drawing.Point(23, 88)
        Me.chkProject.Name = "chkProject"
        Me.chkProject.Size = New System.Drawing.Size(142, 25)
        Me.chkProject.TabIndex = 17
        Me.chkProject.Text = "PROJECT NAME"
        Me.chkProject.UseVisualStyleBackColor = True
        '
        'chkBank
        '
        Me.chkBank.AutoSize = True
        Me.chkBank.Location = New System.Drawing.Point(23, 29)
        Me.chkBank.Name = "chkBank"
        Me.chkBank.Size = New System.Drawing.Size(120, 25)
        Me.chkBank.TabIndex = 16
        Me.chkBank.Text = "BANK NAME"
        Me.chkBank.UseVisualStyleBackColor = True
        '
        'lblBankcbo
        '
        Me.lblBankcbo.AutoSize = True
        Me.lblBankcbo.Location = New System.Drawing.Point(44, 191)
        Me.lblBankcbo.Name = "lblBankcbo"
        Me.lblBankcbo.Size = New System.Drawing.Size(50, 21)
        Me.lblBankcbo.TabIndex = 15
        Me.lblBankcbo.Text = "BANK"
        '
        'cboBank
        '
        Me.cboBank.FormattingEnabled = True
        Me.cboBank.Location = New System.Drawing.Point(171, 191)
        Me.cboBank.Name = "cboBank"
        Me.cboBank.Size = New System.Drawing.Size(260, 29)
        Me.cboBank.TabIndex = 14
        '
        'txtAcct
        '
        Me.txtAcct.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAcct.Location = New System.Drawing.Point(171, 148)
        Me.txtAcct.Multiline = True
        Me.txtAcct.Name = "txtAcct"
        Me.txtAcct.Size = New System.Drawing.Size(260, 37)
        Me.txtAcct.TabIndex = 12
        '
        'btnAddprofile
        '
        Me.btnAddprofile.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddprofile.Location = New System.Drawing.Point(171, 244)
        Me.btnAddprofile.Name = "btnAddprofile"
        Me.btnAddprofile.Size = New System.Drawing.Size(149, 56)
        Me.btnAddprofile.TabIndex = 11
        Me.btnAddprofile.Text = "ADD PROFILE"
        Me.btnAddprofile.UseVisualStyleBackColor = True
        '
        'txtProjectname
        '
        Me.txtProjectname.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProjectname.Location = New System.Drawing.Point(171, 88)
        Me.txtProjectname.Multiline = True
        Me.txtProjectname.Name = "txtProjectname"
        Me.txtProjectname.Size = New System.Drawing.Size(260, 37)
        Me.txtProjectname.TabIndex = 8
        '
        'txtBankname
        '
        Me.txtBankname.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBankname.Location = New System.Drawing.Point(171, 29)
        Me.txtBankname.Multiline = True
        Me.txtBankname.Name = "txtBankname"
        Me.txtBankname.Size = New System.Drawing.Size(260, 37)
        Me.txtBankname.TabIndex = 6
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Info
        Me.TabPage2.Controls.Add(Me.cboSite)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.btnDelete)
        Me.TabPage2.Controls.Add(Me.chkShow)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.txtLastname)
        Me.TabPage2.Controls.Add(Me.btnAddUser)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.cboLevel)
        Me.TabPage2.Controls.Add(Me.txtRetry)
        Me.TabPage2.Controls.Add(Me.txtPassword)
        Me.TabPage2.Controls.Add(Me.txtFirstname)
        Me.TabPage2.Controls.Add(Me.txtUsername)
        Me.TabPage2.Location = New System.Drawing.Point(4, 30)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(503, 399)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "ADD USER"
        '
        'cboSite
        '
        Me.cboSite.FormattingEnabled = True
        Me.cboSite.Location = New System.Drawing.Point(127, 273)
        Me.cboSite.Name = "cboSite"
        Me.cboSite.Size = New System.Drawing.Size(197, 29)
        Me.cboSite.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 273)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 21)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "SITE"
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(346, 319)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(149, 56)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.Text = "DELETE USER"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'chkShow
        '
        Me.chkShow.AutoSize = True
        Me.chkShow.Location = New System.Drawing.Point(393, 158)
        Me.chkShow.Name = "chkShow"
        Me.chkShow.Size = New System.Drawing.Size(70, 25)
        Me.chkShow.TabIndex = 13
        Me.chkShow.Text = "show"
        Me.chkShow.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 21)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "LAST NAME"
        '
        'txtLastname
        '
        Me.txtLastname.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastname.Location = New System.Drawing.Point(127, 110)
        Me.txtLastname.Multiline = True
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(260, 37)
        Me.txtLastname.TabIndex = 11
        '
        'btnAddUser
        '
        Me.btnAddUser.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddUser.Location = New System.Drawing.Point(346, 257)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(149, 56)
        Me.btnAddUser.TabIndex = 10
        Me.btnAddUser.Text = "ADD USER"
        Me.btnAddUser.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 21)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "USER LEVEL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 42)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "RETRY" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PASSWORD"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "PASSWORD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "FIRST NAME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 21)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "USERNAME"
        '
        'cboLevel
        '
        Me.cboLevel.FormattingEnabled = True
        Me.cboLevel.Location = New System.Drawing.Point(127, 238)
        Me.cboLevel.Name = "cboLevel"
        Me.cboLevel.Size = New System.Drawing.Size(197, 29)
        Me.cboLevel.TabIndex = 4
        '
        'txtRetry
        '
        Me.txtRetry.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRetry.Location = New System.Drawing.Point(127, 194)
        Me.txtRetry.Multiline = True
        Me.txtRetry.Name = "txtRetry"
        Me.txtRetry.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRetry.Size = New System.Drawing.Size(260, 37)
        Me.txtRetry.TabIndex = 3
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(127, 153)
        Me.txtPassword.Multiline = True
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(260, 37)
        Me.txtPassword.TabIndex = 2
        '
        'txtFirstname
        '
        Me.txtFirstname.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstname.Location = New System.Drawing.Point(127, 67)
        Me.txtFirstname.Multiline = True
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(260, 37)
        Me.txtFirstname.TabIndex = 1
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(127, 22)
        Me.txtUsername.Multiline = True
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(260, 37)
        Me.txtUsername.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Info
        Me.TabPage3.Controls.Add(Me.btnResetCollections)
        Me.TabPage3.Location = New System.Drawing.Point(4, 30)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(503, 399)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "RESET COLLECTIONS"
        '
        'btnResetCollections
        '
        Me.btnResetCollections.Font = New System.Drawing.Font("Calibri", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetCollections.Location = New System.Drawing.Point(135, 96)
        Me.btnResetCollections.Name = "btnResetCollections"
        Me.btnResetCollections.Size = New System.Drawing.Size(241, 113)
        Me.btnResetCollections.TabIndex = 0
        Me.btnResetCollections.Text = "RESET COLLECTIONS"
        Me.btnResetCollections.UseVisualStyleBackColor = True
        '
        'btnDeleteProf
        '
        Me.btnDeleteProf.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteProf.Location = New System.Drawing.Point(171, 306)
        Me.btnDeleteProf.Name = "btnDeleteProf"
        Me.btnDeleteProf.Size = New System.Drawing.Size(149, 56)
        Me.btnDeleteProf.TabIndex = 19
        Me.btnDeleteProf.Text = "DELETE PROFILE"
        Me.btnDeleteProf.UseVisualStyleBackColor = True
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(511, 467)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADMIN"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FILEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BACKTOHOMEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents btnResetCollections As Button
    Friend WithEvents btnAddUser As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboLevel As ComboBox
    Friend WithEvents txtRetry As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtFirstname As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtLastname As TextBox
    Friend WithEvents chkShow As CheckBox
    Friend WithEvents cboSite As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAddprofile As Button
    Friend WithEvents txtProjectname As TextBox
    Friend WithEvents txtBankname As TextBox
    Friend WithEvents lblBankcbo As Label
    Friend WithEvents cboBank As ComboBox
    Friend WithEvents txtAcct As TextBox
    Friend WithEvents chkAcct As CheckBox
    Friend WithEvents chkProject As CheckBox
    Friend WithEvents chkBank As CheckBox
    Friend WithEvents btnDeleteProf As Button
End Class
