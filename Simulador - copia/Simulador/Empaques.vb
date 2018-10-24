Public Class EMPAQUES

    Public Pres, Temp, ry, rx, PMc, Cg1, Cg2, Cl1, Cl2, PM, GG, Fp, v, Fx1, Fx2, Fy1, Fy2, Y1, GGgrafica, GGraiz, Cs, u0, Gy, Gx, S, D, CFv, FTg As Double
    Private Sub Empaques_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If a1.Checked = True Then 'Raschig
            Fp = 580
        ElseIf a2.Checked = True Then
            Fp = 155
        ElseIf a3.Checked = True Then
            Fp = 95
        ElseIf a4.Checked = True Then
            Fp = 65
        ElseIf b1.Checked = True Then 'Pall metalico
            Fp = 56
        ElseIf b2.Checked = True Then
            Fp = 40
        ElseIf b3.Checked = True Then
            Fp = 27
        ElseIf c1.Checked = True Then 'Pall plastico
            Fp = 55
        ElseIf c2.Checked = True Then
            Fp = 40
        ElseIf d1.Checked = True Then 'Berl
            Fp = 240
        ElseIf d2.Checked = True Then
            Fp = 110
        ElseIf d3.Checked = True Then
            Fp = 65
        ElseIf e1.Checked = True Then 'Intalox
            Fp = 200
        ElseIf e2.Checked = True Then
            Fp = 92
        ElseIf e3.Checked = True Then
            Fp = 52
        ElseIf e4.Checked = True Then
            Fp = 40
        ElseIf e5.Checked = True Then
            Fp = 22
        ElseIf f1.Checked = True Then 'Super Intalox
            Fp = 60
        ElseIf f2.Checked = True Then
            Fp = 30
        ElseIf g1.Checked = True Then 'IMPT
            Fp = 41
        ElseIf g2.Checked = True Then
            Fp = 24
        ElseIf g3.Checked = True Then
            Fp = 18
        ElseIf h1.Checked = True Then 'Hy-pack
            Fp = 45
        ElseIf h2.Checked = True Then
            Fp = 29
        ElseIf h3.Checked = True Then
            Fp = 26
        End If

        Me.Hide()
        GRAFICA.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class