using Models;

namespace DataAccessLayer.DataHandlers
{
	public interface IDataHandler
	{
		Task AddStoreLocation(LocationModel model);
		Task<List<LocationModel>> GetStorelocations();
	}
}