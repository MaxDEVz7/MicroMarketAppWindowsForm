namespace MicroMarket
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelLateral = new Panel();
            EntrarEstoque = new Button();
            Baixar = new Button();
            estoqueBaixo = new CheckBox();
            filters = new Label();
            linkLabel1 = new LinkLabel();
            preferencias = new Button();
            gridProdutos = new DataGridView();
            label1 = new Label();
            AddProduct = new Button();
            exibeDetalhes = new Button();
            deleteProduto = new Button();
            pesquisaBox = new TextBox();
            pictureBox1 = new PictureBox();
            panelLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridProdutos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelLateral
            // 
            panelLateral.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelLateral.BackColor = SystemColors.GradientInactiveCaption;
            panelLateral.Controls.Add(EntrarEstoque);
            panelLateral.Controls.Add(Baixar);
            panelLateral.Controls.Add(estoqueBaixo);
            panelLateral.Controls.Add(filters);
            panelLateral.Controls.Add(linkLabel1);
            panelLateral.Controls.Add(preferencias);
            panelLateral.Location = new Point(-1, -1);
            panelLateral.Name = "panelLateral";
            panelLateral.Size = new Size(224, 512);
            panelLateral.TabIndex = 0;
            panelLateral.Paint += panelLateral_Paint;
            // 
            // EntrarEstoque
            // 
            EntrarEstoque.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            EntrarEstoque.Cursor = Cursors.Hand;
            EntrarEstoque.Location = new Point(13, 360);
            EntrarEstoque.Name = "EntrarEstoque";
            EntrarEstoque.Size = new Size(192, 29);
            EntrarEstoque.TabIndex = 10;
            EntrarEstoque.Text = "Entrar Estoque";
            EntrarEstoque.UseVisualStyleBackColor = true;
            EntrarEstoque.Click += EntrarEstoque_Click;
            // 
            // Baixar
            // 
            Baixar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Baixar.Cursor = Cursors.Hand;
            Baixar.Location = new Point(13, 300);
            Baixar.Name = "Baixar";
            Baixar.Size = new Size(192, 29);
            Baixar.TabIndex = 9;
            Baixar.Text = "Baixar";
            Baixar.UseVisualStyleBackColor = true;
            Baixar.Click += Baixar_Click;
            // 
            // estoqueBaixo
            // 
            estoqueBaixo.AutoSize = true;
            estoqueBaixo.Location = new Point(13, 64);
            estoqueBaixo.Name = "estoqueBaixo";
            estoqueBaixo.Size = new Size(125, 24);
            estoqueBaixo.TabIndex = 8;
            estoqueBaixo.Text = "Estoque baixo";
            estoqueBaixo.UseVisualStyleBackColor = true;
            estoqueBaixo.CheckedChanged += estoqueBaixo_CheckedChanged;
            // 
            // filters
            // 
            filters.Location = new Point(13, 17);
            filters.Name = "filters";
            filters.Size = new Size(192, 25);
            filters.TabIndex = 6;
            filters.Text = "Filtros";
            filters.TextAlign = ContentAlignment.TopCenter;
            filters.Click += filtros_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            linkLabel1.Location = new Point(13, 483);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(192, 25);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://github.com/MaxDEVz7";
            linkLabel1.LinkClicked += linkGitHub_Click;
            // 
            // preferencias
            // 
            preferencias.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            preferencias.Cursor = Cursors.Hand;
            preferencias.Location = new Point(13, 423);
            preferencias.Name = "preferencias";
            preferencias.Size = new Size(192, 29);
            preferencias.TabIndex = 4;
            preferencias.Text = "Preferências";
            preferencias.UseVisualStyleBackColor = true;
            preferencias.Click += preferencias_Click;
            // 
            // gridProdutos
            // 
            gridProdutos.AllowUserToOrderColumns = true;
            gridProdutos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridProdutos.BackgroundColor = SystemColors.Control;
            gridProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridProdutos.GridColor = SystemColors.Control;
            gridProdutos.Location = new Point(229, 39);
            gridProdutos.Name = "gridProdutos";
            gridProdutos.RowHeadersWidth = 51;
            gridProdutos.Size = new Size(712, 472);
            gridProdutos.TabIndex = 1;
            gridProdutos.CellContentClick += gridProducts;
            // 
            // label1
            // 
            label1.Location = new Point(229, -1);
            label1.Name = "label1";
            label1.Size = new Size(712, 37);
            label1.TabIndex = 2;
            label1.Text = "MicroMarket Stock";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += title_Click;
            // 
            // AddProduct
            // 
            AddProduct.BackgroundImageLayout = ImageLayout.None;
            AddProduct.Cursor = Cursors.Hand;
            AddProduct.Image = (Image)resources.GetObject("AddProduct.Image");
            AddProduct.Location = new Point(229, 4);
            AddProduct.Name = "AddProduct";
            AddProduct.Size = new Size(48, 32);
            AddProduct.TabIndex = 3;
            AddProduct.UseVisualStyleBackColor = true;
            AddProduct.Click += adicionarProduto_Click;
            // 
            // exibeDetalhes
            // 
            exibeDetalhes.Cursor = Cursors.Hand;
            exibeDetalhes.Image = (Image)resources.GetObject("exibeDetalhes.Image");
            exibeDetalhes.Location = new Point(283, 4);
            exibeDetalhes.Name = "exibeDetalhes";
            exibeDetalhes.Size = new Size(51, 32);
            exibeDetalhes.TabIndex = 4;
            exibeDetalhes.UseVisualStyleBackColor = true;
            exibeDetalhes.Click += verDetalhesProduto_Click;
            // 
            // deleteProduto
            // 
            deleteProduto.Cursor = Cursors.Hand;
            deleteProduto.Image = (Image)resources.GetObject("deleteProduto.Image");
            deleteProduto.Location = new Point(340, 4);
            deleteProduto.Name = "deleteProduto";
            deleteProduto.Size = new Size(42, 32);
            deleteProduto.TabIndex = 5;
            deleteProduto.UseVisualStyleBackColor = true;
            deleteProduto.Click += deleteProduto_Click;
            // 
            // pesquisaBox
            // 
            pesquisaBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pesquisaBox.Cursor = Cursors.IBeam;
            pesquisaBox.Location = new Point(727, 7);
            pesquisaBox.Name = "pesquisaBox";
            pesquisaBox.Size = new Size(202, 27);
            pesquisaBox.TabIndex = 6;
            pesquisaBox.TextChanged += pesquisaBox_TextChanged;
            pesquisaBox.Enter += pesquisaBox_Enter;
            pesquisaBox.Leave += pesquisaBox_Leave;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = Color.White;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(902, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 511);
            Controls.Add(pictureBox1);
            Controls.Add(pesquisaBox);
            Controls.Add(deleteProduto);
            Controls.Add(exibeDetalhes);
            Controls.Add(AddProduct);
            Controls.Add(label1);
            Controls.Add(gridProdutos);
            Controls.Add(panelLateral);
            Name = "Form1";
            Text = "MicroMarketStock";
            Load += Form1_Load;
            panelLateral.ResumeLayout(false);
            panelLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridProdutos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelLateral;
        private DataGridView gridProdutos;
        private Label label1;
        private Button AddProduct;
        private Button preferencias;
        private Button exibeDetalhes;
        private LinkLabel linkLabel1;
        private Button deleteProduto;
        private Label filters;
        private CheckBox estoqueBaixo;
        private Button EntrarEstoque;
        private Button Baixar;
        private TextBox pesquisaBox;
        private PictureBox pictureBox1;
    }
}
