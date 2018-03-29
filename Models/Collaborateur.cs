using System;

namespace rh.Models
{
    public class Collaborateur
    {
        public int ID { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Genre { get; set; }
        public string Nationalite { get; set; }
        public DateTime DateNaissance { get; set; }
        public DateTime DateEmbauche { get; set; }
        public string Addresse { get; set; }
        public string Ville { get; set; }
        public string CodePostal { get; set; }
        public string NumeroFixe { get; set; }
        public string NumeroPortable { get; set; }
        public string Email { get; set; }
        public string NoSecu { get; set; }
        public Services Service { get; set; }
    }
}