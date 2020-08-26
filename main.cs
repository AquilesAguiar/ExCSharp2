using System;

class MainClass {

/* 1- Criar um programa que leia dois números inteiros, e que solicite ao usuário qual a operação 
deseja realizar entre esses números. Caso o usuário digitar o caractere “*” será realizada uma multiplicação, 
caso seja digitado o caractere “/” será realizada uma divisão, caso seja digitado o caractere “+” 
será realizado uma adição, e caso seja digitado o caractere “–” será realizada uma subtração. */


  public static int Caculadora (int num,int num2,char sinal){
    switch(sinal){
      case '+':
        return num+num2;
      case '-':
        return num-num2;
      case '*':
        return num*num2;
      case '/':
        return num/num2;
      default:
        return 0;
    }
  }


/* 2- O cardápio de uma casa de lanches é dado pela tabela abaixo:
Código Produto Preço Unitário (R$)
---------------------------------
100  Cachorro quente   R$ 1,70
101   Bauru Simples    R$ 2,30
102   Bauru com ovo    R$ 2,60
103   Hamburguer       R$ 2,40
104   Cheeseburguer    R$ 2,50
105   Refrigerante     R$ 1,00
----------------------------------
Escreva um algoritmo que leia o código do item adquirido pelo consumidor e a
quantidade, calculando e mostrando o valor a pagar. Não será necessário exibir o produto
e o valor, somente o valor final
*/

  public static double Cardapio(int cod, int quant){
      switch(cod){
        
        case 100:
          return 1.70*quant;
        
        case 101:
          return 2.30*quant;
        
        case 102:
          return 2.60*quant;
        
        case 103:
          return 2.40*quant;
        
        case 104:
          return 2.50*quant;
        
        case 105:
          return 1*quant;
        
        default:
          return 0;
      }
    }





/* 3- Crie um programa que funcione para uma votação eleitoral. Existem três candidatos:
33 - José Couve
25 - Joana Bravo
10 - Roberto Nove
0 - Voto branco
4 - Voto nulo

Deseja-se saber:
- O candidato vencedor;
- O total de votos em branco;
- O total de votos nulos; */

  public static string votacao (int cod){

    switch ( cod ) {
      case 33:
        return "Você Votou em José Couve";
      
      case 25:
        return "Você Votou em Joana Bravo";
      
      case 10:
        return "Você Votou em Roberto Nove";
      
      case 0:
        return "Você Votou em Voto branco";
      
      case 4:
       return "Você Votou em Voto nulo";
      
      default:
        return "DIGITA CERTO";
      }

  }

  public static int totais (int cand_1, int cand_2, int cand_3, int branco, int nulo) {
    
    int maior = cand_1;

    if (cand_2 > maior)
      maior = cand_2;
    
    
    else if (cand_3 > maior)
      maior = cand_3;
    

    else if (branco > maior)
      maior = branco;
    

    else
      maior = branco;
    
    return maior;

  }




  // Função Principal Main

  public static void Main () {

    /*//Exercicio 1

    Console.WriteLine("Exercicio 1");

    int num,num2;
    char ope;

    Console.Write("Insira o Primeiro Numero >>");
    num = int.Parse(Console.ReadLine());

    Console.Write("Insira o Segundo Numero >>");
    num2 = int.Parse(Console.ReadLine());

    Console.Write("Insira a operação desejada >>");
    ope = char.Parse(Console.ReadLine());

    Console.WriteLine($"Seu resultado >> {Caculadora(num,num2,ope)}");


    //Exercicio 2
    
    Console.WriteLine("Exercicio 2");

    int cod,quant;


    Console.WriteLine("\n---------------------------------\n100  Cachorro quente   R$ 1,70\n101   Bauru Simples    R$ 2,30\n102   Bauru com ovo    R$ 2,60\n103   Hamburguer       R$ 2,40\n104   Cheeseburguer    R$ 2,50\n105   Refrigerante     R$ 1,00\n----------------------------------");

    Console.Write("Insira o código do produto >>");
    cod = int.Parse(Console.ReadLine());

    Console.Write("Insira a quantidade do produto >>");
    quant = int.Parse(Console.ReadLine());


    
    Console.WriteLine($"Preço Total: R$ {Cardapio(cod,quant)}");*/

    //Exercicio 3

    //Variaveis dos candidatos
    
    int cand_1 = 0;
    int cand_2 = 0;
    int cand_3 = 0;
    int branco = 0;
    int nulo   = 0;

    // While
    
    int contador = 0;

    Console.Write("Quantidade de Eleitores >> ");

    int quant = int.Parse(Console.ReadLine());
    
    do {
      
      Console.Write("Digite o Código do Candidato >> ");

      int cod = int.Parse(Console.ReadLine());

      Console.WriteLine(votacao(cod));

      contador ++;

      switch (cod){
        case 33:
          cand_1 ++;
          break;
        
        case 25:
          cand_2 ++;
          break;
        
        case 10:
          cand_3 ++;
          break;
        
        case 0:
          branco ++;
          break;
        
        case 4:
          nulo ++;
          break;

        default:
          Console.WriteLine( "DIGITA CERTO" );
          break;
      }
    }

    while (contador < quant);

    Console.WriteLine($"O maior{totais(cand_1,cand_2,cand_3,branco,nulo)}");
    Console.WriteLine($"Numeros De Votos Brancos >> {branco}");
    Console.WriteLine($"Numeros De Votos Nulos >> {nulo}");

  }
}