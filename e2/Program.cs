/*
Crie um programa que leia 10 numeros
inteiros de um vector e conte quantos 
sao pares e quantos sao impares
*/ 

int[] num = new int[10];
int par = 0, impar = 0;
int i = 0;
while (i < num.Length)
{
    Console.WriteLine("Digite um numero inteiro");
    num[i] = Convert.ToInt32(Console.ReadLine());
    if(num[i] % 2 is 0){par++;}else{impar++;}
    Console.Clear();
    i++;
}

Console.WriteLine($"O total de numeros pares digitados e:{par}");
Console.WriteLine($"O total de numeros impares digitados e:{impar}");