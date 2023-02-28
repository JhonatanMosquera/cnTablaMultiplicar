using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnTablaMultiplicar
{
    /// <summary>
    /// Nombre: jhonatan stiven mosquera moreno
    /// fecha: 24/02/2023
    /// descripcion: Tabla de multiplicar
    /// <param name="args"></param>
    internal class Program
    {
        static void Main(string[] args)
        {
            //inicializamos variable en 0, esta variable obtendra el numero que se quiera multiplicar
            int valor = 0;
            //llamamos el metodo que hace la multplicación
            TablaMultiplicar(valor);
            Console.ReadKey();

        }
        //este es el metodo que nos permitira hacer la operación
        static void TablaMultiplicar(int valor)
        {
            //la estructura while nos permitira hacer que la operacion se repita mientras se cumpla la condicion dada
            while (valor != -1)
            {

                Console.WriteLine("por favor ingrese el numero que quieras saber la tabla de multipilcar(La aplicación se cerrara si pones el (-1)");
                valor = Convert.ToInt32(Console.ReadLine());
                int valorAntiguio = valor;

                if (valor != -1)
                {
                    for (int i = 1; i < 11; i++)
                    {

                        Console.WriteLine("{0}*{1}={2}", valorAntiguio, i, valorAntiguio * i);
                    }
                }

            }





        }



    }
}
