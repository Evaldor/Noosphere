using System;

namespace BrocaZone.models;

public class Sentence
{
    public Sentence(int subjectId, Action action, int objectId, Guid id)
    {
        Id = id;
        SubjectId = subjectId;
        Action = action;
        ObjectId = objectId;
    }

    public Guid Id { get; set; }
    public int SubjectId { get; set; }
    public Action Action { get; set; }
    public int ObjectId{ get; set; }

}
