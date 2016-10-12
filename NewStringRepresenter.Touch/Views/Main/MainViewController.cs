using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.iOS.Views;
using NewStringRepresenter.Touch.Views.Main.Cell;
using StringRepresenter.Core.ViewModels.Main;
using UIKit;

namespace NewStringRepresenter.Touch.Views.Main
{
	public partial class MainViewController : MvxViewController<MainViewModel>
	{
		public MainViewController() : base("MainViewController", null)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			var source = new MvxSimpleTableViewSource(TableView, MainCell.Key, MainCell.Key);

			var set = this.CreateBindingSet<MainViewController, MainViewModel>();
			set.Bind(source).To(vm => vm.Offers);
			set.Bind(source).For(s => s.SelectionChangedCommand).To(vm => vm.ItemSelectedCommand);
			set.Apply();

			TableView.RowHeight = UITableView.AutomaticDimension;
			TableView.EstimatedRowHeight = 135f;
			TableView.Source = source;
			TableView.ReloadData();
		}
	}
}

