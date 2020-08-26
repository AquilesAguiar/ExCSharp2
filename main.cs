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

  public static int votacao (int cod,int quant){
    int 
    while (quant)
    switch (cod){
      case 33:
        return
    }

  }




  // Função Principal Main

  public static void Main () {

    //Exercicio 1

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


    
    Console.WriteLine($"Preço Total: R$ {Cardapio(cod,quant)}");

    //Exercicio 3




   
  }
}