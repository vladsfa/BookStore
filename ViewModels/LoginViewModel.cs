﻿using System.ComponentModel.DataAnnotations;

namespace BookStore_WebApplication.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name ="Email")]        
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name ="Пароль")]
        public string Password { get; set; }

        [Display(Name="Запам'ятати?")]
        public bool RememberMe { get; set; }

        public string ReturnUrl { get; set; }
    }
}
