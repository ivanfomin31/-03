using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PW5_1
{
    interface IAnimal
    {
        void Voice();
    }
    class Dog: IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("���!");
        }
    }
    class Cat: IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("���!");
        }
    }
    class Owl: IAnimal
    {
        private int GetCurrentTime()
        {
            return Convert.ToInt32(File.ReadAllText("current_time.txt"));
        }
        public void Voice()
        {
            int currentTime = GetCurrentTime();
            if ((currentTime >= 8) && (currentTime <= 21))
            {
                Console.WriteLine("����, � ���!");
            }
            else
            {
                Console.WriteLine("��! ��! ��!");
            }
        }
    }
    class Mouse: IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("���-���");
        }
    }
    class Horse : IAnimal
    {
        public void Voice()
        {
            bool animalIsFree = true;
            if (animalIsFree)
            {
                Console.WriteLine("��-��-��");
            }
            else
            {
                Console.WriteLine("������ � ���� �������");
            }
        }
    }
    internal class Program
    {
        static void PetAnimal(IAnimal animal)
        {
            Console.WriteLine("�� ������ ��������, � ��� ��� �������:");
            animal.Voice();
        }
        static void Main(string[] args)
        {
            List<IAnimal> myAnimals = new List<IAnimal>();
            myAnimals.Add(new Dog());
            myAnimals.Add(new Cat());
            myAnimals.Add(new Owl());
            myAnimals.Add(new Mouse());
            myAnimals.Add(new Horse());
            foreach (IAnimal animal in myAnimals)
            {
                PetAnimal(animal);
            }
            Console.ReadKey(true);
        }
    }
}
