<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.txtPass = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtUser = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse3 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnLogin = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPass
        '
        Me.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPass.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtPass.ForeColor = System.Drawing.Color.White
        Me.txtPass.HintForeColor = System.Drawing.Color.Empty
        Me.txtPass.HintText = ""
        Me.txtPass.isPassword = True
        Me.txtPass.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtPass.LineIdleColor = System.Drawing.Color.Gray
        Me.txtPass.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtPass.LineThickness = 3
        Me.txtPass.Location = New System.Drawing.Point(52, 240)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPass.Size = New System.Drawing.Size(175, 33)
        Me.txtPass.TabIndex = 30
        Me.txtPass.Text = "Password"
        Me.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtUser
        '
        Me.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUser.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtUser.ForeColor = System.Drawing.Color.White
        Me.txtUser.HintForeColor = System.Drawing.Color.Empty
        Me.txtUser.HintText = ""
        Me.txtUser.isPassword = False
        Me.txtUser.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtUser.LineIdleColor = System.Drawing.Color.Gray
        Me.txtUser.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtUser.LineThickness = 3
        Me.txtUser.Location = New System.Drawing.Point(52, 190)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtUser.Size = New System.Drawing.Size(175, 33)
        Me.txtUser.TabIndex = 29
        Me.txtUser.Text = "Username"
        Me.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 391)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(277, 10)
        Me.Panel2.TabIndex = 28
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(277, 12)
        Me.Panel1.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(81, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 39)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "LOGIN"
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 15
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 30
        Me.BunifuElipse2.TargetControl = Me.btnLogin
        '
        'BunifuElipse3
        '
        Me.BunifuElipse3.ElipseRadius = 25
        Me.BunifuElipse3.TargetControl = Me
        '
        'btnLogin
        '
        Me.btnLogin.ActiveBorderThickness = 1
        Me.btnLogin.ActiveCornerRadius = 20
        Me.btnLogin.ActiveFillColor = System.Drawing.SystemColors.Highlight
        Me.btnLogin.ActiveForecolor = System.Drawing.Color.White
        Me.btnLogin.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnLogin.BackgroundImage = CType(resources.GetObject("btnLogin.BackgroundImage"), System.Drawing.Image)
        Me.btnLogin.ButtonText = "Login"
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnLogin.IdleBorderThickness = 1
        Me.btnLogin.IdleCornerRadius = 20
        Me.btnLogin.IdleFillColor = System.Drawing.Color.White
        Me.btnLogin.IdleForecolor = System.Drawing.Color.Black
        Me.btnLogin.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnLogin.Location = New System.Drawing.Point(52, 310)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(175, 45)
        Me.btnLogin.TabIndex = 34
        Me.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(110, 32)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(62, 53)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 33
        Me.PictureBox3.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Century Schoolbook", 8.25!, System.Drawing.FontStyle.Underline)
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(117, 360)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(42, 15)
        Me.LinkLabel1.TabIndex = 36
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Cancel"
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(277, 401)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.PictureBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPass As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtUser As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btnLogin As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse3 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
