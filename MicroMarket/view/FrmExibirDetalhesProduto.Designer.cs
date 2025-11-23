namespace MicroMarket
{
    partial class FrmExibirDetalhesProduto
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
            Cadastrar = new Button();
            Cancelar = new Button();
            PrecoBox = new NumericUpDown();
            atencaoLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)PrecoBox).BeginInit();
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
            // Cadastrar
            // 
            Cadastrar.Cursor = Cursors.Hand;
            Cadastrar.DialogResult = DialogResult.OK;
            Cadastrar.Location = new Point(161, 184);
            Cadastrar.Name = "Cadastrar";
            Cadastrar.Size = new Size(246, 29);
            Cadastrar.TabIndex = 6;
            Cadastrar.Text = "Salvar";
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
            // atencaoLabel
            // 
            atencaoLabel.ForeColor = Color.Red;
            atencaoLabel.Location = new Point(182, 135);
            atencaoLabel.Name = "atencaoLabel";
            atencaoLabel.Size = new Size(208, 46);
            atencaoLabel.TabIndex = 9;
            atencaoLabel.Text = "Atenção, você está alterando um registro.";
            // 
            // FrmExibirDetalhesProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 218);
            Controls.Add(atencaoLabel);
            Controls.Add(PrecoBox);
            Controls.Add(Cancelar);
            Controls.Add(Cadastrar);
            Controls.Add(labelPreco);
            Controls.Add(labelNome);
            Controls.Add(NomeBox);
            Name = "FrmExibirDetalhesProduto";
            Text = "Detalhes do produto";
            Load += FrmCadastroProduto_Load;
            ((System.ComponentModel.ISupportInitialize)PrecoBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelNome;
        private Label labelPreco;
        private Button Cadastrar;
        private Button Cancelar;
        public TextBox NomeBox;
        public NumericUpDown PrecoBox;
        private Label atencaoLabel;
    }
}
