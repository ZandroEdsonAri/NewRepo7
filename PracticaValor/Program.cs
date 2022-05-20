using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaValor
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // EjemploTresDatos();
            EjemploCuatroDatos();
        }
        static void EjemploTresDatos()
        {
            int valorUno = 0, valorDos = 0, valortres = 0;
            int maximoValor, mininoValor;
            Console.WriteLine("escriba valor uno:");
            valorUno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("escriba valor dos:");
            valorDos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("escriba valor tres:");
            valortres = Convert.ToInt32(Console.ReadLine());
            //para sacar mayor de 3 numeros
            if (valorUno > valorDos && valorUno > valortres)
            {
                maximoValor = valorUno;
            }
            else
            {
                if (valorDos> valorUno && valorDos>valortres)
                {
                    maximoValor=valorDos;
                }
                else
                {
                    maximoValor = valortres;
                }
            }
            
            //para valor minino de 3 valores
            if (valorUno < valorDos && valorUno < valortres)
            {
                mininoValor = valorUno;
            }
            else
            {
                if(valorDos<valorUno && valorDos <valortres)
                {
                    mininoValor = valorDos;
                }
                else
                {
                    mininoValor = valortres;
                }   
            }
            Console.WriteLine("el numero mayor es: " + maximoValor.ToString() + "\n\n");
            Console.WriteLine("el numero menor es: " + mininoValor.ToString() + "\n\n");      
        }
        
        
        static void EjemploCuatroDatos()
        {
            int valorUno = 0, valorDos = 0, valortres = 0, valorCuatro = 0;
            int maximoValor, mininoValor;
            Console.WriteLine("escriba valor uno:");
            valorUno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("escriba valor dos:");
            valorDos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("escriba valor tres:");
            valortres = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("escriba valor tres:");
            valorCuatro = Convert.ToInt32(Console.ReadLine());

            //Para sacar mayor de 4 valores
            if (valorUno > valorDos && valorUno > valortres && valorUno > valorCuatro )
            {
                maximoValor = valorUno;
            }
            else
            {
                if (valorDos > valorUno && valorDos > valortres && valorDos > valorCuatro)
                {
                    maximoValor = valorDos;
                }
                else
                {
                    if (valortres>valorUno && valortres > valorCuatro && valortres > valorDos)
                    {
                        maximoValor=valortres;
                    }
                    else
                    {
                        maximoValor = valorCuatro;
                    }
                }               
            }

            //Para sacar menor de 4 valores
            if (valorUno < valorDos && valorUno < valortres && valorUno< valorCuatro)
            {
                mininoValor = valorUno;
            }
            else
            {
                if (valorDos < valorUno && valorDos < valortres && valorDos < valorCuatro)
                {
                    mininoValor = valorDos;
                }
                else
                {
                    if (valortres<valorUno && valortres < valorCuatro && valortres < valorDos)
                    {
                        mininoValor = valortres;
                    }
                    else
                    {
                        mininoValor = valorCuatro;
                    }
                }
               
            }
            Console.WriteLine("el numero mayor es: " + maximoValor.ToString() + "\n\n");
            Console.WriteLine("el numero menor es: " + mininoValor.ToString() + "\n\n");
        }
    }
    
    
}
