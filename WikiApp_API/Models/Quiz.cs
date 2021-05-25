using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WikiApp_API.Models
{
    public class Quiz
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public object quiz { get; set; }


        //Foreign key relations
        [ForeignKey("Article")]
        public ICollection<Article> Articles { get; set; }

    }
}
