using System;

class MainClass {

//----------------------------------------------------
/***
1- Criar um programa que leia dois números inteiros, e que solicite ao usuário qual a operação deseja realizar entre esses números. Caso o usuário digitar o caractere “*” será realizada uma multiplicação, caso seja digitado o caractere “/” será realizada uma divisão, caso seja digitado o caractere “+”  será realizado uma adição, e caso seja digitado o caractere “–” será realizada uma subtração.
***/

/*
  public static double LerNumb(char oper, double n1, double n2){
    double resultado;

    switch(oper){
        case '+':
          resultado = n1+n2;
          break;
        case '-':
          resultado =  n1-n2;
          break;
        case '*':
          resultado =  n1*n2;
          break;
        case '/':
          resultado =  n1/n2;
          break;
        default:
          resultado =  -1;
          break;
      }return resultado;
  }
  public static void Main () {
    //lendo variáveis
    Console.WriteLine("Informe o operador (+, -, *, /) ");
    char oper = char.Parse(Console.ReadLine());
    Console.WriteLine("Informe o primeiro número >> ");
    double n1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Informe o segundo número >> ");
    double n2 = double.Parse(Console.ReadLine());
    Console.Write("Resultado >> ");

    //chamando função
    Console.WriteLine(LerNumb(oper,n1,n2));
  }
*/

//-----------------------------------------------------

/***
2- O cardápio de uma casa de lanches é dado pela tabela abaixo:
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
***/

/*
  public static double LerProd(int cod, int quant){  
  
    double valor;

    switch(cod){
      case 100:
        valor = quant * 1.70;
        break;
      case 101:
        valor = quant * 2.30;
        break;
      case 102:
        valor = quant * 2.60;
        break;
      case 103:
        valor = quant * 2.40;
        break;
      case 104:
        valor = quant * 2.50;
        break;
      case 105:
        valor = quant * 1;
        break;
      default:
        valor = 0;
        break;
    }return valor;
     
  }

  public static void Main () {
    Console.WriteLine("Olá! Conforme tabela abaixo, escolha o produto e a quantidade:  \n \n Cod      Produto        Preço  \n 100  Cachorro quente   R$ 1,70 \n 101   Bauru Simples    R$ 2,30 \n 102   Bauru com ovo    R$ 2,60 \n 103   Hamburguer       R$ 2,40 \n 104   Cheeseburguer    R$ 2,50 \n 105   Refrigerante     R$ 1,00" );

    Console.Write("Informe o código do produto >> ");
    int cod = int.Parse(Console.ReadLine());
    Console.Write("Informe a quantidade do produto >> ");
    int quant = int.Parse(Console.ReadLine());
    //chamando função
    Console.Write("Valor Final >> ");
    Console.WriteLine(LerProd(cod,quant));
  }
*/

//-------------------------------------------------------


/***

3- Crie um programa que funcione para uma votação eleitoral. Existem três candidatos:
33 - José Couve
25 - Joana Bravo
10 - Roberto Nove
0 - Voto branco
4 - Voto nulo

Deseja-se saber:
- O candidato vencedor;
- O total de votos em branco;
- O total de votos nulos;

***/
/*
public static void Main () {
    
    char continuar = 's';
    int voto;
    int vbranco = 0;
    int vnulo = 0;

    int jose = 0;
    int joana = 0;
    int roberto = 0;
    
    while (continuar == 's'){
      //NUNCA CRIEM VARIAVEIS DENTRO DE LOOPS
      Console.Write ("Vote >> ");
      voto = int.Parse(Console.ReadLine());
      Console.Write ("Deseja continuar votando (s/n) >> ");
      continuar = char.Parse(Console.ReadLine());

      if (voto == 33)
        jose=jose + 1;
      if (voto == 25)
        joana+=1;
      if (voto == 10)
        roberto+=1;
      if (voto == 0)
        vbranco+=1;
      if (voto == 4)
        vnulo +=1;
    }

    if (jose > joana && jose > roberto){
      Console.WriteLine("José é o vencedor"); 
    }
    else if (joana > jose && joana > roberto){
      Console.WriteLine("Joana é a vencedora");
    }
    else if (roberto > jose && roberto > joana){
      Console.WriteLine("Roberto é o vencedor");
    }
    else if (joana == roberto & joana == jose && roberto == jose){
      Console.WriteLine("José, Joana e Roberto empataram.");
    }
    else if (jose == joana){
      Console.WriteLine("José e Joana empataram");
    }
    else if (jose == roberto){
      Console.WriteLine("José e Roberto empataram");
    }
    else if (joana == roberto){
      Console.WriteLine("Joana e Roberto empataram");
    }
    
    Console.WriteLine("Votos brancos >> {0} ",vbranco);
    Console.WriteLine("Votos nulos >> {0} ",vnulo);
  }
*/


}