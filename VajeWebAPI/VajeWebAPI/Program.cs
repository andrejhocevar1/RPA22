using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace VajeWebAPI
{
    class Program
    {
        static async Task Main(string[] args)
        {
            RunAsync().Wait();

            Mentor m = new Mentor();

            m.MenId = 10021;

            m.MenIme = "Janez";

            m.MenPriimek = "Novak";

            m.MenVloga = "";

            m.MenNaziv = "";

            m.MenUstanova = "";

            using (var client = new HttpClient())

            {

                client.BaseAddress = new Uri("http://localhost:1438/");

                client.DefaultRequestHeaders.Accept.Clear();

                client.DefaultRequestHeaders.Accept.Add(new
                    MediaTypeWithQualityHeaderValue("application/json"));

                var a = await client.PostAsync<Mentor>("api/Mentor", m, new System.Net.Http.Formatting.JsonMediaTypeFormatter());

                if (a.IsSuccessStatusCode)

                    Console.WriteLine("Zapisano");

                else

                    Console.WriteLine("Ni zapisano");

            }

            Console.ReadLine();
        }

        static async Task RunAsync()
        {
            using(var client=new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:1438/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new
                MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.GetAsync("api/Mentor");
                if (response.IsSuccessStatusCode)
                {
                    List<Mentor> vsi = new List<Mentor>();

                    vsi = await response.Content.ReadAsAsync<List<Mentor>>();
                    foreach (Mentor mentor in vsi)
                    {
                        Console.WriteLine("{0}\t{1}\t{2}€", mentor.MenIme, mentor.MenPriimek, mentor.MenVloga, 
                            mentor.MenNaziv, mentor.MenUstanova, mentor.UserID);
                    }
                }
        }
        }
    }
}
