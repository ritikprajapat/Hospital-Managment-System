Imports System.Data.SqlClient
Public Class TreatmentForm
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=A:\Ritik Dev\HospitalDB\HospitalDB.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        Con.Open()
        Dim query As String
        query = " insert into TreatmentTb values(" & TreaID.Text & ",'" & TreaDesc.Text & "','" & TreaCost.Text & "')"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Con)
        cmd = New SqlCommand(query, Con)
        cmd.ExecuteNonQuery()
        MsgBox("Treatment Successfully Added")
        Con.Close()
        populate()
    End Sub
    Public Sub populate()
        Con.Open()
        Dim sql = "select * from TreatmentTb"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        TreatmentDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub TreatmentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
    End Sub
    Private Sub Edit_Click(sender As Object, e As EventArgs) Handles Edit.Click
        If TreaID.Text = "" Or TreaDesc.Text = "" Or TreaCost.Text = "" Then
            MsgBox("Incomplete Information")
        Else
            Con.Open()
            Dim cmd As New SqlCommand("Update TreatmentTb set TreatDesc ='" & TreaDesc.Text & "', TreatCost='" & TreaCost.Text & "' Where TreatID = " & TreaID.Text & "", Con)
            cmd.ExecuteNonQuery()
            MsgBox("Treatment Updated Successfully")
            Con.Close()
            populate()
        End If
    End Sub
    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        If TreaID.Text = "" Then
            MsgBox("Enter The Treament ID")
        Else
            Con.Open()
            Dim query As String
            query = "Delete from TreatmentTb where TreatID=" & TreaID.Text & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Treatment Delete")
            Con.Close()
            populate()
        End If
    End Sub
    Private Sub doctor_Click(sender As Object, e As EventArgs) Handles doctor.Click
        Dim log = New DoctorForm
        log.Show()
    End Sub
    Private Sub receptionist_Click(sender As Object, e As EventArgs) Handles receptionist.Click
        Dim log = New Receptionist
        log.Show()
    End Sub
    Private Sub patient_Click(sender As Object, e As EventArgs) Handles patient.Click
        Dim log = New PatientForm
        log.Show()
    End Sub
    Private Sub diagnosis_Click(sender As Object, e As EventArgs) Handles diagnosis.Click
        Dim log = New DiagnosisForm
        log.Show()
    End Sub
End Class