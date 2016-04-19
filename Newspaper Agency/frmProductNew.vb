Imports System.Data.SqlClient
Public Class frmProductNew
    Dim con As New SqlConnection
    Private Sub frmProductNew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        frmProduct.Show()
        Me.Close()
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim abc As String = " INSERT INTO Productdb (Product_ID,Product_Name,Language,Supplier_ID,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday) VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox10.Text & "','" & ComboBox1.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox5.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "');"
            Dim da As New SqlDataAdapter(abc, con)
            Dim ds As New DataSet
            da.Fill(ds)
            MsgBox("Record updated")
            frmProduct.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SplitContainer1_Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub
End Class