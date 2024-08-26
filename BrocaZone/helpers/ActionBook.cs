namespace BrocaZone.helpers;

public class ActionBook
{
    public List<models.Action> _actions = new List<models.Action>();

    public ActionBook()
    {
        _actions.Add(new models.Action("возлюбил", 1, 0));
        _actions.Add(new models.Action("ударил", -1, 1));
        _actions.Add(new models.Action("одарил", 1, 2));
        _actions.Add(new models.Action("пошел", 0, 3));
        _actions.Add(new models.Action("взял", 0, 4));
        _actions.Add(new models.Action("породил", 0, 5));
    }

    public models.Action GetRandomAction()
    {
        Random random = new Random(); 
        int number = random.Next(_actions.Count());
        return _actions[number];
    }

}
