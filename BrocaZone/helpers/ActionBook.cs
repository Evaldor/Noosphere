namespace BrocaZone.helpers;

public class ActionBook
{
    public List<models.Action> _actions = new List<models.Action>();

    public ActionBook()
    {
        _actions.Add(new models.Action("поприветствовал", 0, 1));
        _actions.Add(new models.Action("обнял", 1, 2));
        _actions.Add(new models.Action("дал еды", 2, 3));
        _actions.Add(new models.Action("пнул", -1, 4));
        _actions.Add(new models.Action("отнял еду", -2, 5));
    }

    public models.Action GetRandomAction()
    {
        Random rnd = new Random();
        return _actions[0];
    }

}
