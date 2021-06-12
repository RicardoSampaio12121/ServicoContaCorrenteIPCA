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
    public partial class PedidosPendentes : Form
    {
        public PedidosPendentes()
        {
            InitializeComponent();
        }

        private void PedidosPendentes_Load(object sender, EventArgs e)
        {
            //Get all the pending requests
            var ar = new ArticleRequest();

            dataGridView1.DataSource = ar.Get();
        }

        /// <summary>
        /// Apresenta pedidos de crédito pendentes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblCodError.Text = "";
            DataTable output = null;

            if (rbArtigo.Checked)
            {
                var ar = new ArticleRequest();

                if (txtCod.Text != "")
                {
                    //Receber dados dos pedidos de credito por artigos de um certo docente
                    if (int.TryParse(txtCod.Text, out var cod))
                    {
                        output = ar.GetByCodTeacher(cod);
                    }
                    else
                    {
                        lblCodError.Text = "Código inválido!";
                    }

                }
                else
                {
                    //Receber dados de todos os pedidos de creditos por artigos
                    output = ar.Get();
                }
            }
            else
            {
                var hr = new HoursRequest();

                if(txtCod.Text != "")
                {
                    output = hr.GetByCodTeacher(int.Parse(txtCod.Text));
                }
                else
                {
                    output = hr.Get();
                }
            }
            

            dataGridView1.DataSource = output;
        }

        /// <summary>
        /// Aceita um pedido de crédito
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceitar_Click(object sender, EventArgs e)
        {
            lblErrorLine.Text = "";
            if (dataGridView1.SelectedRows.Count == 0)
            {
                lblErrorLine.Text = ("Tem que selecionar uma linha da tabela!");
            }
            else if(dataGridView1.SelectedRows.Count > 1)
            {
                lblErrorLine.Text = ("Só pode selecionar uma linha de cada vez!");
            }
            else
            {
                // Recolher valor
                Form valueForm = new ValorForm();
                valueForm.ShowDialog();

                // Guardar a linha selecionada
                int index = dataGridView1.SelectedRows[0].Index;
                DataGridViewRow row = dataGridView1.Rows[index];

                if (rbArtigo.Checked) // Aceita artigo
                {

                    int cod_pedido = int.Parse(row.Cells[0].Value.ToString());
                    int cod = int.Parse(row.Cells[1].Value.ToString());
                    string article = row.Cells[2].Value.ToString();
                    string magazine = row.Cells[3].Value.ToString();
                    DateTime date = DateTime.Parse(row.Cells[4].Value.ToString());
                    float value = Global.Value;

                    var aar = new AcceptedArticleRequest(cod_pedido,
                                                         cod,
                                                         article,
                                                         magazine,
                                                         date,
                                                         value
                                                         );
                    Logic.Application.Application.AcceptArticleRequest(aar);
                }
                else // Aceita horas_extra
                {
                    int cod_pedido = int.Parse(row.Cells[0].Value.ToString());
                    int cod_doc = int.Parse(row.Cells[1].Value.ToString());
                    DateTime date = DateTime.Parse(row.Cells[2].Value.ToString());
                    float given_hours = float.Parse(row.Cells[3].Value.ToString());
                    float value = Global.Value;

                    var ahr = new AcceptedHoursRequest(cod_pedido, cod_doc, date, given_hours, value);

                    Logic.Application.Application.AcceptedHoursRequest(ahr);

                }
                dataGridView1.Rows.RemoveAt(index);


            }
        }

        /// <summary>
        /// Rejeita um pedido de crédito
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRejeitar_Click(object sender, EventArgs e)
        {
            lblErrorLine.Text = "";
            if (dataGridView1.SelectedRows.Count == 0)
            {
                lblErrorLine.Text = ("Tem que selecionar uma linha da tabela!");
            }
            else if (dataGridView1.SelectedRows.Count > 1)
            {
                lblErrorLine.Text = ("Só pode selecionar uma linha de cada vez!");
            }
            else
            {

                int index = dataGridView1.SelectedRows[0].Index;
                DataGridViewRow row = dataGridView1.Rows[index];

                int cod = int.Parse(row.Cells[0].Value.ToString());

                if (rbArtigo.Checked)
                {
                    var ar = new ArticleRequest();
                    ar.Remove(cod);
                }
                else
                {
                    var hr = new HoursRequest();
                    hr.Remove(cod);
                }

                dataGridView1.Rows.RemoveAt(index);
            }
        }
    }
}
