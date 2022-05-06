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
            Console.Clear();
            Console.Write(@"Olá professor!
Informe quantos alunos há em sua turma: ");
            int totalAlunos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Agora informe qual a quantidade mínima de alunos para que a aula não seja cancelada: ");
            int alunosMinimos = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Informe quantos minutos o aluno chegou adiantado ou atrasado \n(utilize números negativos para chegadas adiantadas):");

            int noHorario = 0;
            int indice = 0;
            while (indice < totalAlunos)
            {
                Console.Write("");
                int tempoChegada = Convert.ToInt32(Console.ReadLine());

                if (tempoChegada <= 0)
                {
                    noHorario++;
                }

                indice++;
            }

            if (noHorario >= alunosMinimos)
            {
                Console.Clear();
                Console.WriteLine(@"Aula normal.



");
            }
            else
            {
                Console.Clear();
                Console.WriteLine(@"Aula cancelada.



");

            }
        }
    }
}
