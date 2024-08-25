using System.Runtime.InteropServices;
using BrocaZone.helpers;
using BrocaZone.models;

internal class Program
{
    private static void Main(string[] args)
    {
        ActionBook actionBook = new ActionBook();
        Tribe tribe = new Tribe(1,"Дреговичи");
        bool isMale = true;
        Ant ant = new Ant(1,BrocaZone.helpers.NameGenerator.GetFullName(isMale),DateTime.Now,0,0,tribe);

        BrocaZone.BrocaZone.Initialize(ant);

        
        Story story = new Story(Guid.NewGuid());
        Sentence sentence = new Sentence(0,actionBook.GetRandomAction(),1,Guid.NewGuid());
        story.Sentences.Add(sentence);

        BrocaZone.BrocaZone.ReceiveStory(DateTime.Now,"на завалинке",1,0,story);

        List<Story> stories = BrocaZone.BrocaZone.GetStoriesAbout(1);

        foreach (Story storyItem in stories)
        {
            foreach (var sentenceItem in storyItem.Sentences){
                Console.WriteLine(sentenceItem.SubjectId.ToString()+" "+sentenceItem.Action.Name+" "+sentenceItem.ObjectId.ToString());
            }
        }
    }
}