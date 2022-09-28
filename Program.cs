/*Escribe un programa que realice estos pasos:

Reciba al menos un número por consola

Determine si el número es positivo o negativo
SS
Presente un contador para cada tipo (positivo y negativo).
    */
float num;
Console.WriteLine("Escriba un numero");
num = Convert.ToInt32(Console.ReadLine());


    int positivo = 1;
    int negativo = 0;
   

    if (num == 0)
    {
        Console.Write("El numero digitado {0} es cero", num);
    }
    if (num > 0)
    {
        Console.Write("El numero {0} es positivo", num);
        positivo++;
    }
    if (num < 0)
    {
        Console.Write("El numero {0} es negativo", num);
        negativo++;
    }

    Console.WriteLine("\ncontador de positivos  :" + positivo);
    Console.WriteLine("contador de negativos  :" + negativo);
    Console.ReadKey();
