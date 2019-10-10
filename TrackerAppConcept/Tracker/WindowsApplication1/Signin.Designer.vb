<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Signin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Signin))
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.lblCompanyName = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.btnSignIn = New System.Windows.Forms.Button()
        Me.btnForgot = New System.Windows.Forms.Label()
        Me.btnCreate = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Logo
        '
        Me.Logo.Image = CType(resources.GetObject("Logo.Image"), System.Drawing.Image)
        Me.Logo.Location = New System.Drawing.Point(75, 68)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(142, 109)
        Me.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Logo.TabIndex = 0
        Me.Logo.TabStop = False
        '
        'lblCompanyName
        '
        Me.lblCompanyName.AutoSize = True
        Me.lblCompanyName.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompanyName.Location = New System.Drawing.Point(38, 20)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(216, 23)
        Me.lblCompanyName.TabIndex = 1
        Me.lblCompanyName.Text = "Media Design Child Tracker"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(11, 236)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(58, 13)
        Me.lblUser.TabIndex = 2
        Me.lblUser.Text = "Username:"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Location = New System.Drawing.Point(13, 283)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(56, 13)
        Me.lblPass.TabIndex = 3
        Me.lblPass.Text = "Password:"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(75, 233)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(161, 20)
        Me.txtUser.TabIndex = 6
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(75, 280)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(161, 20)
        Me.txtPass.TabIndex = 7
        '
        'btnSignIn
        '
        Me.btnSignIn.Location = New System.Drawing.Point(107, 318)
        Me.btnSignIn.Name = "btnSignIn"
        Me.btnSignIn.Size = New System.Drawing.Size(75, 23)
        Me.btnSignIn.TabIndex = 8
        Me.btnSignIn.Text = "Sign in"
        Me.btnSignIn.UseVisualStyleBackColor = True
        '
        'btnForgot
        '
        Me.btnForgot.AutoSize = True
        Me.btnForgot.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnForgot.Location = New System.Drawing.Point(60, 419)
        Me.btnForgot.Name = "btnForgot"
        Me.btnForgot.Size = New System.Drawing.Size(145, 13)
        Me.btnForgot.TabIndex = 4
        Me.btnForgot.Text = "Forgot Username / Password"
        '
        'btnCreate
        '
        Me.btnCreate.AutoSize = True
        Me.btnCreate.Location = New System.Drawing.Point(59, 390)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(80, 13)
        Me.btnCreate.TabIndex = 5
        Me.btnCreate.Text = "Create account"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(292, 200)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(49, 359)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Incorrect credentials. Please try again."
        '
        'Signin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 441)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSignIn)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.btnForgot)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.lblCompanyName)
        Me.Controls.Add(Me.Logo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Signin"
        Me.Text = "Sign in"
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Logo As System.Windows.Forms.PictureBox
    Friend WithEvents lblCompanyName As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents lblPass As System.Windows.Forms.Label
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents btnSignIn As System.Windows.Forms.Button
    Friend WithEvents btnForgot As System.Windows.Forms.Label
    Friend WithEvents btnCreate As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
