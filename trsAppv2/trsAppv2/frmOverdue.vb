Imports System.Data.OleDb
Imports System.Data
Imports System.IO.FileStream
Imports trsAppv2.trsAppDataSetTableAdapters
Imports trsAppv2.trsAppDataSet
Public Class frmOverdue
    Public pdcdate As Date

    Private Sub HOMEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HOMEToolStripMenuItem.Click
        Me.Hide()
        frmHome.Show()
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGOUTToolStripMenuItem.Click
        Dim ques As Integer
        ques = MsgBox("ARE YOU SURE YOU WANT TO LOG-OUT?", vbYesNo + vbQuestion, "ARE YOU SURE?")
        If ques = vbNo Then
            Exit Sub
            Me.Show()
        Else
            If System.IO.File.Exists(Globals.logs) = True Then
                'Dim objWriter As New System.IO.StreamWriter(Globalslogs, False)
                Dim objWriter As New System.IO.StreamWriter(Globals.logs, True)
                objWriter.Write(vbNewLine & Globals.logdate & "| " & Globals.loginFullname & "| " & Globals.loginUserlevel & "| " & "LOG-OUT ")
                objWriter.Close()
            Else
                Dim objWriter As New System.IO.StreamWriter(Globals.logs, False)
                objWriter.Write(vbNewLine & Globals.logdate & "| " & Globals.loginFullname & "| " & Globals.loginUserlevel & "| " & "LOG-OUT ")
                objWriter.Close()
            End If


            MsgBox("LOG OUT SUCCESSFUL!")
            Globals.loginFullname = ""
            Globals.loginSite = ""
            Globals.loginUserlevel = 0
            Globals.loginUsername = ""
            Globals.loginSuccess = 0
            Me.Hide()
            frmLogin.Show()
        End If
    End Sub

    Private Sub frmOverdue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblWarning.Text = "WELCOME! MS./MR. " & Globals.loginFullname & " 
KINDLY UPDATE THE FOLLOWING OVERDUE CHECK RECORDS!"
        pdcdate = Date.Today

        overdueDataGridView1.DataSource = GetPDC()
    End Sub

    Private Function GetPDC() As DataTable
    Dim dtpdc As New DataTable
    Using overpdc As New OleDbCommand("Select * From collections WHERE DateValue(checkDate) >'" & pdcdate & "'AND depositStatus = '" & "PENDING" & "'", Globals.dbCon)
            Dim readpdc As OleDbDataReader = overpdc.ExecuteReader()
            dtpdc.Load(readpdc)
        End Using
    Return dtpdc
End Function



    Private Sub linkExport_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkExport.LinkClicked

        'www.vbforums.com/showthread.php?635207-RESOLVED-Exporting-DataGridView-to-CSV
        Dim headers = (From header As DataGridViewColumn In overdueDataGridView1.Columns.Cast(Of DataGridViewColumn)()
                       Select header.HeaderText).ToArray
        Dim drows = From row As DataGridViewRow In overdueDataGridView1.Rows.Cast(Of DataGridViewRow)()
                    Where Not row.IsNewRow
                    Select Array.ConvertAll(row.Cells.Cast(Of DataGridViewCell).ToArray, Function(c) If(c.Value IsNot Nothing, c.Value.ToString, ""))

        Using sw As New IO.StreamWriter("OverduePDCReport.txt")
            sw.WriteLine(String.Join("|", headers))
            For Each r In drows
                sw.WriteLine(String.Join("|", r))
            Next
            MsgBox("CSV FILE GENERATED")
        End Using

        Process.Start("OverduePDCReport.txt")

        If System.IO.File.Exists(Globals.logs) = True Then
            'Dim objWriter As New System.IO.StreamWriter(Globals.logs, False)
            Dim objWriter As New System.IO.StreamWriter(Globals.logs, True)
            objWriter.Write(vbNewLine & Globals.logdate & "| " & Globals.loginFullname & " | " & Globals.loginUserlevel & " | " & "OVERDUE PDC LIST")
            objWriter.Close()
        Else
            Dim objWriter As New System.IO.StreamWriter(Globals.logs, False)
            objWriter.Write(vbNewLine & Globals.logdate & "| " & Globals.loginFullname & " | " & Globals.loginUserlevel & " | " & "OVERDUE PDC LIST")
            objWriter.Close()
        End If
    End Sub

    Private Sub frmOverdue_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        HOMEToolStripMenuItem_Click(sender, e)
    End Sub
End Class