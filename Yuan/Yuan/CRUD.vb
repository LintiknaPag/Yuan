Imports MySql.Data.MySqlClient
Module CRUD
    Public Function strconnection() As MySqlConnection
        Return New MySqlConnection("host=localhost; user=root; password=; database=hotel")
    End Function
    Public strcon As MySqlConnection = strconnection()
    Public result As String
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable

    Public Sub adds(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("Failed to save data", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Data has been save in the database", "SAVED", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub

    Public Sub view(ByVal sql As String, ByVal DataGridView1 As Object)
        Try
            dt = New DataTable
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            DataGridView1.datasource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
            da.Dispose()
        End Try
    End Sub
End Module