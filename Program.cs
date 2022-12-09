using System;

class DIO {
        
static void Main(string[] args){
        
        int n = int.Parse(Console.ReadLine());
        int produto = 1, soma = 0;
        while (n > 0 && n <=1000000){
             int digito = n % 10;
// TODO: Crie as outras condições necessárias para a resolução do desafio:
             produto *= digito;
             soma += digito;
             n /= 10;
           }

           Console.WriteLine(produto-soma);
        }
    }