using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluenAPI
{
    public class Course : BaseEntity
    {
        public string Description { get; set; }
        public int Level { get; set; }
        public double FullPrice { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public List<Tag> Tags { get; set; }
        public Cover Cover { get; set; }
    }
}