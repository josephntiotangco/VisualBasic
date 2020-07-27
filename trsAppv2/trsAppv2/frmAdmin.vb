Imports System.Data.OleDb
Imports System.Data
Imports System.Data.ParameterDirection
Imports System.IO.FileStream
Imports trsAppv2.trsAppDataSet
Public Class frmAdmin
    Public userlevel, addbank, addproject, addacct As Integer
    Private Sub btnResetCollections_Click(sender As Object, e As EventArgs) Handles btnResetCollections.Click
        If Globals.loginUserlevel <> 100 Then
            MsgBox("YOU HAVE NO RIGHTS TO RESET COLLECTION DATABASE!", vbCritical, "CRITICAL")
            Exit Sub
        Else
            Dim resetcmd As New OleDbCommand
            With resetcmd
                .Connection = Globals.dbCon
                .CommandType = CommandType.Text
                .CommandText = "DELETE FROM collections"
                .ExecuteNonQuery()
                MsgBox("COLLECTIONS HAS BEEN DELETED!")
            End With
            If System.IO.File.Exists(Globals.logs) = True Then
                'Dim objWriter As New System.IO.StreamWriter(Globalslogs, False)
                Dim objWriter As New System.IO.StreamWriter(Globals.logs, True)
                objWriter.Write(vbNewLine & Globals.logdate & "| " & Globals.loginFullname & "| " & Globals.loginUserlevel & "| " & "RESET COLLECTION DATABASE ")
                objWriter.Close()
            Else
                Dim objWriter As New System.IO.StreamWriter(Globals.logs, False)
                objWriter.Write(vbNewLine & Globals.logdate & "| " & Globals.loginFullname & "| " & Globals.loginUserlevel & "| " & "RESET COLLECTION DATABASE ")
                objWriter.Close()
            End If

        End If
    End Sub

    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cboLevel.Items.Add("ADMIN")
        Me.cboLevel.Items.Add("USER")
        Me.cboLevel.Items.Add("AUDIT")


        Dim gproject As New OleDbCommand
        gproject.Connection = Globals.dbCon
        gproject.CommandText = "SELECT projectName FROM projects"
        Dim projread As OleDbDataReader = gproject.ExecuteReader()
        While projread.Read
            cboSite.Items.Add(projread.Item(0))
        End While

        Dim banks As New OleDbCommand
        banks.Connection = Globals.dbCon
        banks.CommandText = "SELECT bankName FROM banks"
        Dim bankread As OleDbDataReader = banks.ExecuteReader()
        While bankread.Read
            cboBank.Items.Add(bankread.Item(0))
        End While

        Me.txtBankname.Visible = False
        Me.txtProjectname.Visible = False
        Me.txtAcct.Visible = False
        Me.cboBank.Visible = False
    End Sub

    Private Sub chkShow_CheckedChanged(sender As Object, e As EventArgs) Handles chkShow.CheckedChanged
        If Me.chkShow.Checked = True Then
            Me.txtPassword.PasswordChar = ""
            Me.txtRetry.PasswordChar = ""
        Else
            Me.txtPassword.PasswordChar = "*"
            Me.txtRetry.PasswordChar = "*"
        End If
    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        If Me.cboLevel.Text = "ADMIN" Then
            userlevel = 1
        ElseIf Me.cboLevel.Text = "USER" Then
            userlevel = 2
        ElseIf Me.cboLevel.Text = "AUDIT" Then
            userlevel = 3
        End If

        If Me.txtFirstname.Text = "" Or Me.txtLastname.Text = "" Or Me.txtPassword.Text = "" Or Me.txtRetry.Text = "" Or Me.txtUsername.Text = "" Or Me.cboLevel.Text = "" Or Me.cboSite.Text = "" Then
            MsgBox("MISSING DETAILS, BLANK DETAILS NOT ALLOWED!", vbCritical, "CRITICAL")
            Exit Sub
        Else
            If Me.txtPassword.Text <> Me.txtRetry.Text Then
                MsgBox("PASSWORD IS NOT THE SAME, PLEASE INPUT THE SAME PASSWORD!")
                Exit Sub
            Else
                Dim error1 As Integer
            error1 = MsgBox("ARE YOU SURE YOU WANT TO ADD USER?", vbYesNo + vbQuestion, "ADD USER")
                If error1 = vbNo Then
                    MsgBox("ADD USER CANCELLED")
                    Exit Sub
                Else
                    Try
                        Dim addcmd As New OleDbCommand
                        With addcmd
                            .Connection = Globals.dbCon
                            .CommandType = CommandType.Text
                            .CommandText = "INSERT INTO users([userName],[passWord],[fullName],[lastName],[firstName],[userLevel],[site]) VALUES (@uname, @pword, @funame, @lname, @fname, @ulevel, @uproj)"
                            .Parameters.Add("@uname", OleDbType.VarChar).Value = Me.txtUsername.Text
                            .Parameters.Add("@pword", OleDbType.VarChar).Value = Me.txtPassword.Text
                            .Parameters.Add("@funame", OleDbType.VarChar).Value = Me.txtFirstname.Text & " " & Me.txtLastname.Text
                            .Parameters.Add("@lname", OleDbType.VarChar).Value = Me.txtLastname.Text
                            .Parameters.Add("@fname", OleDbType.VarChar).Value = Me.txtFirstname.Text
                            .Parameters.Add("@ulevel", OleDbType.VarChar).Value = userlevel
                            .Parameters.Add("@uproj", OleDbType.VarChar).Value = Me.cboSite.Text
                            .ExecuteNonQuery()

                            MsgBox("USER " & Me.txtUsername.Text & " IS ADDED TO USER TABLE!")
                        End With
                        If System.IO.File.Exists(Globals.logs) = True Then
                            'Dim objWriter As New System.IO.StreamWriter(Globalslogs, False)
                            Dim objWriter As New System.IO.StreamWriter(Globals.logs, True)
                            objWriter.Write(vbNewLine & Globals.logdate & "| " & Globals.loginFullname & "| " & Globals.loginUserlevel & "| " & "ADDED USER :" & Me.txtUsername.Text & " OF " & Me.txtFirstname.Text & " " & Me.txtLastname.Text)
                            objWriter.Close()
                        Else
                            Dim objWriter As New System.IO.StreamWriter(Globals.logs, False)
                            objWriter.Write(vbNewLine & Globals.logdate & "| " & Globals.loginFullname & "| " & Globals.loginUserlevel & "| " & "ADDED USER :" & Me.txtUsername.Text & " OF " & Me.txtFirstname.Text & " " & Me.txtLastname.Text)
                            objWriter.Close()
                        End If

                        Me.txtUsername.Text = ""
                        Me.txtPassword.Text = ""
                        Me.txtRetry.Text = ""
                        Me.txtLastname.Text = ""
                        Me.txtFirstname.Text = ""
                        Me.cboSite.Text = ""
                        Me.cboLevel.Text = ""
                        userlevel = 0
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical)
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If Me.txtUsername.Text = "" Then
            MsgBox("INPUT USERNAME TO BE DELETED!")
            Exit Sub
        Else
            Dim error2 As Integer
            error2 = MsgBox("ARE YOU SURE YOU WANT TO DELETE THIS USER? " & Me.txtUsername.Text, vbYesNo + vbQuestion, "DELETE USER")
            If error2 = vbNo Then
                MsgBox("DELETION CANCELLED!")
                Exit Sub
            Else
                Try
                    Dim deletecmd As New OleDbCommand
                With deletecmd
                    .Connection = Globals.dbCon
                    .CommandType = CommandType.Text
                    .CommandText = "DELETE FROM users WHERE userName = @user"
                    .Parameters.Add("@user", OleDbType.VarChar).Value = Me.txtUsername.Text
                    .ExecuteNonQuery()


                    MsgBox("YOU DELETED USER " & Me.txtUsername.Text)
                End With
                    If System.IO.File.Exists(Globals.logs) = True Then
                        'Dim objWriter As New System.IO.StreamWriter(Globalslogs, False)
                        Dim objWriter As New System.IO.StreamWriter(Globals.logs, True)
                        objWriter.Write(vbNewLine & Globals.logdate & "| " & Globals.loginFullname & "| " & Globals.loginUserlevel & "| " & "DELETED USER :" & Me.txtUsername.Text)
                        objWriter.Close()
                    Else
                        Dim objWriter As New System.IO.StreamWriter(Globals.logs, False)
                        objWriter.Write(vbNewLine & Globals.logdate & "| " & Globals.loginFullname & "| " & Globals.loginUserlevel & "| " & "DELETED USER :" & Me.txtUsername.Text)
                        objWriter.Close()
                    End If
                    Me.txtUsername.Text = ""
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                End Try
            End If
        End If
    End Sub

    Private Sub BACKTOHOMEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BACKTOHOMEToolStripMenuItem.Click
        frmHome.Show()
        Me.Hide()
    End Sub


    Private Sub chkBank_CheckedChanged(sender As Object, e As EventArgs) Handles chkBank.CheckedChanged
        If Me.chkBank.Checked = True Then
            addbank = 1
            addproject = 0
            addacct = 0
            Me.txtBankname.Visible = True
            Me.txtProjectname.Visible = False
            Me.txtAcct.Visible = False
            Me.cboBank.Visible = False
        Else
            addbank = 0
            addproject = 0
            addacct = 0
            Me.txtBankname.Visible = False
            Me.txtProjectname.Visible = False
            Me.txtAcct.Visible = False
            Me.cboBank.Visible = False
        End If
    End Sub



    Private Sub chkProject_CheckedChanged(sender As Object, e As EventArgs) Handles chkProject.CheckedChanged
        If Me.chkProject.Checked = True Then
            addbank = 0
            addproject = 1
            addacct = 0
            Me.txtBankname.Visible = False
            Me.txtProjectname.Visible = True
            Me.txtAcct.Visible = False
            Me.cboBank.Visible = False
        Else
            addbank = 0
            addproject = 0
            addacct = 0
            Me.txtBankname.Visible = False
            Me.txtProjectname.Visible = False
            Me.txtAcct.Visible = False
            Me.cboBank.Visible = False
        End If
    End Sub
    Private Sub chkAcct_CheckedChanged(sender As Object, e As EventArgs) Handles chkAcct.CheckedChanged
        If Me.chkAcct.Checked = True Then
            addbank = 0
            addproject = 0
            addacct = 1
            Me.txtBankname.Visible = False
            Me.txtProjectname.Visible = False
            Me.txtAcct.Visible = True
            Me.cboBank.Visible = True
        Else
            addbank = 0
            addproject = 0
            addacct = 0
            Me.txtBankname.Visible = False
            Me.txtProjectname.Visible = False
            Me.txtAcct.Visible = False
            Me.cboBank.Visible = False
        End If
    End Sub

    Private Sub btnAddprofile_Click(sender As Object, e As EventArgs) Handles btnAddprofile.Click
        If addacct = 0 And addbank = 0 And addproject = 0 Then
            MsgBox("NOTHING TO ADD! TICK A PROFILE TO ADD PROFILE")
            Exit Sub
        Else
            Dim error3 As Integer
            error3 = MsgBox("ARE YOU SURE YOU WANT TO ADD PROFILE?", vbYesNo + vbQuestion, "ADD PROFILE")
            If error3 = vbNo Then
                MsgBox("CANCELLED ADD TO PROFILE")
                Exit Sub
            Else
                If addacct = 1 And Me.txtAcct.Text <> "" Then
                    Try
                        Dim addacctcmd As New OleDbCommand
                        With addacctcmd
                            .Connection = Globals.dbCon
                            .CommandType = CommandType.Text
                            .CommandText = "INSERT INTO bankacct([bankAtext], [bankName], [bankAccount], [createdBy],[createdDate]) VALUES (@atext, @bname, @bacct, @cby, @crdate)"
                            .Parameters.Add("@atext", OleDbType.VarChar).Value = Me.cboBank.Text & ":" & Me.txtAcct.Text
                            .Parameters.Add("@bname", OleDbType.VarChar).Value = Me.cboBank.Text
                            .Parameters.Add("@bacct", OleDbType.VarChar).Value = Me.txtAcct.Text
                            .Parameters.Add("@cby", OleDbType.VarChar).Value = Globals.loginFullname
                            .Parameters.Add("@crdate", OleDbType.Date).Value = Globals.logdate
                            .ExecuteNonQuery()
                            MsgBox("NEW ACCOUNT HAS BEEN ADDED!")
                        End With
                        If System.IO.File.Exists(Globals.logs) = True Then
                            'Dim objWriter As New System.IO.StreamWriter(Globalslogs, False)
                            Dim objWriter As New System.IO.StreamWriter(Globals.logs, True)
                            objWriter.Write(vbNewLine & Globals.logdate & "| " & Globals.loginFullname & "| " & Globals.loginUserlevel & "| " & "ADD NEW ACCOUNT: " & Me.cboBank.Text & ":" & Me.txtAcct.Text)
                            objWriter.Close()
                        Else
                            Dim objWriter As New System.IO.StreamWriter(Globals.logs, False)
                            objWriter.Write(vbNewLine & Globals.logdate & "| " & Globals.loginFullname & "| " & Globals.loginUserlevel & "| " & "ADD NEW ACCOUNT: " & Me.cboBank.Text & ":" & Me.txtAcct.Text)
                            objWriter.Close()
                        End If
                        Me.txtAcct.Text = ""
                        Me.cboBank.Text = ""
                        Me.chkAcct.Checked = False
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical)
                    End Try
                ElseIf addbank = 1 And Me.txtBankname.Text <> "" Then
                    Try
                        Dim addbankcmd As New OleDbCommand
                        With addbankcmd
                            .Connection = Globals.dbCon
                            .CommandType = CommandType.Text
                            .CommandText = "INSERT INTO banks([bankName],[createdBy],[createdDate]) VALUES (@bname, @cby, @crdate)"
                            .Parameters.Add("@bname", OleDbType.VarChar).Value = Me.txtBankname.Text
                            .Parameters.Add("@cby", OleDbType.VarChar).Value = Globals.loginFullname
                            .Parameters.Add("@crdate", OleDbType.Date).Value = Globals.logdate
                            .ExecuteNonQuery()
                            MsgBox("NEW BANK NAME HAS BEEN ADDED!")
                        End With
                        If System.IO.File.Exists(Globals.logs) = True Then
                            'Dim objWriter As New System.IO.StreamWriter(Globalslogs, False)
                            Dim objWriter As New System.IO.StreamWriter(Globals.logs, True)
                            objWriter.Write(vbNewLine & Globals.logdate & "| " & Globals.loginFullname & "| " & Globals.loginUserlevel & "| " & "ADD NEW BANK: " & Me.txtBankname.Text)
                            objWriter.Close()
                        Else
                            Dim objWriter As New System.IO.StreamWriter(Globals.logs, False)
                            objWriter.Write(vbNewLine & Globals.logdate & "| " & Globals.loginFullname & "| " & Globals.loginUserlevel & "| " & "ADD NEW BANK: " & Me.txtBankname.Text)
                            objWriter.Close()
                        End If
                        Me.txtBankname.Text = ""
                        Me.chkBank.Checked = False
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical)
                    End Try
                ElseIf addproject = 1 And Me.txtProjectname.Text <> "" Then
                    Try
                        Dim addprojcmd As New OleDbCommand
                        With addprojcmd
                            .Connection = Globals.dbCon
                            .CommandType = CommandType.Text
                            .CommandText = "INSERT INTO projects([projectName],[createdBy],[createdDate]) VALUES (@pname, @cby, @crdate)"
                            .Parameters.Add("@pname", OleDbType.VarChar).Value = Me.txtProjectname.Text
                            .Parameters.Add("@cby", OleDbType.VarChar).Value = Globals.loginFullname
                            .Parameters.Add("@crdate", OleDbType.Date).Value = Globals.logdate
                            .ExecuteNonQuery()
                            MsgBox("NEW PROJECT HAS BEEN ADDED!")
                        End With
                        If System.IO.File.Exists(Globals.logs) = True Then
                            'Dim objWriter As New System.IO.StreamWriter(Globalslogs, False)
                            Dim objWriter As New System.IO.StreamWriter(Globals.logs, True)
                            objWriter.Write(vbNewLine & Globals.logdate & "| " & Globals.loginFullname & "| " & Globals.loginUserlevel & "| " & "ADD NEW PROJECT: " & Me.txtProjectname.Text)
                            objWriter.Close()
                        Else
                            Dim objWriter As New System.IO.StreamWriter(Globals.logs, False)
                            objWriter.Write(vbNewLine & Globals.logdate & "| " & Globals.loginFullname & "| " & Globals.loginUserlevel & "| " & "ADD NEW PROJECT: " & Me.txtProjectname.Text)
                            objWriter.Close()
                        End If
                        Me.txtProjectname.Text = ""
                        Me.chkProject.Checked = False
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical)
                    End Try
                Else
                    MsgBox("NOTHING TO ADD! TICK A PROFILE TO ADD PROFILE")
                    Exit Sub
                End If
            End If
        End If
    End Sub
    Private Sub btnDeleteProf_Click(sender As Object, e As EventArgs) Handles btnDeleteProf.Click
        If addacct = 0 And addbank = 0 And addproject = 0 Then
            MsgBox("NOTHING TO DELETE! TICK A PROFILE TO DELETE")
            Exit Sub
        Else
            Dim error4 As Integer
            error4 = MsgBox("ARE YOU SURE YOU WANT TO DELETE PROFILE?", vbYesNo + vbQuestion, "ADD PROFILE")
            If error4 = vbNo Then
                MsgBox("CANCELLED ADD TO PROFILE")
                Exit Sub
            Else
                If addacct = 1 And Me.txtAcct.Text <> "" And Me.cboBank.Text <> "" Then
                    Try
                        Dim delacctcmd As New OleDbCommand
                        With delacctcmd
                            .Connection = Globals.dbCon
                            .CommandType = CommandType.Text
                            .CommandText = "DELETE FROM bankacct WHERE [bankName] = @bname AND [bankAccount] = @bacct"
                            .Parameters.Add("@bname", OleDbType.VarChar).Value = Me.cboBank.Text
                            .Parameters.Add("@bacct", OleDbType.VarChar).Value = Me.txtAcct.Text
                            .ExecuteNonQuery()
                            MsgBox("BANK ACCT#" & Me.txtAcct.Text & "HAS BEEN DELETED!")
                        End With
                        If System.IO.File.Exists(Globals.logs) = True Then
                            'Dim objWriter As New System.IO.StreamWriter(Globalslogs, False)
                            Dim objWriter As New System.IO.StreamWriter(Globals.logs, True)
                            objWriter.Write(vbNewLine & Globals.logdate & "| " & Globals.loginFullname & "| " & Globals.loginUserlevel & "| " & "DELETED ACCOUNT: " & Me.cboBank.Text & ":" & Me.txtAcct.Text)
                            objWriter.Close()
                        Else
                            Dim objWriter As New System.IO.StreamWriter(Globals.logs, False)
                            objWriter.Write(vbNewLine & Globals.logdate & "| " & Globals.loginFullname & "| " & Globals.loginUserlevel & "| " & "DELETED ACCOUNT: " & Me.cboBank.Text & ":" & Me.txtAcct.Text)
                            objWriter.Close()
                        End If
                        Me.txtAcct.Text = ""
                        Me.cboBank.Text = ""
                        Me.chkAcct.Checked = False
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical)
                    End Try
                ElseIf addbank = 1 And Me.txtBankname.Text <> "" Then
                    Try
                        Dim delbankcmd As New OleDbCommand
                        With delbankcmd
                            .Connection = Globals.dbCon
                            .CommandType = CommandType.Text
                            .CommandText = "DELETE FROM banks WHERE [bankName] = @bname"
                            .Parameters.Add("@bname", OleDbType.VarChar).Value = Me.txtBankname.Text
                            .ExecuteNonQuery()
                            MsgBox("BANK NAME " & Me.txtBankname.Text & " HAS BEEN DELETED")
                        End With
                        If System.IO.File.Exists(Globals.logs) = True Then
                            'Dim objWriter As New System.IO.StreamWriter(Globalslogs, False)
                            Dim objWriter As New System.IO.StreamWriter(Globals.logs, True)
                            objWriter.Write(vbNewLine & Globals.logdate & "| " & Globals.loginFullname & "| " & Globals.loginUserlevel & "| " & "DELETED BANK: " & Me.txtBankname.Text)
                            objWriter.Close()
                        Else
                            Dim objWriter As New System.IO.StreamWriter(Globals.logs, False)
                            objWriter.Write(vbNewLine & Globals.logdate & "| " & Globals.loginFullname & "| " & Globals.loginUserlevel & "| " & "DELETED BANK: " & Me.txtBankname.Text)
                            objWriter.Close()
                        End If
                        Me.txtBankname.Text = ""
                        Me.chkBank.Checked = False
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical)
                    End Try
                ElseIf addproject = 1 And Me.txtProjectname.Text <> "" Then
                    Try
                        Dim delprojcmd As New OleDbCommand
                        With delprojcmd
                            .Connection = Globals.dbCon
                            .CommandType = CommandType.Text
                            .CommandText = "DELETE FROM projects WHERE [projectName] = @pname"
                            .Parameters.Add("@pname", OleDbType.VarChar).Value = Me.txtProjectname.Text
                            .ExecuteNonQuery()
                            MsgBox("PROJECT " & Me.txtProjectname.Text & " HAS BEEN DELETED!")
                        End With
                        If System.IO.File.Exists(Globals.logs) = True Then
                            'Dim objWriter As New System.IO.StreamWriter(Globalslogs, False)
                            Dim objWriter As New System.IO.StreamWriter(Globals.logs, True)
                            objWriter.Write(vbNewLine & Globals.logdate & "| " & Globals.loginFullname & "| " & Globals.loginUserlevel & "| " & "DELETED PROJECT: " & Me.txtProjectname.Text)
                            objWriter.Close()
                        Else
                            Dim objWriter As New System.IO.StreamWriter(Globals.logs, False)
                            objWriter.Write(vbNewLine & Globals.logdate & "| " & Globals.loginFullname & "| " & Globals.loginUserlevel & "| " & "DELETED PROJECT: " & Me.txtProjectname.Text)
                            objWriter.Close()
                        End If
                        Me.txtProjectname.Text = ""
                        Me.chkProject.Checked = False
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical)
                    End Try
                Else
                    MsgBox("NOTHING TO DELETE! TICK A PROFILE TO ADD PROFILE")
                    Exit Sub
                End If
            End If
        End If
    End Sub

End Class