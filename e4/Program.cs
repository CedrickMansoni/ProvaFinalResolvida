/*
Crie um programa que leia 10 numeros inteiros 
de um vector e calcule a soma dos numeros pares
*/
int[] num = new int[10];
int soma = 0;
for(int i = 0; i < num.Length; i++)
{
    num[i] = new Random().Next(0, 100);
    if(num[i] % 2 is 0){soma += num[i]; Console.WriteLine($"Valor par sorteado {num[i]}");}
}
Console.WriteLine($"\n\nA soma dos numeros pares sorteados e: {soma}");
