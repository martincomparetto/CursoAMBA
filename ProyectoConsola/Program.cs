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


double precio = 128.5;
int unidades = 10;

Console.WriteLine(precio);
Console.WriteLine(unidades);

double total = precio * unidades;

Console.WriteLine(total);

double resto = total % 3;

Console.WriteLine(resto);

precio++;
Console.WriteLine(precio);

precio--;
Console.WriteLine(precio);

total += 1000;
// es igual a poner total = total + 1000;
Console.WriteLine(total);

total /= 2;
Console.WriteLine(total);

bool estado = false;

Console.WriteLine(!estado);

string nombre = "Sarah", apellido = "Connor";
Console.WriteLine($"El nombre completo es {nombre} {apellido}");


string texto1 = "Izquierda", texto2 = "Derecha";
string cadena = $"*{texto1, -20}*{texto2, 20}*";
Console.WriteLine(cadena);

const int ancho = 20;
Console.WriteLine($"{Math.PI, ancho} - numero PI por defecto");
Console.WriteLine($"{Math.PI, ancho:F6} - numero PI por defecto");
Console.WriteLine($"{total, ancho:C3} - es el total");

var variableCadena = "";

variableCadena = cadena;

cadena = null;
variableCadena = null;

int? edad1;

edad1 = null;


