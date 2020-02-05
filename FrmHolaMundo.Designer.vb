<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHolaMundo
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
        Me.bHolaMundo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bHolaMundo
        '
        Me.bHolaMundo.Location = New System.Drawing.Point(97, 62)
        Me.bHolaMundo.Name = "bHolaMundo"
        Me.bHolaMundo.Size = New System.Drawing.Size(277, 63)
        Me.bHolaMundo.TabIndex = 0
        Me.bHolaMundo.Text = "HAGA CLICK EN EL BOTON"
        Me.bHolaMundo.UseVisualStyleBackColor = True
        '
        'FrmHolaMundo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 196)
        Me.Controls.Add(Me.bHolaMundo)
        Me.Name = "FrmHolaMundo"
        Me.Text = "HOLA MUNDO"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bHolaMundo As System.Windows.Forms.Button

End Class
