using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WeBcalculadora
{
    public partial class Calculadora : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        

        

        private void List()
        {
            
        }


        private void checkBox()
        {
            lresultado.Text = string.Empty;
            ClsCheckbox operacion = new ClsCheckbox(float.Parse(tvalor1.Text), float.Parse(tvalor2.Text));

          if (Csuma.Checked)
                lresultado.Text = $" Suma: {operacion.sumar().ToString()}" + lresultado.Text;

          if (Cresta.Checked)
                lresultado.Text = lresultado.Text + $" Resta: {operacion.restar().ToString()}"  ;

        }
        private void RadioButton()
        {
            float num1 = float.Parse(tvalor1.Text);
            float num2 = float.Parse(tvalor2.Text);

            ClsRadionButton operacion = new ClsRadionButton();

            if (rsuma.Checked)
                lresultado.Text = operacion.sumar(num1, num2).ToString();
            else if (rresta.Checked)
                lresultado.Text = ClsRadionButton.restar(num1, num2).ToString();
        }

        protected void b1_Click(object sender, EventArgs e)
        {        
            lresultado.Text = lresultado.Text + "1";
        }

        protected void b2_Click(object sender, EventArgs e)
        {
            lresultado.Text = lresultado.Text + "2";
        }

        protected void b3_Click(object sender, EventArgs e)
        {
            lresultado.Text = lresultado.Text + "3";
        }

        protected void bsuma_Click(object sender, EventArgs e)
        {
            ClsOperacion.sumar  = true;
            ClsOperacion.restar = false;
            ClsOperacion.multiplicar = false;
            ClsOperacion.dividir = false;
            ClsOperacion.factorial = false;

            float valor1;
            float.TryParse(lresultado.Text, out valor1);
            ClsOperacion.valor1 =valor1;
            lresultado.Text = string.Empty;
        }

        protected void bresultado_Click(object sender, EventArgs e)
        {
            float valor2;
            float.TryParse(lresultado.Text, out valor2);
            ClsOperacion.valor2 = valor2;
            if (ClsOperacion.sumar == true)
            {
                lresultado.Text = ClsOperacion.metodo_sumar(ClsOperacion.valor1, ClsOperacion.valor2).ToString();
            }
            else if (ClsOperacion.restar == true)
            {
                lresultado.Text = ClsOperacion.metodo_restar(ClsOperacion.valor1, ClsOperacion.valor2).ToString();
            }
            else if (ClsOperacion.multiplicar == true)
            {
                lresultado.Text = ClsOperacion.metodo_multiplicar(ClsOperacion.valor1, ClsOperacion.valor2).ToString();
            }
            else if (ClsOperacion.dividir == true)
            {
                lresultado.Text = ClsOperacion.metodo_dividir(ClsOperacion.valor1, ClsOperacion.valor2).ToString();
            }
        }
        protected void bresta_Click(object sender, EventArgs e)
        {
            ClsOperacion.sumar = false;
            ClsOperacion.restar = true;
            ClsOperacion.multiplicar = false;
            ClsOperacion.dividir = false;
            ClsOperacion.factorial = false;
            float valor1;
            float.TryParse(lresultado.Text, out valor1);
            ClsOperacion.valor1 = valor1;
            lresultado.Text = string.Empty;
        }

        protected void bclear_Click(object sender, EventArgs e)
        {
            lresultado.Text = string.Empty;
            ClsOperacion.valor1 = 0;
            ClsOperacion.valor2 = 0;
            ClsOperacion.sumar = false;
            ClsOperacion.restar = false;
            ClsOperacion.multiplicar = false;
            ClsOperacion.dividir = false;
            ClsOperacion.factorial = false;
        }
    }
}