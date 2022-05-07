<h1 align="center">Warren Academy < Edição_Tech ></h1>

<p align="center">
 <a href="#objetivo">Objetivo</a> •
 <a href="#tecnologias">Tecnologias</a> • 
 <a href="#instalação">Instalação</a> • 
 <a href="#execução">Execução</a> •  
 <a href="#documentação-do-sistema">Documentação</a> •
 <a href="#questão-1">Questão 1</a> •
 <a href="#questão-2">Questão 2</a> •
 <a href="#questão-3">Questão 3</a> •
 <a href="#autor">Autor</a>
</p>

  
## Objetivo

O objetivo deste, foi desenvolver algoritmos em linguagem C# para suprir as necessidades propostas pelo Desafio de Programação do processo seletivo da Warren Tech Academy. 

  
##  Tecnologias

As seguintes ferramentas foram usadas na construção do projeto:

* <b>C#</b>;
* <b>Visual Studio 2022</b>;
* <b>.NET 6.0</b>
* <b>GitHub</b>.

## Instalação

* Você vai precisar ter instalado em sua máquina o [Visual Studio 2022](https://visualstudio.microsoft.com/pt-br/downloads/).

* Além disso, também é necessário possuir o [.NET 6.0](https://dotnet.microsoft.com/en-us/download). Antes de realizar o download deste, verifique por meio de um terminal (Prompt de Comando) utilizando o seguinte comando:
  
```
dotnet --version
```
  
* Caso apareça a versão `6.0` o download não é necessário. Da mesma maneira, caso seja necessário instalação, utilize o comando acima para verificar se a instalação foi bem sucedida.

  
## Execução

Para a execução dos algoritmos você pode optar por duas formas:
  
**Por meio do Visual Studio 2022**
  
* Abra o <b>Visual Studio 2022</b>;
* Clone este repositório por meio do link `https://github.com/GreemerBR/DesafioWarrenTechAcademy.git`;
* Após a cloonagem do repositório terminar clique em `View` e após em `Solution Explorer`;
* Na janela que se abriu de um duplo clique em `WarrenTechAcademy.sln`;
* Por fim clique em `F5` e o algoritmo será executado.
    
**Por meio do Prompt de Comando** 
  
* Clique na opção `CODE` localizada na parte superior desta página para fazer o download do arquivo `DesafioWarrenTechAcademy-main.zip`;
* Descompacte o arquivo `DesafioWarrenTechAcademy-main.zip` localmente;
* Entre na pasta que foi descompactada e abra um terminal. Em seguinda digite:

```
dotnet publish
```
  
* Após clicar em enter e esperar a finalização do comando acima, digite:
  
```
cd WarrenTechAcademy.Desafios/bin/Debug/net6.0
```
  
* Por fim, após estar no diretório net6.0, basta digitar o comando abaixo e apertar enter para executar o algoritmo.
  
```
WarrenTechAcademy.Desafios.exe
```

  
## Documentação do Sistema

* O algoritmo foi desenvolvido com auxílio da IDE <b>Visual Studio 2022</b> utilizando a linguagem <b>C#</b>.
  
* Após a execução do mesmo, independente do modo acima escolhido, o seguinte menu será apresentado ao usuário:
  
```
Olá, selecione o item desejado
------------MENU------------
1 - Desafio 01
2 - Desafio 02
3 - Desafio 03
4 - Sair
```

* O usuário deve então informar um dos quatro valores `1`, `2`, `3` ou `4` conforme opção desejada;
* Caso informe qualquer valor diferente dos acima citados o menu continuará a ser apresentado ao usuário até que uma opção válida seja informada;
* Da mesma forma, após a finalização dos `Desafios 01`, `02` ou `03` o menu voltará a ser apresentado ao usuário, sendo necessário informar a opção `4` para que o algoritmo seja finalizado.
  

### Questão 1
 
Alguns números inteiros positivos n possuem uma propriedade na qual a soma de n + reverso(n) resultam em números ímpares. Por exemplo, 36 + 63 = 99 e 409 + 904 = 1313. Considere que n ou reverso(n) não podem começar com 0.

Existem 120 números reversíveis abaixo de 1000.

Construa um algoritmo que mostre na tela todos os números n onde a soma de n + reverso(n) resultem em números ímpares que estão abaixo de 1 milhão.

  
### Questão 2

Um professor de programação, frustrado com a falta de disciplina de seus alunos, decidi cancelar a aula se menos de x alunos estiverem presentes quando a aula for iniciada. O tempo de chegada varia entre:

* Normal: tempoChegada <= 0
* Atraso: tempoChegada > 0
  
Construa um algoritmo que dado o tempo de chegada de cada aluno e o limite x de alunos presentes, determina se a classe vai ser cancelada ou não ("Aula cancelada” ou “Aula normal”).

**Exemplo:**

* Entrada de dados:
  
    x = 3  
    tempoChegada = [-2, -1, 0, 1, 2]

* Saída de dados:
  
    Aula normal.

* Explicação:
  
    Os três primeiros alunos chegaram no horário. Os dois últimos estavam atrasados. O limite é de três alunos, portanto a aula não será cancelada.

  
### Questão 3

Dado um vetor de números e um número n. Determine a soma com o menor número de elementos entre os números do vetor mais próxima de n e também mostre os elementos que compõem a soma. Para criar a soma, utilize qualquer elemento do vetor uma ou mais vezes.

**Exemplo:**

* Entrada de dados:

    N = 10  
    V = [2, 3, 4]

* Saída de dados:

    10  
    [2, 4, 4]  
    [3, 3, 4]

* Explicação:

    Se N = 10 e V = [2, 3, 4] você pode utilizar as seguintes soma: [2, 2, 2, 2, 2], [2, 2, 3, 3], [2, 4, 4] ou [3, 3, 4]. Como a quantidade de elementos em [2, 4, 4] e [3, 3, 4] é igual, os dois conjuntos devem ser mostrados.

  
## Autor

<img src="https://avatars.githubusercontent.com/u/83144131?v=4" width="100px;" alt=""/>
<p>Gregory Viegas Zimmer</p>

Eng. Civil 👷🏻, Mestre em Eng. Ambiental 💧 e aspirante a desenvolvedor👨🏻‍💻. Entre em contato!

[![WhatsApp Badge](https://img.shields.io/badge/WhatsApp-25D366?style=for-the-badge&logo=whatsapp&logoColor=white)](https://wa.me/5547991885219) 
[![Gmail Badge](https://img.shields.io/badge/Gmail-D14836?style=for-the-badge&logo=gmail&logoColor=white&link=mailto:gregory.v.zimmer@gmail.com)](mailto:gregory.v.zimmer@gmail.com)
 
