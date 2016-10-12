using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvvmCross.Platform.IoC;
using StringRepresenter.API.Services;
using StringRepresenter.API.Services.Implementations;

namespace StringRepresenter.Core
{
	public class App : MvxApplication
	{
		public override void Initialize()
		{
			CreatableTypes()
				.EndingWith("Service")
				.AsInterfaces()
				.RegisterAsLazySingleton();

			Mvx.RegisterSingleton<IConnectionService>(() => new ConnectionService());
			
			RegisterAppStart<ViewModels.Main.MainViewModel>();
		}
	}
}
