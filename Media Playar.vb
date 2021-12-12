Public Class mwmp

    Shared URL As String
    Shared Ctlcontrols As Object

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub OFDB_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OFDB.FileOk

    End Sub

    Private Sub Open_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOpen.Click
        OFDB.InitialDirectory = "F:\ALL FILES\My Music\chamila"
        OFDB.ShowDialog()
        wmp.URL = OFDB.FileName()
        wmp.Ctlcontrols.play()



    End Sub

    Private Sub play_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPlay.Click
        wmp.Ctlcontrols.play()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPlay.Click
        wmp.Ctlcontrols.play()
    End Sub

    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        Application.Exit()
    End Sub

    Private Sub mnuPause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPause.Click
        wmp.Ctlcontrols.pause()
    End Sub

    Private Sub cmdPause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPause.Click
        wmp.Ctlcontrols.pause()
    End Sub

    Private Sub cmdStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStop.Click
        wmp.Ctlcontrols.stop()
    End Sub

    Private Sub txtLenth_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLenth.TextChanged
        
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        txtLenth.Text = wmp.Ctlcontrols.currentPositionString
        txtPotition.Text = wmp.Ctlcontrols.currentPosition
    End Sub

    Private Sub mnuUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuUp.Click
        wmp.settings.volume = +10
    End Sub

    Private Sub mnuDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDown.Click
        wmp.settings.volume = -10
    End Sub

    Private Sub mnuMute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMute.Click
        wmp.settings.volume = wmp.settings.mute()
    End Sub

    Private Sub cmdNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        wmp.Ctlcontrols.next()

    End Sub

    Private Sub mnuStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuStop.Click
        wmp.Ctlcontrols.stop()
    End Sub


    Private Sub FileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub wmp_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles wmp.Enter

    End Sub

    Private Sub VolumeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VolumeToolStripMenuItem.Click

    End Sub
End Class
