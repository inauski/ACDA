Imports System.Xml
Public Class Form1
    Private cambio As XDocument
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = XDocument.Load("Bailes.xml").ToString
        cambio = XDocument.Load("Bailes.xml")
        TextBox2.Text = cambio.ToString
    End Sub

    Private Sub btnCoches_Click(sender As System.Object, e As System.EventArgs) Handles btnCoches.Click
        Dim coches = XDocument.Load("coches.xml")
        TextBox1.Text = coches.ToString
    End Sub

    Private Sub btnCoches2_Click(sender As System.Object, e As System.EventArgs) Handles btnCambio.Click
        Dim cont As Char = "A"
        For Each elem In cambio.<Bailes>.Elements
            elem.ReplaceAttributes(New XAttribute("id", cont))
            cont = ChrW(AscW(cont) + 1)
        Next
        TextBox2.Text = cambio.ToString


        'Dim coches2 = XElement.Load("coches.xml")

        'Dim root As XElement = <coche marca="">
        '                           <modelo></modelo>
        '                           <potencia></potencia>
        '                       </coche>
        'root.ReplaceAttributes(New XAttribute("Color", "Rojo"))

        'If rbtArriba.Checked = True Then
        '    coches2.AddFirst(root)
        'ElseIf rbtAbajo.Checked = True Then
        '    coches2.Add(root)
        'End If

        'coches2.Save("coches2.xml")
        'TextBox2.Text = coches2.ToString

    End Sub

    Private Sub btnElimNodo_Click(sender As System.Object, e As System.EventArgs) Handles btnElim.Click
        Dim consulta = From baile In cambio...<baile>
                       Where baile.<plazas>.Value < 18
                       Select baile
        consulta.Remove()
        TextBox2.Text = cambio.ToString

        '' Dim coches2 = XElement.Load("coches.xml")

        'Dim doc As New XmlDocument()
        'doc.Load("coches.xml")

        ''Dim c = coches2.Element("coches").Elements
        ''For Each i In c

        ''Next
        'Dim root As XElement = <coches marca="">
        '                           <modelo></modelo>
        '                           <potencia></potencia>
        '                       </coches>
        ''root.RemoveAll()

        'root.Descendants("coche").Descendants.Remove()


        'root.Save("coches2.xml")
        'TextBox2.Text = root.ToString


        'TextBox2.Text = doc.ToString

        ''https://docs.microsoft.com/es-es/dotnet/api/System.Xml.Linq.XElement.RemoveAll?view=netframework-4.7.1
        ''https://docs.microsoft.com/es-es/dotnet/api/System.Xml.Linq.XElement.SetAttributeValue?view=netframework-4.7.1
    End Sub

   
End Class
