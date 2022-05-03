using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Klicapija
{
    class Program
    {
        static void Main(string[] args)
        {
            RunAsync().Wait();
            Console.ReadLine();
        }
        static async Task RunAsync()
        {
            HttpClient klient = new HttpClient();
            klient.BaseAddress = new Uri("http://localhost:1994/");
            klient.DefaultRequestHeaders.Accept.Clear();
            klient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage odg = await klient.GetAsync("api/Products/1");
            if (odg.IsSuccessStatusCode)
            {
                Produkt p = await odg.Content.ReadAsAsync<Produkt>();
                Console.WriteLine("Moj produkt " + p.Ime + " " + p.Kategorija + " " + p.Cena);
            }
        }
    }
}
