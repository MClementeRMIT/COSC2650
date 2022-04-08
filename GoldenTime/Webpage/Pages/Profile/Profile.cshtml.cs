﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Webpage.EFModel;
using Webpage.Shared;

namespace Webpage.Pages.Profile
{
    public class ProfileModel : PageModel
    {
        private readonly IDbContextFactory<cosc2650Context> _contextFactory;
        public string Identity;

        public List<POCO.User> Users;

        public ProfileModel(IDbContextFactory<cosc2650Context> contextFactory)
        {
            _contextFactory = contextFactory;
        }



        public void OnGet()
        {
            Identity = User.Identity.Name;
            Users = Helper.GetUsers(_contextFactory);
        }





    }
}