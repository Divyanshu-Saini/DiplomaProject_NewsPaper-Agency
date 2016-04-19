Imports System.Data.SqlClient
Public Class frmCustomerEdit
    Dim con As SqlConnection
    Private Sub frmCustomerEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TestdbDataSet.Customersdb' table. You can move, or remove it, as needed.
        Me.CustomersdbTableAdapter.Fill(Me.TestdbDataSet.Customersdb)
        'TODO: This line of code loads data into the 'TestdbDataSet.Customersdb' table. You can move, or remove it, as needed.
        Me.CustomersdbTableAdapter.Fill(Me.TestdbDataSet.Customersdb)
        Try
            con = New SqlConnection("Data Source=SuperComp-PC;Initial Catalog=Testdb;Integrated Security=True")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim sDate As Date = Me.DateTimePicker1.Value
            Dim eDate As Date = Me.DateTimePicker2.Value
            Dim abc As String = " Update Customersdb set Customer_Name='" & TextBox2.Text & "', Address='" & RichTextBox1.Text & "', Delivery_Charge='" & TextBox3.Text & "', Start_Date='" & sDate & "', End_Date='" & eDate & "' Where Customer_ID='" & TextBox1.Text & "';"
            Dim da As New SqlDataAdapter(abc, con)
            Dim ds As New DataSet
            da.Fill(ds)
            MsgBox("UPDATE SUCESSFUL !")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
        frmCustomer.Show()

    End Sub
End Class