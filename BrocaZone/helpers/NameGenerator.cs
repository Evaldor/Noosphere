using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrocaZone.helpers;

public static class NameGenerator{
    static readonly string[] namesN = {"Свято", "Яро", "Влади", "Изя", "Вяче", "Мечи", "Бори", "Гори", "Бого", "Любо", "Мило", "Свето", "Миро", "Добро", "Брони"};
    static readonly string[] namesK = {"слав", "мир", "полк", "люб", "рад", "мил", "зар", "мысл", "дан", "гор", "яр", "вед", "бор", "мысл", "свет"};

    public static string GetFullName(bool isMale)
        {
            return GetName(isMale) + " " + GetSurname(isMale);
        }

    static string GetName(bool isMale)
        {
            Random rnd = new Random();
            int n = rnd.Next(1, 16);
            int k = rnd.Next(1, 16);
            string surname = namesN[n - 1] + namesK[k - 1];
            if (isMale)
            {
                return surname;
            }
            else
            {
                return surname + "а";
            }
        }

    static string GetSurname(bool isMale)
        {
            Random rnd = new Random();
            int n = rnd.Next(1, 16);
            int k = rnd.Next(1, 16);
            string surname1 = namesN[n - 1] + namesK[k - 1];
            string suffix = "";
            if (isMale)
            {
                suffix = "ич";
            }
            else
            {
                suffix = "ична";
            }

            return surname1 + suffix;
        }
    }



