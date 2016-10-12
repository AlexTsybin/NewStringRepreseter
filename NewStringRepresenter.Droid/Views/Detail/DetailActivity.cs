using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace NewStringRepresenter.Droid.Views.Detail
{
	[Activity(Label = "@string/selected_view")]
	public class DetailActivity : MvxActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			SetContentView(Resource.Layout.Activity_Detail);
		}
	}
}
