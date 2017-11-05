Public Class frmKeyboard

    Dim clickedKey(0) As String


    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        clickedKey(0) = "A"

        frmTest.txtTemp.Text = clickedKey(0)
    End Sub
End Class