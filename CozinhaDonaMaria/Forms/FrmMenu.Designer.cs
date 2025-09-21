namespace CozinhaDonaMaria
{
    partial class FrmMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.telasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarReceitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarReceitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarIngredienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarTipoDeCozinhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.consultarReceitasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarReceitasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarIngredientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarTipoDeCozinhaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.extraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bnt_CD_Ingredientes = new System.Windows.Forms.Button();
            this.bnt_CD_TipoCozinha = new System.Windows.Forms.Button();
            this.bnt_CD_Receitas = new System.Windows.Forms.Button();
            this.bnt_CS_Receitas = new System.Windows.Forms.Button();
            this.bnt_CS_Estoque = new System.Windows.Forms.Button();
            this.lbl_Cadastros = new System.Windows.Forms.Label();
            this.lbl_Consultas = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.telasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(826, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // telasToolStripMenuItem
            // 
            this.telasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarReceitasToolStripMenuItem,
            this.extraToolStripMenuItem,
            this.cadastrarReceitasToolStripMenuItem,
            this.cadastrarIngredienteToolStripMenuItem,
            this.cadastrarTipoDeCozinhaToolStripMenuItem});
            this.telasToolStripMenuItem.Name = "telasToolStripMenuItem";
            this.telasToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.telasToolStripMenuItem.Text = "Telas";
            // 
            // consultarReceitasToolStripMenuItem
            // 
            this.consultarReceitasToolStripMenuItem.Name = "consultarReceitasToolStripMenuItem";
            this.consultarReceitasToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.consultarReceitasToolStripMenuItem.Text = "Consultar Receitas";
            this.consultarReceitasToolStripMenuItem.Click += new System.EventHandler(this.consultarReceitasToolStripMenuItem1_Click);
            // 
            // cadastrarReceitasToolStripMenuItem
            // 
            this.cadastrarReceitasToolStripMenuItem.Name = "cadastrarReceitasToolStripMenuItem";
            this.cadastrarReceitasToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.cadastrarReceitasToolStripMenuItem.Text = "Cadastrar Receitas";
            this.cadastrarReceitasToolStripMenuItem.Click += new System.EventHandler(this.cadastrarReceitasToolStripMenuItem1_Click);
            // 
            // cadastrarIngredienteToolStripMenuItem
            // 
            this.cadastrarIngredienteToolStripMenuItem.Name = "cadastrarIngredienteToolStripMenuItem";
            this.cadastrarIngredienteToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.cadastrarIngredienteToolStripMenuItem.Text = "Cadastrar Ingrediente";
            this.cadastrarIngredienteToolStripMenuItem.Click += new System.EventHandler(this.cadastrarIngredientesToolStripMenuItem1_Click);
            // 
            // cadastrarTipoDeCozinhaToolStripMenuItem
            // 
            this.cadastrarTipoDeCozinhaToolStripMenuItem.Name = "cadastrarTipoDeCozinhaToolStripMenuItem";
            this.cadastrarTipoDeCozinhaToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.cadastrarTipoDeCozinhaToolStripMenuItem.Text = "Cadastrar Tipo de Cozinha";
            this.cadastrarTipoDeCozinhaToolStripMenuItem.Click += new System.EventHandler(this.cadastrarTipoDeCozinhaToolStripMenuItem1_Click);
            // 
            // extraToolStripMenuItem
            // 
            this.extraToolStripMenuItem.Name = "extraToolStripMenuItem";
            this.extraToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.extraToolStripMenuItem.Text = "Consultar Estoque";
            this.extraToolStripMenuItem.Click += new System.EventHandler(this.extraToolStripMenuItem1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarReceitasToolStripMenuItem1,
            this.cadastrarReceitasToolStripMenuItem1,
            this.cadastrarIngredientesToolStripMenuItem1,
            this.cadastrarTipoDeCozinhaToolStripMenuItem1,
            this.extraToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(254, 124);
            // 
            // consultarReceitasToolStripMenuItem1
            // 
            this.consultarReceitasToolStripMenuItem1.Name = "consultarReceitasToolStripMenuItem1";
            this.consultarReceitasToolStripMenuItem1.Size = new System.Drawing.Size(253, 24);
            this.consultarReceitasToolStripMenuItem1.Text = "Consultar Receitas";
            this.consultarReceitasToolStripMenuItem1.Click += new System.EventHandler(this.consultarReceitasToolStripMenuItem1_Click);
            // 
            // cadastrarReceitasToolStripMenuItem1
            // 
            this.cadastrarReceitasToolStripMenuItem1.Name = "cadastrarReceitasToolStripMenuItem1";
            this.cadastrarReceitasToolStripMenuItem1.Size = new System.Drawing.Size(253, 24);
            this.cadastrarReceitasToolStripMenuItem1.Text = "Cadastrar Receitas";
            this.cadastrarReceitasToolStripMenuItem1.Click += new System.EventHandler(this.cadastrarReceitasToolStripMenuItem1_Click);
            // 
            // cadastrarIngredientesToolStripMenuItem1
            // 
            this.cadastrarIngredientesToolStripMenuItem1.Name = "cadastrarIngredientesToolStripMenuItem1";
            this.cadastrarIngredientesToolStripMenuItem1.Size = new System.Drawing.Size(253, 24);
            this.cadastrarIngredientesToolStripMenuItem1.Text = "Cadastrar Ingredientes";
            this.cadastrarIngredientesToolStripMenuItem1.Click += new System.EventHandler(this.cadastrarIngredientesToolStripMenuItem1_Click);
            // 
            // cadastrarTipoDeCozinhaToolStripMenuItem1
            // 
            this.cadastrarTipoDeCozinhaToolStripMenuItem1.Name = "cadastrarTipoDeCozinhaToolStripMenuItem1";
            this.cadastrarTipoDeCozinhaToolStripMenuItem1.Size = new System.Drawing.Size(253, 24);
            this.cadastrarTipoDeCozinhaToolStripMenuItem1.Text = "Cadastrar Tipo de Cozinha";
            this.cadastrarTipoDeCozinhaToolStripMenuItem1.Click += new System.EventHandler(this.cadastrarTipoDeCozinhaToolStripMenuItem1_Click);
            // 
            // extraToolStripMenuItem1
            // 
            this.extraToolStripMenuItem1.Name = "extraToolStripMenuItem1";
            this.extraToolStripMenuItem1.Size = new System.Drawing.Size(253, 24);
            this.extraToolStripMenuItem1.Text = "Extra";
            this.extraToolStripMenuItem1.Click += new System.EventHandler(this.extraToolStripMenuItem1_Click);
            // 
            // bnt_CD_Ingredientes
            // 
            this.bnt_CD_Ingredientes.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bnt_CD_Ingredientes.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_CD_Ingredientes.Location = new System.Drawing.Point(307, 115);
            this.bnt_CD_Ingredientes.Name = "bnt_CD_Ingredientes";
            this.bnt_CD_Ingredientes.Size = new System.Drawing.Size(198, 78);
            this.bnt_CD_Ingredientes.TabIndex = 1;
            this.bnt_CD_Ingredientes.Text = "Cadastrar Ingerdientes";
            this.bnt_CD_Ingredientes.UseVisualStyleBackColor = false;
            this.bnt_CD_Ingredientes.Click += new System.EventHandler(this.bnt_CD_Ingredientes_Click);
            // 
            // bnt_CD_TipoCozinha
            // 
            this.bnt_CD_TipoCozinha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bnt_CD_TipoCozinha.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_CD_TipoCozinha.Location = new System.Drawing.Point(43, 115);
            this.bnt_CD_TipoCozinha.Name = "bnt_CD_TipoCozinha";
            this.bnt_CD_TipoCozinha.Size = new System.Drawing.Size(221, 78);
            this.bnt_CD_TipoCozinha.TabIndex = 2;
            this.bnt_CD_TipoCozinha.Text = "Cadastrar Tipo de Cozinha";
            this.bnt_CD_TipoCozinha.UseVisualStyleBackColor = false;
            this.bnt_CD_TipoCozinha.Click += new System.EventHandler(this.bnt_CD_TipoCozinha_Click);
            // 
            // bnt_CD_Receitas
            // 
            this.bnt_CD_Receitas.BackColor = System.Drawing.Color.LightGreen;
            this.bnt_CD_Receitas.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_CD_Receitas.Location = new System.Drawing.Point(577, 115);
            this.bnt_CD_Receitas.Name = "bnt_CD_Receitas";
            this.bnt_CD_Receitas.Size = new System.Drawing.Size(198, 78);
            this.bnt_CD_Receitas.TabIndex = 3;
            this.bnt_CD_Receitas.Text = "Cadastrar Receitas";
            this.bnt_CD_Receitas.UseVisualStyleBackColor = false;
            this.bnt_CD_Receitas.Click += new System.EventHandler(this.bnt_CD_Receitas_Click);
            // 
            // bnt_CS_Receitas
            // 
            this.bnt_CS_Receitas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bnt_CS_Receitas.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_CS_Receitas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bnt_CS_Receitas.Location = new System.Drawing.Point(443, 314);
            this.bnt_CS_Receitas.Name = "bnt_CS_Receitas";
            this.bnt_CS_Receitas.Size = new System.Drawing.Size(198, 78);
            this.bnt_CS_Receitas.TabIndex = 4;
            this.bnt_CS_Receitas.Text = "Consultar Receitas";
            this.bnt_CS_Receitas.UseVisualStyleBackColor = false;
            this.bnt_CS_Receitas.Click += new System.EventHandler(this.bnt_CS_Receitas_Click);
            // 
            // bnt_CS_Estoque
            // 
            this.bnt_CS_Estoque.BackColor = System.Drawing.Color.Plum;
            this.bnt_CS_Estoque.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_CS_Estoque.Location = new System.Drawing.Point(138, 314);
            this.bnt_CS_Estoque.Name = "bnt_CS_Estoque";
            this.bnt_CS_Estoque.Size = new System.Drawing.Size(221, 78);
            this.bnt_CS_Estoque.TabIndex = 5;
            this.bnt_CS_Estoque.Text = "Consultar Estoque";
            this.bnt_CS_Estoque.UseVisualStyleBackColor = false;
            this.bnt_CS_Estoque.Click += new System.EventHandler(this.bnt_CS_Estoque_Click);
            // 
            // lbl_Cadastros
            // 
            this.lbl_Cadastros.AutoSize = true;
            this.lbl_Cadastros.Font = new System.Drawing.Font("Goudy Old Style", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cadastros.ForeColor = System.Drawing.Color.Black;
            this.lbl_Cadastros.Location = new System.Drawing.Point(259, 40);
            this.lbl_Cadastros.Name = "lbl_Cadastros";
            this.lbl_Cadastros.Size = new System.Drawing.Size(281, 51);
            this.lbl_Cadastros.TabIndex = 6;
            this.lbl_Cadastros.Text = "CADASTROS";
            // 
            // lbl_Consultas
            // 
            this.lbl_Consultas.AutoSize = true;
            this.lbl_Consultas.Font = new System.Drawing.Font("Goudy Old Style", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Consultas.ForeColor = System.Drawing.Color.Black;
            this.lbl_Consultas.Location = new System.Drawing.Point(259, 235);
            this.lbl_Consultas.Name = "lbl_Consultas";
            this.lbl_Consultas.Size = new System.Drawing.Size(281, 51);
            this.lbl_Consultas.TabIndex = 7;
            this.lbl_Consultas.Text = "CONSULTAS";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 499);
            this.Controls.Add(this.lbl_Consultas);
            this.Controls.Add(this.lbl_Cadastros);
            this.Controls.Add(this.bnt_CS_Estoque);
            this.Controls.Add(this.bnt_CS_Receitas);
            this.Controls.Add(this.bnt_CD_Receitas);
            this.Controls.Add(this.bnt_CD_TipoCozinha);
            this.Controls.Add(this.bnt_CD_Ingredientes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem telasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarReceitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarReceitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarIngredienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarTipoDeCozinhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extraToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultarReceitasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarReceitasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarIngredientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarTipoDeCozinhaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem extraToolStripMenuItem1;
        private System.Windows.Forms.Button bnt_CD_Ingredientes;
        private System.Windows.Forms.Button bnt_CD_TipoCozinha;
        private System.Windows.Forms.Button bnt_CD_Receitas;
        private System.Windows.Forms.Button bnt_CS_Receitas;
        private System.Windows.Forms.Button bnt_CS_Estoque;
        private System.Windows.Forms.Label lbl_Cadastros;
        private System.Windows.Forms.Label lbl_Consultas;
    }
}