using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;
using Logic.Entities;

namespace ServicoContaCorrenteIPCA
{
    public partial class FazerSolicitaçãoForm : Form
    {
        public FazerSolicitaçãoForm()
        {
            InitializeComponent();
        }


        private void FazerSolicitaçãoForm_Load(object sender, EventArgs e)
        {
            var aar = new AcceptedArticleRequest();
            dataGridView1.DataSource = aar.Get();
            needed = 0;
            updateTable.Clear();
            deleteRow.Clear();
            verbas.Clear();
        }

        /// <summary>
        /// Apresenta as verbas disponiveis por codigo de docente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtCodDoc.Text == "")
            {
                MessageBox.Show("Insira um código de docente!");
            }
            else
            {
                if (!int.TryParse(txtCodDoc.Text, out var cod))
                {
                    MessageBox.Show("Código inválido!");
                }
                else
                {
                    if (rbArtigo.Checked)
                    {
                        var aar = new AcceptedArticleRequest();
                        dataGridView1.DataSource = aar.GetById(cod);
                    }
                    else
                    {
                        var ahr = new AcceptedHoursRequest();
                        dataGridView1.DataSource = ahr.GetById(cod);
                    }
                }
            }
        }

        List<(string, int, float)> updateTable = new List<(string, int, float)>();
        List<(string, int)> deleteRow = new List<(string, int)>();
        List<(string, int)> verbas = new List<(string, int)>();

        float needed = 0;

        /// <summary>
        /// Adicona uma verba
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string table = "Artigo";

            if(txtRemainder.Text == "")
            {
                txtRemainder.Text = txtValor.Text;
                needed = float.Parse(txtRemainder.Text);
            }

            if (float.Parse(txtRemainder.Text) < 0.0001)
            {
                MessageBox.Show("Valor necessário já adquirido");
            }
            else
            {
                int index = dataGridView1.SelectedRows[0].Index;
                DataGridViewRow row = dataGridView1.Rows[index];
                int cod = int.Parse(row.Cells[0].Value.ToString());
                float value = float.Parse(row.Cells[2].Value.ToString());

                if (rbHE.Checked)
                {
                    table = "Horas";
                }

                if (value > needed)
                {
                  
                    verbas.Add((table, cod));


                    dataGridView1.Rows[index].Cells[2].Value = value - needed;
                    needed = 0;
                }
                else
                {
                    verbas.Add((table, cod));
                    needed -= value;

                    dataGridView1.Rows.RemoveAt(index);
                }

                txtRemainder.Text = needed.ToString();


            }
        }

        /// <summary>
        /// Confirma o pedido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (needed == 0)
            {
                int cod_doc = int.Parse(txtCodDoc.Text);
                string motivo = txtMotivo.Text;
                float valor = float.Parse(txtValor.Text);

                Logic.Application.Application.MakeSolicitation(cod_doc, motivo, valor, verbas);

                MessageBox.Show("Solitação realizada com sucesso!");
            }
        }
    }
}
