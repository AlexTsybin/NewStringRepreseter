using Android.App;
using Android.OS;
using Android.Support.V7.Widget;
using MvvmCross.Droid.Support.V7.RecyclerView;
using MvvmCross.Droid.Views;

namespace NewStringRepresenter.Droid.Views.Main
{
	[Activity(Label = "Xml Viewer", MainLauncher = true)]
	public class MainActivity : MvxActivity
	{
		LinearLayoutManager mManager;

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			SetContentView(Resource.Layout.Activity_Main);

			var petList = FindViewById<MvxRecyclerView>(Resource.Id.recyclerView);

			mManager = new LinearLayoutManager(this);

			petList.SetLayoutManager(mManager);
			petList.ItemTemplateSelector = new MainTemplateSelector();
		}
	}
}
