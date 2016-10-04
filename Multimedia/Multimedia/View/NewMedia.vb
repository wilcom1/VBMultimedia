Public Class NewMedia
    Dim transaction As New Trans_Multimedia
    Dim type As String
    Dim result As Boolean
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If Validate_TextBox() Then
            result = transaction.InsertNew(TextBox1.Text, TextBox2.Text, TextBox3.Text)
            If result Then
                MsgBox("El registro se guardó exitosamente", MsgBoxStyle.OkOnly, "Exito")
                Form1.Load_Info()
                Me.Close()
            Else
                MsgBox("Error guadando el registro. Intente nuevamente", MsgBoxStyle.OkOnly, "Error")
            End If
        End If
    End Sub

    Private Sub NewMedia_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Button1.Text = "Aceptar"
        Button2.Text = "Cancelar"
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        Me.Hide()
    End Sub
    Private Function Validate_TextBox()
        If TextBox1.Text.Length = 0 Or TextBox1.Text.StartsWith(" ") Then
            MsgBox("Por favor diligencie los campos", MsgBoxStyle.Critical, "Atención")
            Return False
        End If
        If TextBox2.Text.Length = 0 Or TextBox2.Text.StartsWith(" ") Then
            MsgBox("Por favor diligencie los campos", MsgBoxStyle.Critical, "Atención")
            Return False
        End If
        Return True
    End Function
End Class