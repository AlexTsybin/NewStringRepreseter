// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace NewStringRepresenter.Touch.Views.Detail
{
	[Register ("DetailViewController")]
	partial class DetailViewController
	{
		[Outlet]
		UIKit.UIImageView ImageContainer { get; set; }

		[Outlet]
		UIKit.UILabel MyLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ImageContainer != null) {
				ImageContainer.Dispose ();
				ImageContainer = null;
			}

			if (MyLabel != null) {
				MyLabel.Dispose ();
				MyLabel = null;
			}
		}
	}
}
