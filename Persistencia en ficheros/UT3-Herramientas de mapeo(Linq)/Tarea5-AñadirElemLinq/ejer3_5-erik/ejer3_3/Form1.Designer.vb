<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.up = New System.Windows.Forms.RadioButton()
        Me.down = New System.Windows.Forms.RadioButton()
        Me.marca = New System.Windows.Forms.TextBox()
        Me.modelo = New System.Windows.Forms.TextBox()
        Me.potencia = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(419, 274)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 48)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Añadir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(56, 111)
        Me.txt1.Multiline = True
        Me.txt1.Name = "txt1"
        Me.txt1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt1.Size = New System.Drawing.Size(279, 324)
        Me.txt1.TabIndex = 1
        '
        'up
        '
        Me.up.AutoSize = True
        Me.up.Checked = True
        Me.up.Location = New System.Drawing.Point(361, 274)
        Me.up.Name = "up"
        Me.up.Size = New System.Drawing.Size(52, 17)
        Me.up.TabIndex = 2
        Me.up.TabStop = True
        Me.up.Text = "Arriba"
        Me.up.UseVisualStyleBackColor = True
        '
        'down
        '
        Me.down.AutoSize = True
        Me.down.Location = New System.Drawing.Point(361, 297)
        Me.down.Name = "down"
        Me.down.Size = New System.Drawing.Size(52, 17)
        Me.down.TabIndex = 3
        Me.down.Text = "Abajo"
        Me.down.UseVisualStyleBackColor = True
        '
        'marca
        '
        Me.marca.Location = New System.Drawing.Point(419, 149)
        Me.marca.Name = "marca"
        Me.marca.Size = New System.Drawing.Size(100, 20)
        Me.marca.TabIndex = 4
        '
        'modelo
        '
        Me.modelo.Location = New System.Drawing.Point(419, 175)
        Me.modelo.Name = "modelo"
        Me.modelo.Size = New System.Drawing.Size(100, 20)
        Me.modelo.TabIndex = 5
        '
        'potencia
        '
        Me.potencia.Location = New System.Drawing.Point(419, 201)
        Me.potencia.Name = "potencia"
        Me.potencia.Size = New System.Drawing.Size(100, 20)
        Me.potencia.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(352, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Marca"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(352, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Modelo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(352, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Potencia"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 518)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.potencia)
        Me.Controls.Add(Me.modelo)
        Me.Controls.Add(Me.marca)
        Me.Controls.Add(Me.down)
        Me.Controls.Add(Me.up)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents up As System.Windows.Forms.RadioButton
    Friend WithEvents down As System.Windows.Forms.RadioButton
    Friend WithEvents marca As System.Windows.Forms.TextBox
    Friend WithEvents modelo As System.Windows.Forms.TextBox
    Friend WithEvents potencia As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
