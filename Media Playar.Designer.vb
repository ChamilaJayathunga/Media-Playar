<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mwmp
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mwmp))
        Me.wmp = New AxWMPLib.AxWindowsMediaPlayer()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPlay = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPause = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStop = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolumeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDown = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMute = New System.Windows.Forms.ToolStripMenuItem()
        Me.OFDB = New System.Windows.Forms.OpenFileDialog()
        Me.cmdPlay = New System.Windows.Forms.Button()
        Me.cmdPause = New System.Windows.Forms.Button()
        Me.cmdStop = New System.Windows.Forms.Button()
        Me.txtLenth = New System.Windows.Forms.TextBox()
        Me.txtPotition = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.wmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'wmp
        '
        Me.wmp.AllowDrop = True
        Me.wmp.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.wmp.Enabled = True
        Me.wmp.Location = New System.Drawing.Point(12, 61)
        Me.wmp.Name = "wmp"
        Me.wmp.OcxState = CType(resources.GetObject("wmp.OcxState"), System.Windows.Forms.AxHost.State)
        Me.wmp.Size = New System.Drawing.Size(1340, 647)
        Me.wmp.TabIndex = 0
        Me.wmp.UseWaitCursor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 31)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1364, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.PlayerToolStripMenuItem, Me.VolumeToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(1364, 31)
        Me.MenuStrip2.TabIndex = 2
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOpen, Me.mnuExit})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Tekton Pro Ext", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(56, 27)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'mnuOpen
        '
        Me.mnuOpen.Name = "mnuOpen"
        Me.mnuOpen.Size = New System.Drawing.Size(132, 28)
        Me.mnuOpen.Text = "Open"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(132, 28)
        Me.mnuExit.Text = "Exit"
        '
        'PlayerToolStripMenuItem
        '
        Me.PlayerToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.PlayerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPlay, Me.mnuPause, Me.mnuStop})
        Me.PlayerToolStripMenuItem.Font = New System.Drawing.Font("Tekton Pro Ext", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.PlayerToolStripMenuItem.Name = "PlayerToolStripMenuItem"
        Me.PlayerToolStripMenuItem.Size = New System.Drawing.Size(85, 27)
        Me.PlayerToolStripMenuItem.Text = "Player"
        '
        'mnuPlay
        '
        Me.mnuPlay.Name = "mnuPlay"
        Me.mnuPlay.Size = New System.Drawing.Size(141, 28)
        Me.mnuPlay.Text = "Play"
        '
        'mnuPause
        '
        Me.mnuPause.Name = "mnuPause"
        Me.mnuPause.Size = New System.Drawing.Size(141, 28)
        Me.mnuPause.Text = "Pause"
        '
        'mnuStop
        '
        Me.mnuStop.Name = "mnuStop"
        Me.mnuStop.Size = New System.Drawing.Size(141, 28)
        Me.mnuStop.Text = "Stop"
        '
        'VolumeToolStripMenuItem
        '
        Me.VolumeToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.VolumeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuUp, Me.mnuDown, Me.mnuMute})
        Me.VolumeToolStripMenuItem.Font = New System.Drawing.Font("Tekton Pro Ext", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VolumeToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.VolumeToolStripMenuItem.Name = "VolumeToolStripMenuItem"
        Me.VolumeToolStripMenuItem.Size = New System.Drawing.Size(93, 27)
        Me.VolumeToolStripMenuItem.Text = "Volume"
        '
        'mnuUp
        '
        Me.mnuUp.Name = "mnuUp"
        Me.mnuUp.Size = New System.Drawing.Size(135, 28)
        Me.mnuUp.Text = "Up"
        '
        'mnuDown
        '
        Me.mnuDown.Name = "mnuDown"
        Me.mnuDown.Size = New System.Drawing.Size(135, 28)
        Me.mnuDown.Text = "Down"
        '
        'mnuMute
        '
        Me.mnuMute.Name = "mnuMute"
        Me.mnuMute.Size = New System.Drawing.Size(135, 28)
        Me.mnuMute.Text = "Mute"
        '
        'OFDB
        '
        Me.OFDB.FileName = "OpenFileDialog1"
        '
        'cmdPlay
        '
        Me.cmdPlay.BackColor = System.Drawing.Color.SpringGreen
        Me.cmdPlay.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPlay.Location = New System.Drawing.Point(12, 678)
        Me.cmdPlay.Name = "cmdPlay"
        Me.cmdPlay.Size = New System.Drawing.Size(208, 30)
        Me.cmdPlay.TabIndex = 3
        Me.cmdPlay.Text = "Play"
        Me.cmdPlay.UseVisualStyleBackColor = False
        '
        'cmdPause
        '
        Me.cmdPause.BackColor = System.Drawing.Color.SpringGreen
        Me.cmdPause.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPause.Location = New System.Drawing.Point(217, 678)
        Me.cmdPause.Name = "cmdPause"
        Me.cmdPause.Size = New System.Drawing.Size(208, 30)
        Me.cmdPause.TabIndex = 4
        Me.cmdPause.Text = "Pause"
        Me.cmdPause.UseVisualStyleBackColor = False
        '
        'cmdStop
        '
        Me.cmdStop.BackColor = System.Drawing.Color.SpringGreen
        Me.cmdStop.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdStop.Location = New System.Drawing.Point(424, 678)
        Me.cmdStop.Name = "cmdStop"
        Me.cmdStop.Size = New System.Drawing.Size(212, 30)
        Me.cmdStop.TabIndex = 5
        Me.cmdStop.Text = "Stop"
        Me.cmdStop.UseVisualStyleBackColor = False
        '
        'txtLenth
        '
        Me.txtLenth.Location = New System.Drawing.Point(642, 686)
        Me.txtLenth.Multiline = True
        Me.txtLenth.Name = "txtLenth"
        Me.txtLenth.Size = New System.Drawing.Size(10, 10)
        Me.txtLenth.TabIndex = 6
        '
        'txtPotition
        '
        Me.txtPotition.Location = New System.Drawing.Point(658, 686)
        Me.txtPotition.Multiline = True
        Me.txtPotition.Name = "txtPotition"
        Me.txtPotition.Size = New System.Drawing.Size(10, 10)
        Me.txtPotition.TabIndex = 7
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.Tan
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(0, 714)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(1364, 26)
        Me.ListBox1.TabIndex = 8
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Pristina", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(574, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(261, 55)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "CR Media Playar"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication4.My.Resources.Resources.C__Data_Users_DefApps_AppData_INTERNETEXPLORER_Temp_Saved_Images_images_5__1_
        Me.PictureBox1.Location = New System.Drawing.Point(437, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApplication4.My.Resources.Resources.C__Data_Users_DefApps_AppData_INTERNETEXPLORER_Temp_Saved_Images_images_2__1_
        Me.PictureBox2.Location = New System.Drawing.Point(834, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(132, 55)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'mwmp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1364, 743)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.txtPotition)
        Me.Controls.Add(Me.txtLenth)
        Me.Controls.Add(Me.cmdStop)
        Me.Controls.Add(Me.cmdPause)
        Me.Controls.Add(Me.cmdPlay)
        Me.Controls.Add(Me.wmp)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "mwmp"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.wmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents wmp As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlayerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPlay As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPause As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuStop As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VolumeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuUp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDown As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMute As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OFDB As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cmdPlay As System.Windows.Forms.Button
    Friend WithEvents cmdPause As System.Windows.Forms.Button
    Friend WithEvents cmdStop As System.Windows.Forms.Button
    Friend WithEvents txtLenth As System.Windows.Forms.TextBox
    Friend WithEvents txtPotition As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox

End Class
