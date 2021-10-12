using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class School
    {
        public int ID { get; set; }
        public string SchoolName { get; set; }
        public string Location { get; set; }
        public bool MHA { get; set; }
        public bool MSHCM { get; set; }
        public int Tuition { get; set; }
    }
}