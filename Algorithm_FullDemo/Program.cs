using System;

namespace Algorithm_FullDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var parser = new ParsingInput.InputParser();
            var slotProvider = parser.Parse(args);
        }
    }
}
