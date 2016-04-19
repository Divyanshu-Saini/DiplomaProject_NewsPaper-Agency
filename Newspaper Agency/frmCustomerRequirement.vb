Public Class frmCustomerRequirement

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()

    End Sub

    Private Sub frmCustomerRequirement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TestdbDataSet.Customersdb' table. You can move, or remove it, as needed.
        Me.CustomersdbTableAdapter.Fill(Me.TestdbDataSet.Customersdb)

    End Sub
End Class