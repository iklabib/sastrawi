namespace Context;
public interface IContext
{
    public string GetOriginalWord();

    public string GetCurrentWord();

    public void SetCurrentWord(string word);

    public HashSet<string> GetDictionary();

    public void StopProcess();

    public bool ProcessIsStopped();

    public void AddRemoval(IRemoval removal);

    public List<IRemoval> GetRemovals();
}