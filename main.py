import helpers.tribe_generator 

tribe = helpers.tribe_generator.generate_tribe(10)

for p in tribe:
    print(tribe[p].name())

