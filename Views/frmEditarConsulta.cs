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
    public partial class frmEditarConsulta : Form
    {
        private readonly ConsultaController _consultaController;
        private int _consultaId;
        Paciente pacienteConsulta;
        Dentista dentistaConsulta;

        public frmEditarConsulta(int consultaId)
        {
            InitializeComponent();

            _consultaId = consultaId;

            _consultaController = new ConsultaController();

            CarregarDadosConsulta();
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            PesquisarPaciente();
        }

        private void btnDentista_Click(object sender, EventArgs e)
        {
            PesquisarDentista();
        }

        private void PesquisarPaciente()
        {
            frmSelecionarPaciente frm = new frmSelecionarPaciente(true);
            DialogResult dialogResult = frm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                pacienteConsulta = frm.pacienteSelecao;

                txtPaciente.Text = pacienteConsulta.Nome;
            }
        }

        private void PesquisarDentista()
        {
            frmSelecionarDentista frm = new frmSelecionarDentista(true);
            DialogResult dialogResult = frm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                dentistaConsulta = frm.dentistaSelecao;

                txtDentista.Text = dentistaConsulta.Nome;
            }
        }

        private void CarregarDadosConsulta()
        {
            Consulta consulta = _consultaController.ObterConsultaPorId(_consultaId);

            if (consulta != null)
            {
                dtpDataConsulta.Value = consulta.DataConsulta;
                txtObsConsulta.Text = consulta.Observacoes;
                txtPaciente.Text = consulta.Paciente.Nome;
                txtDentista.Text = consulta.Dentista.Nome;
            }
            else
            {
                MessageBox.Show($"Consulta com ID {_consultaId} não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvarConsulta_Click(object sender, EventArgs e)
        {
            DateTime data = dtpDataConsulta.Value;
            string obs = txtObsConsulta.Text;
            string pacienteNome = txtPaciente.Text;
            string dentistaNome = txtDentista.Text;

            Paciente paciente = new Paciente { Nome = pacienteNome };
            Dentista dentista = new Dentista { Nome = dentistaNome };

            Consulta consulta = new Consulta
            {
                DataConsulta = data,
                Observacoes = obs,
                Paciente = paciente,
                Dentista = dentista,
            };

            bool atualizado = _consultaController.AtualizarConsulta(_consultaId, consulta);

            if (atualizado)
            {
                MessageBox.Show("Consulta atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar a consulta.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
