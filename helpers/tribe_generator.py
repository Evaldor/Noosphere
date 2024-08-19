import models
import name_generator

def generate_tribe(population):

    tribe = {}

    while (population > 0):
        uuid = uuid.uuid4()
        name = name_generator.get_fullname()
        tribe[uuid] = models.Person(name,uuid)

    return tribe