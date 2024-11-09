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
    public partial class frmSelecionarResponsavel : Form
    {
        private readonly ResponsavelController _responsavelController;
        public Responsavel responsavelSelecao;
        public frmSelecionarResponsavel(bool ExibirBotaoSelecionar = false)
        {
            InitializeComponent();

            _responsavelController = new ResponsavelController();

            CarregarDadosResponsavel();

            btnSelecionar.Visible = ExibirBotaoSelecionar;
        }

        private void CarregarDadosResponsavel()
        {
            try
            {
                DataTable tabela = _responsavelController.ObterTodosResponsaveis();

                dgvRegistros.AutoGenerateColumns = false;

                dgvRegistros.Rows.Clear();

                foreach (DataRow row in tabela.Rows)
                {
                    Responsavel responsavel = new Responsavel
                    {
                        Id = (int)row["ID"],
                        Nome = (string)row["Nome"],
                        CPF = (string)row["CPF"],
                        Telefone = (string)row["Telefone"],
                        Parentesco = (string)row["Parentesco"]
                    };

                    int index = dgvRegistros.Rows.Add(
                        responsavel.Id,
                        responsavel.Nome,
                        responsavel.CPF,
                        responsavel.Telefone,
                        responsavel.Parentesco
                    );

                    // Associar o objeto Convenio à linha
                    dgvRegistros.Rows[index].Tag = responsavel;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do responsável: " + ex.Message);
            }
        }
            private Responsavel RecuperarResponsavel()
            {
                if (dgvRegistros.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhum registro selecionado.",
                        "Informação", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return null;
                }
                else
                {
                    // Acessa o Convenio diretamente do Tag da linha selecionada
                    return dgvRegistros.SelectedRows[0].Tag as Responsavel;
                }
            }

            private void btnSelecionar_Click(object sender, EventArgs e)
            {
                Selecionar();
            }

            private void Selecionar()
            {
                responsavelSelecao = RecuperarResponsavel();
                if (responsavelSelecao != null)
                    this.DialogResult = DialogResult.OK;
            }

            private void dgvRegistros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
            {
                // Verifica se a linha clicada é válida (não é uma linha em branco)
                if (e.RowIndex >= 0 && e.RowIndex < dgvRegistros.Rows.Count)
                {
                    // Verifica se a célula clicada contém dados (no caso, a primeira célula que é o ID)
                    var row = dgvRegistros.Rows[e.RowIndex];
                    if (row.Cells[0].Value != null) // Supondo que o ID esteja na primeira coluna
                    {
                        // Se a célula contiver dados, seleciona o convênio
                        responsavelSelecao = row.Tag as Responsavel;

                        if (responsavelSelecao != null)
                        {
                            this.DialogResult = DialogResult.OK; // Fecha o formulário e retorna o convênio selecionado
                        }
                    }
                    else
                    {
                        // Caso o clique tenha sido no "vácuo", não faça nada
                        // Opcional: mostrar uma mensagem ou apenas ignorar
                        MessageBox.Show("Clique em uma linha com dados válidos.");
                    }
                }
            }
        }
    }
