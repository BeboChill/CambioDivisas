using Microsoft.VisualBasic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;
using System.Threading.Tasks.Dataflow;
using System.Xml;

namespace Consola_Curso
{

    internal class Program
    {


        static void Main(string[] args)
        {
            try
            {
                const double valorDolar = 52.75;
                double montoUsuario;


                string respuestaUsuario;
                Console.WriteLine("Quiere Realizar una conversion de peso a dolar");
                respuestaUsuario = Console.ReadLine();
                
                if (!(respuestaUsuario.ToLower().Trim() == "si" || respuestaUsuario.ToLower().Trim() == "no"))
                {
                    throw new Exception("Debe de ingresar si o no.");
                }

                if (respuestaUsuario.ToLower().Trim() == "si")
                {
                    Console.WriteLine("Ingrese sus pesos dominicanos");
                    montoUsuario = double.Parse(Console.ReadLine());
                    double montoTotal = PesoAdolar(valorDolar, montoUsuario);
                    Console.WriteLine($"El Valor de RD${montoUsuario} a dolar es: {Math.Round(montoTotal)}");

                }
                else if (respuestaUsuario.ToLower().Trim() == "no")
                {
                    Console.WriteLine("Ingrese sus dolares por favor");
                    montoUsuario = double.Parse(Console.ReadLine());
                    double montoTotal = DolarApeso (valorDolar, montoUsuario);
                    Console.WriteLine($"El Valor de US${montoUsuario} a peso dominicano es: {Math.Round(montoTotal)}");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }

        }

        public static double PesoAdolar(double valorDolar, double montoUsuario)
        {
            return montoUsuario / valorDolar;
        }

        public static double DolarApeso(double valorDolar, double montoUsuario)
        {
            return valorDolar * montoUsuario;
        }

        

        
    }

}


  

   

   



























































