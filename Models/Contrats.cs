using System;

namespace rh.Models
{
    public class Contrats
    {
        public int ID { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public TypeContrats TypeContrat { get; set; }
        public Collaborateur collaborateur { get; set; }
    }
}