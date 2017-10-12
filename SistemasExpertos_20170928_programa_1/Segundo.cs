using System;
using System.Drawing;
using System.Windows.Forms;
using info.lundin.math;
namespace SistemasExpertos_20170928_programa_1
{
    public partial class Segundo : Form
    {
        bool bandera=true;
        int y = 120;
        int conteo = 0;
        public int[] hechosInt = new int[6];
       
        

        public Segundo(){InitializeComponent();}
        private void Segundo_Load(object sender, EventArgs e){ }
        private void txtEcuacion_KeyPress(object sender, KeyPressEventArgs e){ funcionPrincipal(e); }
        private void cbLógica_KeyPress(object sender, KeyPressEventArgs e){funcionPrincipal(e);}
        private void cbLógica_SelectedIndexChanged(object sender, EventArgs e){programa2();}
        private void funcionPrincipal(KeyPressEventArgs e){if ((int)e.KeyChar == (int)Keys.Enter) programa2();}

        private void programa2()
        {
            {
                txtEcuacion.Text = txtEcuacion.Text.Replace(" ", "");
                try
                {
                    txtRespuesta.Text = "";
                    txtRespuesta.Text = Respuesta(txtEcuacion.Text, bandera, false); bandera = false;
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
        private string Respuesta(string ecuacion, bool realizar,bool respuesta)
        {
        string[] resultado = new string[2], oraciones = new string[2], hechosCad = new string[6], infoEcuacion = new string[2];
            //Separamos las premisas de los hechos
            int foundCierre = ecuacion.IndexOf(">");
            oraciones[0] = ecuacion.Substring(0, foundCierre - 1); //Ecuación 1 sin parentésis
            oraciones[1] = ecuacion.Substring(foundCierre + 1, ecuacion.Length - (foundCierre + 1)); //Ecuación 2 sin paréntesis
            char a; int hechosCount=0; // es el contador para hechos
            //foreach( char a in oraciones[0])
            for (int j = 0; j < oraciones.Length; j++)
            {
                for (int i = 0; i < oraciones[j].Length; i++)
                {
                    a = oraciones[j][i];
                    if (a == '!' || a == '¡') //Si a es igual a !
                    {
                        if (Char.IsLetter(oraciones[j][i + 1]))//Si el siguiente caracter de ! es letra
                        {
                            i++;
                            resultado[j] += "'" + oraciones[j][i] + "' negada ";
                            hechosCad[hechosCount] += "!" + oraciones[j][i]; //Agrega a los hechos esta variable
                            infoEcuacion[j] += hechosInt[hechosCount] ==1?0:1; //Sí es 1 niégalo, si es 0 niégalo
                            addLabels("valor de !" + oraciones[j][i], realizar);
                            hechosCount++;
                            
                        }
                    }
                    else if (Char.IsLetter(a))
                    {
                        resultado[j] += "'" + a + "'";
                        hechosCad[hechosCount] += a;
                        infoEcuacion[j] += hechosInt[hechosCount];
                        addLabels("valor de " + a, realizar);
                        hechosCount++;

                    }
                    else if (a == '(' || a == ')')
                        infoEcuacion[j]+= a.ToString(); //agregamos paréntesis a la ecuación a evaluar
                    else if (a == '&')
                    {
                        resultado[j] += " conjunción de ";
                        infoEcuacion[j] += "*"; //agregamos paréntesis a la ecuación a evaluar. Falta invertir dato si es 0 o 1

                        if (oraciones[j][i + 1] == '&') i++; //Por si tiene 2
                    }
                    else if (a == '|')
                    {
                        resultado[j] += " disyunción de ";
                        infoEcuacion[j] += "+"; //agregamos paréntesis a la ecuación a evaluar. Falta invertir dato si es 0 o 1
                        if (oraciones[j][i + 1] == '|') i++; //por si tiene 2
                    }
                }
            }
            lblEjemplo.Text = "";
            if (respuesta)
            {
                
                ExpressionParser parser = new ExpressionParser();
                for (int j = 0; j < 2; j++)
                {
                    double result = parser.Parse(infoEcuacion[j])>0?1:0; //Aplicamos esto para que se haga algebra de bool
                    lblEjemplo.Text += string.Format("[ "+oraciones[j]+" es "+infoEcuacion[j]+" = {0} ] ", result);
                    if (j == 0) lblEjemplo.Text += "->";
                    Console.WriteLine(string.Format("Result: {0}\n", result));
                }
            }
            return " " + resultado[0] + "  será " + Logica(cbLógica.Text[0]) + " cuando la " + resultado[1] + " sea " + Logica(cbLógica.Text[1]);
        }
        private string Logica(char _string){return _string == 'P' ? " Verdadera " : " Falsa ";}

        private void addLabels(string _texto,bool realizar)
        {
            if(realizar)
            {
                //Crear instancia del control button
                Label temp = new Label();
                //Colocamos las propiedades
                temp.Height = 23;
                temp.Width = 70;
                temp.Location = new Point(20, y);
                temp.Name = "lbl" + conteo.ToString();
                temp.Text = _texto;
                Controls.Add(temp);
                ComboBox temp1 = new ComboBox();
                temp1.Height = 23;
                temp1.Width = 50;
                temp1.Location = new Point(120, y);
                temp1.Name = "txt" + conteo.ToString();
                temp1.AccessibleName = conteo.ToString();
                temp1.Text = "0";
                temp1.Items.Add("0");
                temp1.Items.Add("1");
                temp1.DropDownStyle = ComboBoxStyle.DropDownList;
                Controls.Add(temp1);
                //Incrementamos y(posición y el conteo de los controles 
                y += 25; //para el siguiente buton esté a 2 pixeles de este
                conteo++;
                //Adicionamos el handler 
                temp1.SelectedIndexChanged += new EventHandler(handlerBotones_SelectedIndexChanged);

                //Adicionamos el botón al form
            }
        }

        private void handlerBotones_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox actual = ((ComboBox)sender);

            if (actual.Text != "" && (actual.Text == "1" || actual.Text == "0"))
            {
                hechosInt[Convert.ToInt32(actual.AccessibleName)] = Convert.ToInt16(actual.Text); //rellenamos la cadena hechos con el número del control
            }
            else
            {
                MessageBox.Show("ingrese 1 o 0");
                actual.Focus(); actual.SelectAll();
            } 
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            try
            {
                Respuesta(txtEcuacion.Text, false, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Segundo actual = this;
            Segundo nuevo = new Segundo();
            nuevo.Show();
            actual.Hide();  
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
