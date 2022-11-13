using System;

// IRemovableDisk interface with classes

namespace Interface
{
    interface IRemovableDisk
    {
        // property
        bool HasDisk { get; }

        // methods
        void Insert()
        {
            Console.WriteLine("Removable Disk is inserted.");
        }
        void Reject()
        {
            Console.WriteLine("Removable Disk is rejected.");
        }
    }
    public class CD : Disk, IRemovableDisk
    {
        // properties
        public readonly bool hasDisk;
        public bool HasDisk { get; }

        // methods
        public string GetName()
        {
            return "It is CD!";
        }
        public void Insert()
        {
            Console.WriteLine("The disk is inserted!");
        }
        public void Reject()
        {
            Console.WriteLine("The disk was rejected!");
        }
    }
    public class Flash : Disk, IRemovableDisk
    {
        // properties
        public readonly bool hasDisk;
        public bool HasDisk { get; }

        // methods
        public string GetName()
        {
            return "It is Flash!";
        }
        public void Insert()
        {
            Console.WriteLine("The disk is inserted!");
        }
        public void Reject()
        {
            Console.WriteLine("The disk was rejected!");
        }
    }
    public class DVD : Disk, IRemovableDisk
    {
        // properties
        public readonly bool hasDisk;
        public bool HasDisk { get; }

        // methods
        public string GetName()
        {
            return "It is DVD!";
        }
        public void Insert()
        {
            Console.WriteLine("The DVD is inserted!");
        }
        public void Reject()
        {
            Console.WriteLine("The DVD was rejected!");
        }
    }
}
