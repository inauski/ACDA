Imports System.Xml.Linq
Public Class Form1

    Private Sub btnCrear_Click(sender As System.Object, e As System.EventArgs) Handles btnCrear.Click
        'Xdocument necesita la primera linea (version, encoding), para guardar SIEMPRE Xdocument
        'Con Xelement no se pone la primera linea pero luego lo crea como XML y la pone
        Dim contacto As XDocument =
      <?xml version="1.0" encoding="utf-8"?>
      <Contactos>
          <Contacto>
              <Nombre>Juan</Nombre>
              <EMail>juan@gmail.com</EMail>
              <Telefono Móvil="666666666" Trabajo="911111111"/>
          </Contacto>
          <Contacto>
              <Nombre>Luis</Nombre>
              <EMail>luis@gmail.com</EMail>
              <Telefono Móvil="666777777"/>
          </Contacto>
          <Contacto>
              <Nombre>María</Nombre>
              <EMail>maria@gmail.com</EMail>
              <Telefono Móvil="666888888" Personal="91222222"/>
          </Contacto>
          <Contacto>
              <Nombre>Lola</Nombre>
              <EMail>lola@gmail.com</EMail>
              <Telefono Móvil="666888888" Personal="91222222"/>
          </Contacto>
      </Contactos>

        contacto.Save("Contactos.xml")
        TextBox1.Text = "Documento creado"




    End Sub

    Private Sub btnCargar_Click(sender As System.Object, e As System.EventArgs) Handles btnCargar.Click
         Dim contactos = XDocument.Load("Contactos.xml")
        TextBox1.Text = contactos.ToString

    End Sub
End Class
