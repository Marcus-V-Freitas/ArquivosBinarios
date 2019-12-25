Imports System.IO
Public Class Form1
    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim arquivo As New FileStream("file.doc", FileMode.Create, FileAccess.Write)

        Dim stream As New StreamWriter(arquivo)

        stream.BaseStream.Seek(0, SeekOrigin.End)
        stream.Write(txtTexto.Text)

        stream.Close()



    End Sub

    Private Sub btnCarregar_Click(sender As Object, e As EventArgs) Handles btnCarregar.Click
        Dim arquivo As New FileStream("file.doc", FileMode.Open, FileAccess.Read)
        Dim stream As New StreamReader(arquivo)

        stream.BaseStream.Seek(0, SeekOrigin.Begin)

        While stream.Peek <> -1
            txtTexto.Text = stream.ReadLine()
        End While

        stream.Close()
    End Sub

    Private Sub btnEscrever_Click(sender As Object, e As EventArgs) Handles btnEscrever.Click
        Try
            Dim arquivo As New FileStream("file.doc", FileMode.Append, FileAccess.Write)
            Dim stream As New StreamWriter(arquivo)
            stream.BaseStream.Seek(0, SeekOrigin.End)
            stream.Write(txtTexto.Text)
            stream.Close()
        Catch f As Exception
            MessageBox.Show(f.ToString())
        End Try

    End Sub
End Class
