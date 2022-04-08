Public Class ImageShow
    Public Function Set_Image_Show(pictureBox)
        PictureBoxImageShow.Image = pictureBox.Image
        Return 0
    End Function
    Private Sub ImageShow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        PictureBoxImageShow.Width = Me.Width
        PictureBoxImageShow.Height = Me.Height
    End Sub
End Class