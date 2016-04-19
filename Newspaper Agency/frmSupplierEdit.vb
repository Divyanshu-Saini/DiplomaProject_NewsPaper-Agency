Imports System.Data.SqlClient
Public Class frmSupplierEdit
    Dim con As New SqlConnection
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        frmSupplier.Show()
        Me.Close()

    End Sub

    Private Sub frmSupplierEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim abc As String = " Update Supplierdb set Supplier_Name='" & TextBox2.Text & "',Address='" & RichTextBox1.Text & "',Phone_No='" & TextBox3.Text & "'Where Supplier_ID ='" & TextBox1.Text & "';"
            Dim da As New SqlDataAdapter(abc, con)
            Dim ds As New DataSet
            da.Fill(ds)
            MsgBox("Record updated")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class