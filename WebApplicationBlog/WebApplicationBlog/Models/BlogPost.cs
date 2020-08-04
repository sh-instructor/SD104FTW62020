using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationBlog.Models
{
    public class BlogPost
    {

        [Key]
        public int Id { get; set; }
        
        public string blogTitle { get; set; }

        public string content { get; set; }

        public DateTime blogDate{ get; set; }




    }
}
