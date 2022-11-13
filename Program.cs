using System;
using System.Collections.Generic;

// Task - create interface system with inheritance

namespace Interface
{
    public class Comp
    {
        // properties
        public int countDisk;
        public int countPrintDevice;
        public List<Disk> disks;
        public List<IPrintInformation> printDevice;

        // methods
        public void AddDevice(int index, IPrintInformation si)
        {
            Console.WriteLine("Give the information about your new device:");
            string str = Console.ReadLine();
            Console.WriteLine("Your new device is ");
        }
        public void AddDisk (int index, Disk d)
        {
            Console.WriteLine("Adding new disk:");
            disks.Add(d);
        }
        public bool CheckDisk(string device)
        {
            Console.WriteLine($"Disk inserted here is: {device}");
        }
        public void InsertReject(string device, bool b)
        {
            Console.WriteLine($"Inserted disk is: {device}");
        }
        public void PrintInfo(string text, string device)
        {
            Console.WriteLine($"The device you've inserted is: {device}");
            Console.WriteLine($"Information about given device is: {text}");
        }
        public void ShowDisk()
        {
            Console.WriteLine("You've entered the disk!");
        }
        public void ShowPrintDevice()
        {
            Console.WriteLine("You've chose the print device!");
        }
        public void WriteInfo(string text)
        {
            Console.WriteLine(text);
        }

    }
    class Program
    {
        // initialization
        static void Main(string[] args)
        {
            Comp comp = new Comp();
            comp.AddDevice(1. d);
            comp.CheckDisk(CD);
            comp.ShowDisk();
            comp.WriteInfo("Cd if inserted!");
        }
    }
}
