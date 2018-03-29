using System;
using System.Collections.Generic;

namespace rh.Models
{
    public class TypeConges
    {
        public int ID { get; set; }
        public string Label { get; set; }
        public ICollection<Conges> Conges { get; set; }
    }
}