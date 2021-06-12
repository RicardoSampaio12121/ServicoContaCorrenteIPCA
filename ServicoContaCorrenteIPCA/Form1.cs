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
        /// <summary>
        /// Abre o formulário pedido
        /// </summary>
        /// <param name="childForm"></param>
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

        /// <summary>
        /// Abre o formulário de pedidos de creditos pendentes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPendingRequests_Click(object sender, EventArgs e)
        {
            lblCurrentForm.Text = "Pedidos Pendentes";
            OpenChildForm(new PedidosPendentes());
        }

        /// <summary>
        /// Abre o formulário de pedidos de solicitação pendentes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPendingSolicitation_Click(object sender, EventArgs e)
        {
            lblCurrentForm.Text = "Solicitações Pendentes";
            OpenChildForm(new PendingSolicitations());
        }

        /// <summary>
        /// Abre o formulario de fazer pedidos de creditos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMakeRequest_Click(object sender, EventArgs e)
        {
            lblCurrentForm.Text = "Fazer Pedido";
            OpenChildForm(new FazerPedidoForm());

        }

        /// <summary>
        /// Abre o formulario de fazer solicitações
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMakeSolicitation_Click(object sender, EventArgs e)
        {
            lblCurrentForm.Text = "Fazer Solicitação";
            OpenChildForm(new FazerSolicitaçãoForm());
        }
    }
}
