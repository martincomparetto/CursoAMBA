using System;

// // Declaracion de una variable
// // <tipo de dato> <nombre de la variable>;
// string nombre = "Martin", apellido = "Comparetto";

// Console.WriteLine("Hola " + nombre + apellido);

// int edad = 39;
// nombre = "Tony";

// Console.WriteLine("La edad de " + nombre + " es " + edad.ToString());

// char letra = 'a';

// int dias = 7;

// DateTime ahora;

// const double pi = 3.141516;

// if (true) {
//     string nombre1 = "Pepe";
//     Console.WriteLine(nombre1);
// }

// Console.WriteLine(nombre);


// double precio = 128.5;
// int unidades = 10;

// Console.WriteLine(precio);
// Console.WriteLine(unidades);

// double total = precio * unidades;

// Console.WriteLine(total);

// double resto = total % 3;

// Console.WriteLine(resto);

// precio++;
// Console.WriteLine(precio);

// precio--;
// Console.WriteLine(precio);

// total += 1000;
// // es igual a poner total = total + 1000;
// Console.WriteLine(total);

// total /= 2;
// Console.WriteLine(total);

// bool estado = false;

// Console.WriteLine(!estado);

// string nombre = "Sarah", apellido = "Connor";
// Console.WriteLine($"El nombre completo es {nombre} {apellido}");


// string texto1 = "Izquierda", texto2 = "Derecha";
// string cadena = $"*{texto1, -20}*{texto2, 20}*";
// Console.WriteLine(cadena);

// const int ancho = 20;
// Console.WriteLine($"{Math.PI, ancho} - numero PI por defecto");
// Console.WriteLine($"{Math.PI, ancho:F6} - numero PI por defecto");
// Console.WriteLine($"{total, ancho:C3} - es el total");

// var variableCadena = "";

// variableCadena = cadena;

// cadena = null;
// variableCadena = null;

// int? edad1;

// edad1 = null;


// int edadPersona = 20;

// if (edadPersona < 20)
// {
//     Console.WriteLine("Es un joven");
// }
// else if (edadPersona >= 20 && edadPersona < 70)
// {
//     Console.WriteLine("Es un adulto");
// }
// else
// {
//     Console.WriteLine("Es un abuelo");
// }

// Console.WriteLine(edadPersona < 20 ? "Es un joven" : "No es joven");


// int n = 6;
// while (n <= 5)
// {
//     Console.WriteLine(n);
//     n++;
// }

// n = 8;
// do
// {
//     Console.WriteLine(n);
//     n++;
// } while (n <= 5);

// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
// }

// string[] misTitulos = new string[5];

// misTitulos[0] = "Titulo Primero";
// misTitulos[1] = "Titulo Segundo";
// misTitulos[2] = "Titulo Tercero";
// misTitulos[3] = "Titulo 4";
// misTitulos[4] = "Titulo 5";

// // for (int i = 0; i < misTitulos.Length; i++)
// // {
// //     Console.WriteLine(misTitulos[i]);
// // }

// foreach (string elemento in misTitulos)
// {
//     Console.WriteLine(elemento);
// }

// int[] numeros = new int[] {1, 2, 3, 4, 5};
// foreach (int elemento in numeros)
// {
//     Console.WriteLine(elemento);
// }

// List<int> numerosList = new List<int>();
// numerosList.Add(1);
// numerosList.Add(3);
// numerosList.Add(10);
// numerosList.Add(15);
// numerosList.Add(100);
// Console.WriteLine("Imprimimos primera tanda de " + numerosList.Count);
// foreach (int elemento in numerosList)
// {
//     Console.WriteLine(elemento);
// }

// numerosList.Add(1001);
// numerosList.Add(1002);
// numerosList.Add(1003);
// Console.WriteLine("Imprimimos segunda tanda de " + numerosList.Count);
// foreach (int elemento in numerosList)
// {
//     Console.Write(elemento);
// }


string Saludar(string nombre, string apellido)
{
    string respuestaSaludo = $"Hola {nombre} {apellido}";
    return respuestaSaludo;
}

string respuesta = Saludar("Juana", "DeArco");
MostrarMensaje(respuesta);


void MostrarMensaje(string mensaje)
{
    Console.WriteLine(mensaje);
}


