Imports System.Xml.Linq
Imports System.Xml

Public Class Form1


    Private Sub btnMostrarNombre_Click(sender As System.Object, e As System.EventArgs) Handles btnMostrar.Click
        'obtener origen de datos
        Dim doc = XDocument.Load("Contactos.xml")

        'crear consulta
        Dim Selección = _
            From datos In doc...<Contacto>
            Select datos.<Nombre>.Value

        'ejecutar consulta
        For Each nom In Selección
            ListBox1.Items.Add(nom)
        Next

    End Sub

    Private Sub btnMostrarNomTel_Click(sender As System.Object, e As System.EventArgs) Handles btnMostrarNomTel.Click
        Dim doc = XDocument.Load("Contactos.xml")

        Dim Seleccion = _
            From datos In doc...<Contacto>
            Where datos.<Nombre>.Value Like "L*" And datos.<Telefono>.@Móvil
            Select datos.<Nombre>.Value, datos.<Telefono>.@Móvil, casa = datos.<Telefono>.@Personal 'Para varios atributos, aqui solo es necesario el movil

        For Each nom In Seleccion
            ListBox2.Items.Add(nom.Nombre & "-" & nom.Móvil & "-" & nom.casa)
        Next

    End Sub
End Class
