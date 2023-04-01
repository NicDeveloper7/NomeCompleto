//Made in by Nicholasdev

//Declaração de variável
string nome, sobrenome;

//Campo para o usuário preencher com seu nome e sobrenome
Console.WriteLine("Digite seu Nome: ");
nome = Console.ReadLine()!;
Console.WriteLine("Digite seu Sobrenome: ");
sobrenome = Console.ReadLine()!;

//Exibe o nome de catálogo do usuário
Console.Write("Seu nome de catálogo é: ");
Console.Write($"{sobrenome} {nome}");