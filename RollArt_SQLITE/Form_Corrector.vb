Public Class Form_Corrector
    Private Sub Btn_CERRAR_Click(sender As Object, e As EventArgs) Handles Btn_CERRAR.Click
        RollArt_SQLITE.Visible = True
        Me.Close()
    End Sub

    Private Sub Form_Corrector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cursor = DefaultCursor
    End Sub
End Class