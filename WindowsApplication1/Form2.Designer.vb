<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.CheckWebM = New System.Windows.Forms.CheckBox()
        Me.CheckFLV = New System.Windows.Forms.CheckBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.TextBWscp = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Chk_subir_originales = New System.Windows.Forms.CheckBox()
        Me.ffmpeg_custom_save_3 = New System.Windows.Forms.Button()
        Me.ffmpeg_custom_load_3 = New System.Windows.Forms.Button()
        Me.ffmpeg_custom_save_2 = New System.Windows.Forms.Button()
        Me.ffmpeg_custom_load_2 = New System.Windows.Forms.Button()
        Me.ffmpeg_custom_save_1 = New System.Windows.Forms.Button()
        Me.ffmpeg_custom_load_1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.TreeView()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txtparam = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.lbl_external = New System.Windows.Forms.Label()
        Me.Pgr1 = New System.Windows.Forms.ProgressBar()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lbl_count = New System.Windows.Forms.Label()
        Me.opt1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.opt2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_webm = New System.Windows.Forms.Button()
        Me.flv_hq = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.menu1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CheckWebM
        '
        Me.CheckWebM.AutoSize = True
        Me.CheckWebM.Checked = True
        Me.CheckWebM.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckWebM.Location = New System.Drawing.Point(28, 29)
        Me.CheckWebM.Name = "CheckWebM"
        Me.CheckWebM.Size = New System.Drawing.Size(116, 17)
        Me.CheckWebM.TabIndex = 2
        Me.CheckWebM.Text = "WebM (600K/96K)"
        Me.CheckWebM.UseVisualStyleBackColor = True
        '
        'CheckFLV
        '
        Me.CheckFLV.AutoSize = True
        Me.CheckFLV.Checked = True
        Me.CheckFLV.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckFLV.Location = New System.Drawing.Point(28, 47)
        Me.CheckFLV.Name = "CheckFLV"
        Me.CheckFLV.Size = New System.Drawing.Size(121, 17)
        Me.CheckFLV.TabIndex = 3
        Me.CheckFLV.Text = "FLV (Sin recodificar)"
        Me.CheckFLV.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Multiselect = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Destino"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(72, 106)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(231, 20)
        Me.TextBox4.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Contraseña"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Usuario"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Servidor"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(72, 83)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(231, 20)
        Me.TextBox3.TabIndex = 17
        Me.TextBox3.UseSystemPasswordChar = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(72, 61)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(231, 20)
        Me.TextBox2.TabIndex = 16
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(72, 39)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(231, 20)
        Me.TextBox1.TabIndex = 15
        '
        'Button5
        '
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button5.Location = New System.Drawing.Point(251, 92)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(55, 21)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "Buscar"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(95, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(183, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "CONFIGURACIÓN DE WINSCP"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(79, 93)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(167, 20)
        Me.TextBox5.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Ruta FFmpeg"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Controls.Add(Me.Button8)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.Button13)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(401, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(315, 368)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button7.Location = New System.Drawing.Point(71, 161)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(116, 61)
        Me.Button7.TabIndex = 13
        Me.Button7.Text = "Subir ficheros"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Image = Global.HTML5_Video_Converter.My.Resources.Resources.WinSCP_folder_39px
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button8.Location = New System.Drawing.Point(187, 161)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(116, 61)
        Me.Button8.TabIndex = 14
        Me.Button8.Text = "Listar carpeta"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button8.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.CheckBox5)
        Me.GroupBox5.Controls.Add(Me.Button9)
        Me.GroupBox5.Controls.Add(Me.TextBWscp)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.TextBox5)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.CheckBox2)
        Me.GroupBox5.Controls.Add(Me.Button5)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Location = New System.Drawing.Point(1, 218)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(310, 145)
        Me.GroupBox5.TabIndex = 34
        Me.GroupBox5.TabStop = False
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Checked = True
        Me.CheckBox5.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox5.Location = New System.Drawing.Point(87, 56)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(130, 17)
        Me.CheckBox5.TabIndex = 34
        Me.CheckBox5.Text = "Sobreescribir archivos"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button9.Location = New System.Drawing.Point(251, 116)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(55, 21)
        Me.Button9.TabIndex = 29
        Me.Button9.Text = "Buscar"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button9.UseVisualStyleBackColor = True
        '
        'TextBWscp
        '
        Me.TextBWscp.Location = New System.Drawing.Point(79, 117)
        Me.TextBWscp.Name = "TextBWscp"
        Me.TextBWscp.ReadOnly = True
        Me.TextBWscp.Size = New System.Drawing.Size(167, 20)
        Me.TextBWscp.TabIndex = 28
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(84, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(148, 13)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "OPCIONES GENERALES"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Ruta WinSCP"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(87, 39)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(186, 17)
        Me.CheckBox2.TabIndex = 33
        Me.CheckBox2.Text = "Ver consola de aplicación externa"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Image = Global.HTML5_Video_Converter.My.Resources.Resources.load_icon_23px
        Me.Button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button13.Location = New System.Drawing.Point(72, 132)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(115, 23)
        Me.Button13.TabIndex = 30
        Me.Button13.Text = "        Cargar campos"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Image = Global.HTML5_Video_Converter.My.Resources.Resources.Save_icon_22px
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(186, 132)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(117, 23)
        Me.Button6.TabIndex = 12
        Me.Button6.Text = "Guardar campos"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.UseVisualStyleBackColor = True
        '
        'TreeView1
        '
        Me.TreeView1.ImageIndex = 0
        Me.TreeView1.ImageList = Me.ImageList1
        Me.TreeView1.Location = New System.Drawing.Point(6, 33)
        Me.TreeView1.Margin = New System.Windows.Forms.Padding(1)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.SelectedImageIndex = 0
        Me.TreeView1.ShowRootLines = False
        Me.TreeView1.Size = New System.Drawing.Size(227, 194)
        Me.TreeView1.TabIndex = 30
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "file_icon.png")
        Me.ImageList1.Images.SetKeyName(1, "video_file_icon.png")
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Chk_subir_originales)
        Me.GroupBox2.Controls.Add(Me.ffmpeg_custom_save_3)
        Me.GroupBox2.Controls.Add(Me.ffmpeg_custom_load_3)
        Me.GroupBox2.Controls.Add(Me.ffmpeg_custom_save_2)
        Me.GroupBox2.Controls.Add(Me.ffmpeg_custom_load_2)
        Me.GroupBox2.Controls.Add(Me.ffmpeg_custom_save_1)
        Me.GroupBox2.Controls.Add(Me.ffmpeg_custom_load_1)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TreeView1)
        Me.GroupBox2.Controls.Add(Me.Button10)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.ListBox1)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Location = New System.Drawing.Point(2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(398, 368)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        '
        'Chk_subir_originales
        '
        Me.Chk_subir_originales.AutoSize = True
        Me.Chk_subir_originales.Checked = True
        Me.Chk_subir_originales.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chk_subir_originales.Location = New System.Drawing.Point(13, 345)
        Me.Chk_subir_originales.Name = "Chk_subir_originales"
        Me.Chk_subir_originales.Size = New System.Drawing.Size(137, 17)
        Me.Chk_subir_originales.TabIndex = 35
        Me.Chk_subir_originales.Text = "Subir ficheros de origen"
        Me.Chk_subir_originales.UseVisualStyleBackColor = True
        '
        'ffmpeg_custom_save_3
        '
        Me.ffmpeg_custom_save_3.Image = Global.HTML5_Video_Converter.My.Resources.Resources.Save_icon_22px
        Me.ffmpeg_custom_save_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ffmpeg_custom_save_3.Location = New System.Drawing.Point(354, 341)
        Me.ffmpeg_custom_save_3.Name = "ffmpeg_custom_save_3"
        Me.ffmpeg_custom_save_3.Size = New System.Drawing.Size(40, 23)
        Me.ffmpeg_custom_save_3.TabIndex = 38
        Me.ffmpeg_custom_save_3.Text = "3"
        Me.ffmpeg_custom_save_3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ffmpeg_custom_save_3.UseVisualStyleBackColor = True
        '
        'ffmpeg_custom_load_3
        '
        Me.ffmpeg_custom_load_3.Image = Global.HTML5_Video_Converter.My.Resources.Resources.load_icon_23px
        Me.ffmpeg_custom_load_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ffmpeg_custom_load_3.Location = New System.Drawing.Point(315, 341)
        Me.ffmpeg_custom_load_3.Name = "ffmpeg_custom_load_3"
        Me.ffmpeg_custom_load_3.Size = New System.Drawing.Size(40, 23)
        Me.ffmpeg_custom_load_3.TabIndex = 39
        Me.ffmpeg_custom_load_3.Text = "3"
        Me.ffmpeg_custom_load_3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ffmpeg_custom_load_3.UseVisualStyleBackColor = True
        '
        'ffmpeg_custom_save_2
        '
        Me.ffmpeg_custom_save_2.Image = Global.HTML5_Video_Converter.My.Resources.Resources.Save_icon_22px
        Me.ffmpeg_custom_save_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ffmpeg_custom_save_2.Location = New System.Drawing.Point(276, 341)
        Me.ffmpeg_custom_save_2.Name = "ffmpeg_custom_save_2"
        Me.ffmpeg_custom_save_2.Size = New System.Drawing.Size(40, 23)
        Me.ffmpeg_custom_save_2.TabIndex = 36
        Me.ffmpeg_custom_save_2.Text = "2"
        Me.ffmpeg_custom_save_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ffmpeg_custom_save_2.UseVisualStyleBackColor = True
        '
        'ffmpeg_custom_load_2
        '
        Me.ffmpeg_custom_load_2.Image = Global.HTML5_Video_Converter.My.Resources.Resources.load_icon_23px
        Me.ffmpeg_custom_load_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ffmpeg_custom_load_2.Location = New System.Drawing.Point(237, 341)
        Me.ffmpeg_custom_load_2.Name = "ffmpeg_custom_load_2"
        Me.ffmpeg_custom_load_2.Size = New System.Drawing.Size(40, 23)
        Me.ffmpeg_custom_load_2.TabIndex = 37
        Me.ffmpeg_custom_load_2.Text = "2"
        Me.ffmpeg_custom_load_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ffmpeg_custom_load_2.UseVisualStyleBackColor = True
        '
        'ffmpeg_custom_save_1
        '
        Me.ffmpeg_custom_save_1.Image = Global.HTML5_Video_Converter.My.Resources.Resources.Save_icon_22px
        Me.ffmpeg_custom_save_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ffmpeg_custom_save_1.Location = New System.Drawing.Point(198, 341)
        Me.ffmpeg_custom_save_1.Name = "ffmpeg_custom_save_1"
        Me.ffmpeg_custom_save_1.Size = New System.Drawing.Size(40, 23)
        Me.ffmpeg_custom_save_1.TabIndex = 35
        Me.ffmpeg_custom_save_1.Text = "1"
        Me.ffmpeg_custom_save_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ffmpeg_custom_save_1.UseVisualStyleBackColor = True
        '
        'ffmpeg_custom_load_1
        '
        Me.ffmpeg_custom_load_1.Image = Global.HTML5_Video_Converter.My.Resources.Resources.load_icon_23px
        Me.ffmpeg_custom_load_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ffmpeg_custom_load_1.Location = New System.Drawing.Point(159, 341)
        Me.ffmpeg_custom_load_1.Name = "ffmpeg_custom_load_1"
        Me.ffmpeg_custom_load_1.Size = New System.Drawing.Size(40, 23)
        Me.ffmpeg_custom_load_1.TabIndex = 35
        Me.ffmpeg_custom_load_1.Text = "1"
        Me.ffmpeg_custom_load_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ffmpeg_custom_load_1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(51, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(129, 13)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "LISTA DE FICHEROS"
        '
        'Button10
        '
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Image = Global.HTML5_Video_Converter.My.Resources.Resources.cinema_winscp_133px
        Me.Button10.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button10.Location = New System.Drawing.Point(4, 231)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(148, 106)
        Me.Button10.TabIndex = 12
        Me.Button10.Text = "CONVERTIR Y SUBIR"
        Me.Button10.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.HTML5_Video_Converter.My.Resources.Resources.delete_45
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(236, 97)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(158, 66)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Borrar lista"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.ImageIndex = 0
        Me.ListBox1.ImageList = Me.ImageList1
        Me.ListBox1.Location = New System.Drawing.Point(6, 33)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(1)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectedImageIndex = 0
        Me.ListBox1.Size = New System.Drawing.Size(227, 189)
        Me.ListBox1.TabIndex = 29
        Me.ListBox1.Visible = False
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.HTML5_Video_Converter.My.Resources.Resources.camera_cinema_50px
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button4.Location = New System.Drawing.Point(235, 162)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(158, 66)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "            CONVERTIR"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.flv_hq)
        Me.GroupBox3.Controls.Add(Me.btn_webm)
        Me.GroupBox3.Controls.Add(Me.Button14)
        Me.GroupBox3.Controls.Add(Me.CheckBox1)
        Me.GroupBox3.Controls.Add(Me.TextBox6)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Txtparam)
        Me.GroupBox3.Controls.Add(Me.CheckFLV)
        Me.GroupBox3.Controls.Add(Me.CheckWebM)
        Me.GroupBox3.Location = New System.Drawing.Point(155, 226)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(239, 114)
        Me.GroupBox3.TabIndex = 29
        Me.GroupBox3.TabStop = False
        '
        'Button14
        '
        Me.Button14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button14.Location = New System.Drawing.Point(163, 67)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(74, 23)
        Me.Button14.TabIndex = 40
        Me.Button14.Text = "MP4 HQ"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(5, 70)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(152, 17)
        Me.CheckBox1.TabIndex = 12
        Me.CheckBox1.Text = "Parámetros personalizados"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.Enabled = False
        Me.TextBox6.Location = New System.Drawing.Point(190, 91)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(46, 20)
        Me.TextBox6.TabIndex = 32
        Me.TextBox6.Text = "Ext"
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "OPCIONES DE CONVERSIÓN"
        '
        'Txtparam
        '
        Me.Txtparam.Enabled = False
        Me.Txtparam.Location = New System.Drawing.Point(5, 91)
        Me.Txtparam.Name = "Txtparam"
        Me.Txtparam.Size = New System.Drawing.Size(184, 20)
        Me.Txtparam.TabIndex = 31
        '
        'Button3
        '
        Me.Button3.Image = Global.HTML5_Video_Converter.My.Resources.Resources.open_folder_icon2
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(236, 32)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(158, 66)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Elegir archivos"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.Multiselect = True
        '
        'lbl_external
        '
        Me.lbl_external.AutoSize = True
        Me.lbl_external.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_external.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_external.Location = New System.Drawing.Point(6, 16)
        Me.lbl_external.Name = "lbl_external"
        Me.lbl_external.Size = New System.Drawing.Size(158, 16)
        Me.lbl_external.TabIndex = 36
        Me.lbl_external.Text = "PROGRAMA EXTERNO"
        Me.lbl_external.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_external.Visible = False
        '
        'Pgr1
        '
        Me.Pgr1.Location = New System.Drawing.Point(4, 41)
        Me.Pgr1.Name = "Pgr1"
        Me.Pgr1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Pgr1.Size = New System.Drawing.Size(388, 25)
        Me.Pgr1.TabIndex = 37
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lbl_count)
        Me.GroupBox4.Controls.Add(Me.lbl_external)
        Me.GroupBox4.Controls.Add(Me.Pgr1)
        Me.GroupBox4.Location = New System.Drawing.Point(2, 366)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(397, 71)
        Me.GroupBox4.TabIndex = 38
        Me.GroupBox4.TabStop = False
        '
        'lbl_count
        '
        Me.lbl_count.AutoSize = True
        Me.lbl_count.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_count.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_count.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_count.Location = New System.Drawing.Point(269, 16)
        Me.lbl_count.Name = "lbl_count"
        Me.lbl_count.Size = New System.Drawing.Size(60, 16)
        Me.lbl_count.TabIndex = 38
        Me.lbl_count.Text = "Cuenta"
        Me.lbl_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_count.Visible = False
        '
        'opt1
        '
        Me.opt1.Name = "opt1"
        Me.opt1.Size = New System.Drawing.Size(163, 22)
        Me.opt1.Text = "Capturar imagen"
        '
        'opt2
        '
        Me.opt2.Name = "opt2"
        Me.opt2.Size = New System.Drawing.Size(163, 22)
        Me.opt2.Text = "Crear web"
        '
        'menu1
        '
        Me.menu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.opt1, Me.opt2})
        Me.menu1.Name = "menu1"
        Me.menu1.Size = New System.Drawing.Size(164, 48)
        '
        'Button12
        '
        Me.Button12.Image = Global.HTML5_Video_Converter.My.Resources.Resources.screenshot_39px
        Me.Button12.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button12.Location = New System.Drawing.Point(496, 372)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(92, 65)
        Me.Button12.TabIndex = 35
        Me.Button12.Text = "Capturar imagen"
        Me.Button12.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Image = Global.HTML5_Video_Converter.My.Resources.Resources.html5_39px
        Me.Button11.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button11.Location = New System.Drawing.Point(402, 372)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(92, 65)
        Me.Button11.TabIndex = 30
        Me.Button11.Text = "Crear Web "
        Me.Button11.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.HTML5_Video_Converter.My.Resources.Resources.exit_button_40
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(650, 372)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(66, 65)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Salir"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btn_webm
        '
        Me.btn_webm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_webm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_webm.Location = New System.Drawing.Point(163, 45)
        Me.btn_webm.Name = "btn_webm"
        Me.btn_webm.Size = New System.Drawing.Size(74, 23)
        Me.btn_webm.TabIndex = 40
        Me.btn_webm.Text = "WebM HQ"
        Me.btn_webm.UseVisualStyleBackColor = True
        '
        'flv_hq
        '
        Me.flv_hq.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.flv_hq.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.flv_hq.Location = New System.Drawing.Point(165, 23)
        Me.flv_hq.Name = "flv_hq"
        Me.flv_hq.Size = New System.Drawing.Size(71, 23)
        Me.flv_hq.TabIndex = 40
        Me.flv_hq.Text = "FLV HQ"
        Me.flv_hq.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 440)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HTML5 Video Converter"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.menu1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CheckWebM As System.Windows.Forms.CheckBox
    Friend WithEvents CheckFLV As System.Windows.Forms.CheckBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents TextBWscp As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ListBox1 As System.Windows.Forms.TreeView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents lbl_external As System.Windows.Forms.Label
    Friend WithEvents Pgr1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Txtparam As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents opt1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents opt2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ffmpeg_custom_save_3 As System.Windows.Forms.Button
    Friend WithEvents ffmpeg_custom_load_3 As System.Windows.Forms.Button
    Friend WithEvents ffmpeg_custom_save_2 As System.Windows.Forms.Button
    Friend WithEvents ffmpeg_custom_load_2 As System.Windows.Forms.Button
    Friend WithEvents ffmpeg_custom_save_1 As System.Windows.Forms.Button
    Friend WithEvents ffmpeg_custom_load_1 As System.Windows.Forms.Button
    Friend WithEvents Chk_subir_originales As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_count As System.Windows.Forms.Label
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents btn_webm As System.Windows.Forms.Button
    Friend WithEvents flv_hq As System.Windows.Forms.Button

End Class
