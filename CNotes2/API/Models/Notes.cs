using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Notes
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Note { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CategoryId { get; set; }
        public bool? IsDeleted { get; set; }
        public int? UserId { get; set; }

        public Category Category { get; set; }
        public Users User { get; set; }
    }
}
