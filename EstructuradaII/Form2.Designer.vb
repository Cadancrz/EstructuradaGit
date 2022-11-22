<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GbRegistro = New System.Windows.Forms.GroupBox()
        Me.ChkRegistro = New System.Windows.Forms.CheckBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Lbxregistros = New System.Windows.Forms.ListBox()
        Me.Lblretorno = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GbRegistro.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(72, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1047, 73)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "BIENVENIDO AL FORMULARIO 2"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1128, 504)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 78)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Ir a Form1"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(726, 562)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(393, 20)
        Me.TextBox1.TabIndex = 9
        '
        'GbRegistro
        '
        Me.GbRegistro.Controls.Add(Me.ChkRegistro)
        Me.GbRegistro.Controls.Add(Me.BtnGuardar)
        Me.GbRegistro.Controls.Add(Me.Label2)
        Me.GbRegistro.Controls.Add(Me.TxtNombre)
        Me.GbRegistro.Location = New System.Drawing.Point(12, 125)
        Me.GbRegistro.Name = "GbRegistro"
        Me.GbRegistro.Size = New System.Drawing.Size(362, 199)
        Me.GbRegistro.TabIndex = 10
        Me.GbRegistro.TabStop = False
        '
        'ChkRegistro
        '
        Me.ChkRegistro.AutoSize = True
        Me.ChkRegistro.Location = New System.Drawing.Point(120, 41)
        Me.ChkRegistro.Name = "ChkRegistro"
        Me.ChkRegistro.Size = New System.Drawing.Size(68, 17)
        Me.ChkRegistro.TabIndex = 3
        Me.ChkRegistro.Text = "Registrar"
        Me.ChkRegistro.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(113, 127)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BtnGuardar.TabIndex = 2
        Me.BtnGuardar.Text = "Registrar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tabla del:"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(163, 84)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(100, 20)
        Me.TxtNombre.TabIndex = 0
        '
        'Lbxregistros
        '
        Me.Lbxregistros.FormattingEnabled = True
        Me.Lbxregistros.Location = New System.Drawing.Point(380, 125)
        Me.Lbxregistros.Name = "Lbxregistros"
        Me.Lbxregistros.Size = New System.Drawing.Size(701, 420)
        Me.Lbxregistros.TabIndex = 11
        '
        'Lblretorno
        '
        Me.Lblretorno.AutoSize = True
        Me.Lblretorno.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblretorno.Location = New System.Drawing.Point(126, 410)
        Me.Lblretorno.Name = "Lblretorno"
        Me.Lblretorno.Size = New System.Drawing.Size(0, 31)
        Me.Lblretorno.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(668, 565)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Recibido:"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1215, 594)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Lblretorno)
        Me.Controls.Add(Me.Lbxregistros)
        Me.Controls.Add(Me.GbRegistro)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.GbRegistro.ResumeLayout(False)
        Me.GbRegistro.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GbRegistro As GroupBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Lbxregistros As ListBox
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ChkRegistro As CheckBox
    Friend WithEvents Lblretorno As Label
    Friend WithEvents Label3 As Label
End Class
