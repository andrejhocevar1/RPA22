using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AsinhroniTaski
{
    class Coffee { }
    class Egg { }
    class Bacon { }
    class Toast { }
    class Juice { }
    class Program
    {
        static async void Main(string[] arg)
        {
            //1. sinhrono
            //Coffee cup = PourCoffee();
            //Console.WriteLine("Kava je pripravljena");
            //Egg eggs = FryEggs(2);
            //Console.WriteLine("Jajca so cvrta");
            //Bacon bacon = FryBacon(3);
            //Console.WriteLine("Slanina je crvta");
            //Toast toast = ToastBread(2);
            //ApplyButter(toast);
            //ApplyJam(toast);
            //Console.WriteLine("Toast je pečen");
            //Juice oj = PourOJ();
            //Console.WriteLine("Sok je pripravljen");
            //Console.WriteLine("Zajtrk je pripravljen!");
            //Console.ReadLine();
            //2. asinhrono
            Coffee cup = PourCoffee();
            Console.WriteLine("Kava je pripravljena");
            //Egg eggs = await FryEggs(2);
            Task<Egg> eggs = FryEggs(2);
            //Bacon bacon = await FryBacon(3);
            Task<Bacon> bacon = FryBacon(3);
            Toast toast = await ToastBread(2);
            //Task<Toast> tast = ToastBread(2);
            ApplyButter(toast);
            ApplyJam(toast);
            Console.WriteLine("Toast je pečen");
            Juice oj = PourOJ();
            Console.WriteLine("Sok je pripravljen");
            Egg egg = await eggs;
            Console.WriteLine("Jajca so cvrta");
            Bacon bacons = await bacon;
            Console.WriteLine("Slanina je crvta");
            Console.WriteLine("Zajtrk je pripravljen!");
            Console.ReadLine();
        }
        private static Juice PourOJ()
        {
            Console.WriteLine("Stiskanje soka iz pomaranč");
            return new Juice();
        }
        private static void ApplyJam(Toast toast) => Console.WriteLine("Dodajanje marmelade na toast");
        private static void ApplyButter(Toast toast) => Console.WriteLine("Dodajanje masla na toast");
        private async static Task<Toast> ToastBread(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
                Console.WriteLine("Dodajam košček toasta v toaster");
            Console.WriteLine("Začenjam peči...");
            await Task.Delay(3000);
            Console.WriteLine("Ostrani toast iz toasterja");
            return new Toast();
        }
        private async static Task<Bacon> FryBacon(int slices)
        {
            Console.WriteLine($"Dodajanje {slices} kosov slanine v ponev");
            Console.WriteLine("Pečenje ene strani slanine...");
            await Task.Delay(3000);
            for (int slice = 0; slice < slices; slice++)
                Console.WriteLine("Obračanje slanine");
            Console.WriteLine("Pečenje druge strani slanine...");
            await Task.Delay(3000);
            Console.WriteLine("Daj slanino na krožnik");
            return new Bacon();
        }
        private async static Task<Egg> FryEggs(int howMany)
        {
            Console.WriteLine("Segrevanje ponve...");
            await Task.Delay(3000);
            Console.WriteLine($"Razbijanje {howMany} jajc");
            Console.WriteLine("Cvretje jajc ...");
            await Task.Delay(3000);
            Console.WriteLine("Daj jajca na krožnik");
            return new Egg();
        }
        private static Coffee PourCoffee()
        {
            Console.WriteLine("Kuhanje kave");
            return new Coffee();
        }    
    }
}