class Action:

    # действие субъекта над объектом

    def __init__(self, name, goodness, id):
        self.name = name      # название действия
        self.goodness = goodness  # на сколько действие доброе 0 - нейтральное
        self.id = id
