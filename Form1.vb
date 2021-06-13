Imports System.Data.SqlClient

Public Class Form1



    'Varshaa - DESKTOP-1D4H6BI\SQLEXPRESS
    'Sri Vidhya - DESKTOP-TR3PCQ9\SQLEXPRESS
    'Srindhi - LAPTOP-7IOC0O27\SQLEXPRESS
    'Sirisha - 

    Dim Connection As New SqlConnection("Server=DESKTOP-1D4H6BI\SQLEXPRESS; Database=BloodBank; Integrated Security = true")


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


    Private Sub btnApositive_Click(sender As Object, e As EventArgs) Handles btnApositive.Click
        Dim adapter As New SqlDataAdapter("select Name, Address, Phone_Number, A_Positive from hospitals where A_Positive>0;", Connection)
        Dim table As New DataTable()

        adapter.Fill(table)
        Form3.DataGridViewHospital.DataSource = table
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub btnBpositive_Click(sender As Object, e As EventArgs) Handles btnBpositive.Click
        Dim adapter As New SqlDataAdapter("select Name, Address, Phone_Number, B_Positive from hospitals where B_Positive>0;", Connection)
        Dim table As New DataTable()

        adapter.Fill(table)
        Form3.DataGridViewHospital.DataSource = table
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub btnABpositive_Click(sender As Object, e As EventArgs) Handles btnABpositive.Click
        Dim adapter As New SqlDataAdapter("select Name, Address, Phone_Number, AB_Positive from hospitals where AB_Positive>0;", Connection)
        Dim table As New DataTable()

        adapter.Fill(table)
        Form3.DataGridViewHospital.DataSource = table
        Form3.Show()
        Me.Hide()
    End Sub
    Private Sub btnABnegative_Click(sender As Object, e As EventArgs) Handles btnABnegative.Click
        Dim adapter As New SqlDataAdapter("select Name, Address, Phone_Number, AB_Negative from hospitals where AB_Negative>0;", Connection)
        Dim table As New DataTable()

        adapter.Fill(table)
        Form3.DataGridViewHospital.DataSource = table
        Form3.Show()
        Me.Hide()
    End Sub


    Private Sub btnAnegative_Click(sender As Object, e As EventArgs) Handles btnAnegative.Click
        Dim adapter As New SqlDataAdapter("select Name, Address, Phone_Number, A_Negative from hospitals where A_Negative>0;", Connection)
        Dim table As New DataTable()

        adapter.Fill(table)
        Form3.DataGridViewHospital.DataSource = table
        Form3.Show()
        Me.Hide()
    End Sub
    Private Sub btnBnegative_Click(sender As Object, e As EventArgs) Handles btnBnegative.Click
        Dim adapter As New SqlDataAdapter("select Name, Address, Phone_Number, B_Negative from hospitals where B_Negative>0;", Connection)
        Dim table As New DataTable()

        adapter.Fill(table)
        Form3.DataGridViewHospital.DataSource = table
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub btnOnegative_Click(sender As Object, e As EventArgs) Handles btnOnegative.Click
        Dim adapter As New SqlDataAdapter("select Name, Address, Phone_Number, O_Negative from hospitals where O_Negative>0;", Connection)
        Dim table As New DataTable()

        adapter.Fill(table)
        Form3.DataGridViewHospital.DataSource = table
        Form3.Show()
        Me.Hide()
    End Sub
End Class
