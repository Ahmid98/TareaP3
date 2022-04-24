<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Me.CALCULARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MOSTRARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ACTUALIZARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ELIMINARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_consultaplaca = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tabla = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rb_tipo4 = New System.Windows.Forms.RadioButton()
        Me.rb_tipo3 = New System.Windows.Forms.RadioButton()
        Me.rb_tipo2 = New System.Windows.Forms.RadioButton()
        Me.rb_tipo1 = New System.Windows.Forms.RadioButton()
        Me.txt_kiloF = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_kiloI = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_placa = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.No_placa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_carro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kilo_inicial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kilo_final = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cobro_base = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pago_final = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.tabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Britannic Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CALCULARToolStripMenuItem, Me.MOSTRARToolStripMenuItem, Me.CONSULTARToolStripMenuItem, Me.ACTUALIZARToolStripMenuItem, Me.ELIMINARToolStripMenuItem, Me.LIMPIARToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1000, 36)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CALCULARToolStripMenuItem
        '
        Me.CALCULARToolStripMenuItem.Name = "CALCULARToolStripMenuItem"
        Me.CALCULARToolStripMenuItem.Size = New System.Drawing.Size(113, 29)
        Me.CALCULARToolStripMenuItem.Text = "CALCULAR"
        '
        'MOSTRARToolStripMenuItem
        '
        Me.MOSTRARToolStripMenuItem.Name = "MOSTRARToolStripMenuItem"
        Me.MOSTRARToolStripMenuItem.Size = New System.Drawing.Size(111, 29)
        Me.MOSTRARToolStripMenuItem.Text = "MOSTRAR"
        '
        'CONSULTARToolStripMenuItem
        '
        Me.CONSULTARToolStripMenuItem.Name = "CONSULTARToolStripMenuItem"
        Me.CONSULTARToolStripMenuItem.Size = New System.Drawing.Size(126, 29)
        Me.CONSULTARToolStripMenuItem.Text = "CONSULTAR"
        '
        'ACTUALIZARToolStripMenuItem
        '
        Me.ACTUALIZARToolStripMenuItem.Name = "ACTUALIZARToolStripMenuItem"
        Me.ACTUALIZARToolStripMenuItem.Size = New System.Drawing.Size(130, 29)
        Me.ACTUALIZARToolStripMenuItem.Text = "ACTUALIZAR"
        '
        'ELIMINARToolStripMenuItem
        '
        Me.ELIMINARToolStripMenuItem.Name = "ELIMINARToolStripMenuItem"
        Me.ELIMINARToolStripMenuItem.Size = New System.Drawing.Size(107, 29)
        Me.ELIMINARToolStripMenuItem.Text = "ELIMINAR"
        '
        'LIMPIARToolStripMenuItem
        '
        Me.LIMPIARToolStripMenuItem.Name = "LIMPIARToolStripMenuItem"
        Me.LIMPIARToolStripMenuItem.Size = New System.Drawing.Size(95, 29)
        Me.LIMPIARToolStripMenuItem.Text = "LIMPIAR"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(74, 29)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global._201800934_AUTOS.My.Resources.Resources.fondocarro
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.tabla)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txt_kiloF)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_kiloI)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_placa)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(976, 552)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INGRESO DE DATOS:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_consultaplaca)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(674, 26)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(279, 184)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "CONSULTAR POR NO. PLACA"
        '
        'txt_consultaplaca
        '
        Me.txt_consultaplaca.Location = New System.Drawing.Point(56, 85)
        Me.txt_consultaplaca.Name = "txt_consultaplaca"
        Me.txt_consultaplaca.Size = New System.Drawing.Size(158, 33)
        Me.txt_consultaplaca.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 21)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "No. placa:"
        '
        'tabla
        '
        Me.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.numero, Me.No_placa, Me.tipo_carro, Me.kilo_inicial, Me.kilo_final, Me.cobro_base, Me.pago_final})
        Me.tabla.Location = New System.Drawing.Point(5, 253)
        Me.tabla.Name = "tabla"
        Me.tabla.RowHeadersWidth = 62
        Me.tabla.RowTemplate.Height = 28
        Me.tabla.Size = New System.Drawing.Size(965, 278)
        Me.tabla.TabIndex = 8
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rb_tipo4)
        Me.GroupBox2.Controls.Add(Me.rb_tipo3)
        Me.GroupBox2.Controls.Add(Me.rb_tipo2)
        Me.GroupBox2.Controls.Add(Me.rb_tipo1)
        Me.GroupBox2.Location = New System.Drawing.Point(367, 26)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(279, 184)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo de carro:"
        '
        'rb_tipo4
        '
        Me.rb_tipo4.AutoSize = True
        Me.rb_tipo4.Location = New System.Drawing.Point(177, 115)
        Me.rb_tipo4.Name = "rb_tipo4"
        Me.rb_tipo4.Size = New System.Drawing.Size(85, 25)
        Me.rb_tipo4.TabIndex = 3
        Me.rb_tipo4.TabStop = True
        Me.rb_tipo4.Text = "Tipo 4"
        Me.rb_tipo4.UseVisualStyleBackColor = True
        '
        'rb_tipo3
        '
        Me.rb_tipo3.AutoSize = True
        Me.rb_tipo3.Location = New System.Drawing.Point(177, 41)
        Me.rb_tipo3.Name = "rb_tipo3"
        Me.rb_tipo3.Size = New System.Drawing.Size(85, 25)
        Me.rb_tipo3.TabIndex = 2
        Me.rb_tipo3.TabStop = True
        Me.rb_tipo3.Text = "Tipo 3"
        Me.rb_tipo3.UseVisualStyleBackColor = True
        '
        'rb_tipo2
        '
        Me.rb_tipo2.AutoSize = True
        Me.rb_tipo2.Location = New System.Drawing.Point(31, 115)
        Me.rb_tipo2.Name = "rb_tipo2"
        Me.rb_tipo2.Size = New System.Drawing.Size(85, 25)
        Me.rb_tipo2.TabIndex = 1
        Me.rb_tipo2.TabStop = True
        Me.rb_tipo2.Text = "Tipo 2"
        Me.rb_tipo2.UseVisualStyleBackColor = True
        '
        'rb_tipo1
        '
        Me.rb_tipo1.AutoSize = True
        Me.rb_tipo1.Location = New System.Drawing.Point(31, 41)
        Me.rb_tipo1.Name = "rb_tipo1"
        Me.rb_tipo1.Size = New System.Drawing.Size(80, 25)
        Me.rb_tipo1.TabIndex = 0
        Me.rb_tipo1.TabStop = True
        Me.rb_tipo1.Text = "Tipo 1"
        Me.rb_tipo1.UseVisualStyleBackColor = True
        '
        'txt_kiloF
        '
        Me.txt_kiloF.Location = New System.Drawing.Point(163, 170)
        Me.txt_kiloF.Name = "txt_kiloF"
        Me.txt_kiloF.Size = New System.Drawing.Size(158, 33)
        Me.txt_kiloF.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Kilometraje Final:"
        '
        'txt_kiloI
        '
        Me.txt_kiloI.Location = New System.Drawing.Point(163, 105)
        Me.txt_kiloI.Name = "txt_kiloI"
        Me.txt_kiloI.Size = New System.Drawing.Size(158, 33)
        Me.txt_kiloI.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Kilometraje Inicial:"
        '
        'txt_placa
        '
        Me.txt_placa.Location = New System.Drawing.Point(163, 45)
        Me.txt_placa.Name = "txt_placa"
        Me.txt_placa.Size = New System.Drawing.Size(158, 33)
        Me.txt_placa.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. placa:"
        '
        'numero
        '
        Me.numero.HeaderText = "No."
        Me.numero.MinimumWidth = 8
        Me.numero.Name = "numero"
        Me.numero.Width = 150
        '
        'No_placa
        '
        Me.No_placa.HeaderText = "No. placa"
        Me.No_placa.MinimumWidth = 8
        Me.No_placa.Name = "No_placa"
        Me.No_placa.Width = 150
        '
        'tipo_carro
        '
        Me.tipo_carro.HeaderText = "Tipo carro"
        Me.tipo_carro.MinimumWidth = 8
        Me.tipo_carro.Name = "tipo_carro"
        Me.tipo_carro.Width = 150
        '
        'kilo_inicial
        '
        Me.kilo_inicial.HeaderText = "Kilometraje I."
        Me.kilo_inicial.MinimumWidth = 8
        Me.kilo_inicial.Name = "kilo_inicial"
        Me.kilo_inicial.Width = 150
        '
        'kilo_final
        '
        Me.kilo_final.HeaderText = "Kilometraje F."
        Me.kilo_final.MinimumWidth = 8
        Me.kilo_final.Name = "kilo_final"
        Me.kilo_final.Width = 150
        '
        'cobro_base
        '
        Me.cobro_base.HeaderText = "Cobro base"
        Me.cobro_base.MinimumWidth = 8
        Me.cobro_base.Name = "cobro_base"
        Me.cobro_base.Width = 150
        '
        'pago_final
        '
        Me.pago_final.HeaderText = "Pago final"
        Me.pago_final.MinimumWidth = 8
        Me.pago_final.Name = "pago_final"
        Me.pago_final.Width = 150
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 603)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("MV Boli", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "SISTEMA"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.tabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CALCULARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MOSTRARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CONSULTARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ACTUALIZARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ELIMINARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rb_tipo4 As RadioButton
    Friend WithEvents rb_tipo3 As RadioButton
    Friend WithEvents rb_tipo2 As RadioButton
    Friend WithEvents rb_tipo1 As RadioButton
    Friend WithEvents txt_kiloF As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_kiloI As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_placa As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txt_consultaplaca As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tabla As DataGridView
    Friend WithEvents numero As DataGridViewTextBoxColumn
    Friend WithEvents No_placa As DataGridViewTextBoxColumn
    Friend WithEvents tipo_carro As DataGridViewTextBoxColumn
    Friend WithEvents kilo_inicial As DataGridViewTextBoxColumn
    Friend WithEvents kilo_final As DataGridViewTextBoxColumn
    Friend WithEvents cobro_base As DataGridViewTextBoxColumn
    Friend WithEvents pago_final As DataGridViewTextBoxColumn
End Class
