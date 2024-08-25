using System;

namespace BrocaZone.models;

public class Story
{
    public Story(Guid id)
        {
            Id = id;
            Sentences = new List<Sentence>();
        }

    public Guid Id { get; set; }

    public List<Sentence> Sentences { get; set; }
}
