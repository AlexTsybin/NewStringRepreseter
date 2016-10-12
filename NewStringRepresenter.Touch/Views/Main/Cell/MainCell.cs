using System;

using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using StringRepresenter.Core.ViewModels.Main;
using UIKit;

namespace NewStringRepresenter.Touch.Views.Main.Cell
{
	public partial class MainCell : MvxTableViewCell
	{
		public static readonly NSString Key = new NSString("MainCell");
		public static readonly UINib Nib = UINib.FromName("MainCell", NSBundle.MainBundle);

		public MainCell(IntPtr handle) : base(handle)
		{
			this.DelayBind(() =>
			{
				var imageLoader = new MvxImageViewLoader(() => this.Image);

				var set = this.CreateBindingSet<MainCell, MainItemVM>();
				set.Bind(Title).To(vm => vm.Title);	
				set.Bind(imageLoader).To(VM => VM.ImageUrl);
				set.Apply();
			});
		}
	}
}
