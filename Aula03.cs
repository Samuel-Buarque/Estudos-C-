using System;

class Aula03{
    static void Main(){
        int num1,num2,res;
        num1=10;
        num2=5;
        res = num1 + num2;
        int num=0;
        char letra='s';
        float valor=2.1f;
        string nome = "samuel";
        var aux=nome;

        Console.WriteLine(num);
        Console.WriteLine(letra);
        Console.WriteLine(valor);
        Console.WriteLine(nome);
        Console.WriteLine("seu nome é:" + aux + ", e você tem 21 anos... Triste");
        Console.WriteLine("a soma de " + num1 + " + " + num2 +" é " + res +"!");
    }
}