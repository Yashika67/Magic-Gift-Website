Imports System.Data.OleDb

Public Class frmAboutus

    Dim pro As String
    Dim con As String
    Dim command As String
    Dim cmdd As OleDbCommand
    Dim mycon As OleDbConnection = New OleDbConnection
    Dim cmd As OleDbDataAdapter
    Dim dt As New DataTable
    Dim ra As Integer
    Dim ds As New DataSet

    Private Sub btnpnp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpnp.Click
        PictureBox2.Visible = False
        PictureBox4.Visible = False
        PictureBox3.Visible = True
        Panel2.Visible = False
    End Sub

    Private Sub btnAboutus_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAboutus.Click
        PictureBox4.Visible = False
        PictureBox3.Visible = False
        PictureBox2.Visible = True
        Panel2.Visible = False
    End Sub

    Private Sub btnsnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsnd.Click
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = True
        Panel2.Visible = False
    End Sub

    Private Sub btnContactus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContactus.Click
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        Panel2.Visible = True
    End Sub

    Private Sub frmAboutus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pro = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Magic Gift.accdb"
        con = pro
        mycon.ConnectionString = con
        Call FillData()
        Call FillData1()
        DataGridView1.DataSource = dt.DefaultView
    End Sub
    Private Sub FillData()
        cmd = New OleDbDataAdapter("Select * from ContactUs", con)
        cmd.Fill(dt)
    End Sub
    Private Sub FillData1()
        cmd = New OleDbDataAdapter("Select * from Newsletter", con)
        cmd.Fill(dt)
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        If TextBox1.Text = "" Then
            MsgBox("Enter All Details")
        ElseIf TextBox2.Text = "" Then
            MsgBox("Enter All Details")
        ElseIf TextBox3.Text = "" Then
            MsgBox("Enter All Details")
        ElseIf TextBox4.Text = "" Then
            MsgBox("Enter All Details")
        Else
            Try
                mycon.Open()
                command = "insert into ContactUs values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "')"
                cmdd = New OleDbCommand(command, mycon)
                ra = cmdd.ExecuteNonQuery
                MsgBox("We will Contact you as soon as Possible" & ra)
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



    Private Sub btnSubscribe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubscribe.Click
        If TextBox5.Text = "" Then
            MsgBox("Enter Email")
        Else
            Try
                mycon.Open()
                command = "insert into Newsletter values('" & TextBox5.Text & "')"
                cmdd = New OleDbCommand(command, mycon)
                ra = cmdd.ExecuteNonQuery
                MsgBox("We will Contact you as soon as Possible" & ra)
                dt.Columns.Clear()
                dt.Rows.Clear()
                cmd.Fill(dt)
                DataGridView1.DataSource = dt.DefaultView

            Catch ex As Exception
                MsgBox(" Subscribe Succesfully " & ra)
            End Try
            mycon.Close()
            mycon.Open()
            dt.Columns.Clear()
            dt.Rows.Clear()
            cmd.Fill(dt)
            mycon.Close()
        End If
    End Sub
End Class