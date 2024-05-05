using IMS.Infrastructures.Entity_Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Infrastructures
{
    public class IMSDbcontext:DbContext
    {
        public IMSDbcontext(DbContextOptions<IMSDbcontext> Options) 
         : base(Options) 
        { 
        
        
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new StoreConfiguration());
           
        }
    }
}
