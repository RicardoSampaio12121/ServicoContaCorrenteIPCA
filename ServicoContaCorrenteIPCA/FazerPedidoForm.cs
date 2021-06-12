using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic.Entities;
using Logic.Interfaces;


namespace ServicoContaCorrenteIPCA
{
    public partial class FazerPedidoForm : Form
    {
        public FazerPedidoForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Faz um pedido de credito por um artigo publicado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmitArticleRequest_Click(object sender, EventArgs e)
        {
            lblArtError.Text = "";

            if (txtArtigo.Text == "" || txtRevista.Text == "" || txtNDocArt.Text == "")
            {
                lblArtError.Text = "Todos os campos devem ser preenchidos!";
            }
            else
            {
                if (!int.TryParse(txtNDocArt.Text, out var cod))
                {
                    lblArtError.Text = "Código de docente inválido!";
                }
                else
                {
                    int teacherId = cod; 
                    string articleName = txtArtigo.Text;
                    string magazine = txtRevista.Text;

                    var creditsRequest = new ArticleRequest(teacherId, articleName, magazine);
                    creditsRequest.MakeRequest();

                    txtArtigo.Text = "";
                    txtNDocArt.Text = "";
                    txtRevista.Text = "";
                    MessageBox.Show("Pedido efetuado com sucesso!");
                }
            }
        }

        /// <summary>
        /// Faz um pedido de credito por horas extra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmitHoursRequest_Click(object sender, EventArgs e)
        {
            lblHEError.Text = "";

            if (txtDocHours.Text == "" || txtHoursHours.Text == "" || txtDateHours.Text == "")
            {
                lblHEError.Text = "Todos os campos devem ser preenchidos!";
            }
            else
            {
                if (!int.TryParse(txtDocHours.Text, out var cod))
                {
                    lblHorasDadas.Text = "Código de docente inválido";
                }
                else if(!float.TryParse(txtHoursHours.Text, out var hoursO))
                {
                    lblHorasDadas.Text = "Número de horas inválido";
                }
                else
                {
                    int teacherId = cod;
                    string date = txtDateHours.Text;
                    float hours = hoursO;

                    var hoursRequest = new HoursRequest(teacherId, date, hours);
                    hoursRequest.MakeRequest();

                    txtDocHours.Text = "";
                    txtDateHours.Text = "";
                    txtHoursHours.Text = "";

                    MessageBox.Show("Pedido efetuado com sucesso!");
                }
            }
        }
    }
}