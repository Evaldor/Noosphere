using System;

namespace BrocaZone.models;

public class Person
{
    public Person(string id, string name)
        {
            Id = id;
            Name = name;
            Stories = new List<Story>();
        }

    public string Id { get; set; }

    public string Name { get; set; }

    public List<Story> Stories { get; set; }
}
