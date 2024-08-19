class Story:

    # история состоит из последовательных связанных предложений

    def __init__(self, uuid):
        self._subjects = list()
        self._uuid = uuid

    def tell(self):
        
        r = ''

        for subject in self._subjects:
            r = r + subject.tell() +' '

        return r

    def uuid(self):
        return self._uuid