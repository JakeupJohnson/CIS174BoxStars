﻿using System;
using System.ComponentModel.DataAnnotations;

namespace BoxStars.Domain.Entities
{
    public class Person
    {
        public Guid PersonId { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(6)]
        public string Gender { get; set; }
        public DateTime? DateCreated { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
        [StringLength(16)]
        public string PhoneNumber { get; set; }
    }
}
