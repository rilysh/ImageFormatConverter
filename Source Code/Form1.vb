' ImageFormatConverter
' Copyright (C) 2018-2020 MathInDOS
' You can modify this program and re-distribute under GNU GPLv3 License.

Public Class Form1

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        ofd.Filter = "All Image Formats (*.gif; *.jpg; *.jpeg; *.pbm; *.pgm; *.psd; *.png; *.pnm; *.hdr; *.tga; *.webp; *.bmp; *.dib; *.pcx)|*.gif;*.jpg;*.jpeg;*.pbm; *.pgm; *.psd; *.png; *.pnm; *.hdr; *.tga; *.webp; *.bmp; *.dib; *.pcx"
        If ofd.ShowDialog = DialogResult.OK Then
            TextBox1.Text = ofd.FileName
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If ofd.FileName = Nothing Then
            MessageBox.Show("Please select a image to convert!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        My.Computer.FileSystem.RenameFile("mgck-converter.dll", "mgck-converter.exe")
        Dim convert = "mgck-converter.exe"
        If cb.SelectedItem = "GIF Image" Then
            Dim file As String = """" & ofd.FileName & """" & " output.gif"
            Dim myprocess As New ProcessStartInfo
            myprocess.FileName = convert
            myprocess.Arguments = file
            Process.Start(myprocess)
            My.Computer.FileSystem.RenameFile("mgck-converter.exe", "mgck-converter.dll")
        End If
        If cb.SelectedItem = "JPEG Image" Then
            Dim file As String = """" & ofd.FileName & """" & " output.jpg"
            Dim myprocess As New ProcessStartInfo
            myprocess.FileName = convert
            myprocess.Arguments = file
            Process.Start(myprocess)
            My.Computer.FileSystem.RenameFile("mgck-converter.exe", "mgck-converter.dll")
        End If
        If cb.SelectedItem = "PBM / PGM Image" Then
            Dim file As String = """" & ofd.FileName & """" & " output.pbm"
            Dim myprocess As New ProcessStartInfo
            myprocess.FileName = convert
            myprocess.Arguments = file
            Process.Start(myprocess)
            My.Computer.FileSystem.RenameFile("mgck-converter.exe", "mgck-converter.dll")
        End If
        If cb.SelectedItem = "PhotoShop Image" Then
            Dim file As String = """" & ofd.FileName & """" & " output.psd"
            Dim myprocess As New ProcessStartInfo
            myprocess.FileName = convert
            myprocess.Arguments = file
            Process.Start(myprocess)
            My.Computer.FileSystem.RenameFile("mgck-converter.exe", "mgck-converter.dll")
        End If
        If cb.SelectedItem = "PNG Image" Then
            Dim file As String = """" & ofd.FileName & """" & " output.png"
            Dim myprocess As New ProcessStartInfo
            myprocess.FileName = convert
            myprocess.Arguments = file
            Process.Start(myprocess)
            My.Computer.FileSystem.RenameFile("mgck-converter.exe", "mgck-converter.dll")
        End If
        If cb.SelectedItem = "PNM Image" Then
            Dim file As String = """" & ofd.FileName & """" & " output.pnm"
            Dim myprocess As New ProcessStartInfo
            myprocess.FileName = convert
            myprocess.Arguments = file
            Process.Start(myprocess)
            My.Computer.FileSystem.RenameFile("mgck-converter.exe", "mgck-converter.dll")
        End If
        If cb.SelectedItem = "Radiance RGBE Image" Then
            Dim file As String = """" & ofd.FileName & """" & " output.hdr"
            Dim myprocess As New ProcessStartInfo
            myprocess.FileName = convert
            myprocess.Arguments = file
            Process.Start(myprocess)
            My.Computer.FileSystem.RenameFile("mgck-converter.exe", "mgck-converter.dll")
        End If
        If cb.SelectedItem = "TarGA Image" Then
            Dim file As String = """" & ofd.FileName & """" & " output.tga"
            Dim myprocess As New ProcessStartInfo
            myprocess.FileName = convert
            myprocess.Arguments = file
            Process.Start(myprocess)
            My.Computer.FileSystem.RenameFile("mgck-converter.exe", "mgck-converter.dll")
        End If
        If cb.SelectedItem = "WebP Image" Then
            Dim file As String = """" & ofd.FileName & """" & " output.webp"
            Dim myprocess As New ProcessStartInfo
            myprocess.FileName = convert
            myprocess.Arguments = file
            Process.Start(myprocess)
            My.Computer.FileSystem.RenameFile("mgck-converter.exe", "mgck-converter.dll")
        End If
        If cb.SelectedItem = "Windows BMP Image" Then
            Dim file As String = """" & ofd.FileName & """" & " output.bmp"
            Dim myprocess As New ProcessStartInfo
            myprocess.FileName = convert
            myprocess.Arguments = file
            Process.Start(myprocess)
            My.Computer.FileSystem.RenameFile("mgck-converter.exe", "mgck-converter.dll")
        End If
        If cb.SelectedItem = "X BitMap Imnage" Then
            Dim file As String = """" & ofd.FileName & """" & " output.xbm"
            Dim myprocess As New ProcessStartInfo
            myprocess.FileName = convert
            myprocess.Arguments = file
            Process.Start(myprocess)
            My.Computer.FileSystem.RenameFile("mgck-converter.exe", "mgck-converter.dll")
        End If
        If cb.SelectedItem = "X PixMap Image" Then
            Dim file As String = """" & ofd.FileName & """" & " output.xpm"
            Dim myprocess As New ProcessStartInfo
            myprocess.FileName = convert
            myprocess.Arguments = file
            Process.Start(myprocess)
            My.Computer.FileSystem.RenameFile("mgck-converter.exe", "mgck-converter.dll")
        End If
        If cb.SelectedItem = "ZSoft PCX Image" Then
            Dim file As String = """" & ofd.FileName & """" & " output.pcx"
            Dim myprocess As New ProcessStartInfo
            myprocess.FileName = convert
            myprocess.Arguments = file
            Process.Start(myprocess)
            My.Computer.FileSystem.RenameFile("mgck-converter.exe", "mgck-converter.dll")
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            My.Computer.FileSystem.RenameFile("mgck-converter.dll", "mgck-converter.exe")
            Process.Start("mgck-converter.exe")
            My.Computer.FileSystem.RenameFile("mgck-converter.exe", "mgck-converter.dll")
        Catch ex As Exception
            MessageBox.Show("mgck-converter.dll is missing, please reinstall this program to fix the problem.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End Try
        MaximizeBox = False
        ResizeRedraw = False

        cb.SelectedItem = "JPEG Image"
        ComboBox1.SelectedItem = "Output"
    End Sub

    Private Sub AddInputFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddInputFileToolStripMenuItem.Click
        ofd.Filter = "All Image Formats (*.png)|*.png"
        If ofd.ShowDialog = DialogResult.OK Then
            TextBox1.Text = ofd.FileName
        End If
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        TextBox1.Text = ""
        cb.SelectedItem = "JPEG Image"
    End Sub

    Private Sub ConvertToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConvertToolStripMenuItem1.Click
        If ofd.FileName = Nothing Then
            MessageBox.Show("Please select a image to convert!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        My.Computer.FileSystem.RenameFile("mgck-converter.dll", "mgck-converter.exe")
        Dim convert = "mgck-converter.exe"
        If cb.SelectedItem = "GIF Image" Then
            Dim file As String = """" & ofd.FileName & """" & " output.gif"
            Dim myprocess As New ProcessStartInfo
            myprocess.FileName = convert
            myprocess.Arguments = file
            Process.Start(myprocess)
            My.Computer.FileSystem.RenameFile("mgck-converter.exe", "mgck-converter.dll")
        End If
        If cb.SelectedItem = "JPEG Image" Then
            Dim file As String = """" & ofd.FileName & """" & " output.jpg"
            Dim myprocess As New ProcessStartInfo
            myprocess.FileName = convert
            myprocess.Arguments = file
            Process.Start(myprocess)
            My.Computer.FileSystem.RenameFile("mgck-converter.exe", "mgck-converter.dll")
        End If
        If cb.SelectedItem = "PBM / PGM Image" Then
            Dim file As String = """" & ofd.FileName & """" & " output.pbm"
            Dim myprocess As New ProcessStartInfo
            myprocess.FileName = convert
            myprocess.Arguments = file
            Process.Start(myprocess)
            My.Computer.FileSystem.RenameFile("mgck-converter.exe", "mgck-converter.dll")
        End If
        If cb.SelectedItem = "PhotoShop Image" Then
            Dim file As String = """" & ofd.FileName & """" & " output.psd"
            Dim myprocess As New ProcessStartInfo
            myprocess.FileName = convert
            myprocess.Arguments = file
            Process.Start(myprocess)
            My.Computer.FileSystem.RenameFile("mgck-converter.exe", "mgck-converter.dll")
        End If
        If cb.SelectedItem = "PNG Image" Then
            Dim file As String = """" & ofd.FileName & """" & " output.png"
            Dim myprocess As New ProcessStartInfo
            myprocess.FileName = convert
            myprocess.Arguments = file
            Process.Start(myprocess)
            My.Computer.FileSystem.RenameFile("mgck-converter.exe", "mgck-converter.dll")
        End If
        If cb.SelectedItem = "PNM Image" Then
            Dim file As String = """" & ofd.FileName & """" & " output.pnm"
            Dim myprocess As New ProcessStartInfo
            myprocess.FileName = convert
            myprocess.Arguments = file
            Process.Start(myprocess)
            My.Computer.FileSystem.RenameFile("mgck-converter.exe", "mgck-converter.dll")
        End If
        If cb.SelectedItem = "Radiance RGBE Image" Then
            Dim file As String = """" & ofd.FileName & """" & " output.hdr"
            Dim myprocess As New ProcessStartInfo
            myprocess.FileName = convert
            myprocess.Arguments = file
            Process.Start(myprocess)
            My.Computer.FileSystem.RenameFile("mgck-converter.exe", "mgck-converter.dll")
        End If
        If cb.SelectedItem = "TarGA Image" Then
            Dim file As String = """" & ofd.FileName & """" & " output.tga"
            Dim myprocess As New ProcessStartInfo
            myprocess.FileName = convert
            myprocess.Arguments = file
            Process.Start(myprocess)
            My.Computer.FileSystem.RenameFile("mgck-converter.exe", "mgck-converter.dll")
        End If
        If cb.SelectedItem = "WebP Image" Then
            Dim file As String = """" & ofd.FileName & """" & " output.webp"
            Dim myprocess As New ProcessStartInfo
            myprocess.FileName = convert
            myprocess.Arguments = file
            Process.Start(myprocess)
            My.Computer.FileSystem.RenameFile("mgck-converter.exe", "mgck-converter.dll")
        End If
        If cb.SelectedItem = "Windows BMP Image" Then
            Dim file As String = """" & ofd.FileName & """" & " output.bmp"
            Dim myprocess As New ProcessStartInfo
            myprocess.FileName = convert
            myprocess.Arguments = file
            Process.Start(myprocess)
            My.Computer.FileSystem.RenameFile("mgck-converter.exe", "mgck-converter.dll")
        End If
        If cb.SelectedItem = "X BitMap Imnage" Then
            Dim file As String = """" & ofd.FileName & """" & " output.xbm"
            Dim myprocess As New ProcessStartInfo
            myprocess.FileName = convert
            myprocess.Arguments = file
            Process.Start(myprocess)
            My.Computer.FileSystem.RenameFile("mgck-converter.exe", "mgck-converter.dll")
        End If
        If cb.SelectedItem = "X PixMap Image" Then
            Dim file As String = """" & ofd.FileName & """" & " output.xpm"
            Dim myprocess As New ProcessStartInfo
            myprocess.FileName = convert
            myprocess.Arguments = file
            Process.Start(myprocess)
            My.Computer.FileSystem.RenameFile("mgck-converter.exe", "mgck-converter.dll")
        End If
        If cb.SelectedItem = "ZSoft PCX Image" Then
            Dim file As String = """" & ofd.FileName & """" & " output.pcx"
            Dim myprocess As New ProcessStartInfo
            myprocess.FileName = convert
            myprocess.Arguments = file
            Process.Start(myprocess)
            My.Computer.FileSystem.RenameFile("mgck-converter.exe", "mgck-converter.dll")
        End If
    End Sub

    Private Sub UserManualToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserManualToolStripMenuItem1.Click
        Try
            Process.Start("Help.chm")
        Catch ex As Exception
            MessageBox.Show("Help.chm was not found!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try
    End Sub

    Private Sub SendFeedBackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendFeedBackToolStripMenuItem.Click
        MessageBox.Show("E-Mail: mathindossoftwares@yahoo.com", "FeedBack", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub MoonBatchTeamToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoonBatchTeamToolStripMenuItem.Click
        Process.Start("https://moonbatchorg.blogspot.com")

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Image Format Converter Version-1.0 Created by MathInDOS" & vbLf & "Copyright (C) 2018-2020 MathInDOS", "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        cb.SelectedItem = "JPEG Image"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ofd.Filter = "All Image Formats (*.png)|*.png"
        If ofd.ShowDialog = DialogResult.OK Then
            TextBox1.Text = ofd.FileName
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            Process.Start("Help.chm")
        Catch ex As Exception
            MessageBox.Show("Help.chm was not found!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        MessageBox.Show("E-Mail: mathindossoftwares@yahoo.com", "FeedBack", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Process.Start("https://moonbatchorg.blogspot.com")
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.Close()
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If ofd.FileName = Nothing Then
            MessageBox.Show("Please select a image to convert!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        My.Computer.FileSystem.RenameFile("mgck-converter.dll", "mgck-converter.exe")
        Dim convert = "mgck-converter.exe"
        If cb.SelectedItem = "GIF Image" Then
            Dim file As String = """" & ofd.FileName & """" & " output.gif"
            Dim myprocess As New ProcessStartInfo
            myprocess.FileName = convert
            myprocess.Arguments = file
            Process.Start(myprocess)
            My.Computer.FileSystem.RenameFile("mgck-converter.exe", "mgck-converter.dll")
        End If
        If cb.SelectedItem = "JPEG Image" Then
            Dim file As String = """" & ofd.FileName & """" & " output.jpg"
            Dim myprocess As New ProcessStartInfo
            myprocess.FileName = convert
            myprocess.Arguments = file
            Process.Start(myprocess)
            My.Computer.FileSystem.RenameFile("mgck-converter.exe", "mgck-converter.dll")
        End If
        If cb.SelectedItem = "PBM / PGM Image" Then
            Dim file As String = """" & ofd.FileName & """" & " output.pbm"
            Dim myprocess As New ProcessStartInfo
            myprocess.FileName = convert
            myprocess.Arguments = file
            Process.Start(myprocess)
            My.Computer.FileSystem.RenameFile("mgck-converter.exe", "mgck-converter.dll")
        End If
        If cb.SelectedItem = "PhotoShop Image" Then
            Dim file As String = """" & ofd.FileName & """" & " output.psd"
            Dim myprocess As New ProcessStartInfo
            myprocess.FileName = convert
            myprocess.Arguments = file
            Process.Start(myprocess)
            My.Computer.FileSystem.RenameFile("mgck-converter.exe", "mgck-converter.dll")
        End If
        If cb.SelectedItem = "PNG Image" Then
            Dim file As String = """" & ofd.FileName & """" & " output.png"
            Dim myprocess As New ProcessStartInfo
            myprocess.FileName = convert
            myprocess.Arguments = file
            Process.Start(myprocess)
            My.Computer.FileSystem.RenameFile("mgck-converter.exe", "mgck-converter.dll")
        End If
        If cb.SelectedItem = "PNM Image" Then
            Dim file As String = """" & ofd.FileName & """" & " output.pnm"
            Dim myprocess As New ProcessStartInfo
            myprocess.FileName = convert
            myprocess.Arguments = file
            Process.Start(myprocess)
            My.Computer.FileSystem.RenameFile("mgck-converter.exe", "mgck-converter.dll")
        End If
        If cb.SelectedItem = "Radiance RGBE Image" Then
            Dim file As String = """" & ofd.FileName & """" & " output.hdr"
            Dim myprocess As New ProcessStartInfo
            myprocess.FileName = convert
            myprocess.Arguments = file
            Process.Start(myprocess)
            My.Computer.FileSystem.RenameFile("mgck-converter.exe", "mgck-converter.dll")
        End If
        If cb.SelectedItem = "TarGA Image" Then
            Dim file As String = """" & ofd.FileName & """" & " output.tga"
            Dim myprocess As New ProcessStartInfo
            myprocess.FileName = convert
            myprocess.Arguments = file
            Process.Start(myprocess)
            My.Computer.FileSystem.RenameFile("mgck-converter.exe", "mgck-converter.dll")
        End If
        If cb.SelectedItem = "WebP Image" Then
            Dim file As String = """" & ofd.FileName & """" & " output.webp"
            Dim myprocess As New ProcessStartInfo
            myprocess.FileName = convert
            myprocess.Arguments = file
            Process.Start(myprocess)
            My.Computer.FileSystem.RenameFile("mgck-converter.exe", "mgck-converter.dll")
        End If
        If cb.SelectedItem = "Windows BMP Image" Then
            Dim file As String = """" & ofd.FileName & """" & " output.bmp"
            Dim myprocess As New ProcessStartInfo
            myprocess.FileName = convert
            myprocess.Arguments = file
            Process.Start(myprocess)
            My.Computer.FileSystem.RenameFile("mgck-converter.exe", "mgck-converter.dll")
        End If
        If cb.SelectedItem = "X BitMap Imnage" Then
            Dim file As String = """" & ofd.FileName & """" & " output.xbm"
            Dim myprocess As New ProcessStartInfo
            myprocess.FileName = convert
            myprocess.Arguments = file
            Process.Start(myprocess)
            My.Computer.FileSystem.RenameFile("mgck-converter.exe", "mgck-converter.dll")
        End If
        If cb.SelectedItem = "X PixMap Image" Then
            Dim file As String = """" & ofd.FileName & """" & " output.xpm"
            Dim myprocess As New ProcessStartInfo
            myprocess.FileName = convert
            myprocess.Arguments = file
            Process.Start(myprocess)
            My.Computer.FileSystem.RenameFile("mgck-converter.exe", "mgck-converter.dll")
        End If
        If cb.SelectedItem = "ZSoft PCX Image" Then
            Dim file As String = """" & ofd.FileName & """" & " output.pcx"
            Dim myprocess As New ProcessStartInfo
            myprocess.FileName = convert
            myprocess.Arguments = file
            Process.Start(myprocess)
            My.Computer.FileSystem.RenameFile("mgck-converter.exe", "mgck-converter.dll")
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub


End Class
