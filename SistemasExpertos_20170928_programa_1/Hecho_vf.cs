using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasExpertos_20170928_programa_1
{
    public partial class Hecho_vf : Form
    {
        string label;
        public string respuesta;

        public Hecho_vf(string _label)
        {
            label = _label;
            InitializeComponent();
        }

        private void Hecho_vf_Load(object sender, EventArgs e)
        {
            lbl1.Text = label;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            respuesta = textBox1.Text;
            this.Close();
        }
    }
}
