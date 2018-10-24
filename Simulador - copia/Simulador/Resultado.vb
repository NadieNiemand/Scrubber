Public Class RESULTADO
    Public D As Double
    Private Sub Resultado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DiametroC.Text = GRAFICA.D
    End Sub

    Private Sub Diametro_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DiametroC_Click(sender As Object, e As EventArgs) Handles DiametroC.Click

    End Sub
End Class