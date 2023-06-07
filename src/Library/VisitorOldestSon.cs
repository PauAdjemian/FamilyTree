namespace Library;

public class VisitorOldestSon : Visitor
{
    private int age = 0;
    private string name;
    public string Name
        {
            get
            {
                return name;
            }
        }
    public override void Visit(Person person)
    {
        if (person.Age > age)
        {
            age=person.Age;
            name=person.Name;
        }
    }
    public override void Visit(Node node)
    {
        foreach (Node children in node.Children)
        {
            this.Visit(children.Person);
            children.Accept(this);
        }
    }
    public string Content(Node node)
    {
        VisitorOldestSon visitor = new VisitorOldestSon();
        node.Accept(visitor);
        return visitor.Name;
    }
}