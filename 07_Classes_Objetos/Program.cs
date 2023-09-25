    //Sempre que formos utilizar bibliotecas ou classes já criadas, importamos ela com using
    using Sesi.Model;

    class Program
    {
        public static void Main()
        {
            //Criando uma variável aluno1 e instanciando da classe Aluno, ou seja, estamos criando nosso onjeto
            var aluno1 = new Aluno();
            //Atribuindo um valor ao atributo nome do aluno1
            aluno1.nome = "Bruna";
            aluno1.idade = 16;
            aluno1.turma = "2º EM";
            //Chamando o método da classe Aluno
            aluno1.Apresentar();
            aluno1.ResumirFaltas();
            aluno1.AdicionarFaltas(10);
            aluno1.ResumirFaltas();
            aluno1.AdicionarFaltas(7);
            aluno1.ResumirFaltas();
            aluno1.JustificarFaltas(8);
            aluno1.ResumirFaltas();


            var aluno2 = new Aluno();
            aluno2.nome = "Pedro";
            aluno2.idade = 16;
            aluno2.turma = "2º EM";
            aluno2.Apresentar();
        }
    }
