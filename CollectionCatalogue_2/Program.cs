using System;

namespace CollectionCatalogue_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Collections myCollection = new Collections();

            Checklist myChecklist = new Checklist();

            Console.WriteLine("This program will help you keep track of your collection" +
                " and allow you to add or remove items you're trying to collect " +
                "as well as items you've already collected.");
            Console.WriteLine("Here are the available commands. They are case-sensitive:");
            Console.WriteLine("additem - This command will allow you to add items to your checklist");
            Console.WriteLine("removeitem - This command will allow you to remove items from your checklist");
            Console.WriteLine("collectitem - This command will allow you to indicate that you have " +
                "collected an item on your checklist");
            Console.WriteLine("uncollectitem - This command will allow you to indicate that you " +
                "no longer have ownership of an item on your checklist");
            Console.WriteLine("viewlists - This command will show you your checklist and " +
                "collection");

            string command = Console.ReadLine();
            do
            {
                if (command == "additem")
                { 
                    Console.WriteLine("Please enter the name of the item:");
                    myChecklist.ChecklistAdd(Console.ReadLine());
                    Console.WriteLine("Please enter another command:");
                    command = Console.ReadLine();
                }
                else if (command == "removeitem")
                {
                    Console.WriteLine("Please enter the name of the item:");
                    myChecklist.ChecklistRemove(Console.ReadLine());
                    Console.WriteLine("Please enter another command:");
                    command = Console.ReadLine();
                }
                else if (command == "collectitem")
                {
                    Console.WriteLine("Please enter the name of the item:");
                    string temp = Console.ReadLine();
                    myCollection.AddCollectedItem(temp);
                    myChecklist.ChecklistRemove(temp);
                    Console.WriteLine("Please enter another command:");
                    command = Console.ReadLine();
                }
                else if (command == "uncollectitem")
                {
                    Console.WriteLine("Please enter the name of the item:");
                    string temp = Console.ReadLine();
                    myCollection.RemoveCollectedItem(temp);
                    myChecklist.ChecklistAdd(temp);
                    Console.WriteLine("Please enter another command:");
                    command = Console.ReadLine();
                }
                else if (command == "viewlists")
                {
                    Console.WriteLine("My Checklist:");
                    myChecklist.AvailableItems.ForEach(Console.WriteLine);
                    Console.WriteLine("");
                    Console.WriteLine("My Collection:");
                    myCollection.CollectedItems.ForEach(Console.WriteLine);
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid command:");
                    command = Console.ReadLine();
                }
            } while (command != "");

            Console.ReadLine();
        }
    }
}
