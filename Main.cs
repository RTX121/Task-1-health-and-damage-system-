// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        // player's current health
        Console.Write("Enter player's health: ");
        int health = Convert.ToInt32(Console.ReadLine());

        //damage taken
        Console.Write("Enter damage taken: ");
        int damage = Convert.ToInt32(Console.ReadLine());

        // Subtract damage from health
        health -= damage;
        Console.WriteLine("Health after damage: " + health);

        //healing amount
        Console.Write("Enter healing amount: ");
        int healing = Convert.ToInt32(Console.ReadLine());

        // Add healing to health
        health += healing;
        Console.WriteLine("Health after healing: " + health);

        // Apply power-up (double the health)
        health *= 2;
        Console.WriteLine("Health after power-up: " + health);
    }
}
