Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports MySql.Data.MySqlConnection
Public Class Form1

    Sub ClearAll()

        txtDays.Text = String.Empty
        txtRooms.Text = String.Empty
        txtName.Text = String.Empty

        lblDays.Text = String.Empty
        lblName.Text = String.Empty
        lblPrice.Text = String.Empty
        lblRooms.Text = String.Empty

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim name As String = txtName.Text
        Dim r As Single = Val(txtRooms.Text)
        Dim d As Single = Val(txtDays.Text)
        Dim MyObject As Object
        Dim totalroom As Single = r * 2500
        Dim totalday As Single = d * 750

        MyObject = New MyClass1()

        lblName.Text = name
        lblRooms.Text = (r & " room/rooms")
        lblDays.Text = (d & " day/days")
        lblPrice.Text = MyObject.HOTEL(totalroom, totalday)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ClearAll()

    End Sub

    Private Sub DB_Click(sender As Object, e As EventArgs) Handles DB.Click
        Dim MySqlConnection As New MySqlConnection("host = localhost; user = root; paswword = ")
        Try
            MySqlConnection.Open()
            MessageBox.Show("Successfully connected to the database")
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        adds("INSERT INTO reservation (name,room,day,price) VALUES('" & lblName.Text & " ', '" & lblRooms.Text & " ' , '" & lblDays.Text & " ','" & lblPrice.Text & " ')")
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        view("SELECT * FROM reservation", DataGridView1)

    End Sub
End Class
