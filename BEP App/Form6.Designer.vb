<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.lblDA = New System.Windows.Forms.Label()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.lblHargaJualBaru = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblDetailHargaJualBaru = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtLabaAkhir = New System.Windows.Forms.TextBox()
        Me.txtBiayaVariabel = New System.Windows.Forms.TextBox()
        Me.btnBEP = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.BunifuCards1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDA
        '
        Me.lblDA.AutoSize = True
        Me.lblDA.BackColor = System.Drawing.Color.Transparent
        Me.lblDA.Font = New System.Drawing.Font("Maiandra GD", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDA.Location = New System.Drawing.Point(67, 39)
        Me.lblDA.Name = "lblDA"
        Me.lblDA.Size = New System.Drawing.Size(423, 35)
        Me.lblDA.TabIndex = 164
        Me.lblDA.Text = "Perubahan Harga Jual Reguler"
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.White
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.SystemColors.HotTrack
        Me.BunifuCards1.Controls.Add(Me.lblHargaJualBaru)
        Me.BunifuCards1.Controls.Add(Me.Label6)
        Me.BunifuCards1.Controls.Add(Me.lblDetailHargaJualBaru)
        Me.BunifuCards1.Controls.Add(Me.BunifuSeparator1)
        Me.BunifuCards1.Controls.Add(Me.Label7)
        Me.BunifuCards1.Controls.Add(Me.btnClear)
        Me.BunifuCards1.Controls.Add(Me.txtLabaAkhir)
        Me.BunifuCards1.Controls.Add(Me.txtBiayaVariabel)
        Me.BunifuCards1.Controls.Add(Me.btnBEP)
        Me.BunifuCards1.Controls.Add(Me.Label3)
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(45, 107)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(922, 460)
        Me.BunifuCards1.TabIndex = 163
        '
        'lblHargaJualBaru
        '
        Me.lblHargaJualBaru.AutoSize = True
        Me.lblHargaJualBaru.BackColor = System.Drawing.Color.White
        Me.lblHargaJualBaru.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHargaJualBaru.Location = New System.Drawing.Point(40, 306)
        Me.lblHargaJualBaru.Name = "lblHargaJualBaru"
        Me.lblHargaJualBaru.Size = New System.Drawing.Size(34, 17)
        Me.lblHargaJualBaru.TabIndex = 157
        Me.lblHargaJualBaru.Text = "MoS"
        Me.lblHargaJualBaru.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(40, 279)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 16)
        Me.Label6.TabIndex = 151
        Me.Label6.Text = "Hasil"
        '
        'lblDetailHargaJualBaru
        '
        Me.lblDetailHargaJualBaru.AutoSize = True
        Me.lblDetailHargaJualBaru.BackColor = System.Drawing.Color.White
        Me.lblDetailHargaJualBaru.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetailHargaJualBaru.Location = New System.Drawing.Point(40, 323)
        Me.lblDetailHargaJualBaru.Name = "lblDetailHargaJualBaru"
        Me.lblDetailHargaJualBaru.Size = New System.Drawing.Size(133, 17)
        Me.lblDetailHargaJualBaru.TabIndex = 138
        Me.lblDetailHargaJualBaru.Text = "Detail HargaJualBaru"
        Me.lblDetailHargaJualBaru.Visible = False
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 3
        Me.BunifuSeparator1.Location = New System.Drawing.Point(40, 255)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(837, 21)
        Me.BunifuSeparator1.TabIndex = 135
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(214, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(172, 16)
        Me.Label7.TabIndex = 125
        Me.Label7.Text = "Biaya Variabel / Unit (Rp):"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.DarkKhaki
        Me.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClear.Font = New System.Drawing.Font("Maiandra GD", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Image = Global.BEP_App.My.Resources.Resources.icons8_cancel_30px
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClear.Location = New System.Drawing.Point(528, 185)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(85, 35)
        Me.btnClear.TabIndex = 122
        Me.btnClear.Text = "HAPUS"
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'txtLabaAkhir
        '
        Me.txtLabaAkhir.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLabaAkhir.Location = New System.Drawing.Point(392, 81)
        Me.txtLabaAkhir.MaxLength = 300
        Me.txtLabaAkhir.Name = "txtLabaAkhir"
        Me.txtLabaAkhir.Size = New System.Drawing.Size(127, 31)
        Me.txtLabaAkhir.TabIndex = 119
        '
        'txtBiayaVariabel
        '
        Me.txtBiayaVariabel.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBiayaVariabel.Location = New System.Drawing.Point(392, 46)
        Me.txtBiayaVariabel.MaxLength = 300
        Me.txtBiayaVariabel.Name = "txtBiayaVariabel"
        Me.txtBiayaVariabel.Size = New System.Drawing.Size(127, 31)
        Me.txtBiayaVariabel.TabIndex = 118
        '
        'btnBEP
        '
        Me.btnBEP.BackColor = System.Drawing.Color.DarkKhaki
        Me.btnBEP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBEP.Font = New System.Drawing.Font("Maiandra GD", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBEP.Image = Global.BEP_App.My.Resources.Resources.icons8_checked_checkbox_30px
        Me.btnBEP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBEP.Location = New System.Drawing.Point(431, 185)
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
        Me.Label3.Location = New System.Drawing.Point(160, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(226, 16)
        Me.Label3.TabIndex = 113
        Me.Label3.Text = "Laba Akhir yang Diharapkan (Rp):"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Red
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Maiandra GD", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(929, 24)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(38, 37)
        Me.btnClose.TabIndex = 162
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 650)
        Me.Controls.Add(Me.lblDA)
        Me.Controls.Add(Me.BunifuCards1)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form6"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form6"
        Me.BunifuCards1.ResumeLayout(False)
        Me.BunifuCards1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDA As Label
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents lblHargaJualBaru As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblDetailHargaJualBaru As Label
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label7 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents txtLabaAkhir As TextBox
    Friend WithEvents txtBiayaVariabel As TextBox
    Friend WithEvents btnBEP As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnClose As Button
End Class
