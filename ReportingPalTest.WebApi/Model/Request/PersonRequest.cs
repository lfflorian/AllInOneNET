using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ReportingPalTest.WebApi.Model.Request
{
    public class PersonRequest
    {
        [Required(ErrorMessage = "UniqueId is required")]
        public int? UniqueId { get; set; }
    }
}
