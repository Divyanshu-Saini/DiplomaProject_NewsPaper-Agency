Imports System.Data.SqlClient
Public Class frmCustomerNew
    Dim con As New SqlConnection
    Private Sub frmCustomerNew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            con.ConnectionString = "Data Source=SuperComp-PC;Initial Catalog=Testdb;Integrated Security=True"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        frmCustomer.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim sDate As Date = Me.DateTimePicker1.Value
            Dim eDate As Date = Me.DateTimePicker2.Value
            Dim abc As String = " INSERT INTO Customersdb (Customer_ID,Customer_Name,Address,Delivery_Charge,Start_Date,End_Date) VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & RichTextBox1.Text & "','" & TextBox3.Text & "','" & sDate & "','" & eDate & "');"
            Dim da As New SqlDataAdapter(abc, con)
            Dim ds As New DataSet
            da.Fill(ds)
            MsgBox("Record updated")
            frmCustomer.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SplitContainer1_Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class