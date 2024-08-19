class Story:

    # история состоит из последовательных связанных предложений

    def __init__(self, id):
        self._stories = list()
        self._id = id

    def tell(self):
        
        r = ''

        for story in self._stories:
            r = r + story.tell() +' '

        return r

    def uuid(self):
        return self._id
    
    def add_sentence(self,sentence):
        self._stories.append(sentence)