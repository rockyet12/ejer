// hacer un algoritmo que permita ingresar n valores el fin del ingreso se producira cuando el usuario ingrese  el valor 99999 o la suma de los valores ingresados sea superior a 100k finalmente mostrar la cantidad de valores ingresado, la suma total de los valores y el promedio de los valores 

// using System;

// namespace libreria 
// {
//     class TP
//     {
//         static void  Main()
//         {
//            int suma =0;
//             int promedio=0;
//             int valores = 0;
//             Console.Write("\nIngresar un valor :");
//             valores=int.Parse(Console.ReadLine());

//             while (valores <= 999999 || suma = 100000)
//             {
//                 promedio= suma/valores;
//                 suma = suma + valores;
//                 Console.Write("\nIngresar un valor :");
//                 valores=int.Parse(Console.ReadLine());
//             }

//             Console.WriteLine(suma);
//             Console.WriteLine(promedio);
//         }
//     }
// }

using System;

namespace biblioteca 
{
    class TP
{
    static void Main()
    {
        int valor=0;
        int promedio=0;
        int suma=0;
        int n=0;
        Console .WriteLine("\nIngrese un valor :");
        valor = Int32.Parse(Console.ReadLine());
        while (valor != 999 &&  suma < 100000)
        {
            n++;
            suma = suma + valor;
            Console .WriteLine("\nIngrese un valor :");
            valor = Int32.Parse(Console.ReadLine());
        }
        Console.WriteLine("\nSuma de los valores:"+ suma);
        Console.WriteLine("\ncantidad de valores ingresado:"+ n);
        Console.WriteLine("\npromedio:"+suma /n);
    } 
}
}

