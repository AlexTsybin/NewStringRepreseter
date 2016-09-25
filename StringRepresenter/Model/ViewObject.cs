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

namespace StringRepresenter.Model
{
    public abstract class ViewObject
    {
        public int Id { get; private set; }

        public string Content { get; private set; }

        public ViewObject(int id, string content)
        {
            Id = id;
            Content = content;
        }
    }
}