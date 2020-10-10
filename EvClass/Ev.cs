using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvClass
{
    class Ev
    {
        public string evtipi { get; set; }
        public int evyasi { get; set; }
        public int kat { get; set; }
        public int odasayisi { get; set; }
        public int m2 { get; set; }

        public string evtipigetir()
        {
            return evtipi;
        }
    }
}
