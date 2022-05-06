using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarrenTechAcademy.Desafios
{
    internal class Desafio02
    {
        public void Executar()
        {

            Console.Write(@"Olá professor!
Informe qual o limite de alunos para que a aula não seja cancelada: ");
            int minimo = Convert.ToInt32(Console.ReadLine());

            int noHorario = 0;
            string aviso = "Aula normal";

            while (noHorario < minimo)
            {
                Console.Clear();
                Console.WriteLine("Informe quantos minutos o aluno chegou adiantado ou atrasado (utilize números negativos para chegadas adiantadas): ");
                int tempoChegada = Convert.ToInt32(Console.ReadLine());

                if (tempoChegada > 0)
                {
                    aviso = "Aula cancelada";
                    atrasados++;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(aviso);
                }
            }

            Console.Clear();
            Console.WriteLine(aviso);

        }
    }
}
