using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationMenus
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void abrirFormCompilar()
        {
            FormCompilar f = new FormCompilar("Compilar solución");



            f.Show();
        }

        private void compilarSoluciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormCompilar();
        }

        private void toolStripButtonCompilar_Click(object sender, EventArgs e)
        {
            abrirFormCompilar();
        }
    }
}
