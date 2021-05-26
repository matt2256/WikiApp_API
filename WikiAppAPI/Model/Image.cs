using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WikiAppAPI.Model
{
    public class Image
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public object Blob { get; set; }
    }
}
