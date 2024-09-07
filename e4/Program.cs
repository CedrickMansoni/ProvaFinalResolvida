/*
Crie um programa que leia 10 numeros inteiros 
de um vector e calcule a soma dos numeros pares
*/
int[] num = new int[10]; // Declaração do vector de 10 posições

int soma = 0; // Declaração da variável soma

for(int i = 0; i < num.Length; i++) // Estrutura de repetição para podermos inserir valores aleatórios ao vector  
{
    num[i] = new Random().Next(0, 100); // Atribuição de valores aleatórios gerados usando novas instâncias da class Random 

    if(num[i] % 2 is 0) // Estrutura de decisão, caso o valor seja par, então incremente ele a variável soma
    {
        soma += num[i]; // Incrementar o valor par a varável soma
        Console.WriteLine($"Valor par sorteado {num[i]}"); // Imprimir na tela o valor par sorteado
    } 
}
Console.WriteLine($"\n\nA soma dos números pares sorteados é: {soma}"); // Imprimir na tela a soma dos valores pares sorteados
