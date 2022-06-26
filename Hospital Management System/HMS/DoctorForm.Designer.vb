<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DoctorForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DoctorForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.diagnosis = New System.Windows.Forms.Button()
        Me.treatment = New System.Windows.Forms.Button()
        Me.patient = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.receptionist = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Add = New System.Windows.Forms.Button()
        Me.Edit = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DocPass = New System.Windows.Forms.TextBox()
        Me.DocExp = New System.Windows.Forms.TextBox()
        Me.DocName = New System.Windows.Forms.TextBox()
        Me.DocSpec = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DocID = New System.Windows.Forms.TextBox()
        Me.DoctorDGV = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DocGender = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoctorDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'diagnosis
        '
        Me.diagnosis.FlatAppearance.BorderSize = 0
        Me.diagnosis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.diagnosis.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.diagnosis.Location = New System.Drawing.Point(-1, 583)
        Me.diagnosis.Name = "diagnosis"
        Me.diagnosis.Size = New System.Drawing.Size(273, 60)
        Me.diagnosis.TabIndex = 3
        Me.diagnosis.Text = "Diagnosis"
        Me.diagnosis.UseVisualStyleBackColor = True
        '
        'treatment
        '
        Me.treatment.FlatAppearance.BorderSize = 0
        Me.treatment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.treatment.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.treatment.Location = New System.Drawing.Point(-1, 494)
        Me.treatment.Name = "treatment"
        Me.treatment.Size = New System.Drawing.Size(273, 50)
        Me.treatment.TabIndex = 2
        Me.treatment.Text = "Treatments"
        Me.treatment.UseVisualStyleBackColor = True
        '
        'patient
        '
        Me.patient.FlatAppearance.BorderSize = 0
        Me.patient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.patient.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.patient.Location = New System.Drawing.Point(3, 309)
        Me.patient.Name = "patient"
        Me.patient.Size = New System.Drawing.Size(269, 57)
        Me.patient.TabIndex = 0
        Me.patient.Text = "Patients"
        Me.patient.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.diagnosis)
        Me.Panel1.Controls.Add(Me.treatment)
        Me.Panel1.Controls.Add(Me.receptionist)
        Me.Panel1.Controls.Add(Me.patient)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(273, 1033)
        Me.Panel1.TabIndex = 28
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(273, 263)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'receptionist
        '
        Me.receptionist.FlatAppearance.BorderSize = 0
        Me.receptionist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.receptionist.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.receptionist.Location = New System.Drawing.Point(-1, 396)
        Me.receptionist.Name = "receptionist"
        Me.receptionist.Size = New System.Drawing.Size(273, 58)
        Me.receptionist.TabIndex = 1
        Me.receptionist.Text = "Receptionists"
        Me.receptionist.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.BackColor = System.Drawing.Color.White
        Me.Delete.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Delete.Location = New System.Drawing.Point(688, 750)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(130, 60)
        Me.Delete.TabIndex = 26
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = False
        '
        'Add
        '
        Me.Add.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Add.Location = New System.Drawing.Point(502, 754)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(130, 60)
        Me.Add.TabIndex = 27
        Me.Add.Text = "Add"
        Me.Add.UseVisualStyleBackColor = True
        '
        'Edit
        '
        Me.Edit.BackColor = System.Drawing.Color.White
        Me.Edit.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Edit.Location = New System.Drawing.Point(323, 754)
        Me.Edit.Name = "Edit"
        Me.Edit.Size = New System.Drawing.Size(130, 60)
        Me.Edit.TabIndex = 25
        Me.Edit.Text = "Edit"
        Me.Edit.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(330, 629)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 33)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(334, 204)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 33)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Doctor_ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(330, 287)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 33)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Doctor_Name"
        '
        'DocPass
        '
        Me.DocPass.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DocPass.Location = New System.Drawing.Point(615, 624)
        Me.DocPass.Name = "DocPass"
        Me.DocPass.Size = New System.Drawing.Size(201, 39)
        Me.DocPass.TabIndex = 19
        '
        'DocExp
        '
        Me.DocExp.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DocExp.Location = New System.Drawing.Point(615, 447)
        Me.DocExp.Name = "DocExp"
        Me.DocExp.Size = New System.Drawing.Size(201, 39)
        Me.DocExp.TabIndex = 17
        '
        'DocName
        '
        Me.DocName.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DocName.Location = New System.Drawing.Point(615, 281)
        Me.DocName.Name = "DocName"
        Me.DocName.Size = New System.Drawing.Size(201, 34)
        Me.DocName.TabIndex = 16
        '
        'DocSpec
        '
        Me.DocSpec.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DocSpec.Location = New System.Drawing.Point(615, 536)
        Me.DocSpec.Name = "DocSpec"
        Me.DocSpec.Size = New System.Drawing.Size(201, 39)
        Me.DocSpec.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(329, 455)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 33)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Experience"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(329, 539)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(172, 33)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Specialisation"
        '
        'DocID
        '
        Me.DocID.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DocID.Location = New System.Drawing.Point(615, 204)
        Me.DocID.Name = "DocID"
        Me.DocID.Size = New System.Drawing.Size(201, 39)
        Me.DocID.TabIndex = 33
        '
        'DoctorDGV
        '
        Me.DoctorDGV.AllowUserToAddRows = False
        Me.DoctorDGV.AllowUserToDeleteRows = False
        Me.DoctorDGV.BackgroundColor = System.Drawing.Color.White
        Me.DoctorDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Fuchsia
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DoctorDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DoctorDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DoctorDGV.GridColor = System.Drawing.SystemColors.ControlLight
        Me.DoctorDGV.Location = New System.Drawing.Point(946, 204)
        Me.DoctorDGV.Margin = New System.Windows.Forms.Padding(2)
        Me.DoctorDGV.Name = "DoctorDGV"
        Me.DoctorDGV.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Aqua
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Lime
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DoctorDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DoctorDGV.RowHeadersWidth = 103
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DoctorDGV.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DoctorDGV.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DoctorDGV.RowTemplate.Height = 24
        Me.DoctorDGV.Size = New System.Drawing.Size(882, 606)
        Me.DoctorDGV.TabIndex = 34
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(328, 368)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 33)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Gender"
        '
        'DocGender
        '
        Me.DocGender.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DocGender.FormattingEnabled = True
        Me.DocGender.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.DocGender.Location = New System.Drawing.Point(615, 362)
        Me.DocGender.Margin = New System.Windows.Forms.Padding(2)
        Me.DocGender.Name = "DocGender"
        Me.DocGender.Size = New System.Drawing.Size(201, 39)
        Me.DocGender.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(785, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(263, 35)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "DOCTORS FORM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'DoctorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1902, 1033)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DocGender)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DoctorDGV)
        Me.Controls.Add(Me.DocID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DocSpec)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.Add)
        Me.Controls.Add(Me.Edit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DocPass)
        Me.Controls.Add(Me.DocExp)
        Me.Controls.Add(Me.DocName)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "DoctorForm"
        Me.Text = "DoctorForm"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoctorDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents diagnosis As Button
    Friend WithEvents treatment As Button
    Friend WithEvents patient As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents receptionist As Button
    Friend WithEvents Delete As Button
    Friend WithEvents Add As Button
    Friend WithEvents Edit As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DocPass As TextBox
    Friend WithEvents DocExp As TextBox
    Friend WithEvents DocName As TextBox
    Friend WithEvents DocSpec As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DocID As TextBox
    Friend WithEvents DoctorDGV As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents DocGender As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
