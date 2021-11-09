﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricStore.Models.Models
{
    public class ApplicationUser:IdentityUser
    {

        [Required]
        public string Name { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        [NotMapped]
        public IEnumerable<string> RoleId { get; set; }
        [NotMapped]
        public IEnumerable<string> Role { get; set; }
        [NotMapped]
        public IEnumerable<SelectListItem> RoleList { get; set; }

    }
}
