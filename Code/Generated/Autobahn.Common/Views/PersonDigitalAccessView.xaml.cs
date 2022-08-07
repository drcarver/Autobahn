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
        /// Inject the IPersonDigitalAccessViewModel as the data context for the view
        /// </summary>
        public PersonDigitalAccessView(IPersonDigitalAccessViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
