Imports System.Data.SqlClient
Public Class frmAddAdmin
    Dim con As New SqlConnection
    Private Sub frmAddAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            con.ConnectionString = "Data Source=SuperComp-PC;Initial Catalog=Testdb;Integrated Security=True"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If TextBox1.Text = Nothing And TextBox2.Text = Nothing Then
                MsgBox("You must enter the username ", Microsoft.VisualBasic.MsgBoxStyle.Exclamation, "Eror")
                MsgBox("You must enter the Password ", Microsoft.VisualBasic.MsgBoxStyle.Exclamation, "Eror")
            Else
                Dim abc As String = " INSERT INTO Logindb (Users,Password) VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "');"
                Dim da As New SqlDataAdapter(abc, con)
                Dim ds As New DataSet
                da.Fill(ds)
                MsgBox("New Admin Added Sucessfully !", Microsoft.VisualBasic.MsgBoxStyle.Information)
                Me.Hide()
                TextBox1.Clear()
                TextBox2.Clear()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class