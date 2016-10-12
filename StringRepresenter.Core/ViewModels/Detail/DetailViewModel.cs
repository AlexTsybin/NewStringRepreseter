using System;
using MvvmCross.Core.ViewModels;
using StringRepresenter.Core.ViewModels.Main;

namespace StringRepresenter.Core.ViewModels.Detail
{
	public class DetailViewModel : MvxViewModel
	{
		#region Properties

		private string _title;
		public string Title
		{
			get
			{
				return _title;
			}
			set
			{
				_title = value;
				RaisePropertyChanged(() => Title);
			}
		}

		private string _imageUrl;
		public string ImageUrl
		{
			get
			{
				return _imageUrl;
			}
			set
			{
				_imageUrl = value;
				RaisePropertyChanged(() => ImageUrl);
			}
		}

		private int _id;
		public int Id
		{
			get
			{
				return _id;
			}
			set
			{
				_id = value;
				RaisePropertyChanged(() => Id);
			}
		}

		#endregion

		#region Fields

		private MainItemVM _item;

		#endregion

		#region Public

		public void Init(MainItemVM item)
		{
			_item = item;
			Title = _item.Title;
			ImageUrl = _item.ImageUrl;
			Id = _item.Id;
		}

		#endregion
	}
}
