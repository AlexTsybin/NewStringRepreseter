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
using StringRepresenter.Model;

namespace StringRepresenter
{
    class MyListViewAdapter : BaseAdapter<ViewObject>
    {
        private List<ViewObject> mItems;
        private Context mContext;

        public MyListViewAdapter(Context context, List<ViewObject> items)
        {
            mContext = context;
            mItems = items;
        }

        public override ViewObject this[int position]
        {
            get
            {
                return mItems[position];
            }
        }

        public override int Count
        {
            get
            {
                return mItems.Count;
            }
        }

        public override long GetItemId(int position)
        {
            return mItems.ElementAt(position).Id;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;

            if (row == null)
            {
                row = LayoutInflater.From(mContext).Inflate(Resource.Layout.ListView_Row, null, false);
            }

            TextView txtLine = row.FindViewById<TextView>(Resource.Id.txtLine);

            txtLine.Text = mItems[position].Content;

            return row;
        }
    }
}