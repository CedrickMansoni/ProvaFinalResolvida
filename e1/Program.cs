/*
    Crie um programa que leia 8 números
    inteiros de um vector e exiba o maior 
    e o menor numero.
*/
int[] num = new int[8]; // Declaração do vector de 8 posições

int contador = 0; // Declaração de um contador para manipulação dos índices do vector

foreach (int item in num) // Estrutura de repetição para podermos inserir valores ao vector  
{
    Console.WriteLine("Digite um numero inteiro");  // Solicitar ao usuário que informe os valores inteiros que serão armazenados no vector
    num[contador] = Convert.ToInt32(Console.ReadLine()); // Atribuir esses valores nas posições do vector em função do contador
    Console.Clear(); // Limpar a tela do console
    contador++;   // Incrementar o valor do contador
}

int maior = num.Max(); // Encontrar o maior valor numerico inserido no vector 
int menor = num.Min(); // Encontrar o menor valor numerico inserido no vector 

Console.WriteLine($"O maior numero do vector é: {maior}\n");  // Imprimir na tela o maior valor
Console.WriteLine($"O menor numero do vector é: {menor}");  // Imprimir na tela o menor valor