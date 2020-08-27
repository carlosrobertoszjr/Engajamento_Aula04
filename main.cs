using System;

/***
1- Criar um programa que leia dois números inteiros, e que solicite ao usuário qual a operação deseja realizar entre esses números. Caso o usuário digitar o caractere “*” será realizada uma multiplicação, caso seja digitado o caractere “/” será realizada uma divisão, caso seja digitado o caractere “+”  será realizado uma adição, e caso seja digitado o caractere “–” será realizada uma subtração.
***/

class MainClass {

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
}