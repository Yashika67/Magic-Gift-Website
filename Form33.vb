Imports Magic_Gift.Details
Imports System.Data.OleDb

Public Class frmOrder

    Dim pro As String
    Dim con As String
    Dim command As String
    Dim cmdd As OleDbCommand
    Dim mycon As OleDbConnection = New OleDbConnection
    Dim cmd As OleDbDataAdapter
    Dim dt As New DataTable
    Dim ra As Integer
    Dim ds As New DataSet

    Private Sub Form33_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Text_name.Text = product_name
        Text_price.Text = product_price
        Text_quantity.Text = product_qty
        Text_total.Text = (product_price * product_qty)

        pro = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Magic Gift.accdb"
        con = pro
        mycon.ConnectionString = con
        Call FillData()
        DataGridView1.DataSource = dt.DefaultView
    End Sub
    Private Sub FillData()
        cmd = New OleDbDataAdapter("Select * from BasicDetails", con)
        cmd.Fill(dt)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Enter All Details")
        ElseIf TextBox2.Text = "" Then
            MsgBox("Enter All Details")
        ElseIf TextBox3.Text = "" Then
            MsgBox("Enter All Details")
        ElseIf TextBox4.Text = "" Then
            MsgBox("Enter All Details")
        ElseIf TextBox5.Text = "" Then
            MsgBox("Enter All Details")
        ElseIf Text_total.Text = "0" Then
            MsgBox("Please Select any Gift")
        Else

            Try
                mycon.Open()
                command = "insert into BasicDetails values('" & TextBox1.Text & "','" & TextBox2.Text & "'," & Val(TextBox3.Text) & ",'" & TextBox4.Text & "'," & Val(TextBox5.Text) & ",'" & Text_name.Text & "'," & Val(Text_price.Text) & "," & Val(Text_quantity.Text) & "," & Val(Text_total.Text) & ")"
                cmdd = New OleDbCommand(command, mycon)
                ra = cmdd.ExecuteNonQuery
                MsgBox("Your Order has been Placed" & ra)
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

End Class