<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImageShow
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
        Me.PictureBoxImageShow = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBoxImageShow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxImageShow
        '
        Me.PictureBoxImageShow.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBoxImageShow.Location = New System.Drawing.Point(0, 0)
        Me.PictureBoxImageShow.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBoxImageShow.Name = "PictureBoxImageShow"
        Me.PictureBoxImageShow.Size = New System.Drawing.Size(786, 436)
        Me.PictureBoxImageShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxImageShow.TabIndex = 0
        Me.PictureBoxImageShow.TabStop = False
        '
        'ImageShow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBoxImageShow)
        Me.Name = "ImageShow"
        Me.Text = "ImageShow"
        CType(Me.PictureBoxImageShow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBoxImageShow As PictureBox
End Class
