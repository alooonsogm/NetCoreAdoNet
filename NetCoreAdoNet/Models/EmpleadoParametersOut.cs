using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreAdoNet.Models
{
    public class EmpleadoParametersOut
    {
        public List<string> apellidos { get; set; }
        public int sumaSalarial { get; set; }
        public int mediaSalarial { get; set; }
        public int personas { get; set; }

        public EmpleadoParametersOut()
        {
            this.apellidos = new List<string>();
        }
    }
}
