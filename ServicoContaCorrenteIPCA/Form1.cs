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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelForm.Controls.Add(childForm);
            panelForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnPendingRequests_Click(object sender, EventArgs e)
        {
            lblCurrentForm.Text = "Pedidos Pendentes";
            OpenChildForm(new PedidosPendentes());
        }

        private void btnPendingSolicitation_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void btnMakeRequest_Click(object sender, EventArgs e)
        {
            lblCurrentForm.Text = "Fazer Pedido";
            OpenChildForm(new FazerPedidoForm());

        }

        private void btnMakeSolicitation_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void pBoxLogo_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
