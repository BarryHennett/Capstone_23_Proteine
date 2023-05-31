﻿using Microsoft.AspNetCore.Identity;

namespace Capstone_23_Proteine.Models
{
    public class SetGoalsViewModel
    {
        public Guid Id { get; set; }
        public string SetCalories { get; set; }
        public string SetProtein { get; set; }
        public string SetFat { get; set; }

        // Navigation property to the associated IdentityUser
        public IdentityUser User { get; set; }
    }
}
