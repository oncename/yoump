<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        TextBox1 = New TextBox()
        Button1 = New Button()
        Label2 = New Label()
        ComboBox1 = New ComboBox()
        Label1 = New Label()
        Button2 = New Button()
        OpenFileDialog1 = New OpenFileDialog()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(28, 32)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(555, 27)
        TextBox1.TabIndex = 0
        TextBox1.Text = "C:\Users\SB5\Source\Repos\yoump\bin\Debug\net7.0-windows\001.mp4"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(430, 165)
        Button1.Name = "Button1"
        Button1.Size = New Size(153, 29)
        Button1.TabIndex = 3
        Button1.Text = "Конвертировать"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.Location = New Point(28, 126)
        Label2.Name = "Label2"
        Label2.Size = New Size(396, 97)
        Label2.TabIndex = 5
        Label2.Text = "Converting Video GPU CUDA"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"MP4 (MPEG-4)", "MKV (Matroska)", "AVI (Audio Video Interleave)", "MOV (QuickTime)", "FLV (Flash Video)", "TS (Transport Stream)"})
        ComboBox1.Location = New Point(145, 77)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(223, 28)
        ComboBox1.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(28, 80)
        Label1.Name = "Label1"
        Label1.Size = New Size(112, 20)
        Label1.TabIndex = 7
        Label1.Text = "Формат видео:"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(489, 76)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 8
        Button2.Text = "Обзор"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' OpenFileDialog1
        ' 
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(611, 232)
        Controls.Add(Button2)
        Controls.Add(Label1)
        Controls.Add(ComboBox1)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        Text = "Converting Video CUDA"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
