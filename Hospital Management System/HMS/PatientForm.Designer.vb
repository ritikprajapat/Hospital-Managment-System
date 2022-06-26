<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PatientForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PatID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PatDisease = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Receptionist = New System.Windows.Forms.Button()
        Me.diagnosis = New System.Windows.Forms.Button()
        Me.treatment = New System.Windows.Forms.Button()
        Me.doctor = New System.Windows.Forms.Button()
        Me.Edit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PatPhone = New System.Windows.Forms.TextBox()
        Me.PatAge = New System.Windows.Forms.TextBox()
        Me.PatName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PatBlood = New System.Windows.Forms.ComboBox()
        Me.pat = New System.Windows.Forms.Label()
        Me.PatGender = New System.Windows.Forms.ComboBox()
        Me.blood = New System.Windows.Forms.Label()
        Me.PatientDGV = New System.Windows.Forms.DataGridView()
        Me.Add = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PatID
        '
        Me.PatID.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PatID.Location = New System.Drawing.Point(665, 195)
        Me.PatID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PatID.Name = "PatID"
        Me.PatID.Size = New System.Drawing.Size(195, 39)
        Me.PatID.TabIndex = 52
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(392, 708)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 33)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Disease"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(392, 595)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 33)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Age"
        '
        'PatDisease
        '
        Me.PatDisease.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PatDisease.Location = New System.Drawing.Point(665, 704)
        Me.PatDisease.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PatDisease.Name = "PatDisease"
        Me.PatDisease.Size = New System.Drawing.Size(195, 39)
        Me.PatDisease.TabIndex = 48
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Receptionist)
        Me.Panel1.Controls.Add(Me.diagnosis)
        Me.Panel1.Controls.Add(Me.treatment)
        Me.Panel1.Controls.Add(Me.doctor)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(252, 1055)
        Me.Panel1.TabIndex = 47
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(251, 250)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'Receptionist
        '
        Me.Receptionist.FlatAppearance.BorderSize = 0
        Me.Receptionist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Receptionist.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Receptionist.Location = New System.Drawing.Point(0, 468)
        Me.Receptionist.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Receptionist.Name = "Receptionist"
        Me.Receptionist.Size = New System.Drawing.Size(251, 66)
        Me.Receptionist.TabIndex = 4
        Me.Receptionist.Text = "Receptionists"
        Me.Receptionist.UseVisualStyleBackColor = True
        '
        'diagnosis
        '
        Me.diagnosis.FlatAppearance.BorderSize = 0
        Me.diagnosis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.diagnosis.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.diagnosis.Location = New System.Drawing.Point(0, 702)
        Me.diagnosis.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.diagnosis.Name = "diagnosis"
        Me.diagnosis.Size = New System.Drawing.Size(251, 66)
        Me.diagnosis.TabIndex = 3
        Me.diagnosis.Text = "Diagnosis"
        Me.diagnosis.UseVisualStyleBackColor = True
        '
        'treatment
        '
        Me.treatment.FlatAppearance.BorderSize = 0
        Me.treatment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.treatment.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.treatment.Location = New System.Drawing.Point(-1, 592)
        Me.treatment.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.treatment.Name = "treatment"
        Me.treatment.Size = New System.Drawing.Size(252, 66)
        Me.treatment.TabIndex = 2
        Me.treatment.Text = "Treatments"
        Me.treatment.UseVisualStyleBackColor = True
        '
        'doctor
        '
        Me.doctor.FlatAppearance.BorderSize = 0
        Me.doctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.doctor.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.doctor.Location = New System.Drawing.Point(-1, 345)
        Me.doctor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.doctor.Name = "doctor"
        Me.doctor.Size = New System.Drawing.Size(252, 66)
        Me.doctor.TabIndex = 1
        Me.doctor.Text = "Doctors"
        Me.doctor.UseVisualStyleBackColor = True
        '
        'Edit
        '
        Me.Edit.BackColor = System.Drawing.Color.White
        Me.Edit.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Edit.Location = New System.Drawing.Point(396, 960)
        Me.Edit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Edit.Name = "Edit"
        Me.Edit.Size = New System.Drawing.Size(130, 60)
        Me.Edit.TabIndex = 44
        Me.Edit.Text = "Edit"
        Me.Edit.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(392, 306)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 33)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Patient_Name"
        '
        'PatPhone
        '
        Me.PatPhone.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PatPhone.Location = New System.Drawing.Point(665, 810)
        Me.PatPhone.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PatPhone.Name = "PatPhone"
        Me.PatPhone.Size = New System.Drawing.Size(195, 39)
        Me.PatPhone.TabIndex = 37
        '
        'PatAge
        '
        Me.PatAge.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PatAge.Location = New System.Drawing.Point(665, 591)
        Me.PatAge.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PatAge.Name = "PatAge"
        Me.PatAge.Size = New System.Drawing.Size(195, 39)
        Me.PatAge.TabIndex = 36
        '
        'PatName
        '
        Me.PatName.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PatName.Location = New System.Drawing.Point(665, 302)
        Me.PatName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PatName.Name = "PatName"
        Me.PatName.Size = New System.Drawing.Size(195, 39)
        Me.PatName.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(990, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 35)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "PATIENT FORM"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(392, 814)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 33)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Phone_No"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(392, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 33)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Patient_ID"
        '
        'PatBlood
        '
        Me.PatBlood.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PatBlood.FormattingEnabled = True
        Me.PatBlood.Items.AddRange(New Object() {"A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-"})
        Me.PatBlood.Location = New System.Drawing.Point(665, 498)
        Me.PatBlood.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PatBlood.Name = "PatBlood"
        Me.PatBlood.Size = New System.Drawing.Size(195, 39)
        Me.PatBlood.TabIndex = 53
        '
        'pat
        '
        Me.pat.AutoSize = True
        Me.pat.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.pat.Location = New System.Drawing.Point(392, 410)
        Me.pat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.pat.Name = "pat"
        Me.pat.Size = New System.Drawing.Size(95, 33)
        Me.pat.TabIndex = 54
        Me.pat.Text = "Gender"
        '
        'PatGender
        '
        Me.PatGender.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PatGender.FormattingEnabled = True
        Me.PatGender.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.PatGender.Location = New System.Drawing.Point(665, 406)
        Me.PatGender.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PatGender.Name = "PatGender"
        Me.PatGender.Size = New System.Drawing.Size(195, 39)
        Me.PatGender.TabIndex = 55
        '
        'blood
        '
        Me.blood.AutoSize = True
        Me.blood.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.blood.Location = New System.Drawing.Point(392, 501)
        Me.blood.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.blood.Name = "blood"
        Me.blood.Size = New System.Drawing.Size(161, 33)
        Me.blood.TabIndex = 56
        Me.blood.Text = "Blood Group"
        '
        'PatientDGV
        '
        Me.PatientDGV.AllowUserToAddRows = False
        Me.PatientDGV.AllowUserToDeleteRows = False
        Me.PatientDGV.BackgroundColor = System.Drawing.Color.White
        Me.PatientDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Fuchsia
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PatientDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.PatientDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PatientDGV.GridColor = System.Drawing.SystemColors.ControlLight
        Me.PatientDGV.Location = New System.Drawing.Point(907, 195)
        Me.PatientDGV.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PatientDGV.Name = "PatientDGV"
        Me.PatientDGV.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Aqua
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Lime
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PatientDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.PatientDGV.RowHeadersWidth = 103
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PatientDGV.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.PatientDGV.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PatientDGV.RowTemplate.Height = 24
        Me.PatientDGV.Size = New System.Drawing.Size(953, 654)
        Me.PatientDGV.TabIndex = 57
        '
        'Add
        '
        Me.Add.BackColor = System.Drawing.Color.White
        Me.Add.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Add.Location = New System.Drawing.Point(565, 960)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(130, 60)
        Me.Add.TabIndex = 58
        Me.Add.Text = "Add"
        Me.Add.UseVisualStyleBackColor = False
        '
        'Delete
        '
        Me.Delete.BackColor = System.Drawing.Color.White
        Me.Delete.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Delete.Location = New System.Drawing.Point(741, 960)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(130, 60)
        Me.Delete.TabIndex = 59
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = False
        '
        'PatientForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1902, 1055)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.Add)
        Me.Controls.Add(Me.PatientDGV)
        Me.Controls.Add(Me.blood)
        Me.Controls.Add(Me.PatGender)
        Me.Controls.Add(Me.pat)
        Me.Controls.Add(Me.PatBlood)
        Me.Controls.Add(Me.PatID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PatDisease)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Edit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PatPhone)
        Me.Controls.Add(Me.PatAge)
        Me.Controls.Add(Me.PatName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "PatientForm"
        Me.Text = "PatientForm"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PatID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PatDisease As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents diagnosis As Button
    Friend WithEvents treatment As Button
    Friend WithEvents doctor As Button
    Friend WithEvents Edit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PatPhone As TextBox
    Friend WithEvents PatAge As TextBox
    Friend WithEvents PatName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Receptionist As Button
    Friend WithEvents PatBlood As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pat As Label
    Friend WithEvents PatGender As ComboBox
    Friend WithEvents blood As Label
    Friend WithEvents PatientDGV As DataGridView
    Friend WithEvents Add As Button
    Friend WithEvents Delete As Button
End Class
