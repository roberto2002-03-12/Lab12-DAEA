﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstDemo.Models
{
    public class Seller
    {
        public int SellerId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}