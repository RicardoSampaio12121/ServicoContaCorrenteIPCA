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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable output = null;

            if (rbArtigo.Checked)
            {
                var ar = new ArticleRequest();

                if (txtCod.Text != "")
                {
                    //Receber dados dos pedidos de credito por artigos de um certo docente
                    output = ar.GetByCodTeacher(int.Parse(txtCod.Text));
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

        private void btnAceitar_Click(object sender, EventArgs e)
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

        private void btnRejeitar_Click(object sender, EventArgs e)
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
