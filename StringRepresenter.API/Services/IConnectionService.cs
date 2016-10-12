using System.Collections.Generic;
using System.Threading.Tasks;
using StringRepresenter.API.Model;

namespace StringRepresenter.API.Services
{
	public interface IConnectionService
	{
		Task<List<Offer>> GetDataFromUrl(string url);
	}
}
