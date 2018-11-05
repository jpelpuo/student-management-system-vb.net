<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Staff_Options
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.detailsLName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.detailsdept = New System.Windows.Forms.Label()
        Me.detailsID = New System.Windows.Forms.Label()
        Me.detailsPost = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.detailsFName = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnGrades = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.detailsLName)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.detailsdept)
        Me.SplitContainer1.Panel2.Controls.Add(Me.detailsID)
        Me.SplitContainer1.Panel2.Controls.Add(Me.detailsPost)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.detailsFName)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label12)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnLogout)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnGrades)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnRegister)
        Me.SplitContainer1.Size = New System.Drawing.Size(773, 587)
        Me.SplitContainer1.SplitterDistance = 257
        Me.SplitContainer1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 271)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(299, 126)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "1. Check registered Students for " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     your course" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2. Upload student grade" &
    "s" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label1.Location = New System.Drawing.Point(10, 206)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 34)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Activity Options"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.StudentManagementSystem.My.Resources.Resources._200px_University_of_Ghana
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(216, 169)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'detailsLName
        '
        Me.detailsLName.AutoSize = True
        Me.detailsLName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.detailsLName.ForeColor = System.Drawing.Color.Black
        Me.detailsLName.Location = New System.Drawing.Point(293, 111)
        Me.detailsLName.Name = "detailsLName"
        Me.detailsLName.Size = New System.Drawing.Size(75, 25)
        Me.detailsLName.TabIndex = 22
        Me.detailsLName.Text = "LName"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 26)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Department"
        '
        'detailsdept
        '
        Me.detailsdept.AutoSize = True
        Me.detailsdept.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.detailsdept.Location = New System.Drawing.Point(186, 191)
        Me.detailsdept.Name = "detailsdept"
        Me.detailsdept.Size = New System.Drawing.Size(50, 25)
        Me.detailsdept.TabIndex = 23
        Me.detailsdept.Text = "dept"
        '
        'detailsID
        '
        Me.detailsID.AutoSize = True
        Me.detailsID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.detailsID.Location = New System.Drawing.Point(186, 71)
        Me.detailsID.Name = "detailsID"
        Me.detailsID.Size = New System.Drawing.Size(31, 25)
        Me.detailsID.TabIndex = 24
        Me.detailsID.Text = "ID"
        '
        'detailsPost
        '
        Me.detailsPost.AutoSize = True
        Me.detailsPost.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.detailsPost.Location = New System.Drawing.Point(186, 151)
        Me.detailsPost.Name = "detailsPost"
        Me.detailsPost.Size = New System.Drawing.Size(44, 25)
        Me.detailsPost.TabIndex = 33
        Me.detailsPost.Text = "pos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 23)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Staff ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label6.Location = New System.Drawing.Point(112, 244)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(388, 38)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Please Select An Option" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label5.Location = New System.Drawing.Point(146, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(186, 43)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Welcome"
        '
        'detailsFName
        '
        Me.detailsFName.AutoSize = True
        Me.detailsFName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.detailsFName.ForeColor = System.Drawing.Color.Black
        Me.detailsFName.Location = New System.Drawing.Point(186, 111)
        Me.detailsFName.Name = "detailsFName"
        Me.detailsFName.Size = New System.Drawing.Size(76, 25)
        Me.detailsFName.TabIndex = 21
        Me.detailsFName.Text = "FName"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 26)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Position"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(16, 109)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 26)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Name"
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Crimson
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.SystemColors.Window
        Me.btnLogout.Location = New System.Drawing.Point(137, 475)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(212, 61)
        Me.btnLogout.TabIndex = 13
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnGrades
        '
        Me.btnGrades.BackColor = System.Drawing.Color.DarkKhaki
        Me.btnGrades.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGrades.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrades.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnGrades.Location = New System.Drawing.Point(137, 390)
        Me.btnGrades.Name = "btnGrades"
        Me.btnGrades.Size = New System.Drawing.Size(212, 61)
        Me.btnGrades.TabIndex = 4
        Me.btnGrades.Text = "Upload Grades"
        Me.btnGrades.UseVisualStyleBackColor = False
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.DarkKhaki
        Me.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnRegister.Location = New System.Drawing.Point(137, 305)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(212, 61)
        Me.btnRegister.TabIndex = 3
        Me.btnRegister.Text = "Registered Students"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'Staff_Options
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(773, 587)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Staff_Options"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StaffOptions"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnGrades As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents detailsdept As Label
    Friend WithEvents detailsID As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents detailsLName As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents detailsFName As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents detailsPost As Label
End Class
