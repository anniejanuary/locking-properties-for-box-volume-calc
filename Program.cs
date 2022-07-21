using System;

namespace PropertiesPart1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CREATING AN INSTANCE OF A CLASS "BOX" FROM BOX.CS
            Box box = new Box(3,4,5);

            //box.SetLength(333);
            //box.Height = 20;
            //box.width = 33;
            box.Width = 10;

            //Console.WriteLine($"New length: {box.GetLength()}");
            Console.WriteLine($"Volume is {box.Volume}");
           box.DisplayInfo();

            Console.Read();
        }
    }
}
