class Program {

    public static void Main(){
        //Chamar e receber valor do método dobro
        int dobro = Dobro(int.Parse(Console.ReadLine()));
        double result = Dobro(dobro);
        //Exibir o valor da variavel
        Console.WriteLine($"O dobro é {dobro}");

        int metade = Metade(int.Parse(Console.ReadLine()));
        Console.WriteLine($"A metade é {metade}");

        Tabuada(int.Parse(Console.ReadLine()));

        ResumoSalarios();
    }

    public static int Dobro(int valor)
    {
        int resultado = (valor*2);
        return resultado;
    }
    public static int Metade(int valor)
    {
        int resultado = valor/2;
        return resultado;
    }

    public static void Tabuada(int numero)
    {
        int contador = 1;
        while(contador <= 10){
            Console.WriteLine($"{contador} x {numero} - {contador * numero}");
            contador++;
        }
    }

    public static void ResumoSalarios()
    {
        int somaSalarios = 0;
        int menorSalario = 100000;
        int maiorSalario = 0;
        int salarioEmpregado = 0;

        do {
            Console.WriteLine("Digite o salário do empregado:");
            salarioEmpregado = int.Parse(Console.ReadLine());

            if (salarioEmpregado > 0) {
                somaSalarios = somaSalarios + salarioEmpregado;
            }
            //somaSalario += salarioEmpregado;
            if(salarioEmpregado > maiorSalario)
            {
                maiorSalario = salarioEmpregado;
            }
            if(salarioEmpregado < menorSalario && salarioEmpregado > 0)
            {
                menorSalario = salarioEmpregado;
            }
        } while (salarioEmpregado > 0);
        Console.WriteLine($"A soma dos salários é {somaSalarios} o maior salário é {maiorSalario} e o menor salário {menorSalario}");
    }
}