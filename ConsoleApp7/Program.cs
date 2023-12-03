namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //https://metanit.com/sharp/tutorial/23.2.php
            int[] nums2 = [];   // пустой массив
            Console.WriteLine("Пустой массив !");
            foreach (int i in nums2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Конец чтения пустого массива!");


            Console.WriteLine("Чтения листа !");

            List<int> list1 = [1, 2, 3, 4];
            foreach (int i in list1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Конец чтения листа  !");



            List<int> list2 = []; //  пустой список
            Console.WriteLine("Чтения пустого листа !");
            foreach (int i in list2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Конец чтения пустого листа  !");


            // https://metanit.com/sharp/tutorial/2.33.php
            Span<int> span1 = [1, 2, 3, 4];
            Console.WriteLine("Чтения пустого Span который экономит памят !");

            foreach (int i in span1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Конец чтения  Span который экономит память  !");

            Console.ReadLine();
        }
    }
}
