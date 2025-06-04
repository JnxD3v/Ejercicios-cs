
int personas = 10;
int mayores = 0;
int menores = 0;

// Correccion de Michael;

for (int i = 0; i < personas; i++)
{
    Console.WriteLine("Inserta tu edad");
    int edad = int.Parse(Console.ReadLine());

    if (edad >= 18)
    {
        mayores += 1;
    }

    else
    {
        menores += 1;
    }

}

Console.WriteLine($" - Tenemos \n ~ Mayores:  {mayores}  \n ~ Menores: {menores}");

//int personas = 10;
//int mayores = 0;
//int menores = 0;

//// Correccion de Francisco;

//for (int i = 0; i < personas; i++)
//{

//    Console.WriteLine("Inserta tu edad");
//    int edad = int.Parse(Console.ReadLine());

//    if (edad >= 18) mayores += 1;
//    else menores += 1;

//}

//Console.WriteLine(" ~Tenemos: \n Mayores: {0}\n Menores: {1}", mayores, menores);
