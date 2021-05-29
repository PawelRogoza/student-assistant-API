using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notes.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string przedmiot { get; set; }
        public string zaliczenie { get; set; }
        public string termin { get; set; }
        public string notatka { get; set; }
        public bool wazne { get; set; }
    }
}
