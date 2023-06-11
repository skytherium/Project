using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WorldVision.Web.Models;

namespace WebApplication2.Models
{
    public class Application2DbContext :DbContext
    {
    public DbSet <DataRequest> Requests { get; set; }
    public DbSet <UserLogin> Logins { get; set; }   
    public DbSet <UserRegister> Registers { get; set; } 
    public DbSet <zapovednik> Zapovedniks { get; set; }
    }
}