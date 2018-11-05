<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Student_Options
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.stdLvl = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.stdID = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.stdLName = New System.Windows.Forms.Label()
        Me.stdName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnClass = New System.Windows.Forms.Button()
        Me.btnGPA = New System.Windows.Forms.Button()
        Me.btnGrades = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.stdLvl)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.stdID)
        Me.SplitContainer1.Panel1.Controls.Add(Me.stdLName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.stdName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label8)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnLogout)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnClass)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnGPA)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnGrades)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnRegister)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Size = New System.Drawing.Size(707, 544)
        Me.SplitContainer1.SplitterDistance = 287
        Me.SplitContainer1.TabIndex = 0
        '
        'stdLvl
        '
        Me.stdLvl.AutoSize = True
        Me.stdLvl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stdLvl.Location = New System.Drawing.Point(97, 272)
        Me.stdLvl.Name = "stdLvl"
        Me.stdLvl.Size = New System.Drawing.Size(30, 25)
        Me.stdLvl.TabIndex = 19
        Me.stdLvl.Text = "lvl"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(15, 200)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 23)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "ID No: "
        '
        'stdID
        '
        Me.stdID.AutoSize = True
        Me.stdID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stdID.Location = New System.Drawing.Point(97, 200)
        Me.stdID.Name = "stdID"
        Me.stdID.Size = New System.Drawing.Size(31, 25)
        Me.stdID.TabIndex = 20
        Me.stdID.Text = "ID"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 271)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 26)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Level:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(14, 234)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 26)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Name:"
        '
        'stdLName
        '
        Me.stdLName.AutoSize = True
        Me.stdLName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stdLName.ForeColor = System.Drawing.Color.Black
        Me.stdLName.Location = New System.Drawing.Point(179, 236)
        Me.stdLName.Name = "stdLName"
        Me.stdLName.Size = New System.Drawing.Size(75, 25)
        Me.stdLName.TabIndex = 21
        Me.stdLName.Text = "LName"
        '
        'stdName
        '
        Me.stdName.AutoSize = True
        Me.stdName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stdName.ForeColor = System.Drawing.Color.Black
        Me.stdName.Location = New System.Drawing.Point(97, 236)
        Me.stdName.Name = "stdName"
        Me.stdName.Size = New System.Drawing.Size(76, 25)
        Me.stdName.TabIndex = 18
        Me.stdName.Text = "FName"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 367)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 168)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "1. Register" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2. Check Grades" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3. Calculate GPA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "4. Classification" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label1.Location = New System.Drawing.Point(26, 324)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 34)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Activity Options"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.StudentManagementSystem.My.Resources.Resources._200px_University_of_Ghana
        Me.PictureBox1.Location = New System.Drawing.Point(19, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(216, 169)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label6.Location = New System.Drawing.Point(154, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 30)
        Me.Label6.TabIndex = 8
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Crimson
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.SystemColors.Window
        Me.btnLogout.Location = New System.Drawing.Point(120, 434)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(173, 61)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label5.Location = New System.Drawing.Point(148, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 30)
        Me.Label5.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label4.Location = New System.Drawing.Point(145, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(186, 43)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Welcome"
        '
        'btnClass
        '
        Me.btnClass.BackColor = System.Drawing.Color.DarkKhaki
        Me.btnClass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClass.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClass.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnClass.Location = New System.Drawing.Point(120, 353)
        Me.btnClass.Name = "btnClass"
        Me.btnClass.Size = New System.Drawing.Size(173, 61)
        Me.btnClass.TabIndex = 4
        Me.btnClass.Text = "Classification"
        Me.btnClass.UseVisualStyleBackColor = False
        '
        'btnGPA
        '
        Me.btnGPA.BackColor = System.Drawing.Color.DarkKhaki
        Me.btnGPA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGPA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGPA.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGPA.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnGPA.Location = New System.Drawing.Point(120, 272)
        Me.btnGPA.Name = "btnGPA"
        Me.btnGPA.Size = New System.Drawing.Size(173, 61)
        Me.btnGPA.TabIndex = 3
        Me.btnGPA.Text = "Calculate GPA"
        Me.btnGPA.UseVisualStyleBackColor = False
        '
        'btnGrades
        '
        Me.btnGrades.BackColor = System.Drawing.Color.DarkKhaki
        Me.btnGrades.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGrades.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrades.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnGrades.Location = New System.Drawing.Point(120, 191)
        Me.btnGrades.Name = "btnGrades"
        Me.btnGrades.Size = New System.Drawing.Size(173, 61)
        Me.btnGrades.TabIndex = 2
        Me.btnGrades.Text = "Check Grades"
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
        Me.btnRegister.Location = New System.Drawing.Point(120, 110)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(173, 61)
        Me.btnRegister.TabIndex = 1
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label3.Location = New System.Drawing.Point(84, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(342, 34)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Please Select An Option" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Student_Options
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(707, 544)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Student_Options"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Options"
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
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnClass As Button
    Friend WithEvents btnGPA As Button
    Friend WithEvents btnGrades As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents stdID As Label
    Friend WithEvents stdLvl As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents stdName As Label
    Friend WithEvents stdLName As Label
End Class
