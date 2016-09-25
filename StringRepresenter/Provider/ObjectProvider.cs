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

namespace StringRepresenter.Provider
{
    public class ObjectProvider<T> where T : ViewObject
    {
        private readonly ClientModule<T> _mClientModule;

        public ObjectProvider()
        {
            _mClientModule = new ClientModule<T>();
        }
        
        public List<T> GetAmountOfObjects(int count)
        {
            return _mClientModule.GetAmountOfObjects(count);
        }
    }
}