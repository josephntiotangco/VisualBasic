Public Class frmFormPrinting
    Public ordate As Date = Date.Today
    Public prdate As Date = Date.Today
    Public formtemp As Integer
    Private Sub frmFormPrinting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cboFormType.Items.Add("OR")
        Me.cboFormType.Items.Add("PR")
        formtemp = 0
        If frmHome.hm.cboForm.Text = "OR" Then
            Me.txtCust.Text = Globals.orName
            Me.txtAmt1.Text = Globals.orAmt
            Me.txtAmt2.Text = Globals.orAmt
            Me.txtDate.Text = frmHome.hm.lblDocDate.Text
            Me.txtPay.Text = Globals.orPay
            Me.txtRemarks.Text = Globals.orPart
            Me.txtRef.Text = Globals.orRef
            Me.txtProj.Text = Globals.orProj
            Me.txtUnit.Text = Globals.orUnit
            Me.txtUser.Text = Globals.loginFullname
            Me.cboFormType.Text = "OR"
        Else
            Me.txtCust.Text = Globals.prName
            Me.txtAmt1.Text = Globals.prAmt
            Me.txtAmt2.Text = Globals.prAmt
            Me.txtDate.Text = frmHome.hm.lblDocDate.Text
            Me.txtPay.Text = Globals.prPay
            Me.txtRemarks.Text = Globals.prPart
            Me.txtRef.Text = Globals.prRef
            Me.txtProj.Text = Globals.prProj
            Me.txtUnit.Text = Globals.prUnit
            Me.txtUser.Text = Globals.loginFullname
            Me.cboFormType.Text = "PR"
        End If


        AddHandler PrintDocument1.PrintPage, AddressOf Me.PrintDocument1_PrintPage
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        AddHandler PrintDocument3.PrintPage, AddressOf Me.PrintDocument3_PrintPage
        Me.PrintPreviewDialog3.Document = Me.PrintDocument3
    End Sub

    Private Sub BACKTOHOMEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BACKTOHOMEToolStripMenuItem.Click
        frmHome.Show()
        Me.Hide()
    End Sub

    Private Sub PRINTPREVIEWToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PRINTPREVIEWToolStripMenuItem.Click
        If formtemp = 0 Then
            MsgBox("PLEASE SELECT FORM TYPE!")
            Exit Sub
        ElseIf formtemp = 1 Then
            Me.PrintPreviewDialog1.ShowDialog()
        Else
            Me.PrintPreviewDialog3.ShowDialog()
        End If
    End Sub

    Private Sub PrintDocument3_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)

        Dim f As Font = New Font("Calibri", 12)
        Dim f1 As Font = New Font("Calibri", 14)
        Dim br As SolidBrush = New SolidBrush(Color.Black)
        Dim p As Pen = New Pen(Color.Black)

        e.Graphics.DrawString(Me.txtDate.Text, f, br, My.Settings.datex, My.Settings.datey)
        e.Graphics.DrawString(Me.txtCust.Text, f1, br, My.Settings.custx, My.Settings.custy)
        'e.Graphics.DrawString(Me.txtPRWords1.Text, f, br, My.Settings.prwordsy, My.Settings.prwordsy)
        e.Graphics.DrawString(Me.txtWords.Text, f, br, New Rectangle(My.Settings.rect2locx, My.Settings.rect2locy, My.Settings.rect2x, My.Settings.rect2y), StringFormat.GenericTypographic)
        e.Graphics.DrawString(Me.txtAmt1.Text, f, br, My.Settings.amt1x, My.Settings.amt1y)
        e.Graphics.DrawString(Me.txtRef.Text, f, br, New Rectangle(My.Settings.rectlocx, My.Settings.rectlocy, My.Settings.rectx, My.Settings.recty), StringFormat.GenericTypographic)
        e.Graphics.DrawString(Me.txtRemarks.Text, f, br, My.Settings.partsx, My.Settings.partsy)
        'e.Graphics.DrawString(Me.txtPRAmt2.Text, f, br, 130, My.Settings.pr)
        e.Graphics.DrawString(Me.txtPay.Text, f, br, My.Settings.payx, My.Settings.payy)
        e.Graphics.DrawString(Me.txtUnit.Text, f, br, My.Settings.unitx, My.Settings.unity)
        e.Graphics.DrawString(Me.txtProj.Text, f, br, My.Settings.unitx, My.Settings.projy)
        e.Graphics.DrawString(Me.txtUser.Text, f, br, My.Settings.empx, My.Settings.empy)

    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)

        Dim f As Font = New Font("Calibri", 12)
        Dim br As SolidBrush = New SolidBrush(Color.Black)
        Dim p As Pen = New Pen(Color.Black)

        e.Graphics.DrawString(Me.txtDate.Text, f, br, My.Settings.datex, My.Settings.datey)
        e.Graphics.DrawString(Me.txtCust.Text, f, br, My.Settings.custx, My.Settings.custy)
        'e.Graphics.DrawString(Me.txtORWords1.Text, f, br, My.Settings.wordsx, My.Settings.wordsy)
        e.Graphics.DrawString(Me.txtWords.Text, f, br, New Rectangle(My.Settings.rect2locx, My.Settings.rect2locy, My.Settings.rect2x, My.Settings.rect2y), StringFormat.GenericTypographic)
        e.Graphics.DrawString(Me.txtAmt1.Text, f, br, My.Settings.amt1x, My.Settings.amt1y)
        'e.Graphics.DrawString(Me.txtORref1.Text, f, br, My.Settings.refx, My.Settings.refy)
        e.Graphics.DrawString(Me.txtRef.Text, f, br, New Rectangle(My.Settings.rectlocx, My.Settings.rectlocy, My.Settings.rectx, My.Settings.recty), StringFormat.GenericTypographic)
        'e.Graphics.DrawString(Me.txtORparts1.Text, f, br, My.Settings.partsx, My.Settings.partsy)
        e.Graphics.DrawString(Me.txtRemarks.Text, f, br, New Rectangle(My.Settings.rect1locx, My.Settings.rect1locy, My.Settings.rect1x, My.Settings.rect1y), StringFormat.GenericTypographic)
        e.Graphics.DrawString(Me.txtAmt2.Text, f, br, My.Settings.amt1x, My.Settings.amt1y)
        e.Graphics.DrawString(Me.txtPay.Text, f, br, My.Settings.payx, My.Settings.payy)
        e.Graphics.DrawString(Me.txtUnit.Text, f, br, My.Settings.unitx, My.Settings.unity)
        e.Graphics.DrawString(Me.txtProj.Text, f, br, My.Settings.projx, My.Settings.projy)
        e.Graphics.DrawString(Me.txtUser.Text, f, br, My.Settings.empx, My.Settings.empy)

    End Sub

    Private Sub cboFormType_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboFormType.SelectedValueChanged
        If Me.cboFormType.Text = "OR" Then
            Me.txtDate.Text = ordate
            Me.txtAmt1.Text = UCase(Globals.orAmt)
            Me.txtAmt2.Text = UCase(Globals.orAmt)
            Me.txtCust.Text = UCase(Globals.orName)
            Me.txtUser.Text = UCase(Globals.loginFullname)
            Me.txtRemarks.Text = UCase(Globals.orPart)
            Me.txtPay.Text = UCase(Globals.orPay)
            Me.txtProj.Text = UCase(Globals.orProj)
            Me.txtRef.Text = UCase(Globals.orRef)
            Me.txtUnit.Text = UCase(Globals.orUnit)

            'OR TEMPLATE
            Me.txtAmt1x.Text = 130
            Me.txtAmt1y.Text = 320
            Me.txtCustx.Text = 450
            Me.txtCusty.Text = 180
            Me.txtDatex.Text = 600
            Me.txtDatey.Text = 130
            Me.txtAmt2x.Text = 400
            Me.txtAmt2y.Text = 260
            Me.txtWordx.Text = 400
            Me.txtWordy.Text = 240
            Me.txtRefx.Text = 130
            Me.txtRefy.Text = 150
            Me.txtRemx.Text = 300
            Me.txtRemy.Text = 280
            Me.txtNamex.Text = 600
            Me.txtNamey.Text = 350
            Me.txtPayx.Text = 130
            Me.txtPayy.Text = 350
            Me.txtUnitx.Text = 300
            Me.txtUnity.Text = 320
            Me.txtProjx.Text = 400
            Me.txtProjy.Text = 320
            Me.txtReclocx.Text = 130
            Me.txtReclocy.Text = 150
            Me.txtRecx.Text = 100
            Me.txtRecy.Text = 200
            Me.txtRec1locx.Text = 350
            Me.txtRec1locy.Text = 280
            Me.txtRec1x.Text = 300
            Me.txtRec1y.Text = 60
            Me.txtRec2locx.Text = 350
            Me.txtRec2locy.Text = 210
            Me.txtRec2x.Text = 300
            Me.txtRec2y.Text = 60
            formtemp = 1
            btnUpdate_Click(sender, e)
        Else
            Me.txtAmt1.Text = UCase(Globals.prAmt)
            Me.txtAmt2.Text = UCase(Globals.prAmt)
            Me.txtUser.Text = UCase(Globals.prName)
            Me.txtDate.Text = prdate
            Me.txtRef.Text = UCase(Globals.prRef)
            Me.txtUser.Text = UCase(Globals.loginFullname)
            Me.txtRemarks.Text = UCase(Globals.prPart)
            Me.txtPay.Text = UCase(Globals.prPay)
            Me.txtProj.Text = UCase(Globals.prProj)
            Me.txtWords.Text = ""
            Me.txtUnit.Text = Globals.prUnit

            'PR TEMPLATE
            Me.txtAmt1x.Text = 600
            Me.txtAmt1y.Text = 260
            Me.txtCustx.Text = 350
            Me.txtCusty.Text = 180
            Me.txtDatex.Text = 600
            Me.txtDatey.Text = 130
            Me.txtAmt2x.Text = 130
            Me.txtAmt2y.Text = 320
            Me.txtWordx.Text = 400
            Me.txtWordy.Text = 240
            Me.txtRefx.Text = 350
            Me.txtRefy.Text = 130
            Me.txtRemx.Text = 300
            Me.txtRemy.Text = 280
            Me.txtNamex.Text = 600
            Me.txtNamey.Text = 360
            Me.txtPayx.Text = 130
            Me.txtPayy.Text = 350
            Me.txtUnitx.Text = 300
            Me.txtUnity.Text = 300
            Me.txtProjx.Text = 400
            Me.txtProjy.Text = 300
            Me.txtReclocx.Text = 130
            Me.txtReclocy.Text = 150
            Me.txtRecx.Text = 100
            Me.txtRecy.Text = 200
            Me.txtRec1locx.Text = 350
            Me.txtRec1locy.Text = 280
            Me.txtRec1x.Text = 300
            Me.txtRec1y.Text = 60
            Me.txtRec2locx.Text = 350
            Me.txtRec2locy.Text = 210
            Me.txtRec2x.Text = 300
            Me.txtRec2y.Text = 60
            formtemp = 2
            btnUpdate_Click(sender, e)
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        My.Settings.amt1x = Me.txtAmt1x.Text
        My.Settings.amt1y = Me.txtAmt1y.Text
        My.Settings.datex = Me.txtDatex.Text
        My.Settings.datey = Me.txtDatey.Text
        My.Settings.amt2x = Me.txtAmt2x.Text
        My.Settings.amt2y = Me.txtAmt2y.Text
        My.Settings.wordsx = Me.txtWordx.Text
        My.Settings.wordsy = Me.txtWordy.Text
        My.Settings.refx = Me.txtRefx.Text
        My.Settings.refy = Me.txtRefy.Text
        My.Settings.partsx = Me.txtRemx.Text
        My.Settings.partsy = Me.txtRemy.Text
        My.Settings.empx = Me.txtNamex.Text
        My.Settings.empy = Me.txtNamey.Text
        My.Settings.payx = Me.txtPayx.Text
        My.Settings.payy = Me.txtPayy.Text
        My.Settings.unitx = Me.txtUnitx.Text
        My.Settings.unity = Me.txtUnity.Text
        My.Settings.projx = Me.txtProjx.Text
        My.Settings.projy = Me.txtProjy.Text
        My.Settings.custx = Me.txtCustx.Text
        My.Settings.custy = Me.txtCusty.Text

        My.Settings.rectx = Me.txtRecx.Text
        My.Settings.recty = Me.txtRecy.Text
        My.Settings.rectlocx = Me.txtReclocx.Text
        My.Settings.rectlocy = Me.txtReclocy.Text

        My.Settings.rect1x = Me.txtRec1x.Text
        My.Settings.rect1y = Me.txtRec1y.Text
        My.Settings.rect1locx = Me.txtRec1locx.Text
        My.Settings.rect1locy = Me.txtRec1locy.Text

        My.Settings.rect2x = Me.txtRec2x.Text
        My.Settings.rect2y = Me.txtRec2y.Text
        My.Settings.rect2locx = Me.txtRec2locx.Text
        My.Settings.rect2locy = Me.txtRec2locy.Text

        MsgBox("FORM TEMPLATE SETTINGS UPDATED")
    End Sub
End Class