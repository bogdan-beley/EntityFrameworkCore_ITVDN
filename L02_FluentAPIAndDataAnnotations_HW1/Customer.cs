using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace L02_FluentAPIAndDataAnnotations_HW1
{
    [Table("Clients")]
    public class Customer
    {
        [Column("client_id"), Key]
        public int Id { get; set; }

        [MaxLength(30), Required]
        public string FName { get; set; }

        [MaxLength(30), Required]
        public string LName { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}
