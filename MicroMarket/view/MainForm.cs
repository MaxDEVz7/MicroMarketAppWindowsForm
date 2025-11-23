using System;
using System.Diagnostics;
using MicroMarket.model;
using MicroMarket.view;
using Microsoft.EntityFrameworkCore;

namespace MicroMarket
{
    public partial class Form1 : Form
    {
        private ContextDB contextDb;
        public Form1()
        {
            InitializeComponent();
            contextDb = new ContextDB();
            // Carrega os dados no Grid
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {

            // 1. Começa com todos os produtos
            var query = contextDb.Produtos.AsQueryable();

            // 2. APLICA FILTRO 1: CheckBox "Estoque Baixo" (Se ativo)
            if (estoqueBaixo.Checked)
            {
                int limite = Properties.Settings.Default.ValorEstoqueBaixo;
                query = query.Where(p => p.Estoque < limite);
            }

            // 3. APLICA FILTRO 2: Barra de Pesquisa (Se em pesquisa)
            if (!string.IsNullOrWhiteSpace(pesquisaBox.Text) && pesquisaBox.Text != "Pesquisar...")
            {
                // Converte tudo para minúsculo para a busca não diferenciar maiúsculas
                string termo = pesquisaBox.Text.ToLower();
                query = query.Where(p => p.Nome.ToLower().Contains(termo));
            }

            // 4. execução da busca
            var listaFinal = query.ToList();

            // 5. Atualiza o Grid
            gridProdutos.DataSource = listaFinal;

            // 6. Formatação (Moeda)
            if (gridProdutos.Columns["Preco"] != null)
            {
                gridProdutos.Columns["Preco"].DefaultCellStyle.Format = "C2";
                gridProdutos.Columns["Preco"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Configuração inicial da busca
            pesquisaBox.Text = "Pesquisar...";
            pesquisaBox.ForeColor = Color.Gray;

            if (gridProdutos.Columns["Preco"] != null)
            {
                gridProdutos.Columns["Preco"].DefaultCellStyle.Format = "C2";

                // Alinhar à direita (padrão contábil)
                gridProdutos.Columns["Preco"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            if (gridProdutos.Columns["Estoque"] != null)
            {
                // Alinhar à direita (padrão contábil)
                gridProdutos.Columns["Estoque"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            // CONFIGURAÇÃO DO LAYOUT DAS COLUNAS
            // 1. ID: Largura fixa ou ajustada ao conteúdo
            gridProdutos.Columns["Id"].Width = 50;

            // 2. Preço e Estoque: Ajustam ao tamanho do número
            gridProdutos.Columns["Preco"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            gridProdutos.Columns["Estoque"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // 3. Nome: Ocupa TODO o espaço que sobrar
            gridProdutos.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void adicionarProduto_Click(object sender, EventArgs e)
        {
            // Cria a instância da tela de cadastro
            using (var form = new FrmCadastroProduto())
            {
                // Abre a tela como um "Diálogo"
                var resultado = form.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    // PEGANDO OS DADOS DA OUTRA TELA
                    var novoP = new Produto
                    {
                        Nome = form.NomeBox.Text,
                        Preco = form.PrecoBox.Value,
                        Estoque = (int)form.EstoqueInicial.Value
                    };

                    // Verificação do preço zerado
                    bool permiteZerado = Properties.Settings.Default.PermitirPreçoZerado;

                    if (novoP.Preco <= 0 && !permiteZerado)
                    {
                        MessageBox.Show("O preço não pode menor ou igual a 0.");
                        return;
                    }

                    contextDb.Produtos.Add(novoP);
                    contextDb.SaveChanges();
                    AtualizarGrid();
                }
            }
        }

        private void verDetalhesProduto_Click(object sender, EventArgs e)
        {
            if (gridProdutos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um produto na tabela primeiro.");
                return;
            }

            // Pegar o objeto selecionado na linha
            // O DataBoundItem pega o objeto 'Produto' inteiro que está naquela linha
            var linhaSelecionada = gridProdutos.SelectedRows[0];
            var produtoSelecionado = (Produto)linhaSelecionada.DataBoundItem;

            using (var form = new FrmExibirDetalhesProduto())
            {
                {
                    // Passar o nome para o label da outra tela
                    form.NomeBox.Text = $"{produtoSelecionado.Nome}";
                    form.PrecoBox.Value = produtoSelecionado.Preco;

                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        // Lê a configuração do usuário
                        bool permiteZerado = Properties.Settings.Default.PermitirPreçoZerado;

                        // 4. Validar se tem estoque suficiente
                        if (form.PrecoBox.Value <= 0 && !permiteZerado)
                        {
                            MessageBox.Show("Preço não pode ser zerado ou menor que zero!");
                            return;
                        }

                        produtoSelecionado.Nome = form.NomeBox.Text;
                        produtoSelecionado.Preco = form.PrecoBox.Value;

                        // 5. Atualiza o banco
                        contextDb.SaveChanges();

                        // 6. Atualiza visual
                        AtualizarGrid();
                        MessageBox.Show("Produto alterado!");
                    }
                }
            }
        }

        private void preferencias_Click(object sender, EventArgs e)
        {
            using (var form = new FormsPreferencias())
            {
                // Se o usuário clicou em SALVAR (OK)
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Força uma atualização da grid para aplicar as novas preferencias imediatamente
                    AtualizarGrid();
                }
            }
        }

        private void gridProducts(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deleteProduto_Click(object sender, EventArgs e)
        {
            // 1. Validação: Tem algo selecionado?
            if (gridProdutos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um produto na tabela para excluir.");
                return;
            }

            // 2. Pegar o objeto selecionado na linha
            // O DataBoundItem pega o objeto 'Produto' inteiro que está naquela linha
            var linhaSelecionada = gridProdutos.SelectedRows[0];
            var produtoSelecionado = (Produto)linhaSelecionada.DataBoundItem;

            // 3. Exibe a pergunta e guarda a resposta
            var resultado = MessageBox.Show(
                $"Tem certeza que deseja excluir o produto '{produtoSelecionado.Nome}'?", // Mensagem
                "Confirmar Exclusão", // Título da Janela
                MessageBoxButtons.YesNo, // Botões que vão aparecer
                MessageBoxIcon.Question
            );

            // 4. Verifica o que o usuário clicou
            if (resultado == DialogResult.Yes)
            {
                contextDb.Produtos.Remove(produtoSelecionado);
                contextDb.SaveChanges();

                AtualizarGrid();

                MessageBox.Show("Produto excluído com sucesso!");
            }
        }

        private void filtros_Click(object sender, EventArgs e)
        {

        }

        private void Baixar_Click(object sender, EventArgs e)
        {
            // 1. Validação: Tem algo selecionado?
            if (gridProdutos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um produto na tabela primeiro.");
                return;
            }

            // 2. Pegar o objeto selecionado na linha
            // O DataBoundItem pega o objeto 'Produto' inteiro que está naquela linha
            var linhaSelecionada = gridProdutos.SelectedRows[0];
            var produtoSelecionado = (Produto)linhaSelecionada.DataBoundItem;

            // 3. Abrir a tela de "Quantos?"
            using (var form = new FrmBaixarEstoque())
            {
                // Passar o nome para o label da outra tela
                form.produtoSelecionado.Text = $"Baixar de: {produtoSelecionado.Nome}";

                if (form.ShowDialog() == DialogResult.OK)
                {
                    int qtdBaixa = (int)form.numQtd.Value;


                    // Lê a configuração do usuário
                    bool permiteNegativo = Properties.Settings.Default.PermitirEstoqueNegativo;

                    // 4. Validar se tem estoque suficiente
                    if (produtoSelecionado.Estoque < qtdBaixa && !permiteNegativo)
                    {
                        MessageBox.Show("Estoque insuficiente!");
                        return;
                    }

                    // 5. Atualizar o banco
                    produtoSelecionado.Estoque -= qtdBaixa;

                    contextDb.SaveChanges();

                    // 6. Atualizar visual
                    AtualizarGrid();
                    MessageBox.Show("Baixa realizada!");
                }
            }
        }

        private void EntrarEstoque_Click(object sender, EventArgs e)
        {
            // 1. Validação: Tem algo selecionado?
            if (gridProdutos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um produto na tabela primeiro.");
                return;
            }

            // 2. Pegar o objeto selecionado na linha
            // O DataBoundItem pega o objeto 'Produto' inteiro que está naquela linha
            var linhaSelecionada = gridProdutos.SelectedRows[0];
            var produtoSelecionado = (Produto)linhaSelecionada.DataBoundItem;

            // 3. Abrir a telinha de "Quantos?"
            using (var form = new FrmEntrarEstoque())
            {
                // (Opcional) Passar o nome para o label da outra tela
                form.produtoSelecionado.Text = $"Dando entrada do produto: {produtoSelecionado.Nome}";

                if (form.ShowDialog() == DialogResult.OK)
                {
                    int qtdEntrada = (int)form.numQtd.Value;
                    // 5. Atualizar o banco
                    produtoSelecionado.Estoque += qtdEntrada;

                    contextDb.SaveChanges();

                    // 6. Atualizar visual
                    AtualizarGrid();
                    MessageBox.Show("Entrada realizada!");
                }
            }
        }

        private void estoqueBaixo_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void linkGitHub_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // URL
            string url = "https://github.com/MaxDEVz7"; // Coloque seu link aqui

            // Configura o processo para abrir no navegador padrão
            var info = new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            };

            try
            {
                Process.Start(info);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível abrir o link: " + ex.Message);
            }

            // Opcional: Marca o link como "visitado"
            linkLabel1.LinkVisited = true;
        }

        private void panelLateral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pesquisaBox_TextChanged(object sender, EventArgs e)
        {
            AtualizarGrid();
        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            pesquisaBox.Focus();
        }

        private void pesquisaBox_Enter(object sender, EventArgs e)
        {
            // Se o texto for o placeholder, limpa e muda a cor para preto
            if (pesquisaBox.Text == "Pesquisar...")
            {
                pesquisaBox.Text = "";
                pesquisaBox.ForeColor = Color.Black;
            }
        }

        private void pesquisaBox_Leave(object sender, EventArgs e)
        {
            // Se o usuário não digitou nada, volta o placeholder cinza
            if (string.IsNullOrWhiteSpace(pesquisaBox.Text))
            {
                pesquisaBox.Text = "Pesquisar...";
                pesquisaBox.ForeColor = Color.Gray;
            }
        }
    }
}
