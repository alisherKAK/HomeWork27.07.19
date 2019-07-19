using System;

namespace HomeWork21_07_19
{
    public abstract class Creator
    {
        public abstract IPrinter GetPrinter();

        public string PrintPaper()
        {
            IPrinter printer = GetPrinter();
            string result = printer.Print();
            return result;
        }
    }

    public class CanonCreator : Creator
    {
        public override IPrinter GetPrinter()
        {
            return new Canon();
        }
    }

    public class HPCreator : Creator
    {
        public override IPrinter GetPrinter()
        {
            return new HP();
        }
    }

    public interface IPrinter
    {
        string Print();
    }

    public class Canon : IPrinter
    {
        public string Print()
        {
            Console.WriteLine("Sheet of paper was printed by");
            return "Canon";
        }
    }

    public class HP : IPrinter
    {
        public string Print()
        {
            Console.WriteLine("Sheet of paper was printed by");
            return "HP";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ExecuteCode(new CanonCreator());
            Console.WriteLine("============");
            ExecuteCode(new HPCreator());
            Console.ReadLine();
        }

        static void ExecuteCode(Creator creator)
        {
            Console.WriteLine(creator.PrintPaper());
        }
    }
}
