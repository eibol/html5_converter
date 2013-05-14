Public Class Form1
    Dim ffmpeg_path As String = My.Settings.ffmpeg_location
    Dim expl_conv As String
    Public captured As System.Drawing.Bitmap
    Public Parar As Boolean
    Dim parcial, total As Integer
    Dim overWr, overWr_winscp As String

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim agregar As Boolean = True

        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "Archivo de vídeo mp4 (*.mp4)|*.mp4|Todos los archivos (*.*)|*.*"

        With OpenFileDialog1
            If .ShowDialog = Windows.Forms.DialogResult.OK Then

                'Validar si debe ser agregado o no al treeview oculto de nombre y ruta completos.
                For Each foundFile As String In OpenFileDialog1.FileNames()

                    For Each node As TreeNode In ListBox1.Nodes
                        If node.Text = foundFile Then agregar = False
                    Next
                    If agregar = True Then ListBox1.Nodes.Add(foundFile)
                    agregar = True
                Next

                'Validar si debe ser agregado o no al treeview visible
                For Each foundFile As String In OpenFileDialog1.SafeFileNames()

                    For Each node As TreeNode In TreeView1.Nodes
                        If node.Text = foundFile Then agregar = False


                    Next
                    If agregar = True Then TreeView1.Nodes.Add(foundFile)
                    agregar = True
                Next

                ' Cambiar icono
                For Each node As TreeNode In TreeView1.Nodes
                    If Strings.Right(node.Text, 3) = "mp4" Then
                        node.ImageIndex = 1
                    Else
                        node.ImageIndex = 0
                    End If
                Next
                expl_conv = OpenFileDialog1.FileName.Replace(OpenFileDialog1.SafeFileName, "")

            End If
        End With

    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Parar = False
        If ListBox1.Nodes.Count < 1 Then
            MsgBox("No hay ficheros seleccionador para convertir", MsgBoxStyle.Exclamation)
        ElseIf CheckFLV.Checked = False And CheckWebM.Checked = False And CheckBox1.Checked = False Then
            MsgBox("No se seleccionó ningún formato de conversión", MsgBoxStyle.Exclamation)
        ElseIf CheckBox1.Checked = True And Txtparam.Text = String.Empty Then
            MsgBox("Debe rellenar los parámetros personalizados ffmpeg.", vbExclamation)
        ElseIf CheckBox1.Checked = True And Txtparam.Text <> String.Empty And TextBox6.Text = String.Empty Then
            MsgBox("Debe rellenar la extensión de fichero de destino.", vbExclamation)
        Else
            OpenFileDialog1.FileName = ""
            OpenFileDialog1.Filter = "Ejecutable ffmpeg (ffmpeg.exe)|ffmpeg.exe"
            If Not My.Computer.FileSystem.FileExists(My.Settings.ffmpeg_location) Then
                MsgBox("Debe indicar la ruta del conversor ffmpeg para continuar", MsgBoxStyle.Exclamation)
                With OpenFileDialog1
                    If .ShowDialog = Windows.Forms.DialogResult.Cancel Then
                        MsgBox("El programa requiere ffmpeg.exe para continuar", MsgBoxStyle.Critical)
                        Exit Sub
                    Else
                        ffmpeg_path = OpenFileDialog1.FileName
                        My.Settings.ffmpeg_location = ffmpeg_path
                        My.Settings.Save()
                    End If
                End With

            End If
            Dim convertir As String
            Dim target As String

            Dim n As TreeNode
            Dim foundFile As String
            total = 0
            parcial = 0
            'Calcula totales a convertir

            For Each n In TreeView1.Nodes
                total = total + 1
            Next
            If CheckFLV.Checked = True And CheckWebM.Checked = True Then total = total * 2
            Pgr1.Maximum = total
            For Each n In ListBox1.Nodes

                foundFile = Convert.ToString(n)
                foundFile = foundFile.Replace("TreeNode: ", "")
                target = foundFile.Remove(foundFile.Length - 4)

                'Carpeta escribible?
                Dim file As System.IO.StreamWriter
                Try
                    file = My.Computer.FileSystem.OpenTextFileWriter(target + ".tmp", False, System.Text.Encoding.Default)
                    'System.Text.Encoding.Default
                Catch ex As System.Exception
                    MsgBox("Error: " + ex.Message, vbCritical)
                    Exit Sub
                End Try
                file.Close()
                My.Computer.FileSystem.DeleteFile(target + ".tmp")
                ' Fin chequeo carpeta escribible

                If CheckFLV.Checked = True Then
                    convertir = ffmpeg_path + " -i " + foundFile + " -threads 4 -c copy -f flv -y " + target + ".flv"
                    Dim argums As String
                    argums = " -i " + """" + foundFile + """" + " -threads 4 -c copy -f flv" + overWr + " " + """" + target + ".flv" + """"
                    parcial = parcial + 1
                    Pgr1.Value = parcial
                    ShellandWait(ffmpeg_path, argums, "ffmpeg")
                    If Parar = True Then Exit Sub
                End If

                If Parar = True Then Exit Sub
                If CheckWebM.Checked = True Then
                    convertir = ffmpeg_path + " -i " + foundFile + " -threads 4 -vcodec libvpx -b:v 600k -acodec libvorbis -ab 96k -f webm -y " + target + ".webm"
                    Dim argums As String = " -i " + """" + foundFile + """" + " -threads 4 -vcodec libvpx -b:v 600k -acodec libvorbis -ab 96k -f webm" + overWr + " " + """" + target + ".webm" + """"
                    parcial = parcial + 1
                    Pgr1.Value = parcial
                    ShellandWait(ffmpeg_path, argums, "ffmpeg")
                    If Parar = True Then Exit Sub
                End If

                If CheckBox1.Checked = True Then
                    My.Settings.custom_ffmpeg_param = Txtparam.Text
                    My.Settings.curstom_ffmpeg_ext = TextBox6.Text
                    My.Settings.Save()

                    Dim destino_ovwr As String
                    destino_ovwr = target + "." + TextBox6.Text

                    Dim argums As String
                    If foundFile = destino_ovwr Then

                        Dim anexar As String
                        anexar = "_ff_001"
                        argums = " -i " + """" + foundFile + """" + " " + Txtparam.Text + overWr + " " + """" + target + anexar + "." + TextBox6.Text + """"
                    Else
                        argums = " -i " + """" + foundFile + """" + " " + Txtparam.Text + overWr + " " + """" + target + "." + TextBox6.Text + """"
                    End If
                    parcial = parcial + 1
                    Pgr1.Value = parcial
                    ShellandWait(ffmpeg_path, argums, "ffmpeg")
                    If Parar = True Then Exit Sub
                End If
Next
            If Parar = True Then Exit Sub
            MsgBox("Conversión finalizada", vbInformation)
            Shell("explorer.exe" + " " + expl_conv, AppWinStyle.NormalFocus, False)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolTip1.SetToolTip(CheckBox5, "Sobreescribe ficheros de destino si existen sin esperar confirmación")
        ToolTip1.SetToolTip(ffmpeg_custom_load_1, "Cargar preset FFmpeg 1")
        ToolTip1.SetToolTip(ffmpeg_custom_load_2, "Cargar preset FFmpeg 2")
        ToolTip1.SetToolTip(ffmpeg_custom_load_3, "Cargar preset FFmpeg 3")
        ToolTip1.SetToolTip(ffmpeg_custom_save_1, "Guardar en preset FFmpeg 1")
        ToolTip1.SetToolTip(ffmpeg_custom_save_2, "Guardar en preset FFmpeg 2")
        ToolTip1.SetToolTip(ffmpeg_custom_save_3, "Guardar en preset FFmpeg 3")
        ToolTip1.SetToolTip(CheckWebM, "WebM Vídeo + Audio Ogg Vorbis")
        ToolTip1.SetToolTip(CheckFLV, "Flash Video when source is MP4/H264")
        overWr = " -y "
        overWr_winscp = """option confirm off"""
        Parar = False
        TextBox1.Text = My.Settings.winscp_server
        TextBox2.Text = My.Settings.winscp_user
        TextBox3.Text = My.Settings.winscp_passwd
        TextBox4.Text = My.Settings.winscp_destination
        TextBox5.Text = My.Settings.ffmpeg_location
        TextBWscp.Text = My.Settings.winscp_exe_location
        Txtparam.Text = My.Settings.custom_ffmpeg_param
        TextBox6.Text = My.Settings.curstom_ffmpeg_ext
       
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Nodes.Clear()
        TreeView1.Nodes.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "Ejecutable ffmpeg (ffmpeg.exe)|ffmpeg.exe"
        With OpenFileDialog1
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                ffmpeg_path = OpenFileDialog1.FileName
                My.Settings.ffmpeg_location = ffmpeg_path
                My.Settings.Save()
                TextBox5.Text = My.Settings.ffmpeg_location
            End If
        End With
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Parar = False
        If Not My.Computer.FileSystem.FileExists(My.Settings.winscp_exe_location) Then
            MsgBox("Debe indicar la ruta del conversor winscp para continuar", MsgBoxStyle.Exclamation)
            With OpenFileDialog2
                If .ShowDialog = Windows.Forms.DialogResult.Cancel Then
                    MsgBox("El programa requiere winscp.exe en su equipo para continuar", MsgBoxStyle.Critical)
                    Exit Sub
                Else
                    OpenFileDialog2.Filter = "Ejecutable winscp (winscp.exe)|winscp.exe"
                    Dim winscp_exe_path As String
                    winscp_exe_path = OpenFileDialog2.FileName
                    My.Settings.winscp_exe_location = winscp_exe_path
                    My.Settings.Save()
                    TextBWscp.Text = My.Settings.winscp_exe_location
                End If
            End With
        End If
        If My.Settings.winscp_destination = "" Or My.Settings.winscp_server = "" Or My.Settings.winscp_user = "" Then
            MsgBox("Debe completar los campos de configuración de WinSCP para continuar", MsgBoxStyle.Critical)
            Exit Sub
        End If
        OpenFileDialog2.FileName = ""
        OpenFileDialog2.Filter = "Todos los archivos (*.*)|*.*"
        With OpenFileDialog2
            If .ShowDialog = Windows.Forms.DialogResult.OK Then

                Dim winscp_upload, destino, Wserver, username, pwd As String
                destino = TextBox4.Text
                Wserver = TextBox1.Text
                username = TextBox2.Text
                pwd = TextBox3.Text
                total = OpenFileDialog2.FileNames.Count
                Pgr1.Maximum = total

                If OpenFileDialog2.FileNames.Length = 1 Then
                    Pgr1.Maximum = 1
                    Dim SelFile As String
                    SelFile = OpenFileDialog2.FileName
                    winscp_upload = My.Settings.winscp_exe_location + " /console /command ""option batch on"" ""option confirm off "" ""open " + username + ":" + pwd + "@" + Wserver + """" + " " + """" + "put " + """""" + SelFile + """""" + " " + destino + """" + " " + """" + "exit" + """"
                    Dim winscp_file As String = My.Settings.winscp_exe_location
                    Dim argums As String
                    argums = " /console /command ""option batch on""" + " " + overWr_winscp + " " + """open " + username + ":" + pwd + "@" + Wserver + """" + " " + """" + "put " + """""" + SelFile + """""" + " " + destino + """" + " " + """" + "exit" + """"
                    parcial = 1
                    Pgr1.Value = 1
                    ShellandWait(winscp_file, argums, "winscp")
                    If Parar = True Then Exit Sub
                    MsgBox("Proceso de subida finalizado", vbInformation)
                Else

                    Dim filescp As String = ""
                    For Each file1 As String In OpenFileDialog2.FileNames
                        file1 = """put " + """""" + file1 + """""" + " " + destino + """"
                        filescp = filescp + " " + file1
                    Next
                    winscp_upload = My.Settings.winscp_exe_location + " /console /command ""option batch on"" ""option confirm off "" ""open " + username + ":" + pwd + "@" + Wserver + """" + " " + filescp + " " + """" + "exit" + """"
                    Dim winscp_file As String = My.Settings.winscp_exe_location
                    Dim argums As String = " /console /command ""option batch on""" + " " + overWr_winscp + " " + """open " + username + ":" + pwd + "@" + Wserver + """" + " " + filescp + " " + """" + "exit" + """"
                    ShellandWait(winscp_file, argums, "winscp_batch")
                    Pgr1.Value = total
                    If Parar = True Then Exit Sub
                    MsgBox("Proceso de subida finalizado", vbInformation)
                End If
            End If
        End With
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog2.Filter = "Ejecutable winscp (winscp.exe)|winscp.exe"
        If Not My.Computer.FileSystem.FileExists(My.Settings.winscp_exe_location) Then
            MsgBox("Debe indicar la ruta del conversor winscp para continuar", MsgBoxStyle.Exclamation)
            With OpenFileDialog2
                If .ShowDialog = Windows.Forms.DialogResult.Cancel Then
                    MsgBox("El programa requiere winscp.exe en su equipo para continuar", MsgBoxStyle.Critical)
                    Application.Exit()
                Else
                    Dim winscp_exe_path As String
                    winscp_exe_path = OpenFileDialog1.FileName
                    My.Settings.winscp_exe_location = winscp_exe_path
                    My.Settings.Save()
                    TextBWscp.Text = My.Settings.winscp_exe_location
                End If
            End With
        End If
        If My.Settings.winscp_destination = "" Or My.Settings.winscp_server = "" Or My.Settings.winscp_user = "" Then
            MsgBox("Debe completar los campos de configuración de WinSCP para continuar", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Dim destino, Wserver, username, pwd As String
        destino = My.Settings.winscp_destination
        Wserver = My.Settings.winscp_server
        username = My.Settings.winscp_user
        pwd = My.Settings.winscp_passwd
        Dim winscp_list As String
        winscp_list = My.Settings.winscp_exe_location + " /console /command ""option batch on"" ""option confirm off"" ""open " + username + ":" + pwd + "@" + Wserver + """" + " " + """" + "ls " + " " + destino + """" + " "

        Shell(winscp_list, AppWinStyle.NormalFocus, True)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox4.Text <> "" Then
            My.Settings.winscp_server = TextBox1.Text
            My.Settings.winscp_user = TextBox2.Text
            My.Settings.winscp_passwd = TextBox3.Text
            My.Settings.winscp_destination = TextBox4.Text
            My.Settings.winscp_exe_location = TextBWscp.Text
            My.Settings.Save()
            MsgBox("Configuracion WinSCP guardada", vbInformation)
        Else
            MsgBox("No se guardó la configuración. Ningún campo puede quedar en blanco", vbCritical)
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        OpenFileDialog2.FileName = ""
        OpenFileDialog2.Filter = "Ejecutable winscp (winscp.exe)|winscp.exe"
        With OpenFileDialog2
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim winscp_exe_path As String
                winscp_exe_path = OpenFileDialog2.FileName
                My.Settings.winscp_exe_location = winscp_exe_path
                My.Settings.Save()
                TextBWscp.Text = My.Settings.winscp_exe_location
            End If
        End With

    End Sub

    Private Sub ListBox1_DblClick(sender As Object, e As EventArgs) Handles ListBox1.MouseDoubleClick
        MsgBox(ListBox1.SelectedNode.Text)
    End Sub
    Private Sub ListBox1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles ListBox1.AfterSelect
        If Strings.Right(ListBox1.SelectedNode.Text, 3) = "mp4" Then

            ListBox1.SelectedNode.SelectedImageIndex = 1
        Else
            ListBox1.SelectedNode.SelectedImageIndex = 0
        End If

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        'Valida listas
        If ListBox1.Nodes.Count < 1 Then
            MsgBox("No hay ficheros seleccionador para convertir", MsgBoxStyle.Exclamation)
        ElseIf CheckFLV.Checked = False And CheckWebM.Checked = False And CheckBox1.Checked = False Then
            MsgBox("No se seleccionó ningún formato de conversión", MsgBoxStyle.Exclamation)
        
        Else
            'Valida ffmpeg"
            OpenFileDialog1.FileName = ""
            OpenFileDialog1.Filter = "Ejecutable ffmpeg (ffmpeg.exe)|ffmpeg.exe"
            If Not My.Computer.FileSystem.FileExists(My.Settings.ffmpeg_location) Then
                MsgBox("Debe indicar la ruta del conversor ffmpeg para continuar", MsgBoxStyle.Exclamation)
                With OpenFileDialog1
                    If .ShowDialog = Windows.Forms.DialogResult.Cancel Then
                        MsgBox("El programa requiere ffmpeg.exe para continuar", MsgBoxStyle.Critical)
                        Exit Sub
                    Else
                        ffmpeg_path = OpenFileDialog1.FileName
                        My.Settings.ffmpeg_location = ffmpeg_path
                        My.Settings.Save()
                    End If
                End With
            End If


            ' Valida WinSCP
            If Not My.Computer.FileSystem.FileExists(My.Settings.winscp_exe_location) Then
                MsgBox("Debe indicar la ruta del conversor winscp para continuar", MsgBoxStyle.Exclamation)
                With OpenFileDialog2
                    If .ShowDialog = Windows.Forms.DialogResult.Cancel Then
                        MsgBox("El programa requiere winscp.exe en su equipo para continuar", MsgBoxStyle.Critical)
                        Exit Sub
                    Else
                        OpenFileDialog2.Filter = "Ejecutable winscp (winscp.exe)|winscp.exe"
                        Dim winscp_exe_path As String
                        winscp_exe_path = OpenFileDialog2.FileName
                        My.Settings.winscp_exe_location = winscp_exe_path
                        My.Settings.Save()
                        TextBWscp.Text = My.Settings.winscp_exe_location
                    End If
                End With
            End If

            'Valida configuración WinSCP
            If My.Settings.winscp_destination = "" Or My.Settings.winscp_server = "" Or My.Settings.winscp_user = "" Then
                MsgBox("Debe completar los campos de configuración de WinSCP para continuar", MsgBoxStyle.Critical)
                Exit Sub
            End If

            Dim convertir As String
            Dim target As String

            Dim n As TreeNode
            Dim foundFile As String
            Dim winscp_upload, destino, Wserver, username, SelFile, argums, pwd As String
            destino = TextBox4.Text
            Wserver = TextBox1.Text
            username = TextBox2.Text
            pwd = TextBox3.Text

            'Calcula totales a convertir
            total = 0
            parcial = 0
            For Each n In TreeView1.Nodes
                total = total + 1
            Next
            If CheckFLV.Checked = True And CheckWebM.Checked = True And Chk_subir_originales.Checked = True Then
                total = total * 3
            ElseIf CheckFLV.Checked = True And CheckWebM.Checked = True Then
                total = total * 2
            ElseIf CheckFLV.Checked = True And Chk_subir_originales.Checked = True Then
                total = total * 2
            ElseIf CheckWebM.Checked = True And Chk_subir_originales.Checked = True Then
                total = total * 2
            ElseIf CheckBox1.Checked = True And Chk_subir_originales.Checked = True Then
                total = total * 2
            End If
            Pgr1.Maximum = total

            For Each n In ListBox1.Nodes
                foundFile = Convert.ToString(n)
                foundFile = foundFile.Replace("TreeNode: ", "")
                target = foundFile.Remove(foundFile.Length - 4)

                'Carpeta escribible?

                Dim file As System.IO.StreamWriter
                Try
                    file = My.Computer.FileSystem.OpenTextFileWriter(target + ".tmp", False, System.Text.Encoding.Default)
                    'System.Text.Encoding.Default
                Catch ex As System.Exception
                    MsgBox("Error: " + ex.Message, vbCritical)
                    Exit Sub
                End Try
                file.Close()
                My.Computer.FileSystem.DeleteFile(target + ".tmp")
                ' Fin chequeo carpeta escribible

                'Variables WinSCP subida
                Dim winscp_file As String = My.Settings.winscp_exe_location

                If Chk_subir_originales.Checked = True Then
                    ' Sube primero el original
                    winscp_upload = My.Settings.winscp_exe_location + " /console /command ""option batch on"" ""option confirm off "" ""open " + username + ":" + pwd + "@" + Wserver + """" + " " + """" + "put " + """""" + foundFile + """""" + " " + destino + """" + " " + """" + "exit" + """"
                    argums = " /console /command ""option batch on"" ""option confirm off "" ""open " + username + ":" + pwd + "@" + Wserver + """" + " " + """" + "put " + """""" + foundFile + """""" + " " + destino + """" + " " + """" + "exit" + """"
                    
                    ShellandWait(winscp_file, argums, "winscp")
                    'Shell(winscp_upload, AppWinStyle.NormalFocus, True)
                    parcial = parcial + 1
                    Pgr1.Value = parcial
                    If Parar = True Then Exit Sub
                End If

                If CheckFLV.Checked = True Then
                    convertir = ffmpeg_path + " -i " + foundFile + " -threads 4 -c copy -f flv -y " + target + ".flv"
                    argums = " -i " + """" + foundFile + """" + " -threads 4 -c copy -f flv" + overWr + " " + """" + target + ".flv" + """"
                    parcial = parcial + 1
                    Pgr1.Value = parcial

                    ShellandWait(ffmpeg_path, argums, "ffmpeg")

                    If Parar = True Then Exit Sub
                    SelFile = target + ".flv"
                    winscp_upload = My.Settings.winscp_exe_location + " /console /command ""option batch on"" ""option confirm off "" ""open " + username + ":" + pwd + "@" + Wserver + """" + " " + """" + "put " + """""" + SelFile + """""" + " " + destino + """" + " " + """" + "exit" + """"
                    winscp_file = My.Settings.winscp_exe_location
                    argums = " /console /command ""option batch on""" + " " + overWr_winscp + " " + """open " + username + ":" + pwd + "@" + Wserver + """" + " " + """" + "put " + """""" + SelFile + """""" + " " + destino + """" + " " + """" + "exit" + """"
                    ShellandWait(winscp_file, argums, "winscp")
                    If Parar = True Then Exit Sub
                    'Shell(winscp_upload, AppWinStyle.NormalFocus, True)
                End If

                If CheckWebM.Checked = True Then
                    convertir = ffmpeg_path + " -i " + foundFile + " -threads 4 -vcodec libvpx -b:v 600k -acodec libvorbis -ab 96k -f webm -y " + target + ".webm"
                    argums = " -i " + """" + foundFile + """" + " -threads 4 -vcodec libvpx -b:v 600k -acodec libvorbis -ab 96k -f webm" + overWr + " " + """" + target + ".webm" + """"
                    parcial = parcial + 1
                    Pgr1.Value = parcial
                    ShellandWait(ffmpeg_path, argums, "ffmpeg")
                    If Parar = True Then Exit Sub

                    'Shell(convertir, AppWinStyle.NormalFocus, True, )

                    SelFile = target + ".webm"
                    winscp_upload = My.Settings.winscp_exe_location + " /console /command ""option batch on"" ""option confirm off "" ""open " + username + ":" + pwd + "@" + Wserver + """" + " " + """" + "put " + """""" + SelFile + """""" + " " + destino + """" + " " + """" + "exit" + """"
                    winscp_file = My.Settings.winscp_exe_location
                    argums = " /console /command ""option batch on""" + " " + overWr_winscp + " " + """open " + username + ":" + pwd + "@" + Wserver + """" + " " + """" + "put " + """""" + SelFile + """""" + " " + destino + """" + " " + """" + "exit" + """"
                    ShellandWait(winscp_file, argums, "winscp")
                    'Shell(winscp_upload, AppWinStyle.NormalFocus, True)
                    If Parar = True Then Exit Sub
                End If

                If CheckBox1.Checked = True Then
                    My.Settings.custom_ffmpeg_param = Txtparam.Text
                    My.Settings.curstom_ffmpeg_ext = TextBox6.Text
                    My.Settings.Save()

                    Dim destino_ovwr As String
                    destino_ovwr = target + "." + TextBox6.Text


                    If foundFile = destino_ovwr Then

                        Dim anexar As String
                        anexar = "_ff_001"
                        argums = " -i " + """" + foundFile + """" + " " + Txtparam.Text + overWr + " " + """" + target + anexar + "." + TextBox6.Text + """"
                    Else
                        argums = " -i " + """" + foundFile + """" + " " + Txtparam.Text + overWr + " " + """" + target + "." + TextBox6.Text + """"
                    End If
                    parcial = parcial + 1
                    Pgr1.Value = parcial
                    ShellandWait(ffmpeg_path, argums, "ffmpeg")
                    If Parar = True Then Exit Sub
                End If
            Next
            Pgr1.Value = Pgr1.Maximum
            MsgBox("Conversión y subida finalizada", vbInformation)
            Shell("explorer.exe" + " " + expl_conv, AppWinStyle.NormalFocus, False)
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Form3.ShowDialog()
    End Sub


    Private Sub Button12_Click_1(sender As Object, e As EventArgs) Handles Button12.Click
        Form4.Show()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TextBox4.Text = My.Settings.winscp_destination
        TextBox1.Text = My.Settings.winscp_server
        TextBox2.Text = My.Settings.winscp_user
        TextBox3.Text = My.Settings.winscp_passwd
    End Sub

    Public Function ShellandWait(ByVal ProcessPath As String, arguments As String, ByVal ext_app As String)
        Dim objProcess As System.Diagnostics.Process
        lbl_external.Visible = True
        lbl_count.Visible = True
        If ext_app = "ffmpeg" Then
            lbl_external.Text = "Codificación en curso, espere... "
            lbl_count.Text = "Proceso " + Str(parcial) + " de " + Str(total)
        ElseIf ext_app = "winscp" Then
            lbl_external.Text = "Subida en curso, espere..."
            lbl_count.Text = "Proceso " + Str(parcial) + " de " + Str(total)
        ElseIf ext_app = "winscp_batch" Then
            lbl_external.Text = "Subida en curso, espere por favor..."
            lbl_count.Visible = False
        Else
            lbl_external.Text = "Proceso externo en curso. Espere por favor..."
        End If

        Try

            objProcess = New System.Diagnostics.Process()
            objProcess.StartInfo.FileName = ProcessPath
            objProcess.StartInfo.Arguments = arguments
            If CheckBox2.CheckState = CheckState.Unchecked Then
                objProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            Else
                objProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal
            End If
            'objProcess.StartInfo.UseShellExecute = False
            'objProcess.StartInfo.WorkingDirectory = "c:\"
            'objProcess.StartInfo.RedirectStandardError = True
            'objProcess.StartInfo.RedirectStandardOutput = True
            'objProcess.StartInfo.RedirectStandardInput = True
            objProcess.Start()

            'Wait until the process passes back an exit code 
            objProcess.WaitForExit()
            If objProcess.ExitCode <> 0 Then
                Parar = True

                If ext_app = "ffmpeg" Then
                    MsgBox("FFmpeg devolvió un error de salida código " & objProcess.ExitCode & ". Revise el fichero de origen y los parámetros.", vbCritical)
                ElseIf ext_app = "winscp" Then
                    MsgBox("Winscp devolvió un error al subir el fichero. Revise la configuración del servidor. Si desea sobreescribir el fichero de destino, active la casilla correspondiente.", vbCritical)
                Else
                    MsgBox("Se produjo un error en el programa externo.", vbCritical)
                End If

            End If
            'Free resources associated with this process
            objProcess.Close()
        Catch
            If ext_app = "ffmpeg" Then
                MessageBox.Show("FFmpeg devolvió un error. Código " & ProcessPath, "Error")
            Else
                MessageBox.Show("Error en el programa externo." & ProcessPath, "Error")
            End If

        End Try

        lbl_external.Visible = False
        lbl_count.Visible = False
    End Function

    Private Sub TreeView1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TreeView1.KeyDown
        If e.KeyCode = Keys.Delete And TreeView1.Nodes.Count > 0 Then
            Dim borrar_nodo As New TreeNode
            borrar_nodo.Text = TreeView1.SelectedNode.Text
            TreeView1.Nodes.Remove(TreeView1.SelectedNode)

            For Each node As TreeNode In ListBox1.Nodes
                If Strings.Right(node.Text, borrar_nodo.Text.Length) = borrar_nodo.Text Then
                    node.Remove()
                    Exit Sub
                End If
            Next
                End If
    End Sub

    Private Sub TextBWscp_DBLClick(sender As Object, e As EventArgs) Handles TextBWscp.DoubleClick

        If TextBWscp.Text <> String.Empty Then
            Shell(TextBWscp.Text, AppWinStyle.NormalFocus, False)
        End If
    End Sub

    Private Sub TextBox5_DBLClick(sender As Object, e As EventArgs) Handles TextBox5.DoubleClick
        If TextBox5.Text <> String.Empty Then
            Dim exec As String
            Dim ffmpeg_string As String
            ffmpeg_string = "ffmpeg.exe"
            exec = System.Environment.GetEnvironmentVariable("SystemRoot") + "\system32\cmd.exe" + " /K " + """" + "cd " + Strings.Left(TextBox5.Text, ffmpeg_string.Length) + "bin" + """"
            Shell(exec, AppWinStyle.NormalFocus, False)
        End If
    End Sub

    Private Sub TreeView1_NodeDblClick(ByVal sender As Object, ByVal e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseDoubleClick
        Dim exec As String
        For Each node As TreeNode In TreeView1.Nodes
            If node.IsSelected = True Then
                exec = ListBox1.Nodes(node.Index).Text
                Process.Start(exec)
            End If
        Next
    End Sub
    Private Sub TreeView1_rightClick(ByVal sender As Object, ByVal e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Dim p As Point = New Point(e.X, e.Y)
            menu1.Show(TreeView1, p)
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckFLV.Checked = False
            CheckFLV.Enabled = False
            CheckWebM.Checked = False
            CheckWebM.Enabled = False
            CheckBox5.Enabled = False
            Txtparam.Enabled = True
            TextBox6.Enabled = True
        Else
            CheckFLV.Enabled = True
            CheckWebM.Enabled = True
            CheckBox5.Enabled = True
            Txtparam.Enabled = False
            TextBox6.Enabled = False
        End If

    End Sub

    Private Sub TextBox6_Click(sender As Object, e As EventArgs) Handles TextBox6.Click
        TextBox6.Text = String.Empty
    End Sub

    Private Sub opt1_Click(sender As Object, e As EventArgs) Handles opt1.Click
        Form4.Show()
    End Sub
    Private Sub opt2_Click(sender As Object, e As EventArgs) Handles opt2.Click
        Form3.Show()
    End Sub

    
    Private Sub CheckBox5_click(sender As Object, e As EventArgs) Handles CheckBox5.Click
        If CheckBox5.Checked = False Then
            overWr = String.Empty
            overWr_winscp = String.Empty
            CheckBox2.Checked = True
        Else
            overWr = " -y "
            overWr_winscp = """ option confirm off """
        End If
    End Sub

    Private Sub CheckBox2_Click(sender As Object, e As EventArgs) Handles CheckBox2.Click
        If CheckBox2.Checked = False And CheckBox5.Checked = False Then
            CheckBox2.Checked = True
        End If
    End Sub

    
    Private Sub ffmpeg_custom_save_1_Click(sender As Object, e As EventArgs) Handles ffmpeg_custom_save_1.Click
        If Txtparam.Text <> String.Empty And TextBox6.Text <> String.Empty Then
            My.Settings.custom_ffmppeg_1 = Txtparam.Text
            My.Settings.curstom_ffmpeg_ext_1 = TextBox6.Text
        End If
    End Sub

    Private Sub ffmpeg_custom_load_1_Click(sender As Object, e As EventArgs) Handles ffmpeg_custom_load_1.Click
        Txtparam.Text = My.Settings.custom_ffmppeg_1
        TextBox6.Text = My.Settings.curstom_ffmpeg_ext_1
    End Sub

    Private Sub ffmpeg_custom_save_2_Click(sender As Object, e As EventArgs) Handles ffmpeg_custom_save_2.Click
        If Txtparam.Text <> String.Empty And TextBox6.Text <> String.Empty Then
            My.Settings.custom_ffmppeg_2 = Txtparam.Text
            My.Settings.curstom_ffmpeg_ext_2 = TextBox6.Text
        End If
    End Sub

    Private Sub ffmpeg_custom_save_3_Click(sender As Object, e As EventArgs) Handles ffmpeg_custom_save_3.Click
        If Txtparam.Text <> String.Empty And TextBox6.Text <> String.Empty Then
            My.Settings.custom_ffmppeg_3 = Txtparam.Text
            My.Settings.curstom_ffmpeg_ext_3 = TextBox6.Text
        End If
    End Sub

    Private Sub ffmpeg_custom_load_2_Click(sender As Object, e As EventArgs) Handles ffmpeg_custom_load_2.Click
        Txtparam.Text = My.Settings.custom_ffmppeg_2
        TextBox6.Text = My.Settings.curstom_ffmpeg_ext_2
    End Sub

    Private Sub ffmpeg_custom_load_3_Click(sender As Object, e As EventArgs) Handles ffmpeg_custom_load_3.Click
        Txtparam.Text = My.Settings.custom_ffmppeg_3
        TextBox6.Text = My.Settings.curstom_ffmpeg_ext_3
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        CheckBox1.Checked = True
        CheckFLV.Checked = False
        CheckFLV.Enabled = False
        CheckWebM.Checked = False
        CheckWebM.Enabled = False
        CheckBox5.Enabled = False
        Txtparam.Enabled = True
        TextBox6.Enabled = True
        Txtparam.Text = "-c:v libx264 -threads 2 -preset fast -g 125 -crf 24 -acodec libvo_aacenc -ab 128k -f mp4"
        TextBox6.Text = "mp4"
    End Sub

    Private Sub btn_webm_Click(sender As Object, e As EventArgs) Handles btn_webm.Click
        CheckBox1.Checked = True
        CheckFLV.Checked = False
        CheckFLV.Enabled = False
        CheckWebM.Checked = False
        CheckWebM.Enabled = False
        CheckBox5.Enabled = False
        Txtparam.Enabled = True
        TextBox6.Enabled = True
        Txtparam.Text = "-vcodec libvpx -b:v 1000k -threads 2 -acodec libvorbis -ab 128k -f webm output.webm"
        TextBox6.Text = "webm"
    End Sub

    Private Sub flv_hq_Click(sender As Object, e As EventArgs) Handles flv_hq.Click
        CheckBox1.Checked = True
        CheckFLV.Checked = False
        CheckFLV.Enabled = False
        CheckWebM.Checked = False
        CheckWebM.Enabled = False
        CheckBox5.Enabled = False
        Txtparam.Enabled = True
        TextBox6.Enabled = True
        Txtparam.Text = "-c:v libx264 -threads 2 -preset fast -g 125 -crf 24 -acodec libvo_aacenc -ab 128k -f flv"
        TextBox6.Text = "flv"
    End Sub

End Class