using Visitor;

namespace Context;

class Removal : IRemoval
{
    protected IVisitor visitor;
    protected string subject;
    protected string result;
    protected string removedPart;
    protected string affixType;

    public Removal(
        IVisitor visitor,
        string subject,
        string result,
        string removedPart,
        string affixType
    )
    {
        this.visitor = visitor;
        this.subject = subject;
        this.result = result;
        this.removedPart = removedPart;
        this.affixType = affixType;
    }

    public IVisitor GetVisitor()
    {
        return visitor;
    }

    public string GetSubject()
    {
        return subject;
    }

    public string GetResult()
    {
        return result;
    }

    public IRemoval Clone()
    {
        return new Removal(
            this.visitor,
            this.subject,
            this.result,
            this.removedPart,
            this.affixType
        );
    }

    public string GetRemovedPart()
    {
        return removedPart;
    }

    public string GetAffixType()
    {
        return affixType;
    }
}
