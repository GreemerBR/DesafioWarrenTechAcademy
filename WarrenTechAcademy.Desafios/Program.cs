using WarrenTechAcademy.Desafios;

int item = 5;

while (item > 4)
{
    Console.Write(@"Olá, selecione o item desejado
------------MENU------------
1 - Desafio 01
2 - Desafio 02
3 - Desafio 03
4 - Sair

");

    item = Convert.ToInt32(Console.ReadLine());

    if (item == 1)
    {
        Desafio01 desafio01 = new Desafio01();
        desafio01.Executar();

        item = 5;
    }
    else if (item == 2)
    {
        Desafio02 desafio02 = new Desafio02();
        desafio02.Executar();
        item = 5;
    }
    else if (item == 3)
    {
        Desafio03 desafio03 = new Desafio03();
        desafio03.Executar();
        item = 5;
        item = 5;
    }
    else if (item == 4)
    {
        
        item = 0;
    }
    else
    {
        Console.WriteLine();
        item = 5;
    } 
}