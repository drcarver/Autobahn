//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonImmunizationView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonImmunizationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonImmunizationView : ContentPage
    {
        /// <summary>
        /// Inject the IPersonImmunizationViewModel as the data context for the view
        /// </summary>
        public PersonImmunizationView(IPersonImmunizationViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
