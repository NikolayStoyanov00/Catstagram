﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Catstagram.Models.Identity
{
    public class LoginRequestModel
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}

