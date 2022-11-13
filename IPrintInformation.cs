using System;

// IPrintInformation interface with classes

namespace Interface
{
    interface IPrintInformation
    {
        // methods
        string GetName();
        void Print(string str);
    }
    public class Printer : IPrintInformation
    {
        // methods
        public string GetName()
        {
            return "It is Printer!";
        }
        public void Print(string str)
        {
            Console.WriteLine($"You've printed: {str}");
        }
    }
    public class Monitor : IPrintInformation
    {
        // methods
        public string GetName()
        {
            return "It is Monitor!";
        }
        public void Print(string str)
        {
            Console.WriteLine($"You've shown on the monitor: {str}");
        }
    }
}
