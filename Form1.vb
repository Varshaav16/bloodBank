Imports System.Data.SqlClient

Public Class Form1
    Dim Connection As New SqlConnection("Server=LAPTOP-7IOC0O27\SQLEXPRESS; Database=BloodBank; Integrated Security = true")

    'Private Sub btnOpositive_Click(sender As Object, e As EventArgs) Handles MyBase.Load
    'Dim adapter As New SqlDataAdapter("select Name,Address,Phone_Number from hospitals where O_Positive>0;", Connection)
    'Dim table As New DataTable()
    'adapter.Fill(table)

    'Form2.DataGridView1.DataSource = table



    'End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form5.Show()
        Me.Hide()
    End Sub



    Private Sub btnOpositive_Click(sender As Object, e As EventArgs) Handles btnOpositive.Click
        Dim adapter As New SqlDataAdapter("select Name,Address,Phone_Number,O_Positive from hospitals where O_Positive>0;", Connection)
        Dim table As New DataTable()

        adapter.Fill(table)
        Form3.DataGridViewHospital.DataSource = table
        Form3.Show()
        Me.Hide()

    End Sub
End Class
