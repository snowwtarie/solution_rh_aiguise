using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace rh.Models
{
    public class CongeCollaborateurViewModel : Conge
    {
        [Display(Name = "Collaborateurs")]
        public List<SelectListItem> Collaborateurs { get; set; }
        [Display(Name = "Type de  congés")]
        public List<SelectListItem> TypeConges { get; set; }
    }
}