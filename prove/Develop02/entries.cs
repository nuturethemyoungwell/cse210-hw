
class Entry
{
    string todaysdate, prompt, response;

    public Entry(string _date, string _prompt, string _response)
    {
        todaysdate = _date;
        prompt = _prompt;
        response = _response;
    }

    public void displayEntries()
    {
        Console.WriteLine($"Date: {todaysdate} | prompt: {prompt}");
        Console.WriteLine(response);
    }

    public string getEntriesAsCSV()
    {
        return string.Format("{0} | {1} | {2}", todaysdate, prompt, response);
    }
}