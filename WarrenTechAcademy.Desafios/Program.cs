using WarrenTechAcademy.Desafios;
/*
 * @author Gregory Viegas Zimmer
 * 
 * 
 * @param item int é uma variável criada para que o menu sejá apresentado ao usuário
 */

int item = 1;

/*
 * Loop para apresentar o menu e solicitar a opção desejada ao usuário, enquanto o valor de item for maior do que 0 o menu será
 * apresentado
 */
while (item > 0)
{
    /*
     * Menu de acesso aos algoritmos desenvolvidos. O usuário deve informar o número referente a opção desejada (1, 2, 3 ou 4)
     */
    Console.Write(@"
Olá, selecione o item desejado
------------MENU------------
1 - Desafio 01
2 - Desafio 02
3 - Desafio 03
4 - Sair
");

    item = Convert.ToInt32(Console.ReadLine());

    /*
     * Condicionador para quando o usuário informar o número 1
     * Neste caso o algoritmo irá executar o Desafio01.cs
     * Ao fim do algoritmo Desafio02.cs o valor da variável item continuará a ser 1, desta forma o menu será novamente apresentado
     */
    if (item == 1)
    {
        Desafio01 desafio01 = new Desafio01();
        desafio01.Executar();
    }

    /*
     * Condicionador para quando o usuário informar o número 2
     * Neste caso o algoritmo irá executar o Desafio02.cs
     * Ao fim do algoritmo Desafio02.cs o valor da variável item continuará a ser 2, desta forma o menu será novamente apresentado
     */
    else if (item == 2)
    {
        Desafio02 desafio02 = new Desafio02();
        desafio02.Executar();
    }

    /*
     * Condicionador para quando o usuário informar o número 3
     * Neste caso o algoritmo irá executar o Desafio03.cs
     * Ao fim do algoritmo Desafio03.cs o valor da variável item continuará a ser 3, desta forma o menu será novamente apresentado
     */
    else if (item == 3)
    {
        Desafio03 desafio03 = new Desafio03();
        desafio03.Executar();
    }

    /*
     * Condicionador para quando o usuário informar o número 4
     * Neste caso o valor da variável item passará a ser 0, desta forma não estando mais incluida no loop fazendo com que o altoritmo
     * sejá encerrado
     */
    else if (item == 4)
    {
        item = 0;
    }

    /*
     * Condicionador para quando o usuário informar qualquer número diferente de 1, 2, 3 ou 4
     * Neste caso o valor da variável item passará a ser 1, desta forma o menu será novamente apresentado
     */
    else
    {
        item = 1;
    }
}