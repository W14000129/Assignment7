using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Category
    {
        public Category()
        {
            Notes = new HashSet<Notes>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Notes> Notes { get; set; }
    }
}
