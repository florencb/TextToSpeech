Public Class frmMain
    Dim NickiMinaj As Object = CreateObject("SAPI.SpVoice")
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtText.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub btnRap_Click(sender As Object, e As EventArgs) Handles btnRap.Click
        NickiMinaj.rate = 3
        NickiMinaj.Speak(txtText.Text)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
