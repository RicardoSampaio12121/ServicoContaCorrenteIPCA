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
    public partial class SolicitacaoInformacao : Form
    {
        public SolicitacaoInformacao()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Apresenta informação sobre a solicitação
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SolicitacaoInformacao_Load(object sender, EventArgs e)
        {
            lblDocente.Text = Global.CodDoc.ToString();
            lblMotivo.Text = Global.Motivo;
            lblVal.Text = Global.Value.ToString();

            dataGridView1.DataSource = Logic.Application.Application.GetVerbasHoras(int.Parse(lblDocente.Text));
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;

            dataGridView2.DataSource = Logic.Application.Application.GetVerbasArtigos(int.Parse(lblDocente.Text));
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].Visible = false;
            dataGridView2.Columns[2].Visible = false;
            dataGridView2.Columns[3].Visible = false;
            dataGridView2.Columns[4].Visible = false;
            dataGridView2.Columns[7].Visible = false;
            dataGridView2.Columns[8].Visible = false;
            dataGridView2.Columns[9].Visible = false;
        }
    }
}
