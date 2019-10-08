using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
   public class Prinipal
   {
        public void Bienvenida()
        {
            /*creo el metodo bienvenida para que este sea el unico metodo que instancie en
             el main*/
            Console.WriteLine("-----Bienvenido a mi Humilde Programita-----");
            Menu(); //mando a llamar al metodo menu para que se ejecute    
        }
        public void Menu()
        {
            /*aqui le doy la opcines que existen y que elija la opcion que elija */
            Console.WriteLine();
            Console.WriteLine("=====Opcines de conversiones=====");
            Console.WriteLine();
            Console.WriteLine("1-Convercion de CENTIMETROS a METROS ");
            Console.WriteLine();
            Console.WriteLine("2-Conversion de METROS a PULGADAS");
            Console.WriteLine();
            Console.WriteLine("3-Conversion de Litros a Mililitos");
            Console.WriteLine();
            Opciones();//mando a llamar al metodo opciones
            Console.WriteLine();
        }
        public void Opciones()
        {
            Console.WriteLine("Eija la operacion que desea realizar");
            int opc = Convert.ToInt32(Console.ReadLine());

            OPERACIONES o = new OPERACIONES();
            switch (opc)
            {
                case 1:
                    Console.WriteLine("Ingrese Centimetros");
                    double Cm = Convert.ToDouble(Console.ReadLine());
                    double res = o.Conversion(Cm);
                    Console.WriteLine("la Conversion de {0} cm a metro(s) es {1} metros", Cm, res);
                    break;
                case 2:
                    Console.WriteLine("Ingrese los Metros");
                    double m = Convert.ToDouble(Console.ReadLine());
                    double res2 = o.Conversion(0, m);
                    Console.WriteLine("la Conversion de {0} metro(s) a pulgadas es {1} pulgadas", m, res2);
                    break;
                case 3:
                    Console.WriteLine("Ingrese los litros");
                    double litros = Convert.ToDouble(Console.ReadLine());
                    double res3 = o.Conversion(0, 0, litros);
                    Console.WriteLine("La conversion de {0} litro(s) a mililitros es {1} mililitros", litros, res3);
                    break;
                default:
                    Console.WriteLine("opcion incorrecta");
                    Menu();
                    break;
            }
        }
   }
}
