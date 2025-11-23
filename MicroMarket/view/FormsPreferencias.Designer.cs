namespace MicroMarket.view
{
    partial class FormsPreferencias
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
            chkEstoqueNegativo = new CheckBox();
            Confirmar = new Button();
            Cancelar = new Button();
            chkPrecoZerado = new CheckBox();
            qtdEstoquebaixo = new NumericUpDown();
            labelEstoqueBaixo = new Label();
            ((System.ComponentModel.ISupportInitialize)qtdEstoquebaixo).BeginInit();
            SuspendLayout();
            // 
            // chkEstoqueNegativo
            // 
            chkEstoqueNegativo.Location = new Point(56, 38);
            chkEstoqueNegativo.Name = "chkEstoqueNegativo";
            chkEstoqueNegativo.Size = new Size(292, 30);
            chkEstoqueNegativo.TabIndex = 0;
            chkEstoqueNegativo.Text = "Permite Estoque Negativo?";
            chkEstoqueNegativo.UseVisualStyleBackColor = true;
            chkEstoqueNegativo.CheckedChanged += chkEstoqueNegativo_CheckedChanged;
            // 
            // Confirmar
            // 
            Confirmar.DialogResult = DialogResult.OK;
            Confirmar.Location = new Point(90, 346);
            Confirmar.Name = "Confirmar";
            Confirmar.Size = new Size(206, 29);
            Confirmar.TabIndex = 1;
            Confirmar.Text = "Confirmar";
            Confirmar.UseVisualStyleBackColor = true;
            Confirmar.Click += Confirmar_Click;
            // 
            // Cancelar
            // 
            Cancelar.BackColor = Color.Red;
            Cancelar.DialogResult = DialogResult.Cancel;
            Cancelar.Location = new Point(90, 381);
            Cancelar.Name = "Cancelar";
            Cancelar.Size = new Size(206, 29);
            Cancelar.TabIndex = 2;
            Cancelar.Text = "Cancelar";
            Cancelar.UseVisualStyleBackColor = false;
            Cancelar.Click += Cancelar_Click;
            // 
            // chkPrecoZerado
            // 
            chkPrecoZerado.Location = new Point(56, 88);
            chkPrecoZerado.Name = "chkPrecoZerado";
            chkPrecoZerado.Size = new Size(292, 51);
            chkPrecoZerado.TabIndex = 3;
            chkPrecoZerado.Text = "Permite cadastro de produto com valor zerado?";
            chkPrecoZerado.UseVisualStyleBackColor = true;
            chkPrecoZerado.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // qtdEstoquebaixo
            // 
            qtdEstoquebaixo.Location = new Point(56, 159);
            qtdEstoquebaixo.Name = "qtdEstoquebaixo";
            qtdEstoquebaixo.Size = new Size(46, 27);
            qtdEstoquebaixo.TabIndex = 4;
            qtdEstoquebaixo.ValueChanged += qtdEstoquebaixo_ValueChanged;
            // 
            // labelEstoqueBaixo
            // 
            labelEstoqueBaixo.Location = new Point(108, 154);
            labelEstoqueBaixo.Name = "labelEstoqueBaixo";
            labelEstoqueBaixo.Size = new Size(240, 41);
            labelEstoqueBaixo.TabIndex = 5;
            labelEstoqueBaixo.Text = "Quantidade para considerar estoque baixo";
            labelEstoqueBaixo.Click += labelEstoqueBaixo_Click;
            // 
            // FormsPreferencias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 417);
            Controls.Add(labelEstoqueBaixo);
            Controls.Add(qtdEstoquebaixo);
            Controls.Add(chkPrecoZerado);
            Controls.Add(Cancelar);
            Controls.Add(Confirmar);
            Controls.Add(chkEstoqueNegativo);
            Name = "FormsPreferencias";
            Text = "FormsPreferencias";
            Load += FormsPreferencias_Load;
            ((System.ComponentModel.ISupportInitialize)qtdEstoquebaixo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public CheckBox chkEstoqueNegativo;
        private Button Confirmar;
        private Button Cancelar;
        public CheckBox chkPrecoZerado;
        private NumericUpDown qtdEstoquebaixo;
        private Label labelEstoqueBaixo;
    }
}