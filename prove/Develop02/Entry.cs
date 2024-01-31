public class Entry
{
    public string response;
    
    public string prompt;

    public string date;

    public Entry(string prompt, string response)
    {
        this.response = response;
        this.prompt = prompt;
    }
    public Entry(string import)
    {

    }
    

    public void Display(){

    }

    public string Export()
    {
        return "";
    }
}