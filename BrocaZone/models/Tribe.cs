using System;

namespace BrocaZone.models;

public class Tribe
{
    public int Id {get; set;}
    public string Name {get; set;}

    public Tribe(int id, string name) {
        Id = id;
        Name = name;
    }
}