<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConsultaCliente
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePickerSince = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerUntil = New System.Windows.Forms.DateTimePicker()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(74, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TIPO Y COMERCIAL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tipo de cliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Comercial"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Cliente información", "Cliente normal", "Cliente potencial", "Clientes tienda online", "Empresa", "Persona juridica", "Persona natural", "Proveedores", ""})
        Me.ComboBox1.Location = New System.Drawing.Point(161, 110)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(108, 24)
        Me.ComboBox1.TabIndex = 3
        Me.ComboBox1.Text = "Todos"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Sin comercial"})
        Me.ComboBox2.Location = New System.Drawing.Point(161, 158)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(108, 24)
        Me.ComboBox2.TabIndex = 4
        Me.ComboBox2.Text = "Todos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(393, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(251, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "SELECCIONA EL CAMPO DE BUSCAR"
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"Nombres y apellidos", "Nº Cliente", "Mail", "CIF / DNI", "Dirección", "Localidad", "Provincia", "Telefono ", "IBAN", "Observaciones ", "Referencia"})
        Me.ComboBox3.Location = New System.Drawing.Point(355, 109)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(135, 24)
        Me.ComboBox3.TabIndex = 6
        Me.ComboBox3.Text = "Selecciona"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(510, 111)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(263, 22)
        Me.TextBox1.TabIndex = 7
        Me.TextBox1.Text = "Al escribir aqui comienza la busqueda"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(868, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "FECHA ALTA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(818, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 17)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Desde"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(818, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 17)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Hasta"
        '
        'DateTimePickerSince
        '
        Me.DateTimePickerSince.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerSince.Location = New System.Drawing.Point(896, 94)
        Me.DateTimePickerSince.Name = "DateTimePickerSince"
        Me.DateTimePickerSince.Size = New System.Drawing.Size(97, 22)
        Me.DateTimePickerSince.TabIndex = 11
        '
        'DateTimePickerUntil
        '
        Me.DateTimePickerUntil.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerUntil.Location = New System.Drawing.Point(896, 144)
        Me.DateTimePickerUntil.Name = "DateTimePickerUntil"
        Me.DateTimePickerUntil.Size = New System.Drawing.Size(97, 22)
        Me.DateTimePickerUntil.TabIndex = 12
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(161, 438)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(91, 36)
        Me.ButtonCancel.TabIndex = 13
        Me.ButtonCancel.TabStop = False
        Me.ButtonCancel.Text = "Cancelar"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'FormConsultaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1032, 539)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.DateTimePickerUntil)
        Me.Controls.Add(Me.DateTimePickerSince)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormConsultaCliente"
        Me.Text = "FormConsultaCliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DateTimePickerSince As DateTimePicker
    Friend WithEvents DateTimePickerUntil As DateTimePicker
    Friend WithEvents ButtonCancel As Button
End Class
