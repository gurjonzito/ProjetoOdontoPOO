using ProjetoOdontoPOO.Models;
using System;
using System.Windows.Forms;

namespace ProjetoOdontoPOO.Views
{
    public partial class frmCadPagamento : Form
    {
        private readonly PagamentoController _pagamentoController;
        Paciente pacientePagamento;

        public frmCadPagamento()
        {
            InitializeComponent();
            _pagamentoController = new PagamentoController();
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            PesquisarPaciente();
        }

        private void PesquisarPaciente()
        {
            frmSelecionarPaciente frm = new frmSelecionarPaciente(true);
            DialogResult dialogResult = frm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                pacientePagamento = frm.pacienteSelecao;

                txtPacientePag.Text = pacientePagamento.Nome;
            }
        }

        private void btnSalvarPagamento_Click(object sender, EventArgs e)
        {
            try
            {
                var pagamento = CriarPagamento();

                string mensagem = _pagamentoController.InserirPagamento(pagamento);
                MessageBox.Show(mensagem);

                if (mensagem.Contains("Pagamento registrado com sucesso!"))
                {
                    LimparCampos();
                    txtPacientePag.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private Pagamento CriarPagamento()
        {
            decimal valorPago;
            if (!decimal.TryParse(txtValorPag.Text, out valorPago))
            {
                MessageBox.Show("O valor inserido não é válido. Por favor, insira um valor numérico.");
                return null;
            }

            return new Pagamento
            {
                Paciente = pacientePagamento,
                DataPagamento = dtpDataPag.Value,
                ValorPago = valorPago,
                PagamentoStatus = cbStatusPag.Text,
                MetodoPagamento = cbMetodoPag.Text,
            };
        }

        private void ValidarEntradaNumerica(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtValorPag_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarEntradaNumerica(e);
        }

        private void LimparCampos()
        {
            txtPacientePag.Clear();
            txtValorPag.Clear();

            dtpDataPag.Value = DateTime.Now;

            cbMetodoPag.SelectedIndex = -1;
            cbStatusPag.SelectedIndex = -1;
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
