// Created by: Evgeny
// Created on: Mar 2022
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        //input
        float radius;

        Console.WriteLine("This program finds the volume of a sphere.");
        Console.WriteLine("");

        Console.Write("Enter the radius(cm): ");
        radius = Convert.ToInt32(Console.ReadLine());

        //process
        double volume = 4.0 / 3.0 * Math.PI * Math.Pow(radius, 3);

        //output
        Console.WriteLine("");
        Console.WriteLine("The volume is: " + volume.ToString("0.00") + " cm³.");

        Console.WriteLine("\nDone.");
    }
}