<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        ComboBox1 = New ComboBox()
        Label3 = New Label()
        ComboBox2 = New ComboBox()
        Label4 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(429, 118)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(120, 106)
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(345, 393)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 8
        Button1.Text = "enviar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(51, 97)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 9
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(345, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(131, 20)
        Label1.TabIndex = 10
        Label1.Text = "ELIJA UN PARTIDO"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(27, 74)
        Label2.Name = "Label2"
        Label2.Size = New Size(171, 20)
        Label2.TabIndex = 11
        Label2.Text = "Código único estudiantil"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Location = New Point(429, 261)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(120, 106)
        PictureBox2.TabIndex = 12
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Location = New Point(594, 261)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(120, 106)
        PictureBox3.TabIndex = 13
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Location = New Point(594, 118)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(120, 106)
        PictureBox4.TabIndex = 14
        PictureBox4.TabStop = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Partido1", "Partido2", "Partido3", "Partido4"})
        ComboBox1.Location = New Point(45, 181)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 28)
        ComboBox1.TabIndex = 15
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(43, 158)
        Label3.Name = "Label3"
        Label3.Size = New Size(153, 20)
        Label3.TabIndex = 16
        Label3.Text = "Seleccione un partido"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"1", "2", "3", "4"})
        ComboBox2.Location = New Point(51, 283)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(151, 28)
        ComboBox2.TabIndex = 17
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(82, 231)
        Label4.Name = "Label4"
        Label4.Size = New Size(92, 20)
        Label4.TabIndex = 18
        Label4.Text = "No. de mesa"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SpringGreen
        ClientSize = New Size(800, 450)
        Controls.Add(Label4)
        Controls.Add(ComboBox2)
        Controls.Add(Label3)
        Controls.Add(ComboBox1)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Controls.Add(PictureBox1)
        Name = "Form2"
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label4 As Label
End Class
