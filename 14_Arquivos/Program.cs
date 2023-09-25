using System.IO;

public class Program
{
    public static string caminhoArquivo = "Arquivo/arquivo.txt";
    public static void Main()
    {
        GravarArquivo();
        LerArquivo();
    }
    public static void LerArquivo()
    {
        try
        {
            //Verificar se o arquivo existe
            if (File.Exists(caminhoArquivo) == false)
            {
                //Criando meu arquivo.txt, este comando é executado quando a verificação no if é falsa ou seja o arquivo não existe
                File.Create(caminhoArquivo);
            }
            //Instanciando um objeto da classe StreamReader para ler o arquivo
            using (StreamReader arquivo = new StreamReader(caminhoArquivo))
            {
                string linha;
                //Fazendo o while para ler linha por linha que contém no arquivo
                while ((linha = arquivo.ReadLine()) != null)
                {
                    //Escrevendo no console o conteudo da linha
                    Console.WriteLine(linha);
                }

            }
        }
        catch (Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro ao ler o arquivo: {erro.Message}");
        }
    }
    public static void GravarArquivo()
    {
        try
        {
            using (StreamWriter arquivo = new StreamWriter(caminhoArquivo, true))
            {
                Console.WriteLine("Digite uma informação para gravar no arquivo");
                //string texto = Console.ReadLine();
                arquivo.WriteLine(Console.ReadLine());

            }
        }
        catch (Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro ao gravar o arquivo: {erro.Message}");
        }
    }
}
