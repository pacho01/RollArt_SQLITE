Public Class Form_Corrector
    Private Sub Btn_CERRAR_Click(sender As Object, e As EventArgs) Handles Btn_CERRAR.Click
        RollArt_SQLITE.Visible = True
        Me.Close()
    End Sub

    Private Sub Form_Corrector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub
End Class