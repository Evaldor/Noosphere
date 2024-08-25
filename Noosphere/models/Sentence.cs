using System;

namespace BrocaZone.models;

public class Sentence
{
    public Sentence(string subject, Action action, string obj, string id)
    {
        Id = id;
        Subject = subject;
        Action = action;
        Object = obj;
    }

    public string Id { get; set; }
    public string Subject { get; set; }
    public Action Action { get; set; }
    public string Object{ get; set; }

}
