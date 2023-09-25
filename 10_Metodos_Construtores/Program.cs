using Models;

public class Program
{
    public static void Main()
    {
        //Criando um objeto da classe Pessoa
        //Instanciando sem um método construtor
        /*Pessoa pessoa1 = new Pessoa();
        pessoa1.nome = "Bruna";
        pessoa1.idade = 16;
        pessoa1.Cantar();

        //Alternativa para criação de um objeto sem construtor
        Pessoa pessoa2 = new Pessoa{
            nome = "Kaio",
            idade = 16
        };
        pessoa2.Cantar();
        */
        Pessoa pessoa1 = new Pessoa("Bruna", 16, "brunadutra@aluno.senai.br");
        //pessoa1.Cantar();
        pessoa1.Informacoes();

        Pessoa pessoa2 = new Pessoa("Kaio", 16, "adalberto.albuquerque@aluno.senai.br");
        pessoa2.Informacoes();

        Pessoa pessoa3 = new Pessoa("Ana", 16, "anasantiago@aluno.senai.br");
        pessoa3.Informacoes();
    }
}
