using System;
using System.Linq;

namespace ScubaChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCase t1 = new TestCase("Hi", 1);
            TestCase t2 = new TestCase("Amit", 2);
            TestCase t3 = new TestCase("Assa", 3);
            TestCase t4 = new TestCase("HaGever", 4);

            TestCase[] testCases = new TestCase [4];
            testCases[0] = t1;
            testCases[1] = t2;
            testCases[2] = t3;
            testCases[3] = t4;

            Serializer<TestCase> ser = new Serializer<TestCase>();
            Deserializer<TestCase> dser = new Deserializer<TestCase>();

            Console.WriteLine(testCases.SequenceEqual(dser.Deserialize(ser.Serialize(testCases))));
        }
    }
}
