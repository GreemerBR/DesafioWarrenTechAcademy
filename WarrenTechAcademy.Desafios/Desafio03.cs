using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarrenTechAcademy.Desafios
{
    internal class Desafio03
    {
        public void Executar()
        {
            Console.Clear();
            Console.Write("Informe o número desejado: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            List<int> valor = new List<int>();
            int indice = 0;

            Console.Write("\nInsira os números pertencentes ao vetor. Estes devem ser positivos." +
          "\nCaso queira parar de inserir números digite um número negativo." +
          "\n");
            valor.Add(Convert.ToInt32(Console.ReadLine()));

            while (valor[indice] >= 0)
            {
                valor.Add(Convert.ToInt32(Console.ReadLine()));
                indice++;
            }

            
        }
    }
}
