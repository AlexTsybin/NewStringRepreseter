using MvvmCross.Droid.Support.V7.RecyclerView.ItemTemplates;
using StringRepresenter.Core.ViewModels.Main;

namespace NewStringRepresenter.Droid.Views.Main
{
	public class MainTemplateSelector : MvxTemplateSelector<MainItemVM>
	{

		public override int GetItemLayoutId(int fromViewType)
		{
			return fromViewType;
		}

		protected override int SelectItemViewType(MainItemVM forItemObject)
		{
			return Resource.Layout.Page_Row;
		}
	}
}
