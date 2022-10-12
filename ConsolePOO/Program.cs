// See https://aka.ms/new-console-template for more information
using POO;
using static System.Net.Mime.MediaTypeNames;

Pessoa atleta = new Atleta("Nagayama", "Toshiba", 28);
atleta.Acordar();
atleta.Correr();
atleta.Dormir();

Console.WriteLine();
Console.WriteLine();

Pessoa sedentario = new Sedentario { PrimeiroNome = "Brendson", SegundoNome = "Oliveira", Idade = 62 };
sedentario.Acordar();
sedentario.Correr();
sedentario.Dormir();

Console.WriteLine();
Console.WriteLine();

Pessoa baladeiro = new Baladeiro { PrimeiroNome = "José", SegundoNome = "Bilau", Idade = 23 };
baladeiro.Acordar();
baladeiro.Correr();
baladeiro.Dormir();

