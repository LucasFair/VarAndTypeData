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

        // This will prompt an error to occur, as there is no variable defined as "height".
        // That being said, even if "height" is changed to "length", it will still not work,
        // as there would be a datatype mismatch attempting to turn a double (width) into an int (area).
    }
}
