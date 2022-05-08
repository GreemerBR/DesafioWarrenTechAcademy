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
    internal class Desafio02
    {
        public void Executar()
        {
            /*
             * @param totalAlunos int é a quantidade de alunos totais da turma
             * 
             * O usuário é solicitado a informar a quantidade de alunos que compõem a turma
             */
            Console.Clear();
            Console.Write(@"Olá professor!
Informe quantos alunos há em sua turma: ");
            int totalAlunos = Convert.ToInt32(Console.ReadLine());

            /*
             * @param alunosMinimos int é a quantidade mínima de alunos da turma necessários para que as aulas ocorram normalmente
             * 
             * O usuário é solicitado a informar a quantidade de alunos mínimos devem chegar no horário para que haja aula
             */
            Console.WriteLine();
            Console.Write("Agora informe qual a quantidade mínima de alunos para que a aula não seja cancelada: ");
            int alunosMinimos = Convert.ToInt32(Console.ReadLine());

            /*
             * O usuário é solicitado a informar os minutos que os alunos chegaram adiantados (números negativos) ou atrasados (números
             * positivos)
             */
            Console.Clear();
            Console.WriteLine("Informe quantos minutos o aluno chegou adiantado ou atrasado \n(utilize números negativos para chegadas adiantadas):");

            /*
             * @param noHorário int é a quantidade de alunos que chegaram no horário para a aula
             * @param indice int é o contador para que o loop while funcione
             */
            int noHorario = 0;
            int indice = 0;

            /*
             * Loop para receber os minutos que os alunos chegaram adiantados ou atrasados. Ele funciona enquanto o a varíavel indice
             * anteriormente criada for menor que a quantidade de alunos totais da sala informada anteriormente pelo usuário
             */
            while (indice < totalAlunos)
            {
                /*
                 * @param tempoChegada int são os minutos adiantados ou atrados que os alunos chegaram para a aula
                 */
                Console.Write("");
                int tempoChegada = Convert.ToInt32(Console.ReadLine());

                /*
                 * Condicionar para determinar quantos alunos não chegaram atrados. Sempre que um número negativo ou zero for informado
                 * a variável noHorario será incrementada
                 */
                if (tempoChegada <= 0)
                {
                    noHorario++;
                }

                indice++;
            }

            /*
             * Condicionador para determinar se haverá aula normal ou não. Caso a quantidade de alunos que chegaram no horário seja
             * maior ou igual a quantidade mínima necessária informada pelo usuário anteriormente uma mensagem informando que haverá
             * "Aula normal." será apresentada ao usuário
             */
            if (noHorario >= alunosMinimos)
            {
                Console.Clear();
                Console.WriteLine(@"Aula normal.

");
            }

            /*
             * Caso a quantidade mínima não seja atingida uma mensagem informando "Aula cancelada." será apresentada ao usuário
             */
            else
            {
                Console.Clear();
                Console.WriteLine(@"Aula cancelada.

");

            }
        }
    }
}
