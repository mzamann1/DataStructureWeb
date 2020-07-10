using System;

namespace DataStructureWeb
{
    class Program
    {
        static void Main(string[] args)
        {
            DynaArray<int> obj = new DynaArray<int>();
            obj.Add(1);
            obj.Add(2);
            obj.Add(3);
            obj.Add(4);
            obj.Add(5);
            obj.Add(6);
            obj.Add(7);
            obj.Add(8);

            

            Console.WriteLine(obj.ToString());
            Console.WriteLine("Size : "+obj.size);
            Console.WriteLine(obj.indexOf(7));
            Console.ReadLine();

        }
    }
}
