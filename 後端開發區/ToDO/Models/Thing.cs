using System;
using System.Collections.Generic;

#nullable disable

namespace ToDO.Models
{
    public partial class Thing
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Status { get; set; }
    }
}
