<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Corrector
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Corrector))
        Me.Btn_CERRAR = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_CERRAR
        '
        Me.Btn_CERRAR.Location = New System.Drawing.Point(29, 37)
        Me.Btn_CERRAR.Name = "Btn_CERRAR"
        Me.Btn_CERRAR.Size = New System.Drawing.Size(75, 23)
        Me.Btn_CERRAR.TabIndex = 0
        Me.Btn_CERRAR.Text = "CERRAR"
        Me.Btn_CERRAR.UseVisualStyleBackColor = True
        Me.Btn_CERRAR.UseWaitCursor = True
        '
        'Form_Corrector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1305, 615)
        Me.Controls.Add(Me.Btn_CERRAR)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_Corrector"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Corrector"
        Me.UseWaitCursor = True
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_CERRAR As Button
End Class
