using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroMarket.view
{
    public partial class FormsPreferencias : Form
    {
        public FormsPreferencias()
        {
            InitializeComponent();
        }

        private void chkEstoqueNegativo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            {
                // 1. Atualiza a configuração com o que o usuário marcou
                Properties.Settings.Default.PermitirEstoqueNegativo = chkEstoqueNegativo.Checked;
                Properties.Settings.Default.PermitirPreçoZerado = chkPrecoZerado.Checked;
                Properties.Settings.Default.ValorEstoqueBaixo = (int)qtdEstoquebaixo.Value;
                // Salva persistente no disco
                Properties.Settings.Default.Save();

                MessageBox.Show("Preferências salvas com sucesso!");
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {

        }

        private void FormsPreferencias_Load(object sender, EventArgs e)
        {
            // Ao abrir a tela, marca o checkbox conforme o que está default
            chkEstoqueNegativo.Checked = Properties.Settings.Default.PermitirEstoqueNegativo;
            chkPrecoZerado.Checked = Properties.Settings.Default.PermitirPreçoZerado;
            qtdEstoquebaixo.Value = Properties.Settings.Default.ValorEstoqueBaixo;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void qtdEstoquebaixo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void labelEstoqueBaixo_Click(object sender, EventArgs e)
        {

        }
    }
}
