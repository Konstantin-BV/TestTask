using System;
using System.Collections.Generic;

namespace TestTask
{
    internal class Pallets
    {
        public int id;
        public int width;
        public int height;
        public int depth;
        public int weight;
        public List<Box> Boxs;

        private DateTime CalculatingExpirationDate()
        {
            DateTime minDate = DateTime.MaxValue;
            for (int i = 0; i < Boxs.Count; i++)
            {
                if (minDate > Boxs[i].getExpirationDate())
                {
                    minDate = Boxs[i].getExpirationDate();
                }
            }
            return minDate;
        }

        public DateTime getExpirationDate()
        {
            return CalculatingExpirationDate();
        }

        public int getWeight()
        {
            CalculatingWeight();
            return weight;
        }

        private void CalculatingWeight()
        {
            int AllWeight = 30;
            for (int i = 0; i < Boxs.Count; i++)
            {
                AllWeight += Boxs[i].getWeighth();
            }
            weight = AllWeight;
        }

        public int CalculatingVolume()
        {
            int AllVolume = width * height * depth; ;
            for (int i = 0; i < Boxs.Count; i++)
            {
                AllVolume += Boxs[i].volume();
            }
            return AllVolume;
        }

        public void Writ()
        {
            Console.WriteLine(" ");
            Console.WriteLine($"Id: {id}");
            Console.WriteLine($"Width: {width}");
            Console.WriteLine($"Height: {height}");
            Console.WriteLine($"Depth: {depth}");
            Console.WriteLine($"Weight: {getWeight()}");
            Console.WriteLine($"Volume: {CalculatingVolume()}");
            Console.WriteLine($"Expiration date: {getExpirationDate()}");
            Console.WriteLine("Boxs: ");
            for (int i = 0; i < Boxs.Count; i++)
            {
                Boxs[i].Writ();
            }
            Console.WriteLine(" ");
        }
    }
}
