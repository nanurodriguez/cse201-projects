

public class PromptGenerator
{
    public List<string> _prompts;
    public string GetRandomPrompt()
    {
        Random randomPrompts = new Random();
        int index = randomPrompts.Next(_prompts.Count);
        return _prompts[index];

    }
    // all the prompts are in the Journal Class 
    //The PromptGenerator calls those prompts and get's a random int index and then 
    // Journal displays it*\
}