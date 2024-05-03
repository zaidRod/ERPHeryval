<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1

    Inherits System.Windows.Forms.Form
    'Formulario principal


    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ModuloVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RentabilidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PresupuestosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearPresupuestoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarFacturasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearFacturaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModuloDeComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PresupuestosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarPresupuestosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearPresupuestoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarPedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearPedidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarFacturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearFacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModuloVentasToolStripMenuItem, Me.ModuloDeComprasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ModuloVentasToolStripMenuItem
        '
        Me.ModuloVentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarClienteToolStripMenuItem, Me.RentabilidadToolStripMenuItem, Me.PresupuestosToolStripMenuItem, Me.FacturasToolStripMenuItem})
        Me.ModuloVentasToolStripMenuItem.Name = "ModuloVentasToolStripMenuItem"
        Me.ModuloVentasToolStripMenuItem.Size = New System.Drawing.Size(122, 24)
        Me.ModuloVentasToolStripMenuItem.Text = "Modulo Ventas"
        '
        'RegistrarClienteToolStripMenuItem
        '
        Me.RegistrarClienteToolStripMenuItem.Name = "RegistrarClienteToolStripMenuItem"
        Me.RegistrarClienteToolStripMenuItem.Size = New System.Drawing.Size(199, 26)
        Me.RegistrarClienteToolStripMenuItem.Text = "Registrar cliente"
        '
        'RentabilidadToolStripMenuItem
        '
        Me.RentabilidadToolStripMenuItem.Name = "RentabilidadToolStripMenuItem"
        Me.RentabilidadToolStripMenuItem.Size = New System.Drawing.Size(199, 26)
        Me.RentabilidadToolStripMenuItem.Text = "Rentabilidad"
        '
        'PresupuestosToolStripMenuItem
        '
        Me.PresupuestosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearPresupuestoToolStripMenuItem1, Me.ConsuToolStripMenuItem})
        Me.PresupuestosToolStripMenuItem.Name = "PresupuestosToolStripMenuItem"
        Me.PresupuestosToolStripMenuItem.Size = New System.Drawing.Size(199, 26)
        Me.PresupuestosToolStripMenuItem.Text = "Presupuestos"
        '
        'CrearPresupuestoToolStripMenuItem1
        '
        Me.CrearPresupuestoToolStripMenuItem1.Name = "CrearPresupuestoToolStripMenuItem1"
        Me.CrearPresupuestoToolStripMenuItem1.Size = New System.Drawing.Size(239, 26)
        Me.CrearPresupuestoToolStripMenuItem1.Text = "Consultar presupuesto"
        '
        'ConsuToolStripMenuItem
        '
        Me.ConsuToolStripMenuItem.Name = "ConsuToolStripMenuItem"
        Me.ConsuToolStripMenuItem.Size = New System.Drawing.Size(239, 26)
        Me.ConsuToolStripMenuItem.Text = "Crear presupuesto"
        '
        'FacturasToolStripMenuItem
        '
        Me.FacturasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarFacturasToolStripMenuItem1, Me.CrearFacturaToolStripMenuItem1})
        Me.FacturasToolStripMenuItem.Name = "FacturasToolStripMenuItem"
        Me.FacturasToolStripMenuItem.Size = New System.Drawing.Size(199, 26)
        Me.FacturasToolStripMenuItem.Text = "Facturas"
        '
        'ConsultarFacturasToolStripMenuItem1
        '
        Me.ConsultarFacturasToolStripMenuItem1.Name = "ConsultarFacturasToolStripMenuItem1"
        Me.ConsultarFacturasToolStripMenuItem1.Size = New System.Drawing.Size(210, 26)
        Me.ConsultarFacturasToolStripMenuItem1.Text = "Consultar facturas"
        '
        'CrearFacturaToolStripMenuItem1
        '
        Me.CrearFacturaToolStripMenuItem1.Name = "CrearFacturaToolStripMenuItem1"
        Me.CrearFacturaToolStripMenuItem1.Size = New System.Drawing.Size(210, 26)
        Me.CrearFacturaToolStripMenuItem1.Text = "Crear factura"
        '
        'ModuloDeComprasToolStripMenuItem
        '
        Me.ModuloDeComprasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProveedoresToolStripMenuItem, Me.PresupuestosToolStripMenuItem1, Me.PedidosToolStripMenuItem, Me.FacturasToolStripMenuItem1})
        Me.ModuloDeComprasToolStripMenuItem.Name = "ModuloDeComprasToolStripMenuItem"
        Me.ModuloDeComprasToolStripMenuItem.Size = New System.Drawing.Size(159, 24)
        Me.ModuloDeComprasToolStripMenuItem.Text = "Modulo de Compras"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarProveedorToolStripMenuItem, Me.ListadoDeProveedoresToolStripMenuItem})
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(178, 26)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'AgregarProveedorToolStripMenuItem
        '
        Me.AgregarProveedorToolStripMenuItem.Name = "AgregarProveedorToolStripMenuItem"
        Me.AgregarProveedorToolStripMenuItem.Size = New System.Drawing.Size(248, 26)
        Me.AgregarProveedorToolStripMenuItem.Text = "Agregar proveedor"
        '
        'ListadoDeProveedoresToolStripMenuItem
        '
        Me.ListadoDeProveedoresToolStripMenuItem.Name = "ListadoDeProveedoresToolStripMenuItem"
        Me.ListadoDeProveedoresToolStripMenuItem.Size = New System.Drawing.Size(248, 26)
        Me.ListadoDeProveedoresToolStripMenuItem.Text = "Listado de proveedores"
        '
        'PresupuestosToolStripMenuItem1
        '
        Me.PresupuestosToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarPresupuestosToolStripMenuItem, Me.CrearPresupuestoToolStripMenuItem})
        Me.PresupuestosToolStripMenuItem1.Name = "PresupuestosToolStripMenuItem1"
        Me.PresupuestosToolStripMenuItem1.Size = New System.Drawing.Size(178, 26)
        Me.PresupuestosToolStripMenuItem1.Text = "Presupuestos"
        '
        'ConsultarPresupuestosToolStripMenuItem
        '
        Me.ConsultarPresupuestosToolStripMenuItem.Name = "ConsultarPresupuestosToolStripMenuItem"
        Me.ConsultarPresupuestosToolStripMenuItem.Size = New System.Drawing.Size(245, 26)
        Me.ConsultarPresupuestosToolStripMenuItem.Text = "Consultar presupuestos"
        '
        'CrearPresupuestoToolStripMenuItem
        '
        Me.CrearPresupuestoToolStripMenuItem.Name = "CrearPresupuestoToolStripMenuItem"
        Me.CrearPresupuestoToolStripMenuItem.Size = New System.Drawing.Size(245, 26)
        Me.CrearPresupuestoToolStripMenuItem.Text = "Crear presupuesto"
        '
        'PedidosToolStripMenuItem
        '
        Me.PedidosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarPedidosToolStripMenuItem, Me.CrearPedidoToolStripMenuItem})
        Me.PedidosToolStripMenuItem.Name = "PedidosToolStripMenuItem"
        Me.PedidosToolStripMenuItem.Size = New System.Drawing.Size(178, 26)
        Me.PedidosToolStripMenuItem.Text = "Pedidos"
        '
        'ConsultarPedidosToolStripMenuItem
        '
        Me.ConsultarPedidosToolStripMenuItem.Name = "ConsultarPedidosToolStripMenuItem"
        Me.ConsultarPedidosToolStripMenuItem.Size = New System.Drawing.Size(212, 26)
        Me.ConsultarPedidosToolStripMenuItem.Text = "Consultar pedidos"
        '
        'CrearPedidoToolStripMenuItem
        '
        Me.CrearPedidoToolStripMenuItem.Name = "CrearPedidoToolStripMenuItem"
        Me.CrearPedidoToolStripMenuItem.Size = New System.Drawing.Size(212, 26)
        Me.CrearPedidoToolStripMenuItem.Text = "Crear pedido"
        '
        'FacturasToolStripMenuItem1
        '
        Me.FacturasToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarFacturasToolStripMenuItem, Me.CrearFacturaToolStripMenuItem})
        Me.FacturasToolStripMenuItem1.Name = "FacturasToolStripMenuItem1"
        Me.FacturasToolStripMenuItem1.Size = New System.Drawing.Size(178, 26)
        Me.FacturasToolStripMenuItem1.Text = "Facturas"
        '
        'ConsultarFacturasToolStripMenuItem
        '
        Me.ConsultarFacturasToolStripMenuItem.Name = "ConsultarFacturasToolStripMenuItem"
        Me.ConsultarFacturasToolStripMenuItem.Size = New System.Drawing.Size(210, 26)
        Me.ConsultarFacturasToolStripMenuItem.Text = "Consultar facturas"
        '
        'CrearFacturaToolStripMenuItem
        '
        Me.CrearFacturaToolStripMenuItem.Name = "CrearFacturaToolStripMenuItem"
        Me.CrearFacturaToolStripMenuItem.Size = New System.Drawing.Size(210, 26)
        Me.CrearFacturaToolStripMenuItem.Text = "Crear factura"
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(10, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(778, 420)
        Me.Panel1.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Prototio Heryval"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ModuloVentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RentabilidadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PresupuestosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModuloDeComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PresupuestosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PedidosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AgregarProveedorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearPresupuestoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ConsuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoDeProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarPresupuestosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearPresupuestoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarPedidosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearPedidoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarFacturasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearFacturaToolStripMenuItem As ToolStripMenuItem

    Private Sub CrearPresupuestoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CrearPresupuestoToolStripMenuItem1.Click

    End Sub

    Friend WithEvents ConsultarFacturasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CrearFacturaToolStripMenuItem1 As ToolStripMenuItem

    Private Sub RegistrarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarClienteToolStripMenuItem.Click
        Dim formularioRegitro As New Form2

        ' Carga del formulario nuevo dentro del formulario principal
        formularioRegitro.TopLevel = False
        formularioRegitro.Dock = DockStyle.Fill
        formularioRegitro.FormBorderStyle = FormBorderStyle.None

        'Carga del formulario en el panel
        Panel1.Controls.Add(formularioRegitro)
        'Muestra el formulario
        formularioRegitro.Show()


    End Sub

    Friend WithEvents Panel1 As Panel

End Class
