// Somente declarando ima variável do tipo inteira e sem valor
//int num1;

// Declarando uma varável do tipo interiro atribuindo valor $
//int num2 = 5;

// Declarando variável String
//string nomeAluno = "Pedro";

// Variável do tipo lógico (true ou false)
//bool resultado = true;

// Variáveldo tipo double valor com várias casas decimais
//double coordenada = 1.803465628;

//Variável do tipo decimal - utilizada para valores
//decimal valor = 1.80M;

int idade = 16;
string meuNome = "Bruna";
Console.WriteLine($"Meu nome é {meuNome} e tenho {idade} anos");
Console.WriteLine("");
Console.WriteLine("Em qual cidade você nasceu?");
// ReadLine serve apenas par que eu receba uma informação do usuario e armazeno em uma variável
string nomeCidade = Console.ReadLine();
Console.WriteLine($"Você nasceu em {nomeCidade}");