Console.WriteLine("\n-----Numeros pares e impares-----\n");

int inicio = 0, fim = 0, aux;

Console.Write("Digite o numero inicial: ");
inicio = int.Parse(Console.ReadLine());

Console.Write("Digite o numero final: ");
fim = int.Parse(Console.ReadLine());

aux = inicio;
aux++;
Console.WriteLine("Numeros pares:");
while (aux < fim)
{
    if (aux % 2 == 0){
        Console.Write($"{aux} ");
    }
    aux++;
}

aux = inicio;
aux++;
Console.WriteLine("\nNumeros impares:");
while (aux < fim)
{
    if (aux % 2 != 0)
    {
        Console.Write($"{aux} ");
    }
    aux++;
}

Console.WriteLine("sHOW");
Console.WriteLine("\nPressione qualquer tecla para continuar...");
Console.ReadKey();