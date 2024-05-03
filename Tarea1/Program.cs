//Ejercicios: 

//EJERCICIO 1: Realiza la suma, resta, multiplicación y división de dos números ingresados por el usuario. 

//Declarar variables
Console.WriteLine("=======PROGRAMA DE OPERACIONES======");
Console.Write("Ingrese el primer numero: ");
var numeroUNO = Console.ReadLine();
var numero1 = double.Parse(numeroUNO);

Console.WriteLine("Ingrese el segudnop numero; ");
var numeroDOS = Console.ReadLine();
var numero2 = double.Parse(numeroDOS);

//Resolver el algortimo

double suma = numero1 + numero2;
double resta = numero1 - numero2;
double multiplicacion = numero1 * numero2;
double division = numero1 / numero2;

// Mostrar los resultados
Console.WriteLine($"La suma de {numero1} y {numero2} es: {suma}");
Console.WriteLine($"La resta de {numero1} y {numero2} es: {resta}");
Console.WriteLine($"La multiplicación de {numero1} y {numero2} es: {multiplicacion}");
Console.WriteLine($"La división de {numero1} entre {numero2} es: {division}");



//EJERCICIO 2: Solicita un número al usuario y determina si es par o impar. 

//Declarar variables
Console.WriteLine("=======PROGRAMA QUE DETERMINA SI ES PAR O IMPAR========");
Console.Write("Ingrese un numero entero: ");
var numeroRecibido = Console.ReadLine();
var numero = int.Parse(numeroRecibido);
var esPar = false;

//Resolver el algoritmo

if (numero % 2 == 0)
{
    esPar = true;
}

//Mostrar el resultado

Console.WriteLine(esPar ? "Es pa" : "Es impar");
Console.WriteLine();



//EJERCICIO 3: Pide la base y la altura de un triángulo al usuario y calcula su área. 

//Declarar Variables


Console.Write("Ingresa la longitud de la base del triángulo: ");
double baseT = Convert.ToDouble(Console.ReadLine());


Console.Write("Ingresa la altura del triángulo: ");
double alturaT = Convert.ToDouble(Console.ReadLine());

//Resolver el algoritmo
double area = (baseT * alturaT) / 2;

// Mostrar el resultado
Console.WriteLine("El área del triángulo es: " + area);



//EJERCICIO 4: Crea una función que calcule la factorial de un número. 

//Declarar variables
Console.WriteLine("=====Programa Factorial=======");
Console.Write("Ingrese un numero para calcular el factorial: ");
int numeroF = int.Parse(Console.ReadLine());

double factorial = 1;

//Resolver el algoritmo
if (numeroF < 0)
{
    Console.WriteLine("No se puede calcular el factorial, ya que su numero es negativo.");
}
else
{
    for (int i = 1; i <= numeroF; i++)
    {
        factorial *= i;
    }
}

//Mostrar el resultado
Console.WriteLine($"El factorial de {numeroF} es: {factorial}");
Console.Read();



//EJERCICIO 5: Verifica si un número ingresado por el usuario es primo o no. 

//Declarar variables
Console.Write("Ingresa un número para verificar si es primo: ");
int numeroP = Convert.ToInt32(Console.ReadLine());

bool esPrimo = true;

//Resolver el algoritmo
if (numeroP <= 1)
{
    esPrimo = false;
}
else
{
    for (int i = 2; i <= Math.Sqrt(numeroP); i++)
    {
        if (numeroP % i == 0)
        {
            esPrimo = false;
            break;
        }
    }
}

//Mostrar el resultado
if (esPrimo)
{
    Console.WriteLine(numeroP + " es un número primo.");
}
else
{
    Console.WriteLine(numeroP + " no es un número primo.");
}



//EJERCICIO 6: Toma una cadena de texto y muestra su inversión. 

//Declarar variables
Console.Write("Ingresa una cadena de texto: ");
string texto = Console.ReadLine();

string textoInvertido = "";

// Resolver el algoritmo
for (int i = texto.Length - 1; i >= 0; i--)
{
    textoInvertido += texto[i];
}

// Mostrar el resultado
Console.WriteLine("La cadena invertida es: " + textoInvertido);




//EJERCICIO 7: Calcula la suma de los números pares en un rango especificado por el usuario. 

//Declarar variables
Console.Write("Ingresa el número inicial del rango: ");
int inicio = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingresa el número final del rango: ");
int fin = Convert.ToInt32(Console.ReadLine());

int sumaP = 0;

// Resolver el algoritmo
for (int i = inicio; i <= fin; i++)
{
    if (i % 2 == 0)
    {
        sumaP += i;
    }
}

// Mostrar el resultado
Console.WriteLine("La suma de los números pares en el rango es: " + sumaP);




//EJERCICIO 8: Crea una lista de los cuadrados de los primeros 10 números naturales. 

//Declarar variables
List<int> numeros = new List<int> { 1, 4, 9, 16, 25, 36, 49, 64, 81, 100 };

// Mostrar la lista de cuadrados
Console.WriteLine("Los cuadrados de los primeros 10 números naturales son:");
foreach (int cuadrado in numeros)
{
    Console.WriteLine(cuadrado);
}



//EJERCICIO 9: Cuenta el número de vocales en una cadena de texto. 

//Declarar variables
Console.Write("Ingresa una cadena de texto: ");
string textoC = Console.ReadLine();

int contador = 0;
string vocales = "aeiouAEIOU";

//Resolver el algoritmo
foreach (char caracter in textoC)
{
    if (vocales.Contains(caracter))
    {
        contador++;
    }
}

// Mostrar el número de vocales en la cadena
Console.WriteLine("El número de vocales en la cadena es: " + contador);



//EJERCICIO 10: Genera los primeros 10 números de la serie Fibonacci. 

//Declarar variables
int n = 10;

//Resolver el algoritmo
int primero = 0;
int segundo = 1;

Console.WriteLine("Los primeros " + n + " números de la serie Fibonacci son:");

// Mostrar el resultado
for (int i = 0; i < n; i++)
{
    Console.WriteLine(primero);

    int siguiente = primero + segundo;
    primero = segundo;
    segundo = siguiente;
}



//EJERCICIO 11: Ordena una lista de números ingresados por el usuario de menor a mayor. 

//Declarara variables
Console.Write("Ingresa los números separados por espacios: ");
string entrada = Console.ReadLine();

// Resolver el algoritmo
int[] numerosF = entrada.Split(' ').Select(int.Parse).ToArray();


//Array.Sort(numerosF);

// Mostrar el resultado
Console.WriteLine("Los números ordenados de menor a mayor son: " + string.Join(" ", numerosF));



//EJERCICIO 12: Verifica si una palabra ingresada por el usuario es un palíndromo. 

//Declarar variables
Console.Write("Ingresa una palabra: ");
string palabra = Console.ReadLine().ToLower();

bool Palindromo = true;

// Resolver el algoritmo
for (int i = 0; i < palabra.Length / 2; i++)
{
    if (palabra[i] != palabra[palabra.Length - 1 - i])
    {
        Palindromo = false;
        break;
    }
}

// Mostrar el resultado
if (Palindromo)
{
    Console.WriteLine("La palabra \"" + palabra + "\" es un palíndromo.");
}
else
{
    Console.WriteLine("La palabra \"" + palabra + "\" no es un palíndromo.");
}




//EJERCICIO 13: Crea un programa que genere la tabla de multiplicar de un número ingresado por el usuario. 

//Declarar las variables
Console.Write("Ingresa un número para generar su tabla de multiplicar: ");
int numeroM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Tabla de multiplicar de " + numeroM + ":");

//Resolver el algoritmo
for (int i = 1; i <= 10; i++)
{
    int resultado = numeroM * i;
    //Mostrar el resultado
    Console.WriteLine(numeroM + " x " + i + " = " + resultado);
}



//EJERCICIO 14: Pide el radio de un círculo al usuario y calcula su área. 

//Declarar variables
Console.Write("Ingresa el radio del círculo: ");
double radio = Convert.ToDouble(Console.ReadLine());

// Resolver el algoritmo
double areaC = Math.PI * radio * radio;

// Mostrar el resultado
Console.WriteLine("El área del círculo con radio " + radio + " es: " + areaC);



//EJERCICIO 15: Toma un número entero y calcula la suma de sus dígitos. 

//Declarar variables
Console.Write("Ingresa un número entero: ");
int numeroE = Convert.ToInt32(Console.ReadLine());

int sumaE = 0;

//Resolver el algoritmo
foreach (char digito in numeroE.ToString())
{
    sumaE += int.Parse(digito.ToString());
}

//Mostrar el resultado
Console.WriteLine("La suma de los dígitos de " + numeroE + " es: " + sumaE);



Console.ReadLine();