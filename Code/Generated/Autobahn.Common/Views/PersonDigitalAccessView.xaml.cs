//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonDigitalAccessView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonDigitalAccessView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonDigitalAccessView : ContentPage
    {
        /// <summary>
        /// Inject the PersonDigitalAccessViewModel as the data context for the view
        /// </summary>
        public PersonDigitalAccessView(PersonDigitalAccessViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
