using System;
using System.Collections.Concurrent;

namespace Interfaces
{
    interface IRemoveableDisk
    {
        bool HasDisk { get; }

        void Insert();
        void Reject();
    }
    interface IDisk
    {
        string Read();
        public void Write(string text);
    }
    interface IPrintInformation
    {
        string GetName();
        void Print(string str);
    }

    class Disk : IDisk
    {
        public string memory;
        public int memSize;
        public string Memory { get; set; }
        public int MemSize { get; set; }

        public Disk()
        {
            memory = "";
            memSize = 0;
        }
        public Disk(string memory, int memSize)
        {
            Memory = memory;
            MemSize = memSize;
        }

        public string GetName()
        {
            return "";
        }

        public string Read()
        {
            return "";
        }

        public void Write(string text) { }
    }

    class HDD : Disk
    {
        public string GetName()
        {
            return "";
        }
    }

    class DVD : Disk, IRemoveableDisk
    {
        public bool hasDisk;
        public bool HasDisk { get; }

        public string GetName() { return ""; }

        public void Insert()
        {
            Console.WriteLine("Insert");
        }
        public void Reject()
        {
            Console.WriteLine("Reject");
        }

    }

    class CD : Disk, IRemoveableDisk
    {
        public bool hasDisk;
        public bool HasDisk { get; }

        public string GetName() { return ""; }

        public void Insert()
        {
            Console.WriteLine("Insert");
        }
        public void Reject()
        {
            Console.WriteLine("Reject");
        }

    }

    class Flash : Disk, IRemoveableDisk
    {
        public bool hasDisk;
        public bool HasDisk { get; }

        public string GetName() { return ""; }

        public void Insert()
        {
            Console.WriteLine("Insert");
        }
        public void Reject()
        {
            Console.WriteLine("Reject");
        }

    }

    class Comp
    {
        public int countDisk;
        public int countPrintDevice;
        public Disk[] disks;
        public IPrintInformation printDevice;

        public void AddDevice(int index, IPrintInformation si) { Console.WriteLine("AddDevice..."); }

        public void AddDisk(int index, Disk d) { Console.WriteLine("AddDisk..."); }

        public bool CheckDick(string device) { Console.WriteLine("CheckDick..."); return true; }

        public Comp(int d, int pd) { }

        public void InserReject(string device, bool b) { Console.WriteLine("Inser... Reject..."); }

        public bool PrintInfo(string text, string device) { Console.WriteLine("PrintInfo..."); return true; }

        public string ReadInfo(string device) { Console.WriteLine("ReadInfo..."); return ""; }

        public void ShowDisk() { Console.WriteLine("ShowDisk..."); }

        public void ShowPrintDevice() { Console.WriteLine("ShowPrintDevice..."); }

        public bool WriteInfo(string text, string showDevice) { Console.WriteLine("WriteInfo"); return true; }
    }

    class Printer : IPrintInformation
    {
        public string GetName() { Console.WriteLine("GetName..."); return ""; }

        public void Print(string str) { Console.WriteLine("Print..."); }
    }

    class Monitor : IPrintInformation
    {
        public string GetName() { Console.WriteLine("GetName..."); return ""; }

        public void Print(string str) { Console.WriteLine("Print..."); }
    }

    internal class Program
    {

    }
}