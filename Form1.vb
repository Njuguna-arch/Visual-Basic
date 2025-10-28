Imports System.Data.SQLite

Public Class Form1
    Private ReadOnly connStr As String = "Data Source=teams.db;Version=3;"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using conn As New SQLiteConnection(connStr)
            conn.Open()

            Dim sql As String = "CREATE TABLE IF NOT EXISTS Teams (Id INTEGER PRIMARY KEY AUTOINCREMENT, Name TEXT NOT NULL);"
            Using cmd As New SQLiteCommand(sql, conn)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtName.Text) Then
            MessageBox.Show("Please enter a team name.")
            Return
        End If

        Using conn As New SQLiteConnection(connStr)
            conn.Open()

            Dim sql As String = "INSERT INTO Teams (Name) VALUES (@name);"
            Using cmd As New SQLiteCommand(sql, conn)
                cmd.Parameters.AddWithValue("@name", txtName.Text.Trim())
                cmd.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("Team saved successfully!")
        txtName.Clear()
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Dim connStr As String = "Data Source=teams.db;Version=3;"
        lstTeams.Items.Clear()

        Using conn As New SQLiteConnection(connStr)
            conn.Open()
            Dim sql As String = "SELECT Name FROM Teams;"
            Using cmd As New SQLiteCommand(sql, conn)
                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        lstTeams.Items.Add(reader("Name").ToString())
                    End While
                End Using
            End Using
        End Using
    End Sub

End Class