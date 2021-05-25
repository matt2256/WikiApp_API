using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WikiApp_API.Models
{
    public class Image
    {
        [Key]
        public int MyProperty { get; set; }
        [Required]
        public object image { get; set; }
    }
}
