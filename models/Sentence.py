
class Sentence:

    # предложение. базовый элемент истории.

    def __init__(self, subject, action, object, id):
        self.subject = subject      # субъект события
        self.action = action        # действие
        self.object = object        # объект события
        self.id = id            # идентификатор предложения
