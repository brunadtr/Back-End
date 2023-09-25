namespace Banco
{
    public class ContaCorrente
    {
        private string titular { get; set; }
        private double saldo { get; set; }

        public ContaCorrente(string titularNome){
            this.titular = titularNome;
            this.saldo = 200;
        }

        public void ConsultarSaldo()
        {
            Console.WriteLine($"Seu saldo é de R${saldo}");
        }

        public void Depositar()
        {
            Console.WriteLine("Digite o valor do depósito:");
            double valor = double.Parse(Console.ReadLine());
            if(valor > 0){
                saldo += valor;
                Console.WriteLine("valor depositado com sucesso!");
            }
            else{
                Console.WriteLine("Valor inválido");
            }
        }

        public void Sacar()
        {
            Console.WriteLine("Digite o valor do saque:");
            double valor = double.Parse(Console.ReadLine());
            if(valor > saldo){
                Console.WriteLine($"Seu saldo é muito baixo para sacar esse valor. Seu saldo disponível é de R${saldo}");
            }
            else
            if(valor > 0){
                saldo -= valor;
                Console.WriteLine("valor sacado com sucesso com sucesso!");
            }
            else{
                Console.WriteLine("Valor inválido");
            }
        }
    }
}