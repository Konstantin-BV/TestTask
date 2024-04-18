using System;

namespace TestTask
{
    internal class Box
    {
        public int id;
        public int width;
        public int height;
        public int depth;
        public int weight;
        public DateTime productionDate;

        public int getWeighth() { return weight; }

        public DateTime getExpirationDate()
        {
            return productionDate.AddDays(100);
        }

        public int volume() { return width * height * depth; }

        public void Writ()
        {
            Console.Write($"Id: {id}, ");
            Console.Write($"Width: {width}, ");
            Console.Write($"Height: {height}, ");
            Console.Write($"Depth: {depth}, ");
            Console.Write($"Weight: {weight}, ");
            Console.Write($"Production date: {productionDate}, ");
            Console.WriteLine($"Expiration date: {getExpirationDate()}");
        }
    }
}
