using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMvc5.Models
{
    public class Administrator_Module_Mapping
    {
        public Guid ID { get; set; }
        public Guid Administrator_Id { get; set; }
        public string Module { get; set; }
    }
}