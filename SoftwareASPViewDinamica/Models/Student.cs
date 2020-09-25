using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SoftwareASPViewDinamica.Models
{
    //[DataType(DataType.MultilineText)]
    //Nos permite la Multilinea
    public class Student
    {

        public int StudentId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public string Gender { get; set; }
        public string City { get; set; }

        [DataType(DataType.MultilineText)]
        public string Address { get; set; }

    }
}