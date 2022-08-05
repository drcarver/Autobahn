//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonDigitalAccessSpeedView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonDigitalAccessSpeedView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonDigitalAccessSpeedView : ContentPage
    {
        /// <summary>
        /// Inject the PersonDigitalAccessSpeedViewModel as the data context for the view
        /// </summary>
        public PersonDigitalAccessSpeedView(PersonDigitalAccessSpeedViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
