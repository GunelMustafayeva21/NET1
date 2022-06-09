using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMvcProject.Models
{
    public class IconRow : BaseEntity
    {
        public string Icon { get; set; }
        public string Heading { get; set; }
        public string Text { get; set; }
        public string Link { get; set; }
    }
}
