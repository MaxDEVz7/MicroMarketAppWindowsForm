namespace MicroMarket.view
{
    partial class FrmEntrarEstoque
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
            label2 = new Label();
            produtoSelecionado = new Label();
            Confirmar = new Button();
            Cancelar = new Button();
            numQtd = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numQtd).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Location = new Point(139, 126);
            label2.Name = "label2";
            label2.Size = new Size(145, 24);
            label2.TabIndex = 1;
            label2.Text = "Quantidade á entrar";
            label2.Click += label2_Click;
            // 
            // produtoSelecionado
            // 
            produtoSelecionado.Location = new Point(139, 73);
            produtoSelecionado.Name = "produtoSelecionado";
            produtoSelecionado.Size = new Size(145, 44);
            produtoSelecionado.TabIndex = 2;
            // 
            // Confirmar
            // 
            Confirmar.DialogResult = DialogResult.OK;
            Confirmar.Location = new Point(127, 197);
            Confirmar.Name = "Confirmar";
            Confirmar.Size = new Size(176, 29);
            Confirmar.TabIndex = 3;
            Confirmar.Text = "Confirmar";
            Confirmar.UseVisualStyleBackColor = true;
            // 
            // Cancelar
            // 
            Cancelar.DialogResult = DialogResult.Cancel;
            Cancelar.Location = new Point(12, 12);
            Cancelar.Name = "Cancelar";
            Cancelar.Size = new Size(161, 29);
            Cancelar.TabIndex = 4;
            Cancelar.Text = "Cancelar";
            Cancelar.UseVisualStyleBackColor = true;
            // 
            // numQtd
            // 
            numQtd.Location = new Point(139, 153);
            numQtd.Maximum = new decimal(new int[] { -1530494977, 232830, 0, 0 });
            numQtd.Name = "numQtd";
            numQtd.Size = new Size(150, 27);
            numQtd.TabIndex = 5;
            numQtd.ValueChanged += numQtd_ValueChanged;
            // 
            // FrmEntrarEstoque
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 238);
            Controls.Add(numQtd);
            Controls.Add(Cancelar);
            Controls.Add(Confirmar);
            Controls.Add(produtoSelecionado);
            Controls.Add(label2);
            Name = "FrmEntrarEstoque";
            Text = "Entrada no Estoque";
            ((System.ComponentModel.ISupportInitialize)numQtd).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Button Confirmar;
        private Button Cancelar;
        public Label produtoSelecionado;
        public NumericUpDown numQtd;
    }
}