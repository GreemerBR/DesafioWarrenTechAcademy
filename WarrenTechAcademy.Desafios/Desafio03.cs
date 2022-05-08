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
            int[] valor = new int[3];
            int indice = 0;

            /*
             * Aqui o usuário é solicitado a informar os números que irão compor o vetor
             */
            Console.Write("\nInsira os números pertencentes ao vetor." +
          "\n");

            /*
             * Loop para receber valores que compõem o vetor. Ele funciona enquanto o a varíavel indice anteriormente criada for menor que 3
             */
            while (indice < 3)
            {
                valor[indice] = (Convert.ToInt32(Console.ReadLine()));
                indice++;
            }

            /*
             * Condicionador para determinar se um dos três componentes do vetor é o próprio número informado pelo usuário.
             * Caso seja, a resposta esperada pelo algoritmo será apresentada, sendo está o número informado seguido pelo vetor contendo o próprio número apresentado pelo usuário
             */
            if (valor[0] == numero || valor[1] == numero || valor[2] == numero)
            {
                Console.Clear();
                Console.WriteLine(numero);
                Console.WriteLine("[" + numero + "]");
                Console.WriteLine(@"
");
            }

            /*
             * Condicionador para determinar possíveis combinações
             */
            else if ((valor[0] != numero || valor[1] != numero || valor[2] != numero))
            {

                /*
                 * Loop duplo para criar as combinações de dois valores existentes no vetor que quando somados chegam ao valor do número informado pelo usuário
                 * 
                 * Para isso criou-se a lista combinacoesExatasCom2, que armazenará as combinações de dois valores existentes no vetor que formem o número informado pelo usuário
                 */
                List<Tuple<int, int>> combinacoesExatasCom2 = new List<Tuple<int, int>>();
                for (int i = 0; i < indice; i++)
                {
                    for (int j = 0; j < indice; j++)
                    {

                        /*
                         * Condicionador para elimina as permutaçoes, após verificação essa combinação será armazenada como combinacaoExataCom2
                         */
                        if (!(combinacoesExatasCom2.Contains(new Tuple<int, int>(valor[i], valor[j])) || combinacoesExatasCom2.Contains(new Tuple<int, int>(valor[i], valor[j]))
                            || combinacoesExatasCom2.Contains(new Tuple<int, int>(valor[j], valor[i])) || combinacoesExatasCom2.Contains(new Tuple<int, int>(valor[j], valor[i]))
                            || combinacoesExatasCom2.Contains(new Tuple<int, int>(valor[i], valor[j])) || combinacoesExatasCom2.Contains(new Tuple<int, int>(valor[j], valor[i]))))
                        {
                            Tuple<int, int> combinacaoExataCom2 = new Tuple<int, int>(valor[i], valor[j]);

                            /*
                             * Caso a soma dos componentes desta combinacaoExataCom2 seja igual ao número informado pelo usuário ela será adicionada na lista combinacoesExatasCom2
                             */
                            if ((valor[i] + valor[j]) == numero)
                                combinacoesExatasCom2.Add(combinacaoExataCom2);

                        }
                    }
                }
                /*
                 * Caso hajam combinações existentes na lista combinacoesExatasCom2 a resposta esperada pelo algoritmo será apresentada, sendo está o número apresentado pelo usuário 
                 * seguido por um vetor contendo os dois valores existentes no vetor que quando somados chegam ao número apresentado pelo usuário
                 */
                Console.Clear();
                Console.WriteLine(numero);
                foreach (Tuple<int, int> combinacaoExataCom2 in combinacoesExatasCom2)
                    Console.WriteLine("[" + combinacaoExataCom2.Item1 + " " + combinacaoExataCom2.Item2 + "]");
                Console.WriteLine(@"
");

                /*
                 * Condicionador para o caso de não haverem combinações de dois valores no vetor que quando somados cheguem ao valor apresentado pelo usuário, neste caso, possíveis
                 * combinações dos três valores contidos no vetor serão verificadas
                 */
                if (combinacoesExatasCom2.Count == 0)
                {

                    /*
                     * Loop triplo para criar as combinações de três valores existentes no vetor que quando somados chegam ao valor do número informado pelo usuário
                     * 
                     * Para isso criou-se a lista combinacoesExatasCom3, que armazenará as combinações de três valores existentes no vetor que formem o número informado pelo usuário
                     */
                    List<Tuple<int, int, int>> combinacoesExatasCom3 = new List<Tuple<int, int, int>>();
                    for (int i = 0; i < indice; i++)
                    {
                        for (int j = 0; j < indice; j++)
                        {
                            for (int k = 0; k < indice; k++)
                            {

                                /*
                                 * Condicionador para elimina as permutaçoes, após verificação essa combinação será armazenada como combinacaoExataCom3
                                 */
                                if (!(combinacoesExatasCom3.Contains(new Tuple<int, int, int>(valor[i], valor[j], valor[k])) || combinacoesExatasCom3.Contains(new Tuple<int, int, int>(valor[i], valor[k], valor[j]))
                                    || combinacoesExatasCom3.Contains(new Tuple<int, int, int>(valor[j], valor[k], valor[i])) || combinacoesExatasCom3.Contains(new Tuple<int, int, int>(valor[j], valor[i], valor[k]))
                                    || combinacoesExatasCom3.Contains(new Tuple<int, int, int>(valor[k], valor[i], valor[j])) || combinacoesExatasCom3.Contains(new Tuple<int, int, int>(valor[k], valor[j], valor[i]))))//elimina as permutaçoes, tipo azul-verde, verde-azul
                                {
                                    Tuple<int, int, int> combinacaoExataCom3 = new Tuple<int, int, int>(valor[i], valor[j], valor[k]);


                                    /*
                                     * Caso a soma dos componentes desta combinacaoExataCom3 seja igual ao número informado pelo usuário ela será adicionada na lista combinacoesExatasCom3
                                     */
                                    if ((valor[i] + valor[j] + valor[k]) == numero)
                                        combinacoesExatasCom3.Add(combinacaoExataCom3);
                                }
                            }
                        }
                    }
                    /*
                     * Caso hajam combinações existentes na lista combinacoesExatasCom3 a resposta esperada pelo algoritmo será apresentada, sendo está o número apresentado pelo usuário 
                     * seguido por um vetor contendo os três valores existentes no vetor que quando somados chegam ao número apresentado pelo usuário
                     */
                    Console.Clear();
                    Console.WriteLine(numero);
                    foreach (Tuple<int, int, int> combinacaoExataCom3 in combinacoesExatasCom3)
                        Console.WriteLine("[" + combinacaoExataCom3.Item1 + " " + combinacaoExataCom3.Item2 + " " + combinacaoExataCom3.Item3 + "]");
                    Console.WriteLine(@"
");

                    /*
                     * Condicionador para o caso de não haverem combinações de três valores no vetor que quando somados cheguem ao valor apresentado pelo usuário
                     * Neste caso, os valores mais próximos ao número informado pelo usuário (números imediatamente anterior e posterior) serão verificados através de possíveis valores 
                     * individuais e combinações de dois e três valores contidos no vetor
                     */
                    if (combinacoesExatasCom3.Count == 0)
                    {

                        /*
                         * Condicionador para determinar se um dos três componentes do vetor é o número posterior ao número informado pelo usuário.
                         * Caso seja, a resposta esperada pelo algoritmo será apresentada, sendo está o número apresentado pelo usuário seguido do vetor contendo o número posterior ao
                         * número apresentado pelo usuário
                         */
                        if (valor[0] == (numero + 1) || valor[1] == (numero + 1) || valor[2] == (numero + 1))
                        {
                            Console.Clear();
                            Console.WriteLine(numero);
                            Console.WriteLine("[" + (numero + 1) + "]");

                            /*
                             * Condicionador para determinar se um dos três componentes do vetor é o valor anterior ao número informado pelo usuário.
                             * Caso seja, a resposta esperada pelo algoritmo será apresentada, sendo está o número apresentado pelo usuário seguido do vetor contendo o número anterior
                             * ao número apresentado pelo usuário
                             */
                            if (valor[0] == (numero - 1) || valor[1] == (numero - 1) || valor[2] == (numero - 1))
                            {
                                Console.WriteLine("[" + (numero - 1) + "]");
                            }

                            Console.WriteLine(@"
");
                        }

                        /*
                         * Condicionador para determinar possíveis combinações
                         */
                        else if ((valor[0] != (numero + 1) || valor[1] != (numero + 1) || valor[2] != (numero + 1))
                            && (valor[0] != (numero - 1) || valor[1] != (numero - 1) || valor[2] != (numero - 1)))
                        {

                            /*
                             * Loop duplo para criar as combinações de dois valores existentes no vetor que quando somados chegam o mais próximos ao valor do número informado pelo usuário
                             * 
                             * Para isso criou-se a lista combinacoesProximasCom2, que armazenará as combinações de dois valores existentes no vetor que se aproximem do número informado
                             * pelo usuário
                             */
                            List<Tuple<int, int>> combinacoesProximasCom2 = new List<Tuple<int, int>>();
                            for (int i = 0; i < indice; i++)
                            {
                                for (int j = 0; j < indice; j++)
                                {

                                    /*
                                     * Condicionador para elimina as permutaçoes, após verificação essa combinação será armazenada como combinacaoProximaCom2
                                     */
                                    if (!(combinacoesProximasCom2.Contains(new Tuple<int, int>(valor[i], valor[j])) || combinacoesProximasCom2.Contains(new Tuple<int, int>(valor[i], valor[j]))
                                        || combinacoesProximasCom2.Contains(new Tuple<int, int>(valor[j], valor[i])) || combinacoesProximasCom2.Contains(new Tuple<int, int>(valor[j], valor[i]))
                                        || combinacoesProximasCom2.Contains(new Tuple<int, int>(valor[i], valor[j])) || combinacoesProximasCom2.Contains(new Tuple<int, int>(valor[j], valor[i]))))//elimina as permutaçoes, tipo azul-verde, verde-azul
                                    {
                                        Tuple<int, int> combinacaoProximaCom2 = new Tuple<int, int>(valor[i], valor[j]);

                                        /*
                                         * Caso a soma dos componentes desta combinacaoProximaCom2 seja igual ao número imediatamente inferior ou superior ao informado pelo usuário
                                         * ela será adicionada na lista combinacoesProximasCom2
                                         */
                                        if ((valor[i] + valor[j]) == (numero - 1) || (valor[i] + valor[j]) == (numero + 1))
                                            combinacoesProximasCom2.Add(combinacaoProximaCom2);

                                    }
                                }
                            }

                            /*
                             * Caso hajam combinações existentes na lista combinacoesProximasCom2 a resposta esperada pelo algoritmo será apresentada, sendo está o número apresentado pelo usuário 
                             * seguido por um vetor contendo os dois valores existentes no vetor que quando somados chegam o mais próximo ao número apresentado pelo usuário
                             */
                            Console.Clear();
                            Console.WriteLine(numero);
                            foreach (Tuple<int, int> combinacaoProximaCom2 in combinacoesProximasCom2)
                                Console.WriteLine("[" + combinacaoProximaCom2.Item1 + " " + combinacaoProximaCom2.Item2 + "]");
                            Console.WriteLine(@"
");

                            /*
                             * Condicionador para o caso de não haverem combinações de dois valores no vetor que quando somados cheguem o mais próximo do valor apresentado pelo usuário,
                             * neste caso, possíveis combinações dos três valores contidos no vetor serão verificadas
                             */
                            if (combinacoesProximasCom2.Count == 0)
                            {

                                /*
                                 * Loop triplo para criar as combinações de três valores existentes no vetor que quando somados chegam o mais próximos ao valor do número informado pelo usuário
                                 * 
                                 * Para isso criou-se a lista combinacoesProximasCom3, que armazenará as combinações de três valores existentes no vetor que se aproximem do número informado
                                 * pelo usuário
                                 */
                                List<Tuple<int, int, int>> combinacoesProximasCom3 = new List<Tuple<int, int, int>>();
                                for (int i = 0; i < indice; i++)
                                {
                                    for (int j = 0; j < indice; j++)
                                    {
                                        for (int k = 0; k < indice; k++)
                                        {

                                            /*
                                             * Condicionador para elimina as permutaçoes, após verificação essa combinação será armazenada como combinacaoProximaCom3
                                             */
                                            if (!(combinacoesProximasCom3.Contains(new Tuple<int, int, int>(valor[i], valor[j], valor[k])) || combinacoesProximasCom3.Contains(new Tuple<int, int, int>(valor[i], valor[k], valor[j]))
                                                || combinacoesProximasCom3.Contains(new Tuple<int, int, int>(valor[j], valor[k], valor[i])) || combinacoesProximasCom3.Contains(new Tuple<int, int, int>(valor[j], valor[i], valor[k]))
                                                || combinacoesProximasCom3.Contains(new Tuple<int, int, int>(valor[k], valor[i], valor[j])) || combinacoesProximasCom3.Contains(new Tuple<int, int, int>(valor[k], valor[j], valor[i]))))//elimina as permutaçoes, tipo azul-verde, verde-azul
                                            {
                                                Tuple<int, int, int> combinacaoProximaCom3 = new Tuple<int, int, int>(valor[i], valor[j], valor[k]);

                                                /*
                                                 * Caso a soma dos componentes desta combinacaoProximaCom3 seja igual ao número imediatamente inferior ou superior ao informado pelo usuário
                                                 * ela será adicionada na lista combinacoesProximasCom3
                                                 */
                                                if ((valor[i] + valor[j] + valor[k]) == (numero - 1) || (valor[i] + valor[j] + valor[k]) == (numero + 1))
                                                    combinacoesProximasCom3.Add(combinacaoProximaCom3);
                                            }
                                        }
                                    }
                                }

                                /*
                                 * Caso hajam combinações existentes na lista combinacoesProximasCom3 a resposta esperada pelo algoritmo será apresentada, sendo está o número apresentado pelo usuário 
                                 * seguido por um vetor contendo os três valores existentes no vetor que quando somados chegam o mais próximo ao número apresentado pelo usuário
                                 */
                                Console.Clear();
                                Console.WriteLine(numero);
                                foreach (Tuple<int, int, int> combinacaoProximaCom3 in combinacoesProximasCom3)
                                    Console.WriteLine("[" + combinacaoProximaCom3.Item1 + " " + combinacaoProximaCom3.Item2 + " " + combinacaoProximaCom3.Item3 + "]");
                                Console.WriteLine(@"
");
                            }                            
                        }
                    }
                }
            }
        }
    }
}