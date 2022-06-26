<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Receptionist
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Receptionist))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.diagnosis = New System.Windows.Forms.Button()
        Me.treatment = New System.Windows.Forms.Button()
        Me.patient = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.doctor = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Add = New System.Windows.Forms.Button()
        Me.Edit = New System.Windows.Forms.Button()
        Me.Recep_Phone = New System.Windows.Forms.Label()
        Me.Recep_Pass = New System.Windows.Forms.Label()
        Me.Recep_ID = New System.Windows.Forms.Label()
        Me.Recep_Name = New System.Windows.Forms.Label()
        Me.recepPass = New System.Windows.Forms.TextBox()
        Me.recepPhone = New System.Windows.Forms.TextBox()
        Me.recepName = New System.Windows.Forms.TextBox()
        Me.recepID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReceptionistDGV = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceptionistDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'diagnosis
        '
        Me.diagnosis.FlatAppearance.BorderSize = 0
        Me.diagnosis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.diagnosis.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.diagnosis.Location = New System.Drawing.Point(-2, 734)
        Me.diagnosis.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.diagnosis.Name = "diagnosis"
        Me.diagnosis.Size = New System.Drawing.Size(284, 62)
        Me.diagnosis.TabIndex = 3
        Me.diagnosis.Text = "Diagnosis"
        Me.diagnosis.UseVisualStyleBackColor = True
        '
        'treatment
        '
        Me.treatment.FlatAppearance.BorderSize = 0
        Me.treatment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.treatment.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.treatment.Location = New System.Drawing.Point(0, 604)
        Me.treatment.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.treatment.Name = "treatment"
        Me.treatment.Size = New System.Drawing.Size(282, 62)
        Me.treatment.TabIndex = 2
        Me.treatment.Text = "Treatments"
        Me.treatment.UseVisualStyleBackColor = True
        '
        'patient
        '
        Me.patient.FlatAppearance.BorderSize = 0
        Me.patient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.patient.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.patient.Location = New System.Drawing.Point(-1, 341)
        Me.patient.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.patient.Name = "patient"
        Me.patient.Size = New System.Drawing.Size(283, 62)
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
        Me.Panel1.Controls.Add(Me.doctor)
        Me.Panel1.Controls.Add(Me.patient)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(283, 1055)
        Me.Panel1.TabIndex = 28
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(283, 282)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'doctor
        '
        Me.doctor.FlatAppearance.BorderSize = 0
        Me.doctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.doctor.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.doctor.Location = New System.Drawing.Point(-2, 469)
        Me.doctor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.doctor.Name = "doctor"
        Me.doctor.Size = New System.Drawing.Size(284, 84)
        Me.doctor.TabIndex = 1
        Me.doctor.Text = "Doctors"
        Me.doctor.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.BackColor = System.Drawing.Color.White
        Me.Delete.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Delete.Location = New System.Drawing.Point(886, 821)
        Me.Delete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(130, 60)
        Me.Delete.TabIndex = 26
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = False
        '
        'Add
        '
        Me.Add.BackColor = System.Drawing.Color.White
        Me.Add.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Add.Location = New System.Drawing.Point(666, 821)
        Me.Add.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(130, 60)
        Me.Add.TabIndex = 27
        Me.Add.Text = "Add"
        Me.Add.UseVisualStyleBackColor = False
        '
        'Edit
        '
        Me.Edit.BackColor = System.Drawing.Color.White
        Me.Edit.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Edit.Location = New System.Drawing.Point(464, 821)
        Me.Edit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Edit.Name = "Edit"
        Me.Edit.Size = New System.Drawing.Size(130, 60)
        Me.Edit.TabIndex = 25
        Me.Edit.Text = "Edit"
        Me.Edit.UseVisualStyleBackColor = False
        '
        'Recep_Phone
        '
        Me.Recep_Phone.AutoSize = True
        Me.Recep_Phone.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Recep_Phone.Location = New System.Drawing.Point(460, 574)
        Me.Recep_Phone.Name = "Recep_Phone"
        Me.Recep_Phone.Size = New System.Drawing.Size(133, 33)
        Me.Recep_Phone.TabIndex = 23
        Me.Recep_Phone.Text = "Phone_No"
        '
        'Recep_Pass
        '
        Me.Recep_Pass.AutoSize = True
        Me.Recep_Pass.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Recep_Pass.Location = New System.Drawing.Point(460, 689)
        Me.Recep_Pass.Name = "Recep_Pass"
        Me.Recep_Pass.Size = New System.Drawing.Size(121, 33)
        Me.Recep_Pass.TabIndex = 22
        Me.Recep_Pass.Text = "Password"
        '
        'Recep_ID
        '
        Me.Recep_ID.AutoSize = True
        Me.Recep_ID.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Recep_ID.Location = New System.Drawing.Point(460, 329)
        Me.Recep_ID.Name = "Recep_ID"
        Me.Recep_ID.Size = New System.Drawing.Size(197, 33)
        Me.Recep_ID.TabIndex = 21
        Me.Recep_ID.Text = "Receptionist_ID"
        '
        'Recep_Name
        '
        Me.Recep_Name.AutoSize = True
        Me.Recep_Name.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Recep_Name.Location = New System.Drawing.Point(460, 450)
        Me.Recep_Name.Name = "Recep_Name"
        Me.Recep_Name.Size = New System.Drawing.Size(233, 33)
        Me.Recep_Name.TabIndex = 20
        Me.Recep_Name.Text = "Receptionist_Name"
        '
        'recepPass
        '
        Me.recepPass.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.recepPass.Location = New System.Drawing.Point(831, 681)
        Me.recepPass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.recepPass.Name = "recepPass"
        Me.recepPass.Size = New System.Drawing.Size(170, 39)
        Me.recepPass.TabIndex = 19
        '
        'recepPhone
        '
        Me.recepPhone.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.recepPhone.Location = New System.Drawing.Point(831, 566)
        Me.recepPhone.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.recepPhone.Name = "recepPhone"
        Me.recepPhone.Size = New System.Drawing.Size(170, 39)
        Me.recepPhone.TabIndex = 18
        '
        'recepName
        '
        Me.recepName.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.recepName.Location = New System.Drawing.Point(831, 442)
        Me.recepName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.recepName.Name = "recepName"
        Me.recepName.Size = New System.Drawing.Size(170, 39)
        Me.recepName.TabIndex = 17
        '
        'recepID
        '
        Me.recepID.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.recepID.Location = New System.Drawing.Point(831, 321)
        Me.recepID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.recepID.Name = "recepID"
        Me.recepID.Size = New System.Drawing.Size(170, 39)
        Me.recepID.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(928, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 37)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "RECEPTIONISTS"
        '
        'ReceptionistDGV
        '
        Me.ReceptionistDGV.AllowUserToAddRows = False
        Me.ReceptionistDGV.AllowUserToDeleteRows = False
        Me.ReceptionistDGV.BackgroundColor = System.Drawing.Color.White
        Me.ReceptionistDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Fuchsia
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ReceptionistDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ReceptionistDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReceptionistDGV.GridColor = System.Drawing.SystemColors.ControlLight
        Me.ReceptionistDGV.Location = New System.Drawing.Point(1124, 321)
        Me.ReceptionistDGV.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ReceptionistDGV.Name = "ReceptionistDGV"
        Me.ReceptionistDGV.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Aqua
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Lime
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ReceptionistDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.ReceptionistDGV.RowHeadersWidth = 103
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ReceptionistDGV.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.ReceptionistDGV.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ReceptionistDGV.RowTemplate.Height = 24
        Me.ReceptionistDGV.Size = New System.Drawing.Size(673, 562)
        Me.ReceptionistDGV.TabIndex = 29
        '
        'Receptionist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1902, 1055)
        Me.Controls.Add(Me.ReceptionistDGV)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.Add)
        Me.Controls.Add(Me.Edit)
        Me.Controls.Add(Me.Recep_Phone)
        Me.Controls.Add(Me.Recep_Pass)
        Me.Controls.Add(Me.Recep_ID)
        Me.Controls.Add(Me.Recep_Name)
        Me.Controls.Add(Me.recepPass)
        Me.Controls.Add(Me.recepPhone)
        Me.Controls.Add(Me.recepName)
        Me.Controls.Add(Me.recepID)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Receptionist"
        Me.Text = "Receptionist"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceptionistDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents diagnosis As Button
    Friend WithEvents treatment As Button
    Friend WithEvents patient As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents doctor As Button
    Friend WithEvents Delete As Button
    Friend WithEvents Add As Button
    Friend WithEvents Edit As Button
    Friend WithEvents Recep_Phone As Label
    Friend WithEvents Recep_Pass As Label
    Friend WithEvents Recep_ID As Label
    Friend WithEvents Recep_Name As Label
    Friend WithEvents recepPass As TextBox
    Friend WithEvents recepPhone As TextBox
    Friend WithEvents recepName As TextBox
    Friend WithEvents recepID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ReceptionistDGV As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
End Class
