class exe005
{
    public static void Main()
    {
        ListaDoChurrasco();
        SonhosDeConsumo();
    }

    public static void ListaDoChurrasco()
    {
        string[] itens = new string[6];
        
        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine("Digite a quantidade e os produtos para o churrasco");
            string produto = Console.ReadLine();
            itens[i] = produto;
        }

        Array.Sort(itens);

        foreach (string item in itens){
            Console.WriteLine(item);
        }
    }

    public static void SonhosDeConsumo()
    {
        string[] sonhos = new string[3];
        decimal[] valores = new decimal[3];
        decimal total = 0;
        
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Infome o seu {i} sonho");
            string sonho = Console.ReadLine();
            Console.WriteLine($"Informe o valor do {i}º sonho");
            decimal valor = decimal.Parse(Console.ReadLine());
            sonhos[i] = sonho;
            valores[i] = valor;
        }

        foreach (decimal val in valores)
        {
            total= total + val;
        }
        Console.WriteLine($"Seus sonhos custarão aprox. R${total}");
    }
}
