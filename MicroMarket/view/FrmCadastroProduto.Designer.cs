namespace MicroMarket
{
    partial class FrmCadastroProduto
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NomeBox = new TextBox();
            labelNome = new Label();
            labelPreco = new Label();
            QuantidadeInicialEstoque_label = new Label();
            Cadastrar = new Button();
            Cancelar = new Button();
            PrecoBox = new NumericUpDown();
            EstoqueInicial = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)PrecoBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EstoqueInicial).BeginInit();
            SuspendLayout();
            // 
            // NomeBox
            // 
            NomeBox.Cursor = Cursors.IBeam;
            NomeBox.Location = new Point(220, 28);
            NomeBox.Multiline = true;
            NomeBox.Name = "NomeBox";
            NomeBox.Size = new Size(125, 34);
            NomeBox.TabIndex = 0;
            NomeBox.TextChanged += NomeBox_TextChanged;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(220, 3);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(107, 20);
            labelNome.TabIndex = 3;
            labelNome.Text = "Nome Produto";
            labelNome.Click += labelNome_Click;
            // 
            // labelPreco
            // 
            labelPreco.AutoSize = true;
            labelPreco.Location = new Point(220, 66);
            labelPreco.Name = "labelPreco";
            labelPreco.Size = new Size(46, 20);
            labelPreco.TabIndex = 4;
            labelPreco.Text = "Preço";
            // 
            // QuantidadeInicialEstoque_label
            // 
            QuantidadeInicialEstoque_label.AutoSize = true;
            QuantidadeInicialEstoque_label.Location = new Point(220, 128);
            QuantidadeInicialEstoque_label.Name = "QuantidadeInicialEstoque_label";
            QuantidadeInicialEstoque_label.Size = new Size(187, 20);
            QuantidadeInicialEstoque_label.TabIndex = 5;
            QuantidadeInicialEstoque_label.Text = "Quantidade Inicial estoque";
            // 
            // Cadastrar
            // 
            Cadastrar.Cursor = Cursors.Hand;
            Cadastrar.DialogResult = DialogResult.OK;
            Cadastrar.Location = new Point(161, 184);
            Cadastrar.Name = "Cadastrar";
            Cadastrar.Size = new Size(246, 29);
            Cadastrar.TabIndex = 6;
            Cadastrar.Text = "Cadastrar";
            Cadastrar.UseVisualStyleBackColor = true;
            Cadastrar.Click += Cadastrar_Click;
            // 
            // Cancelar
            // 
            Cancelar.Cursor = Cursors.Hand;
            Cancelar.DialogResult = DialogResult.Cancel;
            Cancelar.Location = new Point(12, 12);
            Cancelar.Name = "Cancelar";
            Cancelar.Size = new Size(94, 29);
            Cancelar.TabIndex = 7;
            Cancelar.Text = "Cancelar";
            Cancelar.UseVisualStyleBackColor = true;
            Cancelar.Click += Cancelar_Click;
            // 
            // PrecoBox
            // 
            PrecoBox.DecimalPlaces = 2;
            PrecoBox.Location = new Point(220, 89);
            PrecoBox.Maximum = new decimal(new int[] { 276447231, 23283, 0, 0 });
            PrecoBox.Name = "PrecoBox";
            PrecoBox.Size = new Size(125, 27);
            PrecoBox.TabIndex = 8;
            PrecoBox.ThousandsSeparator = true;
            PrecoBox.ValueChanged += PrecoBox_ValueChanged;
            // 
            // EstoqueInicial
            // 
            EstoqueInicial.Location = new Point(220, 151);
            EstoqueInicial.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            EstoqueInicial.Name = "EstoqueInicial";
            EstoqueInicial.Size = new Size(125, 27);
            EstoqueInicial.TabIndex = 9;
            // 
            // FrmCadastroProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 218);
            Controls.Add(EstoqueInicial);
            Controls.Add(PrecoBox);
            Controls.Add(Cancelar);
            Controls.Add(Cadastrar);
            Controls.Add(QuantidadeInicialEstoque_label);
            Controls.Add(labelPreco);
            Controls.Add(labelNome);
            Controls.Add(NomeBox);
            Name = "FrmCadastroProduto";
            Text = "Cadastro de produto";
            Load += FrmCadastroProduto_Load;
            ((System.ComponentModel.ISupportInitialize)PrecoBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)EstoqueInicial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelNome;
        private Label labelPreco;
        private Label QuantidadeInicialEstoque_label;
        private Button Cadastrar;
        private Button Cancelar;
        public TextBox NomeBox;
        public NumericUpDown EstoqueInicial;
        public NumericUpDown PrecoBox;
    }
}
