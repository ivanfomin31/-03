using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PW6_1
{
    class Phone
    {
        public Phone (string model, string number)
        {
            Model = model;
            Number = number;
        }
        public string Model
        {
            get;
            set;
        }
        public string Number
        {
            get;
            set;
        }
        public void Call(string number)
        {
            Console.WriteLine($"����� �� ������ {number}");
            WriteToLog($"����� {number}");
        }
        protected void WriteToLog(string text)
        {
            File.AppendAllText("log.txt", $"{Model}, {DateTime.Now}: {text}\n");
        }
    }
    class Smartphone : Phone
    {
        public Smartphone (string model, string number, double cameraResolution) : base (model, number)
        {
            CameraResolution = cameraResolution;
        }
        public double CameraResolution
        {
            get;
            set;
        }
        public void Shoot()
        {
            Console.WriteLine("������ ������");
            WriteToLog($"������ ������");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone myHomePhone = new Phone("iPhone 13", "89806547896");
            myHomePhone.Call("85672537414");
            Smartphone myWorkPhone = new Smartphone("Samsung Galaxy S22", "89195584789", 80.5);
            myWorkPhone.Call("112");
            myWorkPhone.Shoot();
            Console.ReadKey(true);
        }
    }
}
