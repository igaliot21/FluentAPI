using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluenAPI
{
    public class Author : BaseEntity
    {
        public List<Course> Courses { get; set; }
    }
}