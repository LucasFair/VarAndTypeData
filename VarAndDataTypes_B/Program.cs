using System;
using System.IO;

/*
Opgave b)

Prøv at erklære endnu en variabel af type int, du kan kalde variablen area, og tildel den værdierne width * length
int area = width*height;
Visual Studios compiler vil ikke oversætte din kode, men hvorfor?
*/

class AssignmentB
{
    private static void Main(string[] args)
    {
        int length = 16;
        double width = 5.1;
        int area = width * height;

        Console.WriteLine(area);

        // Dette udløser en fejl, da der ikke er en variable kaldt "height",
        // men selvom man puttede "length", so er der et mismatch mellem datatyperne.
    }
}
