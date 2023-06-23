namespace Visitor;

public class VisitorProvider
{
    protected List<IVisitor> visitors = new();
    protected List<IVisitor> suffixVisitors = new();
    protected List<IVisitor> prefixVisitors = new();

    public VisitorProvider()
    {
        initVisitors();
    }
    protected void initVisitors()
    {
        visitors.Add(new DontStemStopWord());
    }

    public List<IVisitor> GetVisitors()
    {
        return visitors;
    }

    public List<IVisitor> GetSuffixVisitors()
    {
        return suffixVisitors;
    }

    public List<IVisitor> GetPrefixVisitors()
    {
        return prefixVisitors;
    }
}