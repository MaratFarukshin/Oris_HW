﻿namespace SocialNetwork309.Models.Auth
{
    public class RegisterViewModel
    {
        public required string FirstName { get; set; }

        public required string LastName { get; set; }

        public required string Email { get; set; }

        public required string Password { get; set; }

        public required string ConfirmPassword { get; set; }
    }
}
