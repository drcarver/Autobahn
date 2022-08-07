//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonDisabilityView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonDisabilityView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonDisabilityView : ContentPage
    {
        /// <summary>
        /// Inject the IPersonDisabilityViewModel as the data context for the view
        /// </summary>
        public PersonDisabilityView(IPersonDisabilityViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
