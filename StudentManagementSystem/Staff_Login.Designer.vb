<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Staff_Login
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtStfID = New System.Windows.Forms.TextBox()
        Me.txtStfPIN = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnStfLogin = New System.Windows.Forms.Button()
        Me.btnStfClose = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label1.Location = New System.Drawing.Point(193, 184)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 57)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Staff Login"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 241)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 39)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ID Number"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtStfID
        '
        Me.txtStfID.Location = New System.Drawing.Point(201, 250)
        Me.txtStfID.MaxLength = 3
        Me.txtStfID.Name = "txtStfID"
        Me.txtStfID.Size = New System.Drawing.Size(253, 26)
        Me.txtStfID.TabIndex = 6
        Me.txtStfID.Tag = "Please enter ID Number"
        '
        'txtStfPIN
        '
        Me.txtStfPIN.Location = New System.Drawing.Point(201, 295)
        Me.txtStfPIN.MaxLength = 5
        Me.txtStfPIN.Name = "txtStfPIN"
        Me.txtStfPIN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtStfPIN.Size = New System.Drawing.Size(253, 26)
        Me.txtStfPIN.TabIndex = 7
        Me.txtStfPIN.Tag = "Please enter PIN"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(53, 286)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 39)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "PIN"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnStfLogin
        '
        Me.btnStfLogin.BackColor = System.Drawing.Color.DarkKhaki
        Me.btnStfLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStfLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStfLogin.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStfLogin.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnStfLogin.Location = New System.Drawing.Point(201, 377)
        Me.btnStfLogin.Name = "btnStfLogin"
        Me.btnStfLogin.Size = New System.Drawing.Size(121, 45)
        Me.btnStfLogin.TabIndex = 9
        Me.btnStfLogin.Text = "Login"
        Me.btnStfLogin.UseVisualStyleBackColor = False
        '
        'btnStfClose
        '
        Me.btnStfClose.BackColor = System.Drawing.Color.Crimson
        Me.btnStfClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStfClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnStfClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStfClose.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStfClose.ForeColor = System.Drawing.Color.White
        Me.btnStfClose.Location = New System.Drawing.Point(333, 377)
        Me.btnStfClose.Name = "btnStfClose"
        Me.btnStfClose.Size = New System.Drawing.Size(121, 45)
        Me.btnStfClose.TabIndex = 9
        Me.btnStfClose.Text = "Close"
        Me.btnStfClose.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CheckBox1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(201, 327)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(116, 25)
        Me.CheckBox1.TabIndex = 12
        Me.CheckBox1.Text = "Show PIN"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.StudentManagementSystem.My.Resources.Resources._200px_University_of_Ghana
        Me.PictureBox1.Location = New System.Drawing.Point(201, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(216, 169)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Staff_Login
        '
        Me.AcceptButton = Me.btnStfLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.CancelButton = Me.btnStfClose
        Me.ClientSize = New System.Drawing.Size(627, 450)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.btnStfClose)
        Me.Controls.Add(Me.btnStfLogin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtStfPIN)
        Me.Controls.Add(Me.txtStfID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Staff_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Staff Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtStfID As TextBox
    Friend WithEvents txtStfPIN As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnStfLogin As Button
    Friend WithEvents btnStfClose As Button
    Friend WithEvents CheckBox1 As CheckBox
End Class
