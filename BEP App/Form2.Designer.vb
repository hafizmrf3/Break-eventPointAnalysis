<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.lblDA = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtHasilBiayaVariabel = New System.Windows.Forms.TextBox()
        Me.txtSalesUnitSaatIni = New System.Windows.Forms.TextBox()
        Me.txtSalesUnitDiharapkan = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblPerubahanMarginKontribusi = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMarginKontribusiSaatIni = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtBiayaVariabelSaatIni = New System.Windows.Forms.TextBox()
        Me.txtSalesUnitPerUnit = New System.Windows.Forms.TextBox()
        Me.btnBEP = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BunifuCards2 = New Bunifu.Framework.UI.BunifuCards()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BunifuCards3 = New Bunifu.Framework.UI.BunifuCards()
        Me.txtMarginKontribusiPerubahan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBiayaVariabelPerubahan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.BunifuCards1.SuspendLayout()
        Me.BunifuCards2.SuspendLayout()
        Me.BunifuCards3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDA
        '
        Me.lblDA.AutoSize = True
        Me.lblDA.BackColor = System.Drawing.Color.Transparent
        Me.lblDA.Font = New System.Drawing.Font("Maiandra GD", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDA.Location = New System.Drawing.Point(153, 17)
        Me.lblDA.Name = "lblDA"
        Me.lblDA.Size = New System.Drawing.Size(455, 35)
        Me.lblDA.TabIndex = 166
        Me.lblDA.Text = "Perubahan Dalam Biaya Variabel"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(95, 439)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(254, 17)
        Me.Label14.TabIndex = 153
        Me.Label14.Text = "(<) Seharusnya perubahan tidak dilakukan"
        Me.Label14.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(543, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 16)
        Me.Label6.TabIndex = 151
        Me.Label6.Text = "Hasil"
        '
        'txtHasilBiayaVariabel
        '
        Me.txtHasilBiayaVariabel.Enabled = False
        Me.txtHasilBiayaVariabel.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHasilBiayaVariabel.Location = New System.Drawing.Point(490, 168)
        Me.txtHasilBiayaVariabel.MaxLength = 300
        Me.txtHasilBiayaVariabel.Name = "txtHasilBiayaVariabel"
        Me.txtHasilBiayaVariabel.Size = New System.Drawing.Size(144, 31)
        Me.txtHasilBiayaVariabel.TabIndex = 150
        '
        'txtSalesUnitSaatIni
        '
        Me.txtSalesUnitSaatIni.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalesUnitSaatIni.Location = New System.Drawing.Point(188, 65)
        Me.txtSalesUnitSaatIni.MaxLength = 300
        Me.txtSalesUnitSaatIni.Name = "txtSalesUnitSaatIni"
        Me.txtSalesUnitSaatIni.Size = New System.Drawing.Size(127, 31)
        Me.txtSalesUnitSaatIni.TabIndex = 147
        '
        'txtSalesUnitDiharapkan
        '
        Me.txtSalesUnitDiharapkan.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalesUnitDiharapkan.Location = New System.Drawing.Point(12, 38)
        Me.txtSalesUnitDiharapkan.MaxLength = 300
        Me.txtSalesUnitDiharapkan.Name = "txtSalesUnitDiharapkan"
        Me.txtSalesUnitDiharapkan.Size = New System.Drawing.Size(128, 31)
        Me.txtSalesUnitDiharapkan.TabIndex = 146
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(32, 364)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 16)
        Me.Label13.TabIndex = 142
        Me.Label13.Text = "Hasil:"
        Me.Label13.Visible = False
        '
        'lblPerubahanMarginKontribusi
        '
        Me.lblPerubahanMarginKontribusi.AutoSize = True
        Me.lblPerubahanMarginKontribusi.BackColor = System.Drawing.Color.White
        Me.lblPerubahanMarginKontribusi.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerubahanMarginKontribusi.Location = New System.Drawing.Point(29, 396)
        Me.lblPerubahanMarginKontribusi.Name = "lblPerubahanMarginKontribusi"
        Me.lblPerubahanMarginKontribusi.Size = New System.Drawing.Size(664, 17)
        Me.lblPerubahanMarginKontribusi.TabIndex = 138
        Me.lblPerubahanMarginKontribusi.Text = "Perubahan Margin Kontribusi sebesar: (sales unit diharapkan * MC diharapkan) - (s" &
    "ales unit saat ini  * MC saat ini)"
        Me.lblPerubahanMarginKontribusi.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(107, 73)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 16)
        Me.Label12.TabIndex = 136
        Me.Label12.Text = "Sales Unit:"
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.White
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.SystemColors.HotTrack
        Me.BunifuCards1.Controls.Add(Me.Label14)
        Me.BunifuCards1.Controls.Add(Me.Label6)
        Me.BunifuCards1.Controls.Add(Me.txtHasilBiayaVariabel)
        Me.BunifuCards1.Controls.Add(Me.txtSalesUnitSaatIni)
        Me.BunifuCards1.Controls.Add(Me.Label13)
        Me.BunifuCards1.Controls.Add(Me.lblPerubahanMarginKontribusi)
        Me.BunifuCards1.Controls.Add(Me.Label12)
        Me.BunifuCards1.Controls.Add(Me.BunifuSeparator1)
        Me.BunifuCards1.Controls.Add(Me.Label9)
        Me.BunifuCards1.Controls.Add(Me.Label7)
        Me.BunifuCards1.Controls.Add(Me.txtMarginKontribusiSaatIni)
        Me.BunifuCards1.Controls.Add(Me.btnClear)
        Me.BunifuCards1.Controls.Add(Me.txtBiayaVariabelSaatIni)
        Me.BunifuCards1.Controls.Add(Me.txtSalesUnitPerUnit)
        Me.BunifuCards1.Controls.Add(Me.btnBEP)
        Me.BunifuCards1.Controls.Add(Me.Label3)
        Me.BunifuCards1.Controls.Add(Me.BunifuCards2)
        Me.BunifuCards1.Controls.Add(Me.BunifuCards3)
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(139, 100)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(743, 547)
        Me.BunifuCards1.TabIndex = 165
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 3
        Me.BunifuSeparator1.Location = New System.Drawing.Point(32, 312)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(684, 21)
        Me.BunifuSeparator1.TabIndex = 135
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(59, 216)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 16)
        Me.Label9.TabIndex = 129
        Me.Label9.Text = "Margin Kontribusi:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(59, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 16)
        Me.Label7.TabIndex = 125
        Me.Label7.Text = "Sales (sales unit):"
        '
        'txtMarginKontribusiSaatIni
        '
        Me.txtMarginKontribusiSaatIni.Enabled = False
        Me.txtMarginKontribusiSaatIni.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarginKontribusiSaatIni.Location = New System.Drawing.Point(189, 205)
        Me.txtMarginKontribusiSaatIni.MaxLength = 300
        Me.txtMarginKontribusiSaatIni.Name = "txtMarginKontribusiSaatIni"
        Me.txtMarginKontribusiSaatIni.Size = New System.Drawing.Size(127, 31)
        Me.txtMarginKontribusiSaatIni.TabIndex = 123
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.DarkKhaki
        Me.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClear.Font = New System.Drawing.Font("Maiandra GD", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Image = Global.BEP_App.My.Resources.Resources.icons8_cancel_30px
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClear.Location = New System.Drawing.Point(582, 271)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(85, 35)
        Me.btnClear.TabIndex = 122
        Me.btnClear.Text = "HAPUS"
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'txtBiayaVariabelSaatIni
        '
        Me.txtBiayaVariabelSaatIni.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBiayaVariabelSaatIni.Location = New System.Drawing.Point(188, 168)
        Me.txtBiayaVariabelSaatIni.MaxLength = 300
        Me.txtBiayaVariabelSaatIni.Name = "txtBiayaVariabelSaatIni"
        Me.txtBiayaVariabelSaatIni.Size = New System.Drawing.Size(127, 31)
        Me.txtBiayaVariabelSaatIni.TabIndex = 119
        '
        'txtSalesUnitPerUnit
        '
        Me.txtSalesUnitPerUnit.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalesUnitPerUnit.Location = New System.Drawing.Point(188, 133)
        Me.txtSalesUnitPerUnit.MaxLength = 300
        Me.txtSalesUnitPerUnit.Name = "txtSalesUnitPerUnit"
        Me.txtSalesUnitPerUnit.Size = New System.Drawing.Size(127, 31)
        Me.txtSalesUnitPerUnit.TabIndex = 118
        '
        'btnBEP
        '
        Me.btnBEP.BackColor = System.Drawing.Color.DarkKhaki
        Me.btnBEP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBEP.Font = New System.Drawing.Font("Maiandra GD", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBEP.Image = Global.BEP_App.My.Resources.Resources.icons8_checked_checkbox_30px
        Me.btnBEP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBEP.Location = New System.Drawing.Point(448, 271)
        Me.btnBEP.Name = "btnBEP"
        Me.btnBEP.Size = New System.Drawing.Size(128, 35)
        Me.btnBEP.TabIndex = 117
        Me.btnBEP.Text = "Cek Kesimpulan"
        Me.btnBEP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBEP.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(75, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 113
        Me.Label3.Text = "Biaya Variabel:"
        '
        'BunifuCards2
        '
        Me.BunifuCards2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BunifuCards2.BorderRadius = 5
        Me.BunifuCards2.BottomSahddow = True
        Me.BunifuCards2.color = System.Drawing.Color.Tomato
        Me.BunifuCards2.Controls.Add(Me.Label1)
        Me.BunifuCards2.Controls.Add(Me.Label5)
        Me.BunifuCards2.LeftSahddow = False
        Me.BunifuCards2.Location = New System.Drawing.Point(183, 27)
        Me.BunifuCards2.Name = "BunifuCards2"
        Me.BunifuCards2.RightSahddow = True
        Me.BunifuCards2.ShadowDepth = 20
        Me.BunifuCards2.Size = New System.Drawing.Size(140, 226)
        Me.BunifuCards2.TabIndex = 154
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 16)
        Me.Label1.TabIndex = 149
        Me.Label1.Text = "Saat ini"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 16)
        Me.Label5.TabIndex = 121
        Me.Label5.Text = "Per Unit (Rp)"
        '
        'BunifuCards3
        '
        Me.BunifuCards3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BunifuCards3.BorderRadius = 5
        Me.BunifuCards3.BottomSahddow = True
        Me.BunifuCards3.color = System.Drawing.Color.Tomato
        Me.BunifuCards3.Controls.Add(Me.txtMarginKontribusiPerubahan)
        Me.BunifuCards3.Controls.Add(Me.Label2)
        Me.BunifuCards3.Controls.Add(Me.txtBiayaVariabelPerubahan)
        Me.BunifuCards3.Controls.Add(Me.Label4)
        Me.BunifuCards3.Controls.Add(Me.txtSalesUnitDiharapkan)
        Me.BunifuCards3.LeftSahddow = False
        Me.BunifuCards3.Location = New System.Drawing.Point(329, 27)
        Me.BunifuCards3.Name = "BunifuCards3"
        Me.BunifuCards3.RightSahddow = True
        Me.BunifuCards3.ShadowDepth = 20
        Me.BunifuCards3.Size = New System.Drawing.Size(155, 226)
        Me.BunifuCards3.TabIndex = 155
        '
        'txtMarginKontribusiPerubahan
        '
        Me.txtMarginKontribusiPerubahan.Enabled = False
        Me.txtMarginKontribusiPerubahan.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarginKontribusiPerubahan.Location = New System.Drawing.Point(12, 180)
        Me.txtMarginKontribusiPerubahan.MaxLength = 300
        Me.txtMarginKontribusiPerubahan.Name = "txtMarginKontribusiPerubahan"
        Me.txtMarginKontribusiPerubahan.Size = New System.Drawing.Size(128, 31)
        Me.txtMarginKontribusiPerubahan.TabIndex = 149
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 148
        Me.Label2.Text = "Diharapkan"
        '
        'txtBiayaVariabelPerubahan
        '
        Me.txtBiayaVariabelPerubahan.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBiayaVariabelPerubahan.Location = New System.Drawing.Point(12, 141)
        Me.txtBiayaVariabelPerubahan.MaxLength = 300
        Me.txtBiayaVariabelPerubahan.Name = "txtBiayaVariabelPerubahan"
        Me.txtBiayaVariabelPerubahan.Size = New System.Drawing.Size(128, 31)
        Me.txtBiayaVariabelPerubahan.TabIndex = 130
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 16)
        Me.Label4.TabIndex = 117
        Me.Label4.Text = "Perubahan"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Maiandra GD", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(153, 52)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(321, 35)
        Me.Label17.TabIndex = 167
        Me.Label17.Text = "dan Volume Penjualan"
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
        Me.btnClose.TabIndex = 164
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 650)
        Me.Controls.Add(Me.lblDA)
        Me.Controls.Add(Me.BunifuCards1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.BunifuCards1.ResumeLayout(False)
        Me.BunifuCards1.PerformLayout()
        Me.BunifuCards2.ResumeLayout(False)
        Me.BunifuCards2.PerformLayout()
        Me.BunifuCards3.ResumeLayout(False)
        Me.BunifuCards3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDA As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtHasilBiayaVariabel As TextBox
    Friend WithEvents txtSalesUnitSaatIni As TextBox
    Friend WithEvents txtSalesUnitDiharapkan As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents lblPerubahanMarginKontribusi As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtMarginKontribusiSaatIni As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents txtBiayaVariabelSaatIni As TextBox
    Friend WithEvents txtSalesUnitPerUnit As TextBox
    Friend WithEvents btnBEP As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents BunifuCards2 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BunifuCards3 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents txtMarginKontribusiPerubahan As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBiayaVariabelPerubahan As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents btnClose As Button
End Class
