Public Class Form1

    Private Sub btnBailes_Click(sender As System.Object, e As System.EventArgs) Handles btnBailes.Click
        Dim baile = XDocument.Load("Bailes.xml")
        TextBox1.Text = baile.ToString

    End Sub

    Private Sub btnCambio_Click(sender As System.Object, e As System.EventArgs) Handles btnCambio.Click
        Dim bailes = XDocument.Load("Bailes.xml")

        Dim consulta As XDocument =
           <?xml version="1.0" encoding="utf-8"?>
           <!--extraido a partir de los datos de Bailes.xml-->
           <Bailes>
               <%= From bai In bailes...<baile>
                   Select <nuevoNodo>
                              <id><%= bai.@id %></id>
                              <%= bai.<nombre> %>
                              <%= bai.<plazas> %>
                              <%= bai.<profesor> %>
                          </nuevoNodo>
               %>
           </Bailes>

        consulta.Save("Actividades2.xml")
        TextBox2.Text = consulta.ToString
    End Sub
End Class
