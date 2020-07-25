<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblDetailJmlUnit = New System.Windows.Forms.Label()
        Me.lblDetailJmlRp = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtBiayaTetap = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtBebanVariabel = New System.Windows.Forms.TextBox()
        Me.txtHargaUnit = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnBEP = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.lblJmlUnit = New System.Windows.Forms.Label()
        Me.txtLaba = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblDA = New System.Windows.Forms.Label()
        Me.BunifuCards1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(338, 174)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 16)
        Me.Label11.TabIndex = 155
        Me.Label11.Text = "Laba Bersih:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(42, 329)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 16)
        Me.Label6.TabIndex = 151
        Me.Label6.Text = "Hasil"
        '
        'lblDetailJmlUnit
        '
        Me.lblDetailJmlUnit.AutoSize = True
        Me.lblDetailJmlUnit.BackColor = System.Drawing.Color.White
        Me.lblDetailJmlUnit.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetailJmlUnit.Location = New System.Drawing.Point(39, 373)
        Me.lblDetailJmlUnit.Name = "lblDetailJmlUnit"
        Me.lblDetailJmlUnit.Size = New System.Drawing.Size(115, 17)
        Me.lblDetailJmlUnit.TabIndex = 138
        Me.lblDetailJmlUnit.Text = "Detail Jumlah Unit"
        Me.lblDetailJmlUnit.Visible = False
        '
        'lblDetailJmlRp
        '
        Me.lblDetailJmlRp.AutoSize = True
        Me.lblDetailJmlRp.BackColor = System.Drawing.Color.White
        Me.lblDetailJmlRp.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetailJmlRp.Location = New System.Drawing.Point(39, 402)
        Me.lblDetailJmlRp.Name = "lblDetailJmlRp"
        Me.lblDetailJmlRp.Size = New System.Drawing.Size(132, 17)
        Me.lblDetailJmlRp.TabIndex = 131
        Me.lblDetailJmlRp.Text = "Detail Jumlah Rupiah"
        Me.lblDetailJmlRp.Visible = False
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 3
        Me.BunifuSeparator1.Location = New System.Drawing.Point(42, 305)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(837, 21)
        Me.BunifuSeparator1.TabIndex = 135
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(338, 136)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 16)
        Me.Label10.TabIndex = 131
        Me.Label10.Text = "Biaya Tetap:"
        '
        'txtBiayaTetap
        '
        Me.txtBiayaTetap.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBiayaTetap.Location = New System.Drawing.Point(433, 127)
        Me.txtBiayaTetap.MaxLength = 300
        Me.txtBiayaTetap.Name = "txtBiayaTetap"
        Me.txtBiayaTetap.Size = New System.Drawing.Size(127, 31)
        Me.txtBiayaTetap.TabIndex = 123
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.DarkKhaki
        Me.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClear.Font = New System.Drawing.Font("Maiandra GD", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Image = Global.BEP_App.My.Resources.Resources.icons8_cancel_30px
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClear.Location = New System.Drawing.Point(588, 264)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(85, 35)
        Me.btnClear.TabIndex = 122
        Me.btnClear.Text = "HAPUS"
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'txtBebanVariabel
        '
        Me.txtBebanVariabel.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBebanVariabel.Location = New System.Drawing.Point(432, 90)
        Me.txtBebanVariabel.MaxLength = 300
        Me.txtBebanVariabel.Name = "txtBebanVariabel"
        Me.txtBebanVariabel.Size = New System.Drawing.Size(127, 31)
        Me.txtBebanVariabel.TabIndex = 119
        '
        'txtHargaUnit
        '
        Me.txtHargaUnit.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHargaUnit.Location = New System.Drawing.Point(432, 55)
        Me.txtHargaUnit.MaxLength = 300
        Me.txtHargaUnit.Name = "txtHargaUnit"
        Me.txtHargaUnit.Size = New System.Drawing.Size(127, 31)
        Me.txtHargaUnit.TabIndex = 118
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(310, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 16)
        Me.Label7.TabIndex = 125
        Me.Label7.Text = "Harga Jual/Unit:"
        '
        'btnBEP
        '
        Me.btnBEP.BackColor = System.Drawing.Color.DarkKhaki
        Me.btnBEP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBEP.Font = New System.Drawing.Font("Maiandra GD", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBEP.Image = Global.BEP_App.My.Resources.Resources.icons8_checked_checkbox_30px
        Me.btnBEP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBEP.Location = New System.Drawing.Point(491, 264)
        Me.btnBEP.Name = "btnBEP"
        Me.btnBEP.Size = New System.Drawing.Size(91, 35)
        Me.btnBEP.TabIndex = 117
        Me.btnBEP.Text = "HITUNG"
        Me.btnBEP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBEP.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(280, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 16)
        Me.Label3.TabIndex = 113
        Me.Label3.Text = "Beban Variabel/Unit:"
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.White
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.SystemColors.HotTrack
        Me.BunifuCards1.Controls.Add(Me.lblJmlUnit)
        Me.BunifuCards1.Controls.Add(Me.txtLaba)
        Me.BunifuCards1.Controls.Add(Me.Label11)
        Me.BunifuCards1.Controls.Add(Me.Label6)
        Me.BunifuCards1.Controls.Add(Me.lblDetailJmlUnit)
        Me.BunifuCards1.Controls.Add(Me.lblDetailJmlRp)
        Me.BunifuCards1.Controls.Add(Me.BunifuSeparator1)
        Me.BunifuCards1.Controls.Add(Me.Label10)
        Me.BunifuCards1.Controls.Add(Me.Label7)
        Me.BunifuCards1.Controls.Add(Me.txtBiayaTetap)
        Me.BunifuCards1.Controls.Add(Me.btnClear)
        Me.BunifuCards1.Controls.Add(Me.Label5)
        Me.BunifuCards1.Controls.Add(Me.txtBebanVariabel)
        Me.BunifuCards1.Controls.Add(Me.txtHargaUnit)
        Me.BunifuCards1.Controls.Add(Me.btnBEP)
        Me.BunifuCards1.Controls.Add(Me.Label3)
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(50, 103)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(914, 460)
        Me.BunifuCards1.TabIndex = 122
        '
        'lblJmlUnit
        '
        Me.lblJmlUnit.AutoSize = True
        Me.lblJmlUnit.BackColor = System.Drawing.Color.White
        Me.lblJmlUnit.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJmlUnit.Location = New System.Drawing.Point(42, 356)
        Me.lblJmlUnit.Name = "lblJmlUnit"
        Me.lblJmlUnit.Size = New System.Drawing.Size(115, 17)
        Me.lblJmlUnit.TabIndex = 157
        Me.lblJmlUnit.Text = "Detail Jumlah Unit"
        Me.lblJmlUnit.Visible = False
        '
        'txtLaba
        '
        Me.txtLaba.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLaba.Location = New System.Drawing.Point(433, 174)
        Me.txtLaba.MaxLength = 300
        Me.txtLaba.Name = "txtLaba"
        Me.txtLaba.Size = New System.Drawing.Size(127, 31)
        Me.txtLaba.TabIndex = 156
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(429, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 16)
        Me.Label5.TabIndex = 121
        Me.Label5.Text = "Per Unit (Rp)"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Red
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Maiandra GD", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(950, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(38, 37)
        Me.btnClose.TabIndex = 121
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lblDA
        '
        Me.lblDA.AutoSize = True
        Me.lblDA.BackColor = System.Drawing.Color.Transparent
        Me.lblDA.Font = New System.Drawing.Font("Maiandra GD", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDA.Location = New System.Drawing.Point(64, 35)
        Me.lblDA.Name = "lblDA"
        Me.lblDA.Size = New System.Drawing.Size(282, 35)
        Me.lblDA.TabIndex = 158
        Me.lblDA.Text = "Analisis Target Laba"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 650)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblDA)
        Me.Controls.Add(Me.BunifuCards1)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form4"
        Me.BunifuCards1.ResumeLayout(False)
        Me.BunifuCards1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label11 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblDetailJmlUnit As Label
    Friend WithEvents lblDetailJmlRp As Label
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label10 As Label
    Friend WithEvents txtBiayaTetap As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents txtBebanVariabel As TextBox
    Friend WithEvents txtHargaUnit As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnBEP As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents txtLaba As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents lblJmlUnit As Label
    Friend WithEvents lblDA As Label
End Class
