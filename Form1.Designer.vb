<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnPao = New System.Windows.Forms.Button()
        Me.btnCafe = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnCroquetes = New System.Windows.Forms.Button()
        Me.btnEmpadas = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnTarte = New System.Windows.Forms.Button()
        Me.btnDoces = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.btnAquas = New System.Windows.Forms.Button()
        Me.btnSumos = New System.Windows.Forms.Button()
        Me.dgvProdutos = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(524, 485)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnPao)
        Me.TabPage1.Controls.Add(Me.btnCafe)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(516, 456)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Café"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnPao
        '
        Me.btnPao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPao.Image = Global.Cafe.My.Resources.Resources.imagesPao
        Me.btnPao.Location = New System.Drawing.Point(25, 170)
        Me.btnPao.Name = "btnPao"
        Me.btnPao.Size = New System.Drawing.Size(140, 136)
        Me.btnPao.TabIndex = 1
        Me.btnPao.Text = "Pão"
        Me.btnPao.UseVisualStyleBackColor = True
        '
        'btnCafe
        '
        Me.btnCafe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCafe.Image = Global.Cafe.My.Resources.Resources.images
        Me.btnCafe.Location = New System.Drawing.Point(25, 18)
        Me.btnCafe.Name = "btnCafe"
        Me.btnCafe.Size = New System.Drawing.Size(140, 136)
        Me.btnCafe.TabIndex = 0
        Me.btnCafe.Text = "Café"
        Me.btnCafe.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnCroquetes)
        Me.TabPage2.Controls.Add(Me.btnEmpadas)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(516, 456)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Salgados"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnCroquetes
        '
        Me.btnCroquetes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCroquetes.Image = Global.Cafe.My.Resources.Resources.descarregarcroq
        Me.btnCroquetes.Location = New System.Drawing.Point(47, 23)
        Me.btnCroquetes.Name = "btnCroquetes"
        Me.btnCroquetes.Size = New System.Drawing.Size(145, 136)
        Me.btnCroquetes.TabIndex = 2
        Me.btnCroquetes.Text = "Croquetes"
        Me.btnCroquetes.UseVisualStyleBackColor = True
        '
        'btnEmpadas
        '
        Me.btnEmpadas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpadas.Image = Global.Cafe.My.Resources.Resources.imagesemp
        Me.btnEmpadas.Location = New System.Drawing.Point(47, 188)
        Me.btnEmpadas.Name = "btnEmpadas"
        Me.btnEmpadas.Size = New System.Drawing.Size(145, 136)
        Me.btnEmpadas.TabIndex = 1
        Me.btnEmpadas.Text = "Empadas"
        Me.btnEmpadas.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btnTarte)
        Me.TabPage3.Controls.Add(Me.btnDoces)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(516, 456)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Doces"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnTarte
        '
        Me.btnTarte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTarte.Image = Global.Cafe.My.Resources.Resources.descarregartarte
        Me.btnTarte.Location = New System.Drawing.Point(42, 191)
        Me.btnTarte.Name = "btnTarte"
        Me.btnTarte.Size = New System.Drawing.Size(139, 136)
        Me.btnTarte.TabIndex = 2
        Me.btnTarte.Text = "Tarte"
        Me.btnTarte.UseVisualStyleBackColor = True
        '
        'btnDoces
        '
        Me.btnDoces.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDoces.Image = Global.Cafe.My.Resources.Resources.descarregarbolo
        Me.btnDoces.Location = New System.Drawing.Point(42, 24)
        Me.btnDoces.Name = "btnDoces"
        Me.btnDoces.Size = New System.Drawing.Size(139, 136)
        Me.btnDoces.TabIndex = 1
        Me.btnDoces.Text = "Bolo"
        Me.btnDoces.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.btnAquas)
        Me.TabPage4.Controls.Add(Me.btnSumos)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(516, 456)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Bebidas"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'btnAquas
        '
        Me.btnAquas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAquas.Image = Global.Cafe.My.Resources.Resources.descarregar
        Me.btnAquas.Location = New System.Drawing.Point(47, 17)
        Me.btnAquas.Name = "btnAquas"
        Me.btnAquas.Size = New System.Drawing.Size(133, 136)
        Me.btnAquas.TabIndex = 2
        Me.btnAquas.Text = "Áquas"
        Me.btnAquas.UseVisualStyleBackColor = True
        '
        'btnSumos
        '
        Me.btnSumos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSumos.Image = Global.Cafe.My.Resources.Resources.descarregarsumo
        Me.btnSumos.Location = New System.Drawing.Point(47, 180)
        Me.btnSumos.Name = "btnSumos"
        Me.btnSumos.Size = New System.Drawing.Size(133, 136)
        Me.btnSumos.TabIndex = 1
        Me.btnSumos.Text = "Sumos"
        Me.btnSumos.UseVisualStyleBackColor = True
        '
        'dgvProdutos
        '
        Me.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProdutos.Location = New System.Drawing.Point(576, 34)
        Me.dgvProdutos.Name = "dgvProdutos"
        Me.dgvProdutos.RowHeadersWidth = 51
        Me.dgvProdutos.RowTemplate.Height = 24
        Me.dgvProdutos.Size = New System.Drawing.Size(265, 459)
        Me.dgvProdutos.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(618, 502)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Total:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(665, 499)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(153, 22)
        Me.TextBox1.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(665, 527)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 42)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Pagamento"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 581)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvProdutos)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Cafe Pão Quente"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents btnPao As Button
    Friend WithEvents btnCafe As Button
    Friend WithEvents btnCroquetes As Button
    Friend WithEvents btnEmpadas As Button
    Friend WithEvents btnTarte As Button
    Friend WithEvents btnDoces As Button
    Friend WithEvents btnAquas As Button
    Friend WithEvents btnSumos As Button
    Friend WithEvents dgvProdutos As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
End Class
