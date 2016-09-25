using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using StringRepresenter.Provider;
using StringRepresenter.Model;
using System.Linq;
using Android.Content;

namespace StringRepresenter
{
    

    [Activity(Label = "@string/ApplicationName", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private List<ViewObject> mItems;
        private ListView mListView;

        private ObjectProvider<CommonStringObject> mProvider = new ObjectProvider<CommonStringObject>();

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            mListView = FindViewById<ListView>(Resource.Id.myListView);

            // We can control the amount of displayed items
            mItems = mProvider.GetAmountOfObjects(20).Select(obj => (ViewObject)obj).ToList();

            // I created a new adapter for use with my string objects
            MyListViewAdapter myAdapter = new MyListViewAdapter(this, mItems);

            mListView.Adapter = myAdapter;

            mListView.ItemClick += MListView_ItemClick;
        }

        private void MListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var stringViewActivity = new Intent(this, typeof(StringViewActivity));
            stringViewActivity.PutExtra("SelectedLine", mItems[e.Position].Content);
            StartActivity(stringViewActivity);
        }
    }
}

