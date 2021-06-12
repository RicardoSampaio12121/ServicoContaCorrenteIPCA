using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServicoContaCorrenteIPCA
{
    public partial class PendingSolicitations : Form
    {
        public PendingSolicitations()
        {
            InitializeComponent();
        }

        private void PendingSolicitations_Load(object sender, EventArgs e)
        {
            var data = Logic.Application.Application.GetSolicitations();
            dataGridView1.DataSource = data;
        }

        /// <summary>
        /// Apresenta as solicitações pendentes por código de docente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblCodError.Text = "";
            
            //Carregar todas as solicitações pendentes
            if(txtCod.Text == "")
            {
                dataGridView1.DataSource = Logic.Application.Application.GetSolicitations();
            }
            else //Carregar solicitacoes de apenas um docente
            {
                if(int.TryParse(txtCod.Text, out var cod))
                {
                    dataGridView1.DataSource = Logic.Application.Application.GetSolicitationsById(cod);
                }
                else
                {
                    lblCodError.Text = "Código de docente inválido";
                }
            }
        }

        /// <summary>
        /// Apresentra informação sobre alguma solicitação
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                lblLinesError.Text = "Tem de selecionar uma linha da tabela!";
            }
            else if (dataGridView1.SelectedRows.Count > 1)
            {
                lblLinesError.Text = "Só pode selecionar uma linha da tabela de cada vez!";
            }
            else
            {

                int index = dataGridView1.SelectedRows[0].Index;
                DataGridViewRow row = dataGridView1.Rows[index];

                Global.CodDoc = int.Parse(row.Cells[1].Value.ToString());
                Global.Value = int.Parse(row.Cells[3].Value.ToString());
                Global.Motivo = row.Cells[2].Value.ToString();

                Form infoForm = new SolicitacaoInformacao();
                infoForm.ShowDialog();
            }
        }

        /// <summary>
        /// Aceita uma solicitação
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceitar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                lblLinesError.Text = "Tem de selecionar uma linha da tabela!";
            }
            else if (dataGridView1.SelectedRows.Count > 1)
            {
                lblLinesError.Text = "Só pode selecionar uma linha da tabela de cada vez!";
            }
            else
            {
                int index = dataGridView1.SelectedRows[0].Index;
                DataGridViewRow row = dataGridView1.Rows[index];

                int cod_sol = int.Parse(row.Cells[0].Value.ToString());
                int cod_docente = int.Parse(row.Cells[1].Value.ToString());
                string motivo = row.Cells[2].Value.ToString();
                float valor = float.Parse(row.Cells[3].Value.ToString());

                Logic.Application.Application.AcceptSolicitation(cod_sol, cod_docente, motivo, valor);

                dataGridView1.Rows.RemoveAt(index);
                MessageBox.Show("Solicitação aceite!");
            }
        }

        /// <summary>
        /// Rejeita uma solicitação
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRejeitar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                lblLinesError.Text = "Tem de selecionar uma linha da tabela!";
            }
            else if (dataGridView1.SelectedRows.Count > 1)
            {
                lblLinesError.Text = "Só pode selecionar uma linha da tabela de cada vez!";
            }
            else
            {
                int index = dataGridView1.SelectedRows[0].Index;
                DataGridViewRow row = dataGridView1.Rows[index];

                int cod_sol = int.Parse(row.Cells[0].Value.ToString());
                int cod_docente = int.Parse(row.Cells[1].Value.ToString());

                Logic.Application.Application.RejectSolicitation(cod_sol, cod_docente);

                dataGridView1.Rows.RemoveAt(index);
                MessageBox.Show("Pedido rejeitado!");
            }
        }
    }
}