Imports System.Data.SqlClient
Public Class frmRemoveAdmin
    Dim con As New SqlConnection
    Private Sub frmRemoveAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        Me.Close()

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If ComboBox1.Text = Nothing Then
            MsgBox("PLEASE ENTER ADMIN USER NAME ", Microsoft.VisualBasic.MsgBoxStyle.Exclamation, "Eror")
        Else
            Dim abc As String = "Delete From Logindb Where Users='" & ComboBox1.Text & "' ;"
            Dim da As New SqlDataAdapter(abc, con)
            Dim ds As New DataSet
            da.Fill(ds)
            MsgBox("Admin Removed", Microsoft.VisualBasic.MsgBoxStyle.ApplicationModal)
            Me.Close()
        End If
    End Sub
End Class