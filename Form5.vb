Imports System.Data.SqlClient


Public Class Form5
    'Varshaa - DESKTOP-1D4H6BI\SQLEXPRESS
    'Sri Vidhya - DESKTOP-TR3PCQ9\SQLEXPRESS
    'Srindhi - LAPTOP-7IOC0O27\SQLEXPRESS
    'Sirisha - 

    Dim Connection As New SqlConnection("Server=LAPTOP-7IOC0O27\SQLEXPRESS; Database=BloodBank; Integrated Security = true")

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        Dim command As New SqlCommand("insert into Hospitals (Name, Address, Phone_Number, O_Positive, A_Positive, B_Positive, AB_Positive, O_Negative, A_Negative, B_Negative, AB_Negative) values (@name, @add, @phno, @opos, @apos, @bpos, @abpos, @oneg, @aneg, @bneg, @abneg)", Connection)
        command.Parameters.Add("@name", SqlDbType.VarChar).Value = Txt_hname.Text
        command.Parameters.Add("@add", SqlDbType.VarChar).Value = Txt_hadd.Text
        command.Parameters.Add("@phno", SqlDbType.VarChar).Value = Txt_hphno.Text
        command.Parameters.Add("@opos", SqlDbType.VarChar).Value = Txt_opos.Text
        command.Parameters.Add("@apos", SqlDbType.VarChar).Value = Txt_Apos.Text
        command.Parameters.Add("@bpos", SqlDbType.VarChar).Value = Txt_Bpos.Text
        command.Parameters.Add("@abpos", SqlDbType.VarChar).Value = Txt_ABpos.Text
        command.Parameters.Add("@oneg", SqlDbType.VarChar).Value = Txt_Oneg.Text
        command.Parameters.Add("@aneg", SqlDbType.VarChar).Value = Txt_Aneg.Text
        command.Parameters.Add("@bneg", SqlDbType.VarChar).Value = Txt_Bneg.Text
        command.Parameters.Add("@abneg", SqlDbType.VarChar).Value = Txt_ABneg.Text

        Connection.Open()

        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("New user successfully added : )")
        Else
            MessageBox.Show("Try again : (")
        End If

        Connection.Close()

    End Sub


    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class