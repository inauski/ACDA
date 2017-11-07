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
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnCoches2 = New System.Windows.Forms.Button()
        Me.btnCoches = New System.Windows.Forms.Button()
        Me.rbtArriba = New System.Windows.Forms.RadioButton()
        Me.rbtAbajo = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(333, 45)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(285, 394)
        Me.TextBox2.TabIndex = 13
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(42, 45)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(285, 394)
        Me.TextBox1.TabIndex = 12
        '
        'btnCoches2
        '
        Me.btnCoches2.Location = New System.Drawing.Point(405, 459)
        Me.btnCoches2.Name = "btnCoches2"
        Me.btnCoches2.Size = New System.Drawing.Size(144, 23)
        Me.btnCoches2.TabIndex = 11
        Me.btnCoches2.Text = "Cargar coches2.xml"
        Me.btnCoches2.UseVisualStyleBackColor = True
        '
        'btnCoches
        '
        Me.btnCoches.Location = New System.Drawing.Point(82, 459)
        Me.btnCoches.Name = "btnCoches"
        Me.btnCoches.Size = New System.Drawing.Size(109, 23)
        Me.btnCoches.TabIndex = 10
        Me.btnCoches.Text = "Cargar coches.xml"
        Me.btnCoches.UseVisualStyleBackColor = True
        '
        'rbtArriba
        '
        Me.rbtArriba.AutoSize = True
        Me.rbtArriba.Location = New System.Drawing.Point(352, 22)
        Me.rbtArriba.Name = "rbtArriba"
        Me.rbtArriba.Size = New System.Drawing.Size(85, 17)
        Me.rbtArriba.TabIndex = 14
        Me.rbtArriba.TabStop = True
        Me.rbtArriba.Text = "Cargar arriba"
        Me.rbtArriba.UseVisualStyleBackColor = True
        '
        'rbtAbajo
        '
        Me.rbtAbajo.AutoSize = True
        Me.rbtAbajo.Location = New System.Drawing.Point(464, 22)
        Me.rbtAbajo.Name = "rbtAbajo"
        Me.rbtAbajo.Size = New System.Drawing.Size(85, 17)
        Me.rbtAbajo.TabIndex = 15
        Me.rbtAbajo.TabStop = True
        Me.rbtAbajo.Text = "Cargar abajo"
        Me.rbtAbajo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 527)
        Me.Controls.Add(Me.rbtAbajo)
        Me.Controls.Add(Me.rbtArriba)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnCoches2)
        Me.Controls.Add(Me.btnCoches)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnCoches2 As System.Windows.Forms.Button
    Friend WithEvents btnCoches As System.Windows.Forms.Button
    Friend WithEvents rbtArriba As System.Windows.Forms.RadioButton
    Friend WithEvents rbtAbajo As System.Windows.Forms.RadioButton

End Class
