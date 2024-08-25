using System;
using BrocaZone.models;

namespace BrocaZone;

public static class BrocaZone
{
    //Метод инициализации. Вызывается при создании анта, получает ссылку на анта
    public static void Initialize(Person person){

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
                                    string iStoryTeller,
                                    Story story)
    {

    }

    public static List<Story> GetStoriesAbout(Person person){
        return new List<Story>();
    }
    public static List<Story> GetAllStories(){
        return new List<Story>();
    }
    public static Story GetRandomStory(){
        
        return new Story(Guid.NewGuid().ToString());
    }

}
