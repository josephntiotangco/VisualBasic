<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHome
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHome))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtUnit = New System.Windows.Forms.TextBox()
        Me.txtCustomer = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.cboCustType = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboProject = New System.Windows.Forms.ComboBox()
        Me.lblDocDate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblTransID = New System.Windows.Forms.Label()
        Me.cboParticular = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboPayment = New System.Windows.Forms.ComboBox()
        Me.cboForm = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtForm = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboBank = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCheck = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtBankBranch = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dpckCheckDate = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cboDepositStat = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dpckDeposit = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtDepositby = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cboBankact = New System.Windows.Forms.ComboBox()
        Me.txtDepositRef = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblPrintStat = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cboNewForm = New System.Windows.Forms.ComboBox()
        Me.txtNewForm = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.dpckForm = New System.Windows.Forms.DateTimePicker()
        Me.cbkNew = New System.Windows.Forms.CheckBox()
        Me.cbkUpdate = New System.Windows.Forms.CheckBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REPORTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DAILYCOLLECTIONREPORTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DETAILEDREPORTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OVERDUEPDCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStrip = New System.Windows.Forms.MenuStrip()
        Me.PRINTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PRINTPREVIEWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ADMINToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MAINTENANCEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.colDataGridView = New System.Windows.Forms.DataGridView()
        Me.TrsAppDataSet = New trsAppv2.trsAppDataSet()
        Me.CollectionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CollectionsTableAdapter = New trsAppv2.trsAppDataSetTableAdapters.collectionsTableAdapter()
        Me.TableAdapterManager = New trsAppv2.trsAppDataSetTableAdapters.TableAdapterManager()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.btnAddOr = New System.Windows.Forms.Button()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.lblOrAmt = New System.Windows.Forms.Label()
        Me.lblPrAmt = New System.Windows.Forms.Label()
        Me.lblRec = New System.Windows.Forms.Label()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.lblREcby = New System.Windows.Forms.Label()
        Me.menuStrip.SuspendLayout()
        CType(Me.colDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrsAppDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CollectionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSave
        '
        resources.ApplyResources(Me.btnSave, "btnSave")
        Me.btnSave.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnSave.Name = "btnSave"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtUnit
        '
        resources.ApplyResources(Me.txtUnit, "txtUnit")
        Me.txtUnit.Name = "txtUnit"
        '
        'txtCustomer
        '
        resources.ApplyResources(Me.txtCustomer, "txtCustomer")
        Me.txtCustomer.Name = "txtCustomer"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'txtRemarks
        '
        resources.ApplyResources(Me.txtRemarks, "txtRemarks")
        Me.txtRemarks.Name = "txtRemarks"
        '
        'Label26
        '
        resources.ApplyResources(Me.Label26, "Label26")
        Me.Label26.Name = "Label26"
        '
        'txtAmount
        '
        resources.ApplyResources(Me.txtAmount, "txtAmount")
        Me.txtAmount.Name = "txtAmount"
        '
        'cboCustType
        '
        resources.ApplyResources(Me.cboCustType, "cboCustType")
        Me.cboCustType.FormattingEnabled = True
        Me.cboCustType.Name = "cboCustType"
        '
        'Label25
        '
        resources.ApplyResources(Me.Label25, "Label25")
        Me.Label25.Name = "Label25"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'cboProject
        '
        resources.ApplyResources(Me.cboProject, "cboProject")
        Me.cboProject.FormattingEnabled = True
        Me.cboProject.Name = "cboProject"
        '
        'lblDocDate
        '
        resources.ApplyResources(Me.lblDocDate, "lblDocDate")
        Me.lblDocDate.Name = "lblDocDate"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label19
        '
        resources.ApplyResources(Me.Label19, "Label19")
        Me.Label19.Name = "Label19"
        '
        'lblTransID
        '
        resources.ApplyResources(Me.lblTransID, "lblTransID")
        Me.lblTransID.Name = "lblTransID"
        '
        'cboParticular
        '
        resources.ApplyResources(Me.cboParticular, "cboParticular")
        Me.cboParticular.FormattingEnabled = True
        Me.cboParticular.Name = "cboParticular"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'cboPayment
        '
        resources.ApplyResources(Me.cboPayment, "cboPayment")
        Me.cboPayment.FormattingEnabled = True
        Me.cboPayment.Name = "cboPayment"
        '
        'cboForm
        '
        resources.ApplyResources(Me.cboForm, "cboForm")
        Me.cboForm.FormattingEnabled = True
        Me.cboForm.Name = "cboForm"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'txtForm
        '
        resources.ApplyResources(Me.txtForm, "txtForm")
        Me.txtForm.Name = "txtForm"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'cboBank
        '
        resources.ApplyResources(Me.cboBank, "cboBank")
        Me.cboBank.FormattingEnabled = True
        Me.cboBank.Name = "cboBank"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Name = "Label10"
        '
        'txtCheck
        '
        resources.ApplyResources(Me.txtCheck, "txtCheck")
        Me.txtCheck.Name = "txtCheck"
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.Name = "Label11"
        '
        'txtBankBranch
        '
        resources.ApplyResources(Me.txtBankBranch, "txtBankBranch")
        Me.txtBankBranch.Name = "txtBankBranch"
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.Name = "Label12"
        '
        'dpckCheckDate
        '
        resources.ApplyResources(Me.dpckCheckDate, "dpckCheckDate")
        Me.dpckCheckDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpckCheckDate.Name = "dpckCheckDate"
        Me.dpckCheckDate.Value = New Date(2019, 10, 23, 15, 47, 38, 0)
        '
        'Label13
        '
        resources.ApplyResources(Me.Label13, "Label13")
        Me.Label13.Name = "Label13"
        '
        'Label18
        '
        resources.ApplyResources(Me.Label18, "Label18")
        Me.Label18.Name = "Label18"
        '
        'Label14
        '
        resources.ApplyResources(Me.Label14, "Label14")
        Me.Label14.Name = "Label14"
        '
        'cboDepositStat
        '
        resources.ApplyResources(Me.cboDepositStat, "cboDepositStat")
        Me.cboDepositStat.FormattingEnabled = True
        Me.cboDepositStat.Name = "cboDepositStat"
        '
        'Label15
        '
        resources.ApplyResources(Me.Label15, "Label15")
        Me.Label15.Name = "Label15"
        '
        'dpckDeposit
        '
        resources.ApplyResources(Me.dpckDeposit, "dpckDeposit")
        Me.dpckDeposit.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpckDeposit.Name = "dpckDeposit"
        Me.dpckDeposit.Value = New Date(2019, 10, 23, 15, 47, 38, 0)
        '
        'Label17
        '
        resources.ApplyResources(Me.Label17, "Label17")
        Me.Label17.Name = "Label17"
        '
        'txtDepositby
        '
        resources.ApplyResources(Me.txtDepositby, "txtDepositby")
        Me.txtDepositby.Name = "txtDepositby"
        '
        'Label20
        '
        resources.ApplyResources(Me.Label20, "Label20")
        Me.Label20.Name = "Label20"
        '
        'Label21
        '
        resources.ApplyResources(Me.Label21, "Label21")
        Me.Label21.Name = "Label21"
        '
        'cboBankact
        '
        resources.ApplyResources(Me.cboBankact, "cboBankact")
        Me.cboBankact.FormattingEnabled = True
        Me.cboBankact.Name = "cboBankact"
        '
        'txtDepositRef
        '
        resources.ApplyResources(Me.txtDepositRef, "txtDepositRef")
        Me.txtDepositRef.Name = "txtDepositRef"
        '
        'Label16
        '
        resources.ApplyResources(Me.Label16, "Label16")
        Me.Label16.Name = "Label16"
        '
        'lblPrintStat
        '
        resources.ApplyResources(Me.lblPrintStat, "lblPrintStat")
        Me.lblPrintStat.Name = "lblPrintStat"
        '
        'Label22
        '
        resources.ApplyResources(Me.Label22, "Label22")
        Me.Label22.Name = "Label22"
        '
        'cboNewForm
        '
        resources.ApplyResources(Me.cboNewForm, "cboNewForm")
        Me.cboNewForm.FormattingEnabled = True
        Me.cboNewForm.Name = "cboNewForm"
        '
        'txtNewForm
        '
        resources.ApplyResources(Me.txtNewForm, "txtNewForm")
        Me.txtNewForm.Name = "txtNewForm"
        '
        'Label23
        '
        resources.ApplyResources(Me.Label23, "Label23")
        Me.Label23.Name = "Label23"
        '
        'Label24
        '
        resources.ApplyResources(Me.Label24, "Label24")
        Me.Label24.Name = "Label24"
        '
        'dpckForm
        '
        resources.ApplyResources(Me.dpckForm, "dpckForm")
        Me.dpckForm.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpckForm.Name = "dpckForm"
        Me.dpckForm.Value = New Date(2019, 10, 23, 15, 47, 38, 0)
        '
        'cbkNew
        '
        resources.ApplyResources(Me.cbkNew, "cbkNew")
        Me.cbkNew.Name = "cbkNew"
        Me.cbkNew.UseVisualStyleBackColor = True
        '
        'cbkUpdate
        '
        resources.ApplyResources(Me.cbkUpdate, "cbkUpdate")
        Me.cbkUpdate.Name = "cbkUpdate"
        Me.cbkUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        resources.ApplyResources(Me.btnAdd, "btnAdd")
        Me.btnAdd.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogOutToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        resources.ApplyResources(Me.FileToolStripMenuItem, "FileToolStripMenuItem")
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        resources.ApplyResources(Me.LogOutToolStripMenuItem, "LogOutToolStripMenuItem")
        '
        'REPORTSToolStripMenuItem
        '
        Me.REPORTSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DAILYCOLLECTIONREPORTToolStripMenuItem, Me.DETAILEDREPORTToolStripMenuItem, Me.OVERDUEPDCToolStripMenuItem})
        Me.REPORTSToolStripMenuItem.Name = "REPORTSToolStripMenuItem"
        resources.ApplyResources(Me.REPORTSToolStripMenuItem, "REPORTSToolStripMenuItem")
        '
        'DAILYCOLLECTIONREPORTToolStripMenuItem
        '
        Me.DAILYCOLLECTIONREPORTToolStripMenuItem.Name = "DAILYCOLLECTIONREPORTToolStripMenuItem"
        resources.ApplyResources(Me.DAILYCOLLECTIONREPORTToolStripMenuItem, "DAILYCOLLECTIONREPORTToolStripMenuItem")
        '
        'DETAILEDREPORTToolStripMenuItem
        '
        Me.DETAILEDREPORTToolStripMenuItem.Name = "DETAILEDREPORTToolStripMenuItem"
        resources.ApplyResources(Me.DETAILEDREPORTToolStripMenuItem, "DETAILEDREPORTToolStripMenuItem")
        '
        'OVERDUEPDCToolStripMenuItem
        '
        Me.OVERDUEPDCToolStripMenuItem.Name = "OVERDUEPDCToolStripMenuItem"
        resources.ApplyResources(Me.OVERDUEPDCToolStripMenuItem, "OVERDUEPDCToolStripMenuItem")
        '
        'menuStrip
        '
        resources.ApplyResources(Me.menuStrip, "menuStrip")
        Me.menuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.REPORTSToolStripMenuItem, Me.PRINTToolStripMenuItem, Me.ADMINToolStripMenuItem})
        Me.menuStrip.Name = "menuStrip"
        '
        'PRINTToolStripMenuItem
        '
        Me.PRINTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PRINTPREVIEWToolStripMenuItem})
        Me.PRINTToolStripMenuItem.Name = "PRINTToolStripMenuItem"
        resources.ApplyResources(Me.PRINTToolStripMenuItem, "PRINTToolStripMenuItem")
        '
        'PRINTPREVIEWToolStripMenuItem
        '
        Me.PRINTPREVIEWToolStripMenuItem.Name = "PRINTPREVIEWToolStripMenuItem"
        resources.ApplyResources(Me.PRINTPREVIEWToolStripMenuItem, "PRINTPREVIEWToolStripMenuItem")
        '
        'ADMINToolStripMenuItem
        '
        Me.ADMINToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MAINTENANCEToolStripMenuItem})
        Me.ADMINToolStripMenuItem.Name = "ADMINToolStripMenuItem"
        resources.ApplyResources(Me.ADMINToolStripMenuItem, "ADMINToolStripMenuItem")
        '
        'MAINTENANCEToolStripMenuItem
        '
        Me.MAINTENANCEToolStripMenuItem.Name = "MAINTENANCEToolStripMenuItem"
        resources.ApplyResources(Me.MAINTENANCEToolStripMenuItem, "MAINTENANCEToolStripMenuItem")
        '
        'colDataGridView
        '
        Me.colDataGridView.AllowUserToAddRows = False
        Me.colDataGridView.AllowUserToDeleteRows = False
        Me.colDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.colDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 7.8!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colDataGridView.DefaultCellStyle = DataGridViewCellStyle1
        Me.colDataGridView.GridColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.colDataGridView, "colDataGridView")
        Me.colDataGridView.MultiSelect = False
        Me.colDataGridView.Name = "colDataGridView"
        Me.colDataGridView.ReadOnly = True
        Me.colDataGridView.RowTemplate.Height = 24
        '
        'TrsAppDataSet
        '
        Me.TrsAppDataSet.DataSetName = "trsAppDataSet"
        Me.TrsAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CollectionsBindingSource
        '
        Me.CollectionsBindingSource.DataMember = "collections"
        Me.CollectionsBindingSource.DataSource = Me.TrsAppDataSet
        '
        'CollectionsTableAdapter
        '
        Me.CollectionsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bankacctTableAdapter = Nothing
        Me.TableAdapterManager.banksTableAdapter = Nothing
        Me.TableAdapterManager.collectionsTableAdapter = Me.CollectionsTableAdapter
        Me.TableAdapterManager.particularsTableAdapter = Nothing
        Me.TableAdapterManager.projectsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = trsAppv2.trsAppDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Nothing
        '
        'Label27
        '
        resources.ApplyResources(Me.Label27, "Label27")
        Me.Label27.Name = "Label27"
        '
        'btnAddOr
        '
        resources.ApplyResources(Me.btnAddOr, "btnAddOr")
        Me.btnAddOr.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnAddOr.Name = "btnAddOr"
        Me.btnAddOr.UseVisualStyleBackColor = True
        '
        'Label28
        '
        resources.ApplyResources(Me.Label28, "Label28")
        Me.Label28.Name = "Label28"
        '
        'Label29
        '
        resources.ApplyResources(Me.Label29, "Label29")
        Me.Label29.Name = "Label29"
        '
        'lblOrAmt
        '
        resources.ApplyResources(Me.lblOrAmt, "lblOrAmt")
        Me.lblOrAmt.Name = "lblOrAmt"
        '
        'lblPrAmt
        '
        resources.ApplyResources(Me.lblPrAmt, "lblPrAmt")
        Me.lblPrAmt.Name = "lblPrAmt"
        '
        'lblRec
        '
        resources.ApplyResources(Me.lblRec, "lblRec")
        Me.lblRec.Name = "lblRec"
        '
        'btnDown
        '
        resources.ApplyResources(Me.btnDown, "btnDown")
        Me.btnDown.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnDown.Name = "btnDown"
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'btnUp
        '
        resources.ApplyResources(Me.btnUp, "btnUp")
        Me.btnUp.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnUp.Name = "btnUp"
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'lblREcby
        '
        resources.ApplyResources(Me.lblREcby, "lblREcby")
        Me.lblREcby.Name = "lblREcby"
        '
        'frmHome
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.cbkUpdate)
        Me.Controls.Add(Me.lblREcby)
        Me.Controls.Add(Me.cbkNew)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnUp)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.btnDown)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.lblRec)
        Me.Controls.Add(Me.cboCustType)
        Me.Controls.Add(Me.lblPrAmt)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.lblOrAmt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.txtCustomer)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.txtUnit)
        Me.Controls.Add(Me.btnAddOr)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboProject)
        Me.Controls.Add(Me.lblDocDate)
        Me.Controls.Add(Me.colDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblTransID)
        Me.Controls.Add(Me.menuStrip)
        Me.Controls.Add(Me.cboParticular)
        Me.Controls.Add(Me.cboDepositStat)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dpckDeposit)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDepositby)
        Me.Controls.Add(Me.cboPayment)
        Me.Controls.Add(Me.cboBankact)
        Me.Controls.Add(Me.cboForm)
        Me.Controls.Add(Me.txtDepositRef)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblPrintStat)
        Me.Controls.Add(Me.txtForm)
        Me.Controls.Add(Me.cboNewForm)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtNewForm)
        Me.Controls.Add(Me.cboBank)
        Me.Controls.Add(Me.dpckForm)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtCheck)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtBankBranch)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.dpckCheckDate)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label24)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.menuStrip
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHome"
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        CType(Me.colDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrsAppDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CollectionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As Button
    Friend WithEvents txtUnit As TextBox
    Friend WithEvents txtCustomer As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents dpckCheckDate As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents txtBankBranch As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtCheck As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cboBank As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtForm As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cboForm As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cboPayment As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cboParticular As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblDocDate As Label
    Friend WithEvents cboProject As ComboBox
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents dpckDeposit As DateTimePicker
    Friend WithEvents cboDepositStat As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtDepositby As TextBox
    Friend WithEvents lblPrintStat As Label
    Friend WithEvents dpckForm As DateTimePicker
    Friend WithEvents Label24 As Label
    Friend WithEvents txtDepositRef As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents cboNewForm As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents txtNewForm As TextBox
    Friend WithEvents cbkNew As CheckBox
    Friend WithEvents cbkUpdate As CheckBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents TrsAppDataSet As trsAppDataSet
    Friend WithEvents CollectionsBindingSource As BindingSource
    Friend WithEvents CollectionsTableAdapter As trsAppDataSetTableAdapters.collectionsTableAdapter
    Friend WithEvents TableAdapterManager As trsAppDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents REPORTSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DAILYCOLLECTIONREPORTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DETAILEDREPORTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents colDataGridView As DataGridView
    Friend WithEvents Label19 As Label
    Friend WithEvents lblTransID As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents cboCustType As ComboBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents Label26 As Label
    Public WithEvents menuStrip As MenuStrip
    Friend WithEvents OVERDUEPDCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PRINTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PRINTPREVIEWToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ADMINToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MAINTENANCEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cboBankact As ComboBox
    Friend WithEvents Label27 As Label
    Friend WithEvents btnAddOr As Button
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents lblOrAmt As Label
    Friend WithEvents lblPrAmt As Label
    Friend WithEvents lblRec As Label
    Friend WithEvents btnDown As Button
    Friend WithEvents btnUp As Button
    Friend WithEvents lblREcby As Label
End Class
