namespace Animais.Model
{
    //Declarando nossa classe Pantera
    public class Pantera
    {
        //Declarando nossos atributos (propriedades) da classe
        public double tamanho { get; set; }
        public int peso { get; set;}
        public string cor { get; set;}
        public string especie { get; set;}
        public string alimentacao { get; set; }

        //Criando um método
        public void Correr()
        {
            Console.WriteLine($"{especie} está correndo");
        }

        public void Cacar()
        {
            Console.WriteLine($"{especie} está caçando");
        }

        public void Reproduzir()
        {
            Console.WriteLine($"{especie} está se reproduzindo");
        }
    }
}