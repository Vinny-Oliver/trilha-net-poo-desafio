using DesafioPOO.Models;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Testando a classe Nokia
        Smartphone nokia = new Nokia("5521993452122", "Nokia 3310", "5521995447892", 16);
        Console.WriteLine($"Modelo: {nokia.Modelo}, Número: {nokia.Numero}");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Dio");

        Console.WriteLine();

        // Testando a classe Iphone
        Smartphone iphone = new Iphone("5521993017520", "iPhone 14", "55219987752", 128);
        Console.WriteLine($"Modelo: {iphone.Modelo}, Número: {iphone.Numero}");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
