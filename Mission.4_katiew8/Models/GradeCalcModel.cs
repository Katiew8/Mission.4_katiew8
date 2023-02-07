using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission._4_katiew8.Models
{
    public class GradeCalcModel
    {
        [Required]
        [Range(0, 100, ErrorMessage = "Assignments score must be between 0 and 100")]
        public int assign { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Group score must be between 0 and 100")]
        public int group { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Quiz score must be between 0 and 100")]
        public int quiz { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Midterm score must be between 0 and 100")]
        public int mid { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Final score must be between 0 and 100")]
        public int final { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Intex score must be between 0 and 100")]
        public int intex { get; set; }


    }
}
