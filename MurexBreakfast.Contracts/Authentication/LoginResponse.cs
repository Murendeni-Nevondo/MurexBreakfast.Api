﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MurexBreakfast.Contracts.Authentication
{
    public class LoginResponse
    {
        public string? Token { get; set; }
        public bool Succeded { get; set; }
    }
}
