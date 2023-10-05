Imports System.Diagnostics
Imports System.Security.Cryptography.Xml
Imports System.Text
Imports System.Text.Encodings
Imports System.Threading.Tasks
Imports Microsoft.VisualBasic.Devices
Imports System.IO
Imports System.Windows.Forms


Public Class Form1
    Private Delegate Sub UpdateLabelDelegate(text As String)
    Private Sub UpdateLabel(text As String)
        If Label2.InvokeRequired Then
            Dim d As New UpdateLabelDelegate(AddressOf UpdateLabel)
            Label2.Invoke(d, text)
        Else
            Label2.Text = text
        End If
    End Sub

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim sFormat As String = "MP4"

        If File.Exists(TextBox1.Text) Then
            If ComboBox1.Text = "MP4 (MPEG-4)" Then
                sFormat = "MP4"
            End If
            If ComboBox1.Text = "MKV (Matroska)" Then
                sFormat = "MKV"
            End If
            If ComboBox1.Text = "AVI (Audio Video Interleave)" Then
                sFormat = "AVI"
            End If
            If ComboBox1.Text = "MOV (QuickTime)" Then
                sFormat = "MOV"
            End If
            If ComboBox1.Text = "FLV (Flash Video)" Then
                sFormat = "FLV"
            End If
            If ComboBox1.Text = "TS (Transport Stream)" Then
                sFormat = "TS"
            End If


            Dim filePath As String = Path.Combine(Application.StartupPath, "input." & sFormat)
            Dim inputVideoPath As String = TextBox1.Text
            Dim outputVideoPath As String = Application.StartupPath & "input." & sFormat


            If File.Exists(filePath) Then

                File.Delete(filePath)

                Button1.Enabled = False
                Button2.Enabled = False
                Await Task.Run(Sub()
                                   ConvertVideoUsingCUDA(inputVideoPath, outputVideoPath)
                               End Sub)

                Button1.Enabled = True
                Button2.Enabled = True

            Else

                Button1.Enabled = False
                Button2.Enabled = False
                Await Task.Run(Sub()
                                   ConvertVideoUsingCUDA(inputVideoPath, outputVideoPath)
                               End Sub)

                Button1.Enabled = True
                Button2.Enabled = True

            End If
        Else
            MsgBox("Выберите видео файл", 16, "Ошибка файла")
        End If

    End Sub

    Private Sub ConvertVideoUsingCUDA(inputPath As String, outputPath As String)
        Try
            Dim ffmpegPath As String = Application.StartupPath & "\ffmpeg.exe"
            Dim arguments As String = $"-i ""{inputPath}"" -c:v h264_nvenc -preset fast -cq 15 -b:v 10M -pix_fmt yuv420p ""{outputPath}"""

            Dim processStartInfo As New ProcessStartInfo(ffmpegPath, arguments) With {
            .UseShellExecute = False,
            .RedirectStandardOutput = True,
            .RedirectStandardError = True,
            .CreateNoWindow = True
        }

            Dim process As New Process With {
            .StartInfo = processStartInfo
        }

            Dim outputBuilder As New StringBuilder()
            Dim errorsBuilder As New StringBuilder()

            AddHandler process.OutputDataReceived, Sub(sender, e)
                                                       If e.Data IsNot Nothing Then
                                                           outputBuilder.AppendLine(e.Data)
                                                           UpdateLabel(e.Data)
                                                       End If
                                                   End Sub

            AddHandler process.ErrorDataReceived, Sub(sender, e)
                                                      If e.Data IsNot Nothing Then
                                                          errorsBuilder.AppendLine(e.Data)
                                                          UpdateLabel($"{e.Data}")
                                                      End If
                                                  End Sub

            process.Start()
            process.BeginOutputReadLine()
            process.BeginErrorReadLine()
            process.WaitForExit()

            UpdateLabel("Conversion completed.")
        Catch ex As Exception
            UpdateLabel($"An error occurred: {ex.Message}")
        End Try
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Text = "MP4 (MPEG-4)"
        TextBox1.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OpenFileDialog1.Filter = "Файлы видео (*.mp4;*.mkv;*.avi;*.mov;*.flv;*.ts)|*.mp4;*.mkv;*.avi;*.mov;*.flv;*.ts|Все файлы (*.*)|*.*"
        OpenFileDialog1.ShowDialog()
        Dim selectedFilePath As String = OpenFileDialog1.FileName
        TextBox1.Text = OpenFileDialog1.FileName
    End Sub

End Class















