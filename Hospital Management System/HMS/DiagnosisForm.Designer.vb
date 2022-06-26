<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DiagnosisForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DiagnosisForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.receptionist = New System.Windows.Forms.Button()
        Me.patient = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.DiagId = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.doctor = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.treatment = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Add = New System.Windows.Forms.Button()
        Me.Edit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PatName = New System.Windows.Forms.TextBox()
        Me.PatIdCb = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Symptom = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DiagMed = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Diagnosis = New System.Windows.Forms.TextBox()
        Me.DiagnosisDGV = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TreatCb = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CostTb = New System.Windows.Forms.TextBox()
        Me.DigCost = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiagnosisDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'receptionist
        '
        Me.receptionist.FlatAppearance.BorderSize = 0
        Me.receptionist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.receptionist.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.receptionist.Location = New System.Drawing.Point(0, 323)
        Me.receptionist.Name = "receptionist"
        Me.receptionist.Size = New System.Drawing.Size(315, 65)
        Me.receptionist.TabIndex = 4
        Me.receptionist.Text = "Receptionists"
        Me.receptionist.UseVisualStyleBackColor = True
        '
        'patient
        '
        Me.patient.FlatAppearance.BorderSize = 0
        Me.patient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.patient.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.patient.Location = New System.Drawing.Point(-3, 521)
        Me.patient.Name = "patient"
        Me.patient.Size = New System.Drawing.Size(318, 66)
        Me.patient.TabIndex = 2
        Me.patient.Text = "Patients"
        Me.patient.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button5.Location = New System.Drawing.Point(-3, 163)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(253, 62)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = "Doctors"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'DiagId
        '
        Me.DiagId.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DiagId.Location = New System.Drawing.Point(811, 188)
        Me.DiagId.Name = "DiagId"
        Me.DiagId.Size = New System.Drawing.Size(219, 34)
        Me.DiagId.TabIndex = 82
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.doctor)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.receptionist)
        Me.Panel1.Controls.Add(Me.treatment)
        Me.Panel1.Controls.Add(Me.patient)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(316, 892)
        Me.Panel1.TabIndex = 80
        '
        'doctor
        '
        Me.doctor.FlatAppearance.BorderSize = 0
        Me.doctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.doctor.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.doctor.Location = New System.Drawing.Point(-1, 434)
        Me.doctor.Name = "doctor"
        Me.doctor.Size = New System.Drawing.Size(316, 58)
        Me.doctor.TabIndex = 32
        Me.doctor.Text = "Doctor"
        Me.doctor.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(315, 265)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'treatment
        '
        Me.treatment.FlatAppearance.BorderSize = 0
        Me.treatment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.treatment.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.treatment.Location = New System.Drawing.Point(0, 624)
        Me.treatment.Name = "treatment"
        Me.treatment.Size = New System.Drawing.Size(315, 66)
        Me.treatment.TabIndex = 3
        Me.treatment.Text = "Treatments"
        Me.treatment.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.BackColor = System.Drawing.Color.White
        Me.Delete.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Delete.Location = New System.Drawing.Point(929, 894)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(146, 57)
        Me.Delete.TabIndex = 78
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = False
        '
        'Add
        '
        Me.Add.BackColor = System.Drawing.Color.White
        Me.Add.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Add.Location = New System.Drawing.Point(728, 894)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(146, 57)
        Me.Add.TabIndex = 79
        Me.Add.Text = "Add"
        Me.Add.UseVisualStyleBackColor = False
        '
        'Edit
        '
        Me.Edit.BackColor = System.Drawing.Color.White
        Me.Edit.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Edit.Location = New System.Drawing.Point(515, 894)
        Me.Edit.Name = "Edit"
        Me.Edit.Size = New System.Drawing.Size(146, 57)
        Me.Edit.TabIndex = 77
        Me.Edit.Text = "Edit"
        Me.Edit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(1062, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(284, 35)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "DIAGNOSIS FORM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(532, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 26)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "Diagnosis_ID" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(531, 370)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 26)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "Patient_Name"
        '
        'PatName
        '
        Me.PatName.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PatName.Location = New System.Drawing.Point(811, 356)
        Me.PatName.Name = "PatName"
        Me.PatName.Size = New System.Drawing.Size(219, 34)
        Me.PatName.TabIndex = 83
        '
        'PatIdCb
        '
        Me.PatIdCb.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PatIdCb.FormattingEnabled = True
        Me.PatIdCb.Location = New System.Drawing.Point(811, 276)
        Me.PatIdCb.Name = "PatIdCb"
        Me.PatIdCb.Size = New System.Drawing.Size(219, 30)
        Me.PatIdCb.TabIndex = 85
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(531, 458)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 26)
        Me.Label5.TabIndex = 87
        Me.Label5.Text = "Symptoms"
        '
        'Symptom
        '
        Me.Symptom.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Symptom.Location = New System.Drawing.Point(811, 448)
        Me.Symptom.Name = "Symptom"
        Me.Symptom.Size = New System.Drawing.Size(219, 34)
        Me.Symptom.TabIndex = 86
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(532, 537)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 26)
        Me.Label6.TabIndex = 89
        Me.Label6.Text = "Medicines"
        '
        'DiagMed
        '
        Me.DiagMed.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DiagMed.Location = New System.Drawing.Point(811, 537)
        Me.DiagMed.Name = "DiagMed"
        Me.DiagMed.Size = New System.Drawing.Size(219, 34)
        Me.DiagMed.TabIndex = 88
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(530, 629)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 26)
        Me.Label7.TabIndex = 91
        Me.Label7.Text = "Diagnosis"
        '
        'Diagnosis
        '
        Me.Diagnosis.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Diagnosis.Location = New System.Drawing.Point(811, 629)
        Me.Diagnosis.Name = "Diagnosis"
        Me.Diagnosis.Size = New System.Drawing.Size(219, 34)
        Me.Diagnosis.TabIndex = 90
        '
        'DiagnosisDGV
        '
        Me.DiagnosisDGV.AllowUserToAddRows = False
        Me.DiagnosisDGV.AllowUserToDeleteRows = False
        Me.DiagnosisDGV.BackgroundColor = System.Drawing.Color.White
        Me.DiagnosisDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Fuchsia
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DiagnosisDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DiagnosisDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DiagnosisDGV.GridColor = System.Drawing.SystemColors.ControlLight
        Me.DiagnosisDGV.Location = New System.Drawing.Point(1132, 188)
        Me.DiagnosisDGV.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DiagnosisDGV.Name = "DiagnosisDGV"
        Me.DiagnosisDGV.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Aqua
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Lime
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DiagnosisDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DiagnosisDGV.RowHeadersWidth = 103
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DiagnosisDGV.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DiagnosisDGV.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DiagnosisDGV.RowTemplate.Height = 24
        Me.DiagnosisDGV.Size = New System.Drawing.Size(945, 763)
        Me.DiagnosisDGV.TabIndex = 92
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(532, 282)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 26)
        Me.Label4.TabIndex = 93
        Me.Label4.Text = "Patient_ID"
        '
        'TreatCb
        '
        Me.TreatCb.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TreatCb.FormattingEnabled = True
        Me.TreatCb.Location = New System.Drawing.Point(811, 714)
        Me.TreatCb.Name = "TreatCb"
        Me.TreatCb.Size = New System.Drawing.Size(219, 30)
        Me.TreatCb.TabIndex = 94
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(531, 714)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 26)
        Me.Label8.TabIndex = 95
        Me.Label8.Text = "Treatment"
        '
        'CostTb
        '
        Me.CostTb.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CostTb.Location = New System.Drawing.Point(811, 800)
        Me.CostTb.Name = "CostTb"
        Me.CostTb.Size = New System.Drawing.Size(219, 34)
        Me.CostTb.TabIndex = 96
        '
        'DigCost
        '
        Me.DigCost.AutoSize = True
        Me.DigCost.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DigCost.Location = New System.Drawing.Point(531, 803)
        Me.DigCost.Name = "DigCost"
        Me.DigCost.Size = New System.Drawing.Size(54, 26)
        Me.DigCost.TabIndex = 97
        Me.DigCost.Text = "Cost"
        '
        'DiagnosisForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1556, 892)
        Me.Controls.Add(Me.DigCost)
        Me.Controls.Add(Me.CostTb)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TreatCb)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DiagnosisDGV)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Diagnosis)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DiagMed)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Symptom)
        Me.Controls.Add(Me.PatIdCb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PatName)
        Me.Controls.Add(Me.DiagId)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.Add)
        Me.Controls.Add(Me.Edit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "DiagnosisForm"
        Me.Text = " "
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiagnosisDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents receptionist As Button
    Friend WithEvents patient As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents DiagId As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Delete As Button
    Friend WithEvents Add As Button
    Friend WithEvents Edit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PatName As TextBox
    Friend WithEvents PatIdCb As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Symptom As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DiagMed As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Diagnosis As TextBox
    Friend WithEvents treatment As Button
    Friend WithEvents DiagnosisDGV As DataGridView
    Friend WithEvents doctor As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TreatCb As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents CostTb As TextBox
    Friend WithEvents DigCost As Label
End Class
