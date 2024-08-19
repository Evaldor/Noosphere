import models.person
import uuid
from random import random

namesn = ["Свято", "Яро", "Влади", "Изя", "Вяче", "Мечи", "Бори", "Гори", "Бого", "Любо","Мило","Свето","Миро","Добро","Брони"]
namesk = ["слав", "мир", "полк", "люб", "рад", "мил", "зар", "мысл", "дан", "гор", "яр", "вед", "бор", "мысл", "свет"]

def get_fullname(gender):
    return get_name(gender)+' '+get_surname(gender)

def get_surname(gender):
    n = round(random()*15)
    k = round(random()*15)
    s1 = namesn[n-1]+namesk[k-1]
    if gender == "м":
        s = s1 + "ич"
    elif gender == "ж":
        s = s1 + "ична"
    else:
        s = "NaN"
    return s


def get_name(gender):
    n = round(random()*15)
    k = round(random()*15)
    s1 = namesn[n-1]+namesk[k-1]
    if gender == "м":
        s = s1
    elif gender == "ж":
        s = s1+"а"
    else:
        s = "NaN"
    return s

def generate_tribe(population):

    tribe = {}

    while (population > 0):
        id = uuid.uuid4()
        name = get_fullname("м")
        tribe[id] = models.person.Person(name,id)
        population = population - 1

    return tribe