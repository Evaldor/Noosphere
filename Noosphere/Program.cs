using BrocaZone.helpers;
using BrocaZone.models;

internal class Program
{
    private static void Main(string[] args)
    {
        ActionBook actionBook = new ActionBook();

        Console.WriteLine(actionBook.actions.First().Name);
    }
}