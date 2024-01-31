using System;
using System.Data;

class Program
{
    static public Journal journal;

    static void Main(string[] args)
    {
        journal = new Journal();
        Console.WriteLine("");
        Run();
    }

    static public string GetPrompt()
    {
        return "";
    }

    static public void Run()
    {
        bool keepGoing = true;
        while(keepGoing)
        {
            var selection = ShowMenu();
            if (selection == 1){
                var prompt = "This was a random prompt";
                var placeholderResponse = "This ";
                var entry = new Entry(placeholderResponse, prompt);
                journal.AddEntry(entry);

            } else if (selection == 2){

            }
            else if(selection == 5){
                keepGoing = false;
            }
        }

    }
    static int ShowMenu()
    {
        Console.WriteLine("Select Option: \n 1. add Entry \n 2. Display Entries ");
        string input = Console.ReadLine();
        return int.Parse(input);
    }

    public void SaveToFile()
    {

    }

    public void LoadJournal()
    {

    }
}