﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLibrary.DTOs
{
    public class AccountBase
    {
        [DataType(DataType.EmailAddress)]
        [EmailAddress] //Data Anotation to Validate Email Address
        [Required]
        public string? EmailAddress { get; set; }

        [DataType(DataType.Password)]
        [Required]
        public string? Password { get; set; }


    }
}
