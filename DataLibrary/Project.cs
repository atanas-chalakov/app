using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class Project
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public List<Task> Tasks { get; set; }
    }
}
