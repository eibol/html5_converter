Public Class Form4
    Public captured As System.Drawing.Bitmap
    Public bmp_a_salvar As System.Drawing.Bitmap
    Public Parar As Boolean

    Private Sub Form4_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
        AxWindowsMediaPlayer1.close()
    End Sub 'Form1_Closing

    Private Sub BtnCapture_Click(sender As Object, e As EventArgs) Handles BtnCapture.Click
        'Dim area As Rectangle
        Dim graph As Graphics

        Dim area As New Rectangle(AxWindowsMediaPlayer1.Location.X, AxWindowsMediaPlayer1.Location.Y, AxWindowsMediaPlayer1.Width, AxWindowsMediaPlayer1.Height - pic_Controls.Height)

        captured = New System.Drawing.Bitmap(AxWindowsMediaPlayer1.Width, AxWindowsMediaPlayer1.Height - pic_Controls.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
        graph = Graphics.FromImage(captured)
        graph.CopyFromScreen(Me.PointToScreen(AxWindowsMediaPlayer1.Location).X, Me.PointToScreen(AxWindowsMediaPlayer1.Location).Y, 0, 0, area.Size, CopyPixelOperation.SourceCopy)

        PictureBox1.SizeMode = PictureBoxSizeMode.Normal
        PictureBox1.Image = captured
        bmp_a_salvar = captured


    End Sub

    Private Sub Btn_Pegar_Click(sender As Object, e As EventArgs) Handles Btn_Pegar.Click
        If Not My.Computer.Clipboard.ContainsImage Then Exit Sub
        PictureBox1.Image = My.Computer.Clipboard.GetImage
       
        Dim bmp_salvar As New Bitmap(PictureBox1.Width, PictureBox1.Height)
        Using g As Graphics = Graphics.FromImage(bmp_salvar)
            g.DrawImage(PictureBox1.Image, 0, 0, bmp_salvar.Width, bmp_salvar.Height)
        End Using
        PictureBox1.Image = bmp_salvar
        bmp_a_salvar = bmp_salvar
    End Sub

   
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.OpenFileDialog2.ShowDialog()
        AxWindowsMediaPlayer1.URL = Form1.OpenFileDialog2.FileName
    End Sub

    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click

        If PictureBox1.Image Is Nothing Then
            MsgBox("Capture una imagen o pegue desde el portapapeles antes de continuar.", vbCritical)
            Exit Sub
        End If

        SaveFileDialog1.FileName = ""
        SaveFileDialog1.Filter = "Imagen JPEG (*.jpg)|*.jpg|Imagen PNG (*.png)|*.png"
        With SaveFileDialog1
            If .ShowDialog = Windows.Forms.DialogResult.OK Then

                Dim myImageCodecInfo As System.Drawing.Imaging.ImageCodecInfo
                Dim myEncoder As System.Drawing.Imaging.Encoder
                Dim myEncoderParameter As System.Drawing.Imaging.EncoderParameter
                Dim myEncoderParameters As System.Drawing.Imaging.EncoderParameters
                'Dim ImageFormat As System.Drawing.Imaging.ImageFormat

                myImageCodecInfo = GetEncoderInfo(Imaging.ImageFormat.Jpeg)

                ' Create an Encoder object based on the GUID 
                ' for the Quality parameter category.
                myEncoder = System.Drawing.Imaging.Encoder.Quality

                ' Create an EncoderParameters object. 
                ' An EncoderParameters object has an array of EncoderParameter 
                ' objects. In this case, there is only one 
                ' EncoderParameter object in the array.
                myEncoderParameters = New System.Drawing.Imaging.EncoderParameters(1)

                Select Case SaveFileDialog1.FilterIndex
                    Case 1
                        myEncoderParameter = New System.Drawing.Imaging.EncoderParameter(myEncoder, CType(90L, Int32))
                        myEncoderParameters.Param(0) = myEncoderParameter

                        PictureBox1.Image.Save(SaveFileDialog1.FileName, myImageCodecInfo, myEncoderParameters)
                    Case 2
                        myImageCodecInfo = GetEncoderInfo(Imaging.ImageFormat.Png)
                        myEncoderParameter = New System.Drawing.Imaging.EncoderParameter(myEncoder, CType(80L, Int32))
                        myEncoderParameters.Param(0) = myEncoderParameter

                        PictureBox1.Image.Save(SaveFileDialog1.FileName, myImageCodecInfo, myEncoderParameters)
                End Select
            End If
End With
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolTip1.SetToolTip(Btn_Guardar, "Guardar imagen")
        ToolTip1.SetToolTip(Btn_Pegar, "Pegar desde el portapapeles")
        ToolTip1.SetToolTip(BtnCapture, "Capturar imagen actual del vídeo")
        ToolTip1.SetToolTip(Button1, "Abrir fichero de vídeo")
        ToolTip1.SetToolTip(Button2, "Cerrar")
        ToolTip1.SetToolTip(save_upload, "Guardar imagen y subir con WinSCP")
        AxWindowsMediaPlayer1.stretchToFit = True
        cbox1.SelectedItem = "16:9"

        For Each node As TreeNode In Form1.TreeView1.Nodes
            If node.IsSelected = True Then AxWindowsMediaPlayer1.URL = Form1.ListBox1.Nodes(node.Index).Text
        Next

        'If Form1.ListBox1.Nodes.Count > 0 Then
        ' AxWindowsMediaPlayer1.URL = Form1.ListBox1.Nodes.Item(0).Text
        ' End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
        Me.Visible = False
    End Sub

    Private Shared Function GetEncoderInfo(ByVal format As System.Drawing.Imaging.ImageFormat) As System.Drawing.Imaging.ImageCodecInfo
        Dim j As Integer
        Dim encoders() As System.Drawing.Imaging.ImageCodecInfo
        encoders = System.Drawing.Imaging.ImageCodecInfo.GetImageEncoders()

        j = 0
        While j < encoders.Length
            If encoders(j).FormatID = format.Guid Then
                Return encoders(j)
            End If
            j += 1
        End While
        Return Nothing

    End Function 'GetEncoderInfo

    Private Sub save_upload_Click(sender As Object, e As EventArgs) Handles save_upload.Click
        'Guardar imagen
        If PictureBox1.Image Is Nothing Then
            MsgBox("Capture una imagen o pegue desde el portapapeles antes de continuar.", vbCritical)
            Exit Sub
        End If

        SaveFileDialog1.FileName = ""
        SaveFileDialog1.Filter = "Imagen JPEG (*.jpg)|*.jpg|Imagen PNG (*.png)|*.png"
        Dim subir As Boolean
        subir = False
        With SaveFileDialog1
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                subir = True
                Dim myImageCodecInfo As System.Drawing.Imaging.ImageCodecInfo
                Dim myEncoder As System.Drawing.Imaging.Encoder
                Dim myEncoderParameter As System.Drawing.Imaging.EncoderParameter
                Dim myEncoderParameters As System.Drawing.Imaging.EncoderParameters
                'Dim ImageFormat As System.Drawing.Imaging.ImageFormat

                myImageCodecInfo = GetEncoderInfo(Imaging.ImageFormat.Jpeg)

                ' Create an Encoder object based on the GUID 
                ' for the Quality parameter category.
                myEncoder = System.Drawing.Imaging.Encoder.Quality

                ' Create an EncoderParameters object. 
                ' An EncoderParameters object has an array of EncoderParameter 
                ' objects. In this case, there is only one 
                ' EncoderParameter object in the array.
                myEncoderParameters = New System.Drawing.Imaging.EncoderParameters(1)

                Select Case SaveFileDialog1.FilterIndex
                    Case 1
                        myEncoderParameter = New System.Drawing.Imaging.EncoderParameter(myEncoder, CType(90L, Int32))
                        myEncoderParameters.Param(0) = myEncoderParameter

                        PictureBox1.Image.Save(SaveFileDialog1.FileName, myImageCodecInfo, myEncoderParameters)
                    Case 2
                        myImageCodecInfo = GetEncoderInfo(Imaging.ImageFormat.Png)
                        myEncoderParameter = New System.Drawing.Imaging.EncoderParameter(myEncoder, CType(80L, Int32))
                        myEncoderParameters.Param(0) = myEncoderParameter

                        PictureBox1.Image.Save(SaveFileDialog1.FileName, myImageCodecInfo, myEncoderParameters)
                End Select
            End If
        End With

        'Subir con WinSCP
        Parar = False
        If subir = False Then Exit Sub
        If Not My.Computer.FileSystem.FileExists(My.Settings.winscp_exe_location) Then
            MsgBox("Debe indicar la ruta del programa winscp para continuar", MsgBoxStyle.Exclamation)
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

                Dim winscp_upload, destino, Wserver, username, pwd As String
                destino = Form1.TextBox4.Text
                Wserver = Form1.TextBox1.Text
                username = Form1.TextBox2.Text
                pwd = Form1.TextBox3.Text

        Dim SelFile As String
        SelFile = SaveFileDialog1.FileName

                winscp_upload = My.Settings.winscp_exe_location + " /console /command ""option batch on"" ""option confirm off "" ""open " + username + ":" + pwd + "@" + Wserver + """" + " " + """" + "put " + """""" + SelFile + """""" + " " + destino + """" + " " + """" + "exit" + """"
                Dim winscp_file As String = My.Settings.winscp_exe_location
                Dim argums As String
        argums = " /console /command ""option batch on""" + " " + """option confirm off""" + " " + """open " + username + ":" + pwd + "@" + Wserver + """" + " " + """" + "put " + """""" + SelFile + """""" + " " + destino + """" + " " + """" + "exit" + """"

        ShellandWait_2(winscp_file, argums, "winscp")
                If Parar = True Then Exit Sub
                MsgBox("Proceso de subida finalizado", vbInformation)

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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbox1.SelectedIndexChanged
        If cbox1.SelectedItem = "4:3" Then
            AxWindowsMediaPlayer1.Width = 375
            PictureBox1.Width = 375
            PictureBox1.Left = 375
            TextBox1.Width = 372
            TextBox1.Left = 378
            Button1.Left = 376
            BtnCapture.Left = 434
            Btn_Pegar.Left = 492
            Btn_Guardar.Left = 550
            save_upload.Left = 609
            cbox1.Left = 689
            Label1.Left = 689
            Button2.Left = 750
            Me.Width = 815
        Else
            AxWindowsMediaPlayer1.Width = 500
            PictureBox1.Width = 500
            PictureBox1.Left = 501
            TextBox1.Width = 499
            TextBox1.Left = 502
            Button1.Left = 502
            BtnCapture.Left = 561
            Btn_Pegar.Left = 619
            Btn_Guardar.Left = 677
            save_upload.Left = 736
            cbox1.Left = 819
            Label1.Left = 819
            Button2.Left = 954
            Me.Width = 1018
        End If
    End Sub
End Class