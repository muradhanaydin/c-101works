using System;

namespace c__101_work{
    class Program{
        static void Main(string[] args){
            // ODEV 1
            /*
            Console.Write("Pozitif bir sayi adeti giriniz: ");
            int n = Int16.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for(int s =0; s<n;s++){
                Console.Write($"{s+1}.Sayiyi Giriniz: ");
                arr[s] = Int16.Parse(Console.ReadLine());
            }
            foreach(int i in arr){  
                if(i%2==0)
                    Console.WriteLine(i);
            }
            */

            //ODEV 2 
            /*
            string[] inp = Console.ReadLine().Split(" ");
            int n = Int16.Parse(inp[0]),m = Int16.Parse(inp[1]);
            int[] arr = new int[n];
            for(int s =0; s<n;s++){
                Console.Write($"{s+1}.Sayiyi Giriniz: ");
                arr[s] = Int16.Parse(Console.ReadLine());
            }
            foreach(int i in arr){
                if(i == m || i%m ==0){
                    Console.WriteLine(i);
                }
            }
            */
            //ODEV 3
            /*
            Console.Write("Pozitif bir sayi adeti giriniz(n m): ");
            int n = Int16.Parse(Console.ReadLine());
            string[] arr = new string[n];
            for(int s =0; s<n;s++){
                Console.Write($"{s+1}.Metini Giriniz: ");
                arr[s] = Console.ReadLine();
            }
            for(int s=0; s<n; s++){
                Console.Write($"{arr[n-s-1]}\t");
            }
            */
            //ODEV 4
            Console.Write("Bir cumle giriniz: ");
            string text = Console.ReadLine();
            int words = text.Split(" ").Length;
            int chars = string.Join("" , text.Split(" ")).Length;

            Console.WriteLine($"Metindeki kelime sayisi: {words}\nMetindeki harf sayisi: {chars}");
            

        }
    }
}