Imports System.Data.SqlClient
Public Class frmProduct
    Dim con As New SqlConnection
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        frmProductFind.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frmProductNew.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmProductEdit.Show()
        Me.Close()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()

    End Sub

    Private Sub frmProduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TestdbDataSet.Productdb' table. You can move, or remove it, as needed.
        Me.ProductdbTableAdapter.Fill(Me.TestdbDataSet.Productdb)
        'TODO: This line of code loads data into the 'TestdbDataSet.Productdb' table. You can move, or remove it, as needed.
        Me.ProductdbTableAdapter.Fill(Me.TestdbDataSet.Productdb)
        Try
            con.ConnectionString = "Data Source=SuperComp-PC;Initial Catalog=Testdb;Integrated Security=True"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            Dim abc As String = "Delete From Productdb Where Product_ID='" & TextBox1.Text & "' ;"
            Dim da As New SqlDataAdapter(abc, con)
            Dim ds As New DataSet
            da.Fill(ds)
            MsgBox("Product Removed", Microsoft.VisualBasic.MsgBoxStyle.ApplicationModal)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class