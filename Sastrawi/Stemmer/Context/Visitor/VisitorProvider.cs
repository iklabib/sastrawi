using Sastrawi.Morphology.Disambiguator;

namespace Sastrawi.Stemmer.Context.Visitor;

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

        suffixVisitors.Add(new RemoveInflectionalParticle());
        suffixVisitors.Add(new RemoveInflectionalPossessivePronoun());
        suffixVisitors.Add(new RemoveDerivationalSuffix());

        prefixVisitors.Add(new RemovePlainPrefix());
        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<IDisambiguator>
                {
                    new DisambiguatorPrefixRule1a(),
                    new DisambiguatorPrefixRule1b()
                }
            )
        );
        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<IDisambiguator>
                {
                    new DisambiguatorPrefixRule2()
                }
            )
        );
        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<IDisambiguator>
                {
                    new DisambiguatorPrefixRule3()
                }
            )
        );
        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<IDisambiguator>
                {
                    new DisambiguatorPrefixRule4()
                }
            )
        );
        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<IDisambiguator>
                {
                    new DisambiguatorPrefixRule5()
                }
            )
        );
        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<IDisambiguator>
                {
                    new DisambiguatorPrefixRule6a(),
                    new DisambiguatorPrefixRule6b()
                }
            )
        );

        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<IDisambiguator>
                {
                    new DisambiguatorPrefixRule7()
                }
            )
        );
        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<IDisambiguator>
                {
                    new DisambiguatorPrefixRule8()
                }
            )
        );
        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<IDisambiguator>
                {
                    new DisambiguatorPrefixRule9()
                }
            )
        );
        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<IDisambiguator>
                {
                    new DisambiguatorPrefixRule10()
                }
            )
        );
        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<IDisambiguator>
                {
                    new DisambiguatorPrefixRule11()
                }
            )
        );
        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<IDisambiguator>
                {
                    new DisambiguatorPrefixRule12()
                }
            )
        );
        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<IDisambiguator>
                {
                    new DisambiguatorPrefixRule13a(),
                    new DisambiguatorPrefixRule13b()
                }
            )
        );

        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<IDisambiguator>
                {
                    new DisambiguatorPrefixRule14()
                }
            )
        );
        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<IDisambiguator>
                {
                    new DisambiguatorPrefixRule15a(),
                    new DisambiguatorPrefixRule15b()
                }
            )
        );
        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<IDisambiguator>
                {
                    new DisambiguatorPrefixRule16()
                }
            )
        );

        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<IDisambiguator>
                {
                    new DisambiguatorPrefixRule17a(),
                    new DisambiguatorPrefixRule17b(),
                    new DisambiguatorPrefixRule17c(),
                    new DisambiguatorPrefixRule17d()
                }
            )
        );

        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<IDisambiguator>
                {
                    new DisambiguatorPrefixRule18a(),
                    new DisambiguatorPrefixRule18b()
                }
            )
        );
        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<IDisambiguator>
                {
                    new DisambiguatorPrefixRule19()
                }
            )
        );
        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<IDisambiguator>
                {
                    new DisambiguatorPrefixRule20()
                }
            )
        );

        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<IDisambiguator>
                {
                    new DisambiguatorPrefixRule21a(),
                    new DisambiguatorPrefixRule21b()
                }
            )
        );
        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<IDisambiguator>
                {
                    new DisambiguatorPrefixRule23()
                }
            )
        );
        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<IDisambiguator>
                {
                    new DisambiguatorPrefixRule24()
                }
            )
        );
        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<IDisambiguator>
                {
                    new DisambiguatorPrefixRule25()
                }
            )
        );

        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<IDisambiguator>
                {
                    new DisambiguatorPrefixRule26a(),
                    new DisambiguatorPrefixRule26b()
                }
            )
        );

        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<IDisambiguator>
                {
                    new DisambiguatorPrefixRule27()
                }
            )
        );

        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<IDisambiguator>
                {
                    new DisambiguatorPrefixRule28a(),
                    new DisambiguatorPrefixRule28b()
                }
            )
        );

        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<IDisambiguator>
                {
                    new DisambiguatorPrefixRule29()
                }
            )
        );

        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<IDisambiguator>
                {
                    new DisambiguatorPrefixRule30a(),
                    new DisambiguatorPrefixRule30b(),
                    new DisambiguatorPrefixRule30c()
                }
            )
        );

        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<IDisambiguator>
                {
                    new DisambiguatorPrefixRule31a(),
                    new DisambiguatorPrefixRule31b()
                }
            )
        );
        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<IDisambiguator>
                {
                    new DisambiguatorPrefixRule32()
                }
            )
        );
        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<IDisambiguator>
                {
                    new DisambiguatorPrefixRule34()
                }
            )
        );

        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<IDisambiguator>
                {
                    new DisambiguatorPrefixRule35()
                }
            )
        );
        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<IDisambiguator>
                {
                    new DisambiguatorPrefixRule36()
                }
            )
        );

        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<IDisambiguator>
                {
                    new DisambiguatorPrefixRule37a(),
                    new DisambiguatorPrefixRule37b()
                }
            )
        );

        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<IDisambiguator>
                {
                    new DisambiguatorPrefixRule38a(),
                    new DisambiguatorPrefixRule38b()
                }
            )
        );

        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<IDisambiguator>
                {
                    new DisambiguatorPrefixRule39a(),
                    new DisambiguatorPrefixRule39b()
                }
            )
        );

        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<IDisambiguator>
                {
                    new DisambiguatorPrefixRule40a(),
                    new DisambiguatorPrefixRule40b()
                }
            )
        );

        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<IDisambiguator>
                {
                    new DisambiguatorPrefixRule41()
                }
            )
        );
        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<IDisambiguator>
                {
                    new DisambiguatorPrefixRule42()
                }
            )
        );
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
