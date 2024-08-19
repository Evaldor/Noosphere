import helpers.tribe_generator 
import models
import models.sentence
import models.story
import uuid
import random

tribe = helpers.tribe_generator.generate_tribe(2)


for p in tribe:

    st_id = uuid.uuid4()
    st = models.story.Story(st_id)

    i = 3
    while (i > 0):
        se_id = uuid.uuid4()
        se = models.sentence.Sentence(random.choice(list(tribe.keys())), "приветствовал", random.choice(list(tribe.keys())), se_id)
        st.sentences.append(se)
        i = i - 1

    tribe[p].stories.append(st)

r = ''
for p in tribe:
    print(tribe[p].name)
    for st in tribe[p].stories:
        for se in st.sentences:
            print(str(se.subject)+' '+se.action+' '+str(se.object)+'.')

