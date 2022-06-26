<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TreatmentForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TreatmentForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.receptionist = New System.Windows.Forms.Button()
        Me.diagnosis = New System.Windows.Forms.Button()
        Me.patient = New System.Windows.Forms.Button()
        Me.doctor = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Add = New System.Windows.Forms.Button()
        Me.Edit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TreaID = New System.Windows.Forms.TextBox()
        Me.TreaDesc = New System.Windows.Forms.TextBox()
        Me.TreaCost = New System.Windows.Forms.TextBox()
        Me.TreatmentDGV = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TreatmentDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'receptionist
        '
        Me.receptionist.FlatAppearance.BorderSize = 0
        Me.receptionist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.receptionist.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.receptionist.Location = New System.Drawing.Point(0, 449)
        Me.receptionist.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.receptionist.Name = "receptionist"
        Me.receptionist.Size = New System.Drawing.Size(291, 66)
        Me.receptionist.TabIndex = 4
        Me.receptionist.Text = "Receptionists"
        Me.receptionist.UseVisualStyleBackColor = True
        '
        'diagnosis
        '
        Me.diagnosis.FlatAppearance.BorderSize = 0
        Me.diagnosis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.diagnosis.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.diagnosis.Location = New System.Drawing.Point(0, 662)
        Me.diagnosis.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.diagnosis.Name = "diagnosis"
        Me.diagnosis.Size = New System.Drawing.Size(291, 66)
        Me.diagnosis.TabIndex = 3
        Me.diagnosis.Text = "Diagnosis"
        Me.diagnosis.UseVisualStyleBackColor = True
        '
        'patient
        '
        Me.patient.FlatAppearance.BorderSize = 0
        Me.patient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.patient.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.patient.Location = New System.Drawing.Point(0, 559)
        Me.patient.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.patient.Name = "patient"
        Me.patient.Size = New System.Drawing.Size(288, 66)
        Me.patient.TabIndex = 2
        Me.patient.Text = "Patients"
        Me.patient.UseVisualStyleBackColor = True
        '
        'doctor
        '
        Me.doctor.FlatAppearance.BorderSize = 0
        Me.doctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.doctor.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.doctor.Location = New System.Drawing.Point(-3, 335)
        Me.doctor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.doctor.Name = "doctor"
        Me.doctor.Size = New System.Drawing.Size(291, 66)
        Me.doctor.TabIndex = 1
        Me.doctor.Text = "Doctors"
        Me.doctor.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(474, 645)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 33)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Cost"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.receptionist)
        Me.Panel1.Controls.Add(Me.diagnosis)
        Me.Panel1.Controls.Add(Me.patient)
        Me.Panel1.Controls.Add(Me.doctor)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(291, 1055)
        Me.Panel1.TabIndex = 65
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-3, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(294, 290)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'Delete
        '
        Me.Delete.BackColor = System.Drawing.Color.White
        Me.Delete.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Delete.Location = New System.Drawing.Point(884, 812)
        Me.Delete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(130, 60)
        Me.Delete.TabIndex = 63
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = False
        '
        'Add
        '
        Me.Add.BackColor = System.Drawing.Color.White
        Me.Add.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Add.Location = New System.Drawing.Point(686, 812)
        Me.Add.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(130, 60)
        Me.Add.TabIndex = 64
        Me.Add.Text = "Add"
        Me.Add.UseVisualStyleBackColor = False
        '
        'Edit
        '
        Me.Edit.BackColor = System.Drawing.Color.White
        Me.Edit.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Edit.Location = New System.Drawing.Point(478, 812)
        Me.Edit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Edit.Name = "Edit"
        Me.Edit.Size = New System.Drawing.Size(130, 60)
        Me.Edit.TabIndex = 62
        Me.Edit.Text = "Edit"
        Me.Edit.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(474, 484)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 33)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Description"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(878, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(305, 35)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "TREATMENT FORM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(472, 314)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 33)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Treatment_ID"
        '
        'TreaID
        '
        Me.TreaID.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TreaID.Location = New System.Drawing.Point(818, 318)
        Me.TreaID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TreaID.Name = "TreaID"
        Me.TreaID.Size = New System.Drawing.Size(195, 39)
        Me.TreaID.TabIndex = 69
        '
        'TreaDesc
        '
        Me.TreaDesc.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TreaDesc.Location = New System.Drawing.Point(818, 480)
        Me.TreaDesc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TreaDesc.Name = "TreaDesc"
        Me.TreaDesc.Size = New System.Drawing.Size(195, 39)
        Me.TreaDesc.TabIndex = 70
        '
        'TreaCost
        '
        Me.TreaCost.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TreaCost.Location = New System.Drawing.Point(818, 641)
        Me.TreaCost.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TreaCost.Name = "TreaCost"
        Me.TreaCost.Size = New System.Drawing.Size(195, 39)
        Me.TreaCost.TabIndex = 71
        '
        'TreatmentDGV
        '
        Me.TreatmentDGV.AllowUserToAddRows = False
        Me.TreatmentDGV.AllowUserToDeleteRows = False
        Me.TreatmentDGV.BackgroundColor = System.Drawing.Color.White
        Me.TreatmentDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Fuchsia
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TreatmentDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.TreatmentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TreatmentDGV.GridColor = System.Drawing.SystemColors.ControlLight
        Me.TreatmentDGV.Location = New System.Drawing.Point(1146, 314)
        Me.TreatmentDGV.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TreatmentDGV.Name = "TreatmentDGV"
        Me.TreatmentDGV.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Aqua
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Lime
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TreatmentDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.TreatmentDGV.RowHeadersWidth = 103
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TreatmentDGV.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.TreatmentDGV.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TreatmentDGV.RowTemplate.Height = 24
        Me.TreatmentDGV.Size = New System.Drawing.Size(640, 558)
        Me.TreatmentDGV.TabIndex = 72
        '
        'TreatmentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1902, 1055)
        Me.Controls.Add(Me.TreatmentDGV)
        Me.Controls.Add(Me.TreaCost)
        Me.Controls.Add(Me.TreaDesc)
        Me.Controls.Add(Me.TreaID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.Add)
        Me.Controls.Add(Me.Edit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "TreatmentForm"
        Me.Text = "TreatmentForm"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TreatmentDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents receptionist As Button
    Friend WithEvents diagnosis As Button
    Friend WithEvents patient As Button
    Friend WithEvents doctor As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Delete As Button
    Friend WithEvents Add As Button
    Friend WithEvents Edit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TreaID As TextBox
    Friend WithEvents TreaDesc As TextBox
    Friend WithEvents TreaCost As TextBox
    Friend WithEvents TreatmentDGV As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
End Class
