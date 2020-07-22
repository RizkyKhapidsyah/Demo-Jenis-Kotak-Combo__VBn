Public Class Form1

    Private Sub tombolTampil_Click(sender As Object, e As EventArgs) Handles tombolTampil.Click
        'menampilkan seleksi-seleksi kotak combo
        labelNegara.Text = cboNegara.Text
        labelMain.Text = cboMain.Text
        labelArtis.Text = cboArtis.Text
    End Sub

    Private Sub tombolReset_Click(sender As Object, e As EventArgs) Handles tombolReset.Click
        'mereset kotak combo
        cboNegara.SelectedIndex = -1
        cboNegara.Text = String.Empty
        cboMain.SelectedIndex = -1
        cboMain.Text = String.Empty
        cboArtis.SelectedIndex = -1
        'Perhatian: cboArtis.Text adalah read-only

        'mereset label
        labelNegara.Text = String.Empty
        labelMain.Text = String.Empty
        labelArtis.Text = String.Empty
    End Sub

    Private Sub tombolKeluar_Click(sender As Object, e As EventArgs) Handles tombolKeluar.Click
        'menutup form
        Me.Close()
    End Sub
End Class
