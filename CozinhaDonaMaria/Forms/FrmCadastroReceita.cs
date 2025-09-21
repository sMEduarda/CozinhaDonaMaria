using System;
using System.Linq;
using System.Windows.Forms;
using CozinhaDonaMaria.Models;
using CozinhaDonaMaria.Services;

namespace CozinhaDonaMaria.Forms
{
    public partial class FrmCadastroReceita : Form
    {
        private Receita receitaAtual;

        // Construtor ajustado para aceitar uma receita (para edição)
        public FrmCadastroReceita(Receita receita = null)
        {
            InitializeComponent();
            receitaAtual = receita ?? new Receita(); // Se null, cria nova receita
        }

        private void FrmCadastroReceita_Load(object sender, EventArgs e)
        {
            try
            {
                // Carregar tipos de cozinha no ComboBox
                cmbTipoCozinha.DataSource = null;
                cmbTipoCozinha.DataSource = TipoCozinhaService.Listar();
                cmbTipoCozinha.DisplayMember = "Nome";
                cmbTipoCozinha.ValueMember = "Id";

                // Carregar ingredientes disponíveis no ComboBox
                cmbIngrediente.DataSource = null;
                cmbIngrediente.DataSource = IngredienteService.Listar();
                cmbIngrediente.DisplayMember = "Nome";
                cmbIngrediente.ValueMember = "Id";

                // Se for edição, preencher os campos com os dados da receita
                if (receitaAtual.Id > 0) // Verifica se é uma receita existente
                {
                    txtNome.Text = receitaAtual.Nome;
                    cmbTipoCozinha.SelectedItem = receitaAtual.Tipo;
                    txtModoPreparo.Text = receitaAtual.ModoPreparo;

                    // Preencher a lista de ingredientes (assumindo que usa um ListBox chamado lstIngredientes)
                    foreach (var ing in receitaAtual.Ingredientes)
                    {
                        listBoxIngredientes.Items.Add($"{ing.Nome} - {ing.UnidadeMedida}");
                    }

                    // Ajustar título para modo de edição
                    LBL_Titulo.Text = "Editar Receita";
                    this.Text = "Editar Receita";
                }
                else
                {
                    // Para criação, garantir que a lista de ingredientes esteja vazia
                    receitaAtual.Ingredientes = new System.Collections.Generic.List<Ingrediente>();
                    LBL_Titulo.Text = "Cadastrar Receita";
                    this.Text = "Cadastrar Receita";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bnt_add_Ingredientes_Click(object sender, EventArgs e)
        {
            if (cmbIngrediente.SelectedItem is Ingrediente ing)
            {
                // Adicionar ingrediente à lista da receita
                receitaAtual.Ingredientes.Add(ing);
                // Adicionar ao ListBox (assumindo que existe um ListBox chamado lstIngredientes)
                listBoxIngredientes.Items.Add($"{ing.Nome} - {ing.UnidadeMedida}");
                cmbIngrediente.SelectedIndex = -1; // Limpar seleção
            }
            else
            {
                MessageBox.Show("Selecione um ingrediente válido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bnt_Salvar_Receita_Click(object sender, EventArgs e)
        {
            // Validação dos campos
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Por favor, insira o nome da receita!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
                return;
            }

            if (cmbTipoCozinha.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione um tipo de cozinha!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbTipoCozinha.Focus();
                return;
            }

            if (receitaAtual.Ingredientes.Count == 0)
            {
                MessageBox.Show("Adicione pelo menos um ingrediente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbIngrediente.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtModoPreparo.Text))
            {
                MessageBox.Show("Por favor, insira o modo de preparo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtModoPreparo.Focus();
                return;
            }

            // Preencher os dados da receita
            receitaAtual.Nome = txtNome.Text;
            receitaAtual.Tipo = (TipoCozinha)cmbTipoCozinha.SelectedItem;
            receitaAtual.ModoPreparo = txtModoPreparo.Text;

            try
            {
                // Salvar ou atualizar a receita
                if (receitaAtual.Id == 0) // Nova receita
                {
                    ReceitaService.Adicionar(receitaAtual);
                    MessageBox.Show("Receita cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else // Edição de receita existente
                {
                    ReceitaService.Atualizar(receitaAtual);
                    MessageBox.Show("Receita atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Definir DialogResult para indicar sucesso ao FrmConsultaReceita
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar a receita: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Métodos do Visual Studio que podem ficar vazios se não forem usados
        private void LBL_Titulo_Click(object sender, EventArgs e) { }
        private void txt_NomeReceita_TextChanged(object sender, EventArgs e) { }
        private void lbl_Ingredientes_Click(object sender, EventArgs e) { }
    }
}