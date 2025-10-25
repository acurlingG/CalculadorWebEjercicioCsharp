using System;
using System.CodeDom;
using System.Collections.Generic;
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

        

        protected void bcalcular_Click(object sender, EventArgs e)
        {
          checkBox();
            
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
    }
}