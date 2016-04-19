Imports System.Data.SqlClient
Public Class frmCustomer
    Dim con As New SqlConnection
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        frmCustomerFind.Show()
        Me.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        frmCustomerNew.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frmCustomerEdit.Show()
        Me.Close()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()

    End Sub

    Private Sub frmCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TestdbDataSet.Customersdb' table. You can move, or remove it, as needed.
        Me.CustomersdbTableAdapter.Fill(Me.TestdbDataSet.Customersdb)
        'TODO: This line of code loads data into the 'TestdbDataSet.Customersdb' table. You can move, or remove it, as needed.
        Me.CustomersdbTableAdapter.Fill(Me.TestdbDataSet.Customersdb)
        Try
            con.ConnectionString = "Data Source=SuperComp-PC;Initial Catalog=Testdb;Integrated Security=True"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim abc As String = "Delete From Customersdb Where Customer_ID='" & TextBox1.Text & "' ;"
            Dim da As New SqlDataAdapter(abc, con)
            Dim ds As New DataSet
            da.Fill(ds)
            MsgBox("Customer Removed", Microsoft.VisualBasic.MsgBoxStyle.ApplicationModal)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class