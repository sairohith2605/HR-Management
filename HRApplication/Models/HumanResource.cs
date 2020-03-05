using System;
using System.ComponentModel.DataAnnotations;

namespace HRApplication.Models
{
    public class HumanResource
    {
        [Required]
        public string ResourceName { get; set; }
        [Required]
        public int Age { get; set; }
        public long ResourceId { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        public string Position { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime JoiningDate { get; set; }
        public string HighestQualifications { get; set; }
        [Required]
        public char Gender { get; set; }
    }
}
