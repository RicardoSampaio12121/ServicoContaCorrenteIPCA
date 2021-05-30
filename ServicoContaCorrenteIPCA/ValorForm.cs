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
    public partial class ValorForm : Form
    {
        public ValorForm()
        {
            InitializeComponent();
        }

        private void ValorForm_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Global.Value = float.Parse(textBox1.Text);
            this.Close();
        }
    }
}
