namespace Library;

public class NameContest
{
    private Node node;
    public NameContest(Node node)
    {
        this.node= node;
    }
    public string GetLargestName()
    {
        VisitorName visitor = new VisitorName();
        node.Accept(visitor);
        return visitor.LargestName;
    
    }
}