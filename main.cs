using System;

/***
1- Criar um programa que leia dois números inteiros, e que solicite ao usuário qual a operação deseja realizar entre esses números. Caso o usuário digitar o caractere “*” será realizada uma multiplicação, caso seja digitado o caractere “/” será realizada uma divisão, caso seja digitado o caractere “+”  será realizado uma adição, e caso seja digitado o caractere “–” será realizada uma subtração.
***/

class MainClass {

  public static int LerNumb(char oper, int n1, int n2){
    
    switch(oper){
      case '+':
        return n1+n2;
      case '-':
        return n1-n2;
      case '*':
        return n1*n2;
      case '/':
        return n1/n2;
      default:
        return "erro";
    }
  }
  public static void Main () {
    Console.WriteLine("Informe o operador (+, -, *, /) ");
    oper = Console.ReadLine();
    Console.WriteLine("Informe o primeiro número >> ");
    n1 = (Console.ReadLine();
    Console.WriteLine("Informe o segundo número >> ");
    n2 = int.Parse(Console.ReadLine();
    Console.WriteLine(LerNumb(n1,n2,oper));
  }

}