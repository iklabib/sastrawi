using Morphology;

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

        suffixVisitors.Add(new RemoveInflectionalParticle());
        suffixVisitors.Add(new RemoveInflectionalPossessivePronoun());
        suffixVisitors.Add(new RemoveDerivationalSuffix());

        prefixVisitors.Add(new RemovePlainPrefix());
        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<Disambiguator.IDisambiguator>
                {
                    new Disambiguator.DisambiguatorPrefixRule1a(),
                    new Disambiguator.DisambiguatorPrefixRule1b()
                }
            )
        );
        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<Disambiguator.IDisambiguator>
                {
                    new Disambiguator.DisambiguatorPrefixRule2()
                }
            )
        );
        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<Disambiguator.IDisambiguator>
                {
                    new Disambiguator.DisambiguatorPrefixRule3()
                }
            )
        );
        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<Disambiguator.IDisambiguator>
                {
                    new Disambiguator.DisambiguatorPrefixRule4()
                }
            )
        );
        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<Disambiguator.IDisambiguator>
                {
                    new Disambiguator.DisambiguatorPrefixRule5()
                }
            )
        );
        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<Disambiguator.IDisambiguator>
                {
                    new Disambiguator.DisambiguatorPrefixRule6a(),
                    new Disambiguator.DisambiguatorPrefixRule6b()
                }
            )
        );

        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<Disambiguator.IDisambiguator>
                {
                    new Disambiguator.DisambiguatorPrefixRule7()
                }
            )
        );
        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<Disambiguator.IDisambiguator>
                {
                    new Disambiguator.DisambiguatorPrefixRule8()
                }
            )
        );
        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<Disambiguator.IDisambiguator>
                {
                    new Disambiguator.DisambiguatorPrefixRule9()
                }
            )
        );
        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<Disambiguator.IDisambiguator>
                {
                    new Disambiguator.DisambiguatorPrefixRule10()
                }
            )
        );
        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<Disambiguator.IDisambiguator>
                {
                    new Disambiguator.DisambiguatorPrefixRule11()
                }
            )
        );
        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<Disambiguator.IDisambiguator>
                {
                    new Disambiguator.DisambiguatorPrefixRule12()
                }
            )
        );
        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<Disambiguator.IDisambiguator>
                {
                    new Disambiguator.DisambiguatorPrefixRule13a(),
                    new Disambiguator.DisambiguatorPrefixRule13b()
                }
            )
        );

        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<Disambiguator.IDisambiguator>
                {
                    new Disambiguator.DisambiguatorPrefixRule14()
                }
            )
        );
        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<Disambiguator.IDisambiguator>
                {
                    new Disambiguator.DisambiguatorPrefixRule15a(),
                    new Disambiguator.DisambiguatorPrefixRule15b()
                }
            )
        );
        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<Disambiguator.IDisambiguator>
                {
                    new Disambiguator.DisambiguatorPrefixRule16()
                }
            )
        );

        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<Disambiguator.IDisambiguator>
                {
                    new Disambiguator.DisambiguatorPrefixRule17a(),
                    new Disambiguator.DisambiguatorPrefixRule17b(),
                    new Disambiguator.DisambiguatorPrefixRule17c(),
                    new Disambiguator.DisambiguatorPrefixRule17d()
                }
            )
        );

        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<Disambiguator.IDisambiguator>
                {
                    new Disambiguator.DisambiguatorPrefixRule18a(),
                    new Disambiguator.DisambiguatorPrefixRule18b()
                }
            )
        );
        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<Disambiguator.IDisambiguator>
                {
                    new Disambiguator.DisambiguatorPrefixRule19()
                }
            )
        );
        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<Disambiguator.IDisambiguator>
                {
                    new Disambiguator.DisambiguatorPrefixRule20()
                }
            )
        );

        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<Disambiguator.IDisambiguator>
                {
                    new Disambiguator.DisambiguatorPrefixRule21a(),
                    new Disambiguator.DisambiguatorPrefixRule21b()
                }
            )
        );
        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<Disambiguator.IDisambiguator>
                {
                    new Disambiguator.DisambiguatorPrefixRule23()
                }
            )
        );
        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<Disambiguator.IDisambiguator>
                {
                    new Disambiguator.DisambiguatorPrefixRule24()
                }
            )
        );
        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<Disambiguator.IDisambiguator>
                {
                    new Disambiguator.DisambiguatorPrefixRule25()
                }
            )
        );

        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<Disambiguator.IDisambiguator>
                {
                    new Disambiguator.DisambiguatorPrefixRule26a(),
                    new Disambiguator.DisambiguatorPrefixRule26b()
                }
            )
        );

        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<Disambiguator.IDisambiguator>
                {
                    new Disambiguator.DisambiguatorPrefixRule27()
                }
            )
        );

        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<Disambiguator.IDisambiguator>
                {
                    new Disambiguator.DisambiguatorPrefixRule28a(),
                    new Disambiguator.DisambiguatorPrefixRule28b()
                }
            )
        );

        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<Disambiguator.IDisambiguator>
                {
                    new Disambiguator.DisambiguatorPrefixRule29()
                }
            )
        );

        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<Disambiguator.IDisambiguator>
                {
                    new Disambiguator.DisambiguatorPrefixRule30a(),
                    new Disambiguator.DisambiguatorPrefixRule30b(),
                    new Disambiguator.DisambiguatorPrefixRule30c()
                }
            )
        );

        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<Disambiguator.IDisambiguator>
                {
                    new Disambiguator.DisambiguatorPrefixRule31a(),
                    new Disambiguator.DisambiguatorPrefixRule31b()
                }
            )
        );
        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<Disambiguator.IDisambiguator>
                {
                    new Disambiguator.DisambiguatorPrefixRule32()
                }
            )
        );
        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<Disambiguator.IDisambiguator>
                {
                    new Disambiguator.DisambiguatorPrefixRule34()
                }
            )
        );

        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<Disambiguator.IDisambiguator>
                {
                    new Disambiguator.DisambiguatorPrefixRule35()
                }
            )
        );
        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<Disambiguator.IDisambiguator>
                {
                    new Disambiguator.DisambiguatorPrefixRule36()
                }
            )
        );

        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<Disambiguator.IDisambiguator>
                {
                    new Disambiguator.DisambiguatorPrefixRule37a(),
                    new Disambiguator.DisambiguatorPrefixRule37b()
                }
            )
        );

        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<Disambiguator.IDisambiguator>
                {
                    new Disambiguator.DisambiguatorPrefixRule38a(),
                    new Disambiguator.DisambiguatorPrefixRule38b()
                }
            )
        );

        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<Disambiguator.IDisambiguator>
                {
                    new Disambiguator.DisambiguatorPrefixRule39a(),
                    new Disambiguator.DisambiguatorPrefixRule39b()
                }
            )
        );

        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<Disambiguator.IDisambiguator>
                {
                    new Disambiguator.DisambiguatorPrefixRule40a(),
                    new Disambiguator.DisambiguatorPrefixRule40b()
                }
            )
        );

        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<Disambiguator.IDisambiguator>
                {
                    new Disambiguator.DisambiguatorPrefixRule41()
                }
            )
        );
        prefixVisitors.Add(
            new PrefixDisambiguator(
                new List<Disambiguator.IDisambiguator>
                {
                    new Disambiguator.DisambiguatorPrefixRule42()
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
