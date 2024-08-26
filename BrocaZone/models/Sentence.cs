using System;

namespace BrocaZone.models;

public class Sentence
{
    public Sentence(Guid subjectId, Action action, Guid objectId, Guid id)
    {
        Id = id;
        SubjectId = subjectId;
        Action = action;
        ObjectId = objectId;
    }

    public Guid Id { get; set; }
    public Guid SubjectId { get; set; }
    public Action Action { get; set; }
    public Guid ObjectId{ get; set; }

}
