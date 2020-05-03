using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRIS_Application.Models
{
    public class HRIS_DBContext : DbContext
    {
        public HRIS_DBContext(DbContextOptions<HRIS_DBContext> options):base(options)
        {

        }
    }
}
