// Created by: Claire Bedrossian
// Created on: Sep 2022
//
// This program calculates area and perimeter of a triangle

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        int height;
        int width;
        int sideA;
        int sideB;
        int area;
        int perimeter;

        Console.WriteLine("This program calculates the area and perimeter of a triangle.");
        Console.WriteLine("");

        Console.Write("Enter the length (cm): ");
        height = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the width (cm): ");
        width = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the side A (cm): ");
        sideA = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the side B (cm): ");
        sideB = Convert.ToInt32(Console.ReadLine());

        area = height * width;
        perimeter = width + sideA + sideB;

        Console.WriteLine("");
        Console.WriteLine("The area is: " + area + " cm². ");
        Console.WriteLine("The perimeter is: " + perimeter + " cm. ");

        Console.WriteLine("\nDone.");
    }
}
