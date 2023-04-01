//Faça um programa que receba dados de um pet ao dar entrada em um pet hotel. Exiba os dados ao final do cadastro.

Console.WriteLine("----   Pet Hotel - Entrada de dados ----\n"); // \n vai pular linha

Console.Write("- Espécie - "); // pergunta para o cliente
string especie = Console.ReadLine()!; //  criado uma variável tipo string e com readline espera para o cliente digitar. 
//Console.WriteLine($"- espécie {especie}"); // writeLine irá devolver a informação e com $ podemos escrever a variável dentre das chaves. 

Console.Write("- Raça - "); // pergunta para o cliente
string raca = Console.ReadLine()!; //  criado uma variável tipo string e com readline espera para o cliente digitar. 


Console.Write("- Nome do Pet - "); // pergunta para o cliente
string nome = Console.ReadLine()!; //  criado uma variável tipo string e com readline espera para o cliente digitar. 

Console.Write("- Idade - "); // pergunta para o cliente
string idade = Console.ReadLine()!; //  criado uma variável tipo string e com readline espera para o cliente digitar. 

Console.Write("- Pelagem/Cor - "); // pergunta para o cliente
string pelagem = Console.ReadLine()!; //  criado uma variável tipo string e com readline espera para o cliente digitar. 

Console.WriteLine();
                                                                              
Console.WriteLine("+=========================================================+");
Console.Write("|                  ");
Console.ForegroundColor = ConsoleColor.Blue; // foregroundColor configura uma cor para o texto. 
Console.Write("Pet Hotel Nem um pio");
Console.ResetColor();
Console.WriteLine("                   |");
Console.WriteLine("+=========================================================+");
Console.Write("| Espécie: ");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write(especie.Trim().ToUpper().PadLeft(15, '.').Substring(0, 15)); // trim corta espaços em branco, toupper letras maiusculas, padleft insere uma ocorrencia no inicio da string, substring obtem parte de uma string de acordo com sua posição
Console.ResetColor();
Console.Write(" | Raça: ");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write(raca.Trim().ToUpper().PadLeft(22, '.').Substring(0, 22));
Console.ResetColor();
Console.WriteLine(" |");
Console.WriteLine("+=========================================================+");
Console.Write("| Nome do Pet: ");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write(nome.Trim().ToUpper().PadLeft(42, '.').Substring(0, 42));
Console.ResetColor();
Console.WriteLine(" |");
Console.WriteLine("+=========================================================+");
Console.Write("| Idade: ");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write(idade.Trim().ToUpper().PadLeft(17, '.').Substring(0, 17)); // trim corta espaços em branco, toupper letras maiusculas, padleft insere uma ocorrencia no inicio da string, substring obtem parte de uma string de acordo com sua posição
Console.ResetColor();
Console.Write(" | Pelagem: ");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write(pelagem.Trim().ToUpper().PadLeft(19, '.').Substring(0, 19));
Console.ResetColor();
Console.WriteLine(" |");
Console.WriteLine("+=========================================================+");
Console.WriteLine();




