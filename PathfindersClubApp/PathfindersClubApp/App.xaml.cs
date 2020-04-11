using Prism;
using Prism.Ioc;
using PathfindersClubApp.ViewModels;
using PathfindersClubApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PathfindersClubApp.Views.Units;
using PathfindersClubApp.ViewModels.Units;
using PathfindersClubApp.Views.Songs;
using PathfindersClubApp.ViewModels.Songs;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace PathfindersClubApp
{
    public partial class App
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }



        protected override async void OnInitialized()
        {
            InitializeComponent();
            #if DEBUG
                HotReloader.Current.Run(this);
            #endif
            await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();            
            containerRegistry.RegisterForNavigation<UnitListPage, UnitListPageViewModel>();
            containerRegistry.RegisterForNavigation<AboutClubPage, AboutClubPageViewModel>();
            containerRegistry.RegisterForNavigation<AllUnitsPage, AllUnitsPageViewModel>();
            containerRegistry.RegisterForNavigation<TestPage, TestPageViewModel>();            
            containerRegistry.RegisterForNavigation<TucanosUnitPage, TucanosUnitPageViewModel>();
            containerRegistry.RegisterForNavigation<PumasUnitPage, PumasUnitPageViewModel>();
            containerRegistry.RegisterForNavigation<TigresUnitPage, TigresUnitPageViewModel>();
            containerRegistry.RegisterForNavigation<AguiasUnitPage, AguiasUnitPageViewModel>();
            containerRegistry.RegisterForNavigation<CangurusUnitPage, CangurusUnitPageViewModel>();
            containerRegistry.RegisterForNavigation<FalcoesUnitPage, FalcoesUnitPageViewModel>();
            containerRegistry.RegisterForNavigation<SongListPage, SongListPageViewModel>();
            containerRegistry.RegisterForNavigation<CoracaoDeReiPage, CoracaoDeReiPageViewModel>();
            containerRegistry.RegisterForNavigation<HinoAtalaiaPage, HinoAtalaiaPageViewModel>();
            containerRegistry.RegisterForNavigation<HinoDesbravadoresPage, HinoDesbravadoresPageViewModel>();
            containerRegistry.RegisterForNavigation<DirectorsPage, DirectorsPageViewModel>();
            containerRegistry.RegisterForNavigation<NaoDesanimamos, NaoDesanimamosViewModel>();
            containerRegistry.RegisterForNavigation<NaoMaisEu, NaoMaisEuViewModel>();
            containerRegistry.RegisterForNavigation<EstouCantandoAlegre, EstouCantandoAlegreViewModel>();
            containerRegistry.RegisterForNavigation<QueroAcordarCantando, QueroAcordarCantandoViewModel>();
            containerRegistry.RegisterForNavigation<OhomemQueAndavaEmGalileia, OhomemQueAndavaEmGalileiaViewModel>();
            containerRegistry.RegisterForNavigation<VouCaminhando, VouCaminhandoViewModel>();
            containerRegistry.RegisterForNavigation<Sinto, SintoViewModel>();
        }
    }
}
