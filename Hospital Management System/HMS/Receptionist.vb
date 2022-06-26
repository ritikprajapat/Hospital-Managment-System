Imports System.Data.SqlClient
Public Class Receptionist
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=A:\Ritik Dev\HospitalDB\HospitalDB.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        Con.Open()
        Dim query As String
        query = "insert into ReceptionistTb values(" & recepID.Text & ",'" & recepName.Text & "','" & recepPhone.Text & "','" & recepPass.Text & "')"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Con)
        cmd.ExecuteNonQuery()
        MsgBox("Receptionist Successfully Added")
        Con.Close()
        populate()
    End Sub
    Public Sub populate()
        Con.Open()
        Dim Sql = "select * from ReceptionistTb"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(Sql, Con)
        Dim builder As SqlCommandBuilder
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        ReceptionistDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub Receptionist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
    End Sub

    Private Sub Edit_Click(sender As Object, e As EventArgs) Handles Edit.Click
        If recepID.Text = "" Or recepName.Text = "" Or recepPhone.Text = "" Or recepPass.Text = "" Then
            MsgBox("Incomplete Information")
        Else
            Con.Open()
            Dim cmd As New SqlCommand("Update ReceptionistTb set RecepName ='" & recepName.Text & "', RecepPhone='" & recepPhone.Text & "', RecepPass='" & recepPass.Text & "' Where RecepID = " & recepID.Text & "", Con)
            cmd.ExecuteNonQuery()
            MsgBox("Receptionist Updated Successfully")
            Con.Close()
            populate()
        End If
    End Sub
    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        If recepID.Text = "" Then
            MsgBox("Enter The Receptionist ID")
        Else
            Con.Open()
            Dim query As String
            query = "Delete from ReceptionistTb where RecepID=" & recepID.Text & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Receptionist Delete")
            Con.Close()
            populate()
        End If
    End Sub
    Private Sub patient_Click(sender As Object, e As EventArgs) Handles patient.Click
        Dim log = New PatientForm
        log.Show()
    End Sub
    Private Sub doctor_Click(sender As Object, e As EventArgs) Handles doctor.Click
        Dim log = New DoctorForm
        log.Show()
    End Sub

    Private Sub treatment_Click(sender As Object, e As EventArgs) Handles treatment.Click
        Dim log = New TreatmentForm
        log.Show()
    End Sub

    Private Sub diagnosis_Click(sender As Object, e As EventArgs) Handles diagnosis.Click
        Dim log = New DiagnosisForm
        log.Show()
    End Sub
End Class