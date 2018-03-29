using System;
using System.Collections.Generic;

namespace rh.Models
{
    public class TypeContrats
    {
        public int ID { get; set; }
        public string Label { get; set; }
        public ICollection<Contrats> Contrats { get; set; }
    }
}