Imports CrystalDecisions.Shared
Imports CrystalDecisions.Windows.Forms
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions
Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Imports System.IO.Stream
Imports System.Configuration


Public Class frmDaily
    Public projectlst As New OleDbCommand
    Public cash, check, pdc As Integer
    Public rpt1 As New CrystalReport1
    Public rpt2 As New CrystalReport2
    Public rpt3 As New CrystalReport3
    Public rpt4 As New CrystalReport4
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim DS As New DataTable


        If cash = 1 And Me.chkDetailed.Checked = False Then

            Dim dc As New OleDbCommand("SELECT project, transDate, unitNum, custName, remarks, paymentCash, paymentCheck, transAmt, depositDate, prRef, orRef FROM collections WHERE paymentType='" + Me.lblPayment.Text + "' AND depositStatus ='" + Me.cboDepstat.Text + "' AND transDate =#" + Me.dpckTrans.Value + "# AND project ='" + Me.cboProject.Text + "'", Globals.dbCon)
            Dim da As OleDbDataReader = dc.ExecuteReader()
            DS.Load(da)
            CrystalReportViewer1.RefreshReport()
            CrystalReportViewer1.SelectionFormula = "{collections.paymentType} ='" + Me.lblPayment.Text + "' AND {collections.depositStatus} ='" + Me.cboDepstat.Text + "' AND {collections.transDate} = #" + Me.dpckTrans.Value + "# AND {collections.project} = '" + Me.cboProject.Text + "'"
            CrystalReportViewer1.RefreshReport()
            dc.Cancel()

        ElseIf cash = 1 And Me.chkDetailed.Checked = True Then
            Dim dc1 As New OleDbCommand("SELECT project, transDate, unitNum, custName, remarks, paymentCash, paymentCheck, transAmt, depositDate, waterConsumption, waterCardload, waterCard, joiningFee, maintenance, associationDues, penalty, smartCardaccess, parking, constructionSecdep, swimmingPoolGymbasketball, rentalAmenity, rental, carSticker, others, prRef, orRef FROM collections  WHERE paymentType='" + Me.lblPayment.Text + "' AND depositStatus ='" + Me.cboDepstat.Text + "' AND transDate =#" + Me.dpckTrans.Value + "# AND project ='" + Me.cboProject.Text + "'", Globals.dbCon)
            Dim da1 As OleDbDataReader = dc1.ExecuteReader()
            DS.Load(da1)
            CrystalReportViewer1.RefreshReport()
            CrystalReportViewer1.SelectionFormula = "{collections.paymentType} ='" + Me.lblPayment.Text + "' AND {collections.depositStatus} ='" + Me.cboDepstat.Text + "' AND {collections.transDate} = #" + Me.dpckTrans.Value + "# AND {collections.project} = '" + Me.cboProject.Text + "'"
            CrystalReportViewer1.RefreshReport()
            dc1.Cancel()

        ElseIf check = 1 And Me.chkDetailed.Checked = False Then
            Dim dc2 As New OleDbCommand("SELECT project, transDate, unitNum, custName, depositDate,  prRef, orRef, paymentCash, paymentCheck, checkDate, transAmt, remarks FROM collections WHERE paymentType='" + Me.lblPayment.Text + "' AND depositStatus ='" + Me.cboDepstat.Text + "' AND transDate =#" + Me.dpckTrans.Value + "# AND project ='" + Me.cboProject.Text + "'", Globals.dbCon)
            Dim da2 As OleDbDataReader = dc2.ExecuteReader()
            DS.Load(da2)
            CrystalReportViewer1.RefreshReport()
            CrystalReportViewer1.SelectionFormula = "{collections.paymentType} ='" + Me.lblPayment.Text + "' AND {collections.depositStatus} ='" + Me.cboDepstat.Text + "' AND {collections.transDate} = #" + Me.dpckTrans.Value + "# AND {collections.project} = '" + Me.cboProject.Text + "'"
            CrystalReportViewer1.RefreshReport()

        ElseIf check = 1 And Me.chkDetailed.Checked = True Then
            Dim dc3 As New OleDbCommand("SELECT project, transDate, unitNum, custName, remarks, paymentCash, paymentCheck, transAmt, depositDate, waterConsumption, waterCardload, waterCard, joiningFee, maintenance, associationDues, penalty, smartCardaccess, parking, constructionSecdep, swimmingPoolGymbasketball, rentalAmenity, rental, carSticker, others, prRef, orRef FROM collections  WHERE paymentType='" + Me.lblPayment.Text + "' AND depositStatus ='" + Me.cboDepstat.Text + "' AND transDate =#" + Me.dpckTrans.Value + "# AND project ='" + Me.cboProject.Text + "'", Globals.dbCon)
            Dim da3 As OleDbDataReader = dc3.ExecuteReader()
            DS.Load(da3)
            CrystalReportViewer1.RefreshReport()
            CrystalReportViewer1.SelectionFormula = "{collections.paymentType} ='" + Me.lblPayment.Text + "' AND {collections.depositStatus} ='" + Me.cboDepstat.Text + "' AND {collections.transDate} = #" + Me.dpckTrans.Value + "# AND {collections.project} = '" + Me.cboProject.Text + "'"
            CrystalReportViewer1.RefreshReport()
            dc3.Cancel()

        ElseIf pdc = 1 Then
            Dim dc4 As New OleDbCommand("SELECT project, transDate, custName, remarks, transAmt, checkNum, checkDate, bank, branch, prRef FROM collections WHERE paymentType='" + Me.lblPayment.Text + "' AND depositStatus ='PENDING' AND checkDate > #" + Me.dpckTrans.Value + "# AND project ='" + Me.cboProject.Text + "'", Globals.dbCon)
            Dim da4 As OleDbDataReader = dc4.ExecuteReader()
            DS.Load(da4)
            CrystalReportViewer1.RefreshReport()
            CrystalReportViewer1.SelectionFormula = "{collections.paymentType} ='" + Me.lblPayment.Text + "' AND {collections.depositStatus} ='PENDING' AND {collections.checkDate} > #" + Me.dpckTrans.Value + "# AND {collections.project} = '" + Me.cboProject.Text + "'"
            CrystalReportViewer1.RefreshReport()

        Else
            MsgBox("NOTHING TO DISPLAY!")
            Exit Sub

        End If

    End Sub

    Private Sub frmDaily_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ds As New trsAppDataSet
        Dim ad As New trsAppDataSetTableAdapters.collectionsTableAdapter
        ad.Fill(ds.collections)
        rpt1.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = rpt1

        Me.cboDepstat.Items.Add("PENDING")
        Me.cboDepstat.Items.Add("DEPOSITED")
        Me.chkDetailed.Visible = False
        Me.chkDetailed.Enabled = False

        projectlst.Connection = Globals.dbCon
        projectlst.CommandText = "SELECT projectName FROM projects"
        Dim projlst As OleDbDataReader = projectlst.ExecuteReader()
        While projlst.Read
            cboProject.Items.Add(projlst.Item(0))
        End While

    End Sub

    Private Sub HOMEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HOMEToolStripMenuItem.Click
        frmHome.Show()
        Me.Hide()
    End Sub

    Private Sub chkCash_CheckedChanged(sender As Object, e As EventArgs) Handles chkCash.CheckedChanged
        If Me.chkCash.Checked = True Then
            Me.lblPayment.Text = "CASH"
            Me.cboDepstat.Text = "DEPOSITED"
            Me.chkCheck.Checked = False
            Me.chkPdc.Checked = False
            Me.chkDetailed.Visible = True
            Me.chkDetailed.Enabled = True
            cash = 1

            Dim ds As New trsAppDataSet
            Dim ad As New trsAppDataSetTableAdapters.collectionsTableAdapter
            ad.Fill(ds.collections)
            rpt1.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = rpt1

        ElseIf Me.chkCash.Checked = False And Me.chkPdc.Checked = True Then
            cash = 0
            chkPdc_CheckedChanged(sender, e)
        ElseIf Me.chkCash.Checked = False And Me.chkCheck.Checked = True Then
            cash = 0
            chkCheck_CheckedChanged(sender, e)
        Else
            Me.lblPayment.Text = ""
            Me.cboDepstat.Text = ""
            cash = 0
            Me.chkDetailed.Checked = False
        End If
    End Sub

    Private Sub chkCheck_CheckedChanged(sender As Object, e As EventArgs) Handles chkCheck.CheckedChanged
        If Me.chkCheck.Checked = True Then
            Me.lblPayment.Text = "CHECK"
            Me.cboDepstat.Text = "DEPOSITED"
            Me.chkCash.Checked = False
            Me.chkPdc.Checked = False
            Me.chkDetailed.Visible = True
            Me.chkDetailed.Enabled = True
            check = 1

            Dim ds As New trsAppDataSet
            Dim ad As New trsAppDataSetTableAdapters.collectionsTableAdapter
            ad.Fill(ds.collections)
            rpt2.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = rpt2

        ElseIf Me.chkCheck.Checked = False And Me.chkPdc.Checked = True Then
            check = 0
            chkPdc_CheckedChanged(sender, e)
        ElseIf Me.chkCheck.Checked = False And Me.chkCash.Checked = True Then
            check = 0
            chkCash_CheckedChanged(sender, e)
        Else
            Me.lblPayment.Text = ""
            Me.cboDepstat.Text = ""
            check = 0
            Me.chkDetailed.Checked = False
        End If
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Try
            Dim CrExportOptions As ExportOptions
            Dim CrDiskFileDestinationOptions As New DiskFileDestinationOptions
            Dim CrFormatTypeOptions As New ExcelFormatOptions
            CrFormatTypeOptions.ExcelUseConstantColumnWidth = False

            If cash = 1 And Me.chkDetailed.Checked = False Then
                CrDiskFileDestinationOptions.DiskFileName = Application.StartupPath + "\SummarizedCashCollectionReport.xls"
                CrExportOptions = rpt1.ExportOptions
                With CrExportOptions
                    .ExportDestinationType = ExportDestinationType.DiskFile
                    .ExportFormatType = ExportFormatType.Excel
                    .DestinationOptions = CrDiskFileDestinationOptions
                    .FormatOptions = CrFormatTypeOptions
                End With
                MsgBox("LOCATE THE FILE INSIDE THE TRSV2 FOLDER")
                rpt1.Export()
            ElseIf cash = 1 And Me.chkDetailed.Checked = True Then
                CrDiskFileDestinationOptions.DiskFileName = Application.StartupPath + "\DetailedCashCollectionReport.xls"
                CrExportOptions = rpt4.ExportOptions
                With CrExportOptions
                    .ExportDestinationType = ExportDestinationType.DiskFile
                    .ExportFormatType = ExportFormatType.Excel
                    .DestinationOptions = CrDiskFileDestinationOptions
                    .FormatOptions = CrFormatTypeOptions
                End With
                MsgBox("LOCATE THE FILE INSIDE THE TRSV2 FOLDER")
                rpt4.Export()
            ElseIf check = 1 And Me.chkDetailed.Checked = False Then
                CrDiskFileDestinationOptions.DiskFileName = Application.StartupPath + "\SummarizedCheckCollectionReport.xls"
                CrExportOptions = rpt2.ExportOptions
                With CrExportOptions
                    .ExportDestinationType = ExportDestinationType.DiskFile
                    .ExportFormatType = ExportFormatType.Excel
                    .DestinationOptions = CrDiskFileDestinationOptions
                    .FormatOptions = CrFormatTypeOptions
                End With
                MsgBox("LOCATE THE FILE INSIDE THE TRSV2 FOLDER")
                rpt2.Export()
            ElseIf check = 1 And Me.chkDetailed.Checked = True Then
                CrDiskFileDestinationOptions.DiskFileName = Application.StartupPath + "\DetailedCheckCollectionReport.xls"
                CrExportOptions = rpt4.ExportOptions
                With CrExportOptions
                    .ExportDestinationType = ExportDestinationType.DiskFile
                    .ExportFormatType = ExportFormatType.Excel
                    .DestinationOptions = CrDiskFileDestinationOptions
                    .FormatOptions = CrFormatTypeOptions
                End With
                MsgBox("LOCATE THE FILE INSIDE THE TRSV2 FOLDER")
                rpt4.Export()
            ElseIf pdc = 1 Then
                CrDiskFileDestinationOptions.DiskFileName = Application.StartupPath + "\PDCCollectionReport.xls"
                CrExportOptions = rpt3.ExportOptions
                With CrExportOptions
                    .ExportDestinationType = ExportDestinationType.DiskFile
                    .ExportFormatType = ExportFormatType.Excel
                    .DestinationOptions = CrDiskFileDestinationOptions
                    .FormatOptions = CrFormatTypeOptions
                End With
                MsgBox("LOCATE THE FILE INSIDE THE TRSV2 FOLDER")
                rpt3.Export()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub chkDetailed_CheckedChanged(sender As Object, e As EventArgs) Handles chkDetailed.CheckedChanged
        If Me.chkDetailed.Checked = False And cash = 1 Then
            Dim ds As New trsAppDataSet
            Dim ad As New trsAppDataSetTableAdapters.collectionsTableAdapter
            ad.Fill(ds.collections)
            rpt1.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = rpt1
        ElseIf Me.chkDetailed.Checked = True And cash = 1 Then
            Dim ds2 As New trsAppDataSet
            Dim ad2 As New trsAppDataSetTableAdapters.collectionsTableAdapter
            ad2.Fill(ds2.collections)
            rpt4.SetDataSource(ds2)
            CrystalReportViewer1.ReportSource = rpt4
        ElseIf Me.chkDetailed.Checked = False And check = 1 Then
            Dim ds3 As New trsAppDataSet
            Dim ad3 As New trsAppDataSetTableAdapters.collectionsTableAdapter
            ad3.Fill(ds3.collections)
            rpt2.SetDataSource(ds3)
            CrystalReportViewer1.ReportSource = rpt2
        ElseIf Me.chkDetailed.Checked = True And check = 1 Then
            Dim ds4 As New trsAppDataSet
            Dim ad4 As New trsAppDataSetTableAdapters.collectionsTableAdapter
            ad4.Fill(ds4.collections)
            rpt4.SetDataSource(ds4)
            CrystalReportViewer1.ReportSource = rpt4
        End If
    End Sub

    Private Sub chkPdc_CheckedChanged(sender As Object, e As EventArgs) Handles chkPdc.CheckedChanged
        If Me.chkPdc.Checked = True Then
            Me.lblPayment.Text = "CHECK"
            Me.cboDepstat.Text = "PENDING"
            Me.chkDetailed.Visible = False
            Me.chkDetailed.Enabled = False
            Me.chkCheck.Checked = False
            Me.chkCash.Checked = False
            pdc = 1

            Dim ds As New trsAppDataSet
            Dim ad As New trsAppDataSetTableAdapters.collectionsTableAdapter
            ad.Fill(ds.collections)
            rpt3.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = rpt3
        ElseIf Me.chkPdc.Checked = False And Me.chkCheck.Checked = True Then
            pdc = 0
            chkCheck_CheckedChanged(sender, e)
        ElseIf Me.chkPdc.Checked = False And Me.chkCash.Checked = True Then
            pdc = 0
            chkCash_CheckedChanged(sender, e)
        Else
            pdc = 0
            Me.lblPayment.Text = ""
            Me.cboDepstat.Text = ""
        End If
    End Sub

End Class