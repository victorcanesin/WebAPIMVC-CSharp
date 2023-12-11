using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void cidadesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           // if ()
            {
                TabPage pagina = new TabPage();
                FrmCidades form = new FrmCidades();
                form.Dock = DockStyle.Fill;
                pagina.Controls.Add(form);
                pagina.Text = "Cidades";
                tabControl1.TabPages.Add(pagina);                 
            }
        }

    }
}
