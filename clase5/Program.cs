
//ejemplo de entradas en consola con if, else if, else

/*Console.WriteLine("Desea continuar? (Y/N)");
var texto = Console.ReadLine();

if (texto.ToUpper() == "Y")
{
    Console.WriteLine("Usted ingreso Yes");
}
else if (texto.ToUpper() == "N")
{
    Console.WriteLine("Usted ingreso No");
}
else
{
    Console.WriteLine("Usted no entendio nada");
}*/

//VUELTERETAS / CICLOS
//CICLOS WHILE

/*Console.WriteLine("cuantas vueltas queres hacer bro?: ");

string respuesta = "s";
var contador = 0;


while (respuesta != "n")
{
    contador++; //contador = contador + 1
    Console.WriteLine("Seguimos dando vueltas, vuelta numero: "
        + contador);
    Console.WriteLine("Seguimos? (s/n)");
    respuesta = Console.ReadLine();
}*/



//CICLOS FOR


//la "i" hace referencia a indice, se suele usar para el for
//la primera ejecucion no hace un incremento
//  declaracion,condicion,paso
for (int i = 0; i <= 12; i++)
{
    Console.WriteLine("Mi bolsa tiene " + i + " caramelos");
    //otra forma de concatenar es ($"Mi bolsa tiene {i} caramelos")
}

//i+=2 es igual a i = i + 2