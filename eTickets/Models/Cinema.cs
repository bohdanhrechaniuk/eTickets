﻿using eTickets.Data.Base;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema :IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name= "Cinema logo")]
        [Required(ErrorMessage = "Cinema logo is required")]
        public string Logo { get;set; }
        [Display(Name = "Cinema Name")]
        [Required(ErrorMessage = "Cinema name is required")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Cinema description is required")]
        public string Description { get; set; }
        [ValidateNever]
        public List<Movie> Movies { get;set; }  
    }
}
