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
using StringRepresenter.Repository;

namespace StringRepresenter
{
    public class ClientModule<T> where T : ViewObject
    {
        private readonly Repository.Repository _mRepository; // TODO: We can create a service for working with data, but now, for simplicity, it's local repository.

        public ClientModule()
        {
            if (typeof(T) == typeof(CommonStringObject))
            {
                _mRepository = new CommonStringsRepository();
            }
        }

        public List<T> GetAmountOfObjects(int count)
        {
            return _mRepository.GetAmountOfObjects(count).Select(obj => (T)obj).ToList();
        }
    }
}