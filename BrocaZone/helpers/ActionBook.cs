namespace BrocaZone.helpers;

public class ActionBook
{
    private List<models.Action> _actions;

    public ActionBook()
    {
        _actions = new List<models.Action>();
        models.Action a = new models.Action("поприветствовал", 0, 1);
        _actions.Append(a);
        _actions.Append(new models.Action("обнял", 1, 2));
        _actions.Append(new models.Action("дал еды", 2, 3));
        _actions.Append(new models.Action("пнул", -1, 4));
        _actions.Append(new models.Action("отнял еду", -2, 5));
    }
}
