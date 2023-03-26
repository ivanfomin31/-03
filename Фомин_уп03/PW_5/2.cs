using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW5_2
{
    interface IHello
    {
        void SayHello();
    }
    class Russian: IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Привет");
        }
    }
    class English: IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Hello");
        }
    }
    class French: IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Salut");
        }
    }
    class Belarusian: IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Прывітанне");
        }
    }
    class Turkish : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Selam);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IHello> greetings = new List<IHello>();
            greetings.Add(new Russian());
            greetings.Add(new English());
            greetings.Add(new French());
            greetings.Add(new Belarusian());
            greetings.Add(new Turkish());
            foreach (IHello hello in greetings)
            {
                hello.SayHello();
            }
            Console.ReadKey(true);
        }
    }
}