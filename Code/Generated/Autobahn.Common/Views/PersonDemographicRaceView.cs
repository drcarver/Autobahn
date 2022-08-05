//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonDemographicRaceView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonDemographicRaceView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonDemographicRaceView : ContentPage
    {
        /// <summary>
        /// Inject the PersonDemographicRaceViewModel as the data context for the view
        /// </summary>
        public PersonDemographicRaceView(PersonDemographicRaceViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
