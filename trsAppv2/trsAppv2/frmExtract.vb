Imports System.Data.OleDb
Imports System.Data
Imports System.Data.ParameterDirection
Imports System.IO.FileStream
Imports System.IO
Imports System.IO.Stream
Imports System.Xml
Imports System.Xml.XPath
Imports ExcelAutoFormat = Microsoft.Office.Interop.Excel.XlRangeAutoFormat
Imports Microsoft.Office.Core
Imports Excel = Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop
Imports System.Data.SqlClient
Imports trsAppv2.trsAppDataSetTableAdapters
Imports trsAppv2.trsAppDataSet
Public Class frmExtract
    Public projectlst As New OleDbCommand
    Public frmD, toD As Date
    Public proj, unit, pay, stat As String

    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        If extractDataGridView1.RowCount = 0 Then
            MsgBox("NOTHING TO EXTRACT!")
            Exit Sub
        Else
            xlApp = New Excel.Application()
            xlWorkBook = xlApp.Workbooks.Add(misValue)
            xlWorkSheet = xlWorkBook.Sheets("sheet1")
            Me.ProgressBar1.Maximum = extractDataGridView1.RowCount

            For i = 0 To extractDataGridView1.RowCount - 2
                Me.ProgressBar1.Value = Int(i * (ProgressBar1.Maximum / extractDataGridView1.RowCount))
                My.Application.DoEvents()
                For j = 0 To extractDataGridView1.ColumnCount - 1
                    For k As Integer = 1 To extractDataGridView1.Columns.Count
                        xlWorkSheet.Cells(1, k) = extractDataGridView1.Columns(k - 1).HeaderText
                        xlWorkSheet.Cells(i + 2, j + 1) = extractDataGridView1(j, i).Value.ToString()
                    Next
                Next
                Me.ProgressBar1.PerformStep()
            Next
            xlWorkSheet.SaveAs(Application.StartupPath + "\Detailed Collection Report.xlsx")
            xlWorkBook.Close()
            xlApp.Quit()

            releaseObject(xlApp)
            releaseObject(xlWorkBook)
            releaseObject(xlWorkSheet)

            MsgBox("YOU CAN FIND THE FILE IN Debug:\Detailed Collection Report.xlsx")
        End If

    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try

    End Sub

    Private Sub HOMEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HOMEToolStripMenuItem.Click
        frmHome.Show()
        Me.Hide()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        If extractDataGridView1.RowCount = 0 Then
            MsgBox("NOTHING TO EXTRACT!")
            Exit Sub
        Else
            'www.vbforums.com/showthread.php?635207-RESOLVED-Exporting-DataGridView-to-CSV
            Dim headers = (From header As DataGridViewColumn In extractDataGridView1.Columns.Cast(Of DataGridViewColumn)()
                           Select header.HeaderText).ToArray
            Dim drows = From row As DataGridViewRow In extractDataGridView1.Rows.Cast(Of DataGridViewRow)()
                        Where Not row.IsNewRow
                        Select Array.ConvertAll(row.Cells.Cast(Of DataGridViewCell).ToArray, Function(c) If(c.Value IsNot Nothing, c.Value.ToString, ""))

            Using sw As New IO.StreamWriter("PerDateDetailedReport.txt")
                sw.WriteLine(String.Join("|", headers))
                For Each r In drows
                    sw.WriteLine(String.Join("|", r))
                Next
                MsgBox("CSV FILE GENERATED")
            End Using

            Process.Start("PerDateDetailedReport.txt")

            If System.IO.File.Exists(Globals.logs) = True Then
                'Dim objWriter As New System.IO.StreamWriter(Globals.logs, False)
                Dim objWriter As New System.IO.StreamWriter(Globals.logs, True)
                objWriter.Write(vbNewLine & Globals.logdate & "| " & Globals.loginFullname & " | " & Globals.loginUserlevel & " | " & "GENERATE PER DATE REPORT")
                objWriter.Close()
            Else
                Dim objWriter As New System.IO.StreamWriter(Globals.logs, False)
                objWriter.Write(vbNewLine & Globals.logdate & "| " & Globals.loginFullname & " | " & Globals.loginUserlevel & " | " & "GENERATE PER DATE REPORT")
                objWriter.Close()
            End If
        End If
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        extractDataGridView1.DataSource = GetSearchCol()
        MsgBox("From: " & frmD & " To: " & toD & " project: " & proj & " unit: " & unit & " payment type: " & pay & " status: " & stat)
    End Sub

    Private Function GetSearchCol() As DataTable
        Dim dtsearch As New DataTable

        proj = cboProject.Text
        unit = txtUnit.Text
        frmD = dpckFrom.Text
        toD = dpckTo.Text
        pay = cboPayment.Text
        stat = cboDepstat.Text

        If proj = "" And unit = "" And pay = "" And stat = "" Then
            Using gencol As New OleDbCommand("SELECT * FROM collections WHERE transDate BETWEEN #" & frmD & "# AND #" & toD & "#", Globals.dbCon)
                Dim gencolread As OleDbDataReader = gencol.ExecuteReader()
                gencolread.Read()
                dtsearch.Load(gencolread)
            End Using
        ElseIf proj <> "" And unit = "" And pay = "" And stat = "" Then
            Using gencol As New OleDbCommand("SELECT * FROM collections WHERE transDate BETWEEN #" & frmD & "# AND #" & toD & "# AND project IN ('" & proj & "');", Globals.dbCon)
                Dim gencolread As OleDbDataReader = gencol.ExecuteReader()
                gencolread.Read()
                dtsearch.Load(gencolread)
            End Using
        ElseIf proj = "" And unit <> "" And pay = "" And stat = "" Then
            Using gencol As New OleDbCommand("SELECT * FROM collections WHERE transDate BETWEEN #" & frmD & "# AND #" & toD & "# AND unitNum IN ('" & unit & "');", Globals.dbCon)
                Dim gencolread As OleDbDataReader = gencol.ExecuteReader()
                gencolread.Read()
                dtsearch.Load(gencolread)
            End Using

        ElseIf proj = "" And unit = "" And pay <> "" And stat = "" Then
            Using gencol As New OleDbCommand("SELECT * FROM collections WHERE transDate BETWEEN #" & frmD & "# AND #" & toD & "# AND paymentType IN ('" & pay & "');", Globals.dbCon)
                Dim gencolread As OleDbDataReader = gencol.ExecuteReader()
                gencolread.Read()
                dtsearch.Load(gencolread)
            End Using

        ElseIf proj = "" And unit = "" And pay = "" And stat <> "" Then
            Using gencol As New OleDbCommand("SELECT * FROM collections WHERE transDate BETWEEN #" & frmD & "# AND #" & toD & "# AND depositStatus IN ('" & stat & "');", Globals.dbCon)
                Dim gencolread As OleDbDataReader = gencol.ExecuteReader()
                gencolread.Read()
                dtsearch.Load(gencolread)
            End Using

        ElseIf proj <> "" And unit <> "" And pay = "" And stat <> "" Then
            Using gencol As New OleDbCommand("SELECT * FROM collections WHERE transDate BETWEEN #" & frmD & "# AND #" & toD & "# AND project IN ('" & proj & "') AND unitNum IN ('" & unit & "');", Globals.dbCon)
                Dim gencolread As OleDbDataReader = gencol.ExecuteReader()
                gencolread.Read()
                dtsearch.Load(gencolread)
            End Using

        ElseIf proj <> "" And unit = "" And pay = "" And stat <> "" Then
            Using gencol As New OleDbCommand("SELECT * FROM collections WHERE transDate BETWEEN #" & frmD & "# AND #" & toD & "# AND project IN ('" & proj & "') AND depositStatus IN ('" & stat & "');", Globals.dbCon)
                Dim gencolread As OleDbDataReader = gencol.ExecuteReader()
                gencolread.Read()
                dtsearch.Load(gencolread)
            End Using
        ElseIf proj <> "" And unit = "" And pay <> "" And stat = "" Then
            Using gencol As New OleDbCommand("SELECT * FROM collections WHERE transDate BETWEEN #" & frmD & "# AND #" & toD & "# AND project IN ('" & proj & "') AND paymentType IN ('" & pay & "');", Globals.dbCon)
                Dim gencolread As OleDbDataReader = gencol.ExecuteReader()
                gencolread.Read()
                dtsearch.Load(gencolread)
            End Using

        ElseIf proj = "" And unit <> "" And pay <> "" And stat = "" Then
            Using gencol As New OleDbCommand("SELECT * FROM collections WHERE transDate BETWEEN #" & frmD & "# AND #" & toD & "# AND unitNum IN ('" & unit & "') AND paymentType IN ('" & pay & "');", Globals.dbCon)
                Dim gencolread As OleDbDataReader = gencol.ExecuteReader()
                gencolread.Read()
                dtsearch.Load(gencolread)
            End Using
        ElseIf proj = "" And unit <> "" And pay = "" And stat <> "" Then
            Using gencol As New OleDbCommand("SELECT * FROM collections WHERE transDate BETWEEN #" & frmD & "# AND #" & toD & "# AND unitNum IN ('" & unit & "') AND depositStatus IN ('" & stat & "');", Globals.dbCon)
                Dim gencolread As OleDbDataReader = gencol.ExecuteReader()
                gencolread.Read()
                dtsearch.Load(gencolread)
            End Using
        ElseIf proj = "" And unit = "" And pay <> "" And stat <> "" Then
            Using gencol As New OleDbCommand("SELECT * FROM collections WHERE transDate BETWEEN #" & frmD & "# AND #" & toD & "# AND paymentType IN ('" & pay & "') AND depositStatus IN ('" & stat & "');", Globals.dbCon)
                Dim gencolread As OleDbDataReader = gencol.ExecuteReader()
                gencolread.Read()
                dtsearch.Load(gencolread)
            End Using

        ElseIf proj = "" And unit <> "" And pay <> "" And stat <> "" Then
            Using gencol As New OleDbCommand("SELECT * FROM collections WHERE transDate BETWEEN #" & frmD & "# AND #" & toD & "# AND unitNum IN ('" & unit & "') AND paymentType IN ('" & pay & "') AND depositStatus IN ('" & stat & "');", Globals.dbCon)
                Dim gencolread As OleDbDataReader = gencol.ExecuteReader()
                gencolread.Read()
                dtsearch.Load(gencolread)
            End Using

        ElseIf proj <> "" And unit = "" And pay <> "" And stat <> "" Then
            Using gencol As New OleDbCommand("SELECT * FROM collections WHERE transDate BETWEEN #" & frmD & "# AND #" & toD & "# AND project IN ('" & proj & "') AND paymentType IN ('" & pay & "') AND depositStatus IN ('" & stat & "');", Globals.dbCon)
                Dim gencolread As OleDbDataReader = gencol.ExecuteReader()
                gencolread.Read()
                dtsearch.Load(gencolread)
            End Using
        ElseIf proj <> "" And unit <> "" And pay = "" And stat <> "" Then
            Using gencol As New OleDbCommand("SELECT * FROM collections WHERE transDate BETWEEN #" & frmD & "# AND #" & toD & "# AND project IN ('" & proj & "') AND unitNum IN ('" & unit & "') AND depositStatus IN ('" & stat & "');", Globals.dbCon)
                Dim gencolread As OleDbDataReader = gencol.ExecuteReader()
                gencolread.Read()
                dtsearch.Load(gencolread)
            End Using

        ElseIf proj <> "" And unit <> "" And pay <> "" And stat = "" Then
            Using gencol As New OleDbCommand("SELECT * FROM collections WHERE transDate BETWEEN #" & frmD & "# AND #" & toD & "# AND project IN ('" & proj & "') AND paymentType IN ('" & pay & "') AND unitNum IN ('" & unit & "');", Globals.dbCon)
                Dim gencolread As OleDbDataReader = gencol.ExecuteReader()
                gencolread.Read()
                dtsearch.Load(gencolread)
            End Using
        End If

        Return dtsearch
    End Function
    Private Sub frmExtract_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        projectlst.Connection = Globals.dbCon
        projectlst.CommandText = "SELECT projectName FROM projects"
        Dim projlst As OleDbDataReader = projectlst.ExecuteReader()
        While projlst.Read
            cboProject.Items.Add(projlst.Item(0))
        End While

        proj = ""
        unit = ""
        frmD = Date.Today
        toD = Date.Today
        pay = ""
        stat = ""


        cboDepstat.Items.Add("PENDING")
        cboDepstat.Items.Add("DEPOSITED")
        cboPayment.Items.Add("CASH")
        cboPayment.Items.Add("CHECK")
        cboPayment.Items.Add("OTHERS")
    End Sub
End Class