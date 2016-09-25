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
using StringRepresenter.Repository.Generator;

namespace StringRepresenter.Repository
{
    public abstract class Repository
    {
        protected List<ViewObject> mListOfViewObjects;

        public abstract List<ViewObject> GetAmountOfObjects(int count);

        public Repository()
        {
            mListOfViewObjects = new List<ViewObject>();
        }
    }
}