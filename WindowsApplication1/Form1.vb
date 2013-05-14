Public Class Form1
    Dim ffmpeg_path As String = "C:\ffmpeg\bin\ffmpeg.exe"

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OpenFileDialog1.ShowDialog()
        Dim convertir As String
        ListBox1.Items.Clear()
        For Each foundFile As String In OpenFileDialog1.FileNames()
            ListBox1.Items.Add(foundFile)
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ListBox1.Items.Count < 1 Then
            MsgBox("No hay ficheros seleccionador para convertir", MsgBoxStyle.Exclamation)
        ElseIf CheckFLV.Checked = False And CheckWebM.Checked = False Then
            MsgBox("No se seleccionó ningún formato de conversión", MsgBoxStyle.Exclamation)
        Else
            Dim convertir As String
            For Each foundFile As String In ListBox1.Items()
                If CheckFLV.Checked = True Then
                    convertir = ffmpeg_path + " -i " + foundFile + " -c copy -f flv " + foundFile + ".flv"
                    Shell(convertir, AppWinStyle.NormalFocus, True, )
                    MsgBox("Convirtiendo 1", vbInformation)
                End If
                If CheckWebM.Checked = True Then
                    convertir = ffmpeg_path + " -i " + foundFile + " -vcodec libvpx -b:v 600k -acodec libvorbis -ab 96k -f webm -y " + foundFile + ".webm"
                    Shell(convertir, AppWinStyle.NormalFocus, True, )
                    MsgBox("Convirtiendo 1", vbInformation)
                End If
            Next
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Not My.Computer.FileSystem.FileExists("c://ffmpeg/bin/ffmpeg.exe") Then
            MsgBox("Debe indicar la ruta del conversor ffmpeg para continuar", MsgBoxStyle.Exclamation)
            OpenFileDialog1.ShowDialog()
            ffmpeg_path = OpenFileDialog1.FileName
            MsgBox(ffmpeg_path)
        End If
    End Sub

   
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
    End Sub
End Class

