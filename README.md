# TALLER 1 SCRIPTING
## Punto #1
### Ejercicio Cadena
  El ejercicio de cadena utilizado fue el siguiente.
  "Realizar una función que calcule si una cadena es palindroma."
  La solución se encuentra en la carpeta llamada "cadena". 

   ### Ejercicio Uso De Funciones
   El ejercicio de uso de funciones utilizado fue el siguiente.
  "Crea un programa en el cual se Realice una función que invierta 
   un array de números enteros".
   https://www.programiz.com/online-compiler/5zoZbgd5K2SRQ

### Ejercicio Ciclos
  El ejercicio de uso ciclos utilizado fue el siguiente.
  "Usando un ciclo do-while calcule la suma de los primeros n números impares".
  https://www.programiz.com/online-compiler/8DMOyWpkz0LnJ

### Ejercicio Matriz
  El ejercicio de uso matriz utilizado fuel el siguiente.
  "Recorra una matriz nxm y reemplace los valores negativos por un número positivo".

  
  ```c#
  using System;

class Program
{
    static void Main()
    {
        // Dimensiones de la matriz
        int n = 5; // Número de filas
        int m = 4; // Número de columnas
        
        // Generar matriz aleatoria
        int[,] matriz = GenerarMatriz(n, m);
        
        // Imprimir matriz original
        Console.WriteLine("Matriz Original:");
        ImprimirMatriz(matriz);
        
        // Reemplazar valores negativos por positivos
        int[,] matrizPositiva = ReemplazarNegativos(matriz);
        
        // Imprimir matriz modificada
        Console.WriteLine("\nMatriz Modificada:");
        ImprimirMatriz(matrizPositiva);
    }
    
    static int[,] GenerarMatriz(int n, int m)
    {
        Random rand = new Random();
        int[,] matriz = new int[n, m];
        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matriz[i, j] = rand.Next(-10, 10); // Generar números aleatorios entre -10 y 9
            }
        }
        
        return matriz;
    }
    
    static void ImprimirMatriz(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
    
    static int[,] ReemplazarNegativos(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        int[,] matrizPositiva = new int[filas, columnas];
        
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                matrizPositiva[i, j] = matriz[i, j] < 0 ? -matriz[i, j] : matriz[i, j];
            }
        }
        
        return matrizPositiva;
    }
}
 ```

## Punto #2
### Actividad con la clase 
La actividad se encuentra en el siguiente link.
https://www.programiz.com/online-compiler/4Q1wy7REpj9dL 

Ejercicio de clase, adivina  el número: Nuestro código utiliza varias funciones
 -GenerarNumeroSecreto:  Genera un número aleatorio.
 -ComprobarAdivinanza:  Compara la adivinanza del usuario con el número secreto y proporciona retroalimentación.

todo es llamado desde un  Main que genera un número secreto llamando a la función GenerarNumeroSecreto.
Utiliza un bucle while para permitir múltiples intentos de adivinanza.

Llama a la función ComprobarAdivinanza para verificar si la adivinanza es correcta.

## Punto #3
### CommandChallenge
La evidencia de los 41 ejercicio se encuentra en la carpeta llamada "ComandChallenge"

## Punto #4
###  FIRMAS
La evidencia de las firmas y sus invocaiones se encuentran en la carpeta llamada "Firmas"

