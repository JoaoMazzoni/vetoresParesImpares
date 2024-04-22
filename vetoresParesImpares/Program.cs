int[] numeros = new int[10];
//int[] pares = new int[10];
//int[] impares = new int[10];

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Digite o {0}° número: ", i + 1);
    numeros[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("\nNúmeros digitados: ");
for (int i = 0; i < 10; i++)
{
    Console.Write(numeros[i] + " ");
}

Console.ReadKey();

Console.WriteLine("\nNúmeros pares: ");
for (int i = 0; i < 10; i++)
{ 
    if (numeros[i] % 2 == 0)
    {
        Console.Write(numeros[i] + "");
    }
 }
Console.ReadKey();

Console.WriteLine("\nNúmeros impares: ");
for (int i = 0; i < 10; i++)
{
    if (numeros[i] % 2 != 0)
    {
        Console.Write(numeros[i] + "");
    }
}
Console.ReadKey();

Console.WriteLine("\nPrimeiros e ultimos números: ");
Console.WriteLine(numeros[0]);
Console.WriteLine(numeros[9]);