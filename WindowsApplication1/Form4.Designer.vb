<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.save_upload = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Btn_Guardar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pic_Controls = New System.Windows.Forms.PictureBox()
        Me.Btn_Pegar = New System.Windows.Forms.Button()
        Me.BtnCapture = New System.Windows.Forms.Button()
        Me.cbox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Controls, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.AllowDrop = True
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(0, 0)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(500, 345)
        Me.AxWindowsMediaPlayer1.TabIndex = 32
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(502, 282)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(499, 15)
        Me.TextBox1.TabIndex = 41
        Me.TextBox1.Text = "IMAGEN CAPTURADA APARECERÁ EN EL CUADRO SUPERIOR"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'save_upload
        '
        Me.save_upload.Image = Global.HTML5_Video_Converter.My.Resources.Resources.save_picture_upload__37px
        Me.save_upload.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.save_upload.Location = New System.Drawing.Point(736, 299)
        Me.save_upload.Name = "save_upload"
        Me.save_upload.Size = New System.Drawing.Size(76, 45)
        Me.save_upload.TabIndex = 42
        Me.save_upload.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.save_upload.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(501, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(500, 281)
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Image = Global.HTML5_Video_Converter.My.Resources.Resources.exit_button_35px
        Me.Button2.Location = New System.Drawing.Point(954, 299)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(47, 45)
        Me.Button2.TabIndex = 40
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.Image = Global.HTML5_Video_Converter.My.Resources.Resources.Save_icon_36px
        Me.Btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_Guardar.Location = New System.Drawing.Point(677, 299)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(59, 45)
        Me.Btn_Guardar.TabIndex = 39
        Me.Btn_Guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_Guardar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.HTML5_Video_Converter.My.Resources.Resources.open_folder_icon_38px
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(502, 299)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(59, 45)
        Me.Button1.TabIndex = 38
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pic_Controls
        '
        Me.pic_Controls.Location = New System.Drawing.Point(0, 294)
        Me.pic_Controls.Name = "pic_Controls"
        Me.pic_Controls.Size = New System.Drawing.Size(500, 64)
        Me.pic_Controls.TabIndex = 37
        Me.pic_Controls.TabStop = False
        Me.pic_Controls.Visible = False
        '
        'Btn_Pegar
        '
        Me.Btn_Pegar.Image = Global.HTML5_Video_Converter.My.Resources.Resources.Paste_36px
        Me.Btn_Pegar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_Pegar.Location = New System.Drawing.Point(619, 299)
        Me.Btn_Pegar.Name = "Btn_Pegar"
        Me.Btn_Pegar.Size = New System.Drawing.Size(59, 45)
        Me.Btn_Pegar.TabIndex = 36
        Me.Btn_Pegar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_Pegar.UseVisualStyleBackColor = True
        '
        'BtnCapture
        '
        Me.BtnCapture.Image = Global.HTML5_Video_Converter.My.Resources.Resources.screenshot_36px
        Me.BtnCapture.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCapture.Location = New System.Drawing.Point(561, 299)
        Me.BtnCapture.Name = "BtnCapture"
        Me.BtnCapture.Size = New System.Drawing.Size(59, 45)
        Me.BtnCapture.TabIndex = 35
        Me.BtnCapture.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCapture.UseVisualStyleBackColor = True
        '
        'cbox1
        '
        Me.cbox1.FormattingEnabled = True
        Me.cbox1.Items.AddRange(New Object() {"16:9", "4:3"})
        Me.cbox1.Location = New System.Drawing.Point(819, 315)
        Me.cbox1.Name = "cbox1"
        Me.cbox1.Size = New System.Drawing.Size(47, 21)
        Me.cbox1.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(819, 299)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Aspecto"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1002, 348)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbox1)
        Me.Controls.Add(Me.save_upload)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Btn_Guardar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pic_Controls)
        Me.Controls.Add(Me.Btn_Pegar)
        Me.Controls.Add(Me.BtnCapture)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HTML5 Video converter - Captura de pantalla de vídeo"
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Controls, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Btn_Pegar As System.Windows.Forms.Button
    Friend WithEvents BtnCapture As System.Windows.Forms.Button
    Friend WithEvents pic_Controls As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents save_upload As System.Windows.Forms.Button
    Friend WithEvents cbox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
