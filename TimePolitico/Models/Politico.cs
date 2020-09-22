using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimePolitico.Models
{
    public class Politico
    {
        public int id { get; set; }
        public string nomeCandidato { get; set; }
        public string partido { get; set; }
        public int numero { get; set; }
        public string cargo { get; set; }
        public string foto { get; set; }
    }
}
