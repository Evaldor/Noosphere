import models.action

def seed():
    actions = {}

    actions[1] = models.action.Action("поприветствовал", 0, 1)
    actions[2] = models.action.Action("обнял", 1, 2)
    actions[3] = models.action.Action("поделился едой", 2, 3)
    actions[4] = models.action.Action("пнул", -1, 4)
    actions[5] = models.action.Action("отнял еду", -2, 5)

    return actions