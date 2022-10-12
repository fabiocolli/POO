using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    //Aqui temos exemplo de Herança, onde a classe atleta herda as funcionalidades, propriedades e atributos da classe Pessoa
    public class Atleta : Pessoa
    {
        public Atleta(string primeiroNome, string segundoNome, int idade)
        {
            this.PrimeiroNome = primeiroNome;
            this.SegundoNome = segundoNome;
            this.Idade = idade;
        }
        public Atleta()
        {

        }

        /*
         Abaixo temos os exemplos de polimorfirmo e encapsulamento, onde cada classe, respectivamente implementa o seu próprio
         comportamento e a implementação é omitida, ou seja não é precisa saber o que os métodos fazem para ser executado
        */

        public override void Acordar()
        {
            Console.WriteLine($"Eu sou o atleta e meu nome é {this.PrimeiroNome} {this.SegundoNome} e tenho {this.Idade} anos de idade.");
            Console.WriteLine("Eu acordo bem cedo pra fazer exercícios");
        }

        public override void Correr()
        {
            Console.WriteLine("Eu não sou corredor, mas consigo correr bem, por que faço outros exercícios");
        }

        public override void Dormir()
        {
            Console.WriteLine("Eu durmo bem cedo por que sou atleta. Atletas precisam dormir bem.");
        }
    }
}
