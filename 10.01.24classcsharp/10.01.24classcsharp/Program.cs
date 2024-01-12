using _1001taskscsharp;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace MySpace
{
    class Program
    {
        //public static void Main(string[] args)
        //{
        //    int[] nums = {1,2,3,4,5,6,7,8,9,10};
        //    Array.ForEach(nums, i =>
        //    {
        //        if (i % 2 == 0)
        //        {
        //            Console.WriteLine(i);
        //        }
        //    });
        //}
        //public static void Main(string[] args)
        //{
        //    int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //    int mid = 0;
        //    Console.WriteLine(nums.Average());
        //}
        //public static void Main(string[] args)
        //{
        //    List<String> list = new List<String>();
        //    list.Add("ab");
        //    list.Add("acc");
        //    list.Add("accc");
        //    list.Add("avccccx");

        //    Console.WriteLine(list.OrderDescending().First());
        //}
        public static void Main(string[] args)
        {
            List<Person> list = new List<Person>();

            list.Add(new Person("Roman", 21));
            list.Add(new Person("Anton", 31));
            list.Add(new Person("Nazar", 8));
            list.Add(new Person("Taras", 77));

            list.ForEach(x =>
            {
                if (x.age >= 30)
                {
                    Console.WriteLine(x.name);
                }
            });

        }

    }
}
