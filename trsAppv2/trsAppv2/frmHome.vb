Imports System.Data.OleDb
Imports System.Data
Imports System.Data.ParameterDirection
Imports System.IO.FileStream
Imports trsAppv2.trsAppDataSetTableAdapters
Imports trsAppv2.trsAppDataSet


Public Class frmHome
    Public Shared hm As frmHome
    Public selectrow As DataGridViewRow
    Public projectlst As New OleDbCommand
    Public tdate, prd, ord As Date
    Public recid, reccount, trxid As Long
    Public transidtxt, orRef, prRef, prnpr, prnor, paycash, paycheck, payothers As String
    Public newpost, uppost, updatetag, newtag, printtag As Integer
    Public outdays As String
    Public hindex As Integer
    Public transamt, watc, watcl, watcd, jf, maint, assc, penal, smart, park, secdep, facil, renta, rent, cars, others As Double

    Private Sub btnDown_Click(sender As Object, e As EventArgs) Handles btnDown.Click
        If Val(Me.lblRec.Text) = colDataGridView.RowCount - 1 Then
            MsgBox("YOU ARE AT THE BUTTOM OF THE LIST")
            Exit Sub
        ElseIf Me.lblRec.Text <> "" Or Val(Me.lblRec.Text) <> colDataGridView.RowCount - 1 Then
            Dim dint As Integer
            dint = Val(Me.lblRec.Text) + 1
            selectrow = colDataGridView.Rows(dint)

            If Me.cbkUpdate.Checked = False And Me.cbkNew.Checked = True Or Me.cbkNew.Checked = False And Me.cbkUpdate.Checked = False Then
                MsgBox("YOU CAN'T SELECT A RECORD IF NOT FOR UPDATING!")
                Exit Sub
            Else
                Me.lblRec.Text = dint.ToString()
                recid = selectrow.Cells(0).Value
                Me.lblTransID.Text = selectrow.Cells(1).Value.ToString
                Me.cboProject.Text = selectrow.Cells(2).Value.ToString
                Me.lblDocDate.Text = selectrow.Cells(3).Value.ToString
                Me.txtUnit.Text = selectrow.Cells(4).Value.ToString
                Me.txtCustomer.Text = selectrow.Cells(5).Value.ToString
                Me.cboCustType.Text = selectrow.Cells(6).Value.ToString
                Me.cboParticular.Text = selectrow.Cells(7).Value.ToString
                Me.cboForm.Text = selectrow.Cells(8).Value.ToString
                Me.txtForm.Text = selectrow.Cells(9).Value.ToString
                Me.txtRemarks.Text = selectrow.Cells(10).Value.ToString
                Me.cboPayment.Text = selectrow.Cells(11).Value.ToString
                If Me.cboPayment.Text = "CHECK" Then
                    Me.txtCheck.Visible = True
                    Me.txtCheck.Enabled = True
                    Me.txtBankBranch.Visible = True
                    Me.txtBankBranch.Enabled = True
                    Me.cboBank.Visible = True
                    Me.cboBank.Enabled = True
                    Me.dpckCheckDate.Visible = True
                    Me.dpckCheckDate.Enabled = True
                    Me.cboNewForm.Visible = True
                    Me.cboNewForm.Enabled = True
                    Me.txtNewForm.Visible = True
                    Me.txtNewForm.Enabled = True
                    Me.dpckForm.Visible = True
                    Me.dpckForm.Enabled = True
                Else
                    Me.txtCheck.Visible = False
                    Me.txtCheck.Enabled = False
                    Me.txtBankBranch.Visible = False
                    Me.txtBankBranch.Enabled = False
                    Me.cboBank.Visible = False
                    Me.cboBank.Enabled = False
                    Me.dpckCheckDate.Visible = False
                    Me.dpckCheckDate.Enabled = False
                    Me.cboNewForm.Visible = False
                    Me.cboNewForm.Enabled = False
                    Me.txtNewForm.Visible = False
                    Me.txtNewForm.Enabled = False
                    Me.dpckForm.Visible = False
                    Me.dpckForm.Enabled = False
                End If


                Me.txtAmount.Text = selectrow.Cells(15).Value
                Me.txtCheck.Text = selectrow.Cells(16).Value.ToString
                Me.dpckCheckDate.Value = selectrow.Cells(17).Value
                Me.cboBank.Text = selectrow.Cells(18).Value.ToString
                Me.txtBankBranch.Text = selectrow.Cells(19).Value.ToString
                Me.lblRecby.Text = selectrow.Cells(20).Value.ToString
                Me.cboDepositStat.Text = selectrow.Cells(23).Value.ToString
                If Me.cboDepositStat.Text = "DEPOSITED" Then
                    Me.dpckDeposit.Visible = True
                    Me.cboBankact.Visible = True
                    Me.txtDepositby.Visible = True
                    Me.txtDepositRef.Visible = True
                    Me.dpckDeposit.Enabled = True
                    Me.cboBankact.Enabled = True
                    Me.txtDepositby.Enabled = True
                    Me.txtDepositRef.Enabled = True
                    Me.dpckDeposit.Value = selectrow.Cells(24).Value
                    Me.txtDepositby.Text = selectrow.Cells(25).Value
                    Me.cboBankact.Text = selectrow.Cells(26).Value.ToString
                    Me.txtDepositRef.Text = selectrow.Cells(27).Value.ToString

                Else
                    Me.dpckDeposit.Visible = False
                    Me.cboBankact.Visible = False
                    Me.txtDepositby.Visible = False
                    Me.txtDepositRef.Visible = False
                    Me.dpckDeposit.Enabled = False
                    Me.cboBankact.Enabled = False
                    Me.txtDepositby.Enabled = False
                    Me.txtDepositRef.Enabled = False
                End If

                If Me.txtForm.Text = "OR" Then
                    Me.lblPrintStat.Text = selectrow.Cells(49).Value.ToString
                Else
                    Me.lblPrintStat.Text = selectrow.Cells(48).Value.ToString
                End If
            End If
        Else
            MsgBox("YOU ARE IN THE BUTTOM OF THE LIST!")
            Exit Sub
        End If
    End Sub

    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click
        If Me.lblRec.Text = 0 Then
            MsgBox("YOU ARE ON TOP OF THE LIST")
            Exit Sub
        ElseIf Me.lblRec.Text <> "" Or Val(Me.lblRec.Text) = 0 Then
            Dim uint As Integer
            uint = Val(Me.lblRec.Text) - 1
            selectrow = colDataGridView.Rows(uint)

            If Me.cbkUpdate.Checked = False And Me.cbkNew.Checked = True Or Me.cbkNew.Checked = False And Me.cbkUpdate.Checked = False Then
                MsgBox("YOU CAN'T SELECT A RECORD IF NOT FOR UPDATING!")
                Exit Sub
            Else
                Me.lblRec.Text = uint.ToString()
                recid = selectrow.Cells(0).Value
                Me.lblTransID.Text = selectrow.Cells(1).Value.ToString
                Me.cboProject.Text = selectrow.Cells(2).Value.ToString
                Me.lblDocDate.Text = selectrow.Cells(3).Value.ToString
                Me.txtUnit.Text = selectrow.Cells(4).Value.ToString
                Me.txtCustomer.Text = selectrow.Cells(5).Value.ToString
                Me.cboCustType.Text = selectrow.Cells(6).Value.ToString
                Me.cboParticular.Text = selectrow.Cells(7).Value.ToString
                Me.cboForm.Text = selectrow.Cells(8).Value.ToString
                Me.txtForm.Text = selectrow.Cells(9).Value.ToString
                Me.txtRemarks.Text = selectrow.Cells(10).Value.ToString
                Me.cboPayment.Text = selectrow.Cells(11).Value.ToString
                If Me.cboPayment.Text = "CHECK" Then
                    Me.txtCheck.Visible = True
                    Me.txtCheck.Enabled = True
                    Me.txtBankBranch.Visible = True
                    Me.txtBankBranch.Enabled = True
                    Me.cboBank.Visible = True
                    Me.cboBank.Enabled = True
                    Me.dpckCheckDate.Visible = True
                    Me.dpckCheckDate.Enabled = True
                    Me.cboNewForm.Visible = True
                    Me.cboNewForm.Enabled = True
                    Me.txtNewForm.Visible = True
                    Me.txtNewForm.Enabled = True
                    Me.dpckForm.Visible = True
                    Me.dpckForm.Enabled = True
                Else
                    Me.txtCheck.Visible = False
                    Me.txtCheck.Enabled = False
                    Me.txtBankBranch.Visible = False
                    Me.txtBankBranch.Enabled = False
                    Me.cboBank.Visible = False
                    Me.cboBank.Enabled = False
                    Me.dpckCheckDate.Visible = False
                    Me.dpckCheckDate.Enabled = False
                    Me.cboNewForm.Visible = False
                    Me.cboNewForm.Enabled = False
                    Me.txtNewForm.Visible = False
                    Me.txtNewForm.Enabled = False
                    Me.dpckForm.Visible = False
                    Me.dpckForm.Enabled = False
                End If


                Me.txtAmount.Text = selectrow.Cells(15).Value
                Me.txtCheck.Text = selectrow.Cells(16).Value.ToString
                Me.dpckCheckDate.Value = selectrow.Cells(17).Value
                Me.cboBank.Text = selectrow.Cells(18).Value.ToString
                Me.txtBankBranch.Text = selectrow.Cells(19).Value.ToString
                Me.lblRecby.Text = selectrow.Cells(20).Value.ToString
                Me.cboDepositStat.Text = selectrow.Cells(23).Value.ToString
                If Me.cboDepositStat.Text = "DEPOSITED" Then
                    Me.dpckDeposit.Visible = True
                    Me.cboBankact.Visible = True
                    Me.txtDepositby.Visible = True
                    Me.txtDepositRef.Visible = True
                    Me.dpckDeposit.Enabled = True
                    Me.cboBankact.Enabled = True
                    Me.txtDepositby.Enabled = True
                    Me.txtDepositRef.Enabled = True
                    Me.dpckDeposit.Value = selectrow.Cells(24).Value
                    Me.txtDepositby.Text = selectrow.Cells(25).Value
                    Me.cboBankact.Text = selectrow.Cells(26).Value.ToString
                    Me.txtDepositRef.Text = selectrow.Cells(27).Value.ToString

                Else
                    Me.dpckDeposit.Visible = False
                    Me.cboBankact.Visible = False
                    Me.txtDepositby.Visible = False
                    Me.txtDepositRef.Visible = False
                    Me.dpckDeposit.Enabled = False
                    Me.cboBankact.Enabled = False
                    Me.txtDepositby.Enabled = False
                    Me.txtDepositRef.Enabled = False
                End If

                If Me.txtForm.Text = "OR" Then
                    Me.lblPrintStat.Text = selectrow.Cells(49).Value.ToString
                Else
                    Me.lblPrintStat.Text = selectrow.Cells(48).Value.ToString
                End If
            End If
        Else
            MsgBox("YOU ARE ON TOP OF THE LIST!")
            Exit Sub
        End If

    End Sub

    Private Sub colDataGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles colDataGridView.KeyDown
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Back Or e.KeyCode = Keys.Shift + Keys.Enter Then
            btnUp_Click(sender, e)
        ElseIf e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            btnDown_Click(sender, e)
        End If
    End Sub

    Private Sub frmHome_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        LogOutToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub MAINTENANCEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MAINTENANCEToolStripMenuItem.Click
        If Globals.loginUserlevel <> 100 Then
            MsgBox("YOU HAVE NO RIGHTS TO ACCESS THIS MODULE! CALL ADMINISTRATOR", vbCritical, "CRITICAL")
            Exit Sub
        Else
            frmAdmin.Show()
        End If
    End Sub

    Private Sub PRINTPREVIEWToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PRINTPREVIEWToolStripMenuItem.Click
        If printtag = 0 Then
            MsgBox("THIS ENTRY IS NOT YET ADDED TO ANY FORM! PLEASE ADD TO OR / PR FIRST!")
        Else
            frmFormPrinting.Show()
        End If
    End Sub

    Private Sub OVERDUEPDCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OVERDUEPDCToolStripMenuItem.Click
        frmOverdue.Show()
    End Sub

    Private Sub DAILYCOLLECTIONREPORTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DAILYCOLLECTIONREPORTToolStripMenuItem.Click
        frmDaily.Show()
    End Sub

    Private Sub DETAILEDREPORTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DETAILEDREPORTToolStripMenuItem.Click
        frmExtract.Show()
    End Sub

    Private Sub cbkNew_CheckedChanged(sender As Object, e As EventArgs) Handles cbkNew.CheckedChanged
        If Me.cbkNew.Checked = True Then
            newtag = 1
            updatetag = 0
            Me.cbkUpdate.Checked = False
            Me.dpckDeposit.Visible = False
            Me.dpckDeposit.Enabled = False
            Me.dpckForm.Visible = False
            Me.dpckForm.Enabled = False
            Me.txtDepositby.Visible = False
            Me.txtDepositby.Enabled = False
            Me.cboBankact.Visible = False
            Me.cboBankact.Enabled = False
            Me.txtDepositRef.Visible = False
            Me.txtDepositRef.Enabled = False
            Me.cboNewForm.Visible = False
            Me.cboNewForm.Enabled = False
            Me.txtNewForm.Visible = False
            Me.txtNewForm.Enabled = False
            Me.lblTransID.Text = ""
            Me.cboProject.Text = ""
            Me.lblDocDate.Text = tdate
            Me.txtUnit.Text = ""
            Me.txtCustomer.Text = ""
            Me.cboCustType.Text = ""
            Me.cboParticular.Text = ""
            Me.cboForm.Text = ""
            Me.txtForm.Text = ""
            Me.txtRemarks.Text = ""
            Me.cboPayment.Text = ""
            Me.txtAmount.Text = 0.00
            Me.txtCheck.Text = ""
            Me.dpckCheckDate.Value = Today
            Me.cboBank.Text = ""
            Me.txtBankBranch.Text = ""
            Me.lblRecby.Text = ""
            Me.cboDepositStat.Text = "PENDING"
            Me.lblPrintStat.Text = ""
        Else
            Me.cbkNew.Checked = False
            Me.cbkUpdate.Checked = True
            newtag = 0
            updatetag = 1
        End If
    End Sub

    Private Sub cbkUpdate_CheckedChanged(sender As Object, e As EventArgs) Handles cbkUpdate.CheckedChanged
        If Me.cbkUpdate.Checked = True Then
            updatetag = 1
            newtag = 0
            Me.cbkNew.Checked = False
            Me.dpckDeposit.Visible = True
            Me.dpckDeposit.Enabled = True
            Me.dpckForm.Visible = True
            Me.dpckForm.Enabled = True
            Me.txtDepositby.Visible = True
            Me.txtDepositby.Enabled = True
            Me.cboBankact.Visible = True
            Me.cboBankact.Enabled = True
            Me.txtDepositRef.Visible = True
            Me.txtDepositRef.Enabled = True
            Me.cboNewForm.Visible = True
            Me.cboNewForm.Enabled = True
            Me.txtNewForm.Visible = True
            Me.txtNewForm.Enabled = True
            Me.lblTransID.Text = ""
            Me.cboProject.Text = ""
            Me.lblDocDate.Text = tdate
            Me.cboDepositStat.Items.Add("PENDING")
            Me.cboDepositStat.Items.Add("DEPOSITED")
            Me.txtUnit.Text = ""
            Me.txtCustomer.Text = ""
            Me.cboCustType.Text = ""
            Me.cboParticular.Text = ""
            Me.cboForm.Text = ""
            Me.txtForm.Text = ""
            Me.txtRemarks.Text = ""
            Me.cboPayment.Text = ""
            Me.txtAmount.Text = 0.00
            Me.txtCheck.Text = ""
            Me.dpckCheckDate.Value = Today
            Me.cboBank.Text = ""
            Me.txtBankBranch.Text = ""
            Me.lblRecby.Text = ""
            Me.lblPrintStat.Text = ""
            Me.colDataGridView.DataSource = GetCollectionList()
        Else
            Me.cbkUpdate.Checked = False
            Me.cbkNew.Checked = True
            newtag = 1
            updatetag = 0
        End If
    End Sub

    Private Sub colDataGridView1_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles colDataGridView.RowHeaderMouseClick

        hindex = e.RowIndex
        selectrow = colDataGridView.Rows(hindex)

        If Me.cbkUpdate.Checked = False And Me.cbkNew.Checked = True Or Me.cbkNew.Checked = False And Me.cbkUpdate.Checked = False Then
            MsgBox("YOU CAN'T SELECT A RECORD IF NOT FOR UPDATING!")
            Exit Sub
        Else
            Me.lblRec.Text = hindex.ToString()
            recid = selectrow.Cells(0).Value
            Me.lblTransID.Text = selectrow.Cells(1).Value.ToString
            Me.cboProject.Text = selectrow.Cells(2).Value.ToString
            Me.lblDocDate.Text = selectrow.Cells(3).Value.ToString
            Me.txtUnit.Text = selectrow.Cells(4).Value.ToString
            Me.txtCustomer.Text = selectrow.Cells(5).Value.ToString
            Me.cboCustType.Text = selectrow.Cells(6).Value.ToString
            Me.cboParticular.Text = selectrow.Cells(7).Value.ToString
            Me.cboForm.Text = selectrow.Cells(8).Value.ToString
            Me.txtForm.Text = selectrow.Cells(9).Value.ToString
            Me.txtRemarks.Text = selectrow.Cells(10).Value.ToString
            Me.cboPayment.Text = selectrow.Cells(11).Value.ToString
            If Me.cboPayment.Text = "CHECK" Then
                Me.txtCheck.Visible = True
                Me.txtCheck.Enabled = True
                Me.txtBankBranch.Visible = True
                Me.txtBankBranch.Enabled = True
                Me.cboBank.Visible = True
                Me.cboBank.Enabled = True
                Me.dpckCheckDate.Visible = True
                Me.dpckCheckDate.Enabled = True
                Me.cboNewForm.Visible = True
                Me.cboNewForm.Enabled = True
                Me.txtNewForm.Visible = True
                Me.txtNewForm.Enabled = True
                Me.dpckForm.Visible = True
                Me.dpckForm.Enabled = True
            Else
                Me.txtCheck.Visible = False
                Me.txtCheck.Enabled = False
                Me.txtBankBranch.Visible = False
                Me.txtBankBranch.Enabled = False
                Me.cboBank.Visible = False
                Me.cboBank.Enabled = False
                Me.dpckCheckDate.Visible = False
                Me.dpckCheckDate.Enabled = False
                Me.cboNewForm.Visible = False
                Me.cboNewForm.Enabled = False
                Me.txtNewForm.Visible = False
                Me.txtNewForm.Enabled = False
                Me.dpckForm.Visible = False
                Me.dpckForm.Enabled = False
            End If


            Me.txtAmount.Text = selectrow.Cells(15).Value
            Me.txtCheck.Text = selectrow.Cells(16).Value.ToString
            Me.dpckCheckDate.Value = selectrow.Cells(17).Value
            Me.cboBank.Text = selectrow.Cells(18).Value.ToString
            Me.txtBankBranch.Text = selectrow.Cells(19).Value.ToString
            Me.lblRecby.Text = selectrow.Cells(20).Value.ToString
            Me.cboDepositStat.Text = selectrow.Cells(23).Value.ToString
            If Me.cboDepositStat.Text = "DEPOSITED" Then
                Me.dpckDeposit.Visible = True
                Me.cboBankact.Visible = True
                Me.txtDepositby.Visible = True
                Me.txtDepositRef.Visible = True
                Me.dpckDeposit.Enabled = True
                Me.cboBankact.Enabled = True
                Me.txtDepositby.Enabled = True
                Me.txtDepositRef.Enabled = True
                Me.dpckDeposit.Value = selectrow.Cells(24).Value
                Me.txtDepositby.Text = selectrow.Cells(25).Value
                Me.cboBankact.Text = selectrow.Cells(26).Value.ToString
                Me.txtDepositRef.Text = selectrow.Cells(27).Value.ToString

            Else
                Me.dpckDeposit.Visible = False
                Me.cboBankact.Visible = False
                Me.txtDepositby.Visible = False
                Me.txtDepositRef.Visible = False
                Me.dpckDeposit.Enabled = False
                Me.cboBankact.Enabled = False
                Me.txtDepositby.Enabled = False
                Me.txtDepositRef.Enabled = False
            End If

            If Me.txtForm.Text = "OR" Then
                Me.lblPrintStat.Text = selectrow.Cells(49).Value.ToString
            Else
                Me.lblPrintStat.Text = selectrow.Cells(48).Value.ToString
            End If
        End If



    End Sub

    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hm = Me
        tdate = Date.Today
        newpost = 0
        uppost = 0
        Me.lblOrAmt.Text = Globals.orAmt
        Me.lblPrAmt.Text = Globals.prAmt
        Me.lblDocDate.Text = tdate
        Me.cbkNew.Checked = True
        Me.dpckDeposit.Visible = False
        Me.dpckDeposit.Enabled = False
        Me.dpckForm.Visible = False
        Me.dpckForm.Enabled = False
        Me.txtDepositby.Visible = False
        Me.txtDepositby.Enabled = False
        Me.cboBankact.Visible = False
        Me.cboBankact.Enabled = False
        Me.txtDepositRef.Visible = False
        Me.txtDepositRef.Enabled = False
        Me.cboNewForm.Visible = False
        Me.cboNewForm.Enabled = False
        Me.txtNewForm.Visible = False
        Me.txtNewForm.Enabled = False
        Me.txtCheck.Enabled = False
        Me.txtCheck.Visible = False
        Me.dpckCheckDate.Enabled = False
        Me.dpckCheckDate.Visible = False
        Me.txtBankBranch.Enabled = False
        Me.txtBankBranch.Visible = False
        Me.cboBank.Enabled = False
        Me.cboBank.Visible = False
        Me.cboDepositStat.Text = "PENDING"
        Me.txtAmount.Text = 0.00
        Me.cboCustType.Items.Add("TENANT")
        Me.cboCustType.Items.Add("OWNER")
        Me.cboCustType.Items.Add("RAMP")
        Me.cboPayment.Items.Add("CASH")
        Me.cboPayment.Items.Add("CHECK")
        Me.cboPayment.Items.Add("OTHERS")
        Me.cboForm.Items.Add("OR")
        Me.cboForm.Items.Add("PR")
        Me.colDataGridView.DataSource = GetCollectionList()

        Dim partics As New OleDbCommand
        partics.Connection = Globals.dbCon
        partics.CommandText = "SELECT partName FROM particulars"
        Dim partread As OleDbDataReader = partics.ExecuteReader()
        While partread.Read
            cboParticular.Items.Add(partread.Item(0))
        End While

        Dim gbank As New OleDbCommand
        gbank.Connection = Globals.dbCon
        gbank.CommandText = "SELECT bankName FROM banks"
        Dim bankread As OleDbDataReader = gbank.ExecuteReader()
        While bankread.Read
            Me.cboBank.Items.Add(bankread.Item(0))
        End While

        Dim gproject As New OleDbCommand
        gproject.Connection = Globals.dbCon
        gproject.CommandText = "SELECT projectName FROM projects"
        Dim projread As OleDbDataReader = gproject.ExecuteReader()
        While projread.Read
            Me.cboProject.Items.Add(projread.Item(0))
        End While

        Dim bacct As New OleDbCommand
        bacct.Connection = Globals.dbCon
        bacct.CommandText = "SELECT bankAtext FROM bankacct"
        Dim bacctread As OleDbDataReader = bacct.ExecuteReader()
        While bacctread.Read
            Me.cboBankact.Items.Add(bacctread.Item(0))
        End While
    End Sub
    Private Function GetCollectionList() As DataTable
        Dim dtCol As New DataTable
        Using colcmd As New OleDbCommand("SELECT * FROM collections", Globals.dbCon)
            Dim colread As OleDbDataReader = colcmd.ExecuteReader()
            dtCol.Load(colread)
            reccount = dtCol.Rows.Count
        End Using
        Return dtCol
    End Function
    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
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
            Globals.loginSuccess = 0
            Globals.loginUsername = ""
            Me.Hide()
            frmLogin.Show()
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Me.cboForm.Text = "OR" Then
            MsgBox("FORM SELECTED IS OR YOU CANNOT USE THIS FUNCTION")
            Exit Sub
        Else
            If Globals.prAmt > 0 Then
                If Globals.prName <> Me.txtCustomer.Text Then
                    MsgBox("THIS PAYMENT IS NOT FOR " & Globals.prName)
                    Exit Sub
                Else
                    Globals.prAmt = Globals.prAmt + Val(Me.txtAmount.Text)
                    Globals.prRef = Globals.prRef & "," & Me.cboBank.Text & ":" & Me.txtBankBranch.Text & ":" & Me.txtCheck.Text & ":" & Me.dpckCheckDate.Value
                    MsgBox("PR CONTENTS : AMT:" & Globals.prAmt & " CUSTOMER NAME:" & Globals.prName & " PARTS:" & Globals.prPart & " REFERENCE:" & Globals.prRef)
                    btnSave_Click(sender, e)
                End If
            Else
                Globals.prAmt = Val(Me.txtAmount.Text)
                Globals.prName = Me.txtCustomer.Text
                Globals.prPart = Me.cboParticular.Text & ":" & Me.txtRemarks.Text
                Globals.prPay = Me.cboPayment.Text
                Globals.prProj = Me.cboProject.Text
                Globals.prUnit = Me.txtUnit.Text
                Globals.prRef = Me.cboBank.Text & ":" & Me.txtBankBranch.Text & ":" & Me.txtCheck.Text & ":" & Me.dpckCheckDate.Value
                MsgBox("PR CONTENTS : AMT:" & Globals.prAmt & " CUSTOMER NAME:" & Globals.prName & " PARTS:" & Globals.prPart & " REFERENCE:" & Globals.prRef)
                btnSave_Click(sender, e)
            End If
            printtag = 1
        End If

    End Sub
    Private Sub btnAddOr_Click(sender As Object, e As EventArgs) Handles btnAddOr.Click
        If Me.cboForm.Text = "PR" Then
            MsgBox("FORM SELECTED IS PR YOU CANNOT USE THIS FUNCTION")
            Exit Sub
        Else
            If Globals.orAmt > 0 Then
                If Globals.orName <> Me.txtCustomer.Text Then
                    MsgBox("THIS PAYMENT IS NOT FOR " & Globals.orName)
                    Exit Sub
                Else
                    Globals.orAmt = Globals.orAmt + Val(Me.txtAmount.Text)
                    Globals.orRef = Globals.orRef
                    MsgBox("OR CONTENTS : AMT:" & Globals.orAmt & " CUSTOMER NAME:" & Globals.orName & " PARTS:" & Globals.orPart & " REFERENCE:" & Globals.orRef)
                    btnSave_Click(sender, e)
                End If
            Else
                Globals.orAmt = Val(Me.txtAmount.Text)
                Globals.orName = Me.txtCustomer.Text
                Globals.orPart = Me.cboParticular.Text & ":" & Me.txtRemarks.Text
                Globals.orPay = Me.cboPayment.Text
                Globals.orProj = Me.cboProject.Text
                Globals.orUnit = Me.txtUnit.Text
                Globals.orRef = Me.txtForm.Text
                MsgBox("OR CONTENTS : AMT:" & Globals.orAmt & " CUSTOMER NAME:" & Globals.orName & " PARTS:" & Globals.orPart & " REFERENCE:" & Globals.orRef)
                btnSave_Click(sender, e)
            End If
            printtag = 1
        End If
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim checkd, depdate, formdate As Date

        If Globals.loginUserlevel = 3 Then
            MsgBox("YOU ARE NOT ALLOWED TO MAKE ENTRIES TO THE DATABASE!", vbOK + vbCritical, "NOT AUTHORIZED")
            Exit Sub
        Else
            If Val(Me.txtAmount.Text) = 0 Or Me.txtCustomer.Text = "" Or Me.txtUnit.Text = "" Or Me.cboCustType.Text = "" Or Me.txtRemarks.Text = "" Or Me.cboPayment.Text = "" Or Me.cboParticular.Text = "" Or Me.cboProject.Text = "" Then
                MsgBox("THERE ARE MISSING DETAILS!")
                Exit Sub
            Else
                Dim ques As Integer
                ques = MsgBox("ARE YOU SURE YOU WANT TO SAVE THIS COLLECTION?", vbYesNo + vbQuestion, "ARE YOU SURE?")
                If ques = vbNo Then
                    MsgBox("POSTING CANCELLED")
                    Exit Sub
                Else
                    transamt = Me.txtAmount.Text
                    If Me.dpckCheckDate.Enabled = False Then
                        Me.dpckCheckDate.Value = "01/01/1900"
                        checkd = Me.dpckCheckDate.Value
                    Else
                        checkd = Me.dpckCheckDate.Value
                    End If
                    If Me.dpckDeposit.Enabled = False Then
                        Me.dpckDeposit.Value = "01/01/1900"
                        depdate = Me.dpckDeposit.Value
                    Else
                        depdate = Me.dpckDeposit.Value
                    End If
                    If Me.dpckForm.Enabled = False Then
                        Me.dpckForm.Value = "01/01/1900"
                        formdate = Me.dpckForm.Value
                    Else
                        formdate = Me.dpckForm.Value
                    End If

                    outdays = (depdate - checkd).TotalDays.ToString()

                    If Me.cboParticular.Text = "WATER CONSUMPTION" Then
                        watc = transamt
                        watcl = 0
                        watcd = 0
                        jf = 0
                        maint = 0
                        assc = 0
                        penal = 0
                        smart = 0
                        park = 0
                        secdep = 0
                        facil = 0
                        renta = 0
                        rent = 0
                        cars = 0
                        others = 0
                    ElseIf Me.cboParticular.Text = "WATER CARD LOAD" Then
                        watc = 0
                        watcl = transamt
                        watcd = 0
                        jf = 0
                        maint = 0
                        assc = 0
                        penal = 0
                        smart = 0
                        park = 0
                        secdep = 0
                        facil = 0
                        renta = 0
                        rent = 0
                        cars = 0
                        others = 0
                    ElseIf Me.cboParticular.Text = "WATER CARD" Then
                        watc = 0
                        watcl = 0
                        watcd = transamt
                        jf = 0
                        maint = 0
                        assc = 0
                        penal = 0
                        smart = 0
                        park = 0
                        secdep = 0
                        facil = 0
                        renta = 0
                        rent = 0
                        cars = 0
                        others = 0
                    ElseIf Me.cboParticular.Text = "JOINING FEE" Then
                        watc = 0
                        watcl = 0
                        watcd = 0
                        jf = transamt
                        maint = 0
                        assc = 0
                        penal = 0
                        smart = 0
                        park = 0
                        secdep = 0
                        facil = 0
                        renta = 0
                        rent = 0
                        cars = 0
                        others = 0
                    ElseIf Me.cboParticular.Text = "MAINTENANCE" Then
                        watc = 0
                        watcl = 0
                        watcd = 0
                        jf = 0
                        maint = transamt
                        assc = 0
                        penal = 0
                        smart = 0
                        park = 0
                        secdep = 0
                        facil = 0
                        renta = 0
                        rent = 0
                        cars = 0
                        others = 0
                    ElseIf Me.cboParticular.Text = "ASSOCIATION DUES" Then
                        watc = 0
                        watcl = 0
                        watcd = 0
                        jf = 0
                        maint = 0
                        assc = transamt
                        penal = 0
                        smart = 0
                        park = 0
                        secdep = 0
                        facil = 0
                        renta = 0
                        rent = 0
                        cars = 0
                        others = 0
                    ElseIf Me.cboParticular.Text = "PENALTY" Then
                        watc = 0
                        watcl = 0
                        watcd = 0
                        jf = 0
                        maint = 0
                        assc = 0
                        penal = transamt
                        smart = 0
                        park = 0
                        secdep = 0
                        facil = 0
                        renta = 0
                        rent = 0
                        cars = 0
                        others = 0
                    ElseIf Me.cboParticular.Text = "SMART CARD ACCESS" Then
                        watc = 0
                        watcl = 0
                        watcd = 0
                        jf = 0
                        maint = 0
                        assc = 0
                        penal = 0
                        smart = transamt
                        park = 0
                        secdep = 0
                        facil = 0
                        renta = 0
                        rent = 0
                        cars = 0
                        others = 0
                    ElseIf Me.cboParticular.Text = "PARKING" Then
                        watc = 0
                        watcl = 0
                        watcd = 0
                        jf = 0
                        maint = 0
                        assc = 0
                        penal = 0
                        smart = 0
                        park = transamt
                        secdep = 0
                        facil = 0
                        renta = 0
                        rent = 0
                        cars = 0
                        others = 0
                    ElseIf Me.cboParticular.Text = "CONSTRUCTION BOND / Security DEPOSIT" Then
                        watc = 0
                        watcl = 0
                        watcd = 0
                        jf = 0
                        maint = 0
                        assc = 0
                        penal = 0
                        smart = 0
                        park = 0
                        secdep = transamt
                        facil = 0
                        renta = 0
                        rent = 0
                        cars = 0
                        others = 0
                    ElseIf Me.cboParticular.Text = "SWIMMING POOL / GYM / BASKETBALL" Then
                        watc = 0
                        watcl = 0
                        watcd = 0
                        jf = 0
                        maint = 0
                        assc = transamt
                        penal = 0
                        smart = 0
                        park = 0
                        secdep = 0
                        facil = 0
                        renta = 0
                        rent = 0
                        cars = 0
                        others = 0
                    ElseIf Me.cboParticular.Text = "RENTAL For AMENITY AREA" Then
                        watc = 0
                        watcl = 0
                        watcd = 0
                        jf = 0
                        maint = 0
                        assc = 0
                        penal = 0
                        smart = 0
                        park = 0
                        secdep = 0
                        facil = 0
                        renta = transamt
                        rent = 0
                        cars = 0
                        others = 0
                    ElseIf Me.cboParticular.Text = "RENTAL" Then
                        watc = 0
                        watcl = 0
                        watcd = 0
                        jf = 0
                        maint = 0
                        assc = 0
                        penal = 0
                        smart = 0
                        park = 0
                        secdep = 0
                        facil = 0
                        renta = 0
                        rent = transamt
                        cars = 0
                        others = 0
                    ElseIf Me.cboParticular.Text = "CAR STICKER" Then
                        watc = 0
                        watcl = 0
                        watcd = 0
                        jf = 0
                        maint = 0
                        assc = 0
                        penal = 0
                        smart = 0
                        park = 0
                        secdep = 0
                        facil = 0
                        renta = 0
                        rent = 0
                        cars = transamt
                        others = 0
                    ElseIf Me.cboParticular.Text = "OTHERS" Then
                        watc = 0
                        watcl = 0
                        watcd = 0
                        jf = 0
                        maint = 0
                        assc = 0
                        penal = 0
                        smart = 0
                        park = 0
                        secdep = 0
                        facil = 0
                        renta = 0
                        rent = 0
                        cars = 0
                        others = transamt
                    End If
                    'command declaration
                    Dim newcolcmd As New OleDbCommand 'NEW COLLECTION
                    Dim upcolcmd As New OleDbCommand 'UPDATE COLLECTION

                    If Me.cboPayment.Text = "CHECK" Then
                        paycheck = "CHK#" & Me.txtCheck.Text
                        paycash = ""
                        payothers = ""
                    ElseIf Me.cboPayment.Text = "CASH" Then
                        paycheck = ""
                        paycash = "CASH"
                        payothers = ""
                    Else
                        paycheck = ""
                        paycash = ""
                        payothers = "OTHER PAYMENT"
                    End If

                    If newtag = 1 Then
                        Try
                            If Me.cboForm.Text = "OR" Then
                                prRef = ""
                                ord = tdate
                                prd = Nothing
                                prnor = "PRINTED:" & tdate
                                prnpr = ""
                                orRef = Me.cboForm.Text & ":" & Me.txtForm.Text
                            Else
                                prRef = Me.cboForm.Text & ":" & Me.txtForm.Text
                                orRef = ""
                                prd = tdate
                                ord = Nothing
                                prnor = ""
                                prnpr = "PRINTED:" & tdate
                            End If

                            With newcolcmd
                                .Connection = Globals.dbCon
                                .CommandType = CommandType.Text
                                .CommandText = "INSERT INTO collections([transDate],[transID],[project],[unitNum],[custName],[custType],[particulars],[formType],[formRef],[remarks],[paymentType],[paymentCash],[paymentCheck],[paymentOthers],[transAmt],[checkNum],[checkDate],[bank],[branch],[receivedBy],[updatedBy],[updatedDate],[depositStatus],[waterConsumption],[waterCardload],[waterCard],[joiningFee],[maintenance],[associationDues],[penalty],[smartCardaccess],[parking],[constructionSecdep],[swimmingPoolGymbasketball],[rentalAmenity],[rental],[carSticker],[others],[prRef],[prDate],[orRef],[orDate],[isPr],[isOr]) VALUES (@tdate,@tid,@proj,@unum,@cname,@cutype,@parts,@ftype,@fref,@remark,@pay,@payc, @payck, @payot, @tamt,@cknum,@ckdate,@bank,@branch,@recby,@upby,@update,@depstat,@watc,@watcl,@watcd,@jf,@maint,@assc,@penal,@smart,@park,@secdep,@facil,@renta,@rent,@cars,@others,@prf,@prd,@orf,@ord,@ispr,@isor)"

                                .Parameters.Add("@tdate", OleDbType.Date).Value = tdate
                                .Parameters.Add("@tid", OleDbType.VarChar).Value = transidtxt
                                .Parameters.Add("@proj", OleDbType.VarChar).Value = Me.cboProject.Text
                                .Parameters.Add("@unum", OleDbType.VarChar).Value = Me.txtUnit.Text
                                .Parameters.Add("@cname", OleDbType.VarChar).Value = Me.txtCustomer.Text
                                .Parameters.Add("@cutype", OleDbType.VarChar).Value = Me.cboCustType.Text
                                .Parameters.Add("@parts", OleDbType.VarChar).Value = Me.cboParticular.Text
                                .Parameters.Add("@ftype", OleDbType.VarChar).Value = Me.cboForm.Text
                                .Parameters.Add("@fref", OleDbType.VarChar).Value = Me.txtForm.Text
                                .Parameters.Add("@remark", OleDbType.VarChar).Value = UCase(Me.cboParticular.Text & ":" & Me.txtRemarks.Text)
                                .Parameters.Add("@pay", OleDbType.VarChar).Value = Me.cboPayment.Text
                                .Parameters.Add("@payc", OleDbType.VarChar).Value = paycash
                                .Parameters.Add("@payck", OleDbType.VarChar).Value = paycheck
                                .Parameters.Add("@payot", OleDbType.VarChar).Value = payothers
                                .Parameters.Add("@tamt", OleDbType.Double).Value = transamt
                                .Parameters.Add("@cknum", OleDbType.VarChar).Value = Me.txtCheck.Text
                                .Parameters.Add("@ckdate", OleDbType.Date).Value = checkd
                                .Parameters.Add("@bank", OleDbType.VarChar).Value = Me.cboBank.Text
                                .Parameters.Add("@branch", OleDbType.VarChar).Value = UCase(Me.txtBankBranch.Text)
                                .Parameters.Add("@recby", OleDbType.VarChar).Value = Me.lblRecby.Text
                                .Parameters.Add("@upby", OleDbType.VarChar).Value = UCase(Me.lblRecby.Text)
                                .Parameters.Add("@update", OleDbType.Date).Value = Globals.logdate
                                .Parameters.Add("@depstat", OleDbType.VarChar).Value = UCase(Me.cboDepositStat.Text)
                                .Parameters.Add("@watc", OleDbType.Double).Value = watc
                                .Parameters.Add("@watcl", OleDbType.Double).Value = watcl
                                .Parameters.Add("@watcd", OleDbType.Double).Value = watcd
                                .Parameters.Add("@jf", OleDbType.Double).Value = jf
                                .Parameters.Add("@maint", OleDbType.Double).Value = maint
                                .Parameters.Add("@assc", OleDbType.Double).Value = assc
                                .Parameters.Add("@penal", OleDbType.Double).Value = penal
                                .Parameters.Add("@smart", OleDbType.Double).Value = smart
                                .Parameters.Add("@park", OleDbType.Double).Value = park
                                .Parameters.Add("@secdep", OleDbType.Double).Value = secdep
                                .Parameters.Add("@facil", OleDbType.Double).Value = facil
                                .Parameters.Add("@renta", OleDbType.Double).Value = renta
                                .Parameters.Add("@rent", OleDbType.Double).Value = rent
                                .Parameters.Add("@cars", OleDbType.Double).Value = cars
                                .Parameters.Add("@others", OleDbType.Double).Value = others
                                .Parameters.Add("@prf", OleDbType.VarChar).Value = prRef
                                .Parameters.Add("@prd", OleDbType.Date).Value = prd
                                .Parameters.Add("@orf", OleDbType.VarChar).Value = orRef
                                .Parameters.Add("@ord", OleDbType.Date).Value = ord
                                .Parameters.Add("@ispr", OleDbType.VarChar).Value = prnpr
                                .Parameters.Add("@isor", OleDbType.VarChar).Value = prnor
                                .ExecuteNonQuery()
                                MsgBox("NEW COLLECTION RECORD ADDED!")
                                newpost = 1
                                colDataGridView.DataSource = GetCollectionList()
                            End With
                            If System.IO.File.Exists(Globals.logs) = True Then
                                'Dim objWriter As New System.IO.StreamWriter(Globalslogs, False)
                                Dim objWriter As New System.IO.StreamWriter(Globals.logs, True)
                                objWriter.Write(vbNewLine & Globals.logdate & "| " & Globals.loginFullname & "| " & Globals.loginUserlevel & "| " & "ADD NEW COLLECTION:" & transidtxt & ":" & transamt)
                                objWriter.Close()
                            Else
                                Dim objWriter As New System.IO.StreamWriter(Globals.logs, False)
                                objWriter.Write(vbNewLine & Globals.logdate & "| " & Globals.loginFullname & "| " & Globals.loginUserlevel & "| " & "ADD NEW COLLECTION:" & transidtxt & ":" & transamt)
                                objWriter.Close()
                            End If
                            newcolcmd.Cancel()
                            Me.cbkNew.Checked = True
                            newtag = 1
                            updatetag = 0
                        Catch ex As Exception
                            MsgBox(ex.Message, MsgBoxStyle.Critical)
                        End Try
                    Else
                        Try
                            If Me.cboNewForm.Text = "OR" Then
                                prRef = ""
                                ord = tdate
                                prd = Nothing
                                prnor = "PRINTED:" & tdate
                                prnpr = ""
                                orRef = Me.cboNewForm.Text & ":" & Me.txtNewForm.Text
                            Else
                                prRef = Me.cboNewForm.Text & ":" & Me.txtNewForm.Text
                                orRef = ""
                                prd = tdate
                                ord = Nothing
                                prnor = ""
                                prnpr = "PRINTED:" & tdate
                            End If


                            With upcolcmd
                                .Connection = Globals.dbCon
                                .CommandType = CommandType.Text
                                .CommandText = "UPDATE collections SET project= @upproj ,unitNum= @upunit ,custName= @upcust ,particulars= @uppart ,paymentType= @uppay ,paymentCash= @upcsh, paymentCheck= @upcsk, paymentOthers= @upoth ,transAmt= @upamt , checkNum= @upchk, checkDate= @upcdat, bank= @upbnk, branch= @upbrh,updatedBy=  @upby ,updatedDate= @updte ,depositStatus= @upstt ,depositDate= @updep ,depositBy= @updby ,depositAcct= @updact ,depositRef= @updref, outstandingDays= @upout ,waterConsumption= @upwc ,waterCardload= @upwat ,waterCard= @upwtc ,joiningFee= @upjf ,maintenance= @upmt ,associationDues= @upasc ,penalty= @uppnl ,smartCardaccess= @upsmt ,parking= @uppk ,constructionSecdep= @upcons ,swimmingPoolGymbasketball= @upfac ,rentalAmenity= @uprta ,rental= @uprnt ,carSticker= @upcrs ,others=@upths ,prRef= @upprf ,prDate= @upprd ,orRef= @uporf ,orDate= @upord , isPr=  @upppr , isOr=  @uppor WHERE transID= @upid"


                                .Parameters.Add("@upproj", OleDbType.VarChar).Value = UCase(Me.cboProject.Text)
                                .Parameters.Add("@upunit", OleDbType.VarChar).Value = UCase(Me.txtUnit.Text)
                                .Parameters.Add("@upcust", OleDbType.VarChar).Value = UCase(Me.txtCustomer.Text)
                                .Parameters.Add("@uppart", OleDbType.VarChar).Value = UCase(Me.cboParticular.Text)
                                .Parameters.Add("@uppay", OleDbType.VarChar).Value = UCase(Me.cboPayment.Text)
                                .Parameters.Add("@upcsh", OleDbType.VarChar).Value = paycash
                                .Parameters.Add("@upcsk", OleDbType.VarChar).Value = paycheck
                                .Parameters.Add("@upoth", OleDbType.VarChar).Value = payothers
                                .Parameters.Add("@upamt", OleDbType.Double).Value = transamt
                                .Parameters.Add("@upchk", OleDbType.VarChar).Value = UCase(Me.txtCheck.Text)
                                .Parameters.Add("@upcdat", OleDbType.Date).Value = checkd
                                .Parameters.Add("@upbnk", OleDbType.VarChar).Value = UCase(Me.cboBank.Text)
                                .Parameters.Add("@upbrh", OleDbType.VarChar).Value = UCase(Me.txtBankBranch.Text)
                                .Parameters.Add("@upby", OleDbType.VarChar).Value = UCase(Globals.loginFullname)
                                .Parameters.Add("@updte", OleDbType.Date).Value = Globals.logdate
                                .Parameters.Add("@upstt", OleDbType.VarChar).Value = UCase(Me.cboDepositStat.Text)
                                .Parameters.Add("@updep", OleDbType.Date).Value = depdate
                                .Parameters.Add("@updby", OleDbType.VarChar).Value = UCase(Me.txtDepositby.Text)
                                .Parameters.Add("@updact", OleDbType.VarChar).Value = UCase(Me.cboBankact.Text)
                                .Parameters.Add("@updref", OleDbType.VarChar).Value = UCase(Me.txtDepositRef.Text)
                                .Parameters.Add("@upout", OleDbType.VarChar).Value = outdays
                                .Parameters.Add("@upwc", OleDbType.Double).Value = watc
                                .Parameters.Add("@upwat", OleDbType.Double).Value = watcl
                                .Parameters.Add("@upwtc", OleDbType.Double).Value = watcd
                                .Parameters.Add("@upjf", OleDbType.Double).Value = jf
                                .Parameters.Add("@upmt", OleDbType.Double).Value = maint
                                .Parameters.Add("@upasc", OleDbType.Double).Value = assc
                                .Parameters.Add("@uppnl", OleDbType.Double).Value = penal
                                .Parameters.Add("@upsmt", OleDbType.Double).Value = smart
                                .Parameters.Add("@uppk", OleDbType.Double).Value = park
                                .Parameters.Add("@upcon", OleDbType.Double).Value = secdep
                                .Parameters.Add("@upfac", OleDbType.Double).Value = facil
                                .Parameters.Add("@uprta", OleDbType.Double).Value = renta
                                .Parameters.Add("@uprnt", OleDbType.Double).Value = rent
                                .Parameters.Add("@upcrs", OleDbType.Double).Value = cars
                                .Parameters.Add("@upths", OleDbType.Double).Value = others
                                .Parameters.Add("@upprf", OleDbType.VarChar).Value = prRef
                                .Parameters.Add("@upprd", OleDbType.Date).Value = prd
                                .Parameters.Add("@uporf", OleDbType.VarChar).Value = orRef
                                .Parameters.Add("@upord", OleDbType.Date).Value = ord
                                .Parameters.Add("@upppr", OleDbType.VarChar).Value = prnpr
                                .Parameters.Add("@uppor", OleDbType.VarChar).Value = prnor
                                .Parameters.Add("@upid", OleDbType.VarChar).Value = recid

                                .ExecuteNonQuery()
                                MsgBox("Record# " & lblTransID.Text & "  HAS BEEN UPDATED BY: " & Globals.loginFullname & ": " & Globals.logdate & " " & upcolcmd.ExecuteNonQuery())
                                colDataGridView.DataSource = GetCollectionList()
                            End With
                            If System.IO.File.Exists(Globals.logs) = True Then
                                'Dim objWriter As New System.IO.StreamWriter(Globalslogs, False)
                                Dim objWriter As New System.IO.StreamWriter(Globals.logs, True)
                                objWriter.Write(vbNewLine & Globals.logdate & "| " & Globals.loginFullname & "| " & Globals.loginUserlevel & "| " & "UPDATED COLLECTION:" & transidtxt & ":" & transamt)
                                objWriter.Close()
                            Else
                                Dim objWriter As New System.IO.StreamWriter(Globals.logs, False)
                                objWriter.Write(vbNewLine & Globals.logdate & "| " & Globals.loginFullname & "| " & Globals.loginUserlevel & "| " & "UPDATED COLLECTION:" & transidtxt & ":" & transamt)
                                objWriter.Close()
                            End If
                            upcolcmd.Cancel()
                            Me.cbkNew.Checked = True
                            newtag = 1
                            updatetag = 0
                        Catch ex As Exception
                            MsgBox(ex.Message, MsgBoxStyle.Critical)
                        End Try
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub cboPayment_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboPayment.SelectedValueChanged
        If Me.cboPayment.Text = "CASH" Then
            Me.txtCheck.Enabled = False
            Me.txtCheck.Visible = False
            Me.dpckCheckDate.Enabled = False
            Me.dpckCheckDate.Visible = False
            Me.txtBankBranch.Enabled = False
            Me.txtBankBranch.Visible = False
            Me.cboBank.Enabled = False
            Me.cboBank.Visible = False
            Me.cboForm.Text = "OR"

        ElseIf Me.cboPayment.Text = "CHECK" Then
            Me.txtCheck.Enabled = True
            Me.txtCheck.Visible = True
            Me.dpckCheckDate.Enabled = True
            Me.dpckCheckDate.Visible = True
            Me.txtBankBranch.Enabled = True
            Me.txtBankBranch.Visible = True
            Me.cboBank.Enabled = True
            Me.cboBank.Visible = True
            Me.cboForm.Text = "PR"
        Else
            Me.txtCheck.Enabled = False
            Me.txtCheck.Visible = False
            Me.dpckCheckDate.Enabled = False
            Me.dpckCheckDate.Visible = False
            Me.txtBankBranch.Enabled = True
            Me.txtBankBranch.Visible = True
            Me.cboBank.Enabled = True
            Me.cboBank.Visible = True
        End If

    End Sub

    Private Sub cboProject_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboProject.SelectedValueChanged
        trxid = reccount + 1
        transidtxt = Me.cboProject.Text & "-" & trxid
        Me.lblTransID.Text = transidtxt
    End Sub

    Private Sub cboDepositStat_TextChanged(sender As Object, e As EventArgs) Handles cboDepositStat.TextChanged
        If Me.cboDepositStat.Text = "DEPOSITED" Then
            Me.dpckDeposit.Visible = True
            Me.dpckDeposit.Enabled = True
            Me.cboBankact.Visible = True
            Me.cboBankact.Enabled = True
            Me.txtDepositby.Visible = True
            Me.txtDepositby.Enabled = True
            Me.txtDepositRef.Visible = True
            Me.txtDepositRef.Enabled = True
        Else
            Me.dpckDeposit.Visible = False
            Me.dpckDeposit.Enabled = False
            Me.cboBankact.Visible = False
            Me.cboBankact.Enabled = False
            Me.txtDepositby.Visible = False
            Me.txtDepositby.Enabled = False
            Me.txtDepositRef.Visible = False
            Me.txtDepositRef.Enabled = False
        End If
    End Sub

    Private Sub cboForm_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboForm.SelectedValueChanged
        If Me.cboPayment.Text = "CASH" Then
            MsgBox("YOU ARE NOT ALLOWED TO CHANGE FORM TYPE")
            Exit Sub
        ElseIf Me.cboPayment.Text = "CHECK" Then
            MsgBox("YOU ARE NOT ALLOWED TO CHANGE FORM TYPE")
            Exit Sub
        Else
            Me.cboForm.Items.Add("OR")
            Me.cboForm.Items.Add("PR")
        End If
    End Sub
End Class
