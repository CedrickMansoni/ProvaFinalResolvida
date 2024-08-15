/*
    Crie um programa que leia 8 numeros
    inteiros de um vector e exiba o maior 
    e o menor numero.
*/
int[] num = new int[8];
for (int i = 0; i < num.Length; i++) 
{
    Console.WriteLine("Digite um numero inteiro");
    num[i] = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
}

int maior = num.Max();
int menor = num.Min();

Console.WriteLine($"O maior numero do vector e: {maior}");
Console.WriteLine($"O menor numero do vector e: {menor}");