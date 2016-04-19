Public Class frmMain

   
    Private Sub PRODUCTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PRODUCTToolStripMenuItem.Click
        frmProduct.Show()

    End Sub

    Private Sub MASTERToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MASTERToolStripMenuItem1.Click
        frmSupplier.Show()

    End Sub

    Private Sub CUSTOMERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CUSTOMERToolStripMenuItem.Click
        frmCustomer.Show()

    End Sub

    Private Sub SUPPLIERPAYMENTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SUPPLIERPAYMENTToolStripMenuItem.Click
        frmSupplierPayment.Show()

    End Sub

    Private Sub CUSTOMERREQUIREMENTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CUSTOMERREQUIREMENTToolStripMenuItem.Click
        frmCustomerRequirement.Show()

    End Sub

    Private Sub CHANGEPASSWORDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHANGEPASSWORDToolStripMenuItem.Click
        frmChangePassword.Show()

    End Sub

    Private Sub ADDADMINToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADDADMINToolStripMenuItem.Click
        frmAddAdmin.Show()

    End Sub

    Private Sub REMOVEADMINToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REMOVEADMINToolStripMenuItem.Click
        frmRemoveAdmin.Show()

    End Sub

    Private Sub PREPAREBILLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PREPAREBILLToolStripMenuItem.Click
        frmPrepareBill.Show()

    End Sub

    Private Sub BILLRECEIVEDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BILLRECEIVEDToolStripMenuItem.Click
        frmBillReceived.Show()

    End Sub

    Private Sub MONTHLYSALEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MONTHLYSALEToolStripMenuItem.Click
        frmMonthlySale.Show()

    End Sub

    Private Sub DAILYSALEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DAILYSALEToolStripMenuItem.Click
        frmDailySale.Show()

    End Sub

    Private Sub BILLBALANCEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BILLBALANCEToolStripMenuItem.Click
        frmBillBalance.show()

    End Sub

    Private Sub EXITToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXITToolStripMenuItem.Click
        frmLogin.Close()
    End Sub

    Private Sub PRINTBILLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PRINTBILLToolStripMenuItem.Click
        frmPrintBill.Show()

    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOGOUTToolStripMenuItem.Click
        frmLogin.Show()
        Me.Close()

    End Sub

    Private Sub DAILYSTOCKToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DAILYSTOCKToolStripMenuItem.Click
        frmDailyStock.Show()

    End Sub
End Class