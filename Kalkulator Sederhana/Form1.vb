Public Class Form1

    Private Sub btnHitung_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnHitung.Click
        Dim bil1 As Double = Val(txtBil1.Text)
        Dim bil2 As Double = Val(txtBil2.Text)
        Dim hasil As Double

        Select Case cbOperasi.Text
            Case "+"
                hasil = bil1 + bil2
            Case "-"
                hasil = bil1 - bil2
            Case "*"
                hasil = bil1 * bil2
            Case "/"
                If bil2 <> 0 Then
                    hasil = bil1 / bil2
                Else
                    MsgBox("Bilangan pembagi tidak boleh 0")
                    Exit Sub
                End If
            Case Else
                MsgBox("Pilih operator")
                Exit Sub
        End Select

        txtHasil.Text = hasil.ToString()
    End Sub

End Class
