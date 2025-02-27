﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectricStore.Models.Models;

namespace ElectricStore.Models.ViewModels
{
    public class ManageRoleVM
    {
        public ApplicationUser User { get; set; }
        public IEnumerable<SelectListItem> RoleList { get; set; }
        public IEnumerable<UserRole> UserRoleList { get; set; }
        public IdentityUserRole<string> UserRole { get; set; }

    }
}
