using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Title = "love";
        Console.ForegroundColor = ConsoleColor.Red;

        string text = "I LOVE YOU ARSHI";
        Console.WriteLine(text);


        int height = 50, width = 50;
        char[,] buffer = new char[height, width];



        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {

                int x = j - width / 2;
                int y = -1 * (i - height / 2);


                int firstPart = x * x;
                int secondPart = (int)((y - Math.Sqrt(Math.Abs(x))) * (y - Math.Abs(x)));

                int heartSize = 300;

                if (firstPart + secondPart <= heartSize)
                {
                    buffer[i, j] = '♥';
                }
                else
                {
                    buffer[i, j] = ' ';
                }
            }
        }


        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Console.Write(buffer[i, j]);
            }
            Console.WriteLine();
        }


        Console.ReadLine();

    }
}