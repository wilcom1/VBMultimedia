Public Class Trans_Multimedia
    Public Function FindAllPictures()
        Dim dataset As New DataSet
        Dim connection As New Connection
        Dim i As Integer
        dataset = connection.QueryExec("SELECT * FROM Multimedia WHERE Tipo = '0'", "Multimedia")
        Dim picturesData(dataset.Tables("Multimedia").Rows.Count - 1) As DataRow
        For i = 0 To dataset.Tables("Multimedia").Rows.Count - 1
            picturesData(i) = dataset.Tables("Multimedia").Rows(i)
        Next
        Return picturesData
    End Function

    Public Function FindAllVideos()
        Dim dataset As New DataSet
        Dim connection As New Connection
        Dim i As Integer
        dataset = connection.QueryExec("SELECT * FROM Multimedia WHERE Tipo = '1'", "Multimedia")
        Dim videosData(dataset.Tables("Multimedia").Rows.Count - 1) As DataRow
        For i = 0 To dataset.Tables("Multimedia").Rows.Count - 1
            videosData(i) = dataset.Tables("Multimedia").Rows(i)
        Next
        Return videosData
    End Function

    Public Function FindAllAudios()
        Dim dataset As New DataSet
        Dim connection As New Connection
        Dim i As Integer
        dataset = connection.QueryExec("SELECT * FROM Multimedia WHERE Tipo = '2'", "Multimedia")
        Dim audiosData(dataset.Tables("Multimedia").Rows.Count - 1) As DataRow
        For i = 0 To dataset.Tables("Multimedia").Rows.Count - 1
            audiosData(i) = dataset.Tables("Multimedia").Rows(i)
        Next
        Return audiosData
    End Function
    Public Function FindAllTexts()
        Dim dataset As New DataSet
        Dim connection As New Connection
        Dim i As Integer
        dataset = connection.QueryExec("SELECT * FROM Multimedia WHERE Tipo = '3'", "Multimedia")
        Dim textsData(dataset.Tables("Multimedia").Rows.Count - 1) As DataRow
        For i = 0 To dataset.Tables("Multimedia").Rows.Count - 1
            textsData(i) = dataset.Tables("Multimedia").Rows(i)
        Next
        Return textsData
    End Function
    Public Function FindPictureByName(Nombre As String)
        Dim dataset As New DataSet
        Dim connection As New Connection
        Dim i As Integer
        dataset = connection.QueryExec("SELECT * FROM Multimedia WHERE Tipo = '0' AND Nombre='" + Nombre + "'", "Multimedia")
        Dim picturesData(dataset.Tables("Multimedia").Rows.Count - 1) As DataRow
        For i = 0 To dataset.Tables("Multimedia").Rows.Count - 1
            picturesData(i) = dataset.Tables("Multimedia").Rows(i)
        Next
        Return picturesData
    End Function
    Public Function FindVideoByName(Nombre As String)
        Dim dataset As New DataSet
        Dim connection As New Connection
        Dim i As Integer
        dataset = connection.QueryExec("SELECT * FROM Multimedia WHERE Tipo = '1' AND Nombre='" + Nombre + "'", "Multimedia")
        Dim videosData(dataset.Tables("Multimedia").Rows.Count - 1) As DataRow
        For i = 0 To dataset.Tables("Multimedia").Rows.Count - 1
            videosData(i) = dataset.Tables("Multimedia").Rows(i)
        Next
        Return videosData
    End Function
    Public Function FindAudioByName(Nombre As String)
        Dim dataset As New DataSet
        Dim connection As New Connection
        Dim i As Integer
        dataset = connection.QueryExec("SELECT * FROM Multimedia WHERE Tipo = '2' AND Nombre='" + Nombre + "'", "Multimedia")
        Dim audiosData(dataset.Tables("Multimedia").Rows.Count - 1) As DataRow
        For i = 0 To dataset.Tables("Multimedia").Rows.Count - 1
            audiosData(i) = dataset.Tables("Multimedia").Rows(i)
        Next
        Return audiosData
    End Function
    Public Function FindTextByName(Nombre As String)
        Dim dataset As New DataSet
        Dim connection As New Connection
        Dim i As Integer
        dataset = connection.QueryExec("SELECT * FROM Multimedia WHERE Tipo = '3' AND Nombre='" + Nombre + "'", "Multimedia")
        Dim textsData(dataset.Tables("Multimedia").Rows.Count - 1) As DataRow
        For i = 0 To dataset.Tables("Multimedia").Rows.Count - 1
            textsData(i) = dataset.Tables("Multimedia").Rows(i)
        Next
        Return textsData
    End Function
    Public Function InsertNew(Nombre As String, Url As String, tipo As String)
        Dim connection As New Connection
        Try
            connection.QueryExec("INSERT INTO Multimedia (Nombre,URL,Tipo) VALUES ('" + Nombre + "','" + Url + "','" + tipo + "')", "Multimedia")
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
