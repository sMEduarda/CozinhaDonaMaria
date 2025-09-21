using System;
using System.Windows.Forms;

namespace CozinhaDonaMaria
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        // --- MENU STRIP (parte de cima) ---
        private void consultarReceitasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new Forms.FrmConsultaReceita();
            form.ShowDialog();
        }

        private void cadastrarReceitasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new Forms.FrmCadastroReceita();
            form.ShowDialog();
        }

        private void cadastrarIngredientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new Forms.FrmCadastroIngrediente();
            form.ShowDialog();
        }

        private void cadastrarTipoDeCozinhaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new Forms.FrmCadastroTipoCozinha();
            form.ShowDialog();
        }

        private void extraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new Forms.FrmExtra();
            form.ShowDialog();
        }

        // --- BOTÕES (na tela) ---
        private void bnt_CD_Ingredientes_Click(object sender, EventArgs e)
        {
            var form = new Forms.FrmCadastroIngrediente();
            form.ShowDialog();
        }

        private void bnt_CD_TipoCozinha_Click(object sender, EventArgs e)
        {
            var form = new Forms.FrmCadastroTipoCozinha();
            form.ShowDialog();
        }

        private void bnt_CS_Estoque_Click(object sender, EventArgs e)
        {
            // Você pode usar FrmConsultaReceita ou criar um FrmConsultaEstoque depois
            var form = new Forms.FrmConsultaReceita();
            form.ShowDialog();
        }

        private void bnt_CS_Receitas_Click(object sender, EventArgs e)
        {
            var form = new Forms.FrmConsultaReceita();
            form.ShowDialog();
        }

        private void bnt_CD_Receitas_Click(object sender, EventArgs e)
        {
            var form = new Forms.FrmCadastroReceita();
            form.ShowDialog();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}


