namespace Library;

public abstract class Visitor
{
    public abstract void Visit(Person person);
    public abstract void Visit(Node node);
}