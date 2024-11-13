using ProjetoOdontoPOO.Models;
using System;
using System.Windows.Forms;

namespace ProjetoOdontoPOO.Views
{
    public partial class frmEditarPagamento : Form
    {
        private readonly PagamentoController _pagamentoController;
        private int _pagamentoId;
        Paciente pacientePagamento;

        public frmEditarPagamento(int pagamentoId)
        {
            InitializeComponent();

            _pagamentoId = pagamentoId;

            _pagamentoController = new PagamentoController();

            CarregarDadosPagamento();
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

        private void CarregarDadosPagamento()
        {
            Pagamento pagamento = _pagamentoController.ObterPagamentoPorId(_pagamentoId);

            if (pagamento != null)
            {
                txtPacientePag.Text = pagamento.Paciente.Nome;
                dtpDataPag.Value = pagamento.DataPagamento;
                txtValorPag.Text = pagamento.ValorPago.ToString();
                cbStatusPag.Text = pagamento.PagamentoStatus;
                cbMetodoPag.Text = pagamento.MetodoPagamento;
            }
            else
            {
                MessageBox.Show($"Pagamento com ID {_pagamentoId} não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvarPagamento_Click(object sender, EventArgs e)
        {
            string pacienteNome = txtPacientePag.Text;
            DateTime data = dtpDataPag.Value;
            if (!decimal.TryParse(txtValorPag.Text, out decimal valor) || valor <= 0)
            {
                MessageBox.Show("Valor inválido. Por favor, insira um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string status = cbStatusPag.Text;
            string metodo = cbMetodoPag.Text;

            Paciente paciente = new Paciente { Nome = pacienteNome };

            Pagamento pagamento = new Pagamento
            {
                Paciente = paciente,
                DataPagamento = data,
                ValorPago = valor,
                PagamentoStatus = status,
                MetodoPagamento = metodo,
            };

            bool atualizado = _pagamentoController.AtualizarPagamento(_pagamentoId, pagamento);

            if (atualizado)
            {
                MessageBox.Show("Pagamento atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar o pagamento.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidarEntradaNumerica(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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

        private void txtValorPag_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarEntradaNumerica(e);
        }
    }
}
