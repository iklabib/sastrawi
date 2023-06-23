using Context;
using Visitor;
using System.Text.RegularExpressions;
abstract class AbstractDisambiguatePrefixRule : IVisitor {
    protected List<IDisambiguator> disambiguators = new();
    public void Visit(IContext context)
    {
        string? result = null;
        var dictionary = context.GetDictionary();
        foreach (var disambiguator in disambiguators)
        {
            result = disambiguator.Disambiguate(context.GetCurrentWord());
            if (dictionary.ContainsKey(result))
                break;
        }

        if (result == null)
            return;

        Regex regex = new Regex(result);
        string removedPart = regex.Replace(context.GetCurrentWord(), "", 1);
        IRemoval removal = new Removal(this, 
                                       context.GetCurrentWord(), 
                                       result, 
                                       removedPart, 
                                       "DP");
        context.AddRemoval(removal);
        context.SetCurrentWord(result);
    }

    public void addDisambiguators(List<IDisambiguator> disambiguators)
    {
        this.disambiguators.AddRange(disambiguators);
    }

    public void addDisambiguator(IDisambiguator disambiguator)
    {
        this.disambiguators.Add(disambiguator);
    }
}
