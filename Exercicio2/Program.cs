Console.WriteLine("\n-----Tabuada-----\n");
int num = 0;

do{
    Console.Write("Digite um numero inteiro positivo: ");
    num = int.Parse(Console.ReadLine());
} while (num < 0);

for(int i = 1; i<=10; i++){
    Console.WriteLine($"{num}x{i}={num*i}");
}

Console.WriteLine("Pressione qualquer tecla para continuar...");
Console.ReadKey();