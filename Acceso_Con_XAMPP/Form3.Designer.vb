<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Button2 = New Button()
        Button4 = New Button()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        Button1 = New Button()
        Label6 = New Label()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(247, 35)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(247, 93)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 27)
        TextBox2.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(169, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 20)
        Label1.TabIndex = 4
        Label1.Text = "Nombre"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(169, 100)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 20)
        Label2.TabIndex = 5
        Label2.Text = "Apellido"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(169, 156)
        Label3.Name = "Label3"
        Label3.Size = New Size(50, 20)
        Label3.TabIndex = 6
        Label3.Text = "Grado"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(566, 263)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 7
        Button2.Text = "limpiar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(535, 219)
        Button4.Name = "Button4"
        Button4.Size = New Size(152, 29)
        Button4.TabIndex = 9
        Button4.Text = "Update"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(247, 219)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(125, 27)
        TextBox4.TabIndex = 10
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(247, 265)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(125, 27)
        TextBox5.TabIndex = 11
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(174, 226)
        Label4.Name = "Label4"
        Label4.Size = New Size(43, 20)
        Label4.TabIndex = 12
        Label4.Text = "clave"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(169, 272)
        Label5.Name = "Label5"
        Label5.Size = New Size(59, 20)
        Label5.TabIndex = 13
        Label5.Text = "Usuario"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(652, 399)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 14
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(152, 324)
        Label6.Name = "Label6"
        Label6.Size = New Size(44, 20)
        Label6.TabIndex = 16
        Label6.Text = "Mesa"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Pre-Kinder1", "Pre-Kinder2", "Preparatoria", "Primero Primaria", "Segundo Primaria", "Tercero Primaria", "Cuarto Primaria B"})
        ComboBox1.Location = New Point(247, 156)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(125, 28)
        ComboBox1.TabIndex = 17
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"1", "2", "3", "4"})
        ComboBox2.Location = New Point(248, 320)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(151, 28)
        ComboBox2.TabIndex = 18
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Cyan
        ClientSize = New Size(800, 450)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(Label6)
        Controls.Add(Button1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(Button4)
        Controls.Add(Button2)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Name = "Form3"
        Text = "Actualizar datos"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
End Class
