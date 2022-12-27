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
            
            //ODEV 4
            Console.Write("Bir cumle giriniz: ");
            string text = Console.ReadLine();
            int words = text.Split(" ").Length;
            int chars = string.Join("" , text.Split(" ")).Length;

            Console.WriteLine($"Metindeki kelime sayisi: {words}\nMetindeki harf sayisi: {chars}");
            
            */

            string t1 = "Bugun hava cok guzel degilmi?";
            string t2 = "guzel degilmi";

            //Length
            Console.WriteLine(t1.Length);

            //Toupper Tolower
            Console.WriteLine(t1.ToLower());
            Console.WriteLine(t2.ToUpper());

            //Concat
            Console.WriteLine(string.Concat(t1 , "Ahmet"));

            //Compareto compare
            Console.WriteLine(t1.CompareTo(t2));
            Console.WriteLine(string.Compare(t1,t2,true));
            Console.WriteLine(string.Compare(t1,t2,false));

            //Contains
            Console.WriteLine(t1.Contains(t2));
            Console.WriteLine(t1.EndsWith("degilmi"));
            Console.WriteLine(t1.StartsWith("Bugun"));

            //IndexOf
            Console.WriteLine(t1.IndexOf("cok"));
            Console.WriteLine(t2.IndexOf("e"));
            Console.WriteLine(t1.LastIndexOf("?"));

            //Insert
            Console.WriteLine(t1.Insert(0 , t1+" "));

            //PadLeft PadRight
            Console.WriteLine(t1 + t2.PadLeft(30));
            Console.WriteLine(t1 + t2.PadLeft(30,'*'));
            Console.WriteLine(t1.PadRight(30) + t2);
            Console.WriteLine(t1.PadRight(30,'_') + t2);

            //Remove
            Console.WriteLine(t1.Remove(t1.Length -5));
            Console.WriteLine(t1.Remove(5,10));

            //Replace
            Console.WriteLine(t1.Replace("Bugun","BUGUN"));
            Console.WriteLine(t1.Replace(' ' , '*'));

            //Split
            Console.WriteLine(t1.Split(" ")[0]);

        }
    }
}