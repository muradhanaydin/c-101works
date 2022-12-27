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
            /*Odev 5
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
            */

            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());
           
            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(2));
            Console.WriteLine(DateTime.Now.AddSeconds(15));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(6));
            Console.WriteLine(DateTime.Now.AddMicroseconds(12));

            //DateTime Format 
            Console.WriteLine(DateTime.Now.ToString("dd")); //24
            Console.WriteLine(DateTime.Now.ToString("ddd")); //Sat
            Console.WriteLine(DateTime.Now.ToString("dddd")); //Saturday

            Console.WriteLine(DateTime.Now.ToString("MM")); //04
            Console.WriteLine(DateTime.Now.ToString("MMM")); //Apr
            Console.WriteLine(DateTime.Now.ToString("MMMM")); //April

            Console.WriteLine(DateTime.Now.ToString("yy")); //22
            Console.WriteLine(DateTime.Now.ToString("yyyy")); //2022

            Console.WriteLine("--------------MATH LIBS-------------");
            Console.WriteLine(Math.Abs(-52)); // Verilen degerin mutlak degerini dondurur
            Console.WriteLine(Math.Sin(10)); // Verilen degerin sinus degerini dondurur
            Console.WriteLine(Math.Cos(10)); // Verilen degerin cosinus degerini dondurur
            Console.WriteLine(Math.Tan(10)); // Verilen degerin tanjant degerini dondurur
            
            Console.WriteLine(Math.Ceiling(22.4)); // Verilen degeri en yakin bir ust tamsayiya yuvarlar
            Console.WriteLine(Math.Round(22.2)); // Verilen degeri en yakin tarafa yuvarlar
            Console.WriteLine(Math.Floor(22.7)); // Verilen degeri bir alt tamsayiya yuvarlar

            Console.WriteLine(Math.Max(0,1)); // Verilen 2 degerden buyugunu geri dondurur
            Console.WriteLine(Math.Min(0,2)); // Verilen 2 degerden kucugunu geri dondurur

            Console.WriteLine(Math.Pow(2,5)); // Verilen iki degerin ussunu alir (2,5) => 2^5
            Console.WriteLine(Math.Sqrt(9)); // Verilen sayinin karekokunu alir
            Console.WriteLine(Math.Log(9)); // Verilen sayiyi logaritma e tabanindaki degeri dondurur
            Console.WriteLine(Math.Exp(3)); // Verilen sayiyi e^3 u verir
            Console.WriteLine(Math.Log10(2)); // Verilen sayiyi logaritma 10 tabanindaki degeri dondurur
        }
    }
}