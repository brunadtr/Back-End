using Animais.Model;

    class Program
    {
        public static void Main()
        {
            var pantera1 = new Pantera();
            pantera1.tamanho = 2.00;
            pantera1.peso = 120;
            pantera1.cor = "Preta";
            pantera1.especie = "Panthera onca";
            pantera1.alimentacao = "carnívora";
            pantera1.Correr();
            pantera1.Cacar();
            pantera1.Reproduzir();
        }
    }
