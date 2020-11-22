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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cb = New System.Windows.Forms.ComboBox
        Me.ofd = New System.Windows.Forms.OpenFileDialog
        Me.sfd = New System.Windows.Forms.SaveFileDialog
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.AddInputFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConvertToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConvertToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.UserManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UserManualToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.SendFeedBackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MoonBatchTeamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Input File:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(9, 104)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(417, 20)
        Me.TextBox1.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 15)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Output:"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.Window
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.ImeMode = System.Windows.Forms.ImeMode.AlphaFull
        Me.ComboBox1.Items.AddRange(New Object() {"Output"})
        Me.ComboBox1.Location = New System.Drawing.Point(11, 154)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(415, 21)
        Me.ComboBox1.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 15)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Output Format:"
        '
        'cb
        '
        Me.cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb.FormattingEnabled = True
        Me.cb.Items.AddRange(New Object() {"GIF Image", "JPEG Image", "PBM / PGM Image", "PhotoShop Image", "PNG Image", "PNM Image", "Radiance RGBE Image", "TarGA Image", "WebP Image", "Windows BMP Image", "ZSoft PCX Image"})
        Me.cb.Location = New System.Drawing.Point(11, 208)
        Me.cb.Name = "cb"
        Me.cb.Size = New System.Drawing.Size(415, 21)
        Me.cb.TabIndex = 17
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 240)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.Size = New System.Drawing.Size(567, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 18
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel1.Text = "Ready"
        '
        'Button3
        '
        Me.Button3.Image = Global.ImageFormatConverter.My.Resources.Resources.go_48
        Me.Button3.Location = New System.Drawing.Point(454, 142)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(89, 75)
        Me.Button3.TabIndex = 19
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Image = Global.ImageFormatConverter.My.Resources.Resources.add_161
        Me.Button9.Location = New System.Drawing.Point(438, 101)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(23, 23)
        Me.Button9.TabIndex = 11
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Image = Global.ImageFormatConverter.My.Resources.Resources.exit_32
        Me.Button8.Location = New System.Drawing.Point(516, 28)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(39, 39)
        Me.Button8.TabIndex = 8
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Image = Global.ImageFormatConverter.My.Resources.Resources.home_321
        Me.Button7.Location = New System.Drawing.Point(422, 27)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(39, 39)
        Me.Button7.TabIndex = 7
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Image = Global.ImageFormatConverter.My.Resources.Resources.mail_32
        Me.Button6.Location = New System.Drawing.Point(374, 27)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(39, 39)
        Me.Button6.TabIndex = 6
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Image = Global.ImageFormatConverter.My.Resources.Resources.help_32
        Me.Button5.Location = New System.Drawing.Point(255, 28)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(39, 39)
        Me.Button5.TabIndex = 5
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Image = Global.ImageFormatConverter.My.Resources.Resources.go_32
        Me.Button4.Location = New System.Drawing.Point(207, 28)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(39, 39)
        Me.Button4.TabIndex = 4
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.ImageFormatConverter.My.Resources.Resources.add_32
        Me.Button2.Location = New System.Drawing.Point(54, 28)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(39, 39)
        Me.Button2.TabIndex = 2
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.ImageFormatConverter.My.Resources.Resources.new_32
        Me.Button1.Location = New System.Drawing.Point(6, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(39, 39)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MenuStrip1.BackgroundImage = Global.ImageFormatConverter.My.Resources.Resources.head
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ConvertToolStripMenuItem, Me.UserManualToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(567, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.ToolStripSeparator1, Me.AddInputFileToolStripMenuItem, Me.ToolStripSeparator2, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Image = Global.ImageFormatConverter.My.Resources.Resources.new_16
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(196, 6)
        '
        'AddInputFileToolStripMenuItem
        '
        Me.AddInputFileToolStripMenuItem.Image = Global.ImageFormatConverter.My.Resources.Resources.add_16
        Me.AddInputFileToolStripMenuItem.Name = "AddInputFileToolStripMenuItem"
        Me.AddInputFileToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AddInputFileToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.AddInputFileToolStripMenuItem.Text = "Add Input File..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(196, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.ImageFormatConverter.My.Resources.Resources.exit_16
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ConvertToolStripMenuItem
        '
        Me.ConvertToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConvertToolStripMenuItem1})
        Me.ConvertToolStripMenuItem.Name = "ConvertToolStripMenuItem"
        Me.ConvertToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ConvertToolStripMenuItem.Text = "Converter"
        '
        'ConvertToolStripMenuItem1
        '
        Me.ConvertToolStripMenuItem1.Image = Global.ImageFormatConverter.My.Resources.Resources.go_16
        Me.ConvertToolStripMenuItem1.Name = "ConvertToolStripMenuItem1"
        Me.ConvertToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F7
        Me.ConvertToolStripMenuItem1.Size = New System.Drawing.Size(135, 22)
        Me.ConvertToolStripMenuItem1.Text = "Convert"
        '
        'UserManualToolStripMenuItem
        '
        Me.UserManualToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserManualToolStripMenuItem1, Me.ToolStripSeparator3, Me.SendFeedBackToolStripMenuItem, Me.MoonBatchTeamToolStripMenuItem, Me.ToolStripSeparator4, Me.AboutToolStripMenuItem})
        Me.UserManualToolStripMenuItem.Name = "UserManualToolStripMenuItem"
        Me.UserManualToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.UserManualToolStripMenuItem.Text = "Help"
        '
        'UserManualToolStripMenuItem1
        '
        Me.UserManualToolStripMenuItem1.Image = Global.ImageFormatConverter.My.Resources.Resources.help_16
        Me.UserManualToolStripMenuItem1.Name = "UserManualToolStripMenuItem1"
        Me.UserManualToolStripMenuItem1.Size = New System.Drawing.Size(161, 22)
        Me.UserManualToolStripMenuItem1.Text = "User Manual"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(158, 6)
        '
        'SendFeedBackToolStripMenuItem
        '
        Me.SendFeedBackToolStripMenuItem.Image = Global.ImageFormatConverter.My.Resources.Resources.mail_16
        Me.SendFeedBackToolStripMenuItem.Name = "SendFeedBackToolStripMenuItem"
        Me.SendFeedBackToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.SendFeedBackToolStripMenuItem.Text = "Send FeedBack"
        '
        'MoonBatchTeamToolStripMenuItem
        '
        Me.MoonBatchTeamToolStripMenuItem.Image = Global.ImageFormatConverter.My.Resources.Resources.home_16
        Me.MoonBatchTeamToolStripMenuItem.Name = "MoonBatchTeamToolStripMenuItem"
        Me.MoonBatchTeamToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.MoonBatchTeamToolStripMenuItem.Text = "Visit MoonBatch"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(158, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = Global.ImageFormatConverter.My.Resources.Resources.about_16
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(567, 262)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.cb)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ImageFormatConverter Version-1.0"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddInputFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConvertToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConvertToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserManualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserManualToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SendFeedBackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MoonBatchTeamToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cb As System.Windows.Forms.ComboBox
    Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents sfd As System.Windows.Forms.SaveFileDialog
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
