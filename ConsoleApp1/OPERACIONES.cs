using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    /*creo una clase para realizar las conversiones */
   public class OPERACIONES
    {
        public double Conversion(double x)//aqui empiezo a hacer sobre carga de metodos 
        {
            /*aqui empiezo a hacer la operacion
             de centimetros a metros */
            double res = x / 100;
            return res;
        }
        public double Conversion(double x,double xx)//este es el segundo metodo sobrecargado
        {
            /*y aqui hago la conversion de 
             metros a pulgadas multiplicando los metros que ingreso el usuario por
             lo */
            double res = xx * 39.3701;
            return res;
        }
        public double Conversion(double x,double xx,double xxx)
        {
            double res = xxx * 1000;
            return res;
        }
    }
}
