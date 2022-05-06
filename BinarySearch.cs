using System;

namespace twofind
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] array = new int[] { 15, 27, 56, 79, 101, 235, 458, 642, 897, 943 };
            Console.WriteLine($"array：15,27,56,79,101,235,458,642,897,943 ");
            int max = array.Length - 1;
            int min = 0;
            int current = 0;
            Console.WriteLine($"Please enter the number you want to find：");

            int input = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < array.Length; i++)

            {
                if (input == array[current])
                {
                    Console.WriteLine($"get it，search {i} times，the number in {current + 1}");
                    break;

                }
                else
                {
                   

                    if (input > array[current])
                    {
                        min = current;
                        int steps = (max - min) / 2;

                  
                        current = current + steps;
                    }
                    else
                    {
                        max = current;
                        int steps = (max - min) / 2;
                    
                        current = current - steps;
                    }
                  
                }


            }

            Console.Read();



        }
    }
}
