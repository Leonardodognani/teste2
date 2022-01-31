Console.Write("Digite o seu nome: ");
string name = Console.ReadLine();

Console.Write("Digite seu sobrenome: ");
string lastName = Console.ReadLine();

Console.Write("Digite sua Idade: ");
string age = Console.ReadLine();

Console.Write("Digite o nome da Cidade onde reside: ");
string city = Console.ReadLine();

Console.Write("Digite a UF do Estado onde reside: ");
string UF = Console.ReadLine();

Console.Write("Digite a formação pretendida: ");
string course = Console.ReadLine();

Console.WriteLine();
Console.WriteLine("Cadastro Realizado com sucesso");
Console.WriteLine();
Console.WriteLine($"Dados a serem confirmados: {name} {lastName}, possui {age} anos, reside na cidade de {city}/{UF} e pretende se formar na área de {course}.");

