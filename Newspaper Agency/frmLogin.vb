Imports System.Data.SqlClient

Public Class frmLogin
    Dim con As New SqlConnection
    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            con.ConnectionString = "Data Source=SuperComp-PC;Initial Catalog=Testdb;Integrated Security=True"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Blogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Blogin.Click
        Try
            If TextBox1.Text = Nothing Then
                MsgBox("You must enter the username ", Microsoft.VisualBasic.MsgBoxStyle.Exclamation, "Eror")
            End If
            If TextBox2.Text = Nothing Then
                MsgBox("You must enter the Password ", Microsoft.VisualBasic.MsgBoxStyle.Exclamation, "Eror")
            End If
            Dim abc As String = "Select * From Logindb Where Users='" & TextBox1.Text & "' AND Password='" & TextBox2.Text & "';"

            Dim da As New SqlDataAdapter(abc, con)
            Dim ds As New DataSet
            da.Fill(ds)
            Dim count = ds.Tables(0).Rows.Count
            If count > 0 Then
                frmMain.Show()
                Me.Hide()
                TextBox1.Clear()
                TextBox2.Clear()
            Else
                MsgBox("Invalid  Login Creentials ", Microsoft.VisualBasic.MsgBoxStyle.Critical)
                TextBox1.Clear()
                TextBox2.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

       
    End Sub

    Private Sub Bsignup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bsignup.Click
        frmSignUp.Show()
        Me.Hide()

    End Sub

    Private Function MsgBoxStyle() As MsgBoxStyle
        Throw New NotImplementedException
    End Function

    Private Function abc() As Object
        Throw New NotImplementedException
    End Function

    Private Sub Bexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bexit.Click
        Me.close

    End Sub
End Class
