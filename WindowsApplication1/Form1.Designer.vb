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
        Me.CheckWebM = New System.Windows.Forms.CheckBox()
        Me.CheckFLV = New System.Windows.Forms.CheckBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CheckWebM
        '
        Me.CheckWebM.AutoSize = True
        Me.CheckWebM.Checked = True
        Me.CheckWebM.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckWebM.Location = New System.Drawing.Point(400, 3)
        Me.CheckWebM.Name = "CheckWebM"
        Me.CheckWebM.Size = New System.Drawing.Size(126, 17)
        Me.CheckWebM.TabIndex = 2
        Me.CheckWebM.Text = "WebM (Transcoding)"
        Me.CheckWebM.UseVisualStyleBackColor = True
        '
        'CheckFLV
        '
        Me.CheckFLV.AutoSize = True
        Me.CheckFLV.Checked = True
        Me.CheckFLV.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckFLV.Location = New System.Drawing.Point(400, 26)
        Me.CheckFLV.Name = "CheckFLV"
        Me.CheckFLV.Size = New System.Drawing.Size(126, 17)
        Me.CheckFLV.TabIndex = 3
        Me.CheckFLV.Text = "FLV (No transcoding)"
        Me.CheckFLV.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(1, 3)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(393, 124)
        Me.ListBox1.TabIndex = 5
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Multiselect = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(400, 49)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(125, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Seleccionar ficheros"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(12, 133)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(382, 39)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "CONVERTIR"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(400, 78)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Borrar lista"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 178)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.CheckFLV)
        Me.Controls.Add(Me.CheckWebM)
        Me.Name = "Form1"
        Me.Text = "FFMPEG MP4 TO WebM/FLV Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckWebM As System.Windows.Forms.CheckBox
    Friend WithEvents CheckFLV As System.Windows.Forms.CheckBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
