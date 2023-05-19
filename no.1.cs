using System;

class Program
{
    static void Main()
    {
        Console.Write("Please Enter Number Layers of the Pascal's Triangle: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 0)
        {
            Console.WriteLine("Invalid Pascal's triangle row number.");
            Console.Write("Please Enter Number Layers of the Pascal's Triangle Again: ");
            n = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i <= n; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(CalculatePascalValue(i, j) + " ");
            }
            Console.WriteLine();
        }
    }

    static int CalculatePascalValue(int row, int column)
    {
        if (column == 0 || column == row)
            return 1;
        else
            return CalculatePascalValue(row - 1, column - 1) + CalculatePascalValue(row - 1, column);
    }
}