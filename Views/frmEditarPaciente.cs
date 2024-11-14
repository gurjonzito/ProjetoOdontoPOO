using ProjetoOdontoPOO.Controllers;
using ProjetoOdontoPOO.Models;
using System;
using System.Windows.Forms;

namespace ProjetoOdontoPOO.Views
{
    public partial class frmEditarPaciente : Form
    {
        private readonly PacienteController _pacienteController;
        private readonly EnderecoController _enderecoController;
        private readonly ConvenioController _convenioController;
        private readonly ResponsavelController _responsavelController;
        private int _pacienteId;
        private bool _modoVisualizacao;

        Convenio convenioPaciente;
        Responsavel responsavelPaciente;

        public frmEditarPaciente(int pacienteId, bool modoVisualizacao = false)
        {
            InitializeComponent();
            _pacienteId = pacienteId;

            _modoVisualizacao = modoVisualizacao;

            _pacienteController = new PacienteController();
            _enderecoController = new EnderecoController();
            _convenioController = new ConvenioController();
            _responsavelController = new ResponsavelController();

            CarregarComboBoxes();
            CarregarDadosPaciente();

            if (_modoVisualizacao)
            {
                DesabilitarCampos();
            }
        }

        private void CarregarComboBoxes()
        {
            cbAtivoInativo.Items.Clear();
            cbAtivoInativo.Items.Add("Ativo");
            cbAtivoInativo.Items.Add("Inativo");
        }

        private void CarregarDadosPaciente()
        {
            // Recupera os dados do paciente
            Paciente paciente = _pacienteController.ObterPacientePorId(_pacienteId);
            Endereco endereco = _enderecoController.ObterDadosEnderecoPorId(_pacienteId);

            if (paciente != null)
            {
                // Preencher os campos de texto do paciente
                txtNomePaciente.Text = paciente.Nome;
                dtpDataPaciente.Value = paciente.DataNascimento;
                txtIdadePaciente.Text = paciente.Idade.ToString();
                txtCPFPaciente.Text = paciente.CPF;
                cbSexoPaciente.Text = paciente.Sexo;
                txtTelefonePaciente.Text = paciente.Telefone;
                txtEmailPaciente.Text = paciente.Email;

                // Carregar nome do Convênio a partir do ID
                if (paciente.Convenio != null && paciente.Convenio.Id > 0)
                {
                    // Verifica se o convênio existe e carrega o nome
                    Convenio convenio = _convenioController.ObterConvenioPorId(paciente.Convenio.Id);
                    if (convenio != null)
                    {
                        txtConvenioPaciente.Text = convenio.Nome;
                        convenioPaciente = convenio; // Armazena o convênio selecionado
                    }
                    else
                    {
                        txtConvenioPaciente.Text = "Sem Convênio";
                        convenioPaciente = null; // Caso o convênio não exista, mantém como null
                    }
                }
                else
                {
                    txtConvenioPaciente.Text = "Sem Convênio";
                    convenioPaciente = null; // Sem convênio
                }

                // Carregar nome do Responsável a partir do ID
                if (paciente.Responsavel != null && paciente.Responsavel.Id > 0)
                {
                    // Verifica se o responsável existe e carrega o nome
                    Responsavel responsavel = _responsavelController.ObterResponsavelPorId(paciente.Responsavel.Id);
                    if (responsavel != null)
                    {
                        txtResponsavelPaciente.Text = responsavel.Nome;
                        responsavelPaciente = responsavel; // Armazena o responsável selecionado
                    }
                    else
                    {
                        txtResponsavelPaciente.Text = "Sem Responsável";
                        responsavelPaciente = null; // Caso o responsável não exista, mantém como null
                    }
                }
                else
                {
                    txtResponsavelPaciente.Text = "Sem Responsável";
                    responsavelPaciente = null; // Sem responsável
                }

                cbAtivoInativo.Text = paciente.Ativo_Inativo == 1 ? "Ativo" : "Inativo";

                // Preencher os campos de endereço
                if (endereco != null)
                {
                    txtLogradouro.Text = endereco.Logradouro;
                    txtNumeroEndereco.Text = endereco.Numero;
                    txtCidadeEndereco.Text = endereco.Cidade;
                    cbUFPaciente.Text = endereco.Estado;
                    txtCEPEndereco.Text = endereco.CEP;
                    txtComplementoEndereco.Text = endereco.Complemento;
                }
                else
                {
                    MessageBox.Show($"Endereço para o paciente com ID {_pacienteId} não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"Paciente com ID {_pacienteId} não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DesabilitarCampos()
        {
            txtNomePaciente.Enabled = false;
            txtCPFPaciente.Enabled = false;
            txtEmailPaciente.Enabled = false;
            txtComplementoEndereco.Enabled = false;
            txtCidadeEndereco.Enabled = false;
            txtIdadePaciente.Enabled = false;
            txtNumeroEndereco.Enabled = false;
            txtTelefonePaciente.Enabled = false;
            txtCEPEndereco.Enabled = false;
            txtLogradouro.Enabled = false;
            btnConvenio.Enabled = false;
            btnResponsavel.Enabled = false;
            btnSalvarPaciente.Visible = false;
            cbAtivoInativo.Enabled = false;
            txtConvenioPaciente.Enabled = false;
            cbSexoPaciente.Enabled = false;
            cbUFPaciente.Enabled = false;
            txtResponsavelPaciente.Enabled = false;
            dtpDataPaciente.Enabled = false;
        }

        private void btnSalvarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                // Coleta os dados do paciente
                string nome = txtNomePaciente.Text;
                DateTime dataNascimento = dtpDataPaciente.Value;
                int idade = int.Parse(txtIdadePaciente.Text);
                string cpf = txtCPFPaciente.Text.Replace(".", "").Replace("-", "").Replace(",", "");
                string sexo = cbSexoPaciente.Text;
                string telefone = txtTelefonePaciente.Text;
                string email = txtEmailPaciente.Text;

                // Coleta o status Ativo/Inativo
                string status = cbAtivoInativo.SelectedItem.ToString();
                int ativoInativo = status == "Ativo" ? 1 : 0;

                // Cria o objeto Paciente
                Paciente paciente = new Paciente
                {
                    Nome = nome,
                    DataNascimento = dataNascimento,
                    Idade = idade,
                    CPF = cpf,
                    Sexo = sexo,
                    Telefone = telefone,
                    Email = email,
                    Ativo_Inativo = ativoInativo
                };

                // Preserva o Convênio existente se não for alterado
                if (convenioPaciente != null)
                {
                    paciente.Convenio = convenioPaciente; // Atualiza com o novo Convênio
                }
                else if (paciente.Convenio == null)
                {
                    paciente.Convenio = null; // Mantém como null se não selecionar nenhum novo Convênio
                }

                // Preserva o Responsável existente se não for alterado
                if (responsavelPaciente != null)
                {
                    paciente.Responsavel = responsavelPaciente; // Atualiza com o novo Responsável
                }
                else if (paciente.Responsavel == null)
                {
                    paciente.Responsavel = null; // Mantém como null se não selecionar nenhum novo Responsável
                }

                // Coleta os dados de endereço
                string logradouro = txtLogradouro.Text;
                string numero = txtNumeroEndereco.Text;
                string cidade = txtCidadeEndereco.Text;
                string estado = cbUFPaciente.Text;
                string cep = txtCEPEndereco.Text.Replace("-", "");
                string complemento = txtComplementoEndereco.Text;

                // Cria o objeto Endereço
                Endereco endereco = new Endereco
                {
                    Logradouro = logradouro,
                    Numero = numero,
                    Cidade = cidade,
                    Estado = estado,
                    CEP = cep,
                    Complemento = complemento
                };

                // Chama o método de atualização com os objetos Paciente e Endereço
                bool atualizado = _pacienteController.AtualizarPacienteComEndereco(_pacienteId, paciente, endereco);

                // Exibe o resultado
                if (atualizado)
                {
                    MessageBox.Show("Paciente atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar o paciente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Ocorreu um erro de formatação: {ex.Message}", "Erro de Formatação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PesquisarConvenio()
        {
            frmSelecionarConvenio frm = new frmSelecionarConvenio(true);
            DialogResult dialogResult = frm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                convenioPaciente = frm.convenioSelecao;

                txtConvenioPaciente.Text = convenioPaciente.Nome;
            }
        }

        private void PesquisarResponsavel()
        {
            frmSelecionarResponsavel frm = new frmSelecionarResponsavel(true);
            DialogResult dialogResult = frm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                responsavelPaciente = frm.responsavelSelecao;

                txtResponsavelPaciente.Text = responsavelPaciente.Nome;
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

        private void btnConvenio_Click(object sender, EventArgs e)
        {
            PesquisarConvenio();
        }

        private void btnResponsavel_Click(object sender, EventArgs e)
        {
            PesquisarResponsavel();
        }
    }
}