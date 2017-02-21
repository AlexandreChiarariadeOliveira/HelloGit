using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloGit
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "Rua abc, 35, Marilia, Sao Paulo";
            string[] teste = texto.Split(',');

            for (int i = 0; i < teste.Length; i++)
            {
                Console.WriteLine(teste[i]);
            }

            foreach (var c in teste)
            {
                Console.WriteLine(c);
            }
            
            Console.ReadKey();
        }
    }
}
