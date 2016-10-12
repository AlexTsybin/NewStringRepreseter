using System.Collections.ObjectModel;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using StringRepresenter.Core.ViewModels.Detail;
using StringRepresenter.Core.ViewModels.Main.Services;

namespace StringRepresenter.Core.ViewModels.Main
{
	public class MainViewModel : MvxViewModel
	{
		#region Commands

		private MvxCommand<MainItemVM> _itemSelectedCommand;
		public System.Windows.Input.ICommand ItemSelectedCommand
		{
			get
			{
				return _itemSelectedCommand ?? (_itemSelectedCommand = new MvxCommand<MainItemVM>(DoSelectItem));
			}
		}

		#endregion

		#region Properties

		private ObservableCollection<MainItemVM> _offers;
		public ObservableCollection<MainItemVM> Offers
		{
			get
			{
				return _offers;
			}
			set
			{
				_offers = value;
				RaisePropertyChanged(() => Offers);
			}
		}

		#endregion

		#region Services

		private IMainVMService _mainVmService
		{
			get
			{
				return Mvx.Resolve<IMainVMService>();
			}
		}

		#endregion

		#region Constructor

		public MainViewModel()
		{
			Offers = new ObservableCollection<MainItemVM>();
		}

		#endregion

		#region Private

		private async Task LoadContent()
		{
			var data = await _mainVmService.LoadData();

			Offers = new ObservableCollection<MainItemVM>(data);
		}

		private void DoSelectItem(MainItemVM item)
		{
			ShowViewModel<DetailViewModel>(item);
		}

		#endregion

		#region Public

		public override void Start()
		{
			LoadContent();
		}

		#endregion
	}
}
