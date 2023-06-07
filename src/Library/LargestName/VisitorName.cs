namespace Library;

public class VisitorName : Visitor
{
    private string largestName = "";
    public string LargestName
        {
            get
            {
                return largestName;
            }
        }
    public override void Visit(Person person)
    {
        if(person.Name.Length > largestName.Length)
        {
            largestName = person.Name;
        }
    }
    public override void Visit(Node node)
    {
        node.Person.Accept(this);
        foreach (Node Child in node.Children)
        {
            Child.Accept(this);
        }
    }


}