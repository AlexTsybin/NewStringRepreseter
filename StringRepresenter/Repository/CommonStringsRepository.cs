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
    public class CommonStringsRepository : Repository
    {
        private readonly IObjectGenerator _mGenerator;

        public CommonStringsRepository()
        {
            _mGenerator = new CommonStringGenerator();
        }

        public override List<ViewObject> GetAmountOfObjects(int count)
        {
            return GenerateNewObjects(count);
        }

        private List<ViewObject> GenerateNewObjects(int count)
        {
            for (int i = 0; i < count; i++)
            {
                mListOfViewObjects.Add(_mGenerator.Generate());   //Create new string object.
            }

            return mListOfViewObjects;
        }
    }
}
