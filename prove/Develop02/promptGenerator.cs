


class promptGenerator
{
    public List<string> _prompts;

    public string randomprompt;
    
    public promptGenerator()
    {
        _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today? ",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?", 
            "If I had one thing I could do over today, what would that be?",
            "What was the strongest emotion i felt today?"
        };
    }

    public string GetRandomPrompt()
    {
        Random rand  = new Random();
        //Generate a random prompt less than the size of the list
        int index = rand.Next(_prompts.Count);
        string randomprompt = _prompts[index];
        //Display the result of the sstring
        return randomprompt;
    }
}

