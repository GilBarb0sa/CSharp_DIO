using System;
using ExemploFundamentos.Models;

#region Operadores de Atribuição

//string a = "15=";
//int b = 0;
//int.TryParse(a, out b);  // Se a variavel a ser convertido com sucesso, imprimi normalmente se falar, a saida será a variavel b.
//Console.WriteLine(b);
//Console.WriteLine("Conversão realizada com sucesso!");

//double a = 4/(2+2);
//Console.WriteLine(a);

//int a = 5;
//double b = a;
//long a = long.MaxValue;
//int b = Convert.ToInt32(a);
//int a = int.MaxValue;
//long b = a;
//Console.WriteLine(b);

//int inteiro = 5;
//string a = inteiro.ToString();
//Console.WriteLine(a);

//Cast - Casting
//int a = Convert.ToInt32("5");
//int a = int.Parse("5");
//Console.WriteLine(a);

//int a = 10;
//int b = 20;
//int c = a + b;
//c = c + 5;
//c += 5;
//Console.WriteLine(c);


//DateTime dataAtual = DateTime.Now.AddDays(5);
//Console.WriteLine("A data de agora é " + dataAtual.ToString("dd/MM/yy  HH:mm"));


//string apresentacao = "Olá mundo";
//int qtd = 1;
//Console.WriteLine("O valor da variavel quantidade :" + qtd);
//qtd = 10;
//Console.WriteLine("O valor da variavel quantidade :" + qtd);
//double altura = 1.80;
//decimal preco = 1.80M;
//bool condicao = true;
//Console.WriteLine(apresentacao);
//Console.WriteLine("Valor da variavel quantidade " + qtd);
//Console.WriteLine("Valor da variavel altura " + altura.ToString("0.00"));
//Console.WriteLine("Valor da variavel preço " + preco);
//Console.WriteLine("Valor da variavel condição " + condicao);


//Pessoa pessoa1 = new Pessoa();
//pessoa1.Nome = "Gilberto";
//pessoa1.Idade = 32;
//pessoa1.Apresentar();

#endregion

#region Operadores Condicionais

//Console.WriteLine("Digite uma letra");
//string letra = Console.ReadLine();

//switch (letra)
//{
//    case "a":
//    case "e":
//    case "i":
//    case "o":
//    case "u":
//        Console.WriteLine("Vogal");
//        break;
//    default:
//        Console.WriteLine("Não é uma vogal");
//        break;
//}


//int quantidadeEmEstoque = 10;
//int quantidadeCompra = 0;
//bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;
//Console.WriteLine($"Quantidade em estoque {quantidadeEmEstoque}");
//Console.WriteLine($"Quantidade compra {quantidadeCompra}");
//Console.WriteLine($"É possível realizar a venda? {possivelVenda}");
//if (quantidadeCompra == 0)
//{
//    Console.WriteLine("Venda inválida.");
//}
//else if (possivelVenda)
//{
//    Console.WriteLine("Venda realizada!");
//}
//else
//{
//    Console.WriteLine("Desculpe não temos a quantidade desejada em estoque!");
//}

#endregion

#region Operadores Lógicos

//bool presencaMinima = true;
//double media = 5;

//if (presencaMinima && media >= 7)
//{
//    Console.WriteLine("Aluno Aprovado");
//}
//else
//{
//    Console.WriteLine("Aluno Reprovado");
//}

//bool ehMaiorDeIdade = false;
//bool possuiAutorizacaoDoResponsavel = true;
//if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
//{
//    Console.WriteLine("Entrada Liberada!");
//}
//else
//{
//    Console.WriteLine("Entrada não Liberada!");
//}

//bool choveu = false;
//bool estaTarde = false;
//if (!choveu && !estaTarde)
//{
//    Console.WriteLine("Vou pedalar.");
//}
//else
//{
//    Console.WriteLine("Vou pedalar um outro dia.");
//}

#endregion