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
    internal class Desafio01
    {
        public void Executar()
        {
            /*
             * @param contador int é a quantidade de números que quando somados com seus reversos geram um impar menor do que 1000000
             * @param texto string é uma variável criada para auxiliar a escrita dos números ao final do algoritmo
             * 
             * Enquanto o algoritmo está em andamento fazendo as análises a mensagem "Processando..." fica aparecendo na tela para
             * o usuário
             */
            Console.Clear();
            Console.WriteLine("Processando...");
            int contador = 0;
            string texto = "";

            /*
             * Loop para criar os número (n). Optou-se por iniciar o i em 12 visto que todas as somas de 1 à 9 geram pares, o reverso
             * de 10 irá começar com 0 não sendo permitido e o reverso de 11 é o próprio e irá gerar um par
             */
            for (int i = 12; i < 1000000; i++)
            {
                /*
                 * @param novaString string é a variável onde o reverso (n) formado será armazenado, porém em formato string
                 * @param novoI string é a variável criada para transformar o int i em string para se criar as novas substrings
                 */
                string novaString = "";
                string novoI = i.ToString();

                /*
                 * Loop para criar o reverso de (n). Optou-se por criar substrings nesta etapa para que fosse possível detarminar se
                 * o primeiro caractere seria 0 ou não, visto que reversos iniciados com 0 não são permitidos
                 */
                for (int j = 0; j < novoI.Length; j++)
                {
                    /*
                     * @param novaSubstring string é a variável que contem cada componente do reverso (n) formado, porém em formato string
                     */
                    string novaSubstring = novoI.Substring(j, 1);

                    novaString = novaSubstring + novaString;
                }

                /*
                 * @param primeiroCaractere string é a variável criada para armazenar o primeiro caracter do reverno (n) formado
                 */
                string primeiroCaractere = novaString.Substring(0, 1);

                /*
                 * Condicionador para converter o reverso (n) em tipo int, caso não se inicie com 0
                 */
                if (primeiroCaractere != "0")
                {
                    /*
                     * @param novoNumero int é o reverso (n) formado
                     * @param soma int é a soma do númnero (n) com seu reverso
                     */
                    int novoNumero = Convert.ToInt32(novaString);

                    int soma = i + novoNumero;

                    /*
                     * Condicionador para determinar se o número *n) e seu reverso irão gerar um número ímpar e se essa soma é menor
                     * do que um milhão (1000000). Caso ambas as informações sejam verdadeiras um contador será incrementado e o
                     * número (n) armazenado, ambas as variáveis servem para posterior informação ao usuário
                     */
                    if ((soma % 2 != 0) && (soma < 1000000))
                    {
                        contador++;
                        texto = texto + i + "; ";
                    }
                }
            }

            /*
             *Mensagem final apresentada ao usuário para que ele saiba quais e quantos números (n) que quando somados com seus reversos
             *irão gerar um ímpar menor que 1000000
             */
            Console.Clear();
            Console.WriteLine(texto + "\n\nOs " + contador + " números acima são todos aqueles cuja sua soma com seu reverso resultem em números ímpares que estão abaixo de 1 milhão.");
            Console.WriteLine(@"

");
        }
    }
}
