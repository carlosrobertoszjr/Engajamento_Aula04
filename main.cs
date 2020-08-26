using System;

/***
1- Criar um programa que leia dois números inteiros, e que solicite ao usuário qual a operação deseja realizar entre esses números. Caso o usuário digitar o caractere “*” será realizada uma multiplicação, caso seja digitado o caractere “/” será realizada uma divisão, caso seja digitado o caractere “+”  será realizado uma adição, e caso seja digitado o caractere “–” será realizada uma subtração.
***/

class MainClass {

  public static int LerNumb(char oper, int n1, int n2){
    double resultado;
    switch(oper){
      case '+':
        resultado = n1+n2;
      case '-':
        resultado =  n1-n2;
      case '*':
        resultado =  n1*n2;
      case '/':
        resultado =  n1/n2;
      default:
        resultado =  -9;
    }return resultado;
  }
  public static void Main () {
    Console.WriteLine("Informe o operador (+, -, *, /) ");
    char oper = char.Parse(Console.ReadLine());
    Console.WriteLine("Informe o primeiro número >> ");
    int n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe o segundo número >> ");
    int n2 = int.Parse(Console.ReadLine());
    //Console.WriteLine(LerNumb(n1,n2,oper));
  }
}