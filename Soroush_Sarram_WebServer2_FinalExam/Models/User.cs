using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Soroush_Sarram_WebServer2_FinalExam.Models
{
    public partial class User
    {
        [Key]
        public int UserId { get; set; }
        [StringLength(50)]
        public string FullName { get; set; } = null!;
        [StringLength(50)]
        public string JobTitle { get; set; } = null!;
        [StringLength(50)]
        public string Password { get; set; } = null!;
        [StringLength(50)]
        public string Email { get; set; } = null!;
    }
}
