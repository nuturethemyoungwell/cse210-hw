


class promptGenerator
{
    public List<string> _prompts;

    public string randomprompt;
    
    public promptGenerator()
    {
        _prompts = new List<string>
        {
            "What would you to do? ",
            "What made your best today?",
            "What is the worse of your day?", 
            "If you have a chance to make a wish, what would that be?",
            "What would tomorrow?"
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

