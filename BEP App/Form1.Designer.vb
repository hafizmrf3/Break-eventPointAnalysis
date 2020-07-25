<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.BunifuCards4 = New Bunifu.Framework.UI.BunifuCards()
        Me.txtPeningkatanLabaBersih = New System.Windows.Forms.TextBox()
        Me.txtPeningkatanBiayaTetap = New System.Windows.Forms.TextBox()
        Me.txtPeningkatanMarginKontribusi = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPeningkatanBiayaVariabel = New System.Windows.Forms.TextBox()
        Me.txtPeningkatanSales = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtUnitSaatIni = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblDetailKesimpulan = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMarginKontribusiUnit = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBiayaVariabelUnit = New System.Windows.Forms.TextBox()
        Me.txtPenjualanUnit = New System.Windows.Forms.TextBox()
        Me.btnBEP = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BunifuCards2 = New Bunifu.Framework.UI.BunifuCards()
        Me.txtPerubahanBiayaTetap = New System.Windows.Forms.TextBox()
        Me.txtLabaBersihSaatIni = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtMarginKontribusiSaatIni = New System.Windows.Forms.TextBox()
        Me.txtBiayaVariabelSaatIni = New System.Windows.Forms.TextBox()
        Me.txtTotalPenjualanSaatIni = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBiayaTetapSaatIni = New System.Windows.Forms.TextBox()
        Me.BunifuCards3 = New Bunifu.Framework.UI.BunifuCards()
        Me.txtLabaBersihDiharapkan = New System.Windows.Forms.TextBox()
        Me.txtBiayaTetapDiharapkan = New System.Windows.Forms.TextBox()
        Me.txtMarginKontribusiDiharapkan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBiayaVariabelDiharapkan = New System.Windows.Forms.TextBox()
        Me.txtTotalPenjualanDiharapkan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUnitDiharapkan = New System.Windows.Forms.TextBox()
        Me.lblDA = New System.Windows.Forms.Label()
        Me.BunifuCards1.SuspendLayout()
        Me.BunifuCards4.SuspendLayout()
        Me.BunifuCards2.SuspendLayout()
        Me.BunifuCards3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Red
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Maiandra GD", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(950, 11)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(38, 37)
        Me.btnClose.TabIndex = 116
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.White
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.SystemColors.HotTrack
        Me.BunifuCards1.Controls.Add(Me.Label18)
        Me.BunifuCards1.Controls.Add(Me.BunifuCards4)
        Me.BunifuCards1.Controls.Add(Me.Label11)
        Me.BunifuCards1.Controls.Add(Me.txtUnitSaatIni)
        Me.BunifuCards1.Controls.Add(Me.Label13)
        Me.BunifuCards1.Controls.Add(Me.lblDetailKesimpulan)
        Me.BunifuCards1.Controls.Add(Me.Label12)
        Me.BunifuCards1.Controls.Add(Me.BunifuSeparator1)
        Me.BunifuCards1.Controls.Add(Me.Label10)
        Me.BunifuCards1.Controls.Add(Me.Label9)
        Me.BunifuCards1.Controls.Add(Me.Label7)
        Me.BunifuCards1.Controls.Add(Me.txtMarginKontribusiUnit)
        Me.BunifuCards1.Controls.Add(Me.btnClear)
        Me.BunifuCards1.Controls.Add(Me.Label5)
        Me.BunifuCards1.Controls.Add(Me.txtBiayaVariabelUnit)
        Me.BunifuCards1.Controls.Add(Me.txtPenjualanUnit)
        Me.BunifuCards1.Controls.Add(Me.btnBEP)
        Me.BunifuCards1.Controls.Add(Me.Label3)
        Me.BunifuCards1.Controls.Add(Me.BunifuCards2)
        Me.BunifuCards1.Controls.Add(Me.BunifuCards3)
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(48, 84)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(906, 552)
        Me.BunifuCards1.TabIndex = 120
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(7, 278)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(161, 16)
        Me.Label18.TabIndex = 157
        Me.Label18.Text = "Perubahan Biaya Tetap:"
        '
        'BunifuCards4
        '
        Me.BunifuCards4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BunifuCards4.BorderRadius = 5
        Me.BunifuCards4.BottomSahddow = True
        Me.BunifuCards4.color = System.Drawing.Color.Tomato
        Me.BunifuCards4.Controls.Add(Me.txtPeningkatanLabaBersih)
        Me.BunifuCards4.Controls.Add(Me.txtPeningkatanBiayaTetap)
        Me.BunifuCards4.Controls.Add(Me.txtPeningkatanMarginKontribusi)
        Me.BunifuCards4.Controls.Add(Me.Label6)
        Me.BunifuCards4.Controls.Add(Me.txtPeningkatanBiayaVariabel)
        Me.BunifuCards4.Controls.Add(Me.txtPeningkatanSales)
        Me.BunifuCards4.Controls.Add(Me.Label17)
        Me.BunifuCards4.LeftSahddow = False
        Me.BunifuCards4.Location = New System.Drawing.Point(643, 16)
        Me.BunifuCards4.Name = "BunifuCards4"
        Me.BunifuCards4.RightSahddow = True
        Me.BunifuCards4.ShadowDepth = 20
        Me.BunifuCards4.Size = New System.Drawing.Size(174, 338)
        Me.BunifuCards4.TabIndex = 156
        '
        'txtPeningkatanLabaBersih
        '
        Me.txtPeningkatanLabaBersih.Enabled = False
        Me.txtPeningkatanLabaBersih.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeningkatanLabaBersih.Location = New System.Drawing.Point(12, 291)
        Me.txtPeningkatanLabaBersih.MaxLength = 40
        Me.txtPeningkatanLabaBersih.Name = "txtPeningkatanLabaBersih"
        Me.txtPeningkatanLabaBersih.Size = New System.Drawing.Size(144, 31)
        Me.txtPeningkatanLabaBersih.TabIndex = 151
        '
        'txtPeningkatanBiayaTetap
        '
        Me.txtPeningkatanBiayaTetap.Enabled = False
        Me.txtPeningkatanBiayaTetap.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeningkatanBiayaTetap.Location = New System.Drawing.Point(12, 217)
        Me.txtPeningkatanBiayaTetap.MaxLength = 40
        Me.txtPeningkatanBiayaTetap.Name = "txtPeningkatanBiayaTetap"
        Me.txtPeningkatanBiayaTetap.Size = New System.Drawing.Size(144, 31)
        Me.txtPeningkatanBiayaTetap.TabIndex = 150
        '
        'txtPeningkatanMarginKontribusi
        '
        Me.txtPeningkatanMarginKontribusi.Enabled = False
        Me.txtPeningkatanMarginKontribusi.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeningkatanMarginKontribusi.Location = New System.Drawing.Point(12, 180)
        Me.txtPeningkatanMarginKontribusi.MaxLength = 300
        Me.txtPeningkatanMarginKontribusi.Name = "txtPeningkatanMarginKontribusi"
        Me.txtPeningkatanMarginKontribusi.Size = New System.Drawing.Size(144, 31)
        Me.txtPeningkatanMarginKontribusi.TabIndex = 149
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(42, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 16)
        Me.Label6.TabIndex = 148
        Me.Label6.Text = "Peningkatan"
        '
        'txtPeningkatanBiayaVariabel
        '
        Me.txtPeningkatanBiayaVariabel.Enabled = False
        Me.txtPeningkatanBiayaVariabel.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeningkatanBiayaVariabel.Location = New System.Drawing.Point(12, 141)
        Me.txtPeningkatanBiayaVariabel.MaxLength = 300
        Me.txtPeningkatanBiayaVariabel.Name = "txtPeningkatanBiayaVariabel"
        Me.txtPeningkatanBiayaVariabel.Size = New System.Drawing.Size(144, 31)
        Me.txtPeningkatanBiayaVariabel.TabIndex = 130
        '
        'txtPeningkatanSales
        '
        Me.txtPeningkatanSales.Enabled = False
        Me.txtPeningkatanSales.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeningkatanSales.Location = New System.Drawing.Point(12, 104)
        Me.txtPeningkatanSales.MaxLength = 300
        Me.txtPeningkatanSales.Name = "txtPeningkatanSales"
        Me.txtPeningkatanSales.Size = New System.Drawing.Size(144, 31)
        Me.txtPeningkatanSales.TabIndex = 112
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(9, 85)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(70, 16)
        Me.Label17.TabIndex = 117
        Me.Label17.Text = "Total (Rp)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(82, 307)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 16)
        Me.Label11.TabIndex = 155
        Me.Label11.Text = "Laba Bersih:"
        '
        'txtUnitSaatIni
        '
        Me.txtUnitSaatIni.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitSaatIni.Location = New System.Drawing.Point(176, 53)
        Me.txtUnitSaatIni.MaxLength = 300
        Me.txtUnitSaatIni.Name = "txtUnitSaatIni"
        Me.txtUnitSaatIni.Size = New System.Drawing.Size(127, 31)
        Me.txtUnitSaatIni.TabIndex = 147
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(27, 451)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(162, 16)
        Me.Label13.TabIndex = 142
        Me.Label13.Text = "Keputusan/Kesimpulan:"
        '
        'lblDetailKesimpulan
        '
        Me.lblDetailKesimpulan.AutoSize = True
        Me.lblDetailKesimpulan.BackColor = System.Drawing.Color.White
        Me.lblDetailKesimpulan.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetailKesimpulan.Location = New System.Drawing.Point(27, 488)
        Me.lblDetailKesimpulan.Name = "lblDetailKesimpulan"
        Me.lblDetailKesimpulan.Size = New System.Drawing.Size(664, 17)
        Me.lblDetailKesimpulan.TabIndex = 138
        Me.lblDetailKesimpulan.Text = "Perubahan Margin Kontribusi sebesar: (sales unit diharapkan * MC diharapkan) - (s" &
    "ales unit saat ini  * MC saat ini)"
        Me.lblDetailKesimpulan.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(95, 61)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 16)
        Me.Label12.TabIndex = 136
        Me.Label12.Text = "Sales Unit:"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 3
        Me.BunifuSeparator1.Location = New System.Drawing.Point(20, 428)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(860, 21)
        Me.BunifuSeparator1.TabIndex = 135
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(82, 246)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 16)
        Me.Label10.TabIndex = 131
        Me.Label10.Text = "Biaya Tetap:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(47, 204)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 16)
        Me.Label9.TabIndex = 129
        Me.Label9.Text = "Margin Kontribusi:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(27, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 16)
        Me.Label7.TabIndex = 125
        Me.Label7.Text = "Sales (sales unit):"
        '
        'txtMarginKontribusiUnit
        '
        Me.txtMarginKontribusiUnit.Enabled = False
        Me.txtMarginKontribusiUnit.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarginKontribusiUnit.Location = New System.Drawing.Point(177, 193)
        Me.txtMarginKontribusiUnit.MaxLength = 300
        Me.txtMarginKontribusiUnit.Name = "txtMarginKontribusiUnit"
        Me.txtMarginKontribusiUnit.Size = New System.Drawing.Size(127, 31)
        Me.txtMarginKontribusiUnit.TabIndex = 123
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.DarkKhaki
        Me.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClear.Font = New System.Drawing.Font("Maiandra GD", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Image = Global.BEP_App.My.Resources.Resources.icons8_cancel_30px
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClear.Location = New System.Drawing.Point(785, 387)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(85, 35)
        Me.btnClear.TabIndex = 122
        Me.btnClear.Text = "HAPUS"
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(173, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 16)
        Me.Label5.TabIndex = 121
        Me.Label5.Text = "Per Unit (Rp)"
        '
        'txtBiayaVariabelUnit
        '
        Me.txtBiayaVariabelUnit.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBiayaVariabelUnit.Location = New System.Drawing.Point(176, 156)
        Me.txtBiayaVariabelUnit.MaxLength = 300
        Me.txtBiayaVariabelUnit.Name = "txtBiayaVariabelUnit"
        Me.txtBiayaVariabelUnit.Size = New System.Drawing.Size(127, 31)
        Me.txtBiayaVariabelUnit.TabIndex = 119
        '
        'txtPenjualanUnit
        '
        Me.txtPenjualanUnit.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPenjualanUnit.Location = New System.Drawing.Point(176, 121)
        Me.txtPenjualanUnit.MaxLength = 300
        Me.txtPenjualanUnit.Name = "txtPenjualanUnit"
        Me.txtPenjualanUnit.Size = New System.Drawing.Size(127, 31)
        Me.txtPenjualanUnit.TabIndex = 118
        '
        'btnBEP
        '
        Me.btnBEP.BackColor = System.Drawing.Color.DarkKhaki
        Me.btnBEP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBEP.Font = New System.Drawing.Font("Maiandra GD", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBEP.Image = Global.BEP_App.My.Resources.Resources.icons8_checked_checkbox_30px
        Me.btnBEP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBEP.Location = New System.Drawing.Point(643, 387)
        Me.btnBEP.Name = "btnBEP"
        Me.btnBEP.Size = New System.Drawing.Size(136, 35)
        Me.btnBEP.TabIndex = 117
        Me.btnBEP.Text = "Cek Kesimpulan"
        Me.btnBEP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBEP.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(63, 164)
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
        Me.BunifuCards2.Controls.Add(Me.txtPerubahanBiayaTetap)
        Me.BunifuCards2.Controls.Add(Me.txtLabaBersihSaatIni)
        Me.BunifuCards2.Controls.Add(Me.Label16)
        Me.BunifuCards2.Controls.Add(Me.txtMarginKontribusiSaatIni)
        Me.BunifuCards2.Controls.Add(Me.txtBiayaVariabelSaatIni)
        Me.BunifuCards2.Controls.Add(Me.txtTotalPenjualanSaatIni)
        Me.BunifuCards2.Controls.Add(Me.Label1)
        Me.BunifuCards2.Controls.Add(Me.txtBiayaTetapSaatIni)
        Me.BunifuCards2.LeftSahddow = False
        Me.BunifuCards2.Location = New System.Drawing.Point(171, 15)
        Me.BunifuCards2.Name = "BunifuCards2"
        Me.BunifuCards2.RightSahddow = True
        Me.BunifuCards2.ShadowDepth = 20
        Me.BunifuCards2.Size = New System.Drawing.Size(286, 339)
        Me.BunifuCards2.TabIndex = 154
        '
        'txtPerubahanBiayaTetap
        '
        Me.txtPerubahanBiayaTetap.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPerubahanBiayaTetap.Location = New System.Drawing.Point(142, 253)
        Me.txtPerubahanBiayaTetap.MaxLength = 300
        Me.txtPerubahanBiayaTetap.Name = "txtPerubahanBiayaTetap"
        Me.txtPerubahanBiayaTetap.Size = New System.Drawing.Size(127, 31)
        Me.txtPerubahanBiayaTetap.TabIndex = 152
        '
        'txtLabaBersihSaatIni
        '
        Me.txtLabaBersihSaatIni.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLabaBersihSaatIni.Location = New System.Drawing.Point(142, 292)
        Me.txtLabaBersihSaatIni.MaxLength = 40
        Me.txtLabaBersihSaatIni.Name = "txtLabaBersihSaatIni"
        Me.txtLabaBersihSaatIni.Size = New System.Drawing.Size(127, 31)
        Me.txtLabaBersihSaatIni.TabIndex = 159
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(140, 86)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(70, 16)
        Me.Label16.TabIndex = 156
        Me.Label16.Text = "Total (Rp)"
        '
        'txtMarginKontribusiSaatIni
        '
        Me.txtMarginKontribusiSaatIni.Enabled = False
        Me.txtMarginKontribusiSaatIni.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarginKontribusiSaatIni.Location = New System.Drawing.Point(143, 179)
        Me.txtMarginKontribusiSaatIni.MaxLength = 300
        Me.txtMarginKontribusiSaatIni.Name = "txtMarginKontribusiSaatIni"
        Me.txtMarginKontribusiSaatIni.Size = New System.Drawing.Size(127, 31)
        Me.txtMarginKontribusiSaatIni.TabIndex = 158
        '
        'txtBiayaVariabelSaatIni
        '
        Me.txtBiayaVariabelSaatIni.Enabled = False
        Me.txtBiayaVariabelSaatIni.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBiayaVariabelSaatIni.Location = New System.Drawing.Point(142, 142)
        Me.txtBiayaVariabelSaatIni.MaxLength = 300
        Me.txtBiayaVariabelSaatIni.Name = "txtBiayaVariabelSaatIni"
        Me.txtBiayaVariabelSaatIni.Size = New System.Drawing.Size(127, 31)
        Me.txtBiayaVariabelSaatIni.TabIndex = 157
        '
        'txtTotalPenjualanSaatIni
        '
        Me.txtTotalPenjualanSaatIni.Enabled = False
        Me.txtTotalPenjualanSaatIni.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPenjualanSaatIni.Location = New System.Drawing.Point(142, 107)
        Me.txtTotalPenjualanSaatIni.MaxLength = 300
        Me.txtTotalPenjualanSaatIni.Name = "txtTotalPenjualanSaatIni"
        Me.txtTotalPenjualanSaatIni.Size = New System.Drawing.Size(127, 31)
        Me.txtTotalPenjualanSaatIni.TabIndex = 156
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(110, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 16)
        Me.Label1.TabIndex = 149
        Me.Label1.Text = "Saat ini"
        '
        'txtBiayaTetapSaatIni
        '
        Me.txtBiayaTetapSaatIni.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBiayaTetapSaatIni.Location = New System.Drawing.Point(142, 216)
        Me.txtBiayaTetapSaatIni.MaxLength = 40
        Me.txtBiayaTetapSaatIni.Name = "txtBiayaTetapSaatIni"
        Me.txtBiayaTetapSaatIni.Size = New System.Drawing.Size(127, 31)
        Me.txtBiayaTetapSaatIni.TabIndex = 133
        '
        'BunifuCards3
        '
        Me.BunifuCards3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BunifuCards3.BorderRadius = 5
        Me.BunifuCards3.BottomSahddow = True
        Me.BunifuCards3.color = System.Drawing.Color.Tomato
        Me.BunifuCards3.Controls.Add(Me.txtLabaBersihDiharapkan)
        Me.BunifuCards3.Controls.Add(Me.txtBiayaTetapDiharapkan)
        Me.BunifuCards3.Controls.Add(Me.txtMarginKontribusiDiharapkan)
        Me.BunifuCards3.Controls.Add(Me.Label2)
        Me.BunifuCards3.Controls.Add(Me.txtBiayaVariabelDiharapkan)
        Me.BunifuCards3.Controls.Add(Me.txtTotalPenjualanDiharapkan)
        Me.BunifuCards3.Controls.Add(Me.Label4)
        Me.BunifuCards3.Controls.Add(Me.txtUnitDiharapkan)
        Me.BunifuCards3.LeftSahddow = False
        Me.BunifuCards3.Location = New System.Drawing.Point(463, 16)
        Me.BunifuCards3.Name = "BunifuCards3"
        Me.BunifuCards3.RightSahddow = True
        Me.BunifuCards3.ShadowDepth = 20
        Me.BunifuCards3.Size = New System.Drawing.Size(174, 338)
        Me.BunifuCards3.TabIndex = 155
        '
        'txtLabaBersihDiharapkan
        '
        Me.txtLabaBersihDiharapkan.Enabled = False
        Me.txtLabaBersihDiharapkan.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLabaBersihDiharapkan.Location = New System.Drawing.Point(12, 291)
        Me.txtLabaBersihDiharapkan.MaxLength = 40
        Me.txtLabaBersihDiharapkan.Name = "txtLabaBersihDiharapkan"
        Me.txtLabaBersihDiharapkan.Size = New System.Drawing.Size(144, 31)
        Me.txtLabaBersihDiharapkan.TabIndex = 151
        '
        'txtBiayaTetapDiharapkan
        '
        Me.txtBiayaTetapDiharapkan.Enabled = False
        Me.txtBiayaTetapDiharapkan.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBiayaTetapDiharapkan.Location = New System.Drawing.Point(12, 217)
        Me.txtBiayaTetapDiharapkan.MaxLength = 40
        Me.txtBiayaTetapDiharapkan.Name = "txtBiayaTetapDiharapkan"
        Me.txtBiayaTetapDiharapkan.Size = New System.Drawing.Size(144, 31)
        Me.txtBiayaTetapDiharapkan.TabIndex = 150
        '
        'txtMarginKontribusiDiharapkan
        '
        Me.txtMarginKontribusiDiharapkan.Enabled = False
        Me.txtMarginKontribusiDiharapkan.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarginKontribusiDiharapkan.Location = New System.Drawing.Point(12, 180)
        Me.txtMarginKontribusiDiharapkan.MaxLength = 300
        Me.txtMarginKontribusiDiharapkan.Name = "txtMarginKontribusiDiharapkan"
        Me.txtMarginKontribusiDiharapkan.Size = New System.Drawing.Size(144, 31)
        Me.txtMarginKontribusiDiharapkan.TabIndex = 149
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 148
        Me.Label2.Text = "Diharapkan"
        '
        'txtBiayaVariabelDiharapkan
        '
        Me.txtBiayaVariabelDiharapkan.Enabled = False
        Me.txtBiayaVariabelDiharapkan.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBiayaVariabelDiharapkan.Location = New System.Drawing.Point(12, 141)
        Me.txtBiayaVariabelDiharapkan.MaxLength = 300
        Me.txtBiayaVariabelDiharapkan.Name = "txtBiayaVariabelDiharapkan"
        Me.txtBiayaVariabelDiharapkan.Size = New System.Drawing.Size(144, 31)
        Me.txtBiayaVariabelDiharapkan.TabIndex = 130
        '
        'txtTotalPenjualanDiharapkan
        '
        Me.txtTotalPenjualanDiharapkan.Enabled = False
        Me.txtTotalPenjualanDiharapkan.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPenjualanDiharapkan.Location = New System.Drawing.Point(12, 104)
        Me.txtTotalPenjualanDiharapkan.MaxLength = 300
        Me.txtTotalPenjualanDiharapkan.Name = "txtTotalPenjualanDiharapkan"
        Me.txtTotalPenjualanDiharapkan.Size = New System.Drawing.Size(144, 31)
        Me.txtTotalPenjualanDiharapkan.TabIndex = 112
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 16)
        Me.Label4.TabIndex = 117
        Me.Label4.Text = "Total (Rp)"
        '
        'txtUnitDiharapkan
        '
        Me.txtUnitDiharapkan.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitDiharapkan.Location = New System.Drawing.Point(12, 41)
        Me.txtUnitDiharapkan.MaxLength = 300
        Me.txtUnitDiharapkan.Name = "txtUnitDiharapkan"
        Me.txtUnitDiharapkan.Size = New System.Drawing.Size(144, 31)
        Me.txtUnitDiharapkan.TabIndex = 146
        '
        'lblDA
        '
        Me.lblDA.AutoSize = True
        Me.lblDA.BackColor = System.Drawing.Color.Transparent
        Me.lblDA.Font = New System.Drawing.Font("Maiandra GD", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDA.Location = New System.Drawing.Point(62, 16)
        Me.lblDA.Name = "lblDA"
        Me.lblDA.Size = New System.Drawing.Size(738, 35)
        Me.lblDA.TabIndex = 159
        Me.lblDA.Text = "Perubahan Dalam Biaya Tetap dan Volume Penjualan"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 650)
        Me.Controls.Add(Me.lblDA)
        Me.Controls.Add(Me.BunifuCards1)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.BunifuCards1.ResumeLayout(False)
        Me.BunifuCards1.PerformLayout()
        Me.BunifuCards4.ResumeLayout(False)
        Me.BunifuCards4.PerformLayout()
        Me.BunifuCards2.ResumeLayout(False)
        Me.BunifuCards2.PerformLayout()
        Me.BunifuCards3.ResumeLayout(False)
        Me.BunifuCards3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label13 As Label
    Friend WithEvents lblDetailKesimpulan As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents txtBiayaTetapSaatIni As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtBiayaVariabelDiharapkan As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtMarginKontribusiUnit As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtBiayaVariabelUnit As TextBox
    Friend WithEvents txtPenjualanUnit As TextBox
    Friend WithEvents btnBEP As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTotalPenjualanDiharapkan As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUnitSaatIni As TextBox
    Friend WithEvents txtUnitDiharapkan As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents BunifuCards2 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents txtLabaBersihSaatIni As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtMarginKontribusiSaatIni As TextBox
    Friend WithEvents txtBiayaVariabelSaatIni As TextBox
    Friend WithEvents txtTotalPenjualanSaatIni As TextBox
    Friend WithEvents BunifuCards3 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents txtLabaBersihDiharapkan As TextBox
    Friend WithEvents txtBiayaTetapDiharapkan As TextBox
    Friend WithEvents txtMarginKontribusiDiharapkan As TextBox
    Friend WithEvents lblDA As Label
    Friend WithEvents BunifuCards4 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents txtPeningkatanLabaBersih As TextBox
    Friend WithEvents txtPeningkatanBiayaTetap As TextBox
    Friend WithEvents txtPeningkatanMarginKontribusi As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPeningkatanBiayaVariabel As TextBox
    Friend WithEvents txtPeningkatanSales As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtPerubahanBiayaTetap As TextBox
End Class
