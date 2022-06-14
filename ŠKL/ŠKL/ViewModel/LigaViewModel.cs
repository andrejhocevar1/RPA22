using ŠKL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ŠKL.ViewModel
{
    class LigaViewModel
    {
        public EkipaViewModel EkipaJimmy { get; set; }
        public EkipaViewModel EkipaJanez { get; set; }
        public LigaViewModel()
        {
            Ekipa j = new Ekipa("Bomberji", DobiBomberje());
            EkipaJanez = new EkipaViewModel(j);
            Ekipa m = new Ekipa("Fantastic", DobiFantastice());
            EkipaJimmy = new EkipaViewModel(m);
        }

        private IEnumerable<Igralec> DobiFantastice()
        {
            List<Igralec> i = new List<Igralec>()
            {
                new Igralec("Jimmy",true,42),
                new Igralec("Henry",true,66),
                new Igralec("Bof",true,19),
                new Igralec("Štefan",true,13),
                new Igralec("Kim",true,1),
                new Igralec("Ed",false,32),
                new Igralec("Berta",false,2)
            };
            return i;
        }

        private IEnumerable<Igralec> DobiBomberje()
        {
            List<Igralec> i = new List<Igralec>()
            {
                new Igralec("Tomi",true,42),
                new Igralec("Mirjan",true,66),
                new Igralec("Katarina",true,59),
                new Igralec("Lucjan",true,17),
                new Igralec("Joe",true,11),
                new Igralec("Mike",false,2),
                new Igralec("Noah",false,62)
            };
            return i;
        }
    }
}
