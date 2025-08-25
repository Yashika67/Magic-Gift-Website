Imports System.Data.OleDb

Public Class frmSignup

    Dim pro As String
    Dim con As String
    Dim command As String
    Dim cmdd As OleDbCommand
    Dim mycon As OleDbConnection = New OleDbConnection
    Dim cmd As OleDbDataAdapter
    Dim dt As New DataTable
    Dim ra As Integer
    Dim ds As New DataSet

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        txtPassword.PasswordChar = ""
    End Sub

    Private Sub PictureBox2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.DoubleClick
        txtPassword.PasswordChar = "*"
    End Sub

    Private Sub btnSignin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignin.Click
        If txtId.Text = "" And txtPassword.Text = "" Then
            MsgBox("Fill the Details")
        Else
            Try
                mycon.Open()
                command = "insert into Signup values('" & txtId.Text & "','" & txtPassword.Text & "','" & txtCPass.Text & "')"
                cmdd = New OleDbCommand(command, mycon)
                ra = cmdd.ExecuteNonQuery
                MsgBox("Login Successful" & ra)
                dt.Columns.Clear()
                dt.Rows.Clear()
                cmd.Fill(dt)
                DataGridView1.DataSource = dt.DefaultView

            Catch ex As Exception
                MsgBox(" Record not Inserted " & ra)
            End Try
            mycon.Close()
            mycon.Open()
            dt.Columns.Clear()
            dt.Rows.Clear()
            cmd.Fill(dt)
            mycon.Close()

        End If
    End Sub

    Private Sub frmSignup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pro = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Magic Gift.accdb"
        con = pro
        mycon.ConnectionString = con
        Call FillData()
        DataGridView1.DataSource = dt.DefaultView
    End Sub
    Private Sub FillData()
        cmd = New OleDbDataAdapter("Select * from Signup", con)
        cmd.Fill(dt)
    End Sub

End Class