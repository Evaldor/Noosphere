using System;

namespace BrocaZone.models;

public class Story
{
    public Story(Guid id, Guid sourceAntId)
        {
            Id = id;
            Sentences = new List<Sentence>();
            SourceAntId = sourceAntId;
        }

    public Guid Id { get; set; }
    public Guid SourceAntId { get; set; }
    public List<Sentence> Sentences { get; set; }
}
