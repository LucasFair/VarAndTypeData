using System;
using System.IO;


/*
Opgave a)

Erklær en variabel af typen int og tildel den værdien 16, du kan evt. kalde variablen length.
Erklær endnu en variabel kaldet width, af typen double og tildel den værdien 5.1.
Prøv at lægge de 2 variable sammen i en Console.WriteLine(length*width); i din main metode og se resultatet.
*/

class AssignmentA
{
    private static void Main(string[] args)
    {
        int length = 16;
        double width = 5.1;

        Console.WriteLine(length * width);
    }
}