<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDaily
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDaily))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FILESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HOMEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.dpckTrans = New System.Windows.Forms.DateTimePicker()
        Me.cboDepstat = New System.Windows.Forms.ComboBox()
        Me.chkCheck = New System.Windows.Forms.CheckBox()
        Me.chkPdc = New System.Windows.Forms.CheckBox()
        Me.chkCash = New System.Windows.Forms.CheckBox()
        Me.chkDetailed = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboProject = New System.Windows.Forms.ComboBox()
        Me.lblPayment = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILESToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1122, 32)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FILESToolStripMenuItem
        '
        Me.FILESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HOMEToolStripMenuItem})
        Me.FILESToolStripMenuItem.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FILESToolStripMenuItem.Name = "FILESToolStripMenuItem"
        Me.FILESToolStripMenuItem.Size = New System.Drawing.Size(63, 28)
        Me.FILESToolStripMenuItem.Text = "FILES"
        '
        'HOMEToolStripMenuItem
        '
        Me.HOMEToolStripMenuItem.Name = "HOMEToolStripMenuItem"
        Me.HOMEToolStripMenuItem.Size = New System.Drawing.Size(140, 28)
        Me.HOMEToolStripMenuItem.Text = "HOME"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(12, 194)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1098, 591)
        Me.CrystalReportViewer1.TabIndex = 16
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'btnGenerate
        '
        Me.btnGenerate.AutoSize = True
        Me.btnGenerate.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnGenerate.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerate.Location = New System.Drawing.Point(643, 35)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(133, 48)
        Me.btnGenerate.TabIndex = 17
        Me.btnGenerate.Text = "GENERATE"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'dpckTrans
        '
        Me.dpckTrans.CalendarFont = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpckTrans.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpckTrans.Location = New System.Drawing.Point(403, 33)
        Me.dpckTrans.Name = "dpckTrans"
        Me.dpckTrans.Size = New System.Drawing.Size(180, 26)
        Me.dpckTrans.TabIndex = 18
        Me.dpckTrans.Value = New Date(2019, 10, 29, 0, 0, 0, 0)
        '
        'cboDepstat
        '
        Me.cboDepstat.FormattingEnabled = True
        Me.cboDepstat.Location = New System.Drawing.Point(403, 63)
        Me.cboDepstat.Name = "cboDepstat"
        Me.cboDepstat.Size = New System.Drawing.Size(180, 26)
        Me.cboDepstat.TabIndex = 20
        '
        'chkCheck
        '
        Me.chkCheck.AutoSize = True
        Me.chkCheck.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCheck.Location = New System.Drawing.Point(3, 33)
        Me.chkCheck.Name = "chkCheck"
        Me.chkCheck.Size = New System.Drawing.Size(78, 24)
        Me.chkCheck.TabIndex = 21
        Me.chkCheck.Text = "CHECK"
        Me.chkCheck.UseVisualStyleBackColor = True
        '
        'chkPdc
        '
        Me.chkPdc.AutoSize = True
        Me.chkPdc.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPdc.Location = New System.Drawing.Point(3, 63)
        Me.chkPdc.Name = "chkPdc"
        Me.chkPdc.Size = New System.Drawing.Size(68, 24)
        Me.chkPdc.TabIndex = 22
        Me.chkPdc.Text = "PDCs"
        Me.chkPdc.UseVisualStyleBackColor = True
        '
        'chkCash
        '
        Me.chkCash.AutoSize = True
        Me.chkCash.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCash.Location = New System.Drawing.Point(3, 3)
        Me.chkCash.Name = "chkCash"
        Me.chkCash.Size = New System.Drawing.Size(70, 24)
        Me.chkCash.TabIndex = 23
        Me.chkCash.Text = "CASH"
        Me.chkCash.UseVisualStyleBackColor = True
        '
        'chkDetailed
        '
        Me.chkDetailed.AutoSize = True
        Me.chkDetailed.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDetailed.Location = New System.Drawing.Point(403, 123)
        Me.chkDetailed.Name = "chkDetailed"
        Me.chkDetailed.Size = New System.Drawing.Size(107, 25)
        Me.chkDetailed.TabIndex = 25
        Me.chkDetailed.Text = "DETAILED?"
        Me.chkDetailed.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.55963!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.98693!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.47712!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.chkPdc, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.chkCheck, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.chkCash, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cboProject, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cboDepstat, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.dpckTrans, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblPayment, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.chkDetailed, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 1, 4)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(25, 35)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(612, 153)
        Me.TableLayoutPanel1.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(196, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 23)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "PAYMENT TYPE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(196, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 23)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "DEPOSIT STATUS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(196, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 23)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "DATE"
        '
        'cboProject
        '
        Me.cboProject.FormattingEnabled = True
        Me.cboProject.Location = New System.Drawing.Point(403, 3)
        Me.cboProject.Name = "cboProject"
        Me.cboProject.Size = New System.Drawing.Size(180, 26)
        Me.cboProject.TabIndex = 28
        '
        'lblPayment
        '
        Me.lblPayment.AutoSize = True
        Me.lblPayment.Location = New System.Drawing.Point(403, 90)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(11, 18)
        Me.lblPayment.TabIndex = 27
        Me.lblPayment.Text = " "
        Me.lblPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(196, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 23)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "PROJECT"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(196, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 23)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "DETAILED?"
        '
        'btnExport
        '
        Me.btnExport.AutoSize = True
        Me.btnExport.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnExport.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.Location = New System.Drawing.Point(643, 104)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(133, 51)
        Me.btnExport.TabIndex = 27
        Me.btnExport.Text = "EXPORT TO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "EXCEL"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'frmDaily
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1122, 838)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDaily"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DAILY COLLECTION"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FILESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HOMEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnGenerate As Button
    Friend WithEvents dpckTrans As DateTimePicker
    Friend WithEvents cboDepstat As ComboBox
    Friend WithEvents chkCheck As CheckBox
    Friend WithEvents chkPdc As CheckBox
    Friend WithEvents chkCash As CheckBox
    Friend WithEvents chkDetailed As CheckBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblPayment As Label
    Friend WithEvents cboProject As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnExport As Button
End Class
