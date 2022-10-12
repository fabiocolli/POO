namespace POO
{
    //Aqui temos o exemplo de abstração
    //Além disso há a proteção dos atributos da classe via propriedades
    public abstract class Pessoa
    {
        private string? primeiroNome { get; set; }
        private string? segundoNome { get; set; }
        private int idade { get; set; }

        public string PrimeiroNome
        {
            get
            {
                return primeiroNome;
            }

            set => primeiroNome = value;
        }

        public string SegundoNome
        {
            get
            {
                return segundoNome;
            }

            set => segundoNome = value;
        }

        public int Idade
        {
            get
            {
                return idade;
            }

            set => idade = value;
        }

        public abstract void Correr();
        public abstract void Acordar();
        public abstract void Dormir();

    }
}