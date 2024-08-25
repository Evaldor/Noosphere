using System;

namespace BrocaZone.models;

public class Ant
{

    public int Id {get; set;}
    public string Name {get; set;}
    public DateTime DateOfBirth {get; set;}
    public int ParentOneId {get; set;}
    public int ParentTwoId {get; set;}
    public Tribe Tribe {get; set;}
    public List<Story> Stories { get; set; }

    public Ant(int Id,
               string Name,
               DateTime DateOfBirth,
               int ParentOneId,
               int ParentTwoId,
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
