using System;

class Program {
static void Main(string[] args)
{
  int[] numeros = new int[7] { 15, 1, 34, 5, 90, 10, 6 };
  Console.WriteLine("Antes de ordenar");
  for(int indice=0; indice < 7; indice++)//por que no se puede hacer numeros.length??
  {
    int elemento;
    elemento = numeros[indice];
    Console.Write(elemento);
    // Imprimir también una coma
    if (indice!=7-1)
      Console.Write(", ");
  }
  Console.WriteLine("");
  ordenarBurbujaDescendente(numeros);
  Console.WriteLine("Después de ordenar descendente");
  for(int indice=0; indice < 7; indice++)//por que no se puede hacer numeros.length??
  {
    int elemento;
    elemento = numeros[indice];
    Console.Write(elemento);
    // Imprimir también una coma
    if (indice!=7-1)
      Console.Write(", ");
  }

}
static void ordenarBurbujaDescendente(int[] array)
  {
     for (int x = 0; x < array.Length; x++)
     {
        for (int indiceActual = 0; indiceActual < array.Length - x -1;indiceActual++)
        {
          int indiceSiguienteElemento = indiceActual + 1;
          // Si el actual es menor que el que le sigue a la derecha...
          if (array[indiceActual] < array[indiceSiguienteElemento])
           {
              int temporal = array[indiceActual];
              array[indiceActual] = array[indiceSiguienteElemento];
               array[indiceSiguienteElemento] = temporal;
            }
         }
      }   
  }
}