using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarrenTechAcademy.Desafios
{
    internal class Desafio01
    {
        public void Executar()
        {
            Console.WriteLine("Processando...");
            int contador = 0;
            string texto = "";

            for (int i = 0; i < 1000000; i++)
            {
                string novaString = "";
                string novoI = i.ToString();

                for (int j = 0; j < novoI.Length; j++)
                {
                    string novaSubstring = novoI.Substring(j, 1);

                    novaString = novaSubstring + novaString;
                }

                string primeiroCaractere = novaString.Substring(0, 1);
                if (primeiroCaractere != "0")
                {
                    int novoNumero = Convert.ToInt32(novaString);

                    int soma = i + novoNumero;
                    if ((soma % 2 != 0) && (soma < 1000000))
                    {
                        contador++;
                        texto = texto + i + "; ";
                    }
                }
            }
            Console.Clear();
            Console.WriteLine(texto + "\n\nOs " + contador + " números acima são todos aqueles cuja sua soma com seu reverso resultem em números ímpares que estão abaixo de 1 milhão.");
        }
    }
}
