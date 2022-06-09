using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMvcProject.Models
{
    public class Testimonials: BaseEntity
    {
        public string Text { get; set; }
        public string Name { get; set; }
    }
}
