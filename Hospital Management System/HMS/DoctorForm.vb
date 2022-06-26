Imports System.Data.SqlClient
Public Class DoctorForm
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=A:\Ritik Dev\HospitalDB\HospitalDB.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        Con.Open()
        Dim query As String
        query = "insert into DoctorTb values(" & DocID.Text & ",'" & DocName.Text & "','" & DocGender.SelectedItem.ToString() & "', " & DocExp.Text & ", '" & DocSpec.Text & "','" & DocPass.Text & "')"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Con)
        cmd.ExecuteNonQuery()
        MsgBox("Doctor Successfully Added")
        Con.Close()
        populate()
    End Sub
    Public Sub populate()
        Con.Open()
        Dim sql = "select * from DoctorTb"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        DoctorDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub Edit_Click(sender As Object, e As EventArgs) Handles Edit.Click
        If DocID.Text = "" Or DocName.Text = "" Or DocSpec.Text = "" Or DocPass.Text = "" Then
            MsgBox("Incomplete Information")
        Else
            Con.Open()
            Dim cmd As New SqlCommand("Update DoctorTb set DoctorName ='" & DocName.Text & "', DoctorGender ='" & DocGender.SelectedItem.ToString() & "',DoctorExp =" & DocExp.Text & ",DoctorSpec ='" & DocSpec.Text & "', DoctorPass='" & DocPass.Text & "' Where DoctorID = " & DocID.Text & "", Con)
            cmd.ExecuteNonQuery()
            MsgBox("Doctor Updated Successfully")
            Con.Close()
            populate()
        End If

    End Sub
    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        If DocID.Text = "" Then
            MsgBox("Enter The Doctor ID")
        Else
            Con.Open()
            Dim query As String
            query = "Delete from DoctorTb where DoctorID=" & DocID.Text & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Doctor Delete")
            Con.Close()
            populate()
        End If
    End Sub
    Private Sub DoctorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
    End Sub
    Private Sub diagnosis_Click(sender As Object, e As EventArgs) Handles diagnosis.Click
        Dim log = New DiagnosisForm
        log.Show()
    End Sub
    Private Sub treatment_Click(sender As Object, e As EventArgs) Handles treatment.Click
        Dim log = New TreatmentForm
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
End Class