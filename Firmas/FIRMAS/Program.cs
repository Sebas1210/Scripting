using System;

public class FIRMAS
{
    public void Saludar()
    {
        Console.WriteLine("¡Hola! Bienvenido al programa.");
       
    }

    // Invocación
    Saludar();

    public void ImprimirNumero(int numero)
    {
        Console.WriteLine("El número recibido es: " + numero);
        
    }
    // Invocación
    ImprimirNumero(42);

    public int Sumar(int a, int b)
    {
        return a + b;
    }
    // Invocación
    int resultado = Sumar(5, 3);
    Console.WriteLine("La suma es: " + resultado);

    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public void Presentarse()
        {
            Console.WriteLine($"Hola, soy {Nombre} y tengo {Edad} años.");
        }

    }
    // Invocación
    Persona persona = new Persona { Nombre = "Juan", Edad = 30 };
    persona.Presentarse();

    public void Saludar(string nombre = "Usuario")
    {
        Console.WriteLine("¡Hola, " + nombre + "!");

        
    }
    // Invocaciones
    Saludar(); // Salida: ¡Hola, Usuario!
    Saludar("Ana"); // Salida: ¡Hola, Ana!   

    public int CalcularSuma(params int[] numeros)
    {
        int suma = 0;
        foreach (int num in numeros)
        {
            suma += num;
        }
        return suma;

        
    }
    // Invocación
    int suma = CalcularSuma(1, 2, 3, 4, 5);
    Console.WriteLine("La suma es: " + suma);

    public void Dividir(int dividendo, int divisor, out int cociente, out int residuo)
    {
        cociente = dividendo / divisor;
        residuo = dividendo % divisor;
    }

    // Invocación
    int a = 10;
    int b = 3;
    int c, d;
    Dividir(a, b, out c, out d);
    Console.WriteLine($"Cociente: {c}, Residuo: {d}");

    public (int suma, int resta) CalcularOperaciones(int a, int b)
    {
        return (a + b, a - b);
    }

    // Invocación
    var operaciones = CalcularOperaciones(10, 5);
    Console.WriteLine($"Suma: {operaciones.suma}, Resta: {operaciones.resta}");
    

    public int Factorial(int n)
    {
        if (n == 0)
            return 1;
        else
            return n * Factorial(n - 1);
    }

    // Invocación
    int resultado = Factorial(5);
    Console.WriteLine("Factorial de 5 es: " + resultado);


    public void ProcesarNumeros(int[] numeros, Action<int> accion)
    {
        foreach (var num in numeros)
        {
            accion(num);
        }
    }

    // Invocación
    int[] nums = { 1, 2, 3, 4, 5 };
    ProcesarNumeros(nums, num => Console.WriteLine(num* num));


    public void EjecutarAccion(Action accion)
    {
        accion();
    }

    // Invocación
    EjecutarAccion(() => Console.WriteLine("¡Hola desde el método anónimo!"));

    public ref int EncontrarMinimo(ref int[] numeros)
    {
        int min = numeros[0];
        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] < min)
                min = numeros[i];
        }
        return ref numeros[Array.IndexOf(numeros, min)];
    }

    // Invocación
    int[] array = { 5, 2, 9, 1, 7 };
    ref int minimo = ref EncontrarMinimo(ref array);
    Console.WriteLine("El menor número es: " + minimo); // Salida: 1

    public T ObtenerPrimero<T>(T[] array)
    {
        return array[0];
    }

    // Invocación
    int[] numeros = { 1, 2, 3, 4, 5 };
    int primero = ObtenerPrimero(numeros);
    Console.WriteLine("El primer número es: " + primero);

    public void DividirSeguro(int dividendo, int divisor)
    {
        try
        {
            int resultado = dividendo / divisor;
            Console.WriteLine("Resultado de la división: " + resultado);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: División por cero");
            // Aquí podrías manejar la excepción según tus necesidades
        }
    }

    // Invocación
    DividirSeguro(10, 0); // Genera una excepción

    public Func<int, int, int> ObtenerOperacion(string operacion)
    {
        switch (operacion)
        {
            case "suma":
                return (a, b) => a + b;
            case "resta":
                return (a, b) => a - b;
            default:
                throw new ArgumentException("Operación no válida");
        }
    }

    // Invocación
    var operacion = ObtenerOperacion("suma");
    int resultado = operacion(10, 5);
    Console.WriteLine("Resultado de la suma: " + resultado);

    public void Saludar(string nombre = "Usuario", string saludo = "Hola")
    {
        Console.WriteLine($"{saludo}, {nombre}!");
    }

    // Invocaciones
    Saludar(); // Salida: Hola, Usuario!
    Saludar("Ana"); // Salida: Hola, Ana!
    Saludar(saludo: "Buen día"); // Salida: Buen día, Usuario!
    Saludar("Juan", "Hola"); // Salida: Hola, Juan!

    public void MostrarPersona(Persona persona)
    {
        Console.WriteLine($"Nombre: {persona.Nombre}, Edad: {persona.Edad}");
    }

    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }

    // Invocación
    Persona persona = new Persona { Nombre = "María", Edad = 25 };
    MostrarPersona(persona);


    public void ObtenerValor(out int a, ref int b)
    {
        a = 5;
        b = b + 10;
    }

    // Invocación
    int valorA, valorB = 10;
    ObtenerValor(out valorA, ref valorB);
    Console.WriteLine($"Valor de A: {valorA}, Valor de B: {valorB}");


    public T Mayor<T>(T[] valores) where T : IComparable<T>
    {
        T mayor = valores[0];
        foreach (var valor in valores)
        {
            if (valor.CompareTo(mayor) > 0)
                mayor = valor;
        }
        return mayor;
    }

    // Invocación
    int[] numeros = { 5, 8, 2, 10, 3 };
    int numMayor = Mayor(numeros);
    Console.WriteLine("El número mayor es: " + numMayor);
















}
