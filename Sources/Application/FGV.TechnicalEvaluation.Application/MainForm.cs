using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using FGV.TechnicalEvaluation.Domain.Exceptions;
using FGV.TechnicalEvaluation.Foundation.Contracts;
using FGV.TechnicalEvaluation.Foundation.Contracts.Services;
using FGV.TechnicalEvaluation.Foundation.Entities;

namespace FGV.TechnicalEvaluation.Application
{
    public partial class MainForm : Form
    {
        private readonly IBooksOrderer _booksOrderer;
        public IApplicationContext Context { get; private set; }

        public MainForm(IApplicationContext applicationContext, IBooksOrderer booksOrderer)
        {
            _booksOrderer = booksOrderer;
            Context = applicationContext;
            
            InitializeComponent();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            LoadAndOrderBooks();
        }

        /// <summary>
        /// Evento de seleção do arquivo XML
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectXmlFile_Click(object sender, System.EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "XML|*.xml";
                dialog.Title = "Selecione o XML";

                if (System.Windows.Forms.Application.UserAppDataRegistry.GetValue("XmlPath") != null)
                    dialog.InitialDirectory =
                        Path.GetDirectoryName(System.Windows.Forms.Application.UserAppDataRegistry.GetValue("XmlPath").ToString());

                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    tbXmlPath.Text = dialog.FileName;
                    System.Windows.Forms.Application.UserAppDataRegistry.SetValue("XmlPath", dialog.FileName);

                    LoadAndOrderBooks();
                }
            }
        }

        /// <summary>
        /// Carrega a lista de livros na grid original e ordena para outra denominada grid ordenada
        /// </summary>
        private void LoadAndOrderBooks()
        {
            if (System.Windows.Forms.Application.UserAppDataRegistry.GetValue("XmlPath") != null)
            {
                var path = System.Windows.Forms.Application.UserAppDataRegistry.GetValue("XmlPath").ToString();
                tbXmlPath.Text = path;

                var dataSet = new DataSet();
                try
                {
                    
                    dataSet.ReadXml(path);
                    dgvBooks.DataSource = dataSet.Tables[0];
                }
                catch
                {
                    MessageBox.Show("Ocorreu um erro ao carregar lista.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                try
                {
                    var books = dataSet.Tables[0].AsEnumerable().Select(r => new Book
                    {
                        Title = r.Field<string>("Title"),
                        AuthorName = r.Field<string>("AuthorName"),
                        EditionYear = Convert.ToInt32(r.Field<string>("EditionYear"))
                    });
                    var list = _booksOrderer.Order(books);

                    dgvOrderedBooks.DataSource = new BindingSource(list, null);
                }
                catch (OrdenationException ex)
                {
                    MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch
                {
                    MessageBox.Show("Ocorreu um erro ao ordenar lista.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}