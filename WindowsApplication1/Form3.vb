Public Class Form3
    Public Parar As Boolean

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox12.Text = String.Empty Then
            MsgBox("Debe seleccionar una ruta al fichero", vbCritical)
            Exit Sub
        End If
        If TextBox11.Text = String.Empty Then
            MsgBox("Debe seleccionar un nombre de archivo html", vbCritical)
            Exit Sub
        End If
        Dim file As System.IO.StreamWriter
        Dim file_path As String
        file_path = TextBox12.Text + "\" + TextBox11.Text + ".html"
        Try
            file = My.Computer.FileSystem.OpenTextFileWriter(file_path, False, System.Text.Encoding.Default)
            'System.Text.Encoding.Default
        Catch ex As System.Exception
            MsgBox("Error: " + ex.Message, vbCritical)
            Exit Sub
        End Try
        file.WriteLine("<!DOCTYPE html PUBLIC " + """-//W3C//DTD XHTML 1.0 Transitional//EN""" + " " + """http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd""" + ">")
        file.WriteLine("<html xmlns=" + """http://www.w3.org/1999/xhtml""" + ">")
        file.WriteLine("<head>")
        file.WriteLine("<meta http-equiv=" + """Content-Type""" + " " + "content=""" + "text/html; charset= iso-8859-1" + """" + "/>")

        Dim titulo_vp As String
        titulo_vp = TextBox1.Text

        file.WriteLine("<title>" + titulo_vp + "</title>")
        file.WriteLine("<style type=" + """text/css""" + ">")
        file.WriteLine(".Titulo {")
        file.WriteLine("font-family: Tahoma, Geneva, sans-serif;")
        file.WriteLine("}")
        file.WriteLine(".Head1 {")
        file.WriteLine("	font-family: Tahoma, Geneva, sans-serif;")
        file.WriteLine("}")
        file.WriteLine(".Head2 {")
        file.WriteLine("font-family: Tahoma, Geneva, sans-serif;")
        file.WriteLine("}")
        file.WriteLine(".pie {")
        file.WriteLine("font-family: Tahoma, Geneva, sans-serif;")
        file.WriteLine("'}")
        file.WriteLine("body,td,th {")
        file.WriteLine("font-size: 12px;")
        file.WriteLine("}")
        file.WriteLine("</style>")
        file.WriteLine("</head>")
        file.WriteLine("<body>")

        Dim titulo_cabecera_pagina As String
        titulo_cabecera_pagina = TextBox2.Text

        file.WriteLine("<h1 align=" + """center""" + " class=" + """Titulo""" + "><strong>" + titulo_cabecera_pagina + "</strong></h1>")

        Dim fecha_pagina, subtitulo_cabecera As String
        fecha_pagina = TextBox3.Text
        subtitulo_cabecera = TextBox4.Text

        file.WriteLine("<p align=" + """center""" + "><strong>" + fecha_pagina + " - " + subtitulo_cabecera + "</strong><p align=" + """center""" + ">")

        Dim url_poster As String
        url_poster = TextBox5.Text

        file.WriteLine("<video controls  poster=" + """" + url_poster + """" + " " + "width=" + """500""" + " " + "height=" + """375""" + ">")

        Dim url_mp4 As String
        url_mp4 = TextBox6.Text

        file.WriteLine("<source src=" + """" + url_mp4 + """" + " " + "type=" + """video/mp4""" + " " + "/>")
        Dim url_webm As String
        url_webm = TextBox7.Text
        file.WriteLine("<source src=" + """" + url_webm + """" + " " + "type=" + """video/webm""" + " " + "/>")
        Dim file_flv As String
        file_flv = TextBox8.Text
        Dim carpeta_videos_remota As String
        carpeta_videos_remota = TextBox9.Text
        
        file.WriteLine("<embed name=" + """player""" + "src=" + """http://stream.globalplaza.org/reproductor/mediaplayer-new.swf?file=" + carpeta_videos_remota + "/" + file_flv + "&amp;searchbar=false&amp;displayheight=281&amp;displaywidth=500&amp;autostart=false&amp;image=" + url_poster + "&amp;bufferlength=3&amp;streamer=rtmp://stream.globalplaza.org/venusStore/_definst_/""" + " " + "allowfullscreen=" + """true""" + " " + "wmode=" + """transparent""" + " " + "height=" + """281""" + " " + "width=" + """500""" + ">")
        file.WriteLine("</video>")
        file.WriteLine("<div align=" + """center""" + ">")
        file.WriteLine("<table width=" + """258""" + " " + "border=" + """0""" + ">")
        file.WriteLine("<tr>")

        If chk_logo.CheckState = CheckState.Checked Then
            file.WriteLine("<td width=" + """33""" + " " + "height=" + """35""" + "><img src=" + "" & text_logo.Text & "" + " " + "width=" + """33""" + " " + "height=" + """33""" + " " + "alt=" + """dit""" + " " + "/></td>")
        End If

        Dim pie_pagina As String
        pie_pagina = TextBox10.Text
        file.WriteLine("<td width=" + """179""" + "><span class=" + """pie""" + ">" + pie_pagina + "</span></td>")
        file.WriteLine("</tr>")
        file.WriteLine("</table>")
        file.WriteLine("</div>")
        file.WriteLine("</div>")
        file.WriteLine("<p>&nbsp;</p>")
        file.WriteLine("</body>")
        file.WriteLine("</html>")
        file.Close()
        Process.Start(file_path)
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        text_logo.Text = My.Settings.logo_pie

        Tt1.SetToolTip(ffmpeg_custom_load_1, "Cargar ruta url para visualizar fichero html subido")
        Tt1.SetToolTip(ffmpeg_custom_save_1, "Guardar ruta url para visualizar fichero html subido")
        Tt1.SetToolTip(text_web_base, "Ruta url para visualizar fichero html subido")

        text_web_base.Text = My.Settings.url_base_videos
        TextBox12.Text = My.Computer.FileSystem.SpecialDirectories.Desktop
        For Each node As TreeNode In Form1.TreeView1.Nodes
            If node.IsSelected = True Then
                TextBox11.Text = Strings.Left(Form1.TreeView1.SelectedNode.Text, Form1.TreeView1.SelectedNode.Text.Length - 4)
                Dim path As String
                Dim restar As Integer
                path = Form1.ListBox1.Nodes(Form1.TreeView1.SelectedNode.Index).Text
                restar = Form1.ListBox1.Nodes(Form1.TreeView1.SelectedNode.Index).Text.Length - (Form1.TreeView1.SelectedNode.Text.Length + 1)
                TextBox12.Text = Strings.Left(path, restar)
            End If
        Next
        TextBox3.Text = System.DateTime.Today
        TextBox12.Enabled = False
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = String.Empty Or TextBox2.Text = String.Empty Then
            If MsgBox("Uno de los títulos principales está en blanco. Esta acción sobreescribirá todos los campos. ¿Desea Continuar?", vbQuestion + vbYesNo) = MsgBoxResult.Yes Then
                My.Settings.titulo_web = TextBox1.Text
                My.Settings.titulo_html = TextBox2.Text
                My.Settings.subtitulo_html = TextBox4.Text
                My.Settings.url_imagen = TextBox5.Text
                My.Settings.mp4_html = TextBox6.Text
                My.Settings.webm_html = TextBox7.Text
                My.Settings.fichero_flv = TextBox8.Text
                My.Settings.carpeta_flash_server = TextBox9.Text
                My.Settings.pie_html = TextBox10.Text
                My.Settings.Save()
            End If
        Else
            My.Settings.titulo_web = TextBox1.Text
            My.Settings.titulo_html = TextBox2.Text
            My.Settings.subtitulo_html = TextBox4.Text
            My.Settings.url_imagen = TextBox5.Text
            My.Settings.mp4_html = TextBox6.Text
            My.Settings.webm_html = TextBox7.Text
            My.Settings.fichero_flv = TextBox8.Text
            My.Settings.carpeta_flash_server = TextBox9.Text
            My.Settings.pie_html = TextBox10.Text
            My.Settings.Save()
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim c As Control
        For Each c In Me.Controls
            If TypeOf (c) Is TextBox Then
                DirectCast(c, TextBox).Text = String.Empty
            End If
        Next
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = My.Settings.titulo_web
        TextBox2.Text = My.Settings.titulo_html
        TextBox3.Text = System.DateTime.Today
        TextBox4.Text = My.Settings.subtitulo_html
        TextBox5.Text = My.Settings.url_imagen
        TextBox6.Text = My.Settings.mp4_html
        TextBox7.Text = My.Settings.webm_html
        TextBox8.Text = My.Settings.fichero_flv
        TextBox9.Text = My.Settings.carpeta_flash_server
        TextBox10.Text = My.Settings.pie_html
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox12.Enabled = True
        FolderBrowserDialog1.ShowDialog()
        TextBox12.Text = FolderBrowserDialog1.SelectedPath
        TextBox12.Enabled = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TextBox12.Text = String.Empty Then
            MsgBox("Debe seleccionar una ruta al fichero", vbCritical)
            Exit Sub
        End If
        If TextBox11.Text = String.Empty Then
            MsgBox("Debe seleccionar un nombre de archivo html", vbCritical)
            Exit Sub
        End If
        Dim file As System.IO.StreamWriter
        Dim file_path As String
        file_path = TextBox12.Text + "\" + TextBox11.Text + ".html"
        Try
            file = My.Computer.FileSystem.OpenTextFileWriter(file_path, False, System.Text.Encoding.Default)
            'System.Text.Encoding.Default
        Catch ex As System.Exception
            MsgBox("Error: " + ex.Message, vbCritical)
            Exit Sub
        End Try
        file.WriteLine("<!DOCTYPE html PUBLIC " + """-//W3C//DTD XHTML 1.0 Transitional//EN""" + " " + """http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd""" + ">")
        file.WriteLine("<html xmlns=" + """http://www.w3.org/1999/xhtml""" + ">")
        file.WriteLine("<head>")
        file.WriteLine("<meta http-equiv=" + """Content-Type""" + " " + "content=""" + "text/html; charset= iso-8859-1" + """" + "/>")

        Dim titulo_vp As String
        titulo_vp = TextBox1.Text

        file.WriteLine("<title>" + titulo_vp + "</title>")
        file.WriteLine("<style type=" + """text/css""" + ">")
        file.WriteLine(".Titulo {")
        file.WriteLine("font-family: Tahoma, Geneva, sans-serif;")
        file.WriteLine("}")
        file.WriteLine(".Head1 {")
        file.WriteLine("	font-family: Tahoma, Geneva, sans-serif;")
        file.WriteLine("}")
        file.WriteLine(".Head2 {")
        file.WriteLine("font-family: Tahoma, Geneva, sans-serif;")
        file.WriteLine("}")
        file.WriteLine(".pie {")
        file.WriteLine("font-family: Tahoma, Geneva, sans-serif;")
        file.WriteLine("'}")
        file.WriteLine("body,td,th {")
        file.WriteLine("font-size: 12px;")
        file.WriteLine("}")
        file.WriteLine("</style>")
        file.WriteLine("</head>")
        file.WriteLine("<body>")

        Dim titulo_cabecera_pagina As String
        titulo_cabecera_pagina = TextBox2.Text

        file.WriteLine("<h1 align=" + """center""" + " class=" + """Titulo""" + "><strong>" + titulo_cabecera_pagina + "</strong></h1>")

        Dim fecha_pagina, subtitulo_cabecera As String
        fecha_pagina = TextBox3.Text
        subtitulo_cabecera = TextBox4.Text

        file.WriteLine("<p align=" + """center""" + "><strong>" + fecha_pagina + " - " + subtitulo_cabecera + "</strong><p align=" + """center""" + ">")

        Dim url_poster As String
        url_poster = TextBox5.Text

        file.WriteLine("<video controls  poster=" + """" + url_poster + """" + " " + "width=" + """500""" + " " + "height=" + """375""" + ">")

        Dim url_mp4 As String
        url_mp4 = TextBox6.Text

        file.WriteLine("<source src=" + """" + url_mp4 + """" + " " + "type=" + """video/mp4""" + " " + "/>")
        Dim url_webm As String
        url_webm = TextBox7.Text
        file.WriteLine("<source src=" + """" + url_webm + """" + " " + "type=" + """video/webm""" + " " + "/>")
        Dim file_flv As String
        file_flv = TextBox8.Text
        Dim carpeta_videos_remota As String
        carpeta_videos_remota = TextBox9.Text

        file.WriteLine("<embed name=" + """player""" + "src=" + """http://stream.globalplaza.org/reproductor/mediaplayer-new.swf?file=" + carpeta_videos_remota + "/" + file_flv + "&amp;searchbar=false&amp;displayheight=281&amp;displaywidth=500&amp;autostart=false&amp;image=" + url_poster + "&amp;bufferlength=3&amp;streamer=rtmp://stream.globalplaza.org/venusStore/_definst_/""" + " " + "allowfullscreen=" + """true""" + " " + "wmode=" + """transparent""" + " " + "height=" + """281""" + " " + "width=" + """500""" + ">")
        file.WriteLine("</video>")
        file.WriteLine("<div align=" + """center""" + ">")
        file.WriteLine("<table width=" + """258""" + " " + "border=" + """0""" + ">")
        file.WriteLine("<tr>")

        If chk_logo.CheckState = CheckState.Checked Then
            file.WriteLine("<td width=" + """33""" + " " + "height=" + """35""" + "><img src=" + "" & text_logo.Text & "" + " " + "width=" + """33""" + " " + "height=" + """33""" + " " + "alt=" + """dit""" + " " + "/></td>")
        End If

        Dim pie_pagina As String
        pie_pagina = TextBox10.Text
        file.WriteLine("<td width=" + """179""" + "><span class=" + """pie""" + ">" + pie_pagina + "</span></td>")
        file.WriteLine("</tr>")
        file.WriteLine("</table>")
        file.WriteLine("</div>")
        file.WriteLine("</div>")
        file.WriteLine("<p>&nbsp;</p>")
        file.WriteLine("</body>")
        file.WriteLine("</html>")
        file.Close()
        WebBrowser1.Navigate(file_path)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Parar = False
        If TextBox12.Text = String.Empty Then
            MsgBox("Debe seleccionar una ruta al fichero", vbCritical)
            Exit Sub
        End If
        If TextBox11.Text = String.Empty Then
            MsgBox("Debe seleccionar un nombre de archivo html", vbCritical)
            Exit Sub
        End If
        Dim file As System.IO.StreamWriter
        Dim file_path As String
        file_path = TextBox12.Text + "\" + TextBox11.Text + ".html"
        Try
            file = My.Computer.FileSystem.OpenTextFileWriter(file_path, False, System.Text.Encoding.Default)
            'System.Text.Encoding.Default
        Catch ex As System.Exception
            MsgBox("Error: " + ex.Message, vbCritical)
            Exit Sub
        End Try
        file.WriteLine("<!DOCTYPE html PUBLIC " + """-//W3C//DTD XHTML 1.0 Transitional//EN""" + " " + """http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd""" + ">")
        file.WriteLine("<html xmlns=" + """http://www.w3.org/1999/xhtml""" + ">")
        file.WriteLine("<head>")
        file.WriteLine("<meta http-equiv=" + """Content-Type""" + " " + "content=""" + "text/html; charset= iso-8859-1" + """" + "/>")

        Dim titulo_vp As String
        titulo_vp = TextBox1.Text

        file.WriteLine("<title>" + titulo_vp + "</title>")
        file.WriteLine("<style type=" + """text/css""" + ">")
        file.WriteLine(".Titulo {")
        file.WriteLine("font-family: Tahoma, Geneva, sans-serif;")
        file.WriteLine("}")
        file.WriteLine(".Head1 {")
        file.WriteLine("	font-family: Tahoma, Geneva, sans-serif;")
        file.WriteLine("}")
        file.WriteLine(".Head2 {")
        file.WriteLine("font-family: Tahoma, Geneva, sans-serif;")
        file.WriteLine("}")
        file.WriteLine(".pie {")
        file.WriteLine("font-family: Tahoma, Geneva, sans-serif;")
        file.WriteLine("'}")
        file.WriteLine("body,td,th {")
        file.WriteLine("font-size: 12px;")
        file.WriteLine("}")
        file.WriteLine("</style>")
        file.WriteLine("</head>")
        file.WriteLine("<body>")

        Dim titulo_cabecera_pagina As String
        titulo_cabecera_pagina = TextBox2.Text

        file.WriteLine("<h1 align=" + """center""" + " class=" + """Titulo""" + "><strong>" + titulo_cabecera_pagina + "</strong></h1>")

        Dim fecha_pagina, subtitulo_cabecera As String
        fecha_pagina = TextBox3.Text
        subtitulo_cabecera = TextBox4.Text

        file.WriteLine("<p align=" + """center""" + "><strong>" + fecha_pagina + " - " + subtitulo_cabecera + "</strong><p align=" + """center""" + ">")

        Dim url_poster As String
        url_poster = TextBox5.Text

        file.WriteLine("<video controls  poster=" + """" + url_poster + """" + " " + "width=" + """500""" + " " + "height=" + """375""" + ">")

        Dim url_mp4 As String
        url_mp4 = TextBox6.Text

        file.WriteLine("<source src=" + """" + url_mp4 + """" + " " + "type=" + """video/mp4""" + " " + "/>")
        Dim url_webm As String
        url_webm = TextBox7.Text
        file.WriteLine("<source src=" + """" + url_webm + """" + " " + "type=" + """video/webm""" + " " + "/>")
        Dim file_flv As String
        file_flv = TextBox8.Text
        Dim carpeta_videos_remota As String
        carpeta_videos_remota = TextBox9.Text

        file.WriteLine("<embed name=" + """player""" + "src=" + """http://stream.globalplaza.org/reproductor/mediaplayer-new.swf?file=" + carpeta_videos_remota + "/" + file_flv + "&amp;searchbar=false&amp;displayheight=281&amp;displaywidth=500&amp;autostart=false&amp;image=" + url_poster + "&amp;bufferlength=3&amp;streamer=rtmp://stream.globalplaza.org/venusStore/_definst_/""" + " " + "allowfullscreen=" + """true""" + " " + "wmode=" + """transparent""" + " " + "height=" + """281""" + " " + "width=" + """500""" + ">")
        file.WriteLine("</video>")
        file.WriteLine("<div align=" + """center""" + ">")
        file.WriteLine("<table width=" + """258""" + " " + "border=" + """0""" + ">")
        file.WriteLine("<tr>")
        If chk_logo.CheckState = CheckState.Checked Then
            file.WriteLine("<td width=" + """33""" + " " + "height=" + """35""" + "><img src=" + "" & text_logo.Text & "" + " " + "width=" + """33""" + " " + "height=" + """33""" + " " + "alt=" + """dit""" + " " + "/></td>")
        End If
        Dim pie_pagina As String
        pie_pagina = TextBox10.Text
        file.WriteLine("<td width=" + """179""" + "><span class=" + """pie""" + ">" + pie_pagina + "</span></td>")
        file.WriteLine("</tr>")
        file.WriteLine("</table>")
        file.WriteLine("</div>")
        file.WriteLine("</div>")
        file.WriteLine("<p>&nbsp;</p>")
        file.WriteLine("</body>")
        file.WriteLine("</html>")
        file.Close()

        'Winscp Upload

        If Not My.Computer.FileSystem.FileExists(My.Settings.winscp_exe_location) Then
            MsgBox("Debe indicar la ruta del conversor winscp para continuar", MsgBoxStyle.Exclamation)
            With Form1.OpenFileDialog2
                If .ShowDialog = Windows.Forms.DialogResult.Cancel Then
                    MsgBox("El programa requiere winscp.exe en su equipo para continuar", MsgBoxStyle.Critical)
                    Exit Sub
                Else
                    Form1.OpenFileDialog2.Filter = "Ejecutable winscp (winscp.exe)|winscp.exe"
                    Dim winscp_exe_path As String
                    winscp_exe_path = Form1.OpenFileDialog2.FileName
                    My.Settings.winscp_exe_location = winscp_exe_path
                    My.Settings.Save()
                    Form1.TextBWscp.Text = My.Settings.winscp_exe_location
                End If
            End With
        End If
        If My.Settings.winscp_destination = "" Or My.Settings.winscp_server = "" Or My.Settings.winscp_user = "" Then
            MsgBox("Debe completar los campos de configuración de WinSCP para continuar", MsgBoxStyle.Critical)
            Exit Sub
        End If

        'Parámetros de subida winscp

        Dim destino, Wserver, username, pwd As String
        destino = Form1.TextBox4.Text
        Wserver = Form1.TextBox1.Text
        username = Form1.TextBox2.Text
        pwd = Form1.TextBox3.Text

        'winscp_upload = My.Settings.winscp_exe_location + " /console /command ""option batch on"" ""option confirm off "" ""open " + username + ":" + pwd + "@" + Wserver + """" + " " + """" + "put " + """""" + file_path + """""" + " " + destino + """" + " " + """" + "exit" + """"
        Dim winscp_file As String = My.Settings.winscp_exe_location
        Dim argums As String
        argums = " /console /command ""option batch on""" + " " + """option confirm off""" + " " + """open " + username + ":" + pwd + "@" + Wserver + """" + " " + """" + "put " + """""" + file_path + """""" + " " + destino + """" + " " + """" + "exit" + """"
        ShellandWait_2(winscp_file, argums, "winscp")
        If Parar = True Then Exit Sub
        MsgBox("Proceso de subida finalizado", vbInformation)

        'Abrir web creada y subida
        If text_web_base.Text <> String.Empty Then
            'MsgBox(text_web_base.Text & "/" & TextBox9.Text & "/" & TextBox11.Text)
            Process.Start(text_web_base.Text & "/" & TextBox9.Text & "/" & TextBox11.Text)
        End If
    End Sub

    Public Function ShellandWait_2(ByVal ProcessPath As String, arguments As String, ByVal ext_app As String)
        Dim objProcess As System.Diagnostics.Process

        Try

            objProcess = New System.Diagnostics.Process()
            objProcess.StartInfo.FileName = ProcessPath
            objProcess.StartInfo.Arguments = arguments
            objProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            objProcess.Start()

            'Wait until the process passes back an exit code 
            objProcess.WaitForExit()
            If objProcess.ExitCode <> 0 Then
                Parar = True
                If ext_app = "ffmpeg" Then
                    MsgBox("FFmpeg devolvió un error de salida código " & objProcess.ExitCode & ". Revise el fichero de origen y los parámetros.", vbCritical)
                    Parar = True
                ElseIf ext_app = "winscp" Then
                    Parar = True
                    MsgBox("Winscp devolvió un error al subir el fichero. Revise la configuración del servidor. Si desea sobreescribir el fichero de destino, active la casilla correspondiente.", vbCritical)
                Else
                    Parar = True
                    MsgBox("Se produjo un error en el programa externo.", vbCritical)
                End If
            End If
            'Free resources associated with this process
            objProcess.Close()
        Catch

            If ext_app = "ffmpeg" Then
                MessageBox.Show("FFmpeg devolvió un error. Código " & ProcessPath, "Error")
            ElseIf ext_app = "winscp" Then
                MessageBox.Show("Error en la subida del fichero." & " " & ProcessPath, "Error")
            Else
                MessageBox.Show("Error en el programa externo." & " " & ProcessPath, "Error")
            End If
            Parar = True
        End Try

    End Function

    
    Private Sub ffmpeg_custom_save_1_Click(sender As Object, e As EventArgs) Handles ffmpeg_custom_save_1.Click
        If text_web_base.Text <> String.Empty Then
            My.Settings.url_base_videos = text_web_base.Text
        End If
    End Sub

    Private Sub ffmpeg_custom_load_1_Click(sender As Object, e As EventArgs) Handles ffmpeg_custom_load_1.Click
        text_web_base.Text = My.Settings.url_base_videos
    End Sub

    Private Sub btn_save_logo_setting_Click(sender As Object, e As EventArgs) Handles btn_save_logo_setting.Click
        If text_logo.Text <> String.Empty Then
            My.Settings.logo_pie = text_logo.Text
        End If
    End Sub
End Class