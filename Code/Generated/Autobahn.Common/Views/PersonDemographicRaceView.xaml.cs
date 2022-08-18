//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonDemographicRaceView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonDemographicRaceView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonDemographicRaceView : ContentPage
    {
        /// <summary>
        /// Inject the IPersonDemographicRace View Model as the data context for the view
        /// </summary>
        public PersonDemographicRaceView(Interfaces.IPersonDemographicRace vm)
        {
            BindingContext  = vm;
        }
    }
}
