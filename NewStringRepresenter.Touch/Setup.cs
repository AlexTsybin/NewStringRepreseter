﻿using System;
using MvvmCross.iOS.Platform;
using MvvmCross.iOS;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Views.Presenters;
using StringRepresenter.Core;

namespace NewStringRepresenter.Touch
{
	public class Setup : MvxIosSetup
	{
		public Setup(MvxApplicationDelegate applicationDelegate, IMvxIosViewPresenter presenter)
			: base(applicationDelegate, presenter)
		{
		}

		protected override IMvxApplication CreateApp()
		{
			return new App();
		}
	}
}
