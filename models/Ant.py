from random import random

class Person:

    # человек, носитель истории, субъект, объект, тот кто управляет историей и кем история управляет

    def __init__(self, name, uuid):
        self._stories = list()
        self._name = name
        self._uuid = uuid

    def tell_random(self):
        n = round(random()*1)
        r = self._stories[n-1].tell()
        return r

    def uuid(self):
        return self._uuid

    def name(self):
        return self._name