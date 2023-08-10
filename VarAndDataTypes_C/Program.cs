using System;
using System.IO;


/*
Opgave c)

Prøv at erklære endnu en variabel af type double, du kan kalde variablen d, og tildel den værdierne width*length
double d = width*length;
Her vil Visual Studio gerne oversætte din kode, men hvorfor nu det?
*/

class AssignmentC
{
    private static void Main(string[] args)
    {
        int length = 16;
        double width = 5.1;
        double d = width * length;

        Console.WriteLine(d);

        // Her bliver slutværdien konverteret til en double-type, og derfor bliver den udregnet korrekt.
    }
}