using System;

namespace BrocaZone.models;

public class Ant
{

    public Guid Id {get; set;}
    public string Name {get; set;}
    public DateTime DateOfBirth {get; set;}
    public Guid ParentOneId {get; set;}
    public Guid ParentTwoId {get; set;}
    public Tribe Tribe {get; set;}
    public List<Story> Stories { get; set; }

    public Ant(Guid Id,
               string Name,
               DateTime DateOfBirth,
               Guid ParentOneId,
               Guid ParentTwoId,
               Tribe Tribe)
    {
        this.Id = Id;
        this.Name = Name;
        this.DateOfBirth = DateOfBirth;
        this.ParentOneId = ParentOneId;
        this.ParentTwoId = ParentTwoId;
        this.Tribe = Tribe;
        Stories = new List<Story>();
    }
}
