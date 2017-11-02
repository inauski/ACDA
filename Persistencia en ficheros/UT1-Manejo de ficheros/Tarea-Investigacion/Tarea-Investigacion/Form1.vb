Imports System
Imports System.IO
Imports System.Text
Public Class Form1
    
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnLeerComp.Click
        Dim ruta As String
        ruta = "d:\" & TextBox1.Text & ".txt"
        Try
            If (File.Exists(ruta)) Then
                Dim sr As StreamReader
                sr = New StreamReader(ruta)
                While (sr.Peek() > -1)
                    MessageBox.Show(sr.ReadToEnd())
                End While
                sr.Close()
            Else
                MessageBox.Show("Fichero inexistente")
            End If
        Catch ex As Exception
            MessageBox.Show("ERROR")
        End Try

    End Sub
End Class
