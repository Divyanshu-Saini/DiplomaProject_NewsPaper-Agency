Imports System.Data.SqlClient
Public Class frmProductEdit
    Dim con As New SqlConnection
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frmProduct.Show()
        Me.Close()

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub frmProductEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TestdbDataSet.Productdb' table. You can move, or remove it, as needed.
        Me.ProductdbTableAdapter.Fill(Me.TestdbDataSet.Productdb)
        'TODO: This line of code loads data into the 'TestdbDataSet.Productdb' table. You can move, or remove it, as needed.
        Me.ProductdbTableAdapter.Fill(Me.TestdbDataSet.Productdb)
        Try
            con.ConnectionString = "Data Source=SuperComp-PC;Initial Catalog=Testdb;Integrated Security=True"
            Dim abc As String = "SELECT Supplier_ID FROM Supplierdb "
            Dim cmd As New SqlCommand(abc, con)
            cmd.CommandType = CommandType.Text
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)

            If dt.Rows.Count = 0 Then
                MsgBox("PLEASE SELECT ADMIN", Microsoft.VisualBasic.MsgBoxStyle.Critical, "Eror")
            Else
                For i = 0 To dt.Rows.Count - 1
                    ComboBox1.Items.Add(dt.Rows(i).Item("Supplier_ID"))

                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim abc As String = "UPDATE Productdb set Product_Name='" & TextBox2.Text & "',Language='" & TextBox10.Text & "',Supplier_ID='" & ComboBox1.Text & "',Monday='" & TextBox3.Text & "',Tuesday='" & TextBox4.Text & "',Wednesday='" & TextBox6.Text & "',Thursday='" & TextBox7.Text & "',Friday='" & TextBox5.Text & "',Saturday='" & TextBox8.Text & "',Sunday='" & TextBox9.Text & "'Where Product_ID='" & TextBox1.Text & "';"
            Dim da As New SqlDataAdapter(abc, con)
            Dim ds As New DataSet
            da.Fill(ds)
            MsgBox("Record Hasbeen Updated Sucessfully ")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
      
    End Sub
End Class