<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proof_of_registration
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.stdLvl = New System.Windows.Forms.Label()
        Me.stdID = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.StdLName = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.StdName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.detailsLName = New System.Windows.Forms.Label()
        Me.detailsLevel = New System.Windows.Forms.Label()
        Me.detailsFName = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.detailsMajor = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.detailsID = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.display = New System.Windows.Forms.ListBox()
        Me.btnStdClose = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Noreg = New System.Windows.Forms.Label()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Noreg)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label8)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel2.Controls.Add(Me.detailsLName)
        Me.SplitContainer1.Panel2.Controls.Add(Me.detailsLevel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.detailsFName)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel2.Controls.Add(Me.detailsMajor)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label16)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label12)
        Me.SplitContainer1.Panel2.Controls.Add(Me.detailsID)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label10)
        Me.SplitContainer1.Panel2.Controls.Add(Me.display)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnStdClose)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Size = New System.Drawing.Size(1007, 621)
        Me.SplitContainer1.SplitterDistance = 335
        Me.SplitContainer1.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.87719!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.77193!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.stdLvl, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.stdID, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.StdLName, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.StdName, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 178)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(319, 124)
        Me.TableLayoutPanel1.TabIndex = 27
        '
        'stdLvl
        '
        Me.stdLvl.AutoSize = True
        Me.stdLvl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stdLvl.Location = New System.Drawing.Point(101, 82)
        Me.stdLvl.Name = "stdLvl"
        Me.stdLvl.Size = New System.Drawing.Size(30, 25)
        Me.stdLvl.TabIndex = 23
        Me.stdLvl.Text = "lvl"
        '
        'stdID
        '
        Me.stdID.AutoSize = True
        Me.stdID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stdID.Location = New System.Drawing.Point(101, 0)
        Me.stdID.Name = "stdID"
        Me.stdID.Size = New System.Drawing.Size(31, 25)
        Me.stdID.TabIndex = 24
        Me.stdID.Text = "ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 26)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Level:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 23)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "ID No: "
        '
        'StdLName
        '
        Me.StdLName.AutoSize = True
        Me.StdLName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StdLName.ForeColor = System.Drawing.Color.Black
        Me.StdLName.Location = New System.Drawing.Point(193, 41)
        Me.StdLName.Name = "StdLName"
        Me.StdLName.Size = New System.Drawing.Size(75, 25)
        Me.StdLName.TabIndex = 22
        Me.StdLName.Text = "LName"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 26)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Name:"
        '
        'StdName
        '
        Me.StdName.AutoSize = True
        Me.StdName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StdName.ForeColor = System.Drawing.Color.Black
        Me.StdName.Location = New System.Drawing.Point(101, 41)
        Me.StdName.Name = "StdName"
        Me.StdName.Size = New System.Drawing.Size(76, 25)
        Me.StdName.TabIndex = 21
        Me.StdName.Text = "FName"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 358)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(328, 69)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "View Courses" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Registered courses appear here." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label1.Location = New System.Drawing.Point(26, 312)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(273, 34)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Registered Courses" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.StudentManagementSystem.My.Resources.Resources._200px_University_of_Ghana
        Me.PictureBox1.Location = New System.Drawing.Point(12, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(216, 169)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 138)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 26)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Level"
        '
        'detailsLName
        '
        Me.detailsLName.AutoSize = True
        Me.detailsLName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.detailsLName.ForeColor = System.Drawing.Color.Black
        Me.detailsLName.Location = New System.Drawing.Point(291, 102)
        Me.detailsLName.Name = "detailsLName"
        Me.detailsLName.Size = New System.Drawing.Size(75, 25)
        Me.detailsLName.TabIndex = 22
        Me.detailsLName.Text = "LName"
        '
        'detailsLevel
        '
        Me.detailsLevel.AutoSize = True
        Me.detailsLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.detailsLevel.Location = New System.Drawing.Point(165, 141)
        Me.detailsLevel.Name = "detailsLevel"
        Me.detailsLevel.Size = New System.Drawing.Size(30, 25)
        Me.detailsLevel.TabIndex = 23
        Me.detailsLevel.Text = "lvl"
        '
        'detailsFName
        '
        Me.detailsFName.AutoSize = True
        Me.detailsFName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.detailsFName.ForeColor = System.Drawing.Color.Black
        Me.detailsFName.Location = New System.Drawing.Point(164, 103)
        Me.detailsFName.Name = "detailsFName"
        Me.detailsFName.Size = New System.Drawing.Size(76, 25)
        Me.detailsFName.TabIndex = 21
        Me.detailsFName.Text = "FName"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label7.Location = New System.Drawing.Point(7, 242)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(273, 34)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Courses Registered"
        '
        'detailsMajor
        '
        Me.detailsMajor.AutoSize = True
        Me.detailsMajor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.detailsMajor.Location = New System.Drawing.Point(164, 179)
        Me.detailsMajor.Name = "detailsMajor"
        Me.detailsMajor.Size = New System.Drawing.Size(38, 25)
        Me.detailsMajor.TabIndex = 32
        Me.detailsMajor.Text = "mjr"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(12, 176)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(74, 26)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "Major"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 100)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 26)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Name"
        '
        'detailsID
        '
        Me.detailsID.AutoSize = True
        Me.detailsID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.detailsID.Location = New System.Drawing.Point(165, 65)
        Me.detailsID.Name = "detailsID"
        Me.detailsID.Size = New System.Drawing.Size(31, 25)
        Me.detailsID.TabIndex = 24
        Me.detailsID.Text = "ID"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(9, 65)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 23)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Student ID"
        '
        'display
        '
        Me.display.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.display.FormattingEnabled = True
        Me.display.ItemHeight = 25
        Me.display.Location = New System.Drawing.Point(13, 279)
        Me.display.Name = "display"
        Me.display.Size = New System.Drawing.Size(643, 279)
        Me.display.TabIndex = 29
        '
        'btnStdClose
        '
        Me.btnStdClose.BackColor = System.Drawing.Color.Crimson
        Me.btnStdClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnStdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStdClose.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStdClose.ForeColor = System.Drawing.Color.White
        Me.btnStdClose.Location = New System.Drawing.Point(535, 564)
        Me.btnStdClose.Name = "btnStdClose"
        Me.btnStdClose.Size = New System.Drawing.Size(121, 45)
        Me.btnStdClose.TabIndex = 26
        Me.btnStdClose.Text = "Close"
        Me.btnStdClose.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label3.Location = New System.Drawing.Point(7, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(288, 34)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Proof Of Registration"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 214)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(341, 26)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Number of Registered Courses:"
        '
        'Noreg
        '
        Me.Noreg.AutoSize = True
        Me.Noreg.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Noreg.Location = New System.Drawing.Point(383, 215)
        Me.Noreg.Name = "Noreg"
        Me.Noreg.Size = New System.Drawing.Size(214, 25)
        Me.Noreg.TabIndex = 34
        Me.Noreg.Text = "No Registered Courses"
        '
        'Proof_of_registration
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1007, 621)
        Me.Controls.Add(Me.SplitContainer1)
        Me.MaximizeBox = False
        Me.Name = "Proof_of_registration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proof of Registration"
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
    Friend WithEvents stdID As Label
    Friend WithEvents stdLvl As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents StdLName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents StdName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnStdClose As Button
    Friend WithEvents detailsLevel As Label
    Friend WithEvents detailsID As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents detailsLName As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents detailsFName As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents detailsMajor As Label
    Friend WithEvents display As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Noreg As Label
    Friend WithEvents Label8 As Label
End Class
