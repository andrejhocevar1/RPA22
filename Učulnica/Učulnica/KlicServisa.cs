using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Net.Http;
using Windows.Data.Html;
using Windows.Storage;
using System.IO;

//1.Model->Copy Paste special, paste json as class
//2.Klic servisa (Uklopi client/NuGet, metoda)

namespace Učulnica
{
    class KlicServisa
    {
        public static async Task PopulatePoglavjaAsync(ObservableCollection<Poglavja> poglavja)
        {
            //iz spletnega servisa pobere podatke o učilnici in odda poglavja v zbirko poglavja

            string url = "https://ucilnice.scng.si/webservice/rest/server.php?wstoken=cdab3d1b4fa5daac1af768a4e5030dc4&wsfunction=core_course_get_contents&courseid=110&moodlewsrestformat=json";
            List<Poglavja> vsa = new List<Poglavja>();

            //klic

            using(var klient = new HttpClient())
            {
                HttpResponseMessage sp = await klient.GetAsync(url);
                vsa = await sp.Content.ReadAsAsync<List<Poglavja>>();
            }
            foreach(var p in vsa)
            {
                p.summary = HtmlUtilities.ConvertToText(p.summary);
                poglavja.Add(p);
            }
        }
        public static async Task<StorageFile> PoberiDatoteko(string imeDat, int dolžina, string ime)
        {
            string url = imeDat + "?token=cdab3d1b4fa5daac1af768a4e5030dc4&function=core_files_get_files";
            HttpClient http = new HttpClient();
            var response = await http.GetAsync(url);
            var x = await response.Content.ReadAsStreamAsync();
            var mapa = Windows.Storage.ApplicationData.Current.LocalFolder;
            StorageFile obstaja = null;

            try
            {
                obstaja = await mapa.GetFileAsync(ime);
            }

            catch { }

            StorageFile dat = null;

            if (obstaja != null)
            {
                dat = obstaja;
                return dat;
            }

            dat = await mapa.CreateFileAsync(ime);

            using (FileStream fileStream = new FileStream(dat.Path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
            {
                await x.CopyToAsync(fileStream);
            }

            return dat;
        }
    }
}
