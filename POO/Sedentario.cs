using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    //Aqui temos exemplo de Herança, onde a classe atleta herda as funcionalidades, propriedades e atributos da classe Pessoa
    public class Sedentario : Pessoa
    {
        public Sedentario(string primeiroNome, string segundoNome, int idade)
        {
            this.PrimeiroNome = primeiroNome;
            this.SegundoNome = segundoNome;
            this.Idade = idade;
        }

        public Sedentario()
        {

        }

        /*
         Abaixo temos os exemplos de polimorfirmo e encapsulamento, onde cada classe, respectivamente implementa o seu próprio
         comportamento e a implementação é omitida, ou seja não é precisa saber o que os métodos fazem para ser executado
        */

        public override void Acordar()
        {
            Console.WriteLine($"Eu sou o sedentário e meu nome é {this.PrimeiroNome} {this.SegundoNome} e tenho {this.Idade} anos de idade.");
            Console.WriteLine("Acordo todos os dias bem tarde e sem disposição.");
        }

        public override void Correr()
        {
            Console.WriteLine("Nem pensar eu vou correr. Muito menos fazer qualquer exercício");
        }

        public override void Dormir()
        {
            Console.WriteLine("A coisa que mais gosto de fazer é dormir.");
        }
    }
}
