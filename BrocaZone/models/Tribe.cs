using System;

namespace BrocaZone.models;

public class Tribe
{
    public Guid Id {get; set;}
    public string Name {get; set;}

    public Tribe(Guid id, string name) {
        Id = id;
        Name = name;
    }
}