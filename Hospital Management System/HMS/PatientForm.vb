Imports System.Data.SqlClient
Public Class PatientForm
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=A:\Ritik Dev\HospitalDB\HospitalDB.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub Add_Click(sender As Object, e As EventArgs)
        Con.Open()
        Dim query As String
        query = "insert into PatientTb values(" & PatID.Text & ",'" & PatName.Text & "','" & PatGender.SelectedItem.ToString() & "','" & PatBlood.SelectedItem.ToString() & "','" & PatAge.Text & "','" & PatDisease.Text & "','" & PatPhone.Text & "')"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Con)
        cmd.ExecuteNonQuery()
        MsgBox("Patient Successfully Added")
        Con.Close()
        populate()
    End Sub
    Public Sub populate()
        Con.Open()
        Dim sql = "select * from PatientTb"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        PatientDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Private Sub Edit_Click(sender As Object, e As EventArgs) Handles Edit.Click
        If PatID.Text = "" Or PatName.Text = "" Or PatPhone.Text = "" Or PatAge.Text = "" Then
            MsgBox("Incomplete Information")
        Else
            Con.Open()
            Dim cmd As New SqlCommand("Update PatientTb set PatientName ='" & PatName.Text & "', PatientGender='" & PatGender.SelectedItem.ToString() & "', PatientBlood='" & PatBlood.SelectedItem.ToString() & "' Where PatientId = " & PatID.Text & "", Con)
            cmd.ExecuteNonQuery()
            MsgBox("Patient Updated Successfully")
            Con.Close()
            populate()
        End If

    End Sub
    Private Sub Delete_Click(sender As Object, e As EventArgs)
        If PatID.Text = "" Then
            MsgBox("Enter The Patient ID")
        Else
            Con.Open()
            Dim query As String
            query = "Delete from PatientTb where PatientId=" & PatID.Text & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Patient Delete")
            Con.Close()
            populate()
        End If
    End Sub

    Private Sub PatientForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
    End Sub

    Private Sub doctor_Click(sender As Object, e As EventArgs) Handles doctor.Click
        Dim log = New DoctorForm
        log.Show()
    End Sub

    Private Sub Receptionist_Click(sender As Object, e As EventArgs) Handles Receptionist.Click
        Dim log = New Receptionist
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