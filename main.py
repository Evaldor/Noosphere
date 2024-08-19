import helpers.tribe_generator
import helpers.actions_generator
import models
import models.sentence
import models.story
import uuid
import random

tribe = helpers.tribe_generator.generate_tribe(10)
actions = helpers.actions_generator.seed()

for p in tribe:

    st_id = uuid.uuid4()
    st = models.story.Story(st_id)

    i = 100
    while (i > 0):
        se_id = uuid.uuid4()
        se = models.sentence.Sentence(random.choice(list(tribe.keys())), random.choice(list(actions.keys())), random.choice(list(tribe.keys())), se_id)
        st.sentences.append(se)
        i = i - 1

    tribe[p].stories.append(st)

# выводим все истории
'''
for p in tribe:
    print(tribe[p].name)
    for st in tribe[p].stories:
        for se in st.sentences:
            print(tribe[se.subject].name+' '+actions[se.action].name+' '+tribe[se.object].name+'.')
'''
# вычисляем отношение

print('как относится')
p1 = random.choice(list(tribe.keys()))
print(tribe[p1].name)
print('к')
p2 = random.choice(list(tribe.keys()))
print(tribe[p2].name)

attitude = 0

for st in tribe[p1].stories:

    for se in st.sentences:
        if (se.object == p1 and se.subject== p2):
            attitude = attitude + actions[se.action].goodness

print(attitude)


