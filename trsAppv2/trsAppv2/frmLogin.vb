Imports trsAppv2.trsAppDataSetTableAdapters
Imports trsAppv2.trsAppDataSet
Imports System.Data.OleDb
Imports System.Data
Imports System.IO.FileStream
Public Class frmLogin
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
        Me.Close()
        Globals.dbCon.Close()
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin_Click(sender, e)
        ElseIf e.KeyCode = Keys.Escape Then
            btnCancel_Click(sender, e)
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim lcmd As OleDbCommand = New OleDbCommand("SELECT * FROM users WHERE userName ='" & txtUsername.Text & "'and passWord = '" & txtPassword.Text & "'", Globals.dbCon)
        Globals.loginSuccess = 0

        Do While Globals.loginSuccess = 0
            Dim lread As OleDbDataReader = lcmd.ExecuteReader()
            Dim user, pass As String
            If (lread.Read() = True) Then
                user = lread("userName")
                pass = lread("passWord")
                Globals.loginFullname = lread("fullName")
                Globals.loginUsername = lread("userName")
                Globals.loginUserlevel = lread("userLevel")
                Globals.loginSite = lread("site")
                MsgBox("LOGIN SUCCESSFUL!")
                Globals.loginSuccess = 1
            Else
                MsgBox("INVALID LOGIN CREDENTIALS!")
                Globals.loginSuccess = 0
                lread.Close()
                Exit Sub
            End If

            If Globals.loginSuccess = 1 Then
                Me.Hide()
                Dim curdate As Date = Date.Today
                Dim checkpdc As New OleDbCommand("SELECT COUNT(*) FROM collections WHERE DateValue(checkDate) >'" & curdate & "'AND depositStatus = '" & "PENDING" & "'", Globals.dbCon)
                Dim checkpdcr As OleDbDataReader = checkpdc.ExecuteReader()
                Dim countpdc As Integer
                checkpdcr.Read()
                countpdc = checkpdcr.GetInt32(0)
                If countpdc > 0 Then
                    frmOverdue.Show()
                    Me.Hide()
                Else
                    frmHome.Show()
                    Me.Hide()
                End If

                If System.IO.File.Exists(Globals.logs) = True Then
                    'Dim objWriter As New System.IO.StreamWriter(Globalslogs, False)
                    Dim objWriter As New System.IO.StreamWriter(Globals.logs, True)
                    objWriter.Write(vbNewLine & Globals.logdate & "| " & Globals.loginFullname & "| " & Globals.loginUserlevel & "| " & "LOG-IN ")
                    objWriter.Close()
                Else
                    Dim objWriter As New System.IO.StreamWriter(Globals.logs, False)
                    objWriter.Write(vbNewLine & Globals.logdate & "| " & Globals.loginFullname & "| " & Globals.loginUserlevel & "| " & "LOG-IN ")
                    objWriter.Close()
                End If
            End If
        Loop

    End Sub

    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin_Click(sender, e)
        ElseIf e.KeyCode = Keys.Escape Then
            btnCancel_Click(sender, e)
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dbConinit As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\trsApp.mdb")
        Globals.dbCon = dbConinit
        Globals.dbCon.Open()
    End Sub

    Private Sub frmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        btnCancel_Click(sender, e)
    End Sub
End Class