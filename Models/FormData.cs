using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcForms.Models
{
    public class FormData
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        [Required]
        public int ActivityId { get; set; }
        [Required]
        public int Duration { get; set; }
        public enum IntensityLevel
        {
            Low,
            Medium,
            High
        }
        public IntensityLevel Intensity { get; set; }
        public bool Exclude { get; set; }
    }
}