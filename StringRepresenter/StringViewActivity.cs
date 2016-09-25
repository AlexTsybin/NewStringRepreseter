using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace StringRepresenter
{
    [Activity(Label = "@string/SelectedLineViewer")]
    public class StringViewActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.StringView);

            string textFromMainActivity = Intent.GetStringExtra("SelectedLine") ?? "Data not available";

            TextView stringViewer = FindViewById<TextView>(Resource.Id.myStringViewer);

            stringViewer.Text = textFromMainActivity;
        }
    }
}