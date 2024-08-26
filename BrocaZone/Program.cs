using System.Runtime.InteropServices;
using BrocaZone.helpers;
using BrocaZone.models;
using bz = BrocaZone.BrocaZone;
internal class Program
{
    
    private static void Main(string[] args)
    {
        //генерим постоянные
        ActionBook actionBook = new ActionBook();
        bz.theBeginningOfTimes = DateTime.Now;

        //генерим N племен
        List<Tribe> pregenTribes = WorldGenerator.GenerateTribes(1);

        //генерим N антов
        List<Ant> pregenAnts = WorldGenerator.GenerateAnts(1);
        
        //добавляем антов в BrocaZone
        foreach (Ant ant in pregenAnts)
        {
            Random rnd= new Random(); 
            int num = rnd.Next(pregenTribes.Count());
            ant.Tribe = pregenTribes[num];
            bz.Initialize(ant);
        };

        //добавляем истории фазы мифа
        foreach (Ant ant in pregenAnts)
        {
            Story story = new Story(Guid.NewGuid(),bz.godId);

            Sentence sentence = new Sentence(bz.godId,
                                         actionBook._actions[5],
                                         ant.Id,
                                         Guid.NewGuid());
            story.Sentences.Add(sentence);

            bz.ReceiveStory(DateTime.Now,
                            "в астрале",
                            ant.Id,
                            bz.godId,
                            story);
        }
        
        //тестдрайв
        Random random = new Random(); 
        int number = random.Next(pregenAnts.Count());
        string storyText = bz.GetStory(pregenAnts[number].Id);
        Console.WriteLine(storyText);
        
        
        /*
        
  
        List<Story> stories = BrocaZone.BrocaZone.GetStoriesAbout(new Guid("8ee5d001-73f2-42ff-9d52-c4291388f28f"));

        foreach (Story storyItem in stories)
        {
            foreach (var sentenceItem in storyItem.Sentences){
                Console.WriteLine(sentenceItem.SubjectId.ToString()+" "+sentenceItem.Action.Name+" "+sentenceItem.ObjectId.ToString());
            }
        }
        */
    }
}