using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Neo4jCsharp.Infrastructure.CrossCutting.Identity.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
    }
}
