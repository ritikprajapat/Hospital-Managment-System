Imports System.Data.SqlClient
Public Class DiagnosisForm
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=A:\Ritik Dev\HospitalDB\HospitalDB.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub FillPatientCombo()
        Con.Open()
        Dim cmd As New SqlCommand("Select * From PatientTb", Con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Tb As New DataTable()
        adapter.Fill(Tb)
        PatIdCb.DataSource = Tb
        PatIdCb.DisplayMember = "PatientId"
        PatIdCb.ValueMember = "PatientId"
        Con.Close()
    End Sub
    Public Sub populate()
        Con.Open()
        Dim sql = "select * from DiagnosisTb"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        DiagnosisDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub FillTreatmentCombo()
        Con.Open()
        Dim cmd As New SqlCommand("Select * From TreatmentTb", Con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Tb As New DataTable()
        adapter.Fill(Tb)
        TreatCb.DataSource = Tb
        TreatCb.DisplayMember = "TreatDesc"
        TreatCb.ValueMember = "TreatDesc"
        Con.Close()
    End Sub
    Private Sub DiagnosisForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillPatientCombo()
        FillTreatmentCombo()
        populate()
    End Sub
    Private Sub PatId_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles PatIdCb.SelectionChangeCommitted
        Con.Open()
        Dim query = "Select * from PatientTb where PatientId = '" & PatIdCb.SelectedValue.ToString() & "'"
        Dim cmd As New SqlCommand(query, Con)
        Dim dt As New DataTable
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader
        While reader.Read
            PatName.Text = reader(1)
        End While
        Con.Close()
    End Sub
    Private Sub Treat_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles TreatCb.SelectionChangeCommitted
        Con.Open()
        Dim query = "Select * from TreatmentTb where TreatDesc = '" & TreatCb.SelectedValue.ToString() & "'"
        Dim cmd As New SqlCommand(query, Con)
        Dim dt As New DataTable
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader
        While reader.Read
            CostTb.Text = reader(2)
        End While
        Con.Close()
    End Sub
    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        Con.Open()
        Dim query As String
        query = " insert into DiagnosisTb values(" & DiagId.Text & "," & PatIdCb.SelectedValue.ToString() & ",'" & PatName.Text & "','" & Symptom.Text & "','" & DiagMed.Text & "','" & Diagnosis.Text & "','" & TreatCb.SelectedValue.ToString() & "'," & CostTb.Text & ")"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Con)
        cmd.ExecuteNonQuery()
        MsgBox("Diagnosis Successfully Added")
        Con.Close()
        populate()
    End Sub
    Private Sub Edit_Click(sender As Object, e As EventArgs) Handles Edit.Click
        If DiagId.Text = "" Or Symptom.Text = "" Or DiagMed.Text = "" Or Diagnosis.Text = "" Then
            MsgBox("Incomplete Information")
        Else
            Con.Open()
            Dim cmd As New SqlCommand("Update DiagnosisTb set PatId ='" & PatIdCb.SelectedValue.ToString() & "', PatName='" & PatName.Text & "', Symptoms='" & Symptom.Text & "', Medicines='" & DiagMed.Text & "', Diagnosis='" & Diagnosis.Text & "', Treatment ='" & TreatCb.SelectedValue.ToString() & "', Cost ='" & CostTb.Text & "' Where DiagID = " & DiagId.Text & "", Con)
            cmd.ExecuteNonQuery()
            MsgBox("Receptionist Updated Successfully")
            Con.Close()
            populate()
        End If
    End Sub
    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        If DiagId.Text = "" Then
            MsgBox("Enter The Diagnosis ID")
        Else
            Con.Open()
            Dim query As String
            query = "Delete from DiagnosisTb where DiagID=" & DiagId.Text & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Diagnosis Delete")
            Con.Close()
            populate()
        End If
    End Sub
    Private Sub receptionist_Click(sender As Object, e As EventArgs) Handles receptionist.Click
        Dim log = New Receptionist
        log.Show()
    End Sub
    Private Sub doctor_Click(sender As Object, e As EventArgs) Handles doctor.Click
        Dim log = New DoctorForm
        log.Show()
    End Sub
    Private Sub patient_Click(sender As Object, e As EventArgs) Handles patient.Click
        Dim log = New PatientForm
        log.Show()
    End Sub
    Private Sub treatment_Click(sender As Object, e As EventArgs) Handles treatment.Click
        Dim log = New TreatmentForm
        log.Show()
    End Sub

    Private Sub DiagnosisDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DiagnosisDGV.CellContentClick

    End Sub
End Class