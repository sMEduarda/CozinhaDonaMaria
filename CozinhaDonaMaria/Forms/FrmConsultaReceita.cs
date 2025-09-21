using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CozinhaDonaMaria.Models;
using CozinhaDonaMaria.Services;

namespace CozinhaDonaMaria.Forms
{
    public partial class FrmConsultaReceita : Form
    {
        private List<Receita> receitasCarregadas = new List<Receita>();

        public FrmConsultaReceita()
        {
            InitializeComponent();
        }

        private void FrmConsultaReceita_Load(object sender, EventArgs e)
        {
            CarregarReceitas();
        }

        private void CarregarReceitas(string filtro = "")
        {
            try
            {
                // Carregar todas as receitas do serviço
                receitasCarregadas = ReceitaService.Listar();

                // Aplicar filtro se houver
                var receitasFiltradas = string.IsNullOrWhiteSpace(filtro)
                    ? receitasCarregadas
                    : receitasCarregadas.Where(r => r.Nome.ToLower().Contains(filtro.ToLower())).ToList();

                // Limpar o DataGridView
                dgvReceitas.DataSource = null;

                // Definir a fonte de dados
                dgvReceitas.DataSource = receitasFiltradas;

                // Configurar colunas visíveis
                if (dgvReceitas.Columns["Nome"] != null)
                    dgvReceitas.Columns["Nome"].HeaderText = "Nome da Receita";

                if (dgvReceitas.Columns["Tipo"] != null)
                {
                    dgvReceitas.Columns["Tipo"].HeaderText = "Tipo de Cozinha";
                }

                // Esconder colunas desnecessárias
                if (dgvReceitas.Columns["Ingredientes"] != null)
                    dgvReceitas.Columns["Ingredientes"].Visible = false;
                if (dgvReceitas.Columns["ModoPreparo"] != null)
                    dgvReceitas.Columns["ModoPreparo"].Visible = false;

                if (receitasFiltradas.Count == 0)
                {
                    MessageBox.Show("Nenhuma receita encontrada!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar receitas: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CarregarReceitas(txtBusca.Text);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if (dgvReceitas.SelectedRows.Count > 0)
            {
                var receitaSelecionada = (Receita)dgvReceitas.SelectedRows[0].DataBoundItem;
                string ingredientes = receitaSelecionada.Ingredientes != null && receitaSelecionada.Ingredientes.Any()
                    ? string.Join(", ", receitaSelecionada.Ingredientes.Select(i => i.Nome))
                    : "Nenhum ingrediente";
                MessageBox.Show(
                    $"Nome: {receitaSelecionada.Nome}\n" +
                    $"Tipo: {(receitaSelecionada.Tipo != null ? receitaSelecionada.Tipo.Nome : "N/A")}\n" +
                    $"Ingredientes: {ingredientes}\n" +
                    $"Modo de Preparo: {receitaSelecionada.ModoPreparo}",
                    "Detalhes da Receita",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Selecione uma receita!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvReceitas.SelectedRows.Count > 0)
            {
                // Obter a receita selecionada
                var receitaSelecionada = (Receita)dgvReceitas.SelectedRows[0].DataBoundItem;

                // Abrir o formulário de cadastro/edição, passando a receita
                using (var frmCadastro = new FrmCadastroReceita(receitaSelecionada))
                {
                    if (frmCadastro.ShowDialog() == DialogResult.OK)
                    {
                        // Atualizar a lista de receitas após a edição
                        CarregarReceitas(txtBusca.Text);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione uma receita para editar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvReceitas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvReceitas.Columns[e.ColumnIndex].Name == "Tipo" && e.Value is TipoCozinha tipo)
            {
                e.Value = tipo.Nome;
            }
        }
    }
}