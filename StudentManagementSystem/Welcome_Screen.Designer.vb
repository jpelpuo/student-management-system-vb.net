<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Welcome_Screen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Welcome_Screen))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StdLogBtn = New System.Windows.Forms.Button()
        Me.StfLogBtn = New System.Windows.Forms.Button()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label1.Location = New System.Drawing.Point(121, 203)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(590, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Student Record Management System"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StdLogBtn
        '
        Me.StdLogBtn.BackColor = System.Drawing.Color.DarkKhaki
        Me.StdLogBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StdLogBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StdLogBtn.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StdLogBtn.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.StdLogBtn.Location = New System.Drawing.Point(80, 264)
        Me.StdLogBtn.Name = "StdLogBtn"
        Me.StdLogBtn.Size = New System.Drawing.Size(156, 56)
        Me.StdLogBtn.TabIndex = 2
        Me.StdLogBtn.Text = "Student Login"
        Me.StdLogBtn.UseVisualStyleBackColor = False
        '
        'StfLogBtn
        '
        Me.StfLogBtn.BackColor = System.Drawing.Color.DarkKhaki
        Me.StfLogBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StfLogBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StfLogBtn.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StfLogBtn.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.StfLogBtn.Location = New System.Drawing.Point(257, 264)
        Me.StfLogBtn.Name = "StfLogBtn"
        Me.StfLogBtn.Size = New System.Drawing.Size(147, 56)
        Me.StfLogBtn.TabIndex = 2
        Me.StfLogBtn.Text = "Staff Login"
        Me.StfLogBtn.UseVisualStyleBackColor = False
        '
        'CloseBtn
        '
        Me.CloseBtn.BackColor = System.Drawing.Color.Crimson
        Me.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseBtn.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.ForeColor = System.Drawing.Color.White
        Me.CloseBtn.Location = New System.Drawing.Point(429, 264)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(147, 56)
        Me.CloseBtn.TabIndex = 2
        Me.CloseBtn.Text = "Close"
        Me.CloseBtn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(228, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 173)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Welcome_Screen
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(656, 369)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.StfLogBtn)
        Me.Controls.Add(Me.StdLogBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Welcome_Screen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Record Management"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents StdLogBtn As Button
    Friend WithEvents StfLogBtn As Button
    Friend WithEvents CloseBtn As Button
End Class
