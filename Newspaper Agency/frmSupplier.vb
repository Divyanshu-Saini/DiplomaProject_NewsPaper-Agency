Imports System.Data.SqlClient
Public Class frmSupplier
    Dim con As New SqlConnection

    Private Sub frmSupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TestdbDataSet.Supplierdb' table. You can move, or remove it, as needed.
        Me.SupplierdbTableAdapter.Fill(Me.TestdbDataSet.Supplierdb)
        'TODO: This line of code loads data into the 'TestdbDataSet.Supplierdb' table. You can move, or remove it, as needed.
        Me.SupplierdbTableAdapter.Fill(Me.TestdbDataSet.Supplierdb)
        Try
            con.ConnectionString = "Data Source=SuperComp-PC;Initial Catalog=Testdb;Integrated Security=True"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        frmSupplierFind.Show()
        Me.Close()

    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        frmSupplierNew.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frmSupplierEdit.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim abc As String = "Delete From Supplierdb Where Supplier_ID='" & TextBox1.Text & "' ;"
            Dim da As New SqlDataAdapter(abc, con)
            Dim ds As New DataSet
            da.Fill(ds)
            MsgBox("Supplier Removed", Microsoft.VisualBasic.MsgBoxStyle.ApplicationModal)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()

    End Sub
End Class