using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriftNewsParser.Models
{
    public class ResultsRDS
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string ProfileUrl { get; set; }
        [Required]
        public string CarNumber { get; set; }
        [Required]
        public string Place { get; set; }
        [Required]
        public string AllPoints { get; set; }
        [AllowNull]
        public string? Q1 { get; set; }
        public string? Q2 { get; set; }
        public string? Q3 { get; set; }
        public string? Q4 { get; set; }
        public string? Q5 { get; set; }
        public string? Q6 { get; set; }
        public string? Q7 { get; set; }
        public string? R1 { get; set; }
        public string? R2 { get; set; }
        public string? R3 { get; set; }
        public string? R4 { get; set; }
        public string? R5 { get; set; }
        public string? R6 { get; set; }
        public string? R7 { get; set; }


    }
}
