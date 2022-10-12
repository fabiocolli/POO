using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    //Aqui temos exemplo de Herança, onde a classe atleta herda as funcionalidades, propriedades e atributos da classe Pessoa
    public class Baladeiro : Pessoa
    {
        public Baladeiro(string primeiroNome, string segundoNome, int idade)
        {
            this.PrimeiroNome = primeiroNome;
            this.SegundoNome = segundoNome;
            this.Idade = idade;
        }

        public Baladeiro()
        {

        }

        /*
         Abaixo temos os exemplos de polimorfirmo e encapsulamento, onde cada classe, respectivamente implementa o seu próprio
         comportamento e a implementação é omitida, ou seja não é precisa saber o que os métodos fazem para ser executado
        */

        public override void Acordar()
        {
            Console.WriteLine($"Eu sou o baladeiro e meu nome é {this.PrimeiroNome} {this.SegundoNome} e tenho {this.Idade} anos de idade.");
            Console.WriteLine("Só acordo depois da 13 horas.");
        }

        public override void Correr()
        {
            Console.WriteLine("Corro um pouquinho pra ter pique pra balada.");
        }

        public override void Dormir()
        {
            Console.WriteLine("Durmo muito, mas só durmo mal, afinal sou baladeiro.");
        }
    }
}
