﻿using Microsoft.AspNetCore.Identity;

namespace FluentPOS.Modules.Identity.Core.Entities
{
    public class ExtendedIdentityRole : IdentityRole<int>
    {
        public ExtendedIdentityRole()
        {
        }

        public ExtendedIdentityRole(string roleName)
        {
            Name = roleName;
            NormalizedName = roleName.ToUpper();
        }
    }
}