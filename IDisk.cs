using System;

// IDisk interface with classes

namespace Interface
{
    interface IDisk
    {
        // property
        string Read();
        // method
        void Write(string text);
    }
    public class Disk : IDisk
    {
        // readonly fields
        public readonly string memory;
        public readonly int memSize;

        // properties
        public int Memory { get; set; }
        public int MemSize { get; set; }

        // constructors
        public Disk() { }
        public Disk(string memory, int memSize) { }

        public string GetName()
        {
            return "It is Disk!";
        }
        public string Read()
        {
            return "Reading information...";
        }
        public void Write(string text)
        {
            Console.WriteLine($"Your text: {text}");
        }
    }
    public class HDD : Disk
    {
        // method
        public string GetName()
        {
            return "It is HDD!";
        }
    }
}
