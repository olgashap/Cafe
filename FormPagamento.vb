
Public Class FormPagamento

    Public Sub InserirLinhas(ByVal produto As String, ByVal preco As String)
        DataGridView1.Rows.Add(produto, preco)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub



End Class