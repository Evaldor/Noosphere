using System;
using System.Text;
using BrocaZone.models;
using BrocaZone;

namespace BrocaZone.helpers;

public static class WorldGenerator
{
    public static List<Tribe> GenerateTribes(int qty){

        List<Tribe> r = new List<Tribe>();

        for (int i = 0; i < qty; i++)
        {
            Guid id = Guid.NewGuid();

            var random = new Random(); 
            StringBuilder sequence = new StringBuilder();

            for (int j = 0; j < 5; j++)
            {
                char letter = (char)random.Next('А', 'Я'); // Генерируем случайную букву
                sequence.Append(letter); // Добавляем букву в последовательность
            }

            string tribeName = sequence.ToString() + "ичи"; // Конкатенируем последовательность и "ичи"


            Tribe tribe = new Tribe(id,tribeName);

            r.Add(tribe);
        }
        return r;

    }

    public static List<Ant> GenerateAnts(int qty){

        List<Ant> r = new List<Ant>();

        for (int i = 0; i < qty; i++)
        {
            Random random = new Random(); // Создаем объект класса Random
            bool isMale = random.Next(2) == 1;

            Tribe tribe = new Tribe(Guid.NewGuid(),"");

            Ant ant = new Ant(new Guid("8ee5d001-73f2-42ff-9d52-c4291388f28f"),
                          NameGenerator.GetFullName(isMale),
                          DateTime.Now,
                          BrocaZone.godId,
                          BrocaZone.godId,
                          tribe);
            r.Add(ant);

        }

        return r;
    }
}
