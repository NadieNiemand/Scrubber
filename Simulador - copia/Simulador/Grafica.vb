Public Class GRAFICA
    Public Pres, Temp, ry, rx, PMc, Cg1, Cg2, Cl1, Cl2, PM, GG, Fp, v, Fx1, Fx2, Fy1, Fy2, Y1, GGgrafica, GGraiz, Cs, u0, Gy, Gx, S, D, CFv, FTg As Double
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub gxgy_Click(sender As Object, e As EventArgs) Handles gxgy.Click

    End Sub

    Public Sub Grafica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        deltaP.Text = PRINCIPAL.PresionDiseño.Text
        gxgy.Text = PRINCIPAL.GGraiz
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        CFv = CsFp.Text
        Cs = (CFv) / (Math.Sqrt(EMPAQUES.Fp) * PRINCIPAL.v ^ 0.05)
        u0 = Cs * Math.Sqrt((PRINCIPAL.rx - PRINCIPAL.ry) / PRINCIPAL.ry)
        Gy = u0 * PRINCIPAL.ry * 3600 'Este ultimo dato es para convertirlo a hrs
        Gx = PRINCIPAL.GG * Gy
        FTg = PRINCIPAL.Fy1 * PRINCIPAL.ry
        S = FTg / Gy
        D = Math.Sqrt((4 * S) / Math.PI)

        Me.Hide()
        RESULTADO.Show()

    End Sub
End Class