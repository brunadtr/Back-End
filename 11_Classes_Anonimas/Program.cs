public class Program
{
    public static void Main()
    {
        //Criando uma classe anônima (classe sem definição inicial)
        var pessoa1 = new {
            nome = "João",
            idade = 17
        };
        var pessoa2 = new {
            nome = "Maria",
            email = "maria@aluno.senai.br"
        };

        Console.WriteLine($"A pessoa1 é {pessoa1.nome} e tem {pessoa1.idade} anos");
        Console.WriteLine($"A pessoa2 é {pessoa2.nome} e seu email é {pessoa2.email}");

        //Criar 2 objetos de classe anonima de Carro
        var carro1 = new {
            marca = "BMW",
            modelo = "BWM Série 3",
            ano = 2020
        };
        var carro2 = new {
            marca = "Honda",
            modelo = "Civic",
            ano = 2022
        };

        Console.WriteLine($"O carro1 é da marca {carro1.marca}, do modelo {carro1.modelo} e do ano de {carro1.ano}");
        Console.WriteLine($"O carro2 é da marca {carro2.marca}, do modelo {carro2.modelo} e do ano de {carro2.ano}");
    }
}
