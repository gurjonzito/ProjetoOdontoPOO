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
    public partial class frmPagamento : Form
    {
        private readonly PacienteController _pacienteController;

        public frmPagamento()
        {
            InitializeComponent();

            _pacienteController = new PacienteController();
        }

        private void frmPagamento_Load(object sender, EventArgs e)
        {
            ConfigurarComboBoxPaciente();
        }

        private void ConfigurarComboBoxPaciente()
        {
            cbPacientePag.DataSource = _pacienteController.ObterTodosPacientes();
            cbPacientePag.DisplayMember = "Nome";
            cbPacientePag.ValueMember = "Id";
            cbPacientePag.SelectedIndex = -1;
        }

        //private void btnConfirmarPagamento_Click(object sender, EventArgs e)
        //{
        //    var pagamento = CriarPagamento();

        //    string mensagem = _pacienteController.InserirPacienteComEndereco(pagamento);
        //    MessageBox.Show(mensagem);

        //    if (mensagem.Contains("Pagamento realizado com sucesso!"))
        //    {
        //        LimparCampos();
        //    }
        //}
    }
}
