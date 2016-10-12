using System.Collections.Generic;
using System.Threading.Tasks;
using MvvmCross.Platform;
using StringRepresenter.API.Model;
using StringRepresenter.API.Model.Book;
using StringRepresenter.API.Model.Media;
using StringRepresenter.API.Model.OfficeEquipment;
using StringRepresenter.API.Model.TicketForEvents;
using StringRepresenter.API.Services;

namespace StringRepresenter.Core.ViewModels.Main.Services
{
	public class MainVMService : IMainVMService
	{
		private IConnectionService _service
		{ 
			get { return Mvx.Resolve<IConnectionService>();}
		}

		public async Task<List<MainItemVM>> LoadData()
		{
			List<Offer> Offers = await _service.GetDataFromUrl("https://yandex.st/market-export/1.0-17/partner/help/YML.xml");
			return Convert(Offers);
		}

		private List<MainItemVM> Convert(List<Offer> listOfOffers)
		{
			List<MainItemVM> convertedViews = new List<MainItemVM>();
			foreach (var offer in listOfOffers)
			{
				if (offer is Book)
				{
					convertedViews.Add(new MainItemVM { Id = offer.Id, Title = (offer as Book).Name, ImageUrl = offer.Picture });
				}
				else if (offer is Media)
				{
					convertedViews.Add(new MainItemVM { Id = offer.Id, Title = (offer as Media).Title, ImageUrl = offer.Picture });
				}
				else if (offer is OfficeEquipment)
				{
					convertedViews.Add(new MainItemVM { Id = offer.Id, Title = (offer as OfficeEquipment).Model, ImageUrl = offer.Picture });
				}
				else if (offer is TicketForEvents)
				{
					convertedViews.Add(new MainItemVM { Id = offer.Id, Title = (offer as TicketForEvents).Name, ImageUrl = offer.Picture });
				}
				else
				{
					convertedViews.Add(new MainItemVM { Id = offer.Id, Title = offer.Description, ImageUrl = offer.Picture });
				}
			}

			return convertedViews;
		}
	}
}
