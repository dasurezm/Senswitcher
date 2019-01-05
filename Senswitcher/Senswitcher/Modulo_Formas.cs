using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Senswitcher.Properties;

namespace Senswitcher
{
    public partial class Modulo_Formas : Form
    {
        public Modulo_Formas()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            btn2.Image = Resources.nuevo;
        }
    }
}
