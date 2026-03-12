using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace TempManager.Models
{
    public class Temp
    {
        public int TempId { get; set; }

        [Required]
        [Remote(action: "CheckDate", controller: "Validation")]
        public DateTime? Date { get; set; }

        [Required]
        [Range(-200, 200)]
        public double? Low { get; set; }

        [Required]
        [Range(-200, 200)]
        public double? High { get; set; }
    }
}
