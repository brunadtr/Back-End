Console.WriteLine("Digite o valor de x:");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor de y:");
int y = int.Parse(Console.ReadLine());

// Exemplos de operadores aritméticos
int soma = x + y;
int subtração = x - y;
int multiplicação = x * y;
int divisão = x / y;
int resto = x % y;
int restoDiv2 = x % 2;

//Console para exibir na tela as variáveis em cada linha 
//Soma: 15
Console.WriteLine($"Soma: {soma}");
Console.WriteLine($"Subtração: " + subtração);
Console.WriteLine($"Multiplicação: " + multiplicação);
Console.WriteLine($"Divisão: " + divisão);
Console.WriteLine($"Resto: " + resto);