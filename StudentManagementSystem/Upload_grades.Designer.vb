<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Upload_grades
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.stfDept = New System.Windows.Forms.Label()
        Me.stfPost = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.stfLName = New System.Windows.Forms.Label()
        Me.stfID = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.stfFName = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.regNo = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnStdClose = New System.Windows.Forms.Button()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.datagrid = New System.Windows.Forms.DataGridView()
        Me.crs = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datagrid, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.stfDept)
        Me.SplitContainer1.Panel1.Controls.Add(Me.stfPost)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel1.Controls.Add(Me.stfLName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.stfID)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label8)
        Me.SplitContainer1.Panel1.Controls.Add(Me.stfFName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnCompute)
        Me.SplitContainer1.Panel2.Controls.Add(Me.regNo)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label10)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnStdClose)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnUpload)
        Me.SplitContainer1.Panel2.Controls.Add(Me.datagrid)
        Me.SplitContainer1.Panel2.Controls.Add(Me.crs)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Size = New System.Drawing.Size(1002, 625)
        Me.SplitContainer1.SplitterDistance = 325
        Me.SplitContainer1.TabIndex = 0
        '
        'stfDept
        '
        Me.stfDept.AutoSize = True
        Me.stfDept.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stfDept.Location = New System.Drawing.Point(130, 322)
        Me.stfDept.Name = "stfDept"
        Me.stfDept.Size = New System.Drawing.Size(50, 25)
        Me.stfDept.TabIndex = 32
        Me.stfDept.Text = "dept"
        '
        'stfPost
        '
        Me.stfPost.AutoSize = True
        Me.stfPost.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stfPost.Location = New System.Drawing.Point(130, 285)
        Me.stfPost.Name = "stfPost"
        Me.stfPost.Size = New System.Drawing.Size(49, 25)
        Me.stfPost.TabIndex = 28
        Me.stfPost.Text = "post"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 322)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 26)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Dept.:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 284)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 26)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Position:"
        '
        'stfLName
        '
        Me.stfLName.AutoSize = True
        Me.stfLName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stfLName.ForeColor = System.Drawing.Color.Black
        Me.stfLName.Location = New System.Drawing.Point(232, 248)
        Me.stfLName.Name = "stfLName"
        Me.stfLName.Size = New System.Drawing.Size(75, 25)
        Me.stfLName.TabIndex = 30
        Me.stfLName.Text = "LName"
        '
        'stfID
        '
        Me.stfID.AutoSize = True
        Me.stfID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stfID.Location = New System.Drawing.Point(130, 211)
        Me.stfID.Name = "stfID"
        Me.stfID.Size = New System.Drawing.Size(31, 25)
        Me.stfID.TabIndex = 29
        Me.stfID.Text = "ID"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(17, 246)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 26)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Name:"
        '
        'stfFName
        '
        Me.stfFName.AutoSize = True
        Me.stfFName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stfFName.ForeColor = System.Drawing.Color.Black
        Me.stfFName.Location = New System.Drawing.Point(130, 248)
        Me.stfFName.Name = "stfFName"
        Me.stfFName.Size = New System.Drawing.Size(76, 25)
        Me.stfFName.TabIndex = 27
        Me.stfFName.Text = "FName"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 211)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 23)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Staff ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 414)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(313, 210)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "To Upload grades:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1. Select Course Code" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3. Enter Marks" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "4. Click Co" &
    "mpute To Show Grades." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "5.Click Upload To save Grades." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label1.Location = New System.Drawing.Point(24, 364)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 34)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Upload Grades"
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
        'btnCompute
        '
        Me.btnCompute.BackColor = System.Drawing.Color.DarkKhaki
        Me.btnCompute.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCompute.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCompute.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompute.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnCompute.Location = New System.Drawing.Point(153, 568)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(121, 45)
        Me.btnCompute.TabIndex = 33
        Me.btnCompute.Text = "Compute"
        Me.btnCompute.UseVisualStyleBackColor = False
        '
        'regNo
        '
        Me.regNo.AutoSize = True
        Me.regNo.Location = New System.Drawing.Point(343, 134)
        Me.regNo.Name = "regNo"
        Me.regNo.Size = New System.Drawing.Size(52, 20)
        Me.regNo.TabIndex = 32
        Me.regNo.Text = "regNo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(13, 131)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(315, 23)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Number of Registered Students:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label3.Location = New System.Drawing.Point(9, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(427, 43)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Upload Student Grades"
        '
        'btnStdClose
        '
        Me.btnStdClose.BackColor = System.Drawing.Color.Crimson
        Me.btnStdClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnStdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStdClose.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStdClose.ForeColor = System.Drawing.Color.White
        Me.btnStdClose.Location = New System.Drawing.Point(535, 568)
        Me.btnStdClose.Name = "btnStdClose"
        Me.btnStdClose.Size = New System.Drawing.Size(121, 45)
        Me.btnStdClose.TabIndex = 18
        Me.btnStdClose.Text = "Close"
        Me.btnStdClose.UseVisualStyleBackColor = False
        '
        'btnUpload
        '
        Me.btnUpload.BackColor = System.Drawing.Color.DarkKhaki
        Me.btnUpload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpload.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpload.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnUpload.Location = New System.Drawing.Point(17, 568)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(121, 45)
        Me.btnUpload.TabIndex = 19
        Me.btnUpload.Text = "Upload"
        Me.btnUpload.UseVisualStyleBackColor = False
        '
        'datagrid
        '
        Me.datagrid.AllowUserToAddRows = False
        Me.datagrid.AllowUserToDeleteRows = False
        Me.datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagrid.BackgroundColor = System.Drawing.SystemColors.Window
        Me.datagrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagrid.DefaultCellStyle = DataGridViewCellStyle1
        Me.datagrid.GridColor = System.Drawing.SystemColors.Window
        Me.datagrid.Location = New System.Drawing.Point(17, 168)
        Me.datagrid.Name = "datagrid"
        Me.datagrid.RowTemplate.Height = 28
        Me.datagrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.datagrid.Size = New System.Drawing.Size(639, 394)
        Me.datagrid.TabIndex = 4
        '
        'crs
        '
        Me.crs.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crs.FormattingEnabled = True
        Me.crs.Location = New System.Drawing.Point(189, 74)
        Me.crs.Name = "crs"
        Me.crs.Size = New System.Drawing.Size(467, 31)
        Me.crs.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 23)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Select course"
        '
        'Upload_grades
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1002, 625)
        Me.Controls.Add(Me.SplitContainer1)
        Me.MaximizeBox = False
        Me.Name = "Upload_grades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Upload_grades"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents datagrid As DataGridView
    Friend WithEvents crs As ComboBox
    Friend WithEvents btnStdClose As Button
    Friend WithEvents btnUpload As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents stfDept As Label
    Friend WithEvents stfPost As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents stfLName As Label
    Friend WithEvents stfID As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents stfFName As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents regNo As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnCompute As Button
End Class
