/*
Crie um programa que leia 10 números inteiros de um vector e conte quantos 
são pares e quantos sao ímpares
*/ 

int[] num = new int[10]; // Declaração do vector de 10 posições

int par = 0, impar = 0; // Declaração das variáveis que vão fazer a contagem da quantidade dos valores pares e ímpares

int contador = 0; // Declaração da variável contador

foreach (int item in num)   // Estrutura de repetição para podermos inserir valores ao vector e verificar a paridade dos mesmos 
{
    Console.WriteLine("Digite um numero inteiro"); // Solicitar ao usuário que informe os valores que serão armazenados no vector

    num[contador] = Convert.ToInt32(Console.ReadLine()); // Atribuir esses valores nas posições do vector em função do contador

    if(num[contador] % 2 is 0) // Estrutura de decisão para avaliar se cada um dos valores é par ou ímpar
        par++;  // Caso o valor seja par, incrementamos o valor da variável par
    else  
        impar++; // Caso o valor seja ímpar, incrementamos o valor da variável ímpar

    Console.Clear(); // Limpar a tela do console
    contador++; // Incrementar o valor do contador
}

Console.WriteLine($"O total de numeros pares digitados é:{par}"); // Imprimir a quantidade de valores pares
Console.WriteLine($"O total de numeros impares digitados é:{impar}"); // Imprimir a quantidade de valores ímpares