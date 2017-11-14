Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim baile = XDocument.Load("Bailes.xml")
        RichTextBox1.Text = baile.ToString

        Dim actividades As XDocument = _
        <?xml version="1.0" encoding="UTF-8"?>
        <!--extraido a partir de los datos de Bailes.xml-->
        <Bailes>
            <%= From datos In baile...<baile>
                Select <nuevoNodo>
                           <id><%= datos.@id %></id>
                           <%= datos...<nombre> %>
                           <%= datos...<plazas> %>
                           <%= datos...<profesor> %>
                       </nuevoNodo> %>
        </Bailes>
        actividades.Save("Actividades2.xml")
        RichTextBox2.Text = actividades.ToString
    End Sub
End Class
