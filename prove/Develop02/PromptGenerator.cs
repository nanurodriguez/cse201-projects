

public class PromptGenerator
{

    public List<string> _prompts = new List<string>
        {"What did you do today?", "Did you meet someone interesting?",
        "Let's mention your blessings:", "Did you find something interesting in your scripture reading?",
        "Mention something you enjoyed doing today:","Did you learn something new?", "Did you inspire other people?"};

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}