using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarrenTechAcademy.Desafios
{
    /* 
     * @author Gregory Viegas Zimmer
     */
    internal class Desafio03
    {
        public void Executar()
        {
            /*
             * @param numero int é o número que o usuário deseja que os números presentes no vetor cheguem ao serem somados
             * @param valor int é a variável na qual serão guardados os números que compõem o vetor
             * @param indice int é o contador para que o loop while funcione
             * 
             * O usuário é solicitado a informar o número que deseja que os números presentes no vetor cheguem ao serem somados
             */
            Console.Clear();
            Console.Write("Informe o número desejado: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            List<int> valor = new List<int>();
            int indice = 0;

            /*
             * Aqui o usuário é solicitado a informar os números que irão compor o vetor
             */
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
