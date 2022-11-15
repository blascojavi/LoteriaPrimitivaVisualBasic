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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.salir = New System.Windows.Forms.Button()
        Me.generarAleatorios = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.reintegro = New System.Windows.Forms.TextBox()
        Me.numero6 = New System.Windows.Forms.TextBox()
        Me.numero5 = New System.Windows.Forms.TextBox()
        Me.numero4 = New System.Windows.Forms.TextBox()
        Me.numero3 = New System.Windows.Forms.TextBox()
        Me.numero2 = New System.Windows.Forms.TextBox()
        Me.numero1 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.borrarSeleccion = New System.Windows.Forms.Button()
        Me.botonAutomatico = New System.Windows.Forms.Button()
        Me.botonManual = New System.Windows.Forms.Button()
        Me.reintegro2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.checkboxPanel = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.salir)
        Me.Panel1.Controls.Add(Me.generarAleatorios)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.reintegro)
        Me.Panel1.Controls.Add(Me.numero6)
        Me.Panel1.Controls.Add(Me.numero5)
        Me.Panel1.Controls.Add(Me.numero4)
        Me.Panel1.Controls.Add(Me.numero3)
        Me.Panel1.Controls.Add(Me.numero2)
        Me.Panel1.Controls.Add(Me.numero1)
        Me.Panel1.Location = New System.Drawing.Point(13, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(544, 141)
        Me.Panel1.TabIndex = 0
        '
        'salir
        '
        Me.salir.Location = New System.Drawing.Point(387, 100)
        Me.salir.Name = "salir"
        Me.salir.Size = New System.Drawing.Size(75, 23)
        Me.salir.TabIndex = 10
        Me.salir.Text = "Borrar"
        Me.salir.UseVisualStyleBackColor = True
        '
        'generarAleatorios
        '
        Me.generarAleatorios.Location = New System.Drawing.Point(49, 100)
        Me.generarAleatorios.Name = "generarAleatorios"
        Me.generarAleatorios.Size = New System.Drawing.Size(75, 23)
        Me.generarAleatorios.TabIndex = 9
        Me.generarAleatorios.Text = "Generar"
        Me.generarAleatorios.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(197, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Combinacion Ganadora"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(451, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Reintegro"
        '
        'reintegro
        '
        Me.reintegro.Enabled = False
        Me.reintegro.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reintegro.Location = New System.Drawing.Point(451, 38)
        Me.reintegro.Name = "reintegro"
        Me.reintegro.Size = New System.Drawing.Size(37, 38)
        Me.reintegro.TabIndex = 6
        '
        'numero6
        '
        Me.numero6.Enabled = False
        Me.numero6.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numero6.Location = New System.Drawing.Point(338, 38)
        Me.numero6.Name = "numero6"
        Me.numero6.Size = New System.Drawing.Size(37, 38)
        Me.numero6.TabIndex = 5
        '
        'numero5
        '
        Me.numero5.Enabled = False
        Me.numero5.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numero5.Location = New System.Drawing.Point(278, 38)
        Me.numero5.Name = "numero5"
        Me.numero5.Size = New System.Drawing.Size(37, 38)
        Me.numero5.TabIndex = 4
        '
        'numero4
        '
        Me.numero4.Enabled = False
        Me.numero4.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numero4.Location = New System.Drawing.Point(226, 38)
        Me.numero4.Name = "numero4"
        Me.numero4.Size = New System.Drawing.Size(37, 38)
        Me.numero4.TabIndex = 3
        '
        'numero3
        '
        Me.numero3.Enabled = False
        Me.numero3.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numero3.Location = New System.Drawing.Point(170, 38)
        Me.numero3.Name = "numero3"
        Me.numero3.Size = New System.Drawing.Size(37, 38)
        Me.numero3.TabIndex = 2
        '
        'numero2
        '
        Me.numero2.Enabled = False
        Me.numero2.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numero2.Location = New System.Drawing.Point(106, 38)
        Me.numero2.Name = "numero2"
        Me.numero2.Size = New System.Drawing.Size(37, 38)
        Me.numero2.TabIndex = 1
        '
        'numero1
        '
        Me.numero1.Enabled = False
        Me.numero1.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numero1.Location = New System.Drawing.Point(49, 38)
        Me.numero1.Name = "numero1"
        Me.numero1.Size = New System.Drawing.Size(37, 38)
        Me.numero1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.borrarSeleccion)
        Me.Panel2.Controls.Add(Me.botonAutomatico)
        Me.Panel2.Controls.Add(Me.botonManual)
        Me.Panel2.Controls.Add(Me.reintegro2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.checkboxPanel)
        Me.Panel2.Location = New System.Drawing.Point(13, 160)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(544, 426)
        Me.Panel2.TabIndex = 2
        '
        'borrarSeleccion
        '
        Me.borrarSeleccion.Location = New System.Drawing.Point(429, 385)
        Me.borrarSeleccion.Name = "borrarSeleccion"
        Me.borrarSeleccion.Size = New System.Drawing.Size(75, 23)
        Me.borrarSeleccion.TabIndex = 13
        Me.borrarSeleccion.Text = "Borrar"
        Me.borrarSeleccion.UseVisualStyleBackColor = True
        '
        'botonAutomatico
        '
        Me.botonAutomatico.Location = New System.Drawing.Point(226, 385)
        Me.botonAutomatico.Name = "botonAutomatico"
        Me.botonAutomatico.Size = New System.Drawing.Size(75, 23)
        Me.botonAutomatico.TabIndex = 12
        Me.botonAutomatico.Text = "Automatica"
        Me.botonAutomatico.UseVisualStyleBackColor = True
        '
        'botonManual
        '
        Me.botonManual.Location = New System.Drawing.Point(23, 385)
        Me.botonManual.Name = "botonManual"
        Me.botonManual.Size = New System.Drawing.Size(75, 23)
        Me.botonManual.TabIndex = 11
        Me.botonManual.Text = "Manual"
        Me.botonManual.UseVisualStyleBackColor = True
        '
        'reintegro2
        '
        Me.reintegro2.Enabled = False
        Me.reintegro2.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.reintegro2.Location = New System.Drawing.Point(244, 347)
        Me.reintegro2.Name = "reintegro2"
        Me.reintegro2.Size = New System.Drawing.Size(100, 21)
        Me.reintegro2.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(168, 351)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Reintegro"
        '
        'checkboxPanel
        '
        Me.checkboxPanel.Location = New System.Drawing.Point(3, 3)
        Me.checkboxPanel.Name = "checkboxPanel"
        Me.checkboxPanel.Size = New System.Drawing.Size(538, 327)
        Me.checkboxPanel.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 598)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "PrimitiveLotteryJBA"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents numero1 As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents checkboxPanel As Panel
    Friend WithEvents salir As Button
    Friend WithEvents generarAleatorios As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents reintegro As TextBox
    Friend WithEvents numero6 As TextBox
    Friend WithEvents numero5 As TextBox
    Friend WithEvents numero4 As TextBox
    Friend WithEvents numero3 As TextBox
    Friend WithEvents numero2 As TextBox
    Friend WithEvents borrarSeleccion As Button
    Friend WithEvents botonAutomatico As Button
    Friend WithEvents botonManual As Button
    Friend WithEvents reintegro2 As TextBox
    Friend WithEvents Label3 As Label
End Class
