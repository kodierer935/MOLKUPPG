using System;
using System.Collections.Generic;
using System.Diagnostics;

class InternetLink
{
    public string Topic { get; set; }
    public string Site { get; set; }
    public string Title { get; set; }
    public string Link { get; set; }
}

class Program
{
    static List<InternetLink> links = new List<InternetLink>();

    static void Main()
    {
        while (true)
        {
            Console.Write("Enter a command: ");
            string input = Console.ReadLine();

            string[] command = input.Split(' ');

            switch (command[0])
            {
                case "edit":
                    EditList();
                    break;
                case "load":
                    LoadLinks("C:\\Users\\Erik\\Desktop\\" + command[1]);
                    break;
                case "list":
                    ListLinks(command);
                    break;
                case "open":
                    OpenLink(command);
                    break;
                case "save":
                    SaveLinks(command);
                    break;
                case "quit":
                    Console.WriteLine("Exiting program.");
                    return;
                default:
                    Console.WriteLine("Command not recognized. Try again.");
                    break;
            }
        }
    }

    static void EditList()
    {
        Console.WriteLine("Opening the list for editing...");
        // Placeholder: Logic to open and edit the list using a text editor
        // Example: Notepad integration
        Process.Start("notepad.exe", "C:\\Users\\Erik\\Desktop\\tester.txt");
    }

    static void LoadLinks(string file)
    {
        Console.WriteLine($"Loading links from file: {file}");
        try
        {
            string[] lines = File.ReadAllLines(file);
            links.Clear(); // Clear the existing links
            foreach (string line in lines)
            {
                string[] parts = line.Split(';');
                if (parts.Length == 4)
                {
                    links.Add(new InternetLink
                    {
                        Topic = parts[0],
                        Site = parts[1],
                        Title = parts[2],
                        Link = parts[3]
                    });
                }
            }
            Console.WriteLine("Links loaded successfully.");
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred while loading links: " + e.Message);
        }
    }


    static void ListLinks(string[] command)
    {
        if (command.Length == 1)
        {
            Console.WriteLine("Listing all links:");
            foreach (var link in links)
            {
                Console.WriteLine($"Topic: {link.Topic}, Site: {link.Site}, Title: {link.Title}");
            }
        }
        else if (command[1] == "topic")
        {
            string topic = command[2];
            Console.WriteLine($"Listing links under topic: {topic}");
            var topicLinks = links.FindAll(l => l.Topic == topic);
            foreach (var link in topicLinks)
            {
                Console.WriteLine($"Site: {link.Site}, Title: {link.Title}");
            }
        }
        else if (command[1] == "site")
        {
            string site = command[2];
            Console.WriteLine($"Listing links from site: {site}");
            var siteLinks = links.FindAll(l => l.Site == site);
            foreach (var link in siteLinks)
            {
                Console.WriteLine($"Topic: {link.Topic}, Title: {link.Title}");
            }
        }
    }

    static void OpenLink(string[] command)
    {
        int index = int.Parse(command[1]);
        if (index >= 0 && index < links.Count)
        {
            Console.WriteLine($"Opening link with index {index}: {links[index].Link}");
            
            // Placeholder: Logic to open the link in a browser or application
            // Example: Opens the link in a browser
            Process.Start(links[index].Link);
        }
        else
        {
            Console.WriteLine("Invalid index. Please provide a valid index.");
        }
    }

    static void SaveLinks(string[] command)
    {
        string fileToSave = "C:\\Users\\Erik\\Desktop\\tester.txt"; // Set the path to the file
        try
        {
            using (StreamWriter writer = new StreamWriter(fileToSave))
            {
                foreach (var link in links)
                {
                    writer.WriteLine($"{link.Topic};{link.Site};{link.Title};{link.Link}");
                }
                Console.WriteLine("Links saved successfully.");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred while saving links: " + e.Message);
        }
    }

}
