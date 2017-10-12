using System;
using System.Windows.Forms;

namespace SistemasExpertos_20170928_programa_1
{
    public partial class Form1 : Form
    {
        public Form1(){InitializeComponent();}

 private void btnCalcular_Click(object sender, EventArgs e)
 {
            lbRespuesta.Text = string.Format("La {0} {1} con la {2} será {3} cuando la {4} {5} con la {6} sea {7}",
 cd(cbOperacionLadoA), Operador(cbA.Text), Operador(cbB.Text), Logica(cbLogica.Text[0]), cd(cbOperacionLadoB),Operador(cbC.Text),
 Operador(cbD.Text), Logica(cbLogica.Text[1]));
        }

 private string cd(ComboBox cb){
            return cb.Text=="&&" ? "Conjunción " : "Disyunción ";
        }

 private string Operador(string _string){
            return _string[0] == '!' ? " la Negación de '" + _string.Substring(1, 1)+"'" : " de '"+ _string+"'";
        }

 private string Logica(char _string)
        {
            return _string == 'P' ? " Verdadera " : " Falsa ";
        }
    }
}
