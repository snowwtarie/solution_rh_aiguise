using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace rh.Models
{
    public class Collaborateur
    {
        public int ID { get; set; }
        public string Nom { get; set; }
        [Display(Name="Prénom")]
        public string Prenom { get; set; }
        public string Genre { get; set; }
        [Display(Name="Nationalité")]
        public string Nationalite { get; set; }
        [Display(Name="Date de naissance")]
        [DataType(DataType.Date)]
        public DateTime DateNaissance { get; set; }
        [Display(Name="Date d'embauche")]
        [DataType(DataType.Date)]
        public DateTime DateEmbauche { get; set; }
        public string Addresse { get; set; }
        public string Ville { get; set; }
        [Display(Name="Code postal")]
        public string CodePostal { get; set; }
        [Display(Name="Téléphone fixe")]
        [DataType(DataType.PhoneNumber)]
        public string NumeroFixe { get; set; }
        [Display(Name="Téléphone portable")]
        [DataType(DataType.PhoneNumber)]
        public string NumeroPortable { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Display(Name="Numéro sécurité sociale")]
        [RegularExpression("^[1-47-8]{1}[0-9]{2}(0[1-9]|1[0-2]|6[2-3])([0-9]{2}|2A|2B)[0-9]{3}[0-9]{3}[0-9]{2}$", ErrorMessage = "Numéro de sécurité sociale invalide")]
        public string NoSecu { get; set; }
        
        public ICollection<Contrat> Contrats { get; set; }

        public ICollection<Conge> Conges { get; set; }

        [Display(Name = "Service")]
        public int ServiceId { get; set; }
        public Service Service { get; set; }

        public override string ToString()
        {
            return this.Nom + " " + this.Prenom;
        }
    }
}
