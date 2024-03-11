static void Ejercicio1()
{
    try
    {
        int num = 0;
        int mayor = 0;
        int menor = 9999;
        do
        {
            Console.Write("Ingrese un numero (0 = Salir): ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num != 0)
            {
                if (num > mayor)
                {
                    mayor = num;
                }
                if (num <= menor)
                {
                    menor = num;
                }
            }

            Console.WriteLine("El número mayor es: " + mayor);
            Console.WriteLine("El número menor es: " + menor);
        } while (num != 0);
    }
    catch (FormatException)
    {
        Console.WriteLine("¡El valor introducido no es un número!");
        Console.WriteLine("¡Volviendo al menú!");
        Console.ReadKey();
        Console.Clear();
    }
    Console.ReadKey();
    Console.Clear();
}


static void Ejercicio2()
{
    try
    {
        int num = 0;
        int resultado = 0;

        Console.WriteLine("\tAdivinar el número que estas pensando ");
        Console.Write("Ingrese cualquier numero: ");
        num = int.Parse(Console.ReadLine());

        resultado = num * 2;
        Console.WriteLine("\nMultiplica ese número por 2 = " + resultado);

        resultado += 8;
        Console.WriteLine("Sumale 8 al resultado = " + resultado);

        resultado *= 5;
        Console.WriteLine("Al resultado multiplícalo por 5 = " + resultado);

        Console.Write("\nDime el resultado final que obtuviste: ");
        int resultadoFinal = int.Parse(Console.ReadLine());

        string resultadoString = resultadoFinal.ToString();

        //Anulando la última cifra
        resultadoString = resultadoString.Substring(0, resultadoString.Length - 1);
        int ultimaCifra = int.Parse(resultadoString);

        ultimaCifra -= 4;

        Console.WriteLine("¡El número que pensaste es: " + ultimaCifra + "!");
        Console.ReadKey();
        Console.Clear();
    }catch (FormatException)
    {
        Console.WriteLine("¡El valor introducido no es un número!");
        Console.WriteLine("¡Volviendo al menú!");
        Console.ReadKey();
        Console.Clear();
    }
    Console.ReadKey();
    Console.Clear();
}

static void Ejercicio3()
{
    Console.WriteLine("\tContador de palabras y vocales ");
    Console.Write("Ingrese una frase: ");
    string frase = Console.ReadLine();

    // Contar palabras
    int cantidadPalabras = 1;
    int i = 0;
    while (i < frase.Length) 
    {
        if (frase[i] == ' ')
        {
            cantidadPalabras++;
        }
        i++;
    }

    // Contar vocales
    int cantidadVocales = 0;
    string vocales = "aeiouáéíóúAEIOUÁÉÍÓÚ";
    for (int y = 0; y < frase.Length; y++)
    {
        if (vocales.Contains(frase[y]))
        {
            cantidadVocales++;
        }
    }

    Console.WriteLine("Cantidad de palabras: " + cantidadPalabras);
    Console.WriteLine("Cantidad de vocales: " + cantidadVocales);
    Console.ReadKey();
    Console.Clear();
}

static void Ejercicio4()
{
    Console.WriteLine("\tDeterminar si una palabra es palindromo ");
    Console.Write("Ingrese una palabra: ");
    string palabra = Console.ReadLine();
    
    //Convirtiendo la cadena en un arreglo de caracteres
    char[] arregloCaracteres = palabra.ToUpper().ToCharArray();
    Array.Reverse(arregloCaracteres );//Invirtiendo el orden de los caracteres en el arreglo
    string nuevaCadena = new string(arregloCaracteres).ToUpper();

 
    if(palabra.ToUpper() == nuevaCadena)
    {
       Console.WriteLine("La palabra es un Palíndromo");
    }
    else
    {
       Console.WriteLine("La palabra no es  un Palíndromo ");
    }
    Console.ReadKey();
    Console.Clear();
}

//Menú Principal
int opcion = 0;
do
{
   
        Console.WriteLine("1. Encontrar número mayor y número menor ");
        Console.WriteLine("2. Adivinar el número que esta pensando ");
        Console.WriteLine("3. Contador de palabras ");
        Console.WriteLine("4. Palindromos ");
        Console.WriteLine("5. Salir ");
        Console.Write("Opcion :");
    try 
    { 
        opcion = Convert.ToInt32(Console.ReadLine());


        switch (opcion)
        {
            case 1:
                Ejercicio1();
                break;
            case 2:
                Ejercicio2();
                break;
            case 3:
                Ejercicio3();
                break;
            case 4:
                Ejercicio4();
                break;
            case 5:
                Console.WriteLine("Saliendo del programa...");
                break;
            default:
                Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                Console.ReadKey();
                Console.Clear();
                break;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("El valor introducido es incorrecto. Por favor, ingrese un número válido.");
        Console.ReadKey();
        Console.Clear();
    }
} while (opcion != 5);
