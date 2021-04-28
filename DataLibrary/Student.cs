using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLibrary
{
    public class Student
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }

    }
}
