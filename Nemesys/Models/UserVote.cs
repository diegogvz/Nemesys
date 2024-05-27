using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nemesys.Models
{
    public class UserVote
    {
        [Key]
        public int UserVoteID { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public int ReportID { get; set; }

        [ForeignKey("ReportID")]
        public Report Report { get; set; }
    }
}

