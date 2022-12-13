Imports System.Data.SqlClient
Public Class HighScores
    Dim conn As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub HighScores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Data Source=DESKTOP-5EIU9KB\SQLEXPRESS;Initial Catalog=ArabaYarisi;Integrated Security=True"
        cmd.CommandText = "Select * from oyuncular order by puan DESC"
        cmd.Connection = conn

        conn.Open()

        Dim sr As SqlDataReader = cmd.ExecuteReader()
        Dim place As Integer = 1

        While sr.Read()
            Dim nick As String = sr.GetValue(0)

            Dim score As Integer = sr.GetValue(1)


            ListBox1.Items.Add(place.ToString() + "-) " + nick)
            ListBox2.Items.Add(score.ToString())

            place += 1

        End While
        conn.Close()

    End Sub
End Class