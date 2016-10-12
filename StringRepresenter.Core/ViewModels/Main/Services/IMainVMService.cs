using System.Collections.Generic;
using System.Threading.Tasks;

namespace StringRepresenter.Core.ViewModels.Main.Services
{
	public interface IMainVMService
	{
		Task<List<MainItemVM>> LoadData();
	}
}
