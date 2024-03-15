Imports Cafe.FormPagamento

Public Class Form1
    Public Property RowHeadersVisible As Boolean
    Public Property AllowUserToDeleteRows As Boolean
    Public Property AllowUserToResizeRows As Boolean


    Private frmPagamento As New FormPagamento()



    Private Sub btnCafe_MouseHover(sender As Object, e As EventArgs) Handles btnCafe.MouseHover, btnPao.MouseHover, btnCroquetes.MouseHover,
            btnEmpadas.MouseHover, btnDoces.MouseHover, btnTarte.MouseHover, btnAquas.MouseHover, btnSumos.MouseHover





        'btnCafe.Image = My.Resources.fundo
        Dim btn As Button
        btn = CType(sender, Button)
        btn.Image = My.Resources.fundo



    End Sub

    Private Sub btnCafe_MouseLeave(sender As Object, e As EventArgs) Handles btnCafe.MouseLeave
        btnCafe.Image = My.Resources.images


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.ReadOnly = True
        TextBox1.TextAlign = HorizontalAlignment.Right
        InicializarGrid()

    End Sub


    Private Sub btnPao_MouseLeave(sender As Object, e As EventArgs) Handles btnPao.MouseLeave
        btnPao.Image = My.Resources.imagesPao

    End Sub

    Private Sub btnCroquetes_MouseLeave(sender As Object, e As EventArgs) Handles btnCroquetes.MouseLeave
        btnCroquetes.Image = My.Resources.descarregarcroq



    End Sub

    Private Sub btnEmpadas_MouseLeave(sender As Object, e As EventArgs) Handles btnEmpadas.MouseLeave
        btnEmpadas.Image = My.Resources.imagesemp



    End Sub

    Private Sub btnDoces_MouseLeave(sender As Object, e As EventArgs) Handles btnDoces.MouseLeave
        btnDoces.Image = My.Resources.descarregarbolo

    End Sub

    Private Sub btnTarte_MouseLeave(sender As Object, e As EventArgs) Handles btnTarte.MouseLeave
        btnTarte.Image = My.Resources.descarregartarte
    End Sub

    Private Sub btnAquas_MouseLeave(sender As Object, e As EventArgs) Handles btnAquas.MouseLeave
        btnAquas.Image = My.Resources.descarregar

    End Sub

    Private Sub btnSumos_MouseLeave(sender As Object, e As EventArgs) Handles btnSumos.MouseLeave
        btnSumos.Image = My.Resources.descarregarsumo

    End Sub

    Private Sub btnCafe_Click(sender As Object, e As EventArgs) Handles btnCafe.Click
        InserirLinhas(btnCafe.Text, 0.65)

    End Sub

    Sub InserirLinhas(produto As String, preco As String)
        dgvProdutos.Rows.Add(produto, preco)
        TextBox1.Text = Format(CDbl("0" + TextBox1.Text) + preco, "0.00 ")


    End Sub



    Private Sub InicializarGrid()
        With dgvProdutos
            .RowHeadersVisible = False
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToResizeRows = False
            .AllowUserToResizeColumns = False
            .MultiSelect = False
            .ReadOnly = True
            .Columns.Add("Produto", "Produto") 'col 0
            .Columns.Add("Preço", "Preço $") 'col 1
            .Font = New Font("Tahoma", 8.25)
            .Columns(0).Width = 150
            .Columns(1).Width = 50
            .Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopLeft
            .Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopRight
            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight



            For Each row As DataGridViewRow In dgvProdutos.Rows
            frmPagamento.DataGridView1.Rows.Add(row.Cells(0).Value, row.Cells(1).Value)
        Next





        End With

    End Sub



    Private Sub AllowUserToAddRows()
        Throw New NotImplementedException()
    End Sub

    Private Sub btnPao_Click(sender As Object, e As EventArgs) Handles btnPao.Click
        InserirLinhas(btnPao.Text, 0.4)

    End Sub

    Private Sub btnCroquetes_Click(sender As Object, e As EventArgs) Handles btnCroquetes.Click
        InserirLinhas(btnCroquetes.Text, 0.7)
    End Sub

    Private Sub btnEmpadas_Click(sender As Object, e As EventArgs) Handles btnEmpadas.Click
        InserirLinhas(btnEmpadas.Text, 0.5)
    End Sub

    Private Sub btnDoces_Click(sender As Object, e As EventArgs) Handles btnDoces.Click
        InserirLinhas(btnDoces.Text, 1.2)
    End Sub

    Private Sub btnTarte_Click(sender As Object, e As EventArgs) Handles btnTarte.Click
        InserirLinhas(btnTarte.Text, 1.1)
    End Sub

    Private Sub btnAquas_Click(sender As Object, e As EventArgs) Handles btnAquas.Click
        InserirLinhas(btnAquas.Text, 1.0)
    End Sub

    Private Sub btnSumos_Click(sender As Object, e As EventArgs) Handles btnSumos.Click
        InserirLinhas(btnSumos.Text, 1.4)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmPagamento.ShowDialog()
    End Sub
End Class
