<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFormPrinting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFormPrinting))
        Me.cboFormType = New System.Windows.Forms.ComboBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbOr = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtProj = New System.Windows.Forms.TextBox()
        Me.txtUnit = New System.Windows.Forms.TextBox()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.txtAmt1 = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPay = New System.Windows.Forms.TextBox()
        Me.txtAmt2 = New System.Windows.Forms.TextBox()
        Me.txtRef = New System.Windows.Forms.TextBox()
        Me.txtWords = New System.Windows.Forms.TextBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtCust = New System.Windows.Forms.TextBox()
        Me.tbPr = New System.Windows.Forms.TabPage()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtRec2locy = New System.Windows.Forms.TextBox()
        Me.txtRec2locx = New System.Windows.Forms.TextBox()
        Me.txtRec2y = New System.Windows.Forms.TextBox()
        Me.txtRec2x = New System.Windows.Forms.TextBox()
        Me.txtRec1locy = New System.Windows.Forms.TextBox()
        Me.txtRec1locx = New System.Windows.Forms.TextBox()
        Me.txtRec1y = New System.Windows.Forms.TextBox()
        Me.txtRec1x = New System.Windows.Forms.TextBox()
        Me.txtReclocy = New System.Windows.Forms.TextBox()
        Me.txtReclocx = New System.Windows.Forms.TextBox()
        Me.txtRecy = New System.Windows.Forms.TextBox()
        Me.txtRecx = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCusty = New System.Windows.Forms.TextBox()
        Me.txtCustx = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtProjy = New System.Windows.Forms.TextBox()
        Me.txtProjx = New System.Windows.Forms.TextBox()
        Me.txtUnity = New System.Windows.Forms.TextBox()
        Me.txtUnitx = New System.Windows.Forms.TextBox()
        Me.txtPayy = New System.Windows.Forms.TextBox()
        Me.txtPayx = New System.Windows.Forms.TextBox()
        Me.txtNamey = New System.Windows.Forms.TextBox()
        Me.txtNamex = New System.Windows.Forms.TextBox()
        Me.txtRemy = New System.Windows.Forms.TextBox()
        Me.txtRemx = New System.Windows.Forms.TextBox()
        Me.txtRefy = New System.Windows.Forms.TextBox()
        Me.txtRefx = New System.Windows.Forms.TextBox()
        Me.txtWordy = New System.Windows.Forms.TextBox()
        Me.txtWordx = New System.Windows.Forms.TextBox()
        Me.txtAmt2y = New System.Windows.Forms.TextBox()
        Me.txtAmt2x = New System.Windows.Forms.TextBox()
        Me.txtAmt1y = New System.Windows.Forms.TextBox()
        Me.txtAmt1x = New System.Windows.Forms.TextBox()
        Me.txtDatey = New System.Windows.Forms.TextBox()
        Me.txtDatex = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BACKTOHOMEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PRINTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PRINTPREVIEWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDocument3 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintPreviewDialog3 = New System.Windows.Forms.PrintPreviewDialog()
        Me.TabControl1.SuspendLayout()
        Me.tbOr.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.tbPr.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboFormType
        '
        Me.cboFormType.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFormType.FormattingEnabled = True
        Me.cboFormType.Location = New System.Drawing.Point(226, 48)
        Me.cboFormType.Name = "cboFormType"
        Me.cboFormType.Size = New System.Drawing.Size(181, 32)
        Me.cboFormType.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbOr)
        Me.TabControl1.Controls.Add(Me.tbPr)
        Me.TabControl1.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(8, 97)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(616, 429)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 1
        '
        'tbOr
        '
        Me.tbOr.BackColor = System.Drawing.SystemColors.Control
        Me.tbOr.Controls.Add(Me.Panel1)
        Me.tbOr.Location = New System.Drawing.Point(4, 30)
        Me.tbOr.Name = "tbOr"
        Me.tbOr.Padding = New System.Windows.Forms.Padding(3)
        Me.tbOr.Size = New System.Drawing.Size(608, 395)
        Me.tbOr.TabIndex = 0
        Me.tbOr.Text = "TEMPLATE"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.txtProj)
        Me.Panel1.Controls.Add(Me.txtUnit)
        Me.Panel1.Controls.Add(Me.txtRemarks)
        Me.Panel1.Controls.Add(Me.txtAmt1)
        Me.Panel1.Controls.Add(Me.txtUser)
        Me.Panel1.Controls.Add(Me.txtPay)
        Me.Panel1.Controls.Add(Me.txtAmt2)
        Me.Panel1.Controls.Add(Me.txtRef)
        Me.Panel1.Controls.Add(Me.txtWords)
        Me.Panel1.Controls.Add(Me.txtDate)
        Me.Panel1.Controls.Add(Me.txtCust)
        Me.Panel1.Location = New System.Drawing.Point(19, 18)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(566, 312)
        Me.Panel1.TabIndex = 23
        '
        'txtProj
        '
        Me.txtProj.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProj.Location = New System.Drawing.Point(322, 231)
        Me.txtProj.Multiline = True
        Me.txtProj.Name = "txtProj"
        Me.txtProj.Size = New System.Drawing.Size(122, 24)
        Me.txtProj.TabIndex = 33
        '
        'txtUnit
        '
        Me.txtUnit.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnit.Location = New System.Drawing.Point(195, 231)
        Me.txtUnit.Multiline = True
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(122, 24)
        Me.txtUnit.TabIndex = 32
        '
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.Location = New System.Drawing.Point(195, 192)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(337, 33)
        Me.txtRemarks.TabIndex = 31
        '
        'txtAmt1
        '
        Me.txtAmt1.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmt1.Location = New System.Drawing.Point(195, 154)
        Me.txtAmt1.Multiline = True
        Me.txtAmt1.Name = "txtAmt1"
        Me.txtAmt1.Size = New System.Drawing.Size(137, 33)
        Me.txtAmt1.TabIndex = 30
        '
        'txtUser
        '
        Me.txtUser.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Location = New System.Drawing.Point(410, 260)
        Me.txtUser.Multiline = True
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(122, 24)
        Me.txtUser.TabIndex = 29
        '
        'txtPay
        '
        Me.txtPay.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPay.Location = New System.Drawing.Point(33, 260)
        Me.txtPay.Multiline = True
        Me.txtPay.Name = "txtPay"
        Me.txtPay.Size = New System.Drawing.Size(122, 24)
        Me.txtPay.TabIndex = 28
        '
        'txtAmt2
        '
        Me.txtAmt2.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmt2.Location = New System.Drawing.Point(33, 231)
        Me.txtAmt2.Multiline = True
        Me.txtAmt2.Name = "txtAmt2"
        Me.txtAmt2.Size = New System.Drawing.Size(122, 24)
        Me.txtAmt2.TabIndex = 27
        '
        'txtRef
        '
        Me.txtRef.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRef.Location = New System.Drawing.Point(33, 28)
        Me.txtRef.Multiline = True
        Me.txtRef.Name = "txtRef"
        Me.txtRef.Size = New System.Drawing.Size(122, 197)
        Me.txtRef.TabIndex = 26
        '
        'txtWords
        '
        Me.txtWords.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWords.Location = New System.Drawing.Point(195, 115)
        Me.txtWords.Multiline = True
        Me.txtWords.Name = "txtWords"
        Me.txtWords.Size = New System.Drawing.Size(337, 33)
        Me.txtWords.TabIndex = 25
        '
        'txtDate
        '
        Me.txtDate.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Location = New System.Drawing.Point(396, 28)
        Me.txtDate.Multiline = True
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(137, 33)
        Me.txtDate.TabIndex = 24
        '
        'txtCust
        '
        Me.txtCust.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCust.Location = New System.Drawing.Point(284, 77)
        Me.txtCust.Multiline = True
        Me.txtCust.Name = "txtCust"
        Me.txtCust.Size = New System.Drawing.Size(248, 33)
        Me.txtCust.TabIndex = 23
        '
        'tbPr
        '
        Me.tbPr.BackColor = System.Drawing.SystemColors.Control
        Me.tbPr.Controls.Add(Me.btnUpdate)
        Me.tbPr.Controls.Add(Me.Label14)
        Me.tbPr.Controls.Add(Me.Label13)
        Me.tbPr.Controls.Add(Me.Label12)
        Me.tbPr.Controls.Add(Me.txtRec2locy)
        Me.tbPr.Controls.Add(Me.txtRec2locx)
        Me.tbPr.Controls.Add(Me.txtRec2y)
        Me.tbPr.Controls.Add(Me.txtRec2x)
        Me.tbPr.Controls.Add(Me.txtRec1locy)
        Me.tbPr.Controls.Add(Me.txtRec1locx)
        Me.tbPr.Controls.Add(Me.txtRec1y)
        Me.tbPr.Controls.Add(Me.txtRec1x)
        Me.tbPr.Controls.Add(Me.txtReclocy)
        Me.tbPr.Controls.Add(Me.txtReclocx)
        Me.tbPr.Controls.Add(Me.txtRecy)
        Me.tbPr.Controls.Add(Me.txtRecx)
        Me.tbPr.Controls.Add(Me.Label11)
        Me.tbPr.Controls.Add(Me.Label10)
        Me.tbPr.Controls.Add(Me.txtCusty)
        Me.tbPr.Controls.Add(Me.txtCustx)
        Me.tbPr.Controls.Add(Me.Label9)
        Me.tbPr.Controls.Add(Me.Label8)
        Me.tbPr.Controls.Add(Me.Label7)
        Me.tbPr.Controls.Add(Me.Label6)
        Me.tbPr.Controls.Add(Me.Label5)
        Me.tbPr.Controls.Add(Me.Label4)
        Me.tbPr.Controls.Add(Me.Label3)
        Me.tbPr.Controls.Add(Me.Label2)
        Me.tbPr.Controls.Add(Me.Label1)
        Me.tbPr.Controls.Add(Me.txtProjy)
        Me.tbPr.Controls.Add(Me.txtProjx)
        Me.tbPr.Controls.Add(Me.txtUnity)
        Me.tbPr.Controls.Add(Me.txtUnitx)
        Me.tbPr.Controls.Add(Me.txtPayy)
        Me.tbPr.Controls.Add(Me.txtPayx)
        Me.tbPr.Controls.Add(Me.txtNamey)
        Me.tbPr.Controls.Add(Me.txtNamex)
        Me.tbPr.Controls.Add(Me.txtRemy)
        Me.tbPr.Controls.Add(Me.txtRemx)
        Me.tbPr.Controls.Add(Me.txtRefy)
        Me.tbPr.Controls.Add(Me.txtRefx)
        Me.tbPr.Controls.Add(Me.txtWordy)
        Me.tbPr.Controls.Add(Me.txtWordx)
        Me.tbPr.Controls.Add(Me.txtAmt2y)
        Me.tbPr.Controls.Add(Me.txtAmt2x)
        Me.tbPr.Controls.Add(Me.txtAmt1y)
        Me.tbPr.Controls.Add(Me.txtAmt1x)
        Me.tbPr.Controls.Add(Me.txtDatey)
        Me.tbPr.Controls.Add(Me.txtDatex)
        Me.tbPr.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPr.Location = New System.Drawing.Point(4, 30)
        Me.tbPr.Name = "tbPr"
        Me.tbPr.Padding = New System.Windows.Forms.Padding(3)
        Me.tbPr.Size = New System.Drawing.Size(608, 395)
        Me.tbPr.TabIndex = 1
        Me.tbPr.Text = "SETTINGS"
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdate.AutoSize = True
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnUpdate.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(402, 304)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(182, 52)
        Me.btnUpdate.TabIndex = 73
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(398, 197)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(110, 21)
        Me.Label14.TabIndex = 72
        Me.Label14.Text = "REMARKS BOX"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(398, 101)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(95, 21)
        Me.Label13.TabIndex = 71
        Me.Label13.Text = "WORDS BOX"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(398, 5)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 21)
        Me.Label12.TabIndex = 70
        Me.Label12.Text = "REFERENCE BOX"
        '
        'txtRec2locy
        '
        Me.txtRec2locy.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRec2locy.Location = New System.Drawing.Point(496, 253)
        Me.txtRec2locy.Multiline = True
        Me.txtRec2locy.Name = "txtRec2locy"
        Me.txtRec2locy.Size = New System.Drawing.Size(88, 26)
        Me.txtRec2locy.TabIndex = 69
        '
        'txtRec2locx
        '
        Me.txtRec2locx.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRec2locx.Location = New System.Drawing.Point(402, 253)
        Me.txtRec2locx.Multiline = True
        Me.txtRec2locx.Name = "txtRec2locx"
        Me.txtRec2locx.Size = New System.Drawing.Size(88, 26)
        Me.txtRec2locx.TabIndex = 68
        '
        'txtRec2y
        '
        Me.txtRec2y.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRec2y.Location = New System.Drawing.Point(496, 221)
        Me.txtRec2y.Multiline = True
        Me.txtRec2y.Name = "txtRec2y"
        Me.txtRec2y.Size = New System.Drawing.Size(88, 26)
        Me.txtRec2y.TabIndex = 67
        '
        'txtRec2x
        '
        Me.txtRec2x.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRec2x.Location = New System.Drawing.Point(402, 221)
        Me.txtRec2x.Multiline = True
        Me.txtRec2x.Name = "txtRec2x"
        Me.txtRec2x.Size = New System.Drawing.Size(88, 26)
        Me.txtRec2x.TabIndex = 66
        '
        'txtRec1locy
        '
        Me.txtRec1locy.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRec1locy.Location = New System.Drawing.Point(496, 157)
        Me.txtRec1locy.Multiline = True
        Me.txtRec1locy.Name = "txtRec1locy"
        Me.txtRec1locy.Size = New System.Drawing.Size(88, 26)
        Me.txtRec1locy.TabIndex = 65
        '
        'txtRec1locx
        '
        Me.txtRec1locx.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRec1locx.Location = New System.Drawing.Point(402, 157)
        Me.txtRec1locx.Multiline = True
        Me.txtRec1locx.Name = "txtRec1locx"
        Me.txtRec1locx.Size = New System.Drawing.Size(88, 26)
        Me.txtRec1locx.TabIndex = 64
        '
        'txtRec1y
        '
        Me.txtRec1y.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRec1y.Location = New System.Drawing.Point(496, 125)
        Me.txtRec1y.Multiline = True
        Me.txtRec1y.Name = "txtRec1y"
        Me.txtRec1y.Size = New System.Drawing.Size(88, 26)
        Me.txtRec1y.TabIndex = 63
        '
        'txtRec1x
        '
        Me.txtRec1x.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRec1x.Location = New System.Drawing.Point(402, 125)
        Me.txtRec1x.Multiline = True
        Me.txtRec1x.Name = "txtRec1x"
        Me.txtRec1x.Size = New System.Drawing.Size(88, 26)
        Me.txtRec1x.TabIndex = 62
        '
        'txtReclocy
        '
        Me.txtReclocy.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReclocy.Location = New System.Drawing.Point(496, 61)
        Me.txtReclocy.Multiline = True
        Me.txtReclocy.Name = "txtReclocy"
        Me.txtReclocy.Size = New System.Drawing.Size(88, 26)
        Me.txtReclocy.TabIndex = 61
        '
        'txtReclocx
        '
        Me.txtReclocx.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReclocx.Location = New System.Drawing.Point(402, 61)
        Me.txtReclocx.Multiline = True
        Me.txtReclocx.Name = "txtReclocx"
        Me.txtReclocx.Size = New System.Drawing.Size(88, 26)
        Me.txtReclocx.TabIndex = 60
        '
        'txtRecy
        '
        Me.txtRecy.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecy.Location = New System.Drawing.Point(496, 29)
        Me.txtRecy.Multiline = True
        Me.txtRecy.Name = "txtRecy"
        Me.txtRecy.Size = New System.Drawing.Size(88, 26)
        Me.txtRecy.TabIndex = 59
        '
        'txtRecx
        '
        Me.txtRecx.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecx.Location = New System.Drawing.Point(402, 29)
        Me.txtRecx.Multiline = True
        Me.txtRecx.Name = "txtRecx"
        Me.txtRecx.Size = New System.Drawing.Size(88, 26)
        Me.txtRecx.TabIndex = 58
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(19, 335)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 21)
        Me.Label11.TabIndex = 57
        Me.Label11.Text = "CUSTOMER"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(19, 303)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 21)
        Me.Label10.TabIndex = 56
        Me.Label10.Text = "PROJECT"
        '
        'txtCusty
        '
        Me.txtCusty.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusty.Location = New System.Drawing.Point(214, 335)
        Me.txtCusty.Multiline = True
        Me.txtCusty.Name = "txtCusty"
        Me.txtCusty.Size = New System.Drawing.Size(88, 26)
        Me.txtCusty.TabIndex = 55
        '
        'txtCustx
        '
        Me.txtCustx.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustx.Location = New System.Drawing.Point(120, 335)
        Me.txtCustx.Multiline = True
        Me.txtCustx.Name = "txtCustx"
        Me.txtCustx.Size = New System.Drawing.Size(88, 26)
        Me.txtCustx.TabIndex = 54
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 271)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 21)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "UNIT"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 239)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 21)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "PAYMENT"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 207)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 21)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "NAME"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 21)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "REMARKS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 21)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "REFERENCE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 21)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "WORDS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 21)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "AMOUNT2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 21)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "AMOUNT1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 21)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "DATE"
        '
        'txtProjy
        '
        Me.txtProjy.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProjy.Location = New System.Drawing.Point(214, 303)
        Me.txtProjy.Multiline = True
        Me.txtProjy.Name = "txtProjy"
        Me.txtProjy.Size = New System.Drawing.Size(88, 26)
        Me.txtProjy.TabIndex = 44
        '
        'txtProjx
        '
        Me.txtProjx.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProjx.Location = New System.Drawing.Point(120, 303)
        Me.txtProjx.Multiline = True
        Me.txtProjx.Name = "txtProjx"
        Me.txtProjx.Size = New System.Drawing.Size(88, 26)
        Me.txtProjx.TabIndex = 43
        '
        'txtUnity
        '
        Me.txtUnity.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnity.Location = New System.Drawing.Point(214, 271)
        Me.txtUnity.Multiline = True
        Me.txtUnity.Name = "txtUnity"
        Me.txtUnity.Size = New System.Drawing.Size(88, 26)
        Me.txtUnity.TabIndex = 42
        '
        'txtUnitx
        '
        Me.txtUnitx.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitx.Location = New System.Drawing.Point(120, 271)
        Me.txtUnitx.Multiline = True
        Me.txtUnitx.Name = "txtUnitx"
        Me.txtUnitx.Size = New System.Drawing.Size(88, 26)
        Me.txtUnitx.TabIndex = 41
        '
        'txtPayy
        '
        Me.txtPayy.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPayy.Location = New System.Drawing.Point(214, 239)
        Me.txtPayy.Multiline = True
        Me.txtPayy.Name = "txtPayy"
        Me.txtPayy.Size = New System.Drawing.Size(88, 26)
        Me.txtPayy.TabIndex = 40
        '
        'txtPayx
        '
        Me.txtPayx.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPayx.Location = New System.Drawing.Point(120, 239)
        Me.txtPayx.Multiline = True
        Me.txtPayx.Name = "txtPayx"
        Me.txtPayx.Size = New System.Drawing.Size(88, 26)
        Me.txtPayx.TabIndex = 39
        '
        'txtNamey
        '
        Me.txtNamey.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamey.Location = New System.Drawing.Point(214, 207)
        Me.txtNamey.Multiline = True
        Me.txtNamey.Name = "txtNamey"
        Me.txtNamey.Size = New System.Drawing.Size(88, 26)
        Me.txtNamey.TabIndex = 38
        '
        'txtNamex
        '
        Me.txtNamex.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamex.Location = New System.Drawing.Point(120, 207)
        Me.txtNamex.Multiline = True
        Me.txtNamex.Name = "txtNamex"
        Me.txtNamex.Size = New System.Drawing.Size(88, 26)
        Me.txtNamex.TabIndex = 37
        '
        'txtRemy
        '
        Me.txtRemy.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemy.Location = New System.Drawing.Point(214, 175)
        Me.txtRemy.Multiline = True
        Me.txtRemy.Name = "txtRemy"
        Me.txtRemy.Size = New System.Drawing.Size(88, 26)
        Me.txtRemy.TabIndex = 36
        '
        'txtRemx
        '
        Me.txtRemx.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemx.Location = New System.Drawing.Point(120, 175)
        Me.txtRemx.Multiline = True
        Me.txtRemx.Name = "txtRemx"
        Me.txtRemx.Size = New System.Drawing.Size(88, 26)
        Me.txtRemx.TabIndex = 35
        '
        'txtRefy
        '
        Me.txtRefy.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefy.Location = New System.Drawing.Point(214, 143)
        Me.txtRefy.Multiline = True
        Me.txtRefy.Name = "txtRefy"
        Me.txtRefy.Size = New System.Drawing.Size(88, 26)
        Me.txtRefy.TabIndex = 34
        '
        'txtRefx
        '
        Me.txtRefx.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefx.Location = New System.Drawing.Point(120, 143)
        Me.txtRefx.Multiline = True
        Me.txtRefx.Name = "txtRefx"
        Me.txtRefx.Size = New System.Drawing.Size(88, 26)
        Me.txtRefx.TabIndex = 33
        '
        'txtWordy
        '
        Me.txtWordy.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWordy.Location = New System.Drawing.Point(214, 111)
        Me.txtWordy.Multiline = True
        Me.txtWordy.Name = "txtWordy"
        Me.txtWordy.Size = New System.Drawing.Size(88, 26)
        Me.txtWordy.TabIndex = 32
        '
        'txtWordx
        '
        Me.txtWordx.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWordx.Location = New System.Drawing.Point(120, 111)
        Me.txtWordx.Multiline = True
        Me.txtWordx.Name = "txtWordx"
        Me.txtWordx.Size = New System.Drawing.Size(88, 26)
        Me.txtWordx.TabIndex = 31
        '
        'txtAmt2y
        '
        Me.txtAmt2y.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmt2y.Location = New System.Drawing.Point(214, 79)
        Me.txtAmt2y.Multiline = True
        Me.txtAmt2y.Name = "txtAmt2y"
        Me.txtAmt2y.Size = New System.Drawing.Size(88, 26)
        Me.txtAmt2y.TabIndex = 30
        '
        'txtAmt2x
        '
        Me.txtAmt2x.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmt2x.Location = New System.Drawing.Point(120, 79)
        Me.txtAmt2x.Multiline = True
        Me.txtAmt2x.Name = "txtAmt2x"
        Me.txtAmt2x.Size = New System.Drawing.Size(88, 26)
        Me.txtAmt2x.TabIndex = 29
        '
        'txtAmt1y
        '
        Me.txtAmt1y.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmt1y.Location = New System.Drawing.Point(214, 47)
        Me.txtAmt1y.Multiline = True
        Me.txtAmt1y.Name = "txtAmt1y"
        Me.txtAmt1y.Size = New System.Drawing.Size(88, 26)
        Me.txtAmt1y.TabIndex = 28
        '
        'txtAmt1x
        '
        Me.txtAmt1x.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmt1x.Location = New System.Drawing.Point(120, 47)
        Me.txtAmt1x.Multiline = True
        Me.txtAmt1x.Name = "txtAmt1x"
        Me.txtAmt1x.Size = New System.Drawing.Size(88, 26)
        Me.txtAmt1x.TabIndex = 27
        '
        'txtDatey
        '
        Me.txtDatey.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDatey.Location = New System.Drawing.Point(214, 15)
        Me.txtDatey.Multiline = True
        Me.txtDatey.Name = "txtDatey"
        Me.txtDatey.Size = New System.Drawing.Size(88, 26)
        Me.txtDatey.TabIndex = 26
        '
        'txtDatex
        '
        Me.txtDatex.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDatex.Location = New System.Drawing.Point(120, 15)
        Me.txtDatex.Multiline = True
        Me.txtDatex.Name = "txtDatex"
        Me.txtDatex.Size = New System.Drawing.Size(88, 26)
        Me.txtDatex.TabIndex = 25
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem, Me.PRINTToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(636, 29)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FILEToolStripMenuItem
        '
        Me.FILEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BACKTOHOMEToolStripMenuItem})
        Me.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(50, 25)
        Me.FILEToolStripMenuItem.Text = "FILE"
        '
        'BACKTOHOMEToolStripMenuItem
        '
        Me.BACKTOHOMEToolStripMenuItem.Name = "BACKTOHOMEToolStripMenuItem"
        Me.BACKTOHOMEToolStripMenuItem.Size = New System.Drawing.Size(198, 26)
        Me.BACKTOHOMEToolStripMenuItem.Text = "BACK TO HOME"
        '
        'PRINTToolStripMenuItem
        '
        Me.PRINTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PRINTPREVIEWToolStripMenuItem})
        Me.PRINTToolStripMenuItem.Name = "PRINTToolStripMenuItem"
        Me.PRINTToolStripMenuItem.Size = New System.Drawing.Size(65, 25)
        Me.PRINTToolStripMenuItem.Text = "PRINT"
        '
        'PRINTPREVIEWToolStripMenuItem
        '
        Me.PRINTPREVIEWToolStripMenuItem.Name = "PRINTPREVIEWToolStripMenuItem"
        Me.PRINTPREVIEWToolStripMenuItem.Size = New System.Drawing.Size(198, 26)
        Me.PRINTPREVIEWToolStripMenuItem.Text = "PRINT PREVIEW"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintPreviewDialog3
        '
        Me.PrintPreviewDialog3.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog3.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog3.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog3.Enabled = True
        Me.PrintPreviewDialog3.Icon = CType(resources.GetObject("PrintPreviewDialog3.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog3.Name = "PrintPreviewDialog3"
        Me.PrintPreviewDialog3.Visible = False
        '
        'frmFormPrinting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(636, 538)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.cboFormType)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFormPrinting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FORM PRINTING"
        Me.TabControl1.ResumeLayout(False)
        Me.tbOr.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tbPr.ResumeLayout(False)
        Me.tbPr.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboFormType As ComboBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tbOr As TabPage
    Friend WithEvents tbPr As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtProj As TextBox
    Friend WithEvents txtUnit As TextBox
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents txtAmt1 As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPay As TextBox
    Friend WithEvents txtAmt2 As TextBox
    Friend WithEvents txtRef As TextBox
    Friend WithEvents txtWords As TextBox
    Friend WithEvents txtDate As TextBox
    Friend WithEvents txtCust As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtProjy As TextBox
    Friend WithEvents txtProjx As TextBox
    Friend WithEvents txtUnity As TextBox
    Friend WithEvents txtUnitx As TextBox
    Friend WithEvents txtPayy As TextBox
    Friend WithEvents txtPayx As TextBox
    Friend WithEvents txtNamey As TextBox
    Friend WithEvents txtNamex As TextBox
    Friend WithEvents txtRemy As TextBox
    Friend WithEvents txtRemx As TextBox
    Friend WithEvents txtRefy As TextBox
    Friend WithEvents txtRefx As TextBox
    Friend WithEvents txtWordy As TextBox
    Friend WithEvents txtWordx As TextBox
    Friend WithEvents txtAmt2y As TextBox
    Friend WithEvents txtAmt2x As TextBox
    Friend WithEvents txtAmt1y As TextBox
    Friend WithEvents txtAmt1x As TextBox
    Friend WithEvents txtDatey As TextBox
    Friend WithEvents txtDatex As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtRec2locy As TextBox
    Friend WithEvents txtRec2locx As TextBox
    Friend WithEvents txtRec2y As TextBox
    Friend WithEvents txtRec2x As TextBox
    Friend WithEvents txtRec1locy As TextBox
    Friend WithEvents txtRec1locx As TextBox
    Friend WithEvents txtRec1y As TextBox
    Friend WithEvents txtRec1x As TextBox
    Friend WithEvents txtReclocy As TextBox
    Friend WithEvents txtReclocx As TextBox
    Friend WithEvents txtRecy As TextBox
    Friend WithEvents txtRecx As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCusty As TextBox
    Friend WithEvents txtCustx As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FILEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BACKTOHOMEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PRINTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PRINTPREVIEWToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDocument3 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintPreviewDialog3 As PrintPreviewDialog
    Friend WithEvents btnUpdate As Button
End Class
