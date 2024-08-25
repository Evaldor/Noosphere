using System;

namespace BrocaZone.models;

public class Action
{
    public Action(string name, Int32 goodness, Int32 id)
    {
        Id = id;
        Name = name;
        Goodness = goodness;
    }

    public Int32 Id { get; set; }
    public string Name { get; set; }
    public Int32 Goodness { get; set; }
}
