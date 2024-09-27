using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace DataAccessLayer.DataHandlers
{
	public class DataHandler : IDataHandler
	{
		private readonly DBAccess _dbAccess;

		public DataHandler(DBAccess dbAccess)
		{
			_dbAccess = dbAccess;
		}

		public async Task AddStoreLocation(LocationModel model)
		{
			await _dbAccess.locations.AddAsync(model);
			await _dbAccess.SaveChangesAsync();
		}

		public async Task<List<LocationModel>> GetStorelocations()
		{
			var data = await _dbAccess.locations.AsNoTracking().ToListAsync();
			return data;
		}

	}
}
