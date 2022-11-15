<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Resultados
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.panelresultado = New System.Windows.Forms.Panel()
        Me.panelresultadoganador = New System.Windows.Forms.Panel()
        Me.labeldevolucion = New System.Windows.Forms.Label()
        Me.labelAciertos = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(246, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mi combinacion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(224, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Combinacion Ganadora"
        '
        'panelresultado
        '
        Me.panelresultado.Location = New System.Drawing.Point(34, 48)
        Me.panelresultado.Name = "panelresultado"
        Me.panelresultado.Size = New System.Drawing.Size(462, 64)
        Me.panelresultado.TabIndex = 2
        '
        'panelresultadoganador
        '
        Me.panelresultadoganador.Location = New System.Drawing.Point(34, 161)
        Me.panelresultadoganador.Name = "panelresultadoganador"
        Me.panelresultadoganador.Size = New System.Drawing.Size(462, 63)
        Me.panelresultadoganador.TabIndex = 3
        '
        'labeldevolucion
        '
        Me.labeldevolucion.AutoSize = True
        Me.labeldevolucion.Location = New System.Drawing.Point(208, 266)
        Me.labeldevolucion.Name = "labeldevolucion"
        Me.labeldevolucion.Size = New System.Drawing.Size(0, 13)
        Me.labeldevolucion.TabIndex = 5
        '
        'labelAciertos
        '
        Me.labelAciertos.AutoSize = True
        Me.labelAciertos.Location = New System.Drawing.Point(41, 266)
        Me.labelAciertos.Name = "labelAciertos"
        Me.labelAciertos.Size = New System.Drawing.Size(0, 13)
        Me.labelAciertos.TabIndex = 6
        '
        'Resultados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 348)
        Me.Controls.Add(Me.labelAciertos)
        Me.Controls.Add(Me.labeldevolucion)
        Me.Controls.Add(Me.panelresultadoganador)
        Me.Controls.Add(Me.panelresultado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Resultados"
        Me.Text = "Resultados"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents panelresultado As Panel
    Friend WithEvents panelresultadoganador As Panel
    Friend WithEvents labeldevolucion As Label
    Friend WithEvents labelAciertos As Label
End Class
