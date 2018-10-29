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
    public partial class FormCompilar : Form
    {
        string mensaje;

        public FormCompilar()
        {
            InitializeComponent();
        }

        public FormCompilar(string mensaje)
        {
            InitializeComponent();
            this.mensaje = mensaje;

        }

        private void FormCompilar_Load(object sender, EventArgs e)
        {
            labelMensaje.Text = mensaje;
        }
    }
}
