using System.Runtime.InteropServices;
using BrocaZone.helpers;
using BrocaZone.models;

internal class Program
{
    private static void Main(string[] args)
    {
        Guid godId = new Guid("00000000-0000-0000-0000-000000000000");
        ActionBook actionBook = new ActionBook();
        Tribe tribe = new Tribe(new Guid("025ffeae-5659-4b5f-9c17-12faf7556b5a"),"Дреговичи");
        bool isMale = true;
        Ant ant = new Ant(new Guid("8ee5d001-73f2-42ff-9d52-c4291388f28f"),
                          NameGenerator.GetFullName(isMale),
                          DateTime.Now,
                          godId,
                          godId,
                          tribe);

        BrocaZone.BrocaZone.Initialize(ant);

        
        Story story = new Story(Guid.NewGuid(),godId);
        Sentence sentence = new Sentence(godId,
                                         actionBook.GetRandomAction(),
                                         new Guid("8ee5d001-73f2-42ff-9d52-c4291388f28f"),
                                         Guid.NewGuid());
        story.Sentences.Add(sentence);

        BrocaZone.BrocaZone.ReceiveStory(DateTime.Now,"на завалинке",new Guid("8ee5d001-73f2-42ff-9d52-c4291388f28f"),godId,story);

        List<Story> stories = BrocaZone.BrocaZone.GetStoriesAbout(new Guid("8ee5d001-73f2-42ff-9d52-c4291388f28f"));

        foreach (Story storyItem in stories)
        {
            foreach (var sentenceItem in storyItem.Sentences){
                Console.WriteLine(sentenceItem.SubjectId.ToString()+" "+sentenceItem.Action.Name+" "+sentenceItem.ObjectId.ToString());
            }
        }
    }
}