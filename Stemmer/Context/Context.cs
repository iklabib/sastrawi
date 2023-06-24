using Visitor;
using ConfixStripping;

namespace Context;

class Context : IContext, IVisitable
{
    protected string originalWord;
    protected string currentWord;
    protected bool processIsStopped;
    protected HashSet<string> dictionary;
    protected VisitorProvider visitorProvider;
    protected List<IRemoval> removals = new();
    protected List<IVisitor> visitors = new();
    protected List<IVisitor> suffixVisitors = new();
    protected List<IVisitor> prefixVisitors = new();
    protected string result = string.Empty;

    public Context(string originalWord, HashSet<string> dictionary, VisitorProvider visitorProvider)
    {
        this.originalWord = originalWord;
        this.currentWord = originalWord;
        this.dictionary = dictionary;
        this.visitorProvider = visitorProvider;

        initVisitors();
    }

    protected void initVisitors()
    {
        visitors = visitorProvider.GetVisitors();
        suffixVisitors = visitorProvider.GetSuffixVisitors();
        prefixVisitors = visitorProvider.GetPrefixVisitors();
    }

    public HashSet<string> GetDictionary()
    {
        return dictionary;
    }

    public void SetDictionary(HashSet<string> dictionary)
    {
        this.dictionary = dictionary;
    }

    public string GetOriginalWord()
    {
        return originalWord;
    }

    public void SetCurrentWord(string word)
    {
        currentWord = word;
    }

    public string GetCurrentWord()
    {
        return currentWord;
    }

    public void StopProcess()
    {
        processIsStopped = true;
    }

    public bool ProcessIsStopped()
    {
        return processIsStopped;
    }

    public void AddRemoval(IRemoval removal)
    {
        removals.Add(removal);
    }

    public List<IRemoval> GetRemovals()
    {
        return removals;
    }

    public string GetResult()
    {
        return result;
    }

    public void Execute()
    {
        // step 1 - 5
        startStemmingProcess();
        if (currentWord == "")
            this.result = originalWord;

        // step 6
        if (dictionary.Contains(currentWord))
            this.result = currentWord;
        else
            this.result = originalWord;
    }

    protected void startStemmingProcess()
    {
        if (dictionary.Contains(currentWord))
            return;

        acceptVisitors(visitors);

        if (dictionary.Contains(currentWord))
            return;

        var csPrecedenceAdjustmentSpecification = new PrecedenceAdjustmentSpecification();
        /*
         * Confix Stripping
         * Try to remove prefix before suffix if the specification is met
        */
        if (csPrecedenceAdjustmentSpecification.IsSatisfiedBy(originalWord))
        {
            // step 4, 5
            removePrefixes();
            if (dictionary.Contains(currentWord))
                return;

            // step 2, 3
            removeSuffixes();
            if (dictionary.Contains(currentWord))
                return;

            // if the trial is failed, restore the original word
            // and continue to normal rule precedence (suffix first, prefix afterwards)
            SetCurrentWord(originalWord);
            removals = new List<IRemoval>();
        }

        // step 2, 3
        removeSuffixes();
        if (dictionary.Contains(currentWord))
            return;

        // step 4, 5
        removePrefixes();
        if (dictionary.Contains(currentWord))
            return;

        // ECS loop pengembalian akhiran
        loopPengembalianAkhiran();
    }

    protected void removePrefixes()
    {
        for (int i = 0; i < 3; ++i)
        {
            acceptPrefixVisitors(prefixVisitors);
            if (dictionary.Contains(currentWord))
            {
                return;
            }
        }
    }

    protected void removeSuffixes()
    {
        acceptVisitors(suffixVisitors);
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }

    protected string acceptVisitors(List<IVisitor> visitors)
    {
        foreach (var visitor in visitors)
        {
            Accept(visitor);
            if (GetDictionary().Contains(currentWord))
                return currentWord;

            if (ProcessIsStopped())
                return currentWord;
        }
        return "";
    }

    protected string acceptPrefixVisitors(List<IVisitor> visitors)
    {
        int removalCount = removals.Count();
        foreach (var visitor in visitors)
        {
            Accept(visitor);
            if (dictionary.Contains(currentWord))
                return currentWord;

            if (processIsStopped)
                return currentWord;

            if (removals.Count() > removalCount)
                return "";
        }

        return "";
    }

    protected void loopPengembalianAkhiran()
    {
        restorePrefix();
        string currentWord = this.currentWord;

        var removals = this.removals.AsEnumerable().Reverse();
        foreach (var removal in removals)
        {
            if (isSuffixRemoval(removal))
                continue;

            if (removal.GetRemovedPart() == "kan")
            {
                SetCurrentWord(removal.GetResult() + "k");

                // step 4, 5
                removePrefixes();
                if (dictionary.Contains(currentWord))
                    return;

                SetCurrentWord(removal.GetResult() + "kan");
            }
            else
            {
                SetCurrentWord(removal.GetResult());
            }

            // step 4, 5
            removePrefixes();
            if (dictionary.Contains(currentWord))
                return;

            this.removals = removals.ToList();
            SetCurrentWord(currentWord);
        }
    }

    protected bool isSuffixRemoval(IRemoval removal)
    {
        return removal.GetAffixType() == "DS"
            || removal.GetAffixType() == "PP"
            || removal.GetAffixType() == "P";
    }

    protected void restorePrefix()
    {
        foreach (var removal in removals)
        {
            if (removal.GetAffixType() == "DP")
            {
                SetCurrentWord(removal.GetSubject());
                break;
            }
        }

        for (int i = removals.Count() - 1; i > 0; --i)
        {
            var removal = removals[i];
            if (removal.GetAffixType() == "DP")
                removals.RemoveAt(i);
        }
    }
}
