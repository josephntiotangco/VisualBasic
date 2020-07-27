<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOverdue
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOverdue))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FILESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HOMEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOGOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.overdueDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.linkExport = New System.Windows.Forms.LinkLabel()
        Me.lblWarning = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.overdueDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILESToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1290, 32)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FILESToolStripMenuItem
        '
        Me.FILESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HOMEToolStripMenuItem, Me.LOGOUTToolStripMenuItem})
        Me.FILESToolStripMenuItem.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FILESToolStripMenuItem.Name = "FILESToolStripMenuItem"
        Me.FILESToolStripMenuItem.Size = New System.Drawing.Size(63, 28)
        Me.FILESToolStripMenuItem.Text = "FILES"
        '
        'HOMEToolStripMenuItem
        '
        Me.HOMEToolStripMenuItem.Name = "HOMEToolStripMenuItem"
        Me.HOMEToolStripMenuItem.Size = New System.Drawing.Size(181, 28)
        Me.HOMEToolStripMenuItem.Text = "HOME"
        '
        'LOGOUTToolStripMenuItem
        '
        Me.LOGOUTToolStripMenuItem.Name = "LOGOUTToolStripMenuItem"
        Me.LOGOUTToolStripMenuItem.Size = New System.Drawing.Size(181, 28)
        Me.LOGOUTToolStripMenuItem.Text = "LOG OUT"
        '
        'overdueDataGridView1
        '
        Me.overdueDataGridView1.AllowUserToAddRows = False
        Me.overdueDataGridView1.AllowUserToDeleteRows = False
        Me.overdueDataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.overdueDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.overdueDataGridView1.Location = New System.Drawing.Point(22, 134)
        Me.overdueDataGridView1.Name = "overdueDataGridView1"
        Me.overdueDataGridView1.ReadOnly = True
        Me.overdueDataGridView1.RowTemplate.Height = 24
        Me.overdueDataGridView1.Size = New System.Drawing.Size(1256, 385)
        Me.overdueDataGridView1.TabIndex = 1
        '
        'linkExport
        '
        Me.linkExport.AutoSize = True
        Me.linkExport.LinkColor = System.Drawing.Color.Black
        Me.linkExport.Location = New System.Drawing.Point(1145, 104)
        Me.linkExport.Name = "linkExport"
        Me.linkExport.Size = New System.Drawing.Size(120, 17)
        Me.linkExport.TabIndex = 2
        Me.linkExport.TabStop = True
        Me.linkExport.Text = "EXPORT TO CSV"
        '
        'lblWarning
        '
        Me.lblWarning.AutoSize = True
        Me.lblWarning.Font = New System.Drawing.Font("Calibri", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWarning.ForeColor = System.Drawing.Color.Red
        Me.lblWarning.Location = New System.Drawing.Point(16, 59)
        Me.lblWarning.Name = "lblWarning"
        Me.lblWarning.Size = New System.Drawing.Size(27, 35)
        Me.lblWarning.TabIndex = 3
        Me.lblWarning.Text = "  "
        '
        'frmOverdue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1290, 549)
        Me.Controls.Add(Me.lblWarning)
        Me.Controls.Add(Me.linkExport)
        Me.Controls.Add(Me.overdueDataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmOverdue"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OVERDUE CHECKS"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.overdueDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FILESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HOMEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LOGOUTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents overdueDataGridView1 As DataGridView
    Friend WithEvents linkExport As LinkLabel
    Friend WithEvents lblWarning As Label
End Class
