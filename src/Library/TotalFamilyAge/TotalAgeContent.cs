namespace Library;

public class TotalAgeContent
{
    private Node node;
    public TotalAgeContent(Node node)
    {
        this.node= node;
    }
    public int GetTotalAges()
    {
        VisitorTotalAge visitor = new VisitorTotalAge();
        node.Accept(visitor);
        return visitor.TotalAge;
    
    }
}
   