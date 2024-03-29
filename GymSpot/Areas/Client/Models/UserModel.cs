﻿using System.ComponentModel.DataAnnotations;

namespace GymSpot.Areas.Client.Models
{
    public class UserModel
    {
        [Key]
        public int UserId { get; set; }
        public string? Name { get; set; }
        public DateTime DateofBirth { get; set; }
        public string? EmailAddress { get; set; }
        public string? AccountPassword { get; set; }
        public string? Address { get; set; }
        public Gender Gender { get; set; }

    }

    public enum Gender
    {
        Male, Female, Other

    }


}
