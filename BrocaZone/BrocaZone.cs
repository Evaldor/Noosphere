using System;
using System.Text;
using BrocaZone.models;
using System.Linq;

namespace BrocaZone;

public static class BrocaZone
{
    public static Guid godId = new Guid("00000000-0000-0000-0000-000000000000"); //боженька для всех историй без начала
    public static DateTime theBeginningOfTimes; //начало времён, для определения на сколько история старинная
    private static List<Tribe> _tribes = new List<Tribe>();
    private static List<Ant> _ants = new List<Ant>();
    //Метод инициализации. Вызывается при создании анта, получает ссылку на анта

    public static void Initialize(Ant ant){
        _ants.Add(ant);
        _tribes.Add(ant.Tribe);
    }

    //Метод, сообщающий о произошедшем в мире событии. 
    //Параметры обсуждаемы, но в целом туда нужно передавать все доступные данные 
    //– когда, где, что, кто, кого, откуда мы это знаем (увидел, услышал, ощутил)
    public static void WorldEventHappened(DateTime dt,
                                          string worldCoordinates,
                                          string eventType,
                                          string iEventActor,
                                          string iEventTarget,
                                          string iWitnessSource)
    {

    }

    //Метод, сообщающий, что ант услышал конкретную историю от какого-то рассказчика.
    public static void ReceiveStory(DateTime dt,
                                    string worldCoordinates,
                                    Guid storyListenerId,
                                    Guid storyTellerId,
                                    Story story)
    {
        foreach(Ant ant in _ants){
            if(ant.Id == storyListenerId){
                if(storyListenerId == storyTellerId){
                    story.SourceAntId = storyListenerId;
                }
                ant.Stories.Add(story);
            }
        }
    }

    public static List<Story> GetStoriesAbout(Guid antId){

        List<Story> stories = new List<Story>();
        foreach(Ant ant in _ants){
            if(ant.Id == antId){
                stories = ant.Stories;
            }
        }
        return stories;
    }

    public static string GetStory(Guid antId){

        StringBuilder storyText = new StringBuilder();
        Ant ant = _ants.FirstOrDefault(t => t.Id == antId);

        storyText.Append("И молвил ");
        storyText.Append(ant.Name+" ");
        storyText.Append("из племени ");
        storyText.Append(ant.Tribe.Name+" ");
        storyText.Append(": ");
        // давно это было, да вот только что, не так много времени прошло как 

        Random random = new Random(); 
        int number = random.Next(ant.Stories.Count());
        Story story = ant.Stories[number];

        int i = 0;
        int storyLength = story.Sentences.Count();

        foreach(Sentence sentence in story.Sentences){
            if(i != 0){
                storyText.Append("А затем ");
            }
            else if(i == storyLength){
                storyText.Append("Ну и наконец ");
            }
            i++;

            if(sentence.SubjectId == godId){
                storyText.Append("Боженька ");
            }
            else if(sentence.SubjectId == ant.Id){
                storyText.Append("Я ");
            }
            else
            {
                storyText.Append(_ants.FirstOrDefault(t => t.Id == sentence.SubjectId).Name+" ");
            }

            storyText.Append(sentence.Action.Name+" ");

            if(sentence.ObjectId == godId){
                storyText.Append("Боженьку ");
            }
            else if(sentence.ObjectId == ant.Id){
                storyText.Append("Мене ");
            }
            else
            {
                storyText.Append(_ants.FirstOrDefault(t => t.Id == sentence.ObjectId).Name+".");
            }
            if(i == storyLength){
                storyText.Append("Вот собственно и всё.");
            }
            
        }

        return storyText.ToString();
    }

    public static List<Story> GetAllStories(){
        return new List<Story>();
    }

    public static Story GetRandomStory(){
        
        return new Story(Guid.NewGuid(),Guid.NewGuid());
    }

}
