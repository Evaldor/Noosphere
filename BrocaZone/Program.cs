using System.Runtime.InteropServices;
using BrocaZone.helpers;
using BrocaZone.models;

internal class Program
{
    private static void Main(string[] args)
    {
        Tribe tribe = new Tribe(1,"Дреговичи");
        bool isMale = true;
        Ant ant = new Ant(1,BrocaZone.helpers.NameGenerator.GetFullName(isMale),DateTime.Now,2,3,tribe);
        Console.WriteLine(ant.Name);
    }
}