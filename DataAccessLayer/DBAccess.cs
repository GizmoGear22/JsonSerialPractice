using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace DataAccessLayer
{
	public class DBAccess: DbContext
	{
		public DBAccess(DbContextOptions options) : base(options) {}

		public DbSet<LocationModel> locations { get; set; }
	}
}
