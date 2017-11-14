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
        Me.rbtAbajo = New System.Windows.Forms.RadioButton()
        Me.rbtArriba = New System.Windows.Forms.RadioButton()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnCambio = New System.Windows.Forms.Button()
        Me.btnCoches = New System.Windows.Forms.Button()
        Me.btnElim = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rbtAbajo
        '
        Me.rbtAbajo.AutoSize = True
        Me.rbtAbajo.Location = New System.Drawing.Point(474, 22)
        Me.rbtAbajo.Name = "rbtAbajo"
        Me.rbtAbajo.Size = New System.Drawing.Size(85, 17)
        Me.rbtAbajo.TabIndex = 21
        Me.rbtAbajo.TabStop = True
        Me.rbtAbajo.Text = "Cargar abajo"
        Me.rbtAbajo.UseVisualStyleBackColor = True
        '
        'rbtArriba
        '
        Me.rbtArriba.AutoSize = True
        Me.rbtArriba.Location = New System.Drawing.Point(362, 22)
        Me.rbtArriba.Name = "rbtArriba"
        Me.rbtArriba.Size = New System.Drawing.Size(85, 17)
        Me.rbtArriba.TabIndex = 20
        Me.rbtArriba.TabStop = True
        Me.rbtArriba.Text = "Cargar arriba"
        Me.rbtArriba.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(343, 45)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(285, 394)
        Me.TextBox2.TabIndex = 19
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(52, 45)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(285, 394)
        Me.TextBox1.TabIndex = 18
        '
        'btnCambio
        '
        Me.btnCambio.Location = New System.Drawing.Point(343, 459)
        Me.btnCambio.Name = "btnCambio"
        Me.btnCambio.Size = New System.Drawing.Size(144, 23)
        Me.btnCambio.TabIndex = 17
        Me.btnCambio.Text = "Cambiar"
        Me.btnCambio.UseVisualStyleBackColor = True
        '
        'btnCoches
        '
        Me.btnCoches.Location = New System.Drawing.Point(92, 459)
        Me.btnCoches.Name = "btnCoches"
        Me.btnCoches.Size = New System.Drawing.Size(109, 23)
        Me.btnCoches.TabIndex = 16
        Me.btnCoches.Text = "Cargar coches.xml"
        Me.btnCoches.UseVisualStyleBackColor = True
        '
        'btnElim
        '
        Me.btnElim.Location = New System.Drawing.Point(493, 459)
        Me.btnElim.Name = "btnElim"
        Me.btnElim.Size = New System.Drawing.Size(144, 23)
        Me.btnElim.TabIndex = 22
        Me.btnElim.Text = "Eliminar "
        Me.btnElim.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 506)
        Me.Controls.Add(Me.btnElim)
        Me.Controls.Add(Me.rbtAbajo)
        Me.Controls.Add(Me.rbtArriba)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnCambio)
        Me.Controls.Add(Me.btnCoches)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbtAbajo As System.Windows.Forms.RadioButton
    Friend WithEvents rbtArriba As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnCambio As System.Windows.Forms.Button
    Friend WithEvents btnCoches As System.Windows.Forms.Button
    Friend WithEvents btnElim As System.Windows.Forms.Button

End Class
