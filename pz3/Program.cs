using System;

namespace delete
{
    public class Computer
    {
        public int Id;
        public int totalHDDMemory;
        public float processorFrequency;

        public Computer(int a, int b, float c)
        {
            Id = a;
            totalHDDMemory = b;
            processorFrequency = c;
        }

        public Computer(int b, float c)
        {
            totalHDDMemory = b;
            processorFrequency = c;
        }

        public Computer(int b)
        {
            totalHDDMemory = b;
        }

        public void GetCompName()
        {
            Console.WriteLine($"ID: {Id} " +
                $"HDD Memory: {totalHDDMemory} " +
                $"Frequency of Processor: {processorFrequency}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer(1,2,3);
            Computer computer1 = new Computer(2, 3, 4.9f);
            Computer computer2 = new Computer(3, 4, 5.1f);
            Computer computer3 = new Computer(4, 5, 1.1f);

            computer.GetCompName();
            computer1.GetCompName();
            computer2.GetCompName();
            computer3.GetCompName();

            Console.WriteLine( Convert.ToString(31, 16));
        }
    }
}
