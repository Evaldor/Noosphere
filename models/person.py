from random import random

class Person:

    # человек, носитель истории, субъект, объект, тот кто управляет историей и кем история управляет

    def __init__(self, name, id):
        self._stories = list()
        self._name = name
        self._id = id

    def tell_random(self):
        n = round(random()*1)
        r = self._stories[n-1].tell()
        return r

    def uuid(self):
        return self._id

    def name(self):
        return self._name

    def add_story(self,story):
        self._stories.append(story)