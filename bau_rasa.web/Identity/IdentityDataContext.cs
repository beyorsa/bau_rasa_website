using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using bau_rasa.web.Entity;

namespace bau_rasa.web.Identity
{
    public class IdentityDataContext : IdentityDbContext<ApplicationUser>
    {
        public IdentityDataContext() : base("dataConnection")
        {

        }
    }
}