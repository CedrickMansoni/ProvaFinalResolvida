/*
    Crie um programa C# que ajude o professor a calcular 
    a situacao de um aluno em 3 provas
*/

double[] notas = new double[3];

System.Console.WriteLine("Digite a primeira nota do aluno");
notas[0] = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Digite a segunda nota do aluno");
notas[1] = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Digite a terceira nota do aluno");
notas[2] = Convert.ToDouble(Console.ReadLine());

double media = (notas[0] + notas[1] + notas[2])/3;

string situacao = media >= 7.0 ? "Aprovado" : "Recuperacao";

System.Console.WriteLine(situacao);

