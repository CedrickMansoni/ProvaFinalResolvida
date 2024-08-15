/*
Crie um programa que leia 10 numeros inteiros de um vector e 
verifique se um numero fornecido pelo usuario esta presente no vector.
*/ 

int[] num = new int[10];
for(int i = 0; i < num.Length; i++)
{
    num[i] = new Random().Next(0, 100);
}

bool acertou = true;

while(acertou)
{
    Console.WriteLine("Advinhe um numero inteiro existente no vector");
    int resposta = Convert.ToInt32(Console.ReadLine());
    foreach(int i in num)
    {
        if(i == resposta){ acertou = false; }        
    }
    Console.Clear();
}
Console.WriteLine("Parabens voce acertou,"); 
