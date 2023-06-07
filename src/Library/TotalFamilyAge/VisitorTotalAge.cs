namespace Library;

public class VisitorTotalAge : Visitor
{
    private int totalAge = 0;
    public int TotalAge
        {
            get
            {
                return totalAge;
            }
        }
    public override void Visit(Person person)
    {
        totalAge+=person.Age;
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