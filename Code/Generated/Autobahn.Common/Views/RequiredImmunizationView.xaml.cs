//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RequiredImmunizationView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The RequiredImmunizationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RequiredImmunizationView : ContentPage
    {
        /// <summary>
        /// Inject the RequiredImmunizationViewModel as the data context for the view
        /// </summary>
        public RequiredImmunizationView(RequiredImmunizationViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
