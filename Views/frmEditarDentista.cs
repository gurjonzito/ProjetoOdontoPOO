﻿using ProjetoOdontoPOO.Controllers;
using ProjetoOdontoPOO.Models;
using System;
using System.Windows.Forms;

namespace ProjetoOdontoPOO.Views
{
    public partial class frmEditarDentista : Form
    {
        private readonly DentistaController _dentistaController;
        private int _dentistaId;

        public frmEditarDentista(int dentistaId)
        {
            InitializeComponent();

            _dentistaId = dentistaId;

            _dentistaController = new DentistaController();

            CarregarDadosDentista();
        }

        private void CarregarDadosDentista()
        {
            Dentista dentista = _dentistaController.ObterDentistaPorId(_dentistaId);

            if (dentista != null)
            {
                txtNomeDentista.Text = dentista.Nome;
                txtCRMDentista.Text = dentista.CRM;
                cbEstadoDentista.Text = dentista.Estado;
                txtEspDentista.Text = dentista.Especialidade;
                txtTelefoneDentista.Text = dentista.Telefone;
            }
            else
            {
                MessageBox.Show($"Dentista com ID {_dentistaId} não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvarDentista_Click(object sender, EventArgs e)
        {
            // Coleta os dados do paciente
            string nome = txtNomeDentista.Text;
            string crm = txtCRMDentista.Text;
            string estado = cbEstadoDentista.Text;
            string telefone = txtTelefoneDentista.Text;
            string especialidade = txtEspDentista.Text;

            // Cria o objeto de Paciente
            Dentista dentista = new Dentista
            {
                Nome = nome,
                CRM = crm,
                Estado = estado,
                Telefone = telefone,
                Especialidade = especialidade,
            };

            // Chama o método de atualização com os objetos Paciente e Endereço
            bool atualizado = _dentistaController.AtualizarDentista(_dentistaId, dentista);

            // Exibe o resultado
            if (atualizado)
            {
                MessageBox.Show("Dentista atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar o dentista.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimparDentista_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            // Limpar campos de texto
            txtNomeDentista.Clear();
            txtCRMDentista.Clear();
            txtEspDentista.Clear();
            txtTelefoneDentista.Clear();

            // Resetar ComboBoxes
            cbEstadoDentista.SelectedIndex = -1;
        }
    }
}
