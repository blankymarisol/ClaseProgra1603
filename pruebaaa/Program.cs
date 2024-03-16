static void Ejemplo()
{
    int[] calificaciones;
    calificaciones = new int[] { 85, 77, 68, 94, 75 };
    Console.WriteLine(calificaciones[2]);
}

Ejemplo();

static void Ejemplo2()
{
    string[] nombres = new string[3];
    nombres[0] = "Juan";
    nombres[1] = "Carlos";
    nombres[2] = "Pedro";

    foreach (string nombre in nombres)
    {
        Console.WriteLine("Nombre" + nombre);
    }

}
Ejemplo2();

//static void Promedio()
//{
//    int[] notas = { 80, 75, 90, 95, 73, 79 };
//    bool hayAprobados = Array.Exists(notas, calif => calif >= 60);
//}
//Promedio();

//foreach (int nota in notas)
//{
//    suma = suma + 1;
//    Console.WriteLine("El promedio es: " + (suma / notas.Length));
//    Console.WriteLine("riginal");
//    foreach (int nota in notas)
//    {
//        Console.WriteLine(nota);
//    }
//}
//Console.WriteLine("Arreglado");
//Array.Sort(notas);
//foreach (int nota in notas)
//{
//    Console.WriteLine(nota);
//}
//}
//Promedio();

static void Arreglo()
{
    string[] original = { "Juan", "Ana", "Pedro", "Maria", "Andrea" };
    string[] invertido = new string[original.Length];

    for (int i = 0; i < original.Length; i++)
    {
        invertido[i] = original[original.Length - 1 - i];
    }

    foreach (var elemento in invertido)
    {
        Console.Write(elemento + " ");
    }
}
Arreglo();
