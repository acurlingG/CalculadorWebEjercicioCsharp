using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace WeBcalculadora
{
    public class ClsOperacion
    {
        public static float valor1 { get; set; }
        public static float valor2 { get; set; }

        public static bool sumar = false;
        public static bool restar = false;
        public static bool multiplicar = false;
        public static bool dividir = false;
        public static bool factorial = false;
        public static bool exponente2 = false;
        public static bool exponente3 = false;
        


        public static float metodo_sumar(float v1, float v2)
        {
            return v1 + v2;
        }   

        public static float metodo_restar( float v1, float v2)
        {
            return v1 - v2;
        }
        public static float metodo_multiplicar(float v1, float v2)
        {
            return v1 * v2;
        }
        public static float metodo_dividir(float v1, float v2)
        {
            return v1 / v2;
        }

    }
}

