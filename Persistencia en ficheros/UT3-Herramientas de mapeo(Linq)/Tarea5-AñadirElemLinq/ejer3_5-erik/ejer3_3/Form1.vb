Imports System.Xml.Linq

Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim carga = XElement.Load("coches.xml")
        Dim bloque As XElement =
    <coche marca=<%= marca.Text %>>
        <modelo><%= modelo.Text %></modelo>
        <potencia><%= potencia.Text %></potencia>
    </coche>


        If up.Checked = True Then
            carga.AddFirst(bloque)
        Else
            carga.Add(bloque)
        End If

        carga.Save("coches.xml")

        txt1.Text = carga.ToString

    End Sub
End Class
