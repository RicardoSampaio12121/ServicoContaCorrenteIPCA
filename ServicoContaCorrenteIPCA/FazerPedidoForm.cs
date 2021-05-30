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

        private void btnSubmitArticleRequest_Click(object sender, EventArgs e)
        {
            int teacherId = int.Parse(txtNDocArt.Text); //TODO: Check if it is a valid ID
            string articleName = txtArtigo.Text;
            string magazine = txtRevista.Text;

            var creditsRequest = new ArticleRequest(teacherId, articleName, magazine);
            creditsRequest.MakeRequest();
        }

        private void btnSubmitHoursRequest_Click(object sender, EventArgs e)
        {
            int teacherId = int.Parse(txtDocHours.Text);
            string date = txtDateHours.Text;
            float hours = float.Parse(txtHoursHours.Text);

            var hoursRequest = new HoursRequest(teacherId, date, hours);
            hoursRequest.MakeRequest();
        }

        private void panelArtigo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
