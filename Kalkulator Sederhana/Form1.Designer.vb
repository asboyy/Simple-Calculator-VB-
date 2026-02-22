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
        Me.txtBil1 = New System.Windows.Forms.TextBox()
        Me.txtBil2 = New System.Windows.Forms.TextBox()
        Me.cbOperasi = New System.Windows.Forms.ComboBox()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.txtHasil = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtBil1
        '
        Me.txtBil1.Location = New System.Drawing.Point(221, 82)
        Me.txtBil1.Name = "txtBil1"
        Me.txtBil1.Size = New System.Drawing.Size(100, 20)
        Me.txtBil1.TabIndex = 0
        '
        'txtBil2
        '
        Me.txtBil2.Location = New System.Drawing.Point(221, 121)
        Me.txtBil2.Name = "txtBil2"
        Me.txtBil2.Size = New System.Drawing.Size(100, 20)
        Me.txtBil2.TabIndex = 1
        '
        'cbOperasi
        '
        Me.cbOperasi.FormattingEnabled = True
        Me.cbOperasi.Items.AddRange(New Object() {"+", "-", "*", "/"})
        Me.cbOperasi.Location = New System.Drawing.Point(221, 158)
        Me.cbOperasi.Name = "cbOperasi"
        Me.cbOperasi.Size = New System.Drawing.Size(122, 21)
        Me.cbOperasi.TabIndex = 2
        '
        'btnHitung
        '
        Me.btnHitung.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnHitung.Location = New System.Drawing.Point(221, 246)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(100, 27)
        Me.btnHitung.TabIndex = 3
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = False
        '
        'txtHasil
        '
        Me.txtHasil.Location = New System.Drawing.Point(221, 201)
        Me.txtHasil.Name = "txtHasil"
        Me.txtHasil.Size = New System.Drawing.Size(100, 20)
        Me.txtHasil.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(78, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Bilangan 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(78, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Bilangan 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(78, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Operasi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(78, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Hasil"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(217, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(176, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Kalkulato Sederhana"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Kalkulator_Sederhana.My.Resources.Resources.LOGIN__2_
        Me.ClientSize = New System.Drawing.Size(567, 368)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtHasil)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.cbOperasi)
        Me.Controls.Add(Me.txtBil2)
        Me.Controls.Add(Me.txtBil1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBil1 As System.Windows.Forms.TextBox
    Friend WithEvents txtBil2 As System.Windows.Forms.TextBox
    Friend WithEvents cbOperasi As System.Windows.Forms.ComboBox
    Friend WithEvents btnHitung As System.Windows.Forms.Button
    Friend WithEvents txtHasil As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
