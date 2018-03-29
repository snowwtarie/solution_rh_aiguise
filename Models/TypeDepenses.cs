using System;
using System.Collections.Generic;

namespace rh.Models
{
    public class TypeDepenses
    {
        public int ID { get; set; }
        public string Label { get; set; }
        public ICollection<Depenses> Depenses { get; set; }
    }
}