Public Class frmSupplierPayment

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub frmSupplierPayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TestdbDataSet.Supplierdb' table. You can move, or remove it, as needed.
        Me.SupplierdbTableAdapter.Fill(Me.TestdbDataSet.Supplierdb)

    End Sub
End Class