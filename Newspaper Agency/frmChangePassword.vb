Imports System.Data.SqlClient
Public Class frmChangePassword
    Dim con As New SqlConnection
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub frmChangePassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            con.ConnectionString = "Data Source=SuperComp-PC;Initial Catalog=Testdb;Integrated Security=True"
            Dim abc As String = "SELECT Users FROM Logindb "
            Dim cmd As New SqlCommand(abc, con)
            cmd.CommandType = CommandType.Text
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)

            If dt.Rows.Count = 0 Then
                MsgBox("PLEASE SELECT ADMIN", Microsoft.VisualBasic.MsgBoxStyle.Critical, "Eror")
            Else
                For i = 0 To dt.Rows.Count - 1
                    ComboBox1.Items.Add(dt.Rows(i).Item("Users"))

                Next
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If ComboBox1.Text = Nothing Then
                MsgBox("You must enter the username ", Microsoft.VisualBasic.MsgBoxStyle.Exclamation, "Error")
            Else
                If TextBox3.Text = TextBox4.Text Then
                    Dim abc As String = "UPDATE Logindb set Password='" & TextBox4.Text & "'Where Users ='" & ComboBox1.Text & "'and Password='" & TextBox2.Text & "';"
                    Dim da As New SqlDataAdapter(abc, con)
                    Dim ds As New DataSet
                    da.Fill(ds)
                    MsgBox("PASSWORD CHANGED SUCCESSFUL !", Microsoft.VisualBasic.MsgBoxStyle.Information)
                    TextBox2.Clear()
                    TextBox3.Clear()
                    TextBox4.Clear()
                    Me.Close()

                Else
                    MsgBox("U R NEW PASSWORD IS MISMATCH ", Microsoft.VisualBasic.MsgBoxStyle.Exclamation, "Error")
                    TextBox2.Clear()
                    TextBox3.Clear()
                    TextBox4.Clear()
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class