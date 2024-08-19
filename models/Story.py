class Story:

    # история состоит из последовательных связанных предложений

    def __init__(self, id):
        self._subjects = list()
        self._id = id

    def tell(self):
        
        r = ''

        for subject in self._subjects:
            r = r + subject.tell() +' '

        return r

    def uuid(self):
        return self._id