Imports System

Public Class Form1

    Private Sub btnCoches_Click(sender As System.Object, e As System.EventArgs) Handles btnCoches.Click
        Dim coches = XDocument.Load("coches.xml")
        TextBox1.Text = coches.ToString
    End Sub

    Private Sub btnCoches2_Click(sender As System.Object, e As System.EventArgs) Handles btnCoches2.Click
        Dim coches2 = XElement.Load("coches.xml")

        Dim marca As String = InputBox("", "MARCA")
        Dim modelo As String = InputBox("", "MODELO")
        Dim potencia As String = InputBox("", "POTENCIA")

        Dim consulta As XElement = <coche marca=<%= marca %>>
                                       <modelo><%= modelo %></modelo>
                                       <potencia><%= potencia %></potencia>
                                   </coche>

        If rbtArriba.Checked = True Then
            coches2.AddFirst(consulta)
        ElseIf rbtAbajo.Checked = True Then
            coches2.Add(consulta)
        End If

        coches2.Save("coches2.xml")
        TextBox2.Text = coches2.ToString


    End Sub

   
End Class
