from random import random

class Person:

    # человек, носитель истории, субъект, объект, тот кто управляет историей и кем история управляет

    def __init__(self, name, id):
        self.stories = list()
        self.name = name
        self.id = id

    def tell_random(self):
        n = round(random()*1)
        r = self._stories[n-1].tell()
        return r
