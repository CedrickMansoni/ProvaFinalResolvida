/*
Crie um programa que leia 10 numeros inteiros de um vector e 
verifique se um número fornecido pelo usuário está presente no vector.
*/ 

int[] num = new int[10]; // Declaração do vector de 10 posições

for(int i = 0; i < num.Length; i++) // Estrutura de repetição para podermos inserir valores aleatórios ao vector  
{
    num[i] = new Random().Next(0, 100); // Atribuição de valores aleatórios gerados usando novas instâncias da class Random 
}

bool acertou = true; // Declaração de uma variável do tipo boolean para tornarmos a estrutura while infinita

while(acertou)
{
    Console.WriteLine("Advinhe um numero inteiro existente no vector"); // Pedindo para o usuário digitar um número aleatório
    int resposta = Convert.ToInt32(Console.ReadLine()); // Recebemos e armazenamos o valor na variável resposta
    foreach(int i in num) // Estrutura de repetição para verificação da existência do valor dentro do vector
    {
        if(i == resposta)
        { acertou = false; break; } // Se o valor existir no vector, então atribuímos false a variavel acertou e paramos o foreach        
    }
    Console.Clear(); // Limpar a tela do console
}
Console.WriteLine("Parabéns você acertou,"); // Imprimir na tela uma mensagem de felicitação ao usuário por ter acertado o valor
