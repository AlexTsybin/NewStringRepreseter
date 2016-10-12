namespace StringRepresenter.Core.ViewModels.Main
{
	public class MainItemVM
	{
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
			}
		}


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
			}
		}
	}
}
