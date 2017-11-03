Public Class Form1

    Private Sub btnBailes1_Click(sender As System.Object, e As System.EventArgs) Handles btnBailes1.Click
        Dim baile = XDocument.Load("Bailes.xml")
        TextBox1.Text = baile.ToString

        baile.Save("Bailes.xml")
        Dim bailes = XDocument.Load("Bailes.xml")
        TextBox1.Text = bailes.ToString
    End Sub

    Private Sub btnActividades_Click(sender As System.Object, e As System.EventArgs) Handles btnActividades.Click
        Dim bailes2 = XDocument.Load("Bailes.xml")

        'Modificar XML
        Dim consulta As XElement =
            <Actividades>
                <%= From bai In bailes2...<baile>
                    Select <actividad>
                               <%= bai.<nombre> %>
                               <%= bai.<precio> %>
                               <%= bai.<profesor> %>
                           </actividad>
                %>
            </Actividades>

        consulta.Save("Actividades.xml")
        Dim b = XDocument.Load("Actividades.xml")
        TextBox2.Text = b.ToString
    End Sub
End Class
