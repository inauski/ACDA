Public Class Form1

    Private Sub btnBailes1_Click(sender As System.Object, e As System.EventArgs) Handles btnBailes1.Click
        'Dim baile As XDocument =
        '<?xml version="1.0" encoding="UTF-8"?>
        '<Bailes>
        '    <baile id="1">
        '        <nombre>Tango</nombre>
        '        <precio cuota="mensual">37</precio>
        '        <plazas>16</plazas>
        '        <comienzo>2012-09-01</comienzo>
        '        <fin>2012-12-01</fin>
        '        <profesor>Juan Diego</profesor>
        '        <sala>A1</sala>
        '    </baile>
        '    <baile id="2">
        '        <nombre>Cha-cha-cha</nombre>
        '        <precio cuota="trimestral">90</precio>
        '        <plazas>12</plazas>
        '        <comienzo>2012-02-01</comienzo>
        '        <fin>2012-11-01</fin>
        '        <profesor>Maitetxu</profesor>
        '        <sala>A1</sala>
        '    </baile>
        '    <baile id="3">
        '        <nombre>Rock</nombre>
        '        <precio cuota="mensual">43</precio>
        '        <plazas>15</plazas>
        '        <comienzo>2012-01-01</comienzo>
        '        <fin>2012-06-01</fin>
        '        <profesor>Saioa</profesor>
        '        <sala>A1</sala>
        '    </baile>
        '    <baile id="4">
        '        <nombre>Bachata</nombre>
        '        <precio cuota="mensual">25</precio>
        '        <plazas>18</plazas>
        '        <comienzo>2012-09-01</comienzo>
        '        <fin>2012-12-01</fin>
        '        <profesor>Paco</profesor>
        '        <sala>A3</sala>
        '    </baile>
        '    <baile id="5">
        '        <nombre>Salsa</nombre>
        '        <precio cuota="trimestral">75</precio>
        '        <plazas>22</plazas>
        '        <comienzo>2012-02-01</comienzo>
        '        <fin>2012-08-01</fin>
        '        <profesor>Marieta</profesor>
        '        <sala>A3</sala>
        '    </baile>
        '    <baile id="6">
        '        <nombre>Pasodoble</nombre>
        '        <precio cuota="anual">180</precio>
        '        <plazas>12</plazas>
        '        <comienzo>2012-01-01</comienzo>
        '        <fin>2013-01-01</fin>
        '        <profesor>Fatima</profesor>
        '        <sala>A3</sala>
        '    </baile>
        '</Bailes>

        'En vez de escribir todo el xml, se puede crear más fácil con estas dos lineas
        Dim baile = XDocument.Load("Bailes.xml")
        TextBox1.Text = baile.ToString

        baile.Save("Bailes.xml")
        Dim bailes = XDocument.Load("Bailes.xml")
        TextBox1.Text = bailes.ToString
    End Sub

    Private Sub btnBailes2_Click(sender As System.Object, e As System.EventArgs) Handles btnBailes2.Click
        Dim bailes2 = XDocument.Load("Bailes.xml")

        Dim consulta As XDocument =
            <?xml version="1.0" encoding="utf-8"?>
            <Bailes>
                <%= From bai In bailes2...<baile>
                    Where bai.<plazas>.Value > 15
                    Select bai
                %>
            </Bailes>

        consulta.Save("Bailes2.xml")
        Dim b = XDocument.Load("Bailes2.xml")
        TextBox2.Text = b.ToString

        'Otra forma de hacerlo, se hace la consutla fuera y luego se pregunta por ella 
        'Dim doc As XDocument = XDocument.Load("bailes.xml")
        'Dim consulta = _
        '        From baile In doc...<baile>
        '        Where (baile.<plazas>.Value > 15)
        '        Select baile
        'Dim docAux As XDocument = _
        '        <?xml version="1.0" encoding="UTF-8"?>
        '        <bailes>
        '            <%= consulta %>
        '        </bailes>

        'docAux.Save("bailes2.xml")
        'MessageBox.Show("Archivo creado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'Private Function docAux() As Object
        '    Throw New NotImplementedException
        'End Function
    End Sub
End Class
