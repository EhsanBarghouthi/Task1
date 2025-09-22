using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationsTask1.models
{
    internal class Blog
    {
        [Key]
        public int BlogId { get; set; }
        [Required]
        public string BlogTitle { get; set; }
        public string? BlogDescription { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
