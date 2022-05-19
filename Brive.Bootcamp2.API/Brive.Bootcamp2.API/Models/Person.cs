using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Brive.Bootcamp2.API.Models
{
      [Table("Person")]  
    public class Person
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("Name")]
        public string Name { get; set; }
        [Column("Age")]
        public int Age { get; set; }
        [Column("Email")]
        public string Email { get; set; }
        [Column("CreatedDate")]
        public DateTime CreatedDate { get; set; }

    }
}
