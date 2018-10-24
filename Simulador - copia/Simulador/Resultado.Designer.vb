<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RESULTADO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RESULTADO))
        Me.RelacionFlujos = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Presion = New System.Windows.Forms.TextBox()
        Me.Temperatura = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PresionDiseño = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Contaminante = New System.Windows.Forms.ComboBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.udiam = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Compl2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Compg1 = New System.Windows.Forms.TextBox()
        Me.ul1 = New System.Windows.Forms.Label()
        Me.ul2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Flujol2 = New System.Windows.Forms.TextBox()
        Me.ug2 = New System.Windows.Forms.Label()
        Me.ug1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Flujog2 = New System.Windows.Forms.TextBox()
        Me.Flujog1 = New System.Windows.Forms.TextBox()
        Me.Compg2 = New System.Windows.Forms.TextBox()
        Me.Flujol1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DiametroC = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RelacionFlujos
        '
        Me.RelacionFlujos.Location = New System.Drawing.Point(220, 341)
        Me.RelacionFlujos.Name = "RelacionFlujos"
        Me.RelacionFlujos.Size = New System.Drawing.Size(132, 26)
        Me.RelacionFlujos.TabIndex = 74
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(160, 341)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(47, 20)
        Me.Label15.TabIndex = 73
        Me.Label15.Text = "Gx/Gy"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Presion)
        Me.GroupBox1.Controls.Add(Me.Temperatura)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Location = New System.Drawing.Point(404, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(237, 100)
        Me.GroupBox1.TabIndex = 72
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Condiciones  de operación"
        '
        'Presion
        '
        Me.Presion.Location = New System.Drawing.Point(90, 57)
        Me.Presion.Name = "Presion"
        Me.Presion.Size = New System.Drawing.Size(71, 26)
        Me.Presion.TabIndex = 1
        '
        'Temperatura
        '
        Me.Temperatura.Location = New System.Drawing.Point(90, 25)
        Me.Temperatura.Name = "Temperatura"
        Me.Temperatura.Size = New System.Drawing.Size(71, 26)
        Me.Temperatura.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(177, 20)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Temperatura                    °F"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(18, 60)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(176, 20)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Presión                        psia"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(787, 390)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 20)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "in H2O/ft "
        '
        'PresionDiseño
        '
        Me.PresionDiseño.Location = New System.Drawing.Point(649, 384)
        Me.PresionDiseño.Name = "PresionDiseño"
        Me.PresionDiseño.Size = New System.Drawing.Size(132, 26)
        Me.PresionDiseño.TabIndex = 70
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(659, 321)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 60)
        Me.Label8.TabIndex = 69
        Me.Label8.Text = "Caida de presión" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de diseño" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(0.05-1.5)"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(168, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(146, 40)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "Seleccione el sistema " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de unidades"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Items.AddRange(New Object() {"Métrico", "Inglés"})
        Me.ListBox1.Location = New System.Drawing.Point(214, 90)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(55, 44)
        Me.ListBox1.TabIndex = 67
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(686, 45)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(174, 20)
        Me.Label14.TabIndex = 66
        Me.Label14.Text = "Seleccione el contaminante"
        '
        'Contaminante
        '
        Me.Contaminante.FormattingEnabled = True
        Me.Contaminante.Items.AddRange(New Object() {"SO2", "NH3", "CO2", "CO", "NOx"})
        Me.Contaminante.Location = New System.Drawing.Point(693, 70)
        Me.Contaminante.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Contaminante.Name = "Contaminante"
        Me.Contaminante.Size = New System.Drawing.Size(160, 28)
        Me.Contaminante.TabIndex = 65
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(883, 10)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(135, 160)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 64
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.Simulador.My.Resources.Resources._1200px_Escudo_UNAM_escalable_svg
        Me.PictureBox2.Location = New System.Drawing.Point(13, 14)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(135, 150)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 63
        Me.PictureBox2.TabStop = False
        '
        'udiam
        '
        Me.udiam.AutoSize = True
        Me.udiam.Location = New System.Drawing.Point(779, 288)
        Me.udiam.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.udiam.Name = "udiam"
        Me.udiam.Size = New System.Drawing.Size(20, 20)
        Me.udiam.TabIndex = 62
        Me.udiam.Text = "m"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(645, 248)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(154, 40)
        Me.Label12.TabIndex = 60
        Me.Label12.Text = "El diametro de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "la columna requerido es"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(338, 589)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 40)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Composición del " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "contaminante"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Compl2
        '
        Me.Compl2.Location = New System.Drawing.Point(462, 589)
        Me.Compl2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Compl2.Name = "Compl2"
        Me.Compl2.Size = New System.Drawing.Size(132, 26)
        Me.Compl2.TabIndex = 58
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(338, 178)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 40)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Composición del " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "contaminante"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(96, 451)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 40)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Composición del " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "contaminante"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Compg1
        '
        Me.Compg1.Location = New System.Drawing.Point(220, 458)
        Me.Compg1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Compg1.Name = "Compg1"
        Me.Compg1.Size = New System.Drawing.Size(132, 26)
        Me.Compg1.TabIndex = 55
        '
        'ul1
        '
        Me.ul1.AutoSize = True
        Me.ul1.Location = New System.Drawing.Point(360, 278)
        Me.ul1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ul1.Name = "ul1"
        Me.ul1.Size = New System.Drawing.Size(38, 20)
        Me.ul1.TabIndex = 54
        Me.ul1.Text = "m3/h"
        '
        'ul2
        '
        Me.ul2.AutoSize = True
        Me.ul2.Location = New System.Drawing.Point(603, 545)
        Me.ul2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ul2.Name = "ul2"
        Me.ul2.Size = New System.Drawing.Size(38, 20)
        Me.ul2.TabIndex = 53
        Me.ul2.Text = "m3/h"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(338, 538)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 40)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Salida de liquido " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "contaminado"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Flujol2
        '
        Me.Flujol2.Location = New System.Drawing.Point(462, 542)
        Me.Flujol2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Flujol2.Name = "Flujol2"
        Me.Flujol2.Size = New System.Drawing.Size(132, 26)
        Me.Flujol2.TabIndex = 51
        '
        'ug2
        '
        Me.ug2.AutoSize = True
        Me.ug2.Location = New System.Drawing.Point(603, 138)
        Me.ug2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ug2.Name = "ug2"
        Me.ug2.Size = New System.Drawing.Size(38, 20)
        Me.ug2.TabIndex = 50
        Me.ug2.Text = "m3/h"
        '
        'ug1
        '
        Me.ug1.AutoSize = True
        Me.ug1.Location = New System.Drawing.Point(360, 412)
        Me.ug1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ug1.Name = "ug1"
        Me.ug1.Size = New System.Drawing.Size(38, 20)
        Me.ug1.TabIndex = 49
        Me.ug1.Text = "m3/h"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(351, 129)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 40)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Flujo de salida " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de gas limpio"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(96, 402)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 40)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Flujo entrada de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "gas contaminado" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(100, 268)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 40)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "Flujo de entrada " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de liquido limpio"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Flujog2
        '
        Me.Flujog2.Location = New System.Drawing.Point(462, 133)
        Me.Flujog2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Flujog2.Name = "Flujog2"
        Me.Flujog2.Size = New System.Drawing.Size(132, 26)
        Me.Flujog2.TabIndex = 45
        '
        'Flujog1
        '
        Me.Flujog1.Location = New System.Drawing.Point(220, 409)
        Me.Flujog1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Flujog1.Name = "Flujog1"
        Me.Flujog1.Size = New System.Drawing.Size(132, 26)
        Me.Flujog1.TabIndex = 44
        '
        'Compg2
        '
        Me.Compg2.Location = New System.Drawing.Point(462, 182)
        Me.Compg2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Compg2.Name = "Compg2"
        Me.Compg2.Size = New System.Drawing.Size(132, 26)
        Me.Compg2.TabIndex = 43
        '
        'Flujol1
        '
        Me.Flujol1.Location = New System.Drawing.Point(220, 275)
        Me.Flujol1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Flujol1.Name = "Flujol1"
        Me.Flujol1.Size = New System.Drawing.Size(132, 26)
        Me.Flujol1.TabIndex = 42
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(404, 227)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(226, 287)
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = False
        '
        'DiametroC
        '
        Me.DiametroC.AutoSize = True
        Me.DiametroC.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiametroC.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.DiametroC.Location = New System.Drawing.Point(645, 289)
        Me.DiametroC.Name = "DiametroC"
        Me.DiametroC.Size = New System.Drawing.Size(69, 19)
        Me.DiametroC.TabIndex = 75
        Me.DiametroC.Text = "Label16"
        '
        'RESULTADO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1041, 749)
        Me.Controls.Add(Me.DiametroC)
        Me.Controls.Add(Me.RelacionFlujos)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PresionDiseño)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Contaminante)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.udiam)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Compl2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Compg1)
        Me.Controls.Add(Me.ul1)
        Me.Controls.Add(Me.ul2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Flujol2)
        Me.Controls.Add(Me.ug2)
        Me.Controls.Add(Me.ug1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Flujog2)
        Me.Controls.Add(Me.Flujog1)
        Me.Controls.Add(Me.Compg2)
        Me.Controls.Add(Me.Flujol1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "RESULTADO"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resultado"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RelacionFlujos As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Presion As TextBox
    Friend WithEvents Temperatura As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PresionDiseño As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Contaminante As ComboBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents udiam As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Compl2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Compg1 As TextBox
    Friend WithEvents ul1 As Label
    Friend WithEvents ul2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Flujol2 As TextBox
    Friend WithEvents ug2 As Label
    Friend WithEvents ug1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Flujog2 As TextBox
    Friend WithEvents Flujog1 As TextBox
    Friend WithEvents Compg2 As TextBox
    Friend WithEvents Flujol1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DiametroC As Label
End Class
