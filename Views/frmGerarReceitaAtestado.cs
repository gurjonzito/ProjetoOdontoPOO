using iTextSharp.text;
using iTextSharp.text.pdf;
using ProjetoOdontoPOO.Controllers;
using ProjetoOdontoPOO.Models;
using System;
using System.IO;
using System.Windows.Forms;

namespace ProjetoOdontoPOO.Views
{
    public partial class frmGerarReceitaAtestado : Form
    {
        private readonly PacienteController _pacienteController;
        private readonly DentistaController _dentistaController;

        Dentista dentistaPaciente;
        Paciente pacienteSelecionado;

        public frmGerarReceitaAtestado()
        {
            InitializeComponent();

            _pacienteController = new PacienteController();
            _dentistaController = new DentistaController();
        }

        private void btnGerarDocumento_Click(object sender, EventArgs e)
        {
            // Verificar se todos os campos estão preenchidos
            if (string.IsNullOrEmpty(cbSelecionarArquivo.Text) || string.IsNullOrEmpty(txtNomePaciente.Text) ||
                string.IsNullOrEmpty(txtNomeDentista.Text) || string.IsNullOrEmpty(txtObsArquivo.Text))
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

                    doc.Add(new Paragraph($"Paciente: {txtNomePaciente.Text}"));
                    doc.Add(new Paragraph($"Médico: {txtNomeDentista.Text}"));
                    doc.Add(new Paragraph("\n"));
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

                    cbSelecionarArquivo.SelectedIndex = -1;
                    txtNomePaciente.Clear(); 
                    txtNomeDentista.Clear(); 
                    txtObsArquivo.Clear(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao gerar documento: {ex.Message}");
                }
            }
        }

        private void PesquisarPaciente()
        {
            frmSelecionarPaciente frm = new frmSelecionarPaciente(true);
            DialogResult dialogResult = frm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                pacienteSelecionado = frm.pacienteSelecao;

                txtNomePaciente.Text = pacienteSelecionado.Nome;
            }
        }

        private void PesquisarDentista()
        {
            frmSelecionarDentista frm = new frmSelecionarDentista(true);
            DialogResult dialogResult = frm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                dentistaPaciente = frm.dentistaSelecao;

                txtNomeDentista.Text = dentistaPaciente.Nome;
            }
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            PesquisarPaciente();
        }

        private void btnDentista_Click(object sender, EventArgs e)
        {
            PesquisarDentista();
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
