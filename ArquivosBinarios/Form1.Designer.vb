<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtTexto = New System.Windows.Forms.TextBox()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnCarregar = New System.Windows.Forms.Button()
        Me.btnEscrever = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtTexto
        '
        Me.txtTexto.Location = New System.Drawing.Point(12, 12)
        Me.txtTexto.Multiline = True
        Me.txtTexto.Name = "txtTexto"
        Me.txtTexto.Size = New System.Drawing.Size(776, 380)
        Me.txtTexto.TabIndex = 0
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(252, 415)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(75, 23)
        Me.btnSalvar.TabIndex = 1
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnCarregar
        '
        Me.btnCarregar.Location = New System.Drawing.Point(504, 415)
        Me.btnCarregar.Name = "btnCarregar"
        Me.btnCarregar.Size = New System.Drawing.Size(77, 23)
        Me.btnCarregar.TabIndex = 2
        Me.btnCarregar.Text = "Carregar"
        Me.btnCarregar.UseVisualStyleBackColor = True
        '
        'btnEscrever
        '
        Me.btnEscrever.Location = New System.Drawing.Point(83, 415)
        Me.btnEscrever.Name = "btnEscrever"
        Me.btnEscrever.Size = New System.Drawing.Size(75, 23)
        Me.btnEscrever.TabIndex = 3
        Me.btnEscrever.Text = "Escrever"
        Me.btnEscrever.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnEscrever)
        Me.Controls.Add(Me.btnCarregar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.txtTexto)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTexto As TextBox
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnCarregar As Button
    Friend WithEvents btnEscrever As Button
End Class
