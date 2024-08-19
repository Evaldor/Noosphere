
class Sentence:

    # предложение. базовый элемент истории.

    def __init__(self, subject, action, object, id):
        self._subject = subject      # субъект события
        self._action = action        # действие
        self._object = object        # объект события
        self._id = id            # идентификатор предложения

    def tell(self):
        return str(self._subject) +' '+self._action +' '+str(self._object)+'.'
    
    def id(self):
        return self._id