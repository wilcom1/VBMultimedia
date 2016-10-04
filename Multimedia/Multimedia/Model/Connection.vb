Public Class Connection
    Dim connection As New OleDb.OleDbConnection
    Dim command As New OleDb.OleDbCommand
    Dim adaptor As New OleDb.OleDbDataAdapter
    Dim data As New DataSet

    Sub New()
        Try
            connection = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\WILMERMANUEL\documents\visual studio 2010\Projects\Multimedia\Multimedia\Multimedia.mdb")
            connection.Open()
        Catch ex As Exception
            'TODO
        End Try
    End Sub

    Public Function QueryExec(Query As String, Table As String)
        Dim data As New DataSet
        adaptor = New System.Data.OleDb.OleDbDataAdapter(Query, connection)
        adaptor.Fill(data, Table)
        connection.Close()
        Return data
    End Function
End Class
