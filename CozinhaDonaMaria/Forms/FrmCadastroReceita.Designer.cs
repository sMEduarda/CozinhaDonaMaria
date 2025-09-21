namespace CozinhaDonaMaria.Forms
{
    partial class FrmCadastroReceita
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_NomeReceita = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.LBL_Titulo = new System.Windows.Forms.Label();
            this.txtModoPreparo = new System.Windows.Forms.TextBox();
            this.lbl_ModoPreparo = new System.Windows.Forms.Label();
            this.lbl_TipoCozinha = new System.Windows.Forms.Label();
            this.cmbTipoCozinha = new System.Windows.Forms.ComboBox();
            this.listBoxIngredientes = new System.Windows.Forms.ListBox();
            this.lbl_Ingredientes = new System.Windows.Forms.Label();
            this.bnt_Salvar_Receita = new System.Windows.Forms.Button();
            this.cmbIngrediente = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_NomeReceita
            // 
            this.lbl_NomeReceita.AutoSize = true;
            this.lbl_NomeReceita.Font = new System.Drawing.Font("Goudy Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NomeReceita.Location = new System.Drawing.Point(31, 112);
            this.lbl_NomeReceita.Name = "lbl_NomeReceita";
            this.lbl_NomeReceita.Size = new System.Drawing.Size(172, 27);
            this.lbl_NomeReceita.TabIndex = 0;
            this.lbl_NomeReceita.Text = "Nome da Receita";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(12, 142);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(215, 30);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.txt_NomeReceita_TextChanged);
            // 
            // LBL_Titulo
            // 
            this.LBL_Titulo.AutoSize = true;
            this.LBL_Titulo.Font = new System.Drawing.Font("Goudy Old Style", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Titulo.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.LBL_Titulo.Location = new System.Drawing.Point(116, 27);
            this.LBL_Titulo.Name = "LBL_Titulo";
            this.LBL_Titulo.Size = new System.Drawing.Size(539, 51);
            this.LBL_Titulo.TabIndex = 3;
            this.LBL_Titulo.Text = "CADASTRO DE RECEITAS";
            // 
            // txtModoPreparo
            // 
            this.txtModoPreparo.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModoPreparo.Location = new System.Drawing.Point(12, 215);
            this.txtModoPreparo.Multiline = true;
            this.txtModoPreparo.Name = "txtModoPreparo";
            this.txtModoPreparo.Size = new System.Drawing.Size(497, 273);
            this.txtModoPreparo.TabIndex = 5;
            // 
            // lbl_ModoPreparo
            // 
            this.lbl_ModoPreparo.AutoSize = true;
            this.lbl_ModoPreparo.Font = new System.Drawing.Font("Goudy Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ModoPreparo.Location = new System.Drawing.Point(12, 185);
            this.lbl_ModoPreparo.Name = "lbl_ModoPreparo";
            this.lbl_ModoPreparo.Size = new System.Drawing.Size(178, 27);
            this.lbl_ModoPreparo.TabIndex = 4;
            this.lbl_ModoPreparo.Text = "Modo de Preparo";
            // 
            // lbl_TipoCozinha
            // 
            this.lbl_TipoCozinha.AutoSize = true;
            this.lbl_TipoCozinha.Font = new System.Drawing.Font("Goudy Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TipoCozinha.Location = new System.Drawing.Point(300, 110);
            this.lbl_TipoCozinha.Name = "lbl_TipoCozinha";
            this.lbl_TipoCozinha.Size = new System.Drawing.Size(168, 27);
            this.lbl_TipoCozinha.TabIndex = 6;
            this.lbl_TipoCozinha.Text = "Tipo de Cozinha";
            // 
            // cmbTipoCozinha
            // 
            this.cmbTipoCozinha.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoCozinha.FormattingEnabled = true;
            this.cmbTipoCozinha.Location = new System.Drawing.Point(278, 140);
            this.cmbTipoCozinha.Name = "cmbTipoCozinha";
            this.cmbTipoCozinha.Size = new System.Drawing.Size(215, 32);
            this.cmbTipoCozinha.TabIndex = 7;
            // 
            // listBoxIngredientes
            // 
            this.listBoxIngredientes.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxIngredientes.FormattingEnabled = true;
            this.listBoxIngredientes.ItemHeight = 24;
            this.listBoxIngredientes.Location = new System.Drawing.Point(527, 196);
            this.listBoxIngredientes.Name = "listBoxIngredientes";
            this.listBoxIngredientes.Size = new System.Drawing.Size(248, 292);
            this.listBoxIngredientes.TabIndex = 8;
            // 
            // lbl_Ingredientes
            // 
            this.lbl_Ingredientes.AutoSize = true;
            this.lbl_Ingredientes.Font = new System.Drawing.Font("Goudy Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ingredientes.Location = new System.Drawing.Point(540, 110);
            this.lbl_Ingredientes.Name = "lbl_Ingredientes";
            this.lbl_Ingredientes.Size = new System.Drawing.Size(212, 27);
            this.lbl_Ingredientes.TabIndex = 9;
            this.lbl_Ingredientes.Text = "Lista de Ingredientes ";
            this.lbl_Ingredientes.Click += new System.EventHandler(this.lbl_Ingredientes_Click);
            // 
            // bnt_Salvar_Receita
            // 
            this.bnt_Salvar_Receita.BackColor = System.Drawing.Color.LimeGreen;
            this.bnt_Salvar_Receita.Font = new System.Drawing.Font("Goudy Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_Salvar_Receita.ForeColor = System.Drawing.Color.Honeydew;
            this.bnt_Salvar_Receita.Location = new System.Drawing.Point(265, 537);
            this.bnt_Salvar_Receita.Name = "bnt_Salvar_Receita";
            this.bnt_Salvar_Receita.Size = new System.Drawing.Size(258, 36);
            this.bnt_Salvar_Receita.TabIndex = 11;
            this.bnt_Salvar_Receita.Text = "Salvar Receita";
            this.bnt_Salvar_Receita.UseVisualStyleBackColor = false;
            this.bnt_Salvar_Receita.Click += new System.EventHandler(this.bnt_Salvar_Receita_Click);
            // 
            // cmbIngrediente
            // 
            this.cmbIngrediente.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIngrediente.FormattingEnabled = true;
            this.cmbIngrediente.Location = new System.Drawing.Point(537, 140);
            this.cmbIngrediente.Name = "cmbIngrediente";
            this.cmbIngrediente.Size = new System.Drawing.Size(215, 32);
            this.cmbIngrediente.TabIndex = 12;
            // 
            // FrmCadastroReceita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 598);
            this.Controls.Add(this.cmbIngrediente);
            this.Controls.Add(this.bnt_Salvar_Receita);
            this.Controls.Add(this.lbl_Ingredientes);
            this.Controls.Add(this.listBoxIngredientes);
            this.Controls.Add(this.cmbTipoCozinha);
            this.Controls.Add(this.lbl_TipoCozinha);
            this.Controls.Add(this.txtModoPreparo);
            this.Controls.Add(this.lbl_ModoPreparo);
            this.Controls.Add(this.LBL_Titulo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbl_NomeReceita);
            this.Name = "FrmCadastroReceita";
            this.Text = "FrmCadastroReceita";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_NomeReceita;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label LBL_Titulo;
        private System.Windows.Forms.TextBox txtModoPreparo;
        private System.Windows.Forms.Label lbl_ModoPreparo;
        private System.Windows.Forms.Label lbl_TipoCozinha;
        private System.Windows.Forms.ComboBox cmbTipoCozinha;
        private System.Windows.Forms.ListBox listBoxIngredientes;
        private System.Windows.Forms.Label lbl_Ingredientes;
        private System.Windows.Forms.Button bnt_Salvar_Receita;
        private System.Windows.Forms.ComboBox cmbIngrediente;
    }
}