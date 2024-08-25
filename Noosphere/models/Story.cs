using System;

namespace BrocaZone.models;

public class Story
{
    public Story(string id)
        {
            Id = id;
            Sentences = new List<Sentence>();
        }

    public string Id { get; set; }

    public List<Sentence> Sentences { get; set; }
}
