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
        Me.btnElim = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnCambio = New System.Windows.Forms.Button()
        Me.btnBailes = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnElim
        '
        Me.btnElim.Location = New System.Drawing.Point(486, 464)
        Me.btnElim.Name = "btnElim"
        Me.btnElim.Size = New System.Drawing.Size(144, 23)
        Me.btnElim.TabIndex = 29
        Me.btnElim.Text = "Eliminar "
        Me.btnElim.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(336, 50)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(285, 394)
        Me.TextBox2.TabIndex = 26
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(45, 50)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(285, 394)
        Me.TextBox1.TabIndex = 25
        '
        'btnCambio
        '
        Me.btnCambio.Location = New System.Drawing.Point(336, 464)
        Me.btnCambio.Name = "btnCambio"
        Me.btnCambio.Size = New System.Drawing.Size(144, 23)
        Me.btnCambio.TabIndex = 24
        Me.btnCambio.Text = "Cambiar"
        Me.btnCambio.UseVisualStyleBackColor = True
        '
        'btnBailes
        '
        Me.btnBailes.Location = New System.Drawing.Point(85, 464)
        Me.btnBailes.Name = "btnBailes"
        Me.btnBailes.Size = New System.Drawing.Size(109, 23)
        Me.btnBailes.TabIndex = 23
        Me.btnBailes.Text = "Cargar bailes.xml"
        Me.btnBailes.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 511)
        Me.Controls.Add(Me.btnElim)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnCambio)
        Me.Controls.Add(Me.btnBailes)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnElim As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnCambio As System.Windows.Forms.Button
    Friend WithEvents btnBailes As System.Windows.Forms.Button

End Class
