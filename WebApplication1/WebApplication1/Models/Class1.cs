using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Predmet
    {
        public int Id { get; set; }
        public string PredmetIme { get; set; }
    }
    public class Student
    {
        public int Id { get; set; }
        public string StudentIme { get; set; }
        public string StudentPriimek { get; set; }
    }

    public class Izpit
    {
        public DateTime Datum { get; set; }
        public int Id { get; set; }
        public int Ocena { get; set; }
        public virtual Predmet Predmet { get; set; }
        public int PredmetID { get; set; }
        public virtual Student Student { get; set; }
        public int StudentID { get; set; }
    }

}