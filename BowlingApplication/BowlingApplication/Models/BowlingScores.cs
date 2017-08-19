using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BowlingApplication.Models
{
    public class BowlingScores
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public int Frame { get; set; }
        public int TotalScore { get; set; }
        public int Strikes { get; set; }
        public int Spares { get; set; }
        [Required]
        public string UID { get; set; }
    }
}