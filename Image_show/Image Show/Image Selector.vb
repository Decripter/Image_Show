Public Class Image_Show
    Public selectImages As Boolean = False

    Public Function Alterna_Seleciona_Exibe()

        selectImages = Not selectImages

        If (selectImages) Then
            CheckBox1.Text = "Exibir/Selecionar - Exibindo Imagens Selecionadas"
            Title.Text = "Exibindo Imagens Selecionadas"

            PictureBox1.BackColor = Color.IndianRed
            PictureBox2.BackColor = Color.IndianRed
            PictureBox3.BackColor = Color.IndianRed

            PictureBox4.BackColor = Color.IndianRed
            PictureBox5.BackColor = Color.IndianRed
            PictureBox6.BackColor = Color.IndianRed

            PictureBox7.BackColor = Color.IndianRed
            PictureBox8.BackColor = Color.IndianRed
            PictureBox9.BackColor = Color.IndianRed


        Else
            CheckBox1.Text = "Exibir/Selecionar - Selecione as Imagens Para Exibir"
            Title.Text = "Selecione as Imagens Para Exibir"

            PictureBox1.BackColor = Color.YellowGreen
            PictureBox2.BackColor = Color.YellowGreen
            PictureBox3.BackColor = Color.YellowGreen

            PictureBox4.BackColor = Color.YellowGreen
            PictureBox5.BackColor = Color.YellowGreen
            PictureBox6.BackColor = Color.YellowGreen

            PictureBox7.BackColor = Color.YellowGreen
            PictureBox8.BackColor = Color.YellowGreen
            PictureBox9.BackColor = Color.YellowGreen
        End If

        Return 0

    End Function

    Public Function Selecionar_Imagens_Exibir(pictureBox)
        If (selectImages) Then
            ImageShow.Set_Image_Show(pictureBox)
            ImageShow.Location = Screen.AllScreens(UBound(Screen.AllScreens)).Bounds.Location
            ImageShow.Show()


        Else
            If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then

                Try
                    pictureBox.Image = Image.FromFile(OpenFileDialog1.FileName)

                Catch ex As Exception

                End Try
            End If
        End If
        Return 0
    End Function



    Private Sub CheckBox1_Click(sender As Object, e As EventArgs) Handles CheckBox1.Click
        Alterna_Seleciona_Exibe()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click, PictureBox9.Click, PictureBox8.Click, PictureBox7.Click, PictureBox6.Click, PictureBox5.Click, PictureBox4.Click, PictureBox3.Click, PictureBox2.Click
        Selecionar_Imagens_Exibir(sender)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ImageShow.Hide()
               
    End Sub




End Class
