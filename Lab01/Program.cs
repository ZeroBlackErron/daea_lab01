class Calculadora
{
    static void Main(string[] args)
    {
        Console.Title = "Procedimientos y funciones";
        string opcion;
        int a;
        int b;
        do
        {
            Console.Clear();
            Console.WriteLine("[1] Suma de dos números");
            Console.WriteLine("[2] Resta de dos números");
            Console.WriteLine("[3] Multiplicacion de dos números");
            Console.WriteLine("[4] Division de dos números");
            Console.WriteLine("[5] Imprimir la raíz cuadrada de los 10 primeros números enteros");
            Console.WriteLine("[6] Imprimir los primeros 10 numeros primos");
            Console.WriteLine("[7] Convertir de grados Farenheit a grados Celcius");
            Console.WriteLine("[8] Convertir de grados Celcius a grados Farenheit");
            Console.WriteLine("[0] Salir");
            Console.WriteLine("Ingrese una opción y presione ENTER");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Ingrese el primer número");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo número");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a, b));
                    Console.ReadKey();
                    break;
                case "2":
                    Console.WriteLine("Ingrese el primer número");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo número");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("La resta de {0} y {1} es {2}", a, b, Resta(a, b));
                    Console.ReadKey();
                    break;
                case "3":
                    Console.WriteLine("Ingrese el primer número");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo número");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("La mulitplicacion de {0} y {1} es {2}", a, b, Multiplicacion(a, b));
                    Console.ReadKey();
                    break;
                case "4":
                    Console.WriteLine("Ingrese el primer número");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo número");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("La division de {0} y {1} es {2}", a, b, Division(a, b));
                    Console.ReadKey();
                    break;
                case "5":
                    Console.WriteLine("Calculando...");
                    Raiz();
                    Console.ReadKey();
                    break;
                case "6":
                    Console.WriteLine("Primeros 10 numeros primos:");
                    Primos();
                    Console.ReadKey();
                    break;
                case "7":
                    Console.WriteLine("Ingrese temperatura en Farenheit");
                    int f = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("La temparatura de {0} F es {1} C", f, ConvertFromFarenheitToCelcius(f));
                    Console.ReadKey();
                    break;
                case "8":
                    Console.WriteLine("Ingrese temperatura en Celcius");
                    int c = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("La temparatura de {0} C es {1} F", c, ConvertFromCelciusToFarenheit(c));
                    Console.ReadKey();
                    break;
            }
        } while (!opcion.Equals("0"));

    }

    static int Suma(int a, int b)
    {
        return a + b;
    }

    static int Resta(int a, int b)
    {
        return a - b;
    }

    static int Multiplicacion(int a, int b)
    {
        return a * b;
    }

    static int Division(int a, int b)
    {
        return a / b;
    }

    static void Raiz()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("La raíz cuadrada de {0} es: {1}", i, Math.Sqrt(i));
        }
    }

    static void Primos()
    {
        int ct = 0, n = 0, i = 1, j = 1;
        while (n < 10)
        {
            j = 1;
            ct = 0;
            while (j <= i)
            {
                if (i % j == 0)
                    ct++;
                j++;
            }
            if (ct == 2)
            {
                Console.WriteLine(i);
                n++;
            }
            i++;
        }
    }

    static float ConvertFromFarenheitToCelcius(int farenheitGrades)
    {
        return 5 * (farenheitGrades - 32) / 9;
    }

    static float ConvertFromCelciusToFarenheit(int celciusGrades)
    {
        return 9 * celciusGrades / 5 + 32;
    }
}