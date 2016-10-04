Public Class Form1
    Dim picturesList() As DataRow
    Dim videosList() As DataRow
    Dim audiosList() As DataRow
    Dim textsList() As DataRow
    Dim mediaData As New Trans_Multimedia

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Load_Info()
        configurar_etiquetas()
    End Sub

    Private Sub load_pictures()
        ComboBox1.Items.Clear()
        picturesList = mediaData.FindAllPictures
        For Each picture As DataRow In picturesList
            ComboBox1.Items.Add(picture.ItemArray(1))
        Next
    End Sub

    Private Sub load_videos()
        ComboBox2.Items.Clear()
        videosList = mediaData.FindAllVideos
        For Each video As DataRow In videosList
            ComboBox2.Items.Add(video.ItemArray(1))
        Next
    End Sub

    Private Sub load_audios()
        ComboBox3.Items.Clear()
        audiosList = mediaData.FindAllAudios
        For Each audio As DataRow In audiosList
            ComboBox3.Items.Add(audio.ItemArray(1))
        Next
    End Sub

    Private Sub load_texts()
        ComboBox4.Items.Clear()
        textsList = mediaData.FindAllTexts
        For Each text As DataRow In textsList
            ComboBox4.Items.Add(text.ItemArray(1))
        Next
    End Sub

    Private Sub configurar_etiquetas()
        Label1.Text = "Imágenes"
        Label2.Text = "Videos"
        Label3.Text = "Audios"
        Label4.Text = "Texto"
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Hide_Objects()
        Dim One_Image() As DataRow
        PictureBox1.Visible = True
        One_Image = mediaData.FindPictureByName(ComboBox1.Text)
        PictureBox1.ImageLocation = One_Image(0).ItemArray(2)
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Hide_Objects()
        Dim One_Video() As DataRow
        AxWindowsMediaPlayer1.Visible = True
        One_Video = mediaData.FindVideoByName(ComboBox2.Text)
        AxWindowsMediaPlayer1.URL = One_Video(0).ItemArray(2)
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        Hide_Objects()
        Dim One_Audio() As DataRow
        AxWindowsMediaPlayer1.Visible = True
        One_Audio = mediaData.FindAudioByName(ComboBox3.Text)
        AxWindowsMediaPlayer1.URL = One_Audio(0).ItemArray(2)
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
        Hide_Objects()
        Dim One_Text() As DataRow
        RichTextBox1.Visible = True
        One_Text = mediaData.FindTextByName(ComboBox4.Text)
        RichTextBox1.LoadFile(One_Text(0).ItemArray(2))
    End Sub
    Private Sub Hide_Objects()
        PictureBox1.Visible = False
        PictureBox1.ImageLocation = ""
        AxWindowsMediaPlayer1.Visible = False
        AxWindowsMediaPlayer1.URL = ""
        RichTextBox1.Visible = False
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        NewMedia.Show()
        NewMedia.Text = "Nueva Imagen"
        NewMedia.TextBox3.Text = "0"
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        NewMedia.Show()
        NewMedia.Text = "Nuevo Video"
        NewMedia.TextBox3.Text = "1"
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        NewMedia.Show()
        NewMedia.Text = "Nuevo Audio"
        NewMedia.TextBox3.Text = "2"
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        NewMedia.Show()
        NewMedia.Text = "Nuevo Texto"
        NewMedia.TextBox3.Text = "3"
    End Sub

    Public Sub Load_Info()
        load_pictures()
        load_videos()
        load_audios()
        load_texts()
        load_firma()
    End Sub

    Private Sub load_firma()
        Label5.Text = "Wilmer Manuel Amézquita Obando"
        Label6.Text = "Visual Basic Avanzado"
        Label7.Text = "Ejercicio 3 - Actividad 2"
    End Sub
End Class

