using _04___Exercício_Lista_Aluno;

List<Aluno> alunos = new List<Aluno>();

while (true)
{
    Aluno x = new Aluno();
    Console.Write("\nDigite a matrícula do aluno(a): ");
    x.Matricula = Convert.ToInt32(Console.ReadLine());
    Console.Write("Digite o nome do aluno(a): ");
    x.Nome = Console.ReadLine();
    Console.Write("Digite o cpf do aluno(a): ");
    x.Cpf = Console.ReadLine();
    Console.Write("Digite a data de nascimento do aluno(a): ");
    x.DataNascimento = DateOnly.Parse(Console.ReadLine());

    alunos.Add(x);

    Console.WriteLine("\nDeseja cadastrar um aluno? ");
    Console.WriteLine("0 - Não");
    Console.WriteLine("1 - Sim");
    Console.Write("Opção escolhida: ");
    int opcao = Convert.ToInt32(Console.ReadLine());

    if(opcao == 0)
    {
        break;
    }
    else if(opcao == 1)
    {

    }
    else
    {
        Console.WriteLine("Opção Inválida!");
    }
}

////

foreach (Aluno a in alunos)
{
    Console.WriteLine($"\n\n MATRÍCULA: {a.Matricula}");
    Console.WriteLine($" NOME: {a.Nome}");
    Console.WriteLine($" CPF: {a.Cpf}");
    Console.WriteLine($" DATA NASCIMENTO: {a.DataNascimento}");
}