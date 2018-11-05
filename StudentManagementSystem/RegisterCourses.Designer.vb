<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegisterCourses
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.stdLvl = New System.Windows.Forms.Label()
        Me.stdID = New System.Windows.Forms.Label()
        Me.StdLName = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.StdName = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.regCourses = New System.Windows.Forms.CheckedListBox()
        Me.btnStdClose = New System.Windows.Forms.Button()
        Me.btnStdReg = New System.Windows.Forms.Button()
        Me.rdSecSEM = New System.Windows.Forms.RadioButton()
        Me.rdFSEM = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Panel2.Controls.Add(Me.regCourses)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnStdClose)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnStdReg)
        Me.SplitContainer1.Panel2.Controls.Add(Me.rdSecSEM)
        Me.SplitContainer1.Panel2.Controls.Add(Me.rdFSEM)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Size = New System.Drawing.Size(1000, 595)
        Me.SplitContainer1.SplitterDistance = 301
        Me.SplitContainer1.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.stdLvl, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.stdID, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.StdLName, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.StdName, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 187)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(272, 131)
        Me.TableLayoutPanel1.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 23)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "ID No: "
        '
        'stdLvl
        '
        Me.stdLvl.AutoSize = True
        Me.stdLvl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stdLvl.Location = New System.Drawing.Point(94, 92)
        Me.stdLvl.Name = "stdLvl"
        Me.stdLvl.Size = New System.Drawing.Size(30, 25)
        Me.stdLvl.TabIndex = 13
        Me.stdLvl.Text = "lvl"
        '
        'stdID
        '
        Me.stdID.AutoSize = True
        Me.stdID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stdID.Location = New System.Drawing.Point(94, 0)
        Me.stdID.Name = "stdID"
        Me.stdID.Size = New System.Drawing.Size(31, 25)
        Me.stdID.TabIndex = 14
        Me.stdID.Text = "ID"
        '
        'StdLName
        '
        Me.StdLName.AutoSize = True
        Me.StdLName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StdLName.ForeColor = System.Drawing.Color.Black
        Me.StdLName.Location = New System.Drawing.Point(185, 46)
        Me.StdLName.Name = "StdLName"
        Me.StdLName.Size = New System.Drawing.Size(75, 25)
        Me.StdLName.TabIndex = 12
        Me.StdLName.Text = "LName"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 26)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Level:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 26)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Name:"
        '
        'StdName
        '
        Me.StdName.AutoSize = True
        Me.StdName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StdName.ForeColor = System.Drawing.Color.Black
        Me.StdName.Location = New System.Drawing.Point(94, 46)
        Me.StdName.Name = "StdName"
        Me.StdName.Size = New System.Drawing.Size(76, 25)
        Me.StdName.TabIndex = 11
        Me.StdName.Text = "FName"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(137, 546)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 20)
        Me.Label7.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 367)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(351, 161)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Steps to register:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1. Select semester to show courses." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2.Select courses for" &
    " the semester." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3. Click Register" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label1.Location = New System.Drawing.Point(26, 321)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 34)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Register Courses"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.StudentManagementSystem.My.Resources.Resources._200px_University_of_Ghana
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(216, 169)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'regCourses
        '
        Me.regCourses.CheckOnClick = True
        Me.regCourses.ColumnWidth = 1
        Me.regCourses.Cursor = System.Windows.Forms.Cursors.Hand
        Me.regCourses.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regCourses.FormattingEnabled = True
        Me.regCourses.Location = New System.Drawing.Point(16, 99)
        Me.regCourses.Name = "regCourses"
        Me.regCourses.Size = New System.Drawing.Size(663, 436)
        Me.regCourses.TabIndex = 18
        '
        'btnStdClose
        '
        Me.btnStdClose.BackColor = System.Drawing.Color.Crimson
        Me.btnStdClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnStdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStdClose.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStdClose.ForeColor = System.Drawing.Color.White
        Me.btnStdClose.Location = New System.Drawing.Point(558, 541)
        Me.btnStdClose.Name = "btnStdClose"
        Me.btnStdClose.Size = New System.Drawing.Size(121, 45)
        Me.btnStdClose.TabIndex = 16
        Me.btnStdClose.Text = "Close"
        Me.btnStdClose.UseVisualStyleBackColor = False
        '
        'btnStdReg
        '
        Me.btnStdReg.BackColor = System.Drawing.Color.DarkKhaki
        Me.btnStdReg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStdReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStdReg.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStdReg.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnStdReg.Location = New System.Drawing.Point(16, 541)
        Me.btnStdReg.Name = "btnStdReg"
        Me.btnStdReg.Size = New System.Drawing.Size(121, 45)
        Me.btnStdReg.TabIndex = 17
        Me.btnStdReg.Text = "Register"
        Me.btnStdReg.UseVisualStyleBackColor = False
        '
        'rdSecSEM
        '
        Me.rdSecSEM.AutoSize = True
        Me.rdSecSEM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdSecSEM.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdSecSEM.Location = New System.Drawing.Point(202, 58)
        Me.rdSecSEM.Name = "rdSecSEM"
        Me.rdSecSEM.Size = New System.Drawing.Size(204, 27)
        Me.rdSecSEM.TabIndex = 2
        Me.rdSecSEM.TabStop = True
        Me.rdSecSEM.Text = "Second Semester"
        Me.rdSecSEM.UseVisualStyleBackColor = True
        '
        'rdFSEM
        '
        Me.rdFSEM.AutoSize = True
        Me.rdFSEM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdFSEM.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdFSEM.Location = New System.Drawing.Point(16, 58)
        Me.rdFSEM.Name = "rdFSEM"
        Me.rdFSEM.Size = New System.Drawing.Size(166, 27)
        Me.rdFSEM.TabIndex = 1
        Me.rdFSEM.TabStop = True
        Me.rdFSEM.Text = "First Semester"
        Me.rdFSEM.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label3.Location = New System.Drawing.Point(10, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(463, 38)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Select Semester and Courses" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'RegisterCourses
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1000, 595)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "RegisterCourses"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register Courses"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents rdSecSEM As RadioButton
    Friend WithEvents rdFSEM As RadioButton
    Friend WithEvents StdLName As Label
    Friend WithEvents StdName As Label
    Friend WithEvents btnStdClose As Button
    Friend WithEvents btnStdReg As Button
    Friend WithEvents regCourses As CheckedListBox
    Friend WithEvents stdID As Label
    Friend WithEvents stdLvl As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
