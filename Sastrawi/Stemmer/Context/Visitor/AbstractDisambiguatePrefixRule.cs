using System.Text.RegularExpressions;
using Sastrawi.Morphology.Disambiguator;

namespace Sastrawi.Stemmer.Context.Visitor;

abstract class AbstractDisambiguatePrefixRule : IVisitor
{
    protected List<IDisambiguator> disambiguators = new();

    public void Visit(IContext context)
    {
        string result = string.Empty;
        var dictionary = context.GetDictionary();
        foreach (var disambiguator in disambiguators)
        {
            result = disambiguator.Disambiguate(context.GetCurrentWord());
            if (!String.IsNullOrEmpty(result) && dictionary.Contains(result))
                break;
        }

        if (String.IsNullOrEmpty(result))
            return;

        Regex regex = new Regex(result);
        string removedPart = regex.Replace(context.GetCurrentWord(), "", 1);
        IRemoval removal = new Removal(this, context.GetCurrentWord(), result, removedPart, "DP");
        context.AddRemoval(removal);
        context.SetCurrentWord(result);
    }

    public void AddDisambiguators(List<IDisambiguator> disambiguators)
    {
        this.disambiguators.AddRange(disambiguators);
    }

    public void AddDisambiguator(IDisambiguator disambiguator)
    {
        this.disambiguators.Add(disambiguator);
    }
}
