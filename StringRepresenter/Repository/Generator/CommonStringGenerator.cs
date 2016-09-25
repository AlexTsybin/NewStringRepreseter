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

namespace StringRepresenter.Repository.Generator
{
    public class CommonStringGenerator : IObjectGenerator
    {
        public ViewObject Generate()
        {
            return new CommonStringObject(IdCreator.CreateId(), StringCreator.Create());
        }
    }
}