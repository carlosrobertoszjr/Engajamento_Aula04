using System;
/*
Tendo como dado de entrada a altura (h) de uma pessoa, construa um algoritmo que calcule seu peso ideal, utilizando as seguintes fórmulas:
Para homens: (72.7*h) - 58
Para mulheres: (62.1*h) - 44.7
*/


class MainClass {

  public static double CalcPeso(double h, char sexo){
    double peso=-1;

    if (sexo=='H')
      peso = 72.7*h - 58;
    else 
      if (sexo=='M')
        peso = 62.1*h - 44.7;
        
    return peso;
  }

  public static double CalcPesoSwitch(double h, char sexo){

    switch (sexo){
      case 'H':
        return 72.7*h - 58;
      case 'M':
        return 62.1*h - 44.7;
      default:
        return -1;
    }
    
  }

  public static void Main (string[] args) {
    Console.WriteLine(CalcPesoSwitch(1.7, 'X'));
    
  }
}