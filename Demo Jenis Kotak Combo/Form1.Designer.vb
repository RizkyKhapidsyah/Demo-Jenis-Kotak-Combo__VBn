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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboNegara = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboMain = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboArtis = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.labelNegara = New System.Windows.Forms.Label()
        Me.labelMain = New System.Windows.Forms.Label()
        Me.labelArtis = New System.Windows.Forms.Label()
        Me.tombolTampil = New System.Windows.Forms.Button()
        Me.tombolReset = New System.Windows.Forms.Button()
        Me.tombolKeluar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pilih Sebuah Negara:"
        '
        'cboNegara
        '
        Me.cboNegara.FormattingEnabled = True
        Me.cboNegara.Items.AddRange(New Object() {"Inggris", "Irlandia", "Skotlandia", "Wales"})
        Me.cboNegara.Location = New System.Drawing.Point(126, 20)
        Me.cboNegara.Name = "cboNegara"
        Me.cboNegara.Size = New System.Drawing.Size(121, 21)
        Me.cboNegara.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Pilih Judul:"
        '
        'cboMain
        '
        Me.cboMain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboMain.FormattingEnabled = True
        Me.cboMain.Items.AddRange(New Object() {"Hamlet", "Much Ado About Nothing", "Rome and Juliet ", "A Comery of Errors", "The Merchant of Venice"})
        Me.cboMain.Location = New System.Drawing.Point(126, 59)
        Me.cboMain.Name = "cboMain"
        Me.cboMain.Size = New System.Drawing.Size(170, 85)
        Me.cboMain.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(67, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Pilih Artis:"
        '
        'cboArtis
        '
        Me.cboArtis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboArtis.FormattingEnabled = True
        Me.cboArtis.Items.AddRange(New Object() {"Michelangelo", "Raphael", "da Vinci"})
        Me.cboArtis.Location = New System.Drawing.Point(126, 152)
        Me.cboArtis.Name = "cboArtis"
        Me.cboArtis.Size = New System.Drawing.Size(96, 21)
        Me.cboArtis.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.labelArtis)
        Me.GroupBox1.Controls.Add(Me.labelMain)
        Me.GroupBox1.Controls.Add(Me.labelNegara)
        Me.GroupBox1.Location = New System.Drawing.Point(340, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(244, 162)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pilihan Anda"
        '
        'labelNegara
        '
        Me.labelNegara.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labelNegara.Location = New System.Drawing.Point(7, 20)
        Me.labelNegara.Name = "labelNegara"
        Me.labelNegara.Size = New System.Drawing.Size(231, 23)
        Me.labelNegara.TabIndex = 0
        '
        'labelMain
        '
        Me.labelMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labelMain.Location = New System.Drawing.Point(7, 68)
        Me.labelMain.Name = "labelMain"
        Me.labelMain.Size = New System.Drawing.Size(231, 23)
        Me.labelMain.TabIndex = 1
        '
        'labelArtis
        '
        Me.labelArtis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labelArtis.Location = New System.Drawing.Point(7, 115)
        Me.labelArtis.Name = "labelArtis"
        Me.labelArtis.Size = New System.Drawing.Size(231, 23)
        Me.labelArtis.TabIndex = 2
        '
        'tombolTampil
        '
        Me.tombolTampil.Location = New System.Drawing.Point(15, 217)
        Me.tombolTampil.Name = "tombolTampil"
        Me.tombolTampil.Size = New System.Drawing.Size(138, 33)
        Me.tombolTampil.TabIndex = 7
        Me.tombolTampil.Text = "Tampilkan Pilihan"
        Me.tombolTampil.UseVisualStyleBackColor = True
        '
        'tombolReset
        '
        Me.tombolReset.Location = New System.Drawing.Point(226, 217)
        Me.tombolReset.Name = "tombolReset"
        Me.tombolReset.Size = New System.Drawing.Size(138, 33)
        Me.tombolReset.TabIndex = 8
        Me.tombolReset.Text = "Reset Form"
        Me.tombolReset.UseVisualStyleBackColor = True
        '
        'tombolKeluar
        '
        Me.tombolKeluar.Location = New System.Drawing.Point(446, 217)
        Me.tombolKeluar.Name = "tombolKeluar"
        Me.tombolKeluar.Size = New System.Drawing.Size(138, 33)
        Me.tombolKeluar.TabIndex = 9
        Me.tombolKeluar.Text = "Keluar"
        Me.tombolKeluar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 262)
        Me.Controls.Add(Me.tombolKeluar)
        Me.Controls.Add(Me.tombolReset)
        Me.Controls.Add(Me.tombolTampil)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cboArtis)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboMain)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboNegara)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Demo Jenis Kotak Combo"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboNegara As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboMain As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboArtis As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents labelArtis As System.Windows.Forms.Label
    Friend WithEvents labelMain As System.Windows.Forms.Label
    Friend WithEvents labelNegara As System.Windows.Forms.Label
    Friend WithEvents tombolTampil As System.Windows.Forms.Button
    Friend WithEvents tombolReset As System.Windows.Forms.Button
    Friend WithEvents tombolKeluar As System.Windows.Forms.Button

End Class
