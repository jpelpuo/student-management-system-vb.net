<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Calculate_GPA
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.stdLvl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.StdLName = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.stdID = New System.Windows.Forms.Label()
        Me.StdName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnGPA = New System.Windows.Forms.Button()
        Me.studGPA = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnStdClose = New System.Windows.Forms.Button()
        Me.gradesview = New System.Windows.Forms.DataGridView()
        Me.allSems = New System.Windows.Forms.RadioButton()
        Me.rdSecSEM = New System.Windows.Forms.RadioButton()
        Me.rdFSEM = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gradesview, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.StdLName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.stdID)
        Me.SplitContainer1.Panel1.Controls.Add(Me.StdName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnGPA)
        Me.SplitContainer1.Panel2.Controls.Add(Me.studGPA)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnStdClose)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gradesview)
        Me.SplitContainer1.Panel2.Controls.Add(Me.allSems)
        Me.SplitContainer1.Panel2.Controls.Add(Me.rdSecSEM)
        Me.SplitContainer1.Panel2.Controls.Add(Me.rdFSEM)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Size = New System.Drawing.Size(923, 600)
        Me.SplitContainer1.SplitterDistance = 307
        Me.SplitContainer1.TabIndex = 0
        '
        'stdLvl
        '
        Me.stdLvl.AutoSize = True
        Me.stdLvl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stdLvl.Location = New System.Drawing.Point(104, 256)
        Me.stdLvl.Name = "stdLvl"
        Me.stdLvl.Size = New System.Drawing.Size(30, 25)
        Me.stdLvl.TabIndex = 22
        Me.stdLvl.Text = "lvl"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 347)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(319, 276)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "To Calculate GPA:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1. Select Semester" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2.The Table Displays the Grades" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   fo" &
    "r the chosen semester" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3. Click GPA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "4. GPA appears at GPA area" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 23)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "ID No: "
        '
        'StdLName
        '
        Me.StdLName.AutoSize = True
        Me.StdLName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StdLName.ForeColor = System.Drawing.Color.Black
        Me.StdLName.Location = New System.Drawing.Point(186, 224)
        Me.StdLName.Name = "StdLName"
        Me.StdLName.Size = New System.Drawing.Size(75, 25)
        Me.StdLName.TabIndex = 21
        Me.StdLName.Text = "LName"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 255)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 26)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Level:"
        '
        'stdID
        '
        Me.stdID.AutoSize = True
        Me.stdID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stdID.Location = New System.Drawing.Point(104, 192)
        Me.stdID.Name = "stdID"
        Me.stdID.Size = New System.Drawing.Size(31, 25)
        Me.stdID.TabIndex = 23
        Me.stdID.Text = "ID"
        '
        'StdName
        '
        Me.StdName.AutoSize = True
        Me.StdName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StdName.ForeColor = System.Drawing.Color.Black
        Me.StdName.Location = New System.Drawing.Point(104, 224)
        Me.StdName.Name = "StdName"
        Me.StdName.Size = New System.Drawing.Size(76, 25)
        Me.StdName.TabIndex = 20
        Me.StdName.Text = "FName"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label3.Location = New System.Drawing.Point(9, 300)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(217, 34)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Calculate GPA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 223)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 26)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Name:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.StudentManagementSystem.My.Resources.Resources._200px_University_of_Ghana
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(216, 169)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'btnGPA
        '
        Me.btnGPA.BackColor = System.Drawing.Color.DarkKhaki
        Me.btnGPA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGPA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGPA.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGPA.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnGPA.Location = New System.Drawing.Point(10, 541)
        Me.btnGPA.Name = "btnGPA"
        Me.btnGPA.Size = New System.Drawing.Size(121, 45)
        Me.btnGPA.TabIndex = 28
        Me.btnGPA.Text = "GPA"
        Me.btnGPA.UseVisualStyleBackColor = False
        '
        'studGPA
        '
        Me.studGPA.AutoSize = True
        Me.studGPA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studGPA.Location = New System.Drawing.Point(528, 23)
        Me.studGPA.Name = "studGPA"
        Me.studGPA.Size = New System.Drawing.Size(54, 25)
        Me.studGPA.TabIndex = 25
        Me.studGPA.Text = "GPA"
        Me.studGPA.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(458, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 26)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "GPA:"
        '
        'btnStdClose
        '
        Me.btnStdClose.BackColor = System.Drawing.Color.Crimson
        Me.btnStdClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnStdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStdClose.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStdClose.ForeColor = System.Drawing.Color.White
        Me.btnStdClose.Location = New System.Drawing.Point(481, 541)
        Me.btnStdClose.Name = "btnStdClose"
        Me.btnStdClose.Size = New System.Drawing.Size(121, 45)
        Me.btnStdClose.TabIndex = 27
        Me.btnStdClose.Text = "Close"
        Me.btnStdClose.UseVisualStyleBackColor = False
        '
        'gradesview
        '
        Me.gradesview.AllowUserToAddRows = False
        Me.gradesview.AllowUserToDeleteRows = False
        Me.gradesview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gradesview.BackgroundColor = System.Drawing.SystemColors.Window
        Me.gradesview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.gradesview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gradesview.DefaultCellStyle = DataGridViewCellStyle1
        Me.gradesview.GridColor = System.Drawing.SystemColors.Window
        Me.gradesview.Location = New System.Drawing.Point(10, 97)
        Me.gradesview.Name = "gradesview"
        Me.gradesview.ReadOnly = True
        Me.gradesview.RowTemplate.Height = 28
        Me.gradesview.Size = New System.Drawing.Size(592, 438)
        Me.gradesview.TabIndex = 26
        '
        'allSems
        '
        Me.allSems.AutoSize = True
        Me.allSems.Cursor = System.Windows.Forms.Cursors.Hand
        Me.allSems.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.allSems.Location = New System.Drawing.Point(412, 64)
        Me.allSems.Name = "allSems"
        Me.allSems.Size = New System.Drawing.Size(60, 27)
        Me.allSems.TabIndex = 25
        Me.allSems.TabStop = True
        Me.allSems.Text = "All"
        Me.allSems.UseVisualStyleBackColor = True
        '
        'rdSecSEM
        '
        Me.rdSecSEM.AutoSize = True
        Me.rdSecSEM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdSecSEM.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdSecSEM.Location = New System.Drawing.Point(193, 64)
        Me.rdSecSEM.Name = "rdSecSEM"
        Me.rdSecSEM.Size = New System.Drawing.Size(204, 27)
        Me.rdSecSEM.TabIndex = 24
        Me.rdSecSEM.TabStop = True
        Me.rdSecSEM.Text = "Second Semester"
        Me.rdSecSEM.UseVisualStyleBackColor = True
        '
        'rdFSEM
        '
        Me.rdFSEM.AutoSize = True
        Me.rdFSEM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdFSEM.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdFSEM.Location = New System.Drawing.Point(10, 64)
        Me.rdFSEM.Name = "rdFSEM"
        Me.rdFSEM.Size = New System.Drawing.Size(166, 27)
        Me.rdFSEM.TabIndex = 23
        Me.rdFSEM.TabStop = True
        Me.rdFSEM.Text = "First Semester"
        Me.rdFSEM.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label1.Location = New System.Drawing.Point(3, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 38)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Calculate GPA"
        '
        'Calculate_GPA
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.CancelButton = Me.btnStdClose
        Me.ClientSize = New System.Drawing.Size(923, 600)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Calculate_GPA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculate GPA"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gradesview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents stdLvl As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents StdLName As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents stdID As Label
    Friend WithEvents StdName As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents allSems As RadioButton
    Friend WithEvents rdSecSEM As RadioButton
    Friend WithEvents rdFSEM As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents gradesview As DataGridView
    Friend WithEvents btnStdClose As Button
    Friend WithEvents studGPA As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnGPA As Button
End Class
