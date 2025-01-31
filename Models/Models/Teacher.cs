﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Dershane.Domain.Models
{
    public class Teacher
    {
        // primary key
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("İsim")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email Adresi Boş bırakılmamalıdır.")]
        [EmailAddress(ErrorMessage = "Lütfen Geçerli Bir Mail Gİriniz.")]
        public string Email { get; set; }

        [Range(1, 100)]
        [DisplayName("Yaş")]
        public int Age { get; set; }

        public string? Address { get; set; }
        // nullable - null olabilir.

    }
}
