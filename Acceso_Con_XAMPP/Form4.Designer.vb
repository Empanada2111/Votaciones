<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Label5 = New Label()
        Label4 = New Label()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(491, 199)
        Button3.Name = "Button3"
        Button3.Size = New Size(207, 29)
        Button3.TabIndex = 28
        Button3.Text = "create"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(548, 248)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 29
        Button2.Text = "limpiar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(671, 392)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 30
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(172, 292)
        Label5.Name = "Label5"
        Label5.Size = New Size(59, 20)
        Label5.TabIndex = 40
        Label5.Text = "Usuario"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(177, 246)
        Label4.Name = "Label4"
        Label4.Size = New Size(45, 20)
        Label4.TabIndex = 39
        Label4.Text = "Clave"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(250, 285)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(125, 27)
        TextBox5.TabIndex = 38
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(250, 239)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(125, 27)
        TextBox4.TabIndex = 37
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(172, 176)
        Label3.Name = "Label3"
        Label3.Size = New Size(50, 20)
        Label3.TabIndex = 36
        Label3.Text = "Grado"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(172, 120)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 20)
        Label2.TabIndex = 35
        Label2.Text = "Apellido"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(172, 62)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 20)
        Label1.TabIndex = 34
        Label1.Text = "Nombre"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(250, 113)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 27)
        TextBox2.TabIndex = 32
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(250, 55)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 31
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Pre-Kinder1", "Pre-Kinder2", "Kinder", "Preparatoria", "Primero Primaria", "Segundo Primaria", "Tercero Primaria ", "Cuarto Primaria B"})
        ComboBox1.Location = New Point(250, 176)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(125, 28)
        ComboBox1.TabIndex = 43
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"1", "2", "3", "4"})
        ComboBox2.Location = New Point(250, 338)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(151, 28)
        ComboBox2.TabIndex = 45
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(154, 342)
        Label6.Name = "Label6"
        Label6.Size = New Size(44, 20)
        Label6.TabIndex = 44
        Label6.Text = "Mesa"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Orange
        ClientSize = New Size(800, 450)
        Controls.Add(ComboBox2)
        Controls.Add(Label6)
        Controls.Add(ComboBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Controls.Add(Button2)
        Controls.Add(Button3)
        Name = "Form4"
        Text = "Registro"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label6 As Label
End Class
