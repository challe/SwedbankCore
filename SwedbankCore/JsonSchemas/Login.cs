﻿using System;
using System.Collections.Generic;

namespace SwedbankCore.JsonSchemas
{
    public class Login
    {
        public bool UseEasyLogin {get; set;}
        public bool GenerateEasyLoginId { get; set; }
        public long UserId { get; set; }
    }
}
