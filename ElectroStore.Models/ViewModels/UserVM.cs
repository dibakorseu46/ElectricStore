﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectricStore.Models.Models;
using ElectricStore.Utility;

namespace ElectricStore.Models.ViewModels
{
    public class UserVM
    {
        public IEnumerable<ApplicationUser> UserList { get; set; }
        public string Search { get; set; }
        public string Role { get; set; }
        public Pager Pager { get; set; }
    }
}
