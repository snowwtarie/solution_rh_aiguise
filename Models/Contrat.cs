using System;

namespace rh.Models
{
    public class Contrat
    {
        public int ID { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public TypeContrat TypeContrat { get; set; }
        public Collaborateur collaborateur { get; set; }
    }
}