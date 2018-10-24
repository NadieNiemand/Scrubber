Public Class PRINCIPAL
    Public Pres, Temp, ry, rx, PMc, Cg1, Cg2, Cl1, Cl2, PM, GG, Fp, v, Fx1, Fx2, Fy1, Fy2, Y1, GGgrafica, GGraiz, PM1, PM2, PM3, PM4, PMg, Cg1M, Cg1A, Cg1D, Cg1N As Double

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles DioxAz.CheckedChanged

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedItem = "Métrico" Then
            ul1.Text = "m^3/h"
            ul2.Text = "m^3/h"
            ug1.Text = "m^3/h"
            ug2.Text = "m^3/h"


        ElseIf ListBox1.SelectedItem = "Inglés" Then
            ul1.Text = "ft^3/h"
            ul2.Text = "ft^3/h"
            ug1.Text = "ft^3/h"
            ug2.Text = "ft^3/h"

        End If
    End Sub

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        rx = 62.3 'lb/ft^3 a 20°C
        v = 1 'cSt a 20°C

        Pres = Val(Presion.Text)
        Temp = Val(Temperatura.Text)
        Fx1 = Val(Flujol1.Text)
        Fx2 = Val(Flujol2.Text)
        Fy1 = Val(Flujog1.Text)
        Fy2 = Val(Flujog2.Text)
        GG = Val(RelacionFlujos.Text)
        
        Cg1M = Val(Comp1M.Text)
        Cg1D = Val(Comp1D.Text)
        Cg1N = Val(Comp1N.Text)
        Cg1A = Val(Comp1A.Text)

        If Monox.Checked = True Then
            PM1 = 28.1
        ElseIf Monox.Checked = False Then
            PM1 = 0
        End If

        If DioxCar.Checked = True Then
            PM2 = 44.01
        ElseIf DioxCar.Checked = False Then
            PM2 = 0
        End If

        If Amonio.Checked = True Then
            PM3 = 17.031
        ElseIf Amonio.Checked = False Then
            PM3 = 0
        End If

        If DioxAz.Checked = True Then
            PM4 = 64.066
        ElseIf DioxAz.Checked = False Then
            PM4 = 0
        End If


        PMg = (PM1 * Cg1M) + (PM2 * Cg1D) + (PM3 * Cg1N) + (PM4 * Cg1A)
        Cg1 = Cg1A + Cg1D + Cg1M + Cg1N
        PM = PMg + (28.96 * (1 - Cg1))
        ry = (PM * Pres) / (10.73 * (Temp + 460))
        GGraiz = GG * Math.Sqrt(ry / rx)

        Me.Hide()
        EMPAQUES.Show()


    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub
End Class
