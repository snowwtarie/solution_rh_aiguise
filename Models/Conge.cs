using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace rh.Models
{
    public class Conge
    {
        public int ID { get; set; }
        [Display(Name = "Date de début")]
        [DataType(DataType.Date)]
        public DateTime DateDebut { get; set; }
        [Display(Name = "Date de fin")]
        [DataType(DataType.Date)]
        public DateTime DateFin { get; set; }
        [Display(Name = "Période de début")]
        public char PeriodeDebut { get; set; }
        [Display(Name = "Période de fin")]
        public char PeriodeFin { get; set; }
        public string Commentaire { get; set; }
        [Display(Name = "Date de la demande")]
        [DataType(DataType.Date)]
        public DateTime DateDemande { get; set; }
        [Display(Name = "Nom du responsable")]
        public string NomResponsable { get; set; }
        [Display(Name = "Prénom du responsable")]
        public string PrenomResponsable { get; set; }
        [Display(Name = "Décision")]
        public bool Decision { get; set; }

        [Display(Name = "Type de congés")]
        public int TypeCongeId { get; set; }
        public TypeConge TypeConge { get; set; }

        [Display(Name = "Collaborateur")]
        public int CollaborateurId { get; set; }
        public Collaborateur Collaborateur { get; set; }
    }
}
