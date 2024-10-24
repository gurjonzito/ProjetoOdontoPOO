using iTextSharp.text;
using iTextSharp.text.pdf;
using ProjetoOdontoPOO.Controllers;
using ProjetoOdontoPOO.Models;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProjetoOdontoPOO.Views
{
    public partial class frmGerarReceitaAtestado : Form
    {
        private readonly PacienteController _pacienteController;
        private readonly DentistaController _dentistaController;

        public frmGerarReceitaAtestado()
        {
            InitializeComponent();

            _pacienteController = new PacienteController();
            _dentistaController = new DentistaController();
        }

        private void frmGerarReceitaAtestado_Load(object sender, EventArgs e)
        {
            ConfigurarComboBoxPaciente();
            ConfigurarComboBoxDentista();
        }

        private void ConfigurarComboBoxPaciente()
        {
            cbPacienteArquivo.DataSource = _pacienteController.ObterTodosPacientes();
            cbPacienteArquivo.DisplayMember = "Nome";
            cbPacienteArquivo.ValueMember = "Id";
            cbPacienteArquivo.SelectedIndex = -1;
        }

        private void ConfigurarComboBoxDentista()
        {
            cbDentistaArquivo.DataSource = _dentistaController.ObterTodosDentistas();
            cbDentistaArquivo.DisplayMember = "Nome";
            cbDentistaArquivo.ValueMember = "Id";
            cbDentistaArquivo.SelectedIndex = -1;
        }

        private void btnGerarDocumento_Click(object sender, EventArgs e)
        {
            // Verificar se todos os campos estão preenchidos
            if (string.IsNullOrEmpty(cbSelecionarArquivo.Text) || string.IsNullOrEmpty(cbPacienteArquivo.Text) ||
                string.IsNullOrEmpty(cbDentistaArquivo.Text) || string.IsNullOrEmpty(txtObsArquivo.Text))
            {
                MessageBox.Show("Preencha todos os campos antes de gerar o documento.");
                return;
            }

            // Criar o documento PDF
            Document doc = new Document();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog.Title = "Salvar documento";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    PdfWriter.GetInstance(doc, new FileStream(saveFileDialog.FileName, FileMode.Create));
                    doc.Open();

                    // Definir conteúdo com base na opção selecionada (Receita ou Atestado)
                    string titulo = cbSelecionarArquivo.Text == "Receita" ? "Receita Médica" : "Atestado Médico";

                    // Adicionar conteúdo ao PDF
                    doc.Add(new Paragraph(titulo, FontFactory.GetFont(FontFactory.HELVETICA, 20, iTextSharp.text.Font.BOLD)));
                    doc.Add(new Paragraph("\n"));

                    doc.Add(new Paragraph($"Paciente: {cbPacienteArquivo.Text}"));
                    doc.Add(new Paragraph($"Médico: {cbDentistaArquivo.Text}"));
                    doc.Add(new Paragraph(txtObsArquivo.Text)); 
                    doc.Add(new Paragraph("\n"));

                    doc.Add(new Paragraph("\n"));
                    doc.Add(new Paragraph("______________________________"));
                    doc.Add(new Paragraph("\n"));
                    doc.Add(new Paragraph("Assinatura do Médico"));
                    doc.Add(new Paragraph("\n"));

                    DateTime dataHoraAtual = DateTime.Now;
                    string dataHoraFormatada = "Data e hora de geração: " + dataHoraAtual.ToString("dd/MM/yyyy HH:mm:ss");
                    Paragraph dataHora = new Paragraph(dataHoraFormatada);
                    dataHora.Alignment = Element.ALIGN_RIGHT;
                    doc.Add(dataHora);

                    doc.Close();

                    MessageBox.Show("Documento gerado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao gerar documento: {ex.Message}");
                }
            }
        }
    }
}
