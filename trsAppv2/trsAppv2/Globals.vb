Imports trsAppv2.trsAppDataSetTableAdapters
Imports trsAppv2.trsAppDataSet
Imports System.Data.OleDb
Imports System.Data
Imports System.IO.FileStream
Public Class Globals
    Public Shared loginFullname, loginUsername, loginSite As String
    Public Shared loginUserlevel, loginSuccess As Integer
    Public Shared dbCon As New OleDbConnection
    Public Shared logdate As Date = Date.Now
    Public Shared logs As String = Application.StartupPath & "\auditlogs.txt"
    Public Shared orName As String, orRef As String, orUnit As String, orProj As String, orPart As String, orPay As String
    Public Shared prName As String, prRef As String, prUnit As String, prProj As String, prPart As String, prPay As String
    Public Shared orAmt, prAmt As Double
End Class
