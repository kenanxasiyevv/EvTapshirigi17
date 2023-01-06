namespace EvTapshirigi17
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Axirinci menfi elementin indeksini tapmaq
            
            Console.Write("Massivin uzunlugunu daxil edin: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"arr[{i}]= ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = arr.Length - 1; i > 0; i--)
            {
                if (arr[i] < 0)
                {
                    Console.Write(i);
                    break;
                }
            }   
            }
    }
}
