using System;
namespace StringRepresenter.API
{
	public class CategoryId
	{
		public string Type { get; set;}
		public string Text { get; set;}

		public CategoryId(string text, string type)
		{
			Text = text;
			Type = type;
		}
	}
}
