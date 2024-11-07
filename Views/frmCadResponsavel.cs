using ProjetoOdontoPOO.Controllers;
using ProjetoOdontoPOO.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoOdontoPOO.Views
{
    public partial class frmCadResponsavel : Form
    {
        private readonly ResponsavelController _responsavelController;

        public frmCadResponsavel()
        {
            InitializeComponent();

            _responsavelController = new ResponsavelController();
        }

        private void btnSalvarResponsavel_Click(object sender, EventArgs e)
        {
            var responsavel = CriarResponsavel();

            string mensagem = _responsavelController.InserirResponsavel(responsavel);
            MessageBox.Show(mensagem);

            if (mensagem.Contains("Responsável cadastrado com sucesso!"))
            {
                LimparCampos();
                txtNomeRes.Focus();
            }
        }

        private Responsavel CriarResponsavel()
        {
            return new Responsavel
            {
                Nome = txtNomeRes.Text,
                DataNascimento = dtpDataRes.Value,
                Idade = int.TryParse(txtIdadeRes.Text, out int idade) ? idade : 0,
                CPF = txtCPFRes.Text.Replace(".", "").Replace("-", "").Replace(",", ""),
                Sexo = cbSexoRes.Text,
                Telefone = txtTelefoneRes.Text,
                Parentesco = txtParentescoRes.Text,
            };
        }

        private void dtpDataRes_Leave(object sender, EventArgs e)
        {
            txtIdadeRes.Text = CalcularIdade(dtpDataRes.Value).ToString();
        }

        private int CalcularIdade(DateTime dataNascimento)
        {
            DateTime hoje = DateTime.Now;
            int idade = hoje.Year - dataNascimento.Year;

            if (hoje < dataNascimento.AddYears(idade))
            {
                idade--;
            }

            return idade;
        }

        private void btnLimparResponsavel_Click(object sender, EventArgs e)
        {
            LimparCampos();
            txtNomeRes.Focus();
        }

        private void ValidarEntradaNumerica(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtTelefoneRes_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarEntradaNumerica(e);
        }

        private void LimparCampos()
        {
            txtNomeRes.Clear();
            txtIdadeRes.Clear();
            txtCPFRes.Clear();
            txtTelefoneRes.Clear();
            txtParentescoRes.Clear();

            cbSexoRes.SelectedIndex = -1;

            dtpDataRes.Value = DateTime.Now;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.icons8_fechar_janela_32;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.icons8_close_window_32_outro;
        }
    }
}
