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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button_Limpiar = New System.Windows.Forms.Button()
        Me.Button_Calular = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox_Hipotenusa = New System.Windows.Forms.TextBox()
        Me.TextBox_Adyacente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label_AnguloA = New System.Windows.Forms.Label()
        Me.Label_AnguloB = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_Limpiar
        '
        Me.Button_Limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Limpiar.Location = New System.Drawing.Point(175, 343)
        Me.Button_Limpiar.Name = "Button_Limpiar"
        Me.Button_Limpiar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Limpiar.TabIndex = 0
        Me.Button_Limpiar.Text = "Limpiar"
        Me.Button_Limpiar.UseVisualStyleBackColor = True
        '
        'Button_Calular
        '
        Me.Button_Calular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Calular.Location = New System.Drawing.Point(32, 343)
        Me.Button_Calular.Name = "Button_Calular"
        Me.Button_Calular.Size = New System.Drawing.Size(75, 23)
        Me.Button_Calular.TabIndex = 1
        Me.Button_Calular.Text = "Calcular"
        Me.Button_Calular.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(266, 218)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'TextBox_Hipotenusa
        '
        Me.TextBox_Hipotenusa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Hipotenusa.Location = New System.Drawing.Point(23, 51)
        Me.TextBox_Hipotenusa.Name = "TextBox_Hipotenusa"
        Me.TextBox_Hipotenusa.Size = New System.Drawing.Size(62, 21)
        Me.TextBox_Hipotenusa.TabIndex = 3
        '
        'TextBox_Adyacente
        '
        Me.TextBox_Adyacente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Adyacente.Location = New System.Drawing.Point(123, 219)
        Me.TextBox_Adyacente.Name = "TextBox_Adyacente"
        Me.TextBox_Adyacente.Size = New System.Drawing.Size(62, 21)
        Me.TextBox_Adyacente.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "cm"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(191, 222)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "cm"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 264)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Angúlo A"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 295)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Angúlo B"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(172, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "90°"
        '
        'Label_AnguloA
        '
        Me.Label_AnguloA.AutoSize = True
        Me.Label_AnguloA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_AnguloA.Location = New System.Drawing.Point(120, 264)
        Me.Label_AnguloA.Name = "Label_AnguloA"
        Me.Label_AnguloA.Size = New System.Drawing.Size(16, 16)
        Me.Label_AnguloA.TabIndex = 10
        Me.Label_AnguloA.Text = "0"
        '
        'Label_AnguloB
        '
        Me.Label_AnguloB.AutoSize = True
        Me.Label_AnguloB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_AnguloB.Location = New System.Drawing.Point(120, 295)
        Me.Label_AnguloB.Name = "Label_AnguloB"
        Me.Label_AnguloB.Size = New System.Drawing.Size(16, 16)
        Me.Label_AnguloB.TabIndex = 11
        Me.Label_AnguloB.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(292, 386)
        Me.Controls.Add(Me.Label_AnguloB)
        Me.Controls.Add(Me.Label_AnguloA)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox_Adyacente)
        Me.Controls.Add(Me.TextBox_Hipotenusa)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button_Calular)
        Me.Controls.Add(Me.Button_Limpiar)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calcular angulo A del triangulo"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_Limpiar As System.Windows.Forms.Button
    Friend WithEvents Button_Calular As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox_Hipotenusa As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Adyacente As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label_AnguloA As System.Windows.Forms.Label
    Friend WithEvents Label_AnguloB As System.Windows.Forms.Label

End Class
