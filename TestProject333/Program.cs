using System;

namespace TestProject333
{
    class Cycler
    {
        public int[] array;
        public Cycler(int[] tempArray) 
        {
            array = tempArray;
        }
        public void Return(int number)
        {
            for (int i = 0; i < number; i++)
            {
                if (i == array.Length) { number = number - i; i = 0; }
                Console.Write(array[i].ToString() + " ");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 3, 5 };
            int number = int.Parse(Console.ReadLine());
            Cycler cycler = new Cycler(array);
            cycler.Return(number);
        }
    }

}
