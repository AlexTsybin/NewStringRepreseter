using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.iOS.Views;
using StringRepresenter.Core.ViewModels.Detail;

namespace NewStringRepresenter.Touch.Views.Detail
{
	public partial class DetailViewController : MvxViewController<DetailViewModel>
	{
		public DetailViewController() : base("DetailViewController", null)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			var imageLoader = new MvxImageViewLoader(() => this.ImageContainer);

			var set = this.CreateBindingSet<DetailViewController, DetailViewModel>();
			set.Bind(MyLabel).To(vm => vm.Title);
			set.Bind(imageLoader).To(vm => vm.ImageUrl);
			set.Apply();
		}
	}
}

