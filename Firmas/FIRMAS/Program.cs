using System;

public class Program
{
    public static void Main(string[] args)
    {
        // 1. Método Saludar
        // Este método no recibe parámetros y simplemente imprime un mensaje de bienvenida.
        public void Saludar()
        {
            Console.WriteLine("¡Hola! Bienvenido al programa.");
        }

        // Invocación
        Saludar(); // Imprime: ¡Hola! Bienvenido al programa.

        // 2. Método ImprimirNumero
        // Este método recibe un entero como parámetro e imprime el número recibido.
        public void ImprimirNumero(int numero)
        {
            Console.WriteLine("El número recibido es: " + numero);
        }

        // Invocación
        ImprimirNumero(42); // Imprime: El número recibido es: 42.

        // 3. Método Sumar
        // Este método recibe dos enteros y devuelve la suma de ambos.
        public int Sumar(int a, int b)
        {
            return a + b;
        }

        // Invocación
        int resultado = Sumar(5, 3);
        Console.WriteLine("La suma es: " + resultado); // Imprime: La suma es: 8.

        // 4. Clase Persona y método Presentarse
        // La clase Persona tiene propiedades Nombre y Edad, y un método Presentarse que imprime una presentación.
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
    persona.Presentarse(); // Imprime: Hola, soy Juan y tengo 30 años.

        // 5. Método Saludar con parámetro opcional
        // Este método tiene un parámetro opcional nombre con un valor predeterminado "Usuario".
        public void Saludar(string nombre = "Usuario")
    {
        Console.WriteLine("¡Hola, " + nombre + "!");
    }

    // Invocaciones
    Saludar(); // Imprime: ¡Hola, Usuario!
    Saludar("Ana"); // Imprime: ¡Hola, Ana!

             // 6. Método CalcularSuma
            // Este método recibe un número variable de enteros y devuelve la suma de todos ellos.
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
    Console.WriteLine("La suma es: " + suma); // Imprime: La suma es: 15.

            // 7. Método Dividir
            // Este método realiza una división y devuelve el cociente y el residuo usando parámetros out.
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
    Console.WriteLine($"Cociente: {c}, Residuo: {d}"); // Imprime: Cociente: 3, Residuo: 1.

            // 8. Método CalcularOperaciones
           // Este método devuelve una tupla con la suma y la resta de dos enteros.
        public (int suma, int resta) CalcularOperaciones(int a, int b)
    {
        return (a + b, a - b);
    }

    // Invocación
    var operaciones = CalcularOperaciones(10, 5);
    Console.WriteLine($"Suma: {operaciones.suma}, Resta: {operaciones.resta}"); // Imprime: Suma: 15, Resta: 5.

            // 9. Método Factorial
            // Este método calcula el factorial de un número usando recursión.
        public int Factorial(int n)
    {
        if (n == 0)
            return 1;
        else
            return n * Factorial(n - 1);
    }

    // Invocación
    int resultado = Factorial(5);
    Console.WriteLine("Factorial de 5 es: " + resultado); // Imprime: Factorial de 5 es: 120.

            // 10. Método ProcesarNumeros
            // Este método recibe un array de enteros y una acción a realizar sobre cada elemento del array.
        public void ProcesarNumeros(int[] numeros, Action<int> accion)
    {
        foreach (var num in numeros)
        {
            accion(num);
        }
    }

    // Invocación
    int[] nums = { 1, 2, 3, 4, 5 };
    ProcesarNumeros(nums, num => Console.WriteLine(num* num)); // Imprime los cuadrados de los números en el array.

    // 11. Método EjecutarAccion
    // Este método recibe una acción como parámetro y la ejecuta.
    public void EjecutarAccion(Action accion)
    {
        accion();
    }

    // Invocación
    EjecutarAccion(() => Console.WriteLine("¡Hola desde el método anónimo!")); // Imprime: ¡Hola desde el método anónimo!

        // 12. Método EncontrarMinimo
        // Este método encuentra y devuelve una referencia al valor mínimo en un array de enteros.
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
    Console.WriteLine("El menor número es: " + minimo); // Imprime: El menor número es: 1.

        // 13. Método ObtenerPrimero
        // Este método genérico devuelve el primer elemento de un array.
        public T ObtenerPrimero<T>(T[] array)
    {
        return array[0];
    }

    // Invocación
    int[] numeros = { 1, 2, 3, 4, 5 };
    int primero = ObtenerPrimero(numeros);
    Console.WriteLine("El primer número es: " + primero); // Imprime: El primer número es: 1.

        // 14. Método DividirSeguro
        // Este método realiza una división y maneja la excepción de división por cero.
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
            // Aquí podrías manejar la excepción según tus necesidades.
        }
    }

    // Invocación
    DividirSeguro(10, 0); // Genera una excepción e imprime: Error: División por cero.

    // 15. Método ObtenerOperacion
    // Este método devuelve una función que realiza la operación especificada.
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
    Console.WriteLine("Resultado de la suma: " + resultado); // Imprime: Resultado de la suma: 15.

        // 16. Método Saludar con múltiples parámetros opcionales
        // Este método tiene dos parámetros opcionales, nombre y saludo.
        public void Saludar(string nombre = "Usuario", string saludo = "Hola")
    {
        Console.WriteLine($"{saludo}, {nombre}!");
    }

    // Invocaciones
    Saludar(); // Imprime: Hola, Usuario!
    Saludar("Ana"); // Imprime: Hola, Ana!
    Saludar(saludo: "Buen día"); // Imprime: Buen día, Usuario!
    Saludar("Juan", "Hola"); // Imprime: Hola, Juan!

    // 17. Método MostrarPersona
    // Este método recibe un objeto Persona y muestra sus propiedades.
    public void MostrarPersona(Persona persona)
    {
        Console.WriteLine($"Nombre: {persona.Nombre}, Edad: {persona.Edad}");
    }

    // Invocación
    Persona persona = new Persona { Nombre = "María", Edad = 25 };
    MostrarPersona(persona); // Imprime: Nombre: María, Edad: 25.

    // 18. Método ObtenerValor
    // Este método utiliza parámetros out y ref para modificar los valores fuera del método.
    public void ObtenerValor(out int a, ref int b)
    {
        a = 5;
        b = b + 10;
    }

    // Invocación
    int valorA, valorB = 10;
    ObtenerValor(out valorA, ref valorB);
    Console.WriteLine($"Valor de A: {valorA}, Valor de B: {valorB}"); // Imprime: Valor de A: 5, Valor de B: 20.

        // 19. Método Mayor
        // Este método genérico encuentra y devuelve el valor mayor en un array de elementos comparables.
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
    Console.WriteLine("El número mayor es: " + numMayor); // Imprime: El número mayor es: 10.
    }
}
